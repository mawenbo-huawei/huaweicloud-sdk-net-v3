using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 批量结束与删除在线迁移任务请求体
    /// </summary>
    public class BatchDeleteJobReq 
    {

        /// <summary>
        /// 批量结束与删除任务请求列表
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteJobReq> Jobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteJobReq {\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Jobs == input.Jobs ||
                    this.Jobs != null &&
                    input.Jobs != null &&
                    this.Jobs.SequenceEqual(input.Jobs)
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
                if (this.Jobs != null)
                    hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                return hashCode;
            }
        }
    }
}