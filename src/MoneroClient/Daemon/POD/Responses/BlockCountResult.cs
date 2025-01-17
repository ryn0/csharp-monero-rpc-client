﻿using System.Text.Json.Serialization;
using Monero.Client.Network;

namespace Monero.Client.Daemon.POD.Responses
{
    internal class BlockCountResult
    {
        [JsonPropertyName("count")]
        public ulong Count { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("untrusted")]
        public bool IsUntrusted { get; set; }
        public override string ToString()
        {
            return $"{this.Count}";
        }
    }
}