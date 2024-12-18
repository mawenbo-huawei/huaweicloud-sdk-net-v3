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
    /// 包含组织成员的账号的有关信息。
    /// </summary>
    public class AccountDto 
    {

        /// <summary>
        /// 账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 账号的统一资源名称。
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }

        /// <summary>
        /// 账号加入组织的方式。invited：邀请加入，created：创建加入。
        /// </summary>
        [JsonProperty("join_method", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinMethod { get; set; }

        /// <summary>
        /// 账号当前的状态。active：有效； suspended：已关闭； pending_closure：关闭中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 账号加入组织的日期。
        /// </summary>
        [JsonProperty("joined_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JoinedAt { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 手机号前缀。
        /// </summary>
        [JsonProperty("intl_number_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string IntlNumberPrefix { get; set; }

        /// <summary>
        /// 与此账号关联的电子邮件地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("  joinMethod: ").Append(JoinMethod).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  joinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  intlNumberPrefix: ").Append(IntlNumberPrefix).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Urn != input.Urn || (this.Urn != null && !this.Urn.Equals(input.Urn))) return false;
            if (this.JoinMethod != input.JoinMethod || (this.JoinMethod != null && !this.JoinMethod.Equals(input.JoinMethod))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.JoinedAt != input.JoinedAt || (this.JoinedAt != null && !this.JoinedAt.Equals(input.JoinedAt))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.IntlNumberPrefix != input.IntlNumberPrefix || (this.IntlNumberPrefix != null && !this.IntlNumberPrefix.Equals(input.IntlNumberPrefix))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Urn != null) hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.JoinMethod != null) hashCode = hashCode * 59 + this.JoinMethod.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.JoinedAt != null) hashCode = hashCode * 59 + this.JoinedAt.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.IntlNumberPrefix != null) hashCode = hashCode * 59 + this.IntlNumberPrefix.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
