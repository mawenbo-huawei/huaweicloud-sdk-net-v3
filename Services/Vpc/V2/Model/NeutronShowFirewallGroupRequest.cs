using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class NeutronShowFirewallGroupRequest 
    {

        /// <summary>
        /// 网络ACL防火墙组ID
        /// </summary>
        [SDKProperty("firewall_group_id", IsPath = true)]
        [JsonProperty("firewall_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronShowFirewallGroupRequest {\n");
            sb.Append("  firewallGroupId: ").Append(FirewallGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronShowFirewallGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronShowFirewallGroupRequest input)
        {
            if (input == null) return false;
            if (this.FirewallGroupId != input.FirewallGroupId || (this.FirewallGroupId != null && !this.FirewallGroupId.Equals(input.FirewallGroupId))) return false;

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
                if (this.FirewallGroupId != null) hashCode = hashCode * 59 + this.FirewallGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
