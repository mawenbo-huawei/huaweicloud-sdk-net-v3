using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作项属性
    /// </summary>
    public class IssueResponseV4 
    {

        /// <summary>
        /// 实际工时
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ActualWorkHours { get; set; }

        /// <summary>
        /// 抄送人
        /// </summary>
        [JsonProperty("assigned_cc_user", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueUser> AssignedCcUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_user", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser AssignedUser { get; set; }

        /// <summary>
        /// 预计开始时间，年-月-日
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 创建时间 年-月-日 时:分:秒
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser Creator { get; set; }

        /// <summary>
        /// 自定义属性值,不建议使用，建议参考new_custom_fields字段
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomField> CustomFields { get; set; }

        /// <summary>
        /// 自定义属性值
        /// </summary>
        [JsonProperty("new_custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewCustomField> NewCustomFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("developer", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser Developer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Domain Domain { get; set; }

        /// <summary>
        /// 工作项进度值
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// 预计结束时间，年-月-日
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 预计工时
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpectedWorkHours { get; set; }

        /// <summary>
        /// 工作项项id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public IssueProjectResponseV4 Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iteration", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Iteration Iteration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Module Module { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_issue", NullValueHandling = NullValueHandling.Ignore)]
        public CreateIssueResponseV4ParentIssue ParentIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Priority Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public IssueResponseV4Order Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Severity Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public IssueItemSfV4Status Status { get; set; }

        /// <summary>
        /// 工作项发布版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 缺陷发现版本号（仅Bug类型工作项具备该字段）
        /// </summary>
        [JsonProperty("find_release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string FindReleaseDev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("env", NullValueHandling = NullValueHandling.Ignore)]
        public IssueDetailResponseV4Env Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public CreateIssueResponseV4Tracker Tracker { get; set; }

        /// <summary>
        /// 更新时间 年-月-日 时:分:秒
        /// </summary>
        [JsonProperty("updated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// 关闭时间 年-月-日 时:分:秒
        /// </summary>
        [JsonProperty("closed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueResponseV4 {\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  assignedCcUser: ").Append(AssignedCcUser).Append("\n");
            sb.Append("  assignedUser: ").Append(AssignedUser).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  newCustomFields: ").Append(NewCustomFields).Append("\n");
            sb.Append("  developer: ").Append(Developer).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  parentIssue: ").Append(ParentIssue).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  findReleaseDev: ").Append(FindReleaseDev).Append("\n");
            sb.Append("  env: ").Append(Env).Append("\n");
            sb.Append("  tracker: ").Append(Tracker).Append("\n");
            sb.Append("  updatedTime: ").Append(UpdatedTime).Append("\n");
            sb.Append("  closedTime: ").Append(ClosedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueResponseV4);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueResponseV4 input)
        {
            if (input == null) return false;
            if (this.ActualWorkHours != input.ActualWorkHours || (this.ActualWorkHours != null && !this.ActualWorkHours.Equals(input.ActualWorkHours))) return false;
            if (this.AssignedCcUser != input.AssignedCcUser || (this.AssignedCcUser != null && input.AssignedCcUser != null && !this.AssignedCcUser.SequenceEqual(input.AssignedCcUser))) return false;
            if (this.AssignedUser != input.AssignedUser || (this.AssignedUser != null && !this.AssignedUser.Equals(input.AssignedUser))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.NewCustomFields != input.NewCustomFields || (this.NewCustomFields != null && input.NewCustomFields != null && !this.NewCustomFields.SequenceEqual(input.NewCustomFields))) return false;
            if (this.Developer != input.Developer || (this.Developer != null && !this.Developer.Equals(input.Developer))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ExpectedWorkHours != input.ExpectedWorkHours || (this.ExpectedWorkHours != null && !this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.Iteration != input.Iteration || (this.Iteration != null && !this.Iteration.Equals(input.Iteration))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParentIssue != input.ParentIssue || (this.ParentIssue != null && !this.ParentIssue.Equals(input.ParentIssue))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.FindReleaseDev != input.FindReleaseDev || (this.FindReleaseDev != null && !this.FindReleaseDev.Equals(input.FindReleaseDev))) return false;
            if (this.Env != input.Env || (this.Env != null && !this.Env.Equals(input.Env))) return false;
            if (this.Tracker != input.Tracker || (this.Tracker != null && !this.Tracker.Equals(input.Tracker))) return false;
            if (this.UpdatedTime != input.UpdatedTime || (this.UpdatedTime != null && !this.UpdatedTime.Equals(input.UpdatedTime))) return false;
            if (this.ClosedTime != input.ClosedTime || (this.ClosedTime != null && !this.ClosedTime.Equals(input.ClosedTime))) return false;

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
                if (this.ActualWorkHours != null) hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.AssignedCcUser != null) hashCode = hashCode * 59 + this.AssignedCcUser.GetHashCode();
                if (this.AssignedUser != null) hashCode = hashCode * 59 + this.AssignedUser.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.NewCustomFields != null) hashCode = hashCode * 59 + this.NewCustomFields.GetHashCode();
                if (this.Developer != null) hashCode = hashCode * 59 + this.Developer.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExpectedWorkHours != null) hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Iteration != null) hashCode = hashCode * 59 + this.Iteration.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentIssue != null) hashCode = hashCode * 59 + this.ParentIssue.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.FindReleaseDev != null) hashCode = hashCode * 59 + this.FindReleaseDev.GetHashCode();
                if (this.Env != null) hashCode = hashCode * 59 + this.Env.GetHashCode();
                if (this.Tracker != null) hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.UpdatedTime != null) hashCode = hashCode * 59 + this.UpdatedTime.GetHashCode();
                if (this.ClosedTime != null) hashCode = hashCode * 59 + this.ClosedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
