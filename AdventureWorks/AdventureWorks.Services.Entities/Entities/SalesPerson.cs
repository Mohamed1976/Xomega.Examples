//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorks.Services.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesPerson
    {
        public int BusinessEntityId { get; set; }
        public Nullable<decimal> SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Employee BusinessEntityIdObject { get; set; }
        public virtual SalesTerritory TerritoryIdObject { get; set; }
    }
}
