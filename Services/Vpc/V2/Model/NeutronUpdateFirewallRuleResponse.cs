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
    /// Response Object
    /// </summary>
    public class NeutronUpdateFirewallRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("firewall_rule", NullValueHandling = NullValueHandling.Ignore)]
        public NeutronFirewallRule FirewallRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFirewallRuleResponse {\n");
            sb.Append("  firewallRule: ").Append(FirewallRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFirewallRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFirewallRuleResponse input)
        {
            if (input == null) return false;
            if (this.FirewallRule != input.FirewallRule || (this.FirewallRule != null && !this.FirewallRule.Equals(input.FirewallRule))) return false;

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
                if (this.FirewallRule != null) hashCode = hashCode * 59 + this.FirewallRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
