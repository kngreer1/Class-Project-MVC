using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Greer_P1.Models
{
    public class CustomersByStateViewModel
    {
        public List<tblState> States;
        public tblState ChosenState;
        public List<tblCustomer> CustomersInState;
    }
}