using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DescribeGroupMembershipRequest 
    {

        /// <summary>
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }

        /// <summary>
        /// 身份源的全局唯一标识符（ID）
        /// </summary>
        [SDKProperty("identity_store_id", IsPath = true)]
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// 身份源中用户和组关联关系的全局唯一标识符（ID）
        /// </summary>
        [SDKProperty("membership_id", IsPath = true)]
        [JsonProperty("membership_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MembershipId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeGroupMembershipRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  membershipId: ").Append(MembershipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeGroupMembershipRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeGroupMembershipRequest input)
        {
            if (input == null) return false;
            if (this.XSecurityToken != input.XSecurityToken || (this.XSecurityToken != null && !this.XSecurityToken.Equals(input.XSecurityToken))) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.MembershipId != input.MembershipId || (this.MembershipId != null && !this.MembershipId.Equals(input.MembershipId))) return false;

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
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                if (this.MembershipId != null) hashCode = hashCode * 59 + this.MembershipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
