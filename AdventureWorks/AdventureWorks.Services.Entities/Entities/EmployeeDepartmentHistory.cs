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
    
    public partial class EmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; }
        public System.DateTime StartDate { get; set; }
        public short DepartmentId { get; set; }
        public byte ShiftId { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Employee BusinessEntityIdObject { get; set; }
        public virtual Department DepartmentIdObject { get; set; }
        public virtual Shift ShiftIdObject { get; set; }
    }
}
