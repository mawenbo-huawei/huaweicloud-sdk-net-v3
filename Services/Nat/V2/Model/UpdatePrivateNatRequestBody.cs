using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 更新私网NAT网关实例的请求体。
    /// </summary>
    public class UpdatePrivateNatRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gateway", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatePrivateNatOption Gateway { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePrivateNatRequestBody {\n");
            sb.Append("  gateway: ").Append(Gateway).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePrivateNatRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePrivateNatRequestBody input)
        {
            if (input == null) return false;
            if (this.Gateway != input.Gateway || (this.Gateway != null && !this.Gateway.Equals(input.Gateway))) return false;

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
                if (this.Gateway != null) hashCode = hashCode * 59 + this.Gateway.GetHashCode();
                return hashCode;
            }
        }
    }
}
