using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Greer_P1.Models
{
    public class SingleProductViewModel
    {
        public List<tblInventory> Inventory;
        public tblInventory ChosenInventory;
        public List<tblInventory> InventoryDetails;
    }
}