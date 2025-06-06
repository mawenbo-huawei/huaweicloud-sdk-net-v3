using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFunctionStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> Count { get; set; }

        /// <summary>
        /// 平均时延，单位毫秒
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> Duration { get; set; }

        /// <summary>
        /// 错误次数
        /// </summary>
        [JsonProperty("fail_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> FailCount { get; set; }

        /// <summary>
        /// 最大时延，单位毫秒
        /// </summary>
        [JsonProperty("max_duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> MaxDuration { get; set; }

        /// <summary>
        /// 最小时延，单位毫秒
        /// </summary>
        [JsonProperty("min_duration", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> MinDuration { get; set; }

        /// <summary>
        /// 被拒绝次数
        /// </summary>
        [JsonProperty("reject_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> RejectCount { get; set; }

        /// <summary>
        /// 函数错误次数
        /// </summary>
        [JsonProperty("function_error_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> FunctionErrorCount { get; set; }

        /// <summary>
        /// 系统错误次数
        /// </summary>
        [JsonProperty("system_error_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> SystemErrorCount { get; set; }

        /// <summary>
        /// 预留实例指标
        /// </summary>
        [JsonProperty("reserved_instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> ReservedInstanceNum { get; set; }

        /// <summary>
        /// 弹性实例指标
        /// </summary>
        [JsonProperty("concurrency_num", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlaReportsValue> ConcurrencyNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionStatisticsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  failCount: ").Append(FailCount).Append("\n");
            sb.Append("  maxDuration: ").Append(MaxDuration).Append("\n");
            sb.Append("  minDuration: ").Append(MinDuration).Append("\n");
            sb.Append("  rejectCount: ").Append(RejectCount).Append("\n");
            sb.Append("  functionErrorCount: ").Append(FunctionErrorCount).Append("\n");
            sb.Append("  systemErrorCount: ").Append(SystemErrorCount).Append("\n");
            sb.Append("  reservedInstanceNum: ").Append(ReservedInstanceNum).Append("\n");
            sb.Append("  concurrencyNum: ").Append(ConcurrencyNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && input.Count != null && !this.Count.SequenceEqual(input.Count))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && input.Duration != null && !this.Duration.SequenceEqual(input.Duration))) return false;
            if (this.FailCount != input.FailCount || (this.FailCount != null && input.FailCount != null && !this.FailCount.SequenceEqual(input.FailCount))) return false;
            if (this.MaxDuration != input.MaxDuration || (this.MaxDuration != null && input.MaxDuration != null && !this.MaxDuration.SequenceEqual(input.MaxDuration))) return false;
            if (this.MinDuration != input.MinDuration || (this.MinDuration != null && input.MinDuration != null && !this.MinDuration.SequenceEqual(input.MinDuration))) return false;
            if (this.RejectCount != input.RejectCount || (this.RejectCount != null && input.RejectCount != null && !this.RejectCount.SequenceEqual(input.RejectCount))) return false;
            if (this.FunctionErrorCount != input.FunctionErrorCount || (this.FunctionErrorCount != null && input.FunctionErrorCount != null && !this.FunctionErrorCount.SequenceEqual(input.FunctionErrorCount))) return false;
            if (this.SystemErrorCount != input.SystemErrorCount || (this.SystemErrorCount != null && input.SystemErrorCount != null && !this.SystemErrorCount.SequenceEqual(input.SystemErrorCount))) return false;
            if (this.ReservedInstanceNum != input.ReservedInstanceNum || (this.ReservedInstanceNum != null && input.ReservedInstanceNum != null && !this.ReservedInstanceNum.SequenceEqual(input.ReservedInstanceNum))) return false;
            if (this.ConcurrencyNum != input.ConcurrencyNum || (this.ConcurrencyNum != null && input.ConcurrencyNum != null && !this.ConcurrencyNum.SequenceEqual(input.ConcurrencyNum))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.FailCount != null) hashCode = hashCode * 59 + this.FailCount.GetHashCode();
                if (this.MaxDuration != null) hashCode = hashCode * 59 + this.MaxDuration.GetHashCode();
                if (this.MinDuration != null) hashCode = hashCode * 59 + this.MinDuration.GetHashCode();
                if (this.RejectCount != null) hashCode = hashCode * 59 + this.RejectCount.GetHashCode();
                if (this.FunctionErrorCount != null) hashCode = hashCode * 59 + this.FunctionErrorCount.GetHashCode();
                if (this.SystemErrorCount != null) hashCode = hashCode * 59 + this.SystemErrorCount.GetHashCode();
                if (this.ReservedInstanceNum != null) hashCode = hashCode * 59 + this.ReservedInstanceNum.GetHashCode();
                if (this.ConcurrencyNum != null) hashCode = hashCode * 59 + this.ConcurrencyNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
