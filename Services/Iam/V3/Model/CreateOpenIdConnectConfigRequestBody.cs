using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 请求体
    /// </summary>
    public class CreateOpenIdConnectConfigRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("openid_connect_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateOpenIdConnectConfig OpenidConnectConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOpenIdConnectConfigRequestBody {\n");
            sb.Append("  openidConnectConfig: ").Append(OpenidConnectConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOpenIdConnectConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOpenIdConnectConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpenidConnectConfig == input.OpenidConnectConfig ||
                    (this.OpenidConnectConfig != null &&
                    this.OpenidConnectConfig.Equals(input.OpenidConnectConfig))
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
                if (this.OpenidConnectConfig != null)
                    hashCode = hashCode * 59 + this.OpenidConnectConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
