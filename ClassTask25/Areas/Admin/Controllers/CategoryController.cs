using ClassTask25.DAL;
using ClassTask25.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassTask25.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class CategoryController : Controller
    {
        AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
    }
}
