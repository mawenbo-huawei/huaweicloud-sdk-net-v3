using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 数据库帐号名称。  数据库帐号名称在1到128个字符之间，不能和系统用户名称相同。  系统用户包括：rdsadmin, rdsuser, rdsbackup, rdsmirror。
    /// </summary>
    public class SqlserverUserWithPrivilege 
    {

        /// <summary>
        /// 数据库帐号名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否为只读权限。
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlserverUserWithPrivilege {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlserverUserWithPrivilege);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlserverUserWithPrivilege input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Readonly != input.Readonly || (this.Readonly != null && !this.Readonly.Equals(input.Readonly))) return false;

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
                if (this.Readonly != null) hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                return hashCode;
            }
        }
    }
}
