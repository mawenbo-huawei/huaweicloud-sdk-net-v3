using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateSlowLogDownloadResponse : SdkResponse
    {

        /// <summary>
        /// 慢日志下载信息列表
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlowLogDownloadInfo> List { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSlowLogDownloadResponse {\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSlowLogDownloadResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSlowLogDownloadResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
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
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
                return hashCode;
            }
        }
    }
}
