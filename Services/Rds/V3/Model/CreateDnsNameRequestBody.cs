using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDnsNameRequestBody 
    {

        /// <summary>
        /// 域名类型，当前只支持private
        /// </summary>
        [JsonProperty("dns_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDnsNameRequestBody {\n");
            sb.Append("  dnsType: ").Append(DnsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDnsNameRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDnsNameRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnsType == input.DnsType ||
                    (this.DnsType != null &&
                    this.DnsType.Equals(input.DnsType))
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
                if (this.DnsType != null)
                    hashCode = hashCode * 59 + this.DnsType.GetHashCode();
                return hashCode;
            }
        }
    }
}
