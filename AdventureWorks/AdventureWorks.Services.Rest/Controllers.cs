//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Web API Controllers" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorks.Services
{
    public static class Controllers
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddScoped<BusinessEntityAddressController, BusinessEntityAddressController>();
            services.AddScoped<CustomerController, CustomerController>();
            services.AddScoped<PersonCreditCardController, PersonCreditCardController>();
            services.AddScoped<ProductController, ProductController>();
            services.AddScoped<SalesOrderController, SalesOrderController>();
            services.AddScoped<SalesPersonController, SalesPersonController>();
            services.AddScoped<SalesReasonController, SalesReasonController>();
            services.AddScoped<SalesTerritoryController, SalesTerritoryController>();
            services.AddScoped<ShipMethodController, ShipMethodController>();
            services.AddScoped<SpecialOfferController, SpecialOfferController>();
            return services;
        }
    }
}