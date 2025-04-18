using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateInstancePeriodRequestProductInfos 
    {

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 服务类型： - hws.service.type.dbss
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型: - hws.resource.type.dbss
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源规格： - dbss.bypassaudit.low - dbss.bypassaudit.medium - dbss.bypassaudit.high
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 产品规格描述。json字符串格式 ：{\&quot;specDesc\&quot;:{\&quot;zh-cn\&quot;:{\&quot;key1\&quot;:\&quot;value1\&quot;},\&quot;en-us\&quot;:{\&quot;key1\&quot;:\&quot;value1\&quot;}}}。key和value为用户自定义希望展示的产品描述信息。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstancePeriodRequestProductInfos {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstancePeriodRequestProductInfos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstancePeriodRequestProductInfos input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
