using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowL7policyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("l7policy", NullValueHandling = NullValueHandling.Ignore)]
        public L7policyResp L7policy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowL7policyResponse {\n");
            sb.Append("  l7policy: ").Append(L7policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowL7policyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowL7policyResponse input)
        {
            if (input == null) return false;
            if (this.L7policy != input.L7policy || (this.L7policy != null && !this.L7policy.Equals(input.L7policy))) return false;

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
                if (this.L7policy != null) hashCode = hashCode * 59 + this.L7policy.GetHashCode();
                return hashCode;
            }
        }
    }
}
