﻿using SecureTradingApi.Enums;
using SecureTradingApi.Models.Abstract;

namespace SecureTradingApi.Models
{
    public class ErrorResponse : SecureTradingResponse<ErrorResponse.InnerResponse>
    {
        public class InnerResponse : BaseInnerResponse {
            public bool IsError()
            {
                return RequestTypeDescription == RequestTypeDescription.ERROR || ErrorCode != "0";
            }
        }
    }
}
