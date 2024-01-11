using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 待删除的用户/客户端流控配置
    /// </summary>
    public class DeleteKafkaUserClientQuotaTaskReq 
    {

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("client", NullValueHandling = NullValueHandling.Ignore)]
        public string Client { get; set; }

        /// <summary>
        /// 是否使用用户默认设置（是则表示对全部用户限流）。
        /// </summary>
        [JsonProperty("user-default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserDefault { get; set; }

        /// <summary>
        /// 是否使用客户端默认设置（是则表示对全部客户端限流）。
        /// </summary>
        [JsonProperty("client-default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClientDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteKafkaUserClientQuotaTaskReq {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  _Client: ").Append(Client).Append("\n");
            sb.Append("  userDefault: ").Append(UserDefault).Append("\n");
            sb.Append("  clientDefault: ").Append(ClientDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteKafkaUserClientQuotaTaskReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteKafkaUserClientQuotaTaskReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Client == input.Client ||
                    (this.Client != null &&
                    this.Client.Equals(input.Client))
                ) && 
                (
                    this.UserDefault == input.UserDefault ||
                    (this.UserDefault != null &&
                    this.UserDefault.Equals(input.UserDefault))
                ) && 
                (
                    this.ClientDefault == input.ClientDefault ||
                    (this.ClientDefault != null &&
                    this.ClientDefault.Equals(input.ClientDefault))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Client != null)
                    hashCode = hashCode * 59 + this.Client.GetHashCode();
                if (this.UserDefault != null)
                    hashCode = hashCode * 59 + this.UserDefault.GetHashCode();
                if (this.ClientDefault != null)
                    hashCode = hashCode * 59 + this.ClientDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}