using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteAutopilotChartRequest 
    {

        /// <summary>
        /// 模板的ID
        /// </summary>
        [SDKProperty("chart_id", IsPath = true)]
        [JsonProperty("chart_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChartId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAutopilotChartRequest {\n");
            sb.Append("  chartId: ").Append(ChartId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAutopilotChartRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAutopilotChartRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChartId == input.ChartId ||
                    (this.ChartId != null &&
                    this.ChartId.Equals(input.ChartId))
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
                if (this.ChartId != null)
                    hashCode = hashCode * 59 + this.ChartId.GetHashCode();
                return hashCode;
            }
        }
    }
}
