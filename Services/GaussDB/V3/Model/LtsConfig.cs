using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LtsConfig 
    {

        /// <summary>
        /// 日志类型。
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LogType { get; set; }

        /// <summary>
        /// 日志组ID。
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// 日志流ID。
        /// </summary>
        [JsonProperty("lts_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStreamId { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LtsConfig {\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsStreamId: ").Append(LtsStreamId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LtsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LtsConfig input)
        {
            if (input == null) return false;
            if (this.LogType != input.LogType || (this.LogType != null && !this.LogType.Equals(input.LogType))) return false;
            if (this.LtsGroupId != input.LtsGroupId || (this.LtsGroupId != null && !this.LtsGroupId.Equals(input.LtsGroupId))) return false;
            if (this.LtsStreamId != input.LtsStreamId || (this.LtsStreamId != null && !this.LtsStreamId.Equals(input.LtsStreamId))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.LogType != null) hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LtsGroupId != null) hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsStreamId != null) hashCode = hashCode * 59 + this.LtsStreamId.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
