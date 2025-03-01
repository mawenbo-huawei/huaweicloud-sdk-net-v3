using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 库配置校验检查结果。
    /// </summary>
    public class ChDatabaseConfigCheckResult 
    {

        /// <summary>
        /// 库同步配置参数名。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 库同步配置参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 校验结果。 取值范围： - success：成功 - fail：失败
        /// </summary>
        [JsonProperty("check_result", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChDatabaseConfigCheckResult {\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  checkResult: ").Append(CheckResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChDatabaseConfigCheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChDatabaseConfigCheckResult input)
        {
            if (input == null) return false;
            if (this.ParamName != input.ParamName || (this.ParamName != null && !this.ParamName.Equals(input.ParamName))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.CheckResult != input.CheckResult || (this.CheckResult != null && !this.CheckResult.Equals(input.CheckResult))) return false;

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
                if (this.ParamName != null) hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.CheckResult != null) hashCode = hashCode * 59 + this.CheckResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
