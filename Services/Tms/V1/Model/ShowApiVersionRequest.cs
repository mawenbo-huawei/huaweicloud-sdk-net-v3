using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowApiVersionRequest 
    {

        /// <summary>
        /// API版本号。
        /// </summary>
        [SDKProperty("api_version", IsPath = true)]
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowApiVersionRequest {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowApiVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowApiVersionRequest input)
        {
            if (input == null) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;

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
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
