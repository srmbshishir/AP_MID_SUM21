using Lecture5.Models;
using Lecture5.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture5.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Login()
        {
            Admin a = new Admin();
            return View(a);
        }

        [HttpPost]
        public ActionResult Login(Admin a)
        {
            Database db = new Database();
            int x = db.Products.Validate(a);

            if (x == 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Incorrect Username/Password";
                return View();
            }
        }
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.Products.GetAll();
            return View(products);
        }

        public ActionResult Create() 
        {
            Product p = new Product();
            return View(p);
        }
        [HttpPost]
        public ActionResult Create(Product p) {
            //insert to db
            if (ModelState.IsValid) {
                Database db = new Database();
                db.Products.Insert(p);
                return RedirectToAction("Index");
            }
            return View();
           
        }
        public ActionResult Edit(string id) {

            Database db = new Database();
            var p = db.Products.Get(id);

            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            //update to db
            Database db = new Database();
            db.Products.Update(p);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            Database db = new Database();
            var p = db.Products.Get(id);

            return View(p);
        }
        [HttpPost]
        public ActionResult Delete(Product p)
        {
            //update to db
            Database db = new Database();
            db.Products.Delete(p);
            return RedirectToAction("Index");
        }

    }
}