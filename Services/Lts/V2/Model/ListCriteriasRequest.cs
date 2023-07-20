using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCriteriasRequest 
    {

        /// <summary>
        /// 租户想查询的日志流所在的日志组的groupid，一般为36位字符串。  缺省值：None  最小长度：36  最大长度：36
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [SDKProperty("topic_id", IsPath = true)]
        [JsonProperty("topic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicId { get; set; }

        /// <summary>
        /// 原始日志：ORIGINALLOG 可视化日志: VISUALIZATION
        /// </summary>
        [SDKProperty("search_type", IsQuery = true)]
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCriteriasRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  topicId: ").Append(TopicId).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCriteriasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCriteriasRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.TopicId == input.TopicId ||
                    (this.TopicId != null &&
                    this.TopicId.Equals(input.TopicId))
                ) && 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.TopicId != null)
                    hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
