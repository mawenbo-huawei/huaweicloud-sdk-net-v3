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
    public class DeleteRouteTableRequest 
    {

        /// <summary>
        /// 路由表ID
        /// </summary>
        [SDKProperty("routetable_id", IsPath = true)]
        [JsonProperty("routetable_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutetableId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRouteTableRequest {\n");
            sb.Append("  routetableId: ").Append(RoutetableId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRouteTableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRouteTableRequest input)
        {
            if (input == null) return false;
            if (this.RoutetableId != input.RoutetableId || (this.RoutetableId != null && !this.RoutetableId.Equals(input.RoutetableId))) return false;

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
                if (this.RoutetableId != null) hashCode = hashCode * 59 + this.RoutetableId.GetHashCode();
                return hashCode;
            }
        }
    }
}
