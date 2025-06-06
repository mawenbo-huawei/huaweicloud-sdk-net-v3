using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowHandshakeRequest 
    {

        /// <summary>
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }

        /// <summary>
        /// 邀请的唯一标识符（ID）。账号在发起邀请时创建ID。
        /// </summary>
        [SDKProperty("handshake_id", IsPath = true)]
        [JsonProperty("handshake_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HandshakeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHandshakeRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  handshakeId: ").Append(HandshakeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHandshakeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHandshakeRequest input)
        {
            if (input == null) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;
            if (this.HandshakeId != input.HandshakeId || (this.HandshakeId != null && !this.HandshakeId.Equals(input.HandshakeId))) return false;

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
                if (this.XSecurityToken != null) hashCode = hashCode * 59 + this.XSecurityToken.GetHashCode();
                if (this.HandshakeId != null) hashCode = hashCode * 59 + this.HandshakeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
