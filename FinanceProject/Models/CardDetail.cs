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
    
    public partial class CardDetail
    {
        public long CardNumber { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public decimal CurrentLimit { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTill { get; set; }

        public int CVV { get; set; }
    
        public  UserTable UserTable { get; set; }
        public  CardType CardType { get; set; }
    }
}
