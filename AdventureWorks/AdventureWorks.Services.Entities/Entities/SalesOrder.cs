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
    
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            this.DetailObjectList = new HashSet<SalesOrderDetail>();
            this.ReasonObjectList = new HashSet<SalesOrderReason>();
        }
    
        public int SalesOrderId { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public byte Status { get; set; }
        public bool OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Customer CustomerIdObject { get; set; }
        public virtual SalesPerson SalesPersonIdObject { get; set; }
        public virtual SalesTerritory TerritoryIdObject { get; set; }
        public virtual Address BillToAddressIdObject { get; set; }
        public virtual Address ShipToAddressIdObject { get; set; }
        public virtual ShipMethod ShipMethodIdObject { get; set; }
        public virtual CreditCard CreditCardIdObject { get; set; }
        public virtual CurrencyRate CurrencyRateIdObject { get; set; }
        public virtual ICollection<SalesOrderDetail> DetailObjectList { get; set; }
        public virtual ICollection<SalesOrderReason> ReasonObjectList { get; set; }
    }
}
