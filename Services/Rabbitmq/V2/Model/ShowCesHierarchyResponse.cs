using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowCesHierarchyResponse : SdkResponse
    {

        /// <summary>
        /// 监控维度。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespDimensions> Dimensions { get; set; }

        /// <summary>
        /// 实例信息。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespInstanceIds> InstanceIds { get; set; }

        /// <summary>
        /// 节点信息。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespNodes> Nodes { get; set; }

        /// <summary>
        /// Queue信息。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespQueues> Queues { get; set; }

        /// <summary>
        /// Vhost信息
        /// </summary>
        [JsonProperty("vhosts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespVhosts> Vhosts { get; set; }

        /// <summary>
        /// exchange信息
        /// </summary>
        [JsonProperty("exchanges", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespExchanges> Exchanges { get; set; }

        /// <summary>
        /// 消费组信息。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowCeshierarchyRespGroups> Groups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCesHierarchyResponse {\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  queues: ").Append(Queues).Append("\n");
            sb.Append("  vhosts: ").Append(Vhosts).Append("\n");
            sb.Append("  exchanges: ").Append(Exchanges).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCesHierarchyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCesHierarchyResponse input)
        {
            if (input == null) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.Queues != input.Queues || (this.Queues != null && input.Queues != null && !this.Queues.SequenceEqual(input.Queues))) return false;
            if (this.Vhosts != input.Vhosts || (this.Vhosts != null && input.Vhosts != null && !this.Vhosts.SequenceEqual(input.Vhosts))) return false;
            if (this.Exchanges != input.Exchanges || (this.Exchanges != null && input.Exchanges != null && !this.Exchanges.SequenceEqual(input.Exchanges))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;

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
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Queues != null) hashCode = hashCode * 59 + this.Queues.GetHashCode();
                if (this.Vhosts != null) hashCode = hashCode * 59 + this.Vhosts.GetHashCode();
                if (this.Exchanges != null) hashCode = hashCode * 59 + this.Exchanges.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                return hashCode;
            }
        }
    }
}
