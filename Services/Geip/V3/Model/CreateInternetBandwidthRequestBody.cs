using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 全域公网带宽信息
    /// </summary>
    public class CreateInternetBandwidthRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internet_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInternetBandwidthRequestBodyInternetBandwidth InternetBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInternetBandwidthRequestBody {\n");
            sb.Append("  internetBandwidth: ").Append(InternetBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInternetBandwidthRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInternetBandwidthRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternetBandwidth == input.InternetBandwidth ||
                    (this.InternetBandwidth != null &&
                    this.InternetBandwidth.Equals(input.InternetBandwidth))
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
                if (this.InternetBandwidth != null)
                    hashCode = hashCode * 59 + this.InternetBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
