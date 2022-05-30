using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanHang.Data;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly HaiSanContext _context;


        public HomeController(HaiSanContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //Ds slide
            ViewBag.ListSlides = await _context.Slides.Where(a =>a.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            //Ds chuyên mục
            ViewBag.ListCategories =await _context.Categories.Where(a => a.ShowHome == true && a.Status == 1).OrderBy(x => x.DisplayOrder).ToListAsync();
            ViewBag.ListProductsPromotion = await _context.Products.Where(a => a.PriceDiscount != null && a.DisplayOrder != null && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(12).ToListAsync();
            ViewBag.DsCa = await _context.Products.Where(a => a.CategoryId == 34 && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(8).ToListAsync();
            ViewBag.DsTom = await _context.Products.Where(a => a.CategoryId == 35 && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(8).ToListAsync();
            ViewBag.DsMuc = await _context.Products.Where(a => a.CategoryId == 36 && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(8).ToListAsync();
            ViewBag.DsOc = await _context.Products.Where(a => a.CategoryId == 37 && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(8).ToListAsync();
            ViewBag.DsCua = await _context.Products.Where(a => a.CategoryId == 38 && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(8).ToListAsync();
        
            return View();
        }

        public async Task<IActionResult> ProductCategories(long id,string sort)
        {
            var category = await _context.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            var ListProductCategories =  await _context.Products.Where(x => x.CategoryId == id && x.Status == 1).ToListAsync();
            if (sort == "asc")
            {
                ListProductCategories=ListProductCategories.OrderBy(x => x.PriceDiscount).ToList();
            }
            else if(sort=="desc")
            {
                ListProductCategories=ListProductCategories.OrderByDescending(x => x.PriceDiscount).ToList();
            }
            ViewBag.ListProductCategories = ListProductCategories;
            return View(category);
        }

        public IActionResult PolicyAndTerms()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
