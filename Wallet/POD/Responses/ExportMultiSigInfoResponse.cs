﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

using Monero.Client.Network;

namespace Monero.Client.Wallet.POD.Responses
{
    internal class ExportMultiSigInfoResponse : RpcResponse
    {
        [JsonPropertyName("result")]
        public ExportMultiSigInformation Result { get; set; }
    }

    public class ExportMultiSigInformation
    {
        [JsonPropertyName("info")]
        public string Information { get; set; }
    }
}