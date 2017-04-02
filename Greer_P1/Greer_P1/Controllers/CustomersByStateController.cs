using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greer_P1.Models;

namespace Greer_P1.Controllers
{
    public class CustomersByStateController : Controller
    {
            List<tblState> states = new List<tblState>();

            List<tblCustomer> customers = new List<tblCustomer>();

            public CustomersByStateController()
            {
                Project_4Entities db = new Project_4Entities();

                states = db.tblStates
                    .OrderBy(m => m.fldStateName)
                    .ToList();

                customers = db.tblCustomers.ToList();
            }

            // GET: ProductsInCategory
            public ActionResult Index()
            {
                CustomersByStateViewModel viewModel = new CustomersByStateViewModel();

                viewModel.States = states;

                return View(viewModel);
            }
            [HttpPost]
            public ActionResult Index(string stateSelect)
            {
                Project_4Entities db = new Project_4Entities();

                var customersInState = db.tblCustomers
                    .Where(m => m.fldState == stateSelect)
                    .OrderBy(m => m.fldFirstName)
                    .ToList();

                CustomersByStateViewModel viewModel = new CustomersByStateViewModel();

                viewModel.States = states;
                viewModel.ChosenState = states.Find(c => c.fldStateCode == stateSelect);
                viewModel.CustomersInState = customersInState;


                return View("SelectedCustomers", viewModel);
            }
        }
    }