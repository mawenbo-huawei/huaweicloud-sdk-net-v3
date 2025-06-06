using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusterStatus 
    {

        /// <summary>
        /// 集群状态，取值如下 - Available：可用，表示集群处于正常状态。 - Unavailable：不可用，表示集群异常，需手动删除。 - ScalingUp：扩容中，表示集群正处于扩容过程中。 - ScalingDown：缩容中，表示集群正处于缩容过程中。 - Creating：创建中，表示集群正处于创建过程中。 - Deleting：删除中，表示集群正处于删除过程中。 - Upgrading：升级中，表示集群正处于升级过程中。 - Resizing：规格变更中，表示集群正处于变更规格中。 - RollingBack：回滚中，表示集群正处于回滚过程中。 - RollbackFailed：回滚异常，表示集群回滚异常。 - Hibernating：休眠中，表示集群正处于休眠过程中。 - Hibernation：已休眠，表示集群正处于休眠状态。 - Awaking：唤醒中，表示集群正处于从休眠状态唤醒的过程中。 - Empty：集群无任何资源（已废弃） - Error：错误，表示集群资源异常，可尝试手动删除。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 任务ID,集群当前状态关联的任务ID。当前支持: - 创建集群时返回关联的任务ID，可通过任务ID查询创建集群的附属任务信息； - 删除集群或者删除集群失败时返回关联的任务ID，此字段非空时，可通过任务ID查询删除集群的附属任务信息。 &gt; 任务信息具有一定时效性，仅用于短期跟踪任务进度，请勿用于集群状态判断等额外场景。
        /// </summary>
        [JsonProperty("jobID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobID { get; set; }

        /// <summary>
        /// 集群变为当前状态的原因，在集群在非“Available”状态下时，会返回此参数。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 集群变为当前状态的原因的详细信息，在集群在非“Available”状态下时，会返回此参数。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 集群中 kube-apiserver 的访问地址。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClusterEndpoints> Endpoints { get; set; }

        /// <summary>
        /// CBC资源锁定
        /// </summary>
        [JsonProperty("isLocked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// CBC资源锁定场景
        /// </summary>
        [JsonProperty("lockScene", NullValueHandling = NullValueHandling.Ignore)]
        public string LockScene { get; set; }

        /// <summary>
        /// 锁定资源
        /// </summary>
        [JsonProperty("lockSource", NullValueHandling = NullValueHandling.Ignore)]
        public string LockSource { get; set; }

        /// <summary>
        /// 锁定的资源ID
        /// </summary>
        [JsonProperty("lockSourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string LockSourceId { get; set; }

        /// <summary>
        /// 删除配置状态（仅删除请求响应包含）
        /// </summary>
        [JsonProperty("deleteOption", NullValueHandling = NullValueHandling.Ignore)]
        public Object DeleteOption { get; set; }

        /// <summary>
        /// 删除状态信息（仅删除请求响应包含）
        /// </summary>
        [JsonProperty("deleteStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Object DeleteStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  isLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  lockScene: ").Append(LockScene).Append("\n");
            sb.Append("  lockSource: ").Append(LockSource).Append("\n");
            sb.Append("  lockSourceId: ").Append(LockSourceId).Append("\n");
            sb.Append("  deleteOption: ").Append(DeleteOption).Append("\n");
            sb.Append("  deleteStatus: ").Append(DeleteStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.JobID != input.JobID || (this.JobID != null && !this.JobID.Equals(input.JobID))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && input.Endpoints != null && !this.Endpoints.SequenceEqual(input.Endpoints))) return false;
            if (this.IsLocked != input.IsLocked || (this.IsLocked != null && !this.IsLocked.Equals(input.IsLocked))) return false;
            if (this.LockScene != input.LockScene || (this.LockScene != null && !this.LockScene.Equals(input.LockScene))) return false;
            if (this.LockSource != input.LockSource || (this.LockSource != null && !this.LockSource.Equals(input.LockSource))) return false;
            if (this.LockSourceId != input.LockSourceId || (this.LockSourceId != null && !this.LockSourceId.Equals(input.LockSourceId))) return false;
            if (this.DeleteOption != input.DeleteOption || (this.DeleteOption != null && !this.DeleteOption.Equals(input.DeleteOption))) return false;
            if (this.DeleteStatus != input.DeleteStatus || (this.DeleteStatus != null && !this.DeleteStatus.Equals(input.DeleteStatus))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.JobID != null) hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Endpoints != null) hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.IsLocked != null) hashCode = hashCode * 59 + this.IsLocked.GetHashCode();
                if (this.LockScene != null) hashCode = hashCode * 59 + this.LockScene.GetHashCode();
                if (this.LockSource != null) hashCode = hashCode * 59 + this.LockSource.GetHashCode();
                if (this.LockSourceId != null) hashCode = hashCode * 59 + this.LockSourceId.GetHashCode();
                if (this.DeleteOption != null) hashCode = hashCode * 59 + this.DeleteOption.GetHashCode();
                if (this.DeleteStatus != null) hashCode = hashCode * 59 + this.DeleteStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
