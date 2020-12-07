using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class PublishAppMessageRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("endpoint_urn", IsPath = true)]
        [JsonProperty("endpoint_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public PublishAppMessageRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishAppMessageRequest {\n");
            sb.Append("  endpointUrn: ").Append(EndpointUrn).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishAppMessageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishAppMessageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndpointUrn == input.EndpointUrn ||
                    (this.EndpointUrn != null &&
                    this.EndpointUrn.Equals(input.EndpointUrn))
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
                if (this.EndpointUrn != null)
                    hashCode = hashCode * 59 + this.EndpointUrn.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}