﻿using System.Net;
using System.Collections.Generic;

namespace Blockfrost.Api.Tests.Services
{
    public abstract class AddressServiceMethodTestBase<TModel> : AServiceMethodTestBase<IAddressService, ICollection<AddressUTxOResponse>>
    {
        protected AddressServiceMethodTestBase(string methodName, HttpStatusCode statusCode = HttpStatusCode.OK) : base(methodName, statusCode)
        {
        }
    }
}
