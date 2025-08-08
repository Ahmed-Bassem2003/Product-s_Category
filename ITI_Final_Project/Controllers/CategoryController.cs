using ITI_Final_Project.Context;
using ITI_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI_Final_Project.Controllers
{
    public class CategoryController : Controller
    {
        CompanyContext db = new CompanyContext();
        
        [HttpGet]
        public IActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var categories = db.Categories.Find(id);
            if (categories == null)
            {
                return RedirectToAction("Index");
            }
            return View(categories);
        }
        /*------------------------------------------------------------------*/
        // Create - Get Method To Show The View That Contain Form 
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        public IActionResult Create(Category department)
        {
            db.Categories.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cat = db.Categories.Find(id);
            if (cat == null)
            {
                return RedirectToAction("Index");
            }
            return View(cat);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var existingCategory = db.Categories.Find(category.CatId);
            if (existingCategory == null)
            {
                return RedirectToAction("Index");
            }

            existingCategory.CatName = category.CatName;
            existingCategory.CatDes = category.CatDes;
            // Add more properties if needed

            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var dept = db.Categories.Find(id);
            if (dept == null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(dept);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
