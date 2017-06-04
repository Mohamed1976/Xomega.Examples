//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Web API Controllers" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Xomega.Framework;

namespace AdventureWorks.Services
{
    ///<summary>
    /// Cross-reference table mapping customers, vendors, and employees to their addresses.
    ///</summary>
    public partial class BusinessEntityAddressController : ApiController
    {
        private ErrorParser errorParser;
        private IBusinessEntityAddressService svc;

        public BusinessEntityAddressController(IServiceProvider serviceProvider)
        {
            errorParser = serviceProvider.GetService<ErrorParser>();
            svc = serviceProvider.GetService<IBusinessEntityAddressService>();
            if (svc is IPrincipalProvider)
                ((IPrincipalProvider)svc).CurrentPrincipal = RequestContext.Principal;
        }

        [Route("business-entity/{_businessEntityId}/address")]
        [HttpGet]
        public HttpResponseMessage ReadList([FromUri] int _businessEntityId)
        {
            HttpResponseMessage response = Request.CreateResponse();
            try
            {
                IEnumerable<BusinessEntityAddress_ReadListOutput> output = svc.ReadList(_businessEntityId);
                response = Request.CreateResponse(output);
            }
            catch (Exception ex)
            {
                ErrorList errors = errorParser.FromException(ex);
                response = Request.CreateResponse(errors);
                response.StatusCode = errors.HttpStatus;
            }
            return response;
        }
    }
}