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
    /// 
    /// </summary>
    public class GetQuerySearchCriteriasBody 
    {

        /// <summary>
        /// 快速查询字段
        /// </summary>
        [JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)]
        public string Criteria { get; set; }

        /// <summary>
        /// 快速查询名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 快速查询id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 快速查询类型： 原始日志：ORIGINALLOG 可视化日志: VISUALIZATION
        /// </summary>
        [JsonProperty("search_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetQuerySearchCriteriasBody {\n");
            sb.Append("  criteria: ").Append(Criteria).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  searchType: ").Append(SearchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetQuerySearchCriteriasBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetQuerySearchCriteriasBody input)
        {
            if (input == null) return false;
            if (this.Criteria != input.Criteria || (this.Criteria != null && !this.Criteria.Equals(input.Criteria))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SearchType != input.SearchType || (this.SearchType != null && !this.SearchType.Equals(input.SearchType))) return false;

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
                if (this.Criteria != null) hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SearchType != null) hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
