using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmartDocumentRecognizerRequestBody 
    {

        /// <summary>
        /// 与url二选一。图片或PDF格式，base64编码，要求base64编码后大小不超过10M。 图像尺寸不小于15×15像素，最长边不超过8192像素，支持JPG/PNG/BMP/TIFF格式。 PDF以144dpi的分辨率转为图像进行文档解析，需符合上述图像尺寸规定。若PDF有多页，当前仅对第1页进行识别。 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// 与data二选一。 图片或PDF的URL路径，目前仅支持华为云上OBS提供的匿名公开授权访问的URL以及公网URL。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 - url中不能存在中文字符，若存在，中文需要进行utf8编码。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 是否进行键值对（key-value）提取。若是，结果会以“kv_result”这一关键字返回。 
        /// </summary>
        [JsonProperty("kv", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kv { get; set; }

        /// <summary>
        /// 是否进行表格识别。此处表格特指逻辑表格，通常具有M行N列的形式，且第一行或第一列为表头。若是，结果会以“table_result”这一关键字返回。 
        /// </summary>
        [JsonProperty("table", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Table { get; set; }

        /// <summary>
        /// 是否进行版面分析。若是，结果会以“layout_result”这一关键字返回。 
        /// </summary>
        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Layout { get; set; }

        /// <summary>
        /// 仅当table为True时有效。是否返回表格转换Microsoft Excel的Base64编码字段。 
        /// </summary>
        [JsonProperty("return_excel", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnExcel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerRequestBody {\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  kv: ").Append(Kv).Append("\n");
            sb.Append("  table: ").Append(Table).Append("\n");
            sb.Append("  layout: ").Append(Layout).Append("\n");
            sb.Append("  returnExcel: ").Append(ReturnExcel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Kv == input.Kv ||
                    (this.Kv != null &&
                    this.Kv.Equals(input.Kv))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.ReturnExcel == input.ReturnExcel ||
                    (this.ReturnExcel != null &&
                    this.ReturnExcel.Equals(input.ReturnExcel))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Kv != null)
                    hashCode = hashCode * 59 + this.Kv.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.ReturnExcel != null)
                    hashCode = hashCode * 59 + this.ReturnExcel.GetHashCode();
                return hashCode;
            }
        }
    }
}