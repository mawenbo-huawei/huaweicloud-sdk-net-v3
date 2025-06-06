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
    /// Request Object
    /// </summary>
    public class ListStarRocksDbParametersRequest 
    {

        /// <summary>
        /// StarRocks实例ID，严格匹配UUID规则。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 请求语言类型。默认en-us。 取值范围： - en-us - zh-cn
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// **参数解释**：  新增子任务的场景，用于区分库参数是否支持修改。  **约束限制**：  非必填。  **取值范围**：  不涉及。  **默认值**：  不涉及。
        /// </summary>
        [SDKProperty("add_task_scenario", IsQuery = true)]
        [JsonProperty("add_task_scenario", NullValueHandling = NullValueHandling.Ignore)]
        public string AddTaskScenario { get; set; }

        /// <summary>
        /// **参数解释**：  新增子任务相应的主任务名。  **约束限制**：  非必填。  **取值范围**：  不涉及。  **默认值**：  不涉及。
        /// </summary>
        [SDKProperty("main_task_name", IsQuery = true)]
        [JsonProperty("main_task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MainTaskName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStarRocksDbParametersRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  addTaskScenario: ").Append(AddTaskScenario).Append("\n");
            sb.Append("  mainTaskName: ").Append(MainTaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStarRocksDbParametersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStarRocksDbParametersRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.AddTaskScenario != input.AddTaskScenario || (this.AddTaskScenario != null && !this.AddTaskScenario.Equals(input.AddTaskScenario))) return false;
            if (this.MainTaskName != input.MainTaskName || (this.MainTaskName != null && !this.MainTaskName.Equals(input.MainTaskName))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.AddTaskScenario != null) hashCode = hashCode * 59 + this.AddTaskScenario.GetHashCode();
                if (this.MainTaskName != null) hashCode = hashCode * 59 + this.MainTaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
