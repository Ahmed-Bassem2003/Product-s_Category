using ITI_Final_Project.Context;
using ITI_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ITI_Final_Project.Controllers
{
    public class ProductController : Controller
    {
        CompanyContext db = new CompanyContext();
  
        [HttpGet]
        public IActionResult Index()
        {
            var product = db.Products.Include(e=>e.Category);
            return View(product);
        }
      
        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = db.Products.Include(e => e.Category).FirstOrDefault(e => e.ProdId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag._Categories = new SelectList(db.Categories, "CatId", "CatName");
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var products = db.Products.FirstOrDefault(e => e.Title == product.Title);
            if (products != null)
            {
                ModelState.AddModelError("", "Title Already Exist");
                ViewBag._Categories = new SelectList(db.Categories, "CatId", "CatName");
                return View();
            }

            
            ModelState.Remove("Category");
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "All Fields required");
            ViewBag._Categories = new SelectList(db.Categories, "CatId", "CatName");
            return View();
        }
        /*------------------------------------------------------------------*/
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var product = db.Products.Include(e => e.Category).FirstOrDefault(e => e.ProdId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag._Categories = new SelectList(db.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }
       
      
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ModelState.Remove("Category");
            if (product != null && ModelState.IsValid)
            {
                var existingProduct = db.Products.FirstOrDefault(p => p.ProdId == product.ProdId);
                if (existingProduct == null)
                {
                    return RedirectToAction("Index");
                }

                
                existingProduct.Title = product.Title;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
                existingProduct.Quantity = product.Quantity;
                existingProduct.ImagePath = product.ImagePath;
                existingProduct.CatId = product.CatId;
               

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag._Categories = new SelectList(db.Categories, "CatId", "CatName");
            return View(product);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
