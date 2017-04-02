using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Greer_P1.Models
{
    public class ProductsInCategoryViewModel
    {
        public List<tblCategory> Categories;
        public tblCategory ChosenCategory;
        public List<tblInventory> InventoryInCategory;
    }
}