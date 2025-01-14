﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VaultSharp.V1.AuthMethods.AppRole.Models
{
    /// <summary>
    /// https://developer.hashicorp.com/vault/api-docs/auth/approle#generate-new-secret-id
    /// </summary>
    public class SecretIdInfo
    {
        [JsonProperty("secret_id")]
        public string SecretId { get; set; }

        [JsonProperty("secret_id_accessor")]
        public string SecretIdAccessor { get; set; }
        
        [JsonProperty("secret_id_num_uses")]
        public long SecretIdNumberOfUses { get; set; }

        [JsonProperty("secret_id_ttl")]
        public long SecretIdTimeToLive { get; set; }
    }
}
