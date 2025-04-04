using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowClickHouseSlowLogDetailResponse : SdkResponse
    {

        /// <summary>
        /// 慢日志列表。
        /// </summary>
        [JsonProperty("slow_log_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChSlowLogDetailResponseSlowLogList> SlowLogList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClickHouseSlowLogDetailResponse {\n");
            sb.Append("  slowLogList: ").Append(SlowLogList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClickHouseSlowLogDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClickHouseSlowLogDetailResponse input)
        {
            if (input == null) return false;
            if (this.SlowLogList != input.SlowLogList || (this.SlowLogList != null && input.SlowLogList != null && !this.SlowLogList.SequenceEqual(input.SlowLogList))) return false;

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
                if (this.SlowLogList != null) hashCode = hashCode * 59 + this.SlowLogList.GetHashCode();
                return hashCode;
            }
        }
    }
}
