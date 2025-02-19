﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VaultSharp.V1.SystemBackend
{
    /// <summary>
    /// Represents the Seal status of the Vault.
    /// </summary>
    public class SealStatus
    {
        /// <summary>
        /// Gets or sets a value indicating the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating thif initialized.
        /// </summary>
        [JsonProperty("initialized")]
        public bool Initialized { get; set; }

        /// <summary>
        /// Gets or sets a value indicating about the <see cref="SealStatus"/>.
        /// </summary>
        /// <value>
        ///   <c>true</c> if sealed; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("sealed")]
        public bool Sealed { get; set; }

        /// <summary>
        /// Gets or sets the number of shares required to reconstruct the master key.
        /// </summary>
        /// <value>
        /// The secret threshold.
        /// </value>
        [JsonProperty("t")]
        public int SecretThreshold { get; set; }

        /// <summary>
        /// Gets or sets the number of shares to split the master key into.
        /// </summary>
        /// <value>
        /// The secret shares.
        /// </value>
        [JsonProperty("n")]
        public int SecretShares { get; set; }

        /// <summary>
        /// Gets or sets the number of shares that have been successfully applied to reconstruct the master key.
        /// When the value is about to reach <see cref="SecretThreshold"/>, the Vault will be unsealed and the value will become <value>0</value>.
        /// </summary>
        /// <value>
        /// The progress count.
        /// </value>
        [JsonProperty("progress")]
        public int Progress { get; set; }

        /// <summary>
        /// Gets or sets the nonce.
        /// </summary>
        /// <value>
        /// The nonce.
        /// </value>
        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or sets the vault version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("build_date")]
        public DateTimeOffset BuildDate { get; set; }

        /// <summary>
        /// Gets or sets the migration.
        /// </summary>
        /// <value>
        /// The migration.
        /// </value>
        [JsonProperty("migration")]
        public bool Migration { get; set; }

        /// <summary>
        /// Gets or sets the recovery seal.
        /// </summary>
        /// <value>
        /// The recovery seal.
        /// </value>
        [JsonProperty("recovery_seal")]
        public bool RecoverySeal { get; set; }

        /// <summary>
        /// Gets or sets what type of storage the cluster is configured to use
        /// </summary>
        [JsonProperty("storage_type")]
        public string StorageType { get; set; }

        [JsonProperty("hcp_link_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HCPLinkStatus { get; set; }

        [JsonProperty("hcp_link_resource_ID", NullValueHandling = NullValueHandling.Ignore)]
        public string HCPLinkResourceID { get; set; }

        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Warnings { get; set; }

        [JsonProperty("ha_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighAvailabilityEnabled { get; set; }

        [JsonProperty("active_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActiveTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the cluster.
        /// </summary>
        /// <value>
        /// The name of the cluster.
        /// </value>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or sets the cluster identifier.
        /// </summary>
        /// <value>
        /// The cluster identifier.
        /// </value>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }
    }
}