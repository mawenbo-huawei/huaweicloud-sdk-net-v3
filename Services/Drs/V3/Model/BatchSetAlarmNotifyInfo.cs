using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 修改收件方式与信息体
    /// </summary>
    public class BatchSetAlarmNotifyInfo 
    {

        /// <summary>
        /// 手动输入手机号、邮箱模式时填写
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubscriptionInfo> Subscriptions { get; set; }

        /// <summary>
        /// 主题资源标识
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 订阅延迟时间
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DelayTime { get; set; }

        /// <summary>
        /// rto延迟时间
        /// </summary>
        [JsonProperty("rto_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RtoDelay { get; set; }

        /// <summary>
        /// rpo延迟时间
        /// </summary>
        [JsonProperty("rpo_delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? RpoDelay { get; set; }

        /// <summary>
        /// 异常告警是否通知用户，不填默认为false
        /// </summary>
        [JsonProperty("alarm_to_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmToUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSetAlarmNotifyInfo {\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  rtoDelay: ").Append(RtoDelay).Append("\n");
            sb.Append("  rpoDelay: ").Append(RpoDelay).Append("\n");
            sb.Append("  alarmToUser: ").Append(AlarmToUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSetAlarmNotifyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSetAlarmNotifyInfo input)
        {
            if (input == null) return false;
            if (this.Subscriptions != input.Subscriptions || (this.Subscriptions != null && input.Subscriptions != null && !this.Subscriptions.SequenceEqual(input.Subscriptions))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.RtoDelay != input.RtoDelay || (this.RtoDelay != null && !this.RtoDelay.Equals(input.RtoDelay))) return false;
            if (this.RpoDelay != input.RpoDelay || (this.RpoDelay != null && !this.RpoDelay.Equals(input.RpoDelay))) return false;
            if (this.AlarmToUser != input.AlarmToUser || (this.AlarmToUser != null && !this.AlarmToUser.Equals(input.AlarmToUser))) return false;

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
                if (this.Subscriptions != null) hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.RtoDelay != null) hashCode = hashCode * 59 + this.RtoDelay.GetHashCode();
                if (this.RpoDelay != null) hashCode = hashCode * 59 + this.RpoDelay.GetHashCode();
                if (this.AlarmToUser != null) hashCode = hashCode * 59 + this.AlarmToUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
