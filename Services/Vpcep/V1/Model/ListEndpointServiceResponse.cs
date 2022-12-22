using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEndpointServiceResponse : SdkResponse
    {

        /// <summary>
        /// 终端节点服务列表
        /// </summary>
        [JsonProperty("endpoint_services", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceList> EndpointServices { get; set; }

        /// <summary>
        /// 满足查询条件的终端节点服务总条数，不受分页（即limit、offset参数）影响。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEndpointServiceResponse {\n");
            sb.Append("  endpointServices: ").Append(EndpointServices).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEndpointServiceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEndpointServiceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndpointServices == input.EndpointServices ||
                    this.EndpointServices != null &&
                    input.EndpointServices != null &&
                    this.EndpointServices.SequenceEqual(input.EndpointServices)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.EndpointServices != null)
                    hashCode = hashCode * 59 + this.EndpointServices.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
