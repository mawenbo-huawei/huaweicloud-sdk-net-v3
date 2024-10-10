using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradeInstanceSpecV2RequestBody 
    {

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upgrade_data", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeInstanceData UpgradeData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInstanceSpecV2RequestBody {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  upgradeData: ").Append(UpgradeData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeInstanceSpecV2RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInstanceSpecV2RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.UpgradeData == input.UpgradeData ||
                    (this.UpgradeData != null &&
                    this.UpgradeData.Equals(input.UpgradeData))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.UpgradeData != null)
                    hashCode = hashCode * 59 + this.UpgradeData.GetHashCode();
                return hashCode;
            }
        }
    }
}
