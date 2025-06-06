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
    /// 参数解释：弹性扩缩容配置信息。负载均衡器开启弹性扩缩容后，可根据负载情况自动调整负载均衡器的规格。  约束限制： - 仅当项目白名单放开后该字段才有效 - 开启弹性扩缩容后，l4_flavor_id和l7_flavor_id表示该LB实例弹性规格的上限。  [&gt;该字段已经废弃，但仍然保留兼容性支持，建议不要使用该字段。如果传入该字段，创建的弹性实例将会有保底规格并产生对应保底规格的费用。](tag:cmcc,ctc,dc2,dt,fcs_arm,fcs_dt,fm,h3dc,hcs,hcso_dt,HEC,hk_sbc,hk_tm,hws,hws_hk,hws_ocb,hws_test,kvm,nohcs,ocb,ct,sbc,sfsturb,tlf,tlf_test,tm)  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42,hcso,hk_vdf,srg,fcs,fcs_vm,mix,hcso_g42,hcso_g42_b)
    /// </summary>
    public class CreateLoadbalancerAutoscalingOption 
    {

        /// <summary>
        /// 参数解释：负载均衡器实例弹性扩缩容开关。 [网关型LB不支持该字段。](tag:hws_eu)  取值范围：  - true：开启。  - false：关闭。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 参数解释：实例弹性扩缩容的最小七层规格ID。  约束限制： 该字段已经废弃，建议不要使用该字段。
        /// </summary>
        [JsonProperty("min_l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MinL7FlavorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadbalancerAutoscalingOption {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  minL7FlavorId: ").Append(MinL7FlavorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadbalancerAutoscalingOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadbalancerAutoscalingOption input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.MinL7FlavorId != input.MinL7FlavorId || (this.MinL7FlavorId != null && !this.MinL7FlavorId.Equals(input.MinL7FlavorId))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.MinL7FlavorId != null) hashCode = hashCode * 59 + this.MinL7FlavorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
