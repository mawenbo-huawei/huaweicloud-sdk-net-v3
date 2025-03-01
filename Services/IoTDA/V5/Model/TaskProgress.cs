using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 任务执行状态统计对象，用于统计任务的整体执行情况。
    /// </summary>
    public class TaskProgress 
    {

        /// <summary>
        /// 子任务总个数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 正在执行的子任务个数。
        /// </summary>
        [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Processing { get; set; }

        /// <summary>
        /// 执行成功的子任务个数。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public int? Success { get; set; }

        /// <summary>
        /// 执行失败的的子任务个数。
        /// </summary>
        [JsonProperty("fail", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fail { get; set; }

        /// <summary>
        /// 等待执行的子任务个数。
        /// </summary>
        [JsonProperty("waitting", NullValueHandling = NullValueHandling.Ignore)]
        public int? Waitting { get; set; }

        /// <summary>
        /// 失败等待重试的子任务个数。
        /// </summary>
        [JsonProperty("fail_wait_retry", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailWaitRetry { get; set; }

        /// <summary>
        /// 停止的子任务个数。
        /// </summary>
        [JsonProperty("stopped", NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; }

        /// <summary>
        /// 移除的子任务个数。
        /// </summary>
        [JsonProperty("removed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Removed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskProgress {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  processing: ").Append(Processing).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  fail: ").Append(Fail).Append("\n");
            sb.Append("  waitting: ").Append(Waitting).Append("\n");
            sb.Append("  failWaitRetry: ").Append(FailWaitRetry).Append("\n");
            sb.Append("  stopped: ").Append(Stopped).Append("\n");
            sb.Append("  removed: ").Append(Removed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskProgress);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskProgress input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Processing != input.Processing || (this.Processing != null && !this.Processing.Equals(input.Processing))) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;
            if (this.Fail != input.Fail || (this.Fail != null && !this.Fail.Equals(input.Fail))) return false;
            if (this.Waitting != input.Waitting || (this.Waitting != null && !this.Waitting.Equals(input.Waitting))) return false;
            if (this.FailWaitRetry != input.FailWaitRetry || (this.FailWaitRetry != null && !this.FailWaitRetry.Equals(input.FailWaitRetry))) return false;
            if (this.Stopped != input.Stopped || (this.Stopped != null && !this.Stopped.Equals(input.Stopped))) return false;
            if (this.Removed != input.Removed || (this.Removed != null && !this.Removed.Equals(input.Removed))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Processing != null) hashCode = hashCode * 59 + this.Processing.GetHashCode();
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Fail != null) hashCode = hashCode * 59 + this.Fail.GetHashCode();
                if (this.Waitting != null) hashCode = hashCode * 59 + this.Waitting.GetHashCode();
                if (this.FailWaitRetry != null) hashCode = hashCode * 59 + this.FailWaitRetry.GetHashCode();
                if (this.Stopped != null) hashCode = hashCode * 59 + this.Stopped.GetHashCode();
                if (this.Removed != null) hashCode = hashCode * 59 + this.Removed.GetHashCode();
                return hashCode;
            }
        }
    }
}
