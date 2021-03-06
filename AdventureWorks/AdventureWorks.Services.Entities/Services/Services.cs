//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Implementations" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using AdventureWorks.Services;

namespace AdventureWorks.Services.Entities
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBusinessEntityAddressService, BusinessEntityAddressService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IPersonService, PersonServiceCustomized>();
            services.AddScoped<IPersonCreditCardService, PersonCreditCardService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISalesOrderService, SalesOrderService>();
            services.AddScoped<ISalesPersonService, SalesPersonService>();
            services.AddScoped<ISalesReasonService, SalesReasonService>();
            services.AddScoped<ISalesTerritoryService, SalesTerritoryService>();
            services.AddScoped<IShipMethodService, ShipMethodService>();
            services.AddScoped<ISpecialOfferService, SpecialOfferService>();
            return services;
        }
    }
}