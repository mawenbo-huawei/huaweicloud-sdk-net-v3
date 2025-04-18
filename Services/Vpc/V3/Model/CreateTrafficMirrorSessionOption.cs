using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTrafficMirrorSessionOption 
    {

        /// <summary>
        /// 功能说明：流量镜像会话名称 取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：流量镜像会话的描述信息 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：流量镜像筛选条件ID
        /// </summary>
        [JsonProperty("traffic_mirror_filter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterId { get; set; }

        /// <summary>
        /// 功能说明：镜像源ID列表，支持弹性网卡作为镜像源。 约束：一个镜像会话默认最大支持10个镜像源。
        /// </summary>
        [JsonProperty("traffic_mirror_sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TrafficMirrorSources { get; set; }

        /// <summary>
        /// 功能说明：镜像目的ID
        /// </summary>
        [JsonProperty("traffic_mirror_target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorTargetId { get; set; }

        /// <summary>
        /// 功能说明：镜像目的类型 取值范围：     eni：弹性网卡     elb：私网弹性负载均衡
        /// </summary>
        [JsonProperty("traffic_mirror_target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorTargetType { get; set; }

        /// <summary>
        /// 功能说明：指定VNI，用于区分不同会话的镜像流量 取值范围：0~16777215 默认值：1
        /// </summary>
        [JsonProperty("virtual_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualNetworkId { get; set; }

        /// <summary>
        /// 功能说明：最大传输单元MTU 取值范围：1~1460 默认值：96
        /// </summary>
        [JsonProperty("packet_length", NullValueHandling = NullValueHandling.Ignore)]
        public string PacketLength { get; set; }

        /// <summary>
        /// 功能说明：会话优先级 取值范围：1~32766
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 功能说明：是否开启会话 取值范围：true、false 默认值：false
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string Enabled { get; set; }

        /// <summary>
        /// 功能说明：支持的镜像源类型 取值范围：     eni：弹性网卡
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrafficMirrorSessionOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  trafficMirrorFilterId: ").Append(TrafficMirrorFilterId).Append("\n");
            sb.Append("  trafficMirrorSources: ").Append(TrafficMirrorSources).Append("\n");
            sb.Append("  trafficMirrorTargetId: ").Append(TrafficMirrorTargetId).Append("\n");
            sb.Append("  trafficMirrorTargetType: ").Append(TrafficMirrorTargetType).Append("\n");
            sb.Append("  virtualNetworkId: ").Append(VirtualNetworkId).Append("\n");
            sb.Append("  packetLength: ").Append(PacketLength).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrafficMirrorSessionOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrafficMirrorSessionOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.TrafficMirrorFilterId != input.TrafficMirrorFilterId || (this.TrafficMirrorFilterId != null && !this.TrafficMirrorFilterId.Equals(input.TrafficMirrorFilterId))) return false;
            if (this.TrafficMirrorSources != input.TrafficMirrorSources || (this.TrafficMirrorSources != null && input.TrafficMirrorSources != null && !this.TrafficMirrorSources.SequenceEqual(input.TrafficMirrorSources))) return false;
            if (this.TrafficMirrorTargetId != input.TrafficMirrorTargetId || (this.TrafficMirrorTargetId != null && !this.TrafficMirrorTargetId.Equals(input.TrafficMirrorTargetId))) return false;
            if (this.TrafficMirrorTargetType != input.TrafficMirrorTargetType || (this.TrafficMirrorTargetType != null && !this.TrafficMirrorTargetType.Equals(input.TrafficMirrorTargetType))) return false;
            if (this.VirtualNetworkId != input.VirtualNetworkId || (this.VirtualNetworkId != null && !this.VirtualNetworkId.Equals(input.VirtualNetworkId))) return false;
            if (this.PacketLength != input.PacketLength || (this.PacketLength != null && !this.PacketLength.Equals(input.PacketLength))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TrafficMirrorFilterId != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterId.GetHashCode();
                if (this.TrafficMirrorSources != null) hashCode = hashCode * 59 + this.TrafficMirrorSources.GetHashCode();
                if (this.TrafficMirrorTargetId != null) hashCode = hashCode * 59 + this.TrafficMirrorTargetId.GetHashCode();
                if (this.TrafficMirrorTargetType != null) hashCode = hashCode * 59 + this.TrafficMirrorTargetType.GetHashCode();
                if (this.VirtualNetworkId != null) hashCode = hashCode * 59 + this.VirtualNetworkId.GetHashCode();
                if (this.PacketLength != null) hashCode = hashCode * 59 + this.PacketLength.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
