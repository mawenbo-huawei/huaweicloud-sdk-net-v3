using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 弹性IP信息。
    /// </summary>
    public class PublicIp 
    {

        /// <summary>
        /// 弹性IP唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性IP地址
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicIp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicIp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicIp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PublicIpAddress != input.PublicIpAddress || (this.PublicIpAddress != null && !this.PublicIpAddress.Equals(input.PublicIpAddress))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublicIpAddress != null) hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
