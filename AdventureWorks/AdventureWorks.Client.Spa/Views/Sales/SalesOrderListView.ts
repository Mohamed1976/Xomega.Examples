//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "SPA Views" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

import { SalesOrderCriteria } from 'DataObjects/Sales/SalesOrderCriteriaCustomized';
import { SalesOrderList } from 'DataObjects/Sales/SalesOrderListCustomized';
import * as router from 'plugins/router';
import { SearchViewModel, ViewParams } from 'xomega';
import * as controls from 'xomega-controls';

class SalesOrderListView extends SearchViewModel {

    constructor() {
        super();
        this.ListObject = new SalesOrderList();
        this.ListObject.CriteriaObject = new SalesOrderCriteria();
    }

    public attached(view, parent) {
        controls.vSplitViewPanel(view);
        if (this.Params[ViewParams.Mode] == ViewParams.ModePopup)
            controls.modalViewPopup(this, view);
        else if (this.Params[ViewParams.Mode] == ViewParams.ModeInline)
            controls.vSplitViewPopup(this, view);
    }

    public permalink() {
        router.navigate('#' + router.activeInstruction().fragment + this.getPermalink());
    }

    protected lnkDetails_Params(data): any {
        let vm = this;
        let params: any = {};
        params["SalesOrderId"] = data.SalesOrderId;
        params[ViewParams.Mode] = ViewParams.ModeInline;
        params[ViewParams.Source] = "lnkDetails";
        return params;
    }

    public lnkDetails_Click(data) {
        if (!this.lnkDetails_Enabled(data)) return;
        let params = this.lnkDetails_Params(data);
        let vm = this;
        this.navigateTo('SalesOrderView', params).then(function (success) {
            if (success) {
                let list = vm.ListObject;
                list.toggleSelection(data);
            }
        });
    }

    public lnkDetails_Enabled(data) {
        return true;
    }

    protected lnkNew_Params(): any {
        let vm = this;
        let params: any = {};
        params[ViewParams.Action] = ViewParams.ActionCreate;
        params[ViewParams.Mode] = ViewParams.ModeInline;
        params[ViewParams.Source] = "lnkNew";
        return params;
    }

    public lnkNew_Click() {
        if (!this.lnkNew_Enabled()) return;
        let params = this.lnkNew_Params();
        let vm = this;
        this.navigateTo('SalesOrderView', params);
    }

    public lnkNew_Enabled() {
        return true;
    }
}

export = SalesOrderListView;