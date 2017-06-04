//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Xomega Data Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xomega.Framework;
using Xomega.Framework.Properties;

namespace AdventureWorks.Client.Objects
{
    public partial class SalesOrderDetailObject : DataObject
    {
        #region Constants

        public const string CarrierTrackingNumber = "CarrierTrackingNumber";
        public const string LineTotal = "LineTotal";
        public const string ModifiedDate = "ModifiedDate";
        public const string OrderQty = "OrderQty";
        public const string ProductId = "ProductId";
        public const string Rowguid = "Rowguid";
        public const string SalesOrderDetailId = "SalesOrderDetailId";
        public const string SalesOrderId = "SalesOrderId";
        public const string SpecialOfferId = "SpecialOfferId";
        public const string UnitPrice = "UnitPrice";
        public const string UnitPriceDiscount = "UnitPriceDiscount";

        #endregion

        #region Properties

        public TextProperty CarrierTrackingNumberProperty { get; private set; }
        public MoneyProperty LineTotalProperty { get; private set; }
        public DateTimeProperty ModifiedDateProperty { get; private set; }
        public SmallIntegerProperty OrderQtyProperty { get; private set; }
        public EnumIntProperty ProductIdProperty { get; private set; }
        public GuidProperty RowguidProperty { get; private set; }
        public IntegerKeyProperty SalesOrderDetailIdProperty { get; private set; }
        public IntegerKeyProperty SalesOrderIdProperty { get; private set; }
        public EnumIntProperty SpecialOfferIdProperty { get; private set; }
        public MoneyProperty UnitPriceProperty { get; private set; }
        public MoneyProperty UnitPriceDiscountProperty { get; private set; }

        #endregion

        #region Construction

        public SalesOrderDetailObject()
        {
        }

        public SalesOrderDetailObject(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void Initialize()
        {
            CarrierTrackingNumberProperty = new TextProperty(this, CarrierTrackingNumber);
            CarrierTrackingNumberProperty.Size = 25;
            LineTotalProperty = new MoneyProperty(this, LineTotal);
            LineTotalProperty.Required = true;
            ModifiedDateProperty = new DateTimeProperty(this, ModifiedDate);
            ModifiedDateProperty.Required = true;
            OrderQtyProperty = new SmallIntegerProperty(this, OrderQty);
            OrderQtyProperty.Required = true;
            ProductIdProperty = new EnumIntProperty(this, ProductId);
            ProductIdProperty.Required = true;
            ProductIdProperty.Size = 10;
            ProductIdProperty.EnumType = "product";
            RowguidProperty = new GuidProperty(this, Rowguid);
            RowguidProperty.Required = true;
            SalesOrderDetailIdProperty = new IntegerKeyProperty(this, SalesOrderDetailId);
            SalesOrderDetailIdProperty.Required = true;
            SalesOrderDetailIdProperty.Editable = false;
            SalesOrderIdProperty = new IntegerKeyProperty(this, SalesOrderId);
            SalesOrderIdProperty.Required = true;
            SalesOrderIdProperty.Editable = false;
            SpecialOfferIdProperty = new EnumIntProperty(this, SpecialOfferId);
            SpecialOfferIdProperty.Required = true;
            SpecialOfferIdProperty.Size = 10;
            SpecialOfferIdProperty.EnumType = "special offer";
            UnitPriceProperty = new MoneyProperty(this, UnitPrice);
            UnitPriceProperty.Required = true;
            UnitPriceDiscountProperty = new MoneyProperty(this, UnitPriceDiscount);
            UnitPriceDiscountProperty.Required = true;
        }

        #endregion

        #region CRUD Operations

        protected override void DoRead(object options)
        {
            SalesOrder_Detail_Read(options);
        }

        protected override void DoSave(object options)
        {
            if (IsNew)
            {
                SalesOrder_Detail_Create(options);
            }
            else
            {
                SalesOrder_Detail_Update(options);
            }
        }

        protected override void DoDelete(object options)
        {
            SalesOrder_Detail_Delete(options);
        }

        #endregion

        #region Service Operations

        protected virtual void SalesOrder_Detail_Read(object options)
        {
            int _salesOrderDetailId = (int)SalesOrderDetailIdProperty.TransportValue;
            using (var s = ServiceProvider.CreateScope())
            {
                SalesOrderDetail_ReadOutput output = s.ServiceProvider.GetService<ISalesOrderService>().Detail_Read(_salesOrderDetailId);
                FromDataContract(output, options);
            }
        }

        protected virtual void SalesOrder_Detail_Create(object options)
        {
            int _salesOrderId = (int)SalesOrderIdProperty.TransportValue;
            SalesOrderDetail_CreateInput_Data _data = ToDataContract<SalesOrderDetail_CreateInput_Data>(options);
            using (var s = ServiceProvider.CreateScope())
            {
                SalesOrderDetail_CreateOutput output = s.ServiceProvider.GetService<ISalesOrderService>().Detail_Create(_salesOrderId, _data);
                FromDataContract(output, options);
            }
        }

        protected virtual void SalesOrder_Detail_Update(object options)
        {
            int _salesOrderDetailId = (int)SalesOrderDetailIdProperty.TransportValue;
            SalesOrderDetail_UpdateInput_Data _data = ToDataContract<SalesOrderDetail_UpdateInput_Data>(options);
            using (var s = ServiceProvider.CreateScope())
            {
                s.ServiceProvider.GetService<ISalesOrderService>().Detail_Update(_salesOrderDetailId, _data);
            }
        }

        protected virtual void SalesOrder_Detail_Delete(object options)
        {
            int _salesOrderDetailId = (int)SalesOrderDetailIdProperty.TransportValue;
            using (var s = ServiceProvider.CreateScope())
            {
                s.ServiceProvider.GetService<ISalesOrderService>().Detail_Delete(_salesOrderDetailId);
            }
        }

        #endregion
    }
}