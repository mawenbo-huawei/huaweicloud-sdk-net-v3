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
    /// Request Object
    /// </summary>
    public class DeleteTransitIpRequest 
    {

        /// <summary>
        /// 中转IP的ID。
        /// </summary>
        [SDKProperty("transit_ip_id", IsPath = true)]
        [JsonProperty("transit_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitIpId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTransitIpRequest {\n");
            sb.Append("  transitIpId: ").Append(TransitIpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTransitIpRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTransitIpRequest input)
        {
            if (input == null) return false;
            if (this.TransitIpId != input.TransitIpId || (this.TransitIpId != null && !this.TransitIpId.Equals(input.TransitIpId))) return false;

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
                if (this.TransitIpId != null) hashCode = hashCode * 59 + this.TransitIpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
