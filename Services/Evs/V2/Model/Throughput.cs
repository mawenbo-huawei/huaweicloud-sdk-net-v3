using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Throughput 
    {

        /// <summary>
        /// 冻结标签。
        /// </summary>
        [JsonProperty("frozened", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Frozened { get; set; }

        /// <summary>
        /// 云硬盘吞吐量标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 吞吐量大小。
        /// </summary>
        [JsonProperty("total_val", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalVal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Throughput {\n");
            sb.Append("  frozened: ").Append(Frozened).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  totalVal: ").Append(TotalVal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Throughput);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Throughput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Frozened == input.Frozened ||
                    (this.Frozened != null &&
                    this.Frozened.Equals(input.Frozened))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TotalVal == input.TotalVal ||
                    (this.TotalVal != null &&
                    this.TotalVal.Equals(input.TotalVal))
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
                if (this.Frozened != null)
                    hashCode = hashCode * 59 + this.Frozened.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TotalVal != null)
                    hashCode = hashCode * 59 + this.TotalVal.GetHashCode();
                return hashCode;
            }
        }
    }
}
