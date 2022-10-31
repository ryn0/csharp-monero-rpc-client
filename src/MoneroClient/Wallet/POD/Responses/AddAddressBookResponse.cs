﻿using System.Text.Json.Serialization;
using Monero.Client.Network;

namespace Monero.Client.Wallet.POD.Responses
{
    internal class AddAddressBookResponse : RpcResponse
    {
        [JsonPropertyName("result")]
        public AddAddressBook Result { get; set; }
    }
}