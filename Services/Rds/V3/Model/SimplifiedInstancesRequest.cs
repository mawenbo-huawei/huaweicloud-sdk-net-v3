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
    public class SimplifiedInstancesRequest 
    {

        /// <summary>
        /// 实例id集合
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimplifiedInstancesRequest {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimplifiedInstancesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimplifiedInstancesRequest input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
