using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 实时码率
    /// </summary>
    public class V2BitrateInfo 
    {

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 流名。
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 采样开始时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 采样结束时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 码率信息列表，单位为Kbps。
        /// </summary>
        [JsonProperty("data_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> DataList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2BitrateInfo {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  dataList: ").Append(DataList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as V2BitrateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(V2BitrateInfo input)
        {
            if (input == null) return false;
            if (this.PublishDomain != input.PublishDomain || (this.PublishDomain != null && !this.PublishDomain.Equals(input.PublishDomain))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.DataList != input.DataList || (this.DataList != null && input.DataList != null && !this.DataList.SequenceEqual(input.DataList))) return false;

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
                if (this.PublishDomain != null) hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DataList != null) hashCode = hashCode * 59 + this.DataList.GetHashCode();
                return hashCode;
            }
        }
    }
}
