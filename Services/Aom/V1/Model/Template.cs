using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 变更服务模板模板元数据。
    /// </summary>
    public class Template 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approve_info", NullValueHandling = NullValueHandling.Ignore)]
        public ApproveInfo ApproveInfo { get; set; }

        /// <summary>
        /// 模板创建人，从接口调用传入的token中获取。
        /// </summary>
        [JsonProperty("create_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 模板创建时间，为utc时间毫秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 模板id，唯一标识，根据project_id和template_name生成。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 模板是否收藏，不允许更新模板时修改，更改收藏状态调用单独的更新模板收藏状态接口
        /// </summary>
        [JsonProperty("is_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCollect { get; set; }

        /// <summary>
        /// 是否发布成服务
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// 作业id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 作业版本
        /// </summary>
        [JsonProperty("job_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobVersion { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否需要同步
        /// </summary>
        [JsonProperty("need_synchronize", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedSynchronize { get; set; }

        /// <summary>
        /// 任务执行时需要的参数列表。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Node> Nodes { get; set; }

        /// <summary>
        /// 任务执行时需要的参数列表。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 引用参数
        /// </summary>
        [JsonProperty("quote", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Quote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rate_control", NullValueHandling = NullValueHandling.Ignore)]
        public RateControl RateControl { get; set; }

        /// <summary>
        /// 默认模板为public，自定义模板为private
        /// </summary>
        [JsonProperty("share_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareType { get; set; }

        /// <summary>
        /// 作业步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Step> Steps { get; set; }

        /// <summary>
        /// 模板更新人，从接口调用传入的token中获取。
        /// </summary>
        [JsonProperty("update_by", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateBy { get; set; }

        /// <summary>
        /// 模板更新时间，为utc时间毫秒数。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 模板版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Template {\n");
            sb.Append("  approveInfo: ").Append(ApproveInfo).Append("\n");
            sb.Append("  createBy: ").Append(CreateBy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isCollect: ").Append(IsCollect).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobVersion: ").Append(JobVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  needSynchronize: ").Append(NeedSynchronize).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  quote: ").Append(Quote).Append("\n");
            sb.Append("  rateControl: ").Append(RateControl).Append("\n");
            sb.Append("  shareType: ").Append(ShareType).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  updateBy: ").Append(UpdateBy).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Template);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Template input)
        {
            if (input == null) return false;
            if (this.ApproveInfo != input.ApproveInfo || (this.ApproveInfo != null && !this.ApproveInfo.Equals(input.ApproveInfo))) return false;
            if (this.CreateBy != input.CreateBy || (this.CreateBy != null && !this.CreateBy.Equals(input.CreateBy))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsCollect != input.IsCollect || (this.IsCollect != null && !this.IsCollect.Equals(input.IsCollect))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobVersion != input.JobVersion || (this.JobVersion != null && !this.JobVersion.Equals(input.JobVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NeedSynchronize != input.NeedSynchronize || (this.NeedSynchronize != null && !this.NeedSynchronize.Equals(input.NeedSynchronize))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Quote != input.Quote || (this.Quote != null && input.Quote != null && !this.Quote.SequenceEqual(input.Quote))) return false;
            if (this.RateControl != input.RateControl || (this.RateControl != null && !this.RateControl.Equals(input.RateControl))) return false;
            if (this.ShareType != input.ShareType || (this.ShareType != null && !this.ShareType.Equals(input.ShareType))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.UpdateBy != input.UpdateBy || (this.UpdateBy != null && !this.UpdateBy.Equals(input.UpdateBy))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.ApproveInfo != null) hashCode = hashCode * 59 + this.ApproveInfo.GetHashCode();
                if (this.CreateBy != null) hashCode = hashCode * 59 + this.CreateBy.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsCollect != null) hashCode = hashCode * 59 + this.IsCollect.GetHashCode();
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobVersion != null) hashCode = hashCode * 59 + this.JobVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NeedSynchronize != null) hashCode = hashCode * 59 + this.NeedSynchronize.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Quote != null) hashCode = hashCode * 59 + this.Quote.GetHashCode();
                if (this.RateControl != null) hashCode = hashCode * 59 + this.RateControl.GetHashCode();
                if (this.ShareType != null) hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.UpdateBy != null) hashCode = hashCode * 59 + this.UpdateBy.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
