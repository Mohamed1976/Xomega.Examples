//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "SPA Views" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

import { AuthenticationObject } from 'DataObjects/Person/AuthenticationObject';
import { DetailsViewModel, ViewParams } from 'xomega';
import * as controls from 'xomega-controls';

class LoginView extends DetailsViewModel {

    public obj: AuthenticationObject;

    public constructor() {
        super();
        this.DetailsObject = this.obj = new AuthenticationObject();
    }

    public attached(view, parent) {
        if (this.Params[ViewParams.Mode] == ViewParams.ModePopup)
            controls.modalViewPopup(this, view);
        else if (this.Params[ViewParams.Mode] == ViewParams.ModeInline)
            controls.vSplitViewPopup(this, view);
    }
}

export = LoginView;