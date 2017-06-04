//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "TS Service Contracts" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

import { AddressKey } from 'ServiceContracts/Person/PersonStructures';

export class CreditCardInfo {
    public CreditCardId: any = null;
    public CardNumber: any = null;
    public Expiration: any = null;
}

export class CustomerLookup {
    public StoreName: any = null;
    public PersonName: any = null;
}

export class CustomerInfo {
    public CustomerId: any = null;
    public StoreId: any = null;
    public StoreName: any = null;
    public PersonId: any = null;
    public PersonName: any = null;
    public AccountNumber: any = null;
    public TerritoryId: any = null;
    public BillingAddress: AddressKey = new AddressKey();
    public ShippingAddress: AddressKey = new AddressKey();
}

export class CustomerUpdate {
    public CustomerId: any = null;
    public BillingAddress: AddressKey = new AddressKey();
    public ShippingAddress: AddressKey = new AddressKey();
}

export class PaymentInfo {
    public SubTotal: any = null;
    public ShipMethodId: any = null;
    public TaxAmt: any = null;
    public Freight: any = null;
    public TotalDue: any = null;
    public DueDate: any = null;
    public CurrencyRate: any = null;
    public CreditCard: PaymentInfo_CreditCard = new PaymentInfo_CreditCard();
}

export class PaymentInfo_CreditCard {
    public CreditCardId: any = null;
    public CreditCardApprovalCode: any = null;
}

export class PaymentUpdate {
    public ShipMethodId: any = null;
    public DueDate: any = null;
    public CreditCard: PaymentUpdate_CreditCard = new PaymentUpdate_CreditCard();
}

export class PaymentUpdate_CreditCard {
    public CreditCardId: any = null;
    public CreditCardApprovalCode: any = null;
}

export class SalesInfo {
    public TerritoryId: any = null;
    public SalesPersonId: any = null;
    public SalesReason: Array<any> = null;
}