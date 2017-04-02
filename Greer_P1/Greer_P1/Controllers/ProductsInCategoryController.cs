using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greer_P1.Models;

namespace Greer_P1.Controllers
{
    public class ProductsInCategoryController : Controller
    {
        List<tblCategory> categories = new List<tblCategory>();

        List<tblInventory> inventory = new List<tblInventory>();

        public ProductsInCategoryController()
        {
            Project_4Entities db = new Project_4Entities();

            categories = db.tblCategories
                .OrderBy(m => m.fldCatagoryName)
                .ToList();

            inventory = db.tblInventories.ToList();
        }

        // GET: ProductsInCategory
        public ActionResult Index()
        {
            ProductsInCategoryViewModel viewModel = new ProductsInCategoryViewModel();

            viewModel.Categories = categories;

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(int categoriesSelect)
        {
            Project_4Entities db = new Project_4Entities();

            var productsInCategory = db.tblInventories
                .Where(m => m.fldCatagoryID == categoriesSelect)
                .OrderBy(m => m.fldProductName)
                .ToList();

            ProductsInCategoryViewModel viewModel = new ProductsInCategoryViewModel();

            viewModel.Categories = categories;
            viewModel.ChosenCategory = categories.Find(c => c.fldCatagoryID == categoriesSelect);
            viewModel.InventoryInCategory = productsInCategory;


            return View("SelectedInventory", viewModel);
        }
    }
}