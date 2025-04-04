using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyConfigurationRequestBody 
    {

        /// <summary>
        /// 实例ID或组ID或节点ID的列表对象。可以调用“查询实例列表和详情”接口获取。如果未申请实例，可以调用“创建实例”接口创建。 - 当变更的实例类型是集群，如果变更的是shard组或者config组的参数模板，传值为组ID。如果变更的是mongos节点的参数模板，传值为节点ID。 - 当变更的实例类型是副本集或单节点，传值为实例ID。
        /// </summary>
        [JsonProperty("entity_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EntityIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyConfigurationRequestBody {\n");
            sb.Append("  entityIds: ").Append(EntityIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyConfigurationRequestBody input)
        {
            if (input == null) return false;
            if (this.EntityIds != input.EntityIds || (this.EntityIds != null && input.EntityIds != null && !this.EntityIds.SequenceEqual(input.EntityIds))) return false;

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
                if (this.EntityIds != null) hashCode = hashCode * 59 + this.EntityIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
