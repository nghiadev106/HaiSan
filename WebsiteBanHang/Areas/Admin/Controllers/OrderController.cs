using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebsiteBanHang.Areas.Admin.Models.Order;
using WebsiteBanHang.Services;

namespace WebsiteBanHang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var lstOrder = await _orderService.GetAll();
            ViewBag.ListOrder = lstOrder;
            return View();
        }

        public async Task<IActionResult> Detail(long id)
        {
            var order =await  _orderService.GetDetail(id);
            ViewBag.order = order;
            var orderDetails = await _orderService.GetOrderDetail(id);
            ViewBag.orderDetails = orderDetails;
            return View();
        }

        public async Task<IActionResult> Delete(long id)
        {
            var model = await _orderService.GetDetail(id);
            if (model == null)
            {
                TempData["warning"] = "Hóa đơn không tồn tại";
                return RedirectToAction("Index");
            }
            var result = await _orderService.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa hóa đơn thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa hóa đơn thất bại";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeStatus(StatusRequest request)
        {
            var result = await _orderService.ChangeStatus(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật trạng thái đơn hàng thành công";
                return RedirectToAction("Detail", new { id = request.Id });
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật trạng thái đơn hàng thất bại");
                TempData["error"] = "Cập nhật trạng thái đơn hàng thất bại";
                return RedirectToAction("Detail", new { id = request.Id });
            }
        }
    }
}
