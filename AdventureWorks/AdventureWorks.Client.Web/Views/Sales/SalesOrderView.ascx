<%---------------------------------------------------------------------------------------------
 This file was AUTO-GENERATED by "ASP.NET Views" Xomega.Net generator.

 Manual CHANGES to this file WILL BE LOST when the code is regenerated.
----------------------------------------------------------------------------------------------%>

<%@ Control Language="C#" Inherits="AdventureWorks.Client.Web.SalesOrderView" %>

<%@ Import Namespace="AdventureWorks.Client.Objects" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<%@ Register src="~/Controls/Errors.ascx" tagname="Errors" tagprefix="uc" %>
<%@ Register src="~/Controls/Editors/DateTimeControl.ascx" tagname="DateTimeControl" tagprefix="uc" %>
<%@ Register src="~/Controls/Editors/PickListControl.ascx" tagname="PickListControl" tagprefix="uc" %>
<%@ Register src="~/Views/Sales/CustomerListView.ascx" tagname="CustomerListView" tagprefix="uc" %>
<%@ Register src="~/Views/Sales/SalesOrderDetailView.ascx" tagname="SalesOrderDetailView" tagprefix="uc" %>

<asp:Panel ID="pnlComposition" CssClass="view-composition" runat="server">
  <asp:UpdatePanel ID="upl_Main" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
      <asp:Panel ID="pnl_View" CssClass="view with-footer" runat="server" data-width="840" data-height="640">
        <div class="view-header">
          <asp:Label ID="lblSalesOrderViewTitle" CssClass="view-title" Text="Sales Order" runat="server"></asp:Label>
        </div>
        <div class="view-body">
          <div class="content indented">
            <uc:Errors ID="ucl_Errors" runat="server"></uc:Errors>
            <asp:Panel ID="pnl_Object" CssClass="indented" runat="server">
              <asp:Panel ID="pnlMain" CssClass="xw-obj" GroupingText="Sales Order" runat="server">
                <table class="xw-fieldset-layout">
                  <tr>
                    <td class="fieldColumn" style="width: 50%">
                      <div class="field">
                        <asp:Label ID="lblSalesOrderNumber" Text="Sales Order Number:" CssClass="label" runat="server"></asp:Label>
                        <asp:Label LabelID="lblSalesOrderNumber" ID="ctlSalesOrderNumber" Property="<%# SalesOrderObject.SalesOrderNumber %>" runat="server"></asp:Label>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblOrderDate" Text="Order Date:" CssClass="label" runat="server"></asp:Label>
                        <asp:Label LabelID="lblOrderDate" ID="ctlOrderDate" Property="<%# SalesOrderObject.OrderDate %>" runat="server"></asp:Label>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblStatus" Text="Status:" CssClass="label" runat="server"></asp:Label>
                        <asp:DropDownList LabelID="lblStatus" ID="ctlStatus" Property="<%# SalesOrderObject.Status %>" runat="server"></asp:DropDownList>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblOnlineOrderFlag" Text="Online Order Flag:" CssClass="label" runat="server"></asp:Label>
                        <asp:CheckBox LabelID="lblOnlineOrderFlag" ID="ctlOnlineOrderFlag" Property="<%# SalesOrderObject.OnlineOrderFlag %>" runat="server"></asp:CheckBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblPurchaseOrderNumber" Text="Purchase Order Number:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblPurchaseOrderNumber" ID="ctlPurchaseOrderNumber" Property="<%# SalesOrderObject.PurchaseOrderNumber %>" runat="server"></asp:TextBox>
                      </div>
                    </td>
                    <td class="fieldColumn" style="width: 50%">
                      <div class="field">
                        <asp:Label ID="lblAccountNumber" Text="Account Number:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblAccountNumber" ID="ctlAccountNumber" Property="<%# SalesOrderObject.AccountNumber %>" runat="server"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblShipDate" Text="Ship Date:" CssClass="label" runat="server"></asp:Label>
                        <uc:DateTimeControl LabelID="lblShipDate" ID="ctlShipDate" Property="<%# SalesOrderObject.ShipDate %>" TextCssClass="date" runat="server"></uc:DateTimeControl>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblComment" Text="Comment:" CssClass="label" runat="server"></asp:Label>
                        <asp:TextBox LabelID="lblComment" ID="ctlComment" Property="<%# SalesOrderObject.Comment %>" runat="server"></asp:TextBox>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblRevisionNumber" Text="Revision Number:" CssClass="label" runat="server"></asp:Label>
                        <asp:Label LabelID="lblRevisionNumber" ID="ctlRevisionNumber" Property="<%# SalesOrderObject.RevisionNumber %>" runat="server"></asp:Label>
                      </div>
                      <div class="field">
                        <asp:Label ID="lblModifiedDate" Text="Modified Date:" CssClass="label" runat="server"></asp:Label>
                        <asp:Label LabelID="lblModifiedDate" ID="ctlModifiedDate" Property="<%# SalesOrderObject.ModifiedDate %>" runat="server"></asp:Label>
                      </div>
                    </td>
                  </tr>
                </table>
              </asp:Panel>
              <ajaxToolkit:TabContainer ID="tbcChildren" runat="server">
                <ajaxToolkit:TabPanel ID="tabCustomer" HeaderText="Customer" runat="server">
                  <ContentTemplate>
                    <asp:Panel ID="pnlCustomer" CssClass="xw-obj borderless" runat="server" GroupingText=" " ChildObject="<%# SalesOrderObject.Customer %>">
                      <table class="xw-fieldset-layout">
                        <tr>
                          <td class="fieldColumn" style="width: 50%">
                            <div class="field">
                              <asp:Label ID="lblCustomerStoreName" Text="Store Name:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblCustomerStoreName" ID="ctlCustomerStoreName" Property="<%# SalesOrderCustomerObject.StoreName %>" runat="server"></asp:Label>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblCustomerPersonName" Text="Person Name:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblCustomerPersonName" ID="ctlCustomerPersonName" Property="<%# SalesOrderCustomerObject.PersonName %>" runat="server"></asp:Label>
                            </div>
                          </td>
                          <td class="fieldColumn" style="width: 50%">
                            <div class="field">
                              <asp:Label ID="lblCustomerAccountNumber" Text="Account Number:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblCustomerAccountNumber" ID="ctlCustomerAccountNumber" Property="<%# SalesOrderCustomerObject.AccountNumber %>" runat="server"></asp:Label>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblCustomerTerritoryId" Text="Territory:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblCustomerTerritoryId" ID="ctlCustomerTerritoryId" Property="<%# SalesOrderCustomerObject.TerritoryId %>" runat="server"></asp:Label>
                            </div>
                          </td>
                        </tr>
                      </table>
                    </asp:Panel>
                    <asp:Panel ID="pnlCustomerChildren" ChildObject="<%# SalesOrderObject.Customer %>" runat="server">
                      <asp:Panel ID="pnlLookup" CssClass="xw-obj " runat="server" GroupingText="Lookup" ChildObject="<%# SalesOrderCustomerObject.Lookup %>">
                        <table class="xw-fieldset-layout">
                          <tr>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblLookupStoreName" Text="Store Name:" CssClass="label" runat="server"></asp:Label>
                                <asp:TextBox LabelID="lblLookupStoreName" ID="ctlLookupStoreName" Property="<%# SalesCustomerLookupObject.StoreName %>" runat="server"></asp:TextBox>
                              </div>
                            </td>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblLookupPersonName" Text="Person Name:" CssClass="label" runat="server"></asp:Label>
                                <asp:TextBox LabelID="lblLookupPersonName" ID="ctlLookupPersonName" Property="<%# SalesCustomerLookupObject.PersonName %>" runat="server"></asp:TextBox>
                              </div>
                            </td>
                          </tr>
                        </table>
                        <asp:LinkButton ID="lnkCustomerLookupLookUp" runat="server" OnCommand="lnkCustomerLookupLookUp_Click">Look Up</asp:LinkButton>
                      </asp:Panel>
                      <asp:Panel ID="pnlBillingAddress" CssClass="xw-obj " runat="server" GroupingText="Billing Address" ChildObject="<%# SalesOrderCustomerObject.BillingAddress %>">
                        <table class="xw-fieldset-layout">
                          <tr>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblBillingAddressAddressId" Text="Address Type:" CssClass="label" runat="server"></asp:Label>
                                <asp:DropDownList LabelID="lblBillingAddressAddressId" ID="ctlBillingAddressAddressId" Property="<%# AddressObject.AddressId %>" AutoPostBack="true" runat="server"></asp:DropDownList>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblBillingAddressAddressLine1" Text="Address Line1:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblBillingAddressAddressLine1" ID="ctlBillingAddressAddressLine1" Property="<%# AddressObject.AddressLine1 %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblBillingAddressAddressLine2" Text="Address Line2:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblBillingAddressAddressLine2" ID="ctlBillingAddressAddressLine2" Property="<%# AddressObject.AddressLine2 %>" runat="server"></asp:Label>
                              </div>
                            </td>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblBillingAddressCityState" Text="City/State:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblBillingAddressCityState" ID="ctlBillingAddressCityState" Property="<%# AddressObject.CityState %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblBillingAddressPostalCode" Text="Postal Code:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblBillingAddressPostalCode" ID="ctlBillingAddressPostalCode" Property="<%# AddressObject.PostalCode %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblBillingAddressCountry" Text="Country:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblBillingAddressCountry" ID="ctlBillingAddressCountry" Property="<%# AddressObject.Country %>" runat="server"></asp:Label>
                              </div>
                            </td>
                          </tr>
                        </table>
                      </asp:Panel>
                      <asp:Panel ID="pnlShippingAddress" CssClass="xw-obj " runat="server" GroupingText="Shipping Address" ChildObject="<%# SalesOrderCustomerObject.ShippingAddress %>">
                        <table class="xw-fieldset-layout">
                          <tr>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblShippingAddressAddressId" Text="Address Type:" CssClass="label" runat="server"></asp:Label>
                                <asp:DropDownList LabelID="lblShippingAddressAddressId" ID="ctlShippingAddressAddressId" Property="<%# AddressObject.AddressId %>" AutoPostBack="true" runat="server"></asp:DropDownList>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblShippingAddressAddressLine1" Text="Address Line1:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblShippingAddressAddressLine1" ID="ctlShippingAddressAddressLine1" Property="<%# AddressObject.AddressLine1 %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblShippingAddressAddressLine2" Text="Address Line2:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblShippingAddressAddressLine2" ID="ctlShippingAddressAddressLine2" Property="<%# AddressObject.AddressLine2 %>" runat="server"></asp:Label>
                              </div>
                            </td>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblShippingAddressCityState" Text="City/State:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblShippingAddressCityState" ID="ctlShippingAddressCityState" Property="<%# AddressObject.CityState %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblShippingAddressPostalCode" Text="Postal Code:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblShippingAddressPostalCode" ID="ctlShippingAddressPostalCode" Property="<%# AddressObject.PostalCode %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblShippingAddressCountry" Text="Country:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblShippingAddressCountry" ID="ctlShippingAddressCountry" Property="<%# AddressObject.Country %>" runat="server"></asp:Label>
                              </div>
                            </td>
                          </tr>
                        </table>
                      </asp:Panel>
                    </asp:Panel>
                  </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel ID="tabDetail" HeaderText="Detail" runat="server">
                  <ContentTemplate>
                    <asp:Panel ID="pnlDetail" CssClass="xw-obj borderless" runat="server" GroupingText="">
                      <asp:GridView ID="gridDetail" AllowPaging="True" PageSize="10" runat="server" ChildObject="<%# SalesOrderObject.Detail %>">
                        <Columns>
                          <asp:TemplateField HeaderText="Product">
                            <ItemTemplate>
                              <asp:LinkButton ID="lnkDetailDetails" runat="server" OnCommand="lnkDetailDetails_Click" CommandArgument="<%# Container.DataItemIndex %>">
                                <asp:Label ID="fldProduct" Property="<%# SalesOrderDetailList.Product %>" runat="server"></asp:Label>
                              </asp:LinkButton>
                            </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Qty">
                            <ItemTemplate>
                              <asp:Label ID="fldOrderQty" Property="<%# SalesOrderDetailList.OrderQty %>" runat="server"></asp:Label>
                            </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Price">
                            <ItemTemplate>
                              <asp:Label ID="fldUnitPrice" Property="<%# SalesOrderDetailList.UnitPrice %>" runat="server"></asp:Label>
                            </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Discount">
                            <ItemTemplate>
                              <asp:Label ID="fldUnitPriceDiscount" Property="<%# SalesOrderDetailList.UnitPriceDiscount %>" runat="server"></asp:Label>
                            </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Special Offer">
                            <ItemTemplate>
                              <asp:Label ID="fldSpecialOffer" Property="<%# SalesOrderDetailList.SpecialOffer %>" runat="server"></asp:Label>
                            </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Total">
                            <ItemTemplate>
                              <asp:Label ID="fldLineTotal" Property="<%# SalesOrderDetailList.LineTotal %>" runat="server"></asp:Label>
                            </ItemTemplate>
                          </asp:TemplateField>
                          <asp:TemplateField HeaderText="Tracking #">
                            <ItemTemplate>
                              <asp:Label ID="fldCarrierTrackingNumber" Property="<%# SalesOrderDetailList.CarrierTrackingNumber %>" runat="server"></asp:Label>
                            </ItemTemplate>
                          </asp:TemplateField>
                        </Columns>
                      </asp:GridView>
                      <asp:LinkButton ID="lnkDetailNew" runat="server" OnCommand="lnkDetailNew_Click">New</asp:LinkButton>
                    </asp:Panel>
                  </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel ID="tabPayment" HeaderText="Payment" runat="server">
                  <ContentTemplate>
                    <asp:Panel ID="pnlPayment" CssClass="xw-obj borderless" runat="server" GroupingText=" " ChildObject="<%# SalesOrderObject.Payment %>">
                      <table class="xw-fieldset-layout">
                        <tr>
                          <td class="fieldColumn" style="width: 50%">
                            <div class="field">
                              <asp:Label ID="lblPaymentSubTotal" Text="Sub Total:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblPaymentSubTotal" ID="ctlPaymentSubTotal" Property="<%# SalesOrderPaymentObject.SubTotal %>" runat="server"></asp:Label>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblPaymentShipMethodId" Text="Shipment Method:" CssClass="label" runat="server"></asp:Label>
                              <asp:DropDownList LabelID="lblPaymentShipMethodId" ID="ctlPaymentShipMethodId" Property="<%# SalesOrderPaymentObject.ShipMethodId %>" runat="server"></asp:DropDownList>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblPaymentTaxAmt" Text="Tax Amt:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblPaymentTaxAmt" ID="ctlPaymentTaxAmt" Property="<%# SalesOrderPaymentObject.TaxAmt %>" runat="server"></asp:Label>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblPaymentFreight" Text="Freight:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblPaymentFreight" ID="ctlPaymentFreight" Property="<%# SalesOrderPaymentObject.Freight %>" runat="server"></asp:Label>
                            </div>
                          </td>
                          <td class="fieldColumn" style="width: 50%">
                            <div class="field">
                              <asp:Label ID="lblPaymentTotalDue" Text="Total Due:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblPaymentTotalDue" ID="ctlPaymentTotalDue" Property="<%# SalesOrderPaymentObject.TotalDue %>" runat="server"></asp:Label>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblPaymentDueDate" Text="Due Date:" CssClass="label" runat="server"></asp:Label>
                              <uc:DateTimeControl LabelID="lblPaymentDueDate" ID="ctlPaymentDueDate" Property="<%# SalesOrderPaymentObject.DueDate %>" TextCssClass="date" runat="server"></uc:DateTimeControl>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblPaymentCurrencyRate" Text="Currency Rate:" CssClass="label" runat="server"></asp:Label>
                              <asp:Label LabelID="lblPaymentCurrencyRate" ID="ctlPaymentCurrencyRate" Property="<%# SalesOrderPaymentObject.CurrencyRate %>" runat="server"></asp:Label>
                            </div>
                          </td>
                        </tr>
                      </table>
                    </asp:Panel>
                    <asp:Panel ID="pnlPaymentChildren" ChildObject="<%# SalesOrderObject.Payment %>" runat="server">
                      <asp:Panel ID="pnlCreditCard" CssClass="xw-obj " runat="server" GroupingText="Credit Card" ChildObject="<%# SalesOrderPaymentObject.CreditCard %>">
                        <table class="xw-fieldset-layout">
                          <tr>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblCreditCardCreditCardId" Text="Credit Card:" CssClass="label" runat="server"></asp:Label>
                                <asp:DropDownList LabelID="lblCreditCardCreditCardId" ID="ctlCreditCardCreditCardId" Property="<%# CreditCardPaymentObject.CreditCardId %>" AutoPostBack="true" runat="server"></asp:DropDownList>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblCreditCardCardNumber" Text="Card Number:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblCreditCardCardNumber" ID="ctlCreditCardCardNumber" Property="<%# CreditCardPaymentObject.CardNumber %>" runat="server"></asp:Label>
                              </div>
                            </td>
                            <td class="fieldColumn" style="width: 50%">
                              <div class="field">
                                <asp:Label ID="lblCreditCardExpiration" Text="Expiration:" CssClass="label" runat="server"></asp:Label>
                                <asp:Label LabelID="lblCreditCardExpiration" ID="ctlCreditCardExpiration" Property="<%# CreditCardPaymentObject.Expiration %>" runat="server"></asp:Label>
                              </div>
                              <div class="field">
                                <asp:Label ID="lblCreditCardCreditCardApprovalCode" Text="Credit Card Approval Code:" CssClass="label" runat="server"></asp:Label>
                                <asp:TextBox LabelID="lblCreditCardCreditCardApprovalCode" ID="ctlCreditCardCreditCardApprovalCode" Property="<%# CreditCardPaymentObject.CreditCardApprovalCode %>" runat="server"></asp:TextBox>
                              </div>
                            </td>
                          </tr>
                        </table>
                      </asp:Panel>
                    </asp:Panel>
                  </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel ID="tabSales" HeaderText="Sales" runat="server">
                  <ContentTemplate>
                    <asp:Panel ID="pnlSales" CssClass="xw-obj borderless" runat="server" GroupingText=" " ChildObject="<%# SalesOrderObject.Sales %>">
                      <table class="xw-fieldset-layout">
                        <tr>
                          <td class="fieldColumn" style="width: 50%">
                            <div class="field">
                              <asp:Label ID="lblSalesTerritoryId" Text="Territory:" CssClass="label" runat="server"></asp:Label>
                              <asp:DropDownList LabelID="lblSalesTerritoryId" ID="ctlSalesTerritoryId" Property="<%# SalesOrderSalesObject.TerritoryId %>" AutoPostBack="true" runat="server"></asp:DropDownList>
                            </div>
                            <div class="field">
                              <asp:Label ID="lblSalesSalesPersonId" Text="Sales Person:" CssClass="label" runat="server"></asp:Label>
                              <asp:DropDownList LabelID="lblSalesSalesPersonId" ID="ctlSalesSalesPersonId" Property="<%# SalesOrderSalesObject.SalesPersonId %>" runat="server"></asp:DropDownList>
                            </div>
                          </td>
                          <td class="fieldColumn" style="width: 50%">
                            <div class="field">
                              <asp:Label ID="lblSalesSalesReason" Text="Sales Reason:" CssClass="label" runat="server"></asp:Label>
                              <uc:PickListControl LabelID="lblSalesSalesReason" ID="ctlSalesSalesReason" Property="<%# SalesOrderSalesObject.SalesReason %>" Rows="6" runat="server"></uc:PickListControl>
                            </div>
                          </td>
                        </tr>
                      </table>
                    </asp:Panel>
                  </ContentTemplate>
                </ajaxToolkit:TabPanel>
              </ajaxToolkit:TabContainer>
            </asp:Panel>
          </div>
        </div>
        <div class="view-footer action-bar">
          <asp:Button ID="btn_Delete" Text="Delete" CssClass="btn-delete" Enabled="false" OnClientClick="if (!confirm('Are you sure you want to delete this object?\nThis action cannot be undone.')) return false;" runat="server"></asp:Button>
          <asp:Button ID="btn_Save" Text="Save" CssClass="btn-save" runat="server"></asp:Button>
          <asp:Button ID="btn_Close" Text="Close" CssClass="btn-close" runat="server"></asp:Button>
        </div>
      </asp:Panel>
    </ContentTemplate>
  </asp:UpdatePanel>
  <asp:UpdatePanel ID="uplCustomerListView" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
      <uc:CustomerListView ID="uclCustomerListView" Visible="false" runat="server"></uc:CustomerListView>
    </ContentTemplate>
  </asp:UpdatePanel>
  <asp:UpdatePanel ID="uplSalesOrderDetailView" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
      <uc:SalesOrderDetailView ID="uclSalesOrderDetailView" Visible="false" runat="server"></uc:SalesOrderDetailView>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Panel>