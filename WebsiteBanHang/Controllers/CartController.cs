using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanHang.Data;
using WebsiteBanHang.Models;
using WebsiteBanHang.Services;

namespace WebsiteBanHang.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;

        public CartController(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }

        const string SessionCart = "Cart";
        public IActionResult Index()
        {                
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(OrderViewModel order)
        {
            if (ModelState.IsValid)
            {
                var session = HttpContext.Session.GetString(SessionCart);
                List<CartItemViewModel> cart = new List<CartItemViewModel>();
                if (session != null)
                {
                    cart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
                }
                var total = 0;
                List<OrderDetail> orderDetails = new List<OrderDetail>();
                foreach (var item in cart)
                {
                    total += item.Quantity * Convert.ToInt32(item.Price);
                    var detail = new OrderDetail();
                    detail.ProductId = item.ProductId;
                    detail.Price = item.Price;
                    detail.Quantity = item.Quantity;
                    detail.CreatedDate = DateTime.Now;
                    orderDetails.Add(detail);
                }
                var orderNew = new Order();
                orderNew.OrderName = order.OrderName;
                orderNew.OrderEmail = order.OrderEmail;
                orderNew.OrderPhone = Convert.ToInt32(order.OrderPhone);
                orderNew.OrderAddress = order.OrderAddress;
                orderNew.OrderNote = order.OrderNote;
                orderNew.CreatedDate = DateTime.Now;
                orderNew.PaymentStatus = 0;
                orderNew.TotalMoney = Convert.ToDecimal(total);

                var result=await _orderService.Create(orderNew, orderDetails);
                if (result)
                {
                    List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
                    HttpContext.Session.SetString(SessionCart, JsonConvert.SerializeObject(currentCart));
                }
                return Redirect("/cart/CheckoutSuccess");
            }
            return View(order);
        }

        public IActionResult CheckoutSuccess()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SessionCart);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            return Ok(currentCart);
        }

        public async Task<IActionResult> AddToCart(long id)
        {
            var session = HttpContext.Session.GetString(SessionCart);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            if (currentCart.Any(x => x.ProductId == id))
            {
                foreach (var item in currentCart)
                {
                    if (item.ProductId == id)
                    {
                        item.Quantity += 1;
                    }
                }
            }
            else
            {
                CartItemViewModel newItem = new CartItemViewModel();
                newItem.ProductId = id;
                var product = await _productService.Detail(id);
                newItem.Logo = product.Logo;
                newItem.Name = product.Name;
                if (product.PriceDiscount != null)
                {
                    newItem.Price = product.PriceDiscount;
                }
                else
                {
                    newItem.Price = product.Price;
                }             
                newItem.Quantity = 1;
                currentCart.Add(newItem);
            }

            HttpContext.Session.SetString(SessionCart, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SessionCart);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }

            HttpContext.Session.SetString(SessionCart, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }   
    }
}
