using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Node network parameters.
    /// </summary>
    public class AutopilotHostNetwork 
    {

        /// <summary>
        /// 用于创建控制节点的VPC的ID。  获取方法如下： - 方法1：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。 - 方法2：通过虚拟私有云服务的API接口查询。   [链接请参见[查询VPC列表](https://support.huaweicloud.com/api-vpc/vpc_api01_0003.html)](tag:hws)   [链接请参见[查询VPC列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_api01_0003.html)](tag:hws_hk) 
        /// </summary>
        [JsonProperty("vpc", NullValueHandling = NullValueHandling.Ignore)]
        public string Vpc { get; set; }

        /// <summary>
        /// 用于创建控制节点的subnet的网络ID。获取方法如下：  - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。 - 方法2：通过虚拟私有云服务的查询子网列表接口查询。   [链接请参见[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)](tag:hws)   [链接请参见[查询子网列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_subnet01_0003.html)](tag:hws_hk)  
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public string Subnet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutopilotHostNetwork {\n");
            sb.Append("  vpc: ").Append(Vpc).Append("\n");
            sb.Append("  subnet: ").Append(Subnet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutopilotHostNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutopilotHostNetwork input)
        {
            if (input == null) return false;
            if (this.Vpc != input.Vpc || (this.Vpc != null && !this.Vpc.Equals(input.Vpc))) return false;
            if (this.Subnet != input.Subnet || (this.Subnet != null && !this.Subnet.Equals(input.Subnet))) return false;

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
                if (this.Vpc != null) hashCode = hashCode * 59 + this.Vpc.GetHashCode();
                if (this.Subnet != null) hashCode = hashCode * 59 + this.Subnet.GetHashCode();
                return hashCode;
            }
        }
    }
}
