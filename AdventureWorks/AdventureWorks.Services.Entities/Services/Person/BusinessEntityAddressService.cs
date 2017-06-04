//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Service Implementations" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated
// unless they are placed between corresponding CUSTOM_CODE_START/CUSTOM_CODE_END lines.
//
// This file can be DELETED DURING REGENERATION IF NO LONGER NEEDED, e.g. if it gets renamed.
// To prevent this and preserve manual custom changes please remove the line above.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Xomega.Framework.Services;
// CUSTOM_CODE_START: add namespaces for custom code below
// CUSTOM_CODE_END

namespace AdventureWorks.Services.Entities
{
    public partial class BusinessEntityAddressService : BaseService, IBusinessEntityAddressService
    {
        protected AdventureWorksEntities ctx;

        public BusinessEntityAddressService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            ctx = serviceProvider.GetService<AdventureWorksEntities>();
            if (ctx == null) ctx = new AdventureWorksEntities();
        }

        public virtual IEnumerable<BusinessEntityAddress_ReadListOutput> ReadList(int _businessEntityId)
        {
            // CUSTOM_CODE_START: add custom security checks for ReadList operation below
            // CUSTOM_CODE_END
            IEnumerable<BusinessEntityAddress_ReadListOutput> res = null;
            try
            {
                var src = from obj in ctx.BusinessEntityAddress select obj;
                #region Source filter
                if (true)
                {
                    // CUSTOM_CODE_START: add code for BusinessEntityId criteria of ReadList operation below
                    if (_businessEntityId != null)
                    {
                        src = src.Where(o => o.BusinessEntityId == _businessEntityId);
                    } // CUSTOM_CODE_END
                }
                // CUSTOM_CODE_START: add custom filter criteria to the source query for ReadList operation below
                // src = src.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                var qry = from obj in src
                          select new BusinessEntityAddress_ReadListOutput() {
                              // CUSTOM_CODE_START: set the AddressId output parameter of ReadList operation below
                              AddressId = obj.AddressId, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the AddressType output parameter of ReadList operation below
                              AddressType = obj.AddressTypeIdObject.Name, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the AddressLine1 output parameter of ReadList operation below
                              AddressLine1 = obj.AddressIdObject.AddressLine1, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the AddressLine2 output parameter of ReadList operation below
                              AddressLine2 = obj.AddressIdObject.AddressLine2, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the City output parameter of ReadList operation below
                              City = obj.AddressIdObject.City, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the State output parameter of ReadList operation below
                              State = obj.AddressIdObject.StateProvinceIdObject.StateProvinceCode, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the PostalCode output parameter of ReadList operation below
                              PostalCode = obj.AddressIdObject.PostalCode, // CUSTOM_CODE_END
                              // CUSTOM_CODE_START: set the Country output parameter of ReadList operation below
                              Country = obj.AddressIdObject.StateProvinceIdObject.CountryRegionCodeObject.CountryRegionCode, // CUSTOM_CODE_END
                          };
                #region Result filter
                if (true)
                {
                }
                // CUSTOM_CODE_START: add custom filter criteria to the result query for ReadList operation below
                // qry = qry.Where(o => o.FieldName == VALUE);
                // CUSTOM_CODE_END
                #endregion
                currentErrors.AbortIfHasErrors();
                res = qry.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }
    }
}