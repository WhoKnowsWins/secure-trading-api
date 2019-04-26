﻿using System;
using Newtonsoft.Json;
using SecureTradingApi.Enums;
using SecureTradingApi.Models.Abstract;

namespace SecureTradingApi.Models
{
    public class TransactionQueryRequest : BaseInnerRequest
    {
        public TransactionQueryFilter Filter { get; set; }

        public TransactionQueryRequest() : base(RequestTypeDescription.TRANSACTIONQUERY)
        {
        }
    }

    public class TransactionQueryFilter
    {
        [JsonProperty("sitereference")]
        public ValueWrapper[] SiteReference { get; set; }
        [JsonProperty("currencyiso3a")]
        public ValueWrapper[] CurrencyIso3a { get; set; }
        [JsonProperty("transactionreference")]
        public ValueWrapper[] TransactionReference { get; set; }
        [JsonProperty("accounttypedescription")]
        public ValueWrapper[] AccountTypeDescription { get; set; }

        [JsonProperty("billingemail")]
        public ValueWrapper[] BillingEmail { get; set; }
        [JsonProperty("billingfirstname")]
        public ValueWrapper[] BillingFirstName { get; set; }
        [JsonProperty("billinglastname")]
        public ValueWrapper[] BillingLastName { get; set; }
        [JsonProperty("billingpostcode")]
        public ValueWrapper[] BillingPostcode { get; set; }
        [JsonProperty("billingpremise")]
        public ValueWrapper[] BillingPremise { get; set; }

        [JsonProperty("customerip")]
        public ValueWrapper[] CustomerIp { get; set; }
        [JsonProperty("starttimestamp")]
        public ValueWrapper[] StartTime { get; set; }
        [JsonProperty("endtimestamp")]
        public ValueWrapper[] EndTime { get; set; }
        [JsonProperty("orderereference")]
        public ValueWrapper[] OrderReference { get; set; }
        [JsonProperty("pan")]
        public ValueWrapper[] CardNumber { get; set; }
        [JsonProperty("parenttransactionreference")]
        public ValueWrapper[] ParentTransactionReference { get; set; }
        [JsonProperty("PaymentTypeDescription")]
        public ValueWrapper[] PaymentTypeDescription { get; set; }
    }
}