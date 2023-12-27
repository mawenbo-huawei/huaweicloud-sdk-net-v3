using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 更新构建任务请求体
    /// </summary>
    public class UpdateBuildJobRequestBody 
    {

        /// <summary>
        /// 使用机器的架构
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }

        /// <summary>
        /// 构建任务所在项目的ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 构建任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 是否自动更新子模块
        /// </summary>
        [JsonProperty("auto_update_sub_module", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoUpdateSubModule { get; set; }

        /// <summary>
        /// 执行机规格
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 构建执行参数列表
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateBuildJobParameter> Parameters { get; set; }

        /// <summary>
        /// 构建执行SCM
        /// </summary>
        [JsonProperty("scms", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateBuildJobScm> Scms { get; set; }

        /// <summary>
        /// 构建执行的步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateBuildJobSteps> Steps { get; set; }

        /// <summary>
        /// host类型
        /// </summary>
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HostType { get; set; }

        /// <summary>
        /// 构建的配置类型
        /// </summary>
        [JsonProperty("build_config_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildConfigType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBuildJobRequestBody {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  autoUpdateSubModule: ").Append(AutoUpdateSubModule).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  scms: ").Append(Scms).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  buildConfigType: ").Append(BuildConfigType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBuildJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBuildJobRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arch == input.Arch ||
                    (this.Arch != null &&
                    this.Arch.Equals(input.Arch))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.AutoUpdateSubModule == input.AutoUpdateSubModule ||
                    (this.AutoUpdateSubModule != null &&
                    this.AutoUpdateSubModule.Equals(input.AutoUpdateSubModule))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Scms == input.Scms ||
                    this.Scms != null &&
                    input.Scms != null &&
                    this.Scms.SequenceEqual(input.Scms)
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.BuildConfigType == input.BuildConfigType ||
                    (this.BuildConfigType != null &&
                    this.BuildConfigType.Equals(input.BuildConfigType))
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
                if (this.Arch != null)
                    hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.AutoUpdateSubModule != null)
                    hashCode = hashCode * 59 + this.AutoUpdateSubModule.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Scms != null)
                    hashCode = hashCode * 59 + this.Scms.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.BuildConfigType != null)
                    hashCode = hashCode * 59 + this.BuildConfigType.GetHashCode();
                return hashCode;
            }
        }
    }
}
