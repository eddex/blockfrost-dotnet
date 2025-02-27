﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blockfrost.Api
{
    public partial class Pool_metadata
    {
        /// <summary>Description of the stake pool</summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>Hash of the metadata file</summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>Hexadecimal pool ID</summary>
        [JsonPropertyName("hex")]
        [Required(AllowEmptyStrings = true)]
        public string Hex { get; set; }

        /// <summary>Home page of the stake pool</summary>
        [JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        /// <summary>Name of the stake pool</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>Bech32 pool ID</summary>
        [JsonPropertyName("pool_id")]
        [Required(AllowEmptyStrings = true)]
        public string Pool_id { get; set; }

        /// <summary>Ticker of the stake pool</summary>
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }

        /// <summary>URL to the stake pool metadata</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
