using ClassTask25.DAL;
using ClassTask25.Models;
using ClassTask25.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClassTask25.Controllers
{
    public class HomeController:Controller
    {
        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Product> products = _context.Products.ToList();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                Products = products
            };


            return View(homeVM);

        }
    }
}
