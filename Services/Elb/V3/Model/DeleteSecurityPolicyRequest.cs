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
    /// Request Object
    /// </summary>
    public class DeleteSecurityPolicyRequest 
    {

        /// <summary>
        /// 自定义安全策略的ID。
        /// </summary>
        [SDKProperty("security_policy_id", IsPath = true)]
        [JsonProperty("security_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSecurityPolicyRequest {\n");
            sb.Append("  securityPolicyId: ").Append(SecurityPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSecurityPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSecurityPolicyRequest input)
        {
            if (input == null) return false;
            if (this.SecurityPolicyId != input.SecurityPolicyId || (this.SecurityPolicyId != null && !this.SecurityPolicyId.Equals(input.SecurityPolicyId))) return false;

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
                if (this.SecurityPolicyId != null) hashCode = hashCode * 59 + this.SecurityPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
