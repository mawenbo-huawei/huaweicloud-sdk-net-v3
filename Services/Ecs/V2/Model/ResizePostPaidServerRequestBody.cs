using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class ResizePostPaidServerRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize", NullValueHandling = NullValueHandling.Ignore)]
        public ResizePostPaidServerOption Resize { get; set; }

        /// <summary>
        /// 是否只预检此次请求。  true：发送检查请求，不会变更云服务器规格。检查项包括是否填写了必需参数、请求格式等。  如果检查不通过，则返回对应错误。 如果检查通过，则返回202状态码。 false：发送正常请求，通过检查后并且执行变更云服务器规格请求。
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizePostPaidServerRequestBody {\n");
            sb.Append("  resize: ").Append(Resize).Append("\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizePostPaidServerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizePostPaidServerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resize == input.Resize ||
                    (this.Resize != null &&
                    this.Resize.Equals(input.Resize))
                ) && 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
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
                if (this.Resize != null)
                    hashCode = hashCode * 59 + this.Resize.GetHashCode();
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                return hashCode;
            }
        }
    }
}
