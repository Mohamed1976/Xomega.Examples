//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "TS Lookup Cache Loaders" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

import { PersonCreditCard_ReadListOutput, IPersonCreditCardService } from 'ServiceContracts/Sales/IPersonCreditCardService';
import { BaseLookupCacheLoader, Header, LookupTable, ErrorList } from 'xomega';

export class PersonCreditCardReadListCacheLoader extends BaseLookupCacheLoader {

    constructor(caseSensitive: boolean) {
        super(caseSensitive, 'person credit card');
    }

    protected loadRequest(): JQueryAjaxSettings {
        // overrde this method in a subclass and provide proper input value(s)!
        return this.getLoadRequest(null);
    }

    protected getLoadRequest(_businessEntityId: any): JQueryAjaxSettings {
        return IPersonCreditCardService.getReadListRequest(_businessEntityId);
    }

    public loadCache(tableType: string, updateCache: (table: LookupTable) => void) {
        let req: JQueryAjaxSettings = this.loadRequest();
        let cl = this;
        req.success = function (data) {
            let lkpData: { [key: string]: Header } = {};
            let rows: PersonCreditCard_ReadListOutput[] = data.Result || [];
            for (let row of rows) {
                let h: Header = lkpData[row.CreditCardId] || new Header(tableType, row.CreditCardId, row.CreditCardName);
                h.addToAttribute('person name', row.PersonName);
                h.addToAttribute('card type', row.CardType);
                h.addToAttribute('card number', row.CardNumber);
                h.addToAttribute('exp month', row.ExpMonth);
                h.addToAttribute('exp year', row.ExpYear);
                lkpData[row.CreditCardId] = h;
            }
            var tblData = Object.keys(lkpData).map(k => lkpData[k]);
            var tbl: LookupTable = new LookupTable(tableType, tblData, cl.caseSensitive);
            updateCache(tbl);
        };
        req.error = (jqXHR, textStatus, errorThrow) => {
            updateCache(LookupTable.fromErrors(tableType, ErrorList.fromErrorResponse(jqXHR, errorThrow)));
        };
        $.ajax(req);
    }
}