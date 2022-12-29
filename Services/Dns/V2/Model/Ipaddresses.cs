using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Ipaddresses 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipaddress", NullValueHandling = NullValueHandling.Ignore)]
        public IpaddressData Ipaddress { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ipaddresses {\n");
            sb.Append("  ipaddress: ").Append(Ipaddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Ipaddresses);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Ipaddresses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ipaddress == input.Ipaddress ||
                    (this.Ipaddress != null &&
                    this.Ipaddress.Equals(input.Ipaddress))
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
                if (this.Ipaddress != null)
                    hashCode = hashCode * 59 + this.Ipaddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
