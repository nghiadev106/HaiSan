using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanHang.Data;

namespace WebsiteBanHang.Controllers
{
    public class BlogsController : Controller
    {
        private readonly HaiSanContext _context;

        public BlogsController(HaiSanContext context)
        {      
            _context = context;
        }
        public async Task<IActionResult> ListBlogs()
        {
            ViewBag.ListBlog = await _context.News.Where(x => x.Status == 1).OrderBy(x => x.DisplayOrder).Take(12).ToListAsync();
            return View();
        }

        public async Task<IActionResult> DetailBlog(long id)
        {
            var blog = await _context.News.Where(x => x.Status == 1&& x.Id==id).SingleOrDefaultAsync();
            return View(blog);
        }
    }
}
