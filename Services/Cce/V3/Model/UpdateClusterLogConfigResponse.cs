using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateClusterLogConfigResponse : SdkResponse
    {

        /// <summary>
        /// 存储时长
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }

        /// <summary>
        /// 日志配置项
        /// </summary>
        [JsonProperty("log_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClusterLogConfigLogConfigs> LogConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateClusterLogConfigResponse {\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  logConfigs: ").Append(LogConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateClusterLogConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateClusterLogConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TtlInDays == input.TtlInDays ||
                    (this.TtlInDays != null &&
                    this.TtlInDays.Equals(input.TtlInDays))
                ) && 
                (
                    this.LogConfigs == input.LogConfigs ||
                    this.LogConfigs != null &&
                    input.LogConfigs != null &&
                    this.LogConfigs.SequenceEqual(input.LogConfigs)
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
                if (this.TtlInDays != null)
                    hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.LogConfigs != null)
                    hashCode = hashCode * 59 + this.LogConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
