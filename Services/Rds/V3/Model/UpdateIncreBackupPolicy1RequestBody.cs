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
    /// update incre backup policy
    /// </summary>
    public class UpdateIncreBackupPolicy1RequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("incre_backup_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ShowIncreBackupPolicyRespBodyIncreBackupPolicy IncreBackupPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateIncreBackupPolicy1RequestBody {\n");
            sb.Append("  increBackupPolicy: ").Append(IncreBackupPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateIncreBackupPolicy1RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateIncreBackupPolicy1RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncreBackupPolicy == input.IncreBackupPolicy ||
                    (this.IncreBackupPolicy != null &&
                    this.IncreBackupPolicy.Equals(input.IncreBackupPolicy))
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
                if (this.IncreBackupPolicy != null)
                    hashCode = hashCode * 59 + this.IncreBackupPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
