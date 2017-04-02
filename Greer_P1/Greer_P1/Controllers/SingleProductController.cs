using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greer_P1.Models;

namespace Greer_P1.Controllers
{
    public class SingleProductController : Controller
    {     
            List<tblInventory> inventory = new List<tblInventory>();

            public SingleProductController()
            {
                Project_4Entities db = new Project_4Entities();

                inventory = db.tblInventories
                    .OrderBy(m => m.fldProductName)
                    .ToList();
            }

            // GET: ProductsInCategory
            public ActionResult Index()
            {
                SingleProductViewModel viewModel = new SingleProductViewModel();

                viewModel.Inventory = inventory;

                return View(viewModel);
            }
            [HttpPost]
            public ActionResult Index(string ProductSelect)
            {
                Project_4Entities db = new Project_4Entities();

                var inventoryDetails = db.tblInventories
                    .Where(m => m.fldProductSKU == ProductSelect)
                    .ToList();

                SingleProductViewModel viewModel = new SingleProductViewModel();

                viewModel.Inventory = inventory;
                viewModel.ChosenInventory = inventory.Find(c => c.fldProductSKU == ProductSelect);
                viewModel.InventoryDetails = inventoryDetails;


                return View("InventoryDetails", viewModel);
            }
        }
    }
