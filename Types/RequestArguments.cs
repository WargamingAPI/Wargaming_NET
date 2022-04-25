﻿using Newtonsoft.Json;
using static WargamingApi.WargamingApi;

namespace Wargaming_Net.Types
{
    public class RequestArguments : WargamingApi.Types.RequestArguments
    {
        public Sections Section;
        public Format Type;

        internal new object RequestParameters
        {
            set => base.RequestParameters = JsonConvert.SerializeObject(value, SerializationOptions);
        }
    }
}