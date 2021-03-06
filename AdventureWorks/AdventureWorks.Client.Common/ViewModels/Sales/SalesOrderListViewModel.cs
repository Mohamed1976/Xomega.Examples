//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "View Models" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using AdventureWorks.Client.Objects;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Specialized;
using Xomega.Framework;
using Xomega.Framework.Views;

namespace AdventureWorks.Client.ViewModels
{
    public partial class SalesOrderListViewModel : SearchViewModel
    {
        protected SalesOrderList list { get { return List as SalesOrderList; } }
        protected SalesOrderCriteria criteria { get { return List.CriteriaObject as SalesOrderCriteria; } }

        public SalesOrderListViewModel(IServiceProvider sp) : base(sp)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
            List = ServiceProvider.GetService<SalesOrderList>();
            List.CriteriaObject = ServiceProvider.GetService<SalesOrderCriteria>();
        }

        #region Link lnkDetails

        public virtual NameValueCollection lnkDetails_Params(int row)
        {
            NameValueCollection query = new NameValueCollection();
            DataListObject list = this.list;
            list.CurrentRow = row;
            query.Add("SalesOrderId", this.list.SalesOrderIdProperty.EditStringValue);
            query.Add(ViewParams.Mode.Param, ViewParams.Mode.Inline);
            query.Add(ViewParams.QuerySource, "lnkDetails");
            return query;
        }

        public virtual void lnkDetails_Command(IView tgtView, IView curView, int row)
        {
            NameValueCollection query = lnkDetails_Params(row);
            ViewModel tgtModel = ServiceProvider.GetService<SalesOrderViewModel>();
            if (NavigateTo(tgtModel, tgtView, query, this, curView))
            {
                DataListObject list = this.list;
                if (list != null) list.SelectRow(row);
            }
        }

        public virtual bool lnkDetails_Enabled(int row)
        {
            return true;
        }
        #endregion

        #region Link lnkNew

        public virtual NameValueCollection lnkNew_Params()
        {
            NameValueCollection query = new NameValueCollection();
            query.Add(ViewParams.Action.Param, ViewParams.Action.Create);
            query.Add(ViewParams.Mode.Param, ViewParams.Mode.Inline);
            query.Add(ViewParams.QuerySource, "lnkNew");
            return query;
        }

        public virtual void lnkNew_Command(IView tgtView, IView curView)
        {
            NameValueCollection query = lnkNew_Params();
            ViewModel tgtModel = ServiceProvider.GetService<SalesOrderViewModel>();
            NavigateTo(tgtModel, tgtView, query, this, curView);
        }

        public virtual bool lnkNew_Enabled()
        {
            return true;
        }
        #endregion
    }
}