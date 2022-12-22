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
    /// 
    /// </summary>
    public class UpdateEpConnections 
    {

        /// <summary>
        /// 连接管理描述字段列表
        /// </summary>
        [JsonProperty("connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectionsDesc> Connections { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEpConnections {\n");
            sb.Append("  connections: ").Append(Connections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEpConnections);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEpConnections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    input.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
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
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                return hashCode;
            }
        }
    }
}
