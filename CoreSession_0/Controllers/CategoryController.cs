using CoreSession_0.ExtensionMethods;
using CoreSession_0.Models.ContextClasses;
using CoreSession_0.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreSession_0.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult GetCategories()
        {
            return View(_db.Categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }


        public IActionResult UpdateCategory(int id)
        {
            return View(_db.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            Category original = _db.Categories.Find(category.CategoryId);

            original.CategoryName = category.CategoryName;
            original.Description = category.Description;
            _db.SaveChanges();
            return RedirectToAction("GetCategories");


        }

        public IActionResult DeleteCategory(int id)
        {
           
           

            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }


        public IActionResult CreateSession(int id)
        {
            Category c = _db.Categories.Find(id);
            HttpContext.Session.SetObject("cagri", c); //setobject, extension metodun ismi.
            return View();
        }
    }
}
