using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanHang.Areas.Admin.Models.Order;
using WebsiteBanHang.Data;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetAll();
        Task<Order> GetDetail(long orderId);
        Task<List<OrderDetailViewModel>> GetOrderDetail(long orderId);
        Task<bool> Create(Order order, List<OrderDetail> orderDetails);
        Task<int> Delete(long id);
        Task<int> ChangeStatus(StatusRequest request);
    }
    public class OrderService: IOrderService
    {
        private readonly HaiSanContext _context;

        public OrderService(HaiSanContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(Order order, List<OrderDetail> orderDetails)
        {
            try
            {
                var result= _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                foreach (var orderDetail in orderDetails)
                {
                    orderDetail.OrderId = order.Id;
                    _context.OrderDetails.Add(orderDetail);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Order> GetDetail(long orderId)
        {
            var query =await _context.Orders.Where(x => x.Id == orderId).SingleOrDefaultAsync();
            return query;
        }

        public async Task<List<OrderDetailViewModel>> GetOrderDetail(long orderId)
        {
            var model = from od in _context.OrderDetails
                        join p in _context.Products on od.ProductId equals p.Id
                        where od.OrderId==orderId
                        select new OrderDetailViewModel
                        {
                            ProductName = p.Name,
                            Logo = p.Logo,
                            Price = p.Price,
                            PriceDiscount = od.Price,
                            Quantity = od.Quantity
                        };
            return await model.ToListAsync();
        }

        public async Task<List<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<int> ChangeStatus(StatusRequest request)
        {
            try
            {
                Order order = await _context.Orders.FindAsync(request.Id);
                if (order == null) return -1;
                order.PaymentStatus = request.PaymentStatus;
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<int> Delete(long id)
        {
            try
            {
                var orderDetails = await _context.OrderDetails.Where(x => x.OrderId == id).ToListAsync();
                if (orderDetails.Count() > 0)
                {
                    foreach(var item in orderDetails)
                    {
                        var detail = await _context.OrderDetails.Where(x => x.Id == item.Id).SingleOrDefaultAsync();
                        _context.OrderDetails.Remove(detail);
                    }
                    await _context.SaveChangesAsync();
                }
                var order = await _context.Orders.FindAsync(id);
                if (order == null) return -1;
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
