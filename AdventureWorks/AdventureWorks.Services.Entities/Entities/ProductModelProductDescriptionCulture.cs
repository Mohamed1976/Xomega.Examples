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
    
    public partial class ProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; }
        public int ProductDescriptionId { get; set; }
        public string CultureId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ProductModel ProductModelIdObject { get; set; }
        public virtual ProductDescription ProductDescriptionIdObject { get; set; }
        public virtual Culture CultureIdObject { get; set; }
    }
}
