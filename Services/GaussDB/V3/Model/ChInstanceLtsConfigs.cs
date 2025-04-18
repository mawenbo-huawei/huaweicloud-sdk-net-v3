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
    public class ChInstanceLtsConfigs 
    {

        /// <summary>
        /// 实例LTS配置信息。
        /// </summary>
        [JsonProperty("lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChLtsConfigs> LtsConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public ChInstanceLtsConfigsInstance Instance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChInstanceLtsConfigs {\n");
            sb.Append("  ltsConfigs: ").Append(LtsConfigs).Append("\n");
            sb.Append("  instance: ").Append(Instance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChInstanceLtsConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChInstanceLtsConfigs input)
        {
            if (input == null) return false;
            if (this.LtsConfigs != input.LtsConfigs || (this.LtsConfigs != null && input.LtsConfigs != null && !this.LtsConfigs.SequenceEqual(input.LtsConfigs))) return false;
            if (this.Instance != input.Instance || (this.Instance != null && !this.Instance.Equals(input.Instance))) return false;

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
                if (this.LtsConfigs != null) hashCode = hashCode * 59 + this.LtsConfigs.GetHashCode();
                if (this.Instance != null) hashCode = hashCode * 59 + this.Instance.GetHashCode();
                return hashCode;
            }
        }
    }
}
