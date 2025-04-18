using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddDataRestInfoImageInfoObjects 
    {

        /// <summary>
        /// 主体目标框。
        /// </summary>
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public string Box { get; set; }

        /// <summary>
        /// 主体类目序号。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public int? Category { get; set; }

        /// <summary>
        /// 主体类目名称。
        /// </summary>
        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDataRestInfoImageInfoObjects {\n");
            sb.Append("  box: ").Append(Box).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  categoryName: ").Append(CategoryName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDataRestInfoImageInfoObjects);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDataRestInfoImageInfoObjects input)
        {
            if (input == null) return false;
            if (this.Box != input.Box || (this.Box != null && !this.Box.Equals(input.Box))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CategoryName != input.CategoryName || (this.CategoryName != null && !this.CategoryName.Equals(input.CategoryName))) return false;

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
                if (this.Box != null) hashCode = hashCode * 59 + this.Box.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CategoryName != null) hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                return hashCode;
            }
        }
    }
}
