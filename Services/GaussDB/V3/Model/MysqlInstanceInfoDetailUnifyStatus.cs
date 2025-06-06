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
    /// 
    /// </summary>
    public class MysqlInstanceInfoDetailUnifyStatus 
    {

        /// <summary>
        /// 实例ID，严格匹配UUID规则。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 创建的实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 租户在某一Region下的project ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例状态。  取值： - 值为“creating”，表示实例正在创建。 - 值为“normal”，表示实例正常。 - 值为“abnormal”，表示实例异常。 - 值为“createfail”，表示实例创建失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据库端口号。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 实例备注
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 实例类型，取Cluster”。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlInstanceChargeInfo ChargeInfo { get; set; }

        /// <summary>
        /// 节点个数。
        /// </summary>
        [JsonProperty("node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlDatastoreWithKernelVersion Datastore { get; set; }

        /// <summary>
        /// 备份空间使用大小，单位为GB。
        /// </summary>
        [JsonProperty("backup_used_space", NullValueHandling = NullValueHandling.Ignore)]
        public double? BackupUsedSpace { get; set; }

        /// <summary>
        /// 创建时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。  其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式与\&quot;created\&quot;字段对应格式完全相同。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 实例的写内网IP地址。
        /// </summary>
        [JsonProperty("private_write_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateWriteIps { get; set; }

        /// <summary>
        /// 实例内网域名列表。实例创建成功后，需要手动申请内网域名，否则查询内网域名为空。
        /// </summary>
        [JsonProperty("private_dns_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateDnsNames { get; set; }

        /// <summary>
        /// 实例的公网IP地址。
        /// </summary>
        [JsonProperty("public_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIps { get; set; }

        /// <summary>
        /// 默认用户名。
        /// </summary>
        [JsonProperty("db_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUserName { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网的网络ID信息。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 实例创建的模板ID，或者应用到实例的最新参数组模板ID。
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backup_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlBackupStrategy BackupStrategy { get; set; }

        /// <summary>
        /// 节点信息。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlInstanceNodeInfo> Nodes { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 可用区模式。  取值范围： - single：单可用区。 - multi：多可用区。
        /// </summary>
        [JsonProperty("az_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AzMode { get; set; }

        /// <summary>
        /// 主可用区。
        /// </summary>
        [JsonProperty("master_az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAzCode { get; set; }

        /// <summary>
        /// 可维护时间窗，为UTC时间。
        /// </summary>
        [JsonProperty("maintenance_window", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintenanceWindow { get; set; }

        /// <summary>
        /// 实例标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlTags> Tags { get; set; }

        /// <summary>
        /// 专属资源池ID，只有数据库实例属于专属资源池才会返回该参数。
        /// </summary>
        [JsonProperty("dedicated_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedResourceId { get; set; }

        /// <summary>
        /// 代理信息。
        /// </summary>
        [JsonProperty("proxies", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyInfo> Proxies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tde_info", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlTdeInfo TdeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlInstanceInfoDetailUnifyStatus {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("  nodeCount: ").Append(NodeCount).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  backupUsedSpace: ").Append(BackupUsedSpace).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  privateWriteIps: ").Append(PrivateWriteIps).Append("\n");
            sb.Append("  privateDnsNames: ").Append(PrivateDnsNames).Append("\n");
            sb.Append("  publicIps: ").Append(PublicIps).Append("\n");
            sb.Append("  dbUserName: ").Append(DbUserName).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  backupStrategy: ").Append(BackupStrategy).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  azMode: ").Append(AzMode).Append("\n");
            sb.Append("  masterAzCode: ").Append(MasterAzCode).Append("\n");
            sb.Append("  maintenanceWindow: ").Append(MaintenanceWindow).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  dedicatedResourceId: ").Append(DedicatedResourceId).Append("\n");
            sb.Append("  proxies: ").Append(Proxies).Append("\n");
            sb.Append("  tdeInfo: ").Append(TdeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlInstanceInfoDetailUnifyStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlInstanceInfoDetailUnifyStatus input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ChargeInfo != input.ChargeInfo || (this.ChargeInfo != null && !this.ChargeInfo.Equals(input.ChargeInfo))) return false;
            if (this.NodeCount != input.NodeCount || (this.NodeCount != null && !this.NodeCount.Equals(input.NodeCount))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.BackupUsedSpace != input.BackupUsedSpace || (this.BackupUsedSpace != null && !this.BackupUsedSpace.Equals(input.BackupUsedSpace))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.PrivateWriteIps != input.PrivateWriteIps || (this.PrivateWriteIps != null && input.PrivateWriteIps != null && !this.PrivateWriteIps.SequenceEqual(input.PrivateWriteIps))) return false;
            if (this.PrivateDnsNames != input.PrivateDnsNames || (this.PrivateDnsNames != null && input.PrivateDnsNames != null && !this.PrivateDnsNames.SequenceEqual(input.PrivateDnsNames))) return false;
            if (this.PublicIps != input.PublicIps || (this.PublicIps != null && !this.PublicIps.Equals(input.PublicIps))) return false;
            if (this.DbUserName != input.DbUserName || (this.DbUserName != null && !this.DbUserName.Equals(input.DbUserName))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.ConfigurationId != input.ConfigurationId || (this.ConfigurationId != null && !this.ConfigurationId.Equals(input.ConfigurationId))) return false;
            if (this.BackupStrategy != input.BackupStrategy || (this.BackupStrategy != null && !this.BackupStrategy.Equals(input.BackupStrategy))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.AzMode != input.AzMode || (this.AzMode != null && !this.AzMode.Equals(input.AzMode))) return false;
            if (this.MasterAzCode != input.MasterAzCode || (this.MasterAzCode != null && !this.MasterAzCode.Equals(input.MasterAzCode))) return false;
            if (this.MaintenanceWindow != input.MaintenanceWindow || (this.MaintenanceWindow != null && !this.MaintenanceWindow.Equals(input.MaintenanceWindow))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.DedicatedResourceId != input.DedicatedResourceId || (this.DedicatedResourceId != null && !this.DedicatedResourceId.Equals(input.DedicatedResourceId))) return false;
            if (this.Proxies != input.Proxies || (this.Proxies != null && input.Proxies != null && !this.Proxies.SequenceEqual(input.Proxies))) return false;
            if (this.TdeInfo != input.TdeInfo || (this.TdeInfo != null && !this.TdeInfo.Equals(input.TdeInfo))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ChargeInfo != null) hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                if (this.NodeCount != null) hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.BackupUsedSpace != null) hashCode = hashCode * 59 + this.BackupUsedSpace.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.PrivateWriteIps != null) hashCode = hashCode * 59 + this.PrivateWriteIps.GetHashCode();
                if (this.PrivateDnsNames != null) hashCode = hashCode * 59 + this.PrivateDnsNames.GetHashCode();
                if (this.PublicIps != null) hashCode = hashCode * 59 + this.PublicIps.GetHashCode();
                if (this.DbUserName != null) hashCode = hashCode * 59 + this.DbUserName.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.ConfigurationId != null) hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.BackupStrategy != null) hashCode = hashCode * 59 + this.BackupStrategy.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.AzMode != null) hashCode = hashCode * 59 + this.AzMode.GetHashCode();
                if (this.MasterAzCode != null) hashCode = hashCode * 59 + this.MasterAzCode.GetHashCode();
                if (this.MaintenanceWindow != null) hashCode = hashCode * 59 + this.MaintenanceWindow.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DedicatedResourceId != null) hashCode = hashCode * 59 + this.DedicatedResourceId.GetHashCode();
                if (this.Proxies != null) hashCode = hashCode * 59 + this.Proxies.GetHashCode();
                if (this.TdeInfo != null) hashCode = hashCode * 59 + this.TdeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
