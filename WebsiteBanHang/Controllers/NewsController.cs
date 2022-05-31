using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanHang.Data;

namespace WebsiteBanHang.Controllers
{
    public class NewsController : Controller
    {
        private readonly HaiSanContext _context;

        public NewsController(HaiSanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.listNews = _context.News.Where(x => x.Status == 1).OrderBy(x => x.CreateDate).ToList();
            ViewBag.categories = _context.CategoriesNews.Where(x => x.Status == 1).OrderBy(x => x.CreateDate).ToList();
            return View();
        }

        public IActionResult Category(int id)
        {
            ViewBag.listNews = _context.News.Where(x => x.Status == 1 && x.CategoryId==id).OrderBy(x => x.CreateDate).ToList();
            ViewBag.categories = _context.CategoriesNews.Where(x => x.Status == 1).OrderBy(x => x.CreateDate).ToList();
            ViewBag.cate = _context.CategoriesNews.Where(x => x.Status == 1 && x.Id == id).SingleOrDefault();
            return View();
        }

        public IActionResult Detail(int id)
        {
            var news = _context.News.Where(x => x.Status == 1 && x.Id==id).SingleOrDefault();
            ViewBag.related =  _context.News.Where(x => x.CategoryId == news.CategoryId && x.Id != id && x.Status == 1).OrderBy(x => x.DisplayOrder).Take(12).ToList();
            return View(news);
        }
    }
}
