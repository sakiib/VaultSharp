﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace VaultSharp.V1.SecretsEngines.Transit
{
    /// <summary>
    /// The output encoding format options for a request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OutputEncodingFormat
    {
        /// <summary>
        /// Return the response data in a base64 encoded string format.
        /// </summary>
        base64,
        /// <summary>
        /// Return the response data in a hexadecimal string format.
        /// </summary>
        hex
    }
}