using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 数据库信息。
    /// </summary>
    public class GaussDBforOpenDatabaseForCreation 
    {

        /// <summary>
        /// 数据库名称。  数据库名称长度可在1～63个字符之间，由字母、数字、或下划线组成，不能包含其他特殊字符，不能以“pg”和数字开头，且不能和GaussDB 模板库重名。 GaussDB 模板库包括postgres， template0 ，template1。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库字符集。默认C。
        /// </summary>
        [JsonProperty("character_set", NullValueHandling = NullValueHandling.Ignore)]
        public string CharacterSet { get; set; }

        /// <summary>
        /// 数据库所属用户，缺省时默认是root，不能和系统用户重名，且必须是已存在的用户。  系统用户包括“rdsAdmin”,“ rdsMetric”, “rdsBackup”, “rdsRepl”。
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 数据库模板名称，仅为template0。
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }

        /// <summary>
        /// 数据库排序集。默认默认C。  - 须知： 不同的排序规则下，相同字符串的比较其结果可能是不同的。 例如，在en_US.utf8下， select &#39;a&#39;&gt;&#39;A&#39;;执行结果为false，但在&#39;C&#39;下，select &#39;a&#39;&gt;&#39;A&#39;;结果为true。如果数据库从“O”迁移到GaussDB ，数据库排序集需使用&#39;C&#39;才能得到一致的预期。支持的排序规则可以查询系统表 pg_collation。
        /// </summary>
        [JsonProperty("lc_collate", NullValueHandling = NullValueHandling.Ignore)]
        public string LcCollate { get; set; }

        /// <summary>
        /// 数据库分类集。默认C。
        /// </summary>
        [JsonProperty("lc_ctype", NullValueHandling = NullValueHandling.Ignore)]
        public string LcCtype { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBforOpenDatabaseForCreation {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  characterSet: ").Append(CharacterSet).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  lcCollate: ").Append(LcCollate).Append("\n");
            sb.Append("  lcCtype: ").Append(LcCtype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBforOpenDatabaseForCreation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBforOpenDatabaseForCreation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CharacterSet == input.CharacterSet ||
                    (this.CharacterSet != null &&
                    this.CharacterSet.Equals(input.CharacterSet))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.LcCollate == input.LcCollate ||
                    (this.LcCollate != null &&
                    this.LcCollate.Equals(input.LcCollate))
                ) && 
                (
                    this.LcCtype == input.LcCtype ||
                    (this.LcCtype != null &&
                    this.LcCtype.Equals(input.LcCtype))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CharacterSet != null)
                    hashCode = hashCode * 59 + this.CharacterSet.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.LcCollate != null)
                    hashCode = hashCode * 59 + this.LcCollate.GetHashCode();
                if (this.LcCtype != null)
                    hashCode = hashCode * 59 + this.LcCtype.GetHashCode();
                return hashCode;
            }
        }
    }
}
