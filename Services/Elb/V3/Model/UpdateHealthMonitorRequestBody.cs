using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class UpdateHealthMonitorRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("healthmonitor", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateHealthMonitorOption Healthmonitor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHealthMonitorRequestBody {\n");
            sb.Append("  healthmonitor: ").Append(Healthmonitor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHealthMonitorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHealthMonitorRequestBody input)
        {
            if (input == null) return false;
            if (this.Healthmonitor != input.Healthmonitor || (this.Healthmonitor != null && !this.Healthmonitor.Equals(input.Healthmonitor))) return false;

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
                if (this.Healthmonitor != null) hashCode = hashCode * 59 + this.Healthmonitor.GetHashCode();
                return hashCode;
            }
        }
    }
}
