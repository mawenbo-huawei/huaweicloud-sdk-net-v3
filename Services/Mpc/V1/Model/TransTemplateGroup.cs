using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TransTemplateGroup 
    {

        /// <summary>
        /// 模板组名称 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 视频信息列表 
        /// </summary>
        [JsonProperty("videos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoObj> Videos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public Audio Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_common", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCommon VideoCommon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public Common Common { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransTemplateGroup {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  videos: ").Append(Videos).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  videoCommon: ").Append(VideoCommon).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransTemplateGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransTemplateGroup input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Videos != input.Videos || (this.Videos != null && input.Videos != null && !this.Videos.SequenceEqual(input.Videos))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;
            if (this.VideoCommon != input.VideoCommon || (this.VideoCommon != null && !this.VideoCommon.Equals(input.VideoCommon))) return false;
            if (this.Common != input.Common || (this.Common != null && !this.Common.Equals(input.Common))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Videos != null) hashCode = hashCode * 59 + this.Videos.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.VideoCommon != null) hashCode = hashCode * 59 + this.VideoCommon.GetHashCode();
                if (this.Common != null) hashCode = hashCode * 59 + this.Common.GetHashCode();
                return hashCode;
            }
        }
    }
}
