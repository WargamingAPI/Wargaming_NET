﻿using Newtonsoft.Json;
using Wargaming_Net.Types.Enums;
using WargamingApi;

namespace Wargaming_Net.Types
{
    public class RequestArguments : WargamingApi.Types.RequestArguments
    {
        public Sections Section;
        public Format Type;

        internal new object RequestParameters
        {
            set => base.RequestParameters = JsonConvert.SerializeObject(value, WargamingApiClient.SerializationOptions);
        }
    }
}