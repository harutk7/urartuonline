﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmeriaPay
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentClientClass", Namespace="payments.ameriabank.am/PaymentsClientClass")]
    public partial class PaymentClientClass : object
    {
        
        private string CardHolderIDField;
        
        private string ClientIDField;
        
        private string CurrencyField;
        
        private string DescriptionField;
        
        private string OpaqueField;
        
        private int OrderIDField;
        
        private string PasswordField;
        
        private AmeriaPay.PayPalRequestFields PayPalFieldsField;
        
        private decimal PaymentAmountField;
        
        private string UsernameField;
        
        private string backURLField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardHolderID
        {
            get
            {
                return this.CardHolderIDField;
            }
            set
            {
                this.CardHolderIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ClientID
        {
            get
            {
                return this.ClientIDField;
            }
            set
            {
                this.ClientIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Currency
        {
            get
            {
                return this.CurrencyField;
            }
            set
            {
                this.CurrencyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Opaque
        {
            get
            {
                return this.OpaqueField;
            }
            set
            {
                this.OpaqueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int OrderID
        {
            get
            {
                return this.OrderIDField;
            }
            set
            {
                this.OrderIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public AmeriaPay.PayPalRequestFields PayPalFields
        {
            get
            {
                return this.PayPalFieldsField;
            }
            set
            {
                this.PayPalFieldsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal PaymentAmount
        {
            get
            {
                return this.PaymentAmountField;
            }
            set
            {
                this.PaymentAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string backURL
        {
            get
            {
                return this.backURLField;
            }
            set
            {
                this.backURLField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PayPalRequestFields", Namespace="payments.ameriabank.am/PayPalRequestFields")]
    public partial class PayPalRequestFields : object
    {
        
        private AmeriaPay.ProductInformation[] ProductsInformationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AmeriaPay.ProductInformation[] ProductsInformation
        {
            get
            {
                return this.ProductsInformationField;
            }
            set
            {
                this.ProductsInformationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductInformation", Namespace="payments.ameriabank.am/PayPal/ProductInformation")]
    public partial class ProductInformation : object
    {
        
        private string DescriptionField;
        
        private string NameField;
        
        private decimal PriceField;
        
        private System.Nullable<int> QuantityField;
        
        private string URLField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Quantity
        {
            get
            {
                return this.QuantityField;
            }
            set
            {
                this.QuantityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string URL
        {
            get
            {
                return this.URLField;
            }
            set
            {
                this.URLField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultPaymentClass", Namespace="payments.ameriabank.am/ResultPaymentClass")]
    public partial class ResultPaymentClass : object
    {
        
        private string PaymentIDField;
        
        private int RespcodeField;
        
        private string RespmessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentID
        {
            get
            {
                return this.PaymentIDField;
            }
            set
            {
                this.PaymentIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Respcode
        {
            get
            {
                return this.RespcodeField;
            }
            set
            {
                this.RespcodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Respmessage
        {
            get
            {
                return this.RespmessageField;
            }
            set
            {
                this.RespmessageField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentFields", Namespace="payments.ameriabank.am/PaymentFieldsClass")]
    public partial class PaymentFields : object
    {
        
        private string amountField;
        
        private decimal approveamountField;
        
        private string authcodeField;
        
        private string cardholderIDField;
        
        private string cardnumberField;
        
        private string clientnameField;
        
        private string currencyField;
        
        private string datetimeField;
        
        private decimal depositamountField;
        
        private string descrField;
        
        private string merchantidField;
        
        private string opaqueField;
        
        private string orderidField;
        
        private byte orderstatuscodeField;
        
        private string payment_stateField;
        
        private int paymenttypeField;
        
        private AmeriaPay.PayPalResponseFields paypalfieldsField;
        
        private decimal refundamountField;
        
        private string respcodeField;
        
        private decimal rewardpointField;
        
        private string rrnField;
        
        private string stanField;
        
        private string terminalidField;
        
        private string trxnDetailsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal approveamount
        {
            get
            {
                return this.approveamountField;
            }
            set
            {
                this.approveamountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string authcode
        {
            get
            {
                return this.authcodeField;
            }
            set
            {
                this.authcodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardholderID
        {
            get
            {
                return this.cardholderIDField;
            }
            set
            {
                this.cardholderIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cardnumber
        {
            get
            {
                return this.cardnumberField;
            }
            set
            {
                this.cardnumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string clientname
        {
            get
            {
                return this.clientnameField;
            }
            set
            {
                this.clientnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string datetime
        {
            get
            {
                return this.datetimeField;
            }
            set
            {
                this.datetimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal depositamount
        {
            get
            {
                return this.depositamountField;
            }
            set
            {
                this.depositamountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descr
        {
            get
            {
                return this.descrField;
            }
            set
            {
                this.descrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string merchantid
        {
            get
            {
                return this.merchantidField;
            }
            set
            {
                this.merchantidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string opaque
        {
            get
            {
                return this.opaqueField;
            }
            set
            {
                this.opaqueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string orderid
        {
            get
            {
                return this.orderidField;
            }
            set
            {
                this.orderidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte orderstatuscode
        {
            get
            {
                return this.orderstatuscodeField;
            }
            set
            {
                this.orderstatuscodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string payment_state
        {
            get
            {
                return this.payment_stateField;
            }
            set
            {
                this.payment_stateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int paymenttype
        {
            get
            {
                return this.paymenttypeField;
            }
            set
            {
                this.paymenttypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public AmeriaPay.PayPalResponseFields paypalfields
        {
            get
            {
                return this.paypalfieldsField;
            }
            set
            {
                this.paypalfieldsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal refundamount
        {
            get
            {
                return this.refundamountField;
            }
            set
            {
                this.refundamountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string respcode
        {
            get
            {
                return this.respcodeField;
            }
            set
            {
                this.respcodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal rewardpoint
        {
            get
            {
                return this.rewardpointField;
            }
            set
            {
                this.rewardpointField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rrn
        {
            get
            {
                return this.rrnField;
            }
            set
            {
                this.rrnField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string stan
        {
            get
            {
                return this.stanField;
            }
            set
            {
                this.stanField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string terminalid
        {
            get
            {
                return this.terminalidField;
            }
            set
            {
                this.terminalidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string trxnDetails
        {
            get
            {
                return this.trxnDetailsField;
            }
            set
            {
                this.trxnDetailsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PayPalResponseFields", Namespace="payments.ameriabank.am/PayPalResponseFields")]
    public partial class PayPalResponseFields : object
    {
        
        private decimal ApproveAmountField;
        
        private string ClientEmailField;
        
        private decimal DepostiAmountField;
        
        private decimal ExchangeRateField;
        
        private decimal RefundAmountField;
        
        private AmeriaPay.ShippingInformation ShippingDataField;
        
        private decimal TransAmountField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ApproveAmount
        {
            get
            {
                return this.ApproveAmountField;
            }
            set
            {
                this.ApproveAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientEmail
        {
            get
            {
                return this.ClientEmailField;
            }
            set
            {
                this.ClientEmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DepostiAmount
        {
            get
            {
                return this.DepostiAmountField;
            }
            set
            {
                this.DepostiAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ExchangeRate
        {
            get
            {
                return this.ExchangeRateField;
            }
            set
            {
                this.ExchangeRateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal RefundAmount
        {
            get
            {
                return this.RefundAmountField;
            }
            set
            {
                this.RefundAmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AmeriaPay.ShippingInformation ShippingData
        {
            get
            {
                return this.ShippingDataField;
            }
            set
            {
                this.ShippingDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TransAmount
        {
            get
            {
                return this.TransAmountField;
            }
            set
            {
                this.TransAmountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShippingInformation", Namespace="payments.ameriabank.am/PayPal/ShippingInformation")]
    public partial class ShippingInformation : object
    {
        
        private string Address1Field;
        
        private string Address2Field;
        
        private string CityField;
        
        private string CountryCodeField;
        
        private string DefaultAddressField;
        
        private string IdField;
        
        private string PhoneField;
        
        private string PostalCodeField;
        
        private string RecipientNameField;
        
        private string StatusField;
        
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address1
        {
            get
            {
                return this.Address1Field;
            }
            set
            {
                this.Address1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address2
        {
            get
            {
                return this.Address2Field;
            }
            set
            {
                this.Address2Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DefaultAddress
        {
            get
            {
                return this.DefaultAddressField;
            }
            set
            {
                this.DefaultAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode
        {
            get
            {
                return this.PostalCodeField;
            }
            set
            {
                this.PostalCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RecipientName
        {
            get
            {
                return this.RecipientNameField;
            }
            set
            {
                this.RecipientNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RespMessage", Namespace="payments.ameriabank.am/RespMessage")]
    public partial class RespMessage : object
    {
        
        private string OpaqueField;
        
        private string RespcodeField;
        
        private string RespmessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Opaque
        {
            get
            {
                return this.OpaqueField;
            }
            set
            {
                this.OpaqueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Respcode
        {
            get
            {
                return this.RespcodeField;
            }
            set
            {
                this.RespcodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Respmessage
        {
            get
            {
                return this.RespmessageField;
            }
            set
            {
                this.RespmessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://payments.ameriabank.am", ConfigurationName="AmeriaPay.IAmeria")]
    public interface IAmeria
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://payments.ameriabank.am/IAmeria/GetPaymentID", ReplyAction="http://payments.ameriabank.am/IAmeria/GetPaymentIDResponse")]
        System.Threading.Tasks.Task<AmeriaPay.ResultPaymentClass> GetPaymentIDAsync(AmeriaPay.PaymentClientClass paymentfields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://payments.ameriabank.am/IAmeria/GetPaymentFields", ReplyAction="http://payments.ameriabank.am/IAmeria/GetPaymentFieldsResponse")]
        System.Threading.Tasks.Task<AmeriaPay.PaymentFields> GetPaymentFieldsAsync(AmeriaPay.PaymentClientClass paymentfields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://payments.ameriabank.am/IAmeria/ReversePayment", ReplyAction="http://payments.ameriabank.am/IAmeria/ReversePaymentResponse")]
        System.Threading.Tasks.Task<AmeriaPay.RespMessage> ReversePaymentAsync(AmeriaPay.PaymentClientClass paymentfields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://payments.ameriabank.am/IAmeria/Confirmation", ReplyAction="http://payments.ameriabank.am/IAmeria/ConfirmationResponse")]
        System.Threading.Tasks.Task<AmeriaPay.RespMessage> ConfirmationAsync(AmeriaPay.PaymentClientClass paymentfields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://payments.ameriabank.am/IAmeria/Refund", ReplyAction="http://payments.ameriabank.am/IAmeria/RefundResponse")]
        System.Threading.Tasks.Task<AmeriaPay.RespMessage> RefundAsync(AmeriaPay.PaymentClientClass paymentfields);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://payments.ameriabank.am/IAmeria/UpdateOpaque", ReplyAction="http://payments.ameriabank.am/IAmeria/UpdateOpaqueResponse")]
        System.Threading.Tasks.Task<AmeriaPay.RespMessage> UpdateOpaqueAsync(AmeriaPay.PaymentClientClass paymentfields);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IAmeriaChannel : AmeriaPay.IAmeria, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class AmeriaClient : System.ServiceModel.ClientBase<AmeriaPay.IAmeria>, AmeriaPay.IAmeria
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AmeriaClient() : 
                base(AmeriaClient.GetDefaultBinding(), AmeriaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IAmeria.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AmeriaClient(EndpointConfiguration endpointConfiguration) : 
                base(AmeriaClient.GetBindingForEndpoint(endpointConfiguration), AmeriaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AmeriaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AmeriaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AmeriaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AmeriaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AmeriaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<AmeriaPay.ResultPaymentClass> GetPaymentIDAsync(AmeriaPay.PaymentClientClass paymentfields)
        {
            return base.Channel.GetPaymentIDAsync(paymentfields);
        }
        
        public System.Threading.Tasks.Task<AmeriaPay.PaymentFields> GetPaymentFieldsAsync(AmeriaPay.PaymentClientClass paymentfields)
        {
            return base.Channel.GetPaymentFieldsAsync(paymentfields);
        }
        
        public System.Threading.Tasks.Task<AmeriaPay.RespMessage> ReversePaymentAsync(AmeriaPay.PaymentClientClass paymentfields)
        {
            return base.Channel.ReversePaymentAsync(paymentfields);
        }
        
        public System.Threading.Tasks.Task<AmeriaPay.RespMessage> ConfirmationAsync(AmeriaPay.PaymentClientClass paymentfields)
        {
            return base.Channel.ConfirmationAsync(paymentfields);
        }
        
        public System.Threading.Tasks.Task<AmeriaPay.RespMessage> RefundAsync(AmeriaPay.PaymentClientClass paymentfields)
        {
            return base.Channel.RefundAsync(paymentfields);
        }
        
        public System.Threading.Tasks.Task<AmeriaPay.RespMessage> UpdateOpaqueAsync(AmeriaPay.PaymentClientClass paymentfields)
        {
            return base.Channel.UpdateOpaqueAsync(paymentfields);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAmeria))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAmeria))
            {
                return new System.ServiceModel.EndpointAddress("https://payments.ameriabank.am/webservice/PaymentService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AmeriaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IAmeria);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AmeriaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IAmeria);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IAmeria,
        }
    }
}
