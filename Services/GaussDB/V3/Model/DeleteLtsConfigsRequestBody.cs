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
    public class DeleteLtsConfigsRequestBody 
    {

        /// <summary>
        /// 日志配置列表
        /// </summary>
        [JsonProperty("log_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceDeleteLtsConfig> LogConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLtsConfigsRequestBody {\n");
            sb.Append("  logConfigs: ").Append(LogConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLtsConfigsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLtsConfigsRequestBody input)
        {
            if (input == null) return false;
            if (this.LogConfigs != input.LogConfigs || (this.LogConfigs != null && input.LogConfigs != null && !this.LogConfigs.SequenceEqual(input.LogConfigs))) return false;

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
                if (this.LogConfigs != null) hashCode = hashCode * 59 + this.LogConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
