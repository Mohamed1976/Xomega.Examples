//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;

namespace AdventureWorks.Services.Entities
{
    ///<summary>
    /// Customers (resellers) of Adventure Works products.
    ///</summary>
    public partial class Store
    {
        public Store()
        {
        }

        #region Properties

        public int BusinessEntityId  { get; set; }

        ///<summary>
        /// Name of the store.
        ///</summary>
        public string Name  { get; set; }

        ///<summary>
        /// ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        ///</summary>
        public int? SalesPersonId  { get; set; }

        ///<summary>
        /// Demographic informationg about the store such as the number of employees, annual sales and store type.
        ///</summary>
        public string Demographics  { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public Guid Rowguid  { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate  { get; set; }

        #endregion

        #region Navigation Properties

        ///<summary>
        /// BusinessEntity object referenced by the field BusinessEntityId.
        ///</summary>
        public virtual BusinessEntity BusinessEntityObject { get; set; }

        ///<summary>
        /// SalesPerson object referenced by the field SalesPersonId.
        ///</summary>
        public virtual SalesPerson SalesPersonObject { get; set; }

        #endregion
    }
}