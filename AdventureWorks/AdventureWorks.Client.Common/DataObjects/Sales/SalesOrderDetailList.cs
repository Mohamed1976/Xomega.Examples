//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Xomega Data Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Xomega.Framework;
using Xomega.Framework.Properties;

namespace AdventureWorks.Client.Objects
{
    public partial class SalesOrderDetailList : DataListObject
    {
        #region Constants

        public const string CarrierTrackingNumber = "CarrierTrackingNumber";
        public const string LineTotal = "LineTotal";
        public const string OrderQty = "OrderQty";
        public const string Product = "Product";
        public const string SalesOrderDetailId = "SalesOrderDetailId";
        public const string SpecialOffer = "SpecialOffer";
        public const string UnitPrice = "UnitPrice";
        public const string UnitPriceDiscount = "UnitPriceDiscount";

        #endregion

        #region Properties

        public TextProperty CarrierTrackingNumberProperty { get; private set; }
        public MoneyProperty LineTotalProperty { get; private set; }
        public SmallIntegerProperty OrderQtyProperty { get; private set; }
        public EnumIntProperty ProductProperty { get; private set; }
        public IntegerKeyProperty SalesOrderDetailIdProperty { get; private set; }
        public EnumIntProperty SpecialOfferProperty { get; private set; }
        public MoneyProperty UnitPriceProperty { get; private set; }
        public MoneyProperty UnitPriceDiscountProperty { get; private set; }

        #endregion

        #region Construction

        public SalesOrderDetailList()
        {
        }

        public SalesOrderDetailList(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void Initialize()
        {
            CarrierTrackingNumberProperty = new TextProperty(this, CarrierTrackingNumber);
            CarrierTrackingNumberProperty.Size = 25;
            CarrierTrackingNumberProperty.Editable = false;
            LineTotalProperty = new MoneyProperty(this, LineTotal);
            LineTotalProperty.Required = true;
            LineTotalProperty.Editable = false;
            OrderQtyProperty = new SmallIntegerProperty(this, OrderQty);
            OrderQtyProperty.Required = true;
            OrderQtyProperty.Editable = false;
            ProductProperty = new EnumIntProperty(this, Product);
            ProductProperty.Required = true;
            ProductProperty.Size = 10;
            ProductProperty.EnumType = "product";
            ProductProperty.Editable = false;
            SalesOrderDetailIdProperty = new IntegerKeyProperty(this, SalesOrderDetailId);
            SalesOrderDetailIdProperty.Required = true;
            SalesOrderDetailIdProperty.Editable = false;
            SpecialOfferProperty = new EnumIntProperty(this, SpecialOffer);
            SpecialOfferProperty.Required = true;
            SpecialOfferProperty.Size = 10;
            SpecialOfferProperty.EnumType = "special offer";
            SpecialOfferProperty.Editable = false;
            UnitPriceProperty = new MoneyProperty(this, UnitPrice);
            UnitPriceProperty.Required = true;
            UnitPriceProperty.Editable = false;
            UnitPriceDiscountProperty = new MoneyProperty(this, UnitPriceDiscount);
            UnitPriceDiscountProperty.Required = true;
            UnitPriceDiscountProperty.Editable = false;
        }

        #endregion

        #region CRUD Operations

        protected override void DoRead(object options)
        {
            SalesOrder_Detail_ReadList(
                Parent == null ? default(int) : (int)(Parent as SalesOrderObject).SalesOrderIdProperty.TransportValue, options);
        }

        #endregion

        #region Service Operations

        protected virtual void SalesOrder_Detail_ReadList(int _salesOrderId, object options)
        {
            using (var s = ServiceProvider.CreateScope())
            {
                IEnumerable<SalesOrderDetail_ReadListOutput> output = s.ServiceProvider.GetService<ISalesOrderService>().Detail_ReadList(_salesOrderId);
                FromDataContract(output, options);
            }
        }

        #endregion
    }
}