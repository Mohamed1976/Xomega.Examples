//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Xomega Data Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using System;
using Xomega.Framework;
using Xomega.Framework.Properties;

namespace AdventureWorks.Client.Objects
{
    public partial class SalesOrderSalesObject : DataObject
    {
        #region Constants

        public const string SalesPersonId = "SalesPersonId";
        public const string SalesReason = "SalesReason";
        public const string TerritoryId = "TerritoryId";

        #endregion

        #region Properties

        public EnumIntProperty SalesPersonIdProperty { get; private set; }
        public EnumIntProperty SalesReasonProperty { get; private set; }
        public EnumIntProperty TerritoryIdProperty { get; private set; }

        #endregion

        #region Construction

        public SalesOrderSalesObject()
        {
        }

        public SalesOrderSalesObject(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void Initialize()
        {
            SalesPersonIdProperty = new EnumIntProperty(this, SalesPersonId);
            SalesPersonIdProperty.EnumType = "sales person";
            SalesReasonProperty = new EnumIntProperty(this, SalesReason);
            SalesReasonProperty.IsMultiValued = true;
            SalesReasonProperty.Size = 10;
            SalesReasonProperty.EnumType = "sales reason";
            TerritoryIdProperty = new EnumIntProperty(this, TerritoryId);
            TerritoryIdProperty.Size = 10;
            TerritoryIdProperty.EnumType = "sales territory";
        }

        #endregion
    }
}