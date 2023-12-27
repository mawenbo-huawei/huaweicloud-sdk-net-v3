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
    /// Response Object
    /// </summary>
    public class SetInstancesNewDbShrinkResponse : SdkResponse
    {

        /// <summary>
        /// 收缩结果。successful:成功 failed:失败
        /// </summary>
        [JsonProperty("resp", NullValueHandling = NullValueHandling.Ignore)]
        public string Resp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetInstancesNewDbShrinkResponse {\n");
            sb.Append("  resp: ").Append(Resp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetInstancesNewDbShrinkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetInstancesNewDbShrinkResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resp == input.Resp ||
                    (this.Resp != null &&
                    this.Resp.Equals(input.Resp))
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
                if (this.Resp != null)
                    hashCode = hashCode * 59 + this.Resp.GetHashCode();
                return hashCode;
            }
        }
    }
}
