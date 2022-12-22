using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateRecordSetsRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("zone_id", IsPath = true)]
        [JsonProperty("zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("recordset_id", IsPath = true)]
        [JsonProperty("recordset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordsetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateRecordSetsReq Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRecordSetsRequest {\n");
            sb.Append("  zoneId: ").Append(ZoneId).Append("\n");
            sb.Append("  recordsetId: ").Append(RecordsetId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRecordSetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRecordSetsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZoneId == input.ZoneId ||
                    (this.ZoneId != null &&
                    this.ZoneId.Equals(input.ZoneId))
                ) && 
                (
                    this.RecordsetId == input.RecordsetId ||
                    (this.RecordsetId != null &&
                    this.RecordsetId.Equals(input.RecordsetId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.ZoneId != null)
                    hashCode = hashCode * 59 + this.ZoneId.GetHashCode();
                if (this.RecordsetId != null)
                    hashCode = hashCode * 59 + this.RecordsetId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
