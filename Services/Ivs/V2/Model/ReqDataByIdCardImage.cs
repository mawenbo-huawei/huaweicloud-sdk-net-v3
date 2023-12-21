using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReqDataByIdCardImage 
    {

        /// <summary>
        /// 身份证人像面图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("idcard_image1", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardImage1 { get; set; }

        /// <summary>
        /// 身份证国徽面图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("idcard_image2", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardImage2 { get; set; }

        /// <summary>
        /// 现场人像图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("face_image", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceImage { get; set; }

        /// <summary>
        /// 响应参数similarity是否详细显示，默认为false。 - true表示响应中的similarity为0~1000的小数。 - false表示响应中的similarity为0~100的整数。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Detail { get; set; }

        /// <summary>
        /// 是否允许对入参face_image进行人脸检测及图片裁剪，默认为true，表示允许。
        /// </summary>
        [JsonProperty("crop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqDataByIdCardImage {\n");
            sb.Append("  idcardImage1: ").Append(IdcardImage1).Append("\n");
            sb.Append("  idcardImage2: ").Append(IdcardImage2).Append("\n");
            sb.Append("  faceImage: ").Append(FaceImage).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  crop: ").Append(Crop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReqDataByIdCardImage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReqDataByIdCardImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdcardImage1 == input.IdcardImage1 ||
                    (this.IdcardImage1 != null &&
                    this.IdcardImage1.Equals(input.IdcardImage1))
                ) && 
                (
                    this.IdcardImage2 == input.IdcardImage2 ||
                    (this.IdcardImage2 != null &&
                    this.IdcardImage2.Equals(input.IdcardImage2))
                ) && 
                (
                    this.FaceImage == input.FaceImage ||
                    (this.FaceImage != null &&
                    this.FaceImage.Equals(input.FaceImage))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Crop == input.Crop ||
                    (this.Crop != null &&
                    this.Crop.Equals(input.Crop))
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
                if (this.IdcardImage1 != null)
                    hashCode = hashCode * 59 + this.IdcardImage1.GetHashCode();
                if (this.IdcardImage2 != null)
                    hashCode = hashCode * 59 + this.IdcardImage2.GetHashCode();
                if (this.FaceImage != null)
                    hashCode = hashCode * 59 + this.FaceImage.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Crop != null)
                    hashCode = hashCode * 59 + this.Crop.GetHashCode();
                return hashCode;
            }
        }
    }
}
