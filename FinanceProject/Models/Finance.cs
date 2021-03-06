//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finance
    {
        public int FinanceID { get; set; }
        public string Email { get; set; }
        public int Months { get; set; }
        public decimal EmiAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public System.DateTime purchaseDate { get; set; }
        public int ProductID { get; set; }
        public Nullable<System.DateTime> LastPaymentDate { get; set; }
    
        public  UserTable UserTable { get; set; }
        public  Product Product { get; set; }
    }
}
