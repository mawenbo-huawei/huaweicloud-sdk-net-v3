using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBlackWhiteListResponse : SdkResponse
    {

        /// <summary>
        /// IP黑白名单类型（0：关闭IP黑白名单功能，1：黑名单，2：白名单）。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// IP黑白名单列表。
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBlackWhiteListResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBlackWhiteListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBlackWhiteListResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
