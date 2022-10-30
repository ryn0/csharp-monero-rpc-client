﻿using System.Text.Json.Serialization;
using Monero.Client.Network;

namespace Monero.Client.Wallet.POD.Responses
{
    internal class TagAccountsResponse : RpcResponse
    {
        [JsonPropertyName("result")]
        public TagAccounts Result { get; set; }
    }
}