//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Greer_P1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        public string fldEmail { get; set; }
        public string fldLastName { get; set; }
        public string fldFirstName { get; set; }
        public string fldCity { get; set; }
        public string fldState { get; set; }
        public string fldZipCode { get; set; }
        public string fldPhoneNumber { get; set; }
        public string fldAddress { get; set; }
    
        public virtual tblState tblState { get; set; }
    }
}