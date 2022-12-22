using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 告警模板列表
        /// </summary>
        [JsonProperty("alarm_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmTemplates> AlarmTemplates { get; set; }

        /// <summary>
        /// 告警模板记录总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTemplatesResponse {\n");
            sb.Append("  alarmTemplates: ").Append(AlarmTemplates).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTemplatesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmTemplates == input.AlarmTemplates ||
                    this.AlarmTemplates != null &&
                    input.AlarmTemplates != null &&
                    this.AlarmTemplates.SequenceEqual(input.AlarmTemplates)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.AlarmTemplates != null)
                    hashCode = hashCode * 59 + this.AlarmTemplates.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
