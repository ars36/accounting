//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderModel
    {
        public int OrderID { get; set; }
        public int MobileID { get; set; }
        public string MobileModel { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual MobileModel MobileModel1 { get; set; }
    }
}
