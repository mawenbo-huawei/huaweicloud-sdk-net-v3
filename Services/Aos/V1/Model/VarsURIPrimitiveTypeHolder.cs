using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VarsURIPrimitiveTypeHolder 
    {

        /// <summary>
        /// HCL支持参数，即，同一个模板可以给予不同的参数而达到不同的效果  * vars_uri需要指向一个OBS的pre-signed URL地址，其他地址暂不支持  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * vars_uri中的内容使用HCL的tfvars格式，用户可以将”.tfvars”中的内容保存到文件并上传到OBS中，并将OBS pre-signed URL传递给vars_uri。具体tfvars格式见：https://www.terraform.io/language/values/variables#variable-definitions-tfvars-files  * 注意：vars_uri的内容不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars。如为敏感信息，建议通过vars_structure并设置encryption字段传递 
        /// </summary>
        [JsonProperty("vars_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VarsURIPrimitiveTypeHolder {\n");
            sb.Append("  varsUri: ").Append(VarsUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VarsURIPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VarsURIPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VarsUri == input.VarsUri ||
                    (this.VarsUri != null &&
                    this.VarsUri.Equals(input.VarsUri))
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
                if (this.VarsUri != null)
                    hashCode = hashCode * 59 + this.VarsUri.GetHashCode();
                return hashCode;
            }
        }
    }
}