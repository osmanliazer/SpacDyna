using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpacDyna.DAL;
using SpacDyna.Models;
using SpacDyna.ViewModels;
using SpacDyna.ViewModels.Category;

namespace SpacDyna.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly SpacContext _context;

        public CategoryController(SpacContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
        public async IActionResult Create()
        {
            CreateCategoryVM  productVM=new CreateCategoryVM();
            {
                Categories=await _context.Categories.ToListAsync();
            }
            return View();
        }
    }
}
