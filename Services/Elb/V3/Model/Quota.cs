using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 负载均衡相关各类资源的配额信息。仅返回资源的总配额，不包括剩余可用配额。
    /// </summary>
    public class Quota 
    {

        /// <summary>
        /// 参数解释：项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 负载均衡器配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public int? Loadbalancer { get; set; }

        /// <summary>
        /// 证书配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Certificate { get; set; }

        /// <summary>
        /// 监听器配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("listener", NullValueHandling = NullValueHandling.Ignore)]
        public int? Listener { get; set; }

        /// <summary>
        /// 转发策略配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("l7policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? L7policy { get; set; }

        /// <summary>
        /// 单个转发策略下所有转发规则的condition总数配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("condition_per_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConditionPerPolicy { get; set; }

        /// <summary>
        /// 后端服务器组配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("pool", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pool { get; set; }

        /// <summary>
        /// 健康检查配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("healthmonitor", NullValueHandling = NullValueHandling.Ignore)]
        public int? Healthmonitor { get; set; }

        /// <summary>
        /// 后端服务器配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public int? Member { get; set; }

        /// <summary>
        /// 单个pool下的member的配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("members_per_pool", NullValueHandling = NullValueHandling.Ignore)]
        public int? MembersPerPool { get; set; }

        /// <summary>
        /// 单个监听器下的pool的配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("listeners_per_pool", NullValueHandling = NullValueHandling.Ignore)]
        public int? ListenersPerPool { get; set; }

        /// <summary>
        /// IP地址组配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。  [不支持该字段，请勿使用。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ipgroup { get; set; }

        /// <summary>
        /// 单个IP地址组可以关联的监听器数量配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。  [不支持该字段，请勿使用。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("ipgroup_bindings", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpgroupBindings { get; set; }

        /// <summary>
        /// 单个监听器下关联的所有IP地址组的ip列表中的IP总数不能超过ipgroup_max_length。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。  [不支持该字段，请勿使用。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("ipgroup_max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpgroupMaxLength { get; set; }

        /// <summary>
        /// 自定义安全策略配额。  取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。  [不支持该字段，请勿使用。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("security_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecurityPolicy { get; set; }

        /// <summary>
        /// 单个LB实例下的监听器配额。 取值： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。  &gt; 当前单个LB下监听器配额实际未限制，但建议不要超过默认配额。
        /// </summary>
        [JsonProperty("listeners_per_loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public int? ListenersPerLoadbalancer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  loadbalancer: ").Append(Loadbalancer).Append("\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  listener: ").Append(Listener).Append("\n");
            sb.Append("  l7policy: ").Append(L7policy).Append("\n");
            sb.Append("  conditionPerPolicy: ").Append(ConditionPerPolicy).Append("\n");
            sb.Append("  pool: ").Append(Pool).Append("\n");
            sb.Append("  healthmonitor: ").Append(Healthmonitor).Append("\n");
            sb.Append("  member: ").Append(Member).Append("\n");
            sb.Append("  membersPerPool: ").Append(MembersPerPool).Append("\n");
            sb.Append("  listenersPerPool: ").Append(ListenersPerPool).Append("\n");
            sb.Append("  ipgroup: ").Append(Ipgroup).Append("\n");
            sb.Append("  ipgroupBindings: ").Append(IpgroupBindings).Append("\n");
            sb.Append("  ipgroupMaxLength: ").Append(IpgroupMaxLength).Append("\n");
            sb.Append("  securityPolicy: ").Append(SecurityPolicy).Append("\n");
            sb.Append("  listenersPerLoadbalancer: ").Append(ListenersPerLoadbalancer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Quota input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Loadbalancer == input.Loadbalancer ||
                    (this.Loadbalancer != null &&
                    this.Loadbalancer.Equals(input.Loadbalancer))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Listener == input.Listener ||
                    (this.Listener != null &&
                    this.Listener.Equals(input.Listener))
                ) && 
                (
                    this.L7policy == input.L7policy ||
                    (this.L7policy != null &&
                    this.L7policy.Equals(input.L7policy))
                ) && 
                (
                    this.ConditionPerPolicy == input.ConditionPerPolicy ||
                    (this.ConditionPerPolicy != null &&
                    this.ConditionPerPolicy.Equals(input.ConditionPerPolicy))
                ) && 
                (
                    this.Pool == input.Pool ||
                    (this.Pool != null &&
                    this.Pool.Equals(input.Pool))
                ) && 
                (
                    this.Healthmonitor == input.Healthmonitor ||
                    (this.Healthmonitor != null &&
                    this.Healthmonitor.Equals(input.Healthmonitor))
                ) && 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    this.MembersPerPool == input.MembersPerPool ||
                    (this.MembersPerPool != null &&
                    this.MembersPerPool.Equals(input.MembersPerPool))
                ) && 
                (
                    this.ListenersPerPool == input.ListenersPerPool ||
                    (this.ListenersPerPool != null &&
                    this.ListenersPerPool.Equals(input.ListenersPerPool))
                ) && 
                (
                    this.Ipgroup == input.Ipgroup ||
                    (this.Ipgroup != null &&
                    this.Ipgroup.Equals(input.Ipgroup))
                ) && 
                (
                    this.IpgroupBindings == input.IpgroupBindings ||
                    (this.IpgroupBindings != null &&
                    this.IpgroupBindings.Equals(input.IpgroupBindings))
                ) && 
                (
                    this.IpgroupMaxLength == input.IpgroupMaxLength ||
                    (this.IpgroupMaxLength != null &&
                    this.IpgroupMaxLength.Equals(input.IpgroupMaxLength))
                ) && 
                (
                    this.SecurityPolicy == input.SecurityPolicy ||
                    (this.SecurityPolicy != null &&
                    this.SecurityPolicy.Equals(input.SecurityPolicy))
                ) && 
                (
                    this.ListenersPerLoadbalancer == input.ListenersPerLoadbalancer ||
                    (this.ListenersPerLoadbalancer != null &&
                    this.ListenersPerLoadbalancer.Equals(input.ListenersPerLoadbalancer))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Loadbalancer != null)
                    hashCode = hashCode * 59 + this.Loadbalancer.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Listener != null)
                    hashCode = hashCode * 59 + this.Listener.GetHashCode();
                if (this.L7policy != null)
                    hashCode = hashCode * 59 + this.L7policy.GetHashCode();
                if (this.ConditionPerPolicy != null)
                    hashCode = hashCode * 59 + this.ConditionPerPolicy.GetHashCode();
                if (this.Pool != null)
                    hashCode = hashCode * 59 + this.Pool.GetHashCode();
                if (this.Healthmonitor != null)
                    hashCode = hashCode * 59 + this.Healthmonitor.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.MembersPerPool != null)
                    hashCode = hashCode * 59 + this.MembersPerPool.GetHashCode();
                if (this.ListenersPerPool != null)
                    hashCode = hashCode * 59 + this.ListenersPerPool.GetHashCode();
                if (this.Ipgroup != null)
                    hashCode = hashCode * 59 + this.Ipgroup.GetHashCode();
                if (this.IpgroupBindings != null)
                    hashCode = hashCode * 59 + this.IpgroupBindings.GetHashCode();
                if (this.IpgroupMaxLength != null)
                    hashCode = hashCode * 59 + this.IpgroupMaxLength.GetHashCode();
                if (this.SecurityPolicy != null)
                    hashCode = hashCode * 59 + this.SecurityPolicy.GetHashCode();
                if (this.ListenersPerLoadbalancer != null)
                    hashCode = hashCode * 59 + this.ListenersPerLoadbalancer.GetHashCode();
                return hashCode;
            }
        }
    }
}
