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
    public class DeleteVpcRouteRequest 
    {

        /// <summary>
        /// 路由ID
        /// </summary>
        [SDKProperty("route_id", IsPath = true)]
        [JsonProperty("route_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteVpcRouteRequest {\n");
            sb.Append("  routeId: ").Append(RouteId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteVpcRouteRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteVpcRouteRequest input)
        {
            if (input == null) return false;
            if (this.RouteId != input.RouteId || (this.RouteId != null && !this.RouteId.Equals(input.RouteId))) return false;

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
                if (this.RouteId != null) hashCode = hashCode * 59 + this.RouteId.GetHashCode();
                return hashCode;
            }
        }
    }
}
