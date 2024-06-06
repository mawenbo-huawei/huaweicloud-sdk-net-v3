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
    public class UpdateSlowlogSensitiveSwitchRequestBody 
    {

        /// <summary>
        /// 慢日志开关状态。
        /// </summary>
        [JsonProperty("open_slow_log_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenSlowLogSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSlowlogSensitiveSwitchRequestBody {\n");
            sb.Append("  openSlowLogSwitch: ").Append(OpenSlowLogSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSlowlogSensitiveSwitchRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSlowlogSensitiveSwitchRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpenSlowLogSwitch == input.OpenSlowLogSwitch ||
                    (this.OpenSlowLogSwitch != null &&
                    this.OpenSlowLogSwitch.Equals(input.OpenSlowLogSwitch))
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
                if (this.OpenSlowLogSwitch != null)
                    hashCode = hashCode * 59 + this.OpenSlowLogSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
