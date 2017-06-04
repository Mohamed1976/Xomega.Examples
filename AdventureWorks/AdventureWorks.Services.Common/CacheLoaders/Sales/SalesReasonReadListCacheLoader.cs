//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "Lookup Cache Loaders" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Xomega.Framework;
using Xomega.Framework.Lookup;

namespace AdventureWorks.Services
{
    public partial class SalesReasonReadListCacheLoader : LookupCacheLoader 
    {
        public SalesReasonReadListCacheLoader(IServiceProvider serviceProvider)
            : base(serviceProvider, LookupCache.Global, true, "sales reason")
        {
        }

        protected virtual IEnumerable<SalesReason_ReadListOutput> ReadList()
        {
            using (var s = serviceProvider.CreateScope())
            {
                return s.ServiceProvider.GetService<ISalesReasonService>().ReadList();
            }
        }

        protected override void LoadCache(string tableType, CacheUpdater updateCache)
        {
            Dictionary<string, Dictionary<string, Header>> data = new Dictionary<string, Dictionary<string, Header>>();
            foreach (SalesReason_ReadListOutput row in ReadList())
            {
                string type = "sales reason";
                Dictionary<string, Header> tbl;
                if (!data.TryGetValue(type, out tbl)) data[type] = tbl = new Dictionary<string, Header>();

                string id = "" + row.SalesReasonId;
                Header h;
                if (!tbl.TryGetValue(id, out h))
                {
                    tbl[id] = h = new Header(type, id, row.Name);
                }
            }
            // if no data is returned we still need to update cache to get the notify listener removed
            if (data.Count == 0) updateCache(new LookupTable(tableType, new List<Header>(), true));
            foreach (string type in data.Keys)
                updateCache(new LookupTable(type, data[type].Values, true));
        }
    }
}