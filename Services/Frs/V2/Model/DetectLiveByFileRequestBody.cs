using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DetectLiveByFileRequestBody : IFormDataBody
    {

        /// <summary>
        /// 本地视频文件。上传文件时，请求格式为multipart。 视频要求： • 视频文件大小不超过8MB，建议客户端压缩到200KB~2MB。 • 限制视频时长1～15秒。 • 建议帧率10fps～30fps。 • 封装格式：mp4、avi、flv、webm、asf、mov。 • 视频编码格式： h261、h263、h264、hevc、vc1、vp8、vp9、wmv3。
        /// </summary>
        [JsonProperty("video_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart VideoFile { get; set; }

        /// <summary>
        /// 动作代码顺序列表，英文逗号（,）分隔。建议单动作，目前支持的动作有： • 1：左摇头 • 2：右摇头 • 3：点头 • 4：嘴部动作 • 5：眨眼
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public string Actions { get; set; }

        /// <summary>
        /// 该参数为动作时间数组拼接的字符串，数组的长度和actions的数量一致，每一项代表了对应次序动作的起始时间和结束时间，单位为距视频开始的毫秒数。
        /// </summary>
        [JsonProperty("action_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionTime { get; set; }

        /// <summary>
        /// 该参数为点头动作幅度的判断门限，取值范围：[1,90]，默认为10，单位为度。该值设置越大，则越难判断为点头。
        /// </summary>
        [JsonProperty("nod_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? NodThreshold { get; set; }


        
        public DetectLiveByFileRequestBody WithVideoFile(Stream stream, string filename)
        {
            this.VideoFile = new FormDataFilePart(stream, filename);
            return this;
        }

        public DetectLiveByFileRequestBody WithVideoFile(Stream stream, string filename, string contentType)
        {
            this.VideoFile = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("video_file", VideoFile);
            formData.Add("actions", new FormDataPart<string>(Actions));
            if (ActionTime != null) {
                formData.Add("action_time", new FormDataPart<string>(ActionTime));
            }
            if (NodThreshold != null) {
                formData.Add("nod_threshold", new FormDataPart<double?>(NodThreshold));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectLiveByFileRequestBody {\n");
            sb.Append("  videoFile: ").Append(VideoFile).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  actionTime: ").Append(ActionTime).Append("\n");
            sb.Append("  nodThreshold: ").Append(NodThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectLiveByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectLiveByFileRequestBody input)
        {
            if (input == null) return false;
            if (this.VideoFile != input.VideoFile || (this.VideoFile != null && !this.VideoFile.Equals(input.VideoFile))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && !this.Actions.Equals(input.Actions))) return false;
            if (this.ActionTime != input.ActionTime || (this.ActionTime != null && !this.ActionTime.Equals(input.ActionTime))) return false;
            if (this.NodThreshold != input.NodThreshold || (this.NodThreshold != null && !this.NodThreshold.Equals(input.NodThreshold))) return false;

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
                if (this.VideoFile != null) hashCode = hashCode * 59 + this.VideoFile.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.ActionTime != null) hashCode = hashCode * 59 + this.ActionTime.GetHashCode();
                if (this.NodThreshold != null) hashCode = hashCode * 59 + this.NodThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
