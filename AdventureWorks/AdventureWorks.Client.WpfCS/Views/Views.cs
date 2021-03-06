//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "WPF Views - Client-Server" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorks.Client.WpfCS
{
    public static class Views
    {
        public static IServiceCollection AddViews(this IServiceCollection services)
        {
            services.AddTransient<LoginView, LoginViewCustomized>();
            services.AddTransient<CustomerListView, CustomerListView>();
            services.AddTransient<SalesOrderView, SalesOrderView>();
            services.AddTransient<SalesOrderListView, SalesOrderListView>();
            services.AddTransient<SalesOrderDetailView, SalesOrderDetailView>();
            return services;
        }
    }
}