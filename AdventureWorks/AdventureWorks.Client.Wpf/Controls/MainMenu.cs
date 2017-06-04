//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "WPF Views" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using System.Collections.Specialized;
using System.Windows.Controls;
using System.Windows.Input;
using Xomega.Framework;
using Xomega.Framework.Views;
using AdventureWorks.Client.ViewModels;

namespace AdventureWorks.Client.Wpf
{
    public partial class MainMenu
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Sales Menu

        public static string M_Sales_Title = "_Sales";

        public static bool M_Sales_Visible = true;

        #region CustomerListView Command

        public static ICommand V_CustomerListView_Command = new RelayCommand<MenuItem>(CustomerListView_Execute, CustomerListView_Enabled);

        public static string V_CustomerListView_Title = "_Customer List";

        public static bool V_CustomerListView_Visible = true;

        public static void CustomerListView_Execute(MenuItem menuItem)
        {
            NameValueCollection query = new NameValueCollection();
            query.Add(ViewParams.Mode.Param, ViewParams.Mode.Popup);
            WPFView tgtView = DI.DefaultServiceProvider.GetService<CustomerListView>();
            tgtView.Owner = menuItem;
            ViewModel.NavigateTo(DI.DefaultServiceProvider.GetService<CustomerListViewModel>(), tgtView, query, null, null);
        }

        public static bool CustomerListView_Enabled(MenuItem menuItem) { return true; }
        
        #endregion

        #region SalesOrderView Command

        public static ICommand V_SalesOrderView_Command = new RelayCommand<MenuItem>(SalesOrderView_Execute, SalesOrderView_Enabled);

        public static string V_SalesOrderView_Title = "_New Sales Order";

        public static bool V_SalesOrderView_Visible = true;

        public static void SalesOrderView_Execute(MenuItem menuItem)
        {
            NameValueCollection query = new NameValueCollection();
            query.Add(ViewParams.Mode.Param, ViewParams.Mode.Popup);
            query.Add(ViewParams.Action.Param, ViewParams.Action.Create);
            WPFView tgtView = DI.DefaultServiceProvider.GetService<SalesOrderView>();
            tgtView.Owner = menuItem;
            ViewModel.NavigateTo(DI.DefaultServiceProvider.GetService<SalesOrderViewModel>(), tgtView, query, null, null);
        }

        public static bool SalesOrderView_Enabled(MenuItem menuItem) { return true; }
        
        #endregion

        #region SalesOrderListView Command

        public static ICommand V_SalesOrderListView_Command = new RelayCommand<MenuItem>(SalesOrderListView_Execute, SalesOrderListView_Enabled);

        public static string V_SalesOrderListView_Title = "_Sales Order List";

        public static bool V_SalesOrderListView_Visible = true;

        public static void SalesOrderListView_Execute(MenuItem menuItem)
        {
            NameValueCollection query = new NameValueCollection();
            query.Add(ViewParams.Mode.Param, ViewParams.Mode.Popup);
            WPFView tgtView = DI.DefaultServiceProvider.GetService<SalesOrderListView>();
            tgtView.Owner = menuItem;
            ViewModel.NavigateTo(DI.DefaultServiceProvider.GetService<SalesOrderListViewModel>(), tgtView, query, null, null);
        }

        public static bool SalesOrderListView_Enabled(MenuItem menuItem) { return true; }
        
        #endregion

        #endregion
    }
}