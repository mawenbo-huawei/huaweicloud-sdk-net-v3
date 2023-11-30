using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Image.V2.Model;

namespace HuaweiCloud.SDK.Image.V2
{
    public partial class ImageClient : Client
    {
        public static ClientBuilder<ImageClient> NewBuilder()
        {
            return new ClientBuilder<ImageClient>();
        }

        
        /// <summary>
        /// 名人识别
        ///
        /// 分析并识别图片中包含的政治人物、明星及网红人物，返回人物信息及人脸坐标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunCelebrityRecognitionResponse RunCelebrityRecognition(RunCelebrityRecognitionRequest runCelebrityRecognitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/celebrity-recognition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCelebrityRecognitionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunCelebrityRecognitionResponse>(response);
        }

        public SyncInvoker<RunCelebrityRecognitionResponse> RunCelebrityRecognitionInvoker(RunCelebrityRecognitionRequest runCelebrityRecognitionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/celebrity-recognition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runCelebrityRecognitionRequest);
            return new SyncInvoker<RunCelebrityRecognitionResponse>(this, "POST", request, JsonUtils.DeSerialize<RunCelebrityRecognitionResponse>);
        }
        
        /// <summary>
        /// 主体识别
        ///
        /// 检测图像中的主要内容，返回主要内容的坐标信息，这里的主要内容包括两方面：bounding_box和main_object_box
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageMainObjectDetectionResponse RunImageMainObjectDetection(RunImageMainObjectDetectionRequest runImageMainObjectDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/image/main-object-detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMainObjectDetectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunImageMainObjectDetectionResponse>(response);
        }

        public SyncInvoker<RunImageMainObjectDetectionResponse> RunImageMainObjectDetectionInvoker(RunImageMainObjectDetectionRequest runImageMainObjectDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/image/main-object-detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMainObjectDetectionRequest);
            return new SyncInvoker<RunImageMainObjectDetectionResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageMainObjectDetectionResponse>);
        }
        
        /// <summary>
        /// 标签识别
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应置信度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageMediaTaggingResponse RunImageMediaTagging(RunImageMediaTaggingRequest runImageMediaTaggingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunImageMediaTaggingResponse>(response);
        }

        public SyncInvoker<RunImageMediaTaggingResponse> RunImageMediaTaggingInvoker(RunImageMediaTaggingRequest runImageMediaTaggingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingRequest);
            return new SyncInvoker<RunImageMediaTaggingResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageMediaTaggingResponse>);
        }
        
        /// <summary>
        /// 媒资图像标签检测
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应的位置坐标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageMediaTaggingDetResponse RunImageMediaTaggingDet(RunImageMediaTaggingDetRequest runImageMediaTaggingDetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging-det", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingDetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunImageMediaTaggingDetResponse>(response);
        }

        public SyncInvoker<RunImageMediaTaggingDetResponse> RunImageMediaTaggingDetInvoker(RunImageMediaTaggingDetRequest runImageMediaTaggingDetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/media-tagging-det", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageMediaTaggingDetRequest);
            return new SyncInvoker<RunImageMediaTaggingDetResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageMediaTaggingDetResponse>);
        }
        
        /// <summary>
        /// 图像标签
        ///
        /// 自然图像的语义内容非常丰富，一个图像包含多个标签内容，图像标签服务准确识别自然图片中数百种场景、上千种通用物体及其属性，让智能相册管理、照片检索和分类、基于场景内容或者物体的广告推荐等功能更加直观。使用时用户发送待处理图片，返回图片标签内容及相应置信度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunImageTaggingResponse RunImageTagging(RunImageTaggingRequest runImageTaggingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/tagging", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageTaggingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunImageTaggingResponse>(response);
        }

        public SyncInvoker<RunImageTaggingResponse> RunImageTaggingInvoker(RunImageTaggingRequest runImageTaggingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/tagging", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runImageTaggingRequest);
            return new SyncInvoker<RunImageTaggingResponse>(this, "POST", request, JsonUtils.DeSerialize<RunImageTaggingResponse>);
        }
        
        /// <summary>
        /// 翻拍识别
        ///
        /// 零售行业通常根据零售店的销售量进行销售奖励，拍摄售出商品的条形码上传后台是常用的统计方式。翻拍识别利用深度神经网络算法判断条形码图片为原始拍摄，还是经过二次翻拍、打印翻拍等手法二次处理的图片。利用翻拍识别，可以检测出经过二次处理的不合规范图片，使得统计数据更准确、有效。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunRecaptureDetectResponse RunRecaptureDetect(RunRecaptureDetectRequest runRecaptureDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/recapture-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runRecaptureDetectRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunRecaptureDetectResponse>(response);
        }

        public SyncInvoker<RunRecaptureDetectResponse> RunRecaptureDetectInvoker(RunRecaptureDetectRequest runRecaptureDetectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/image/recapture-detect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runRecaptureDetectRequest);
            return new SyncInvoker<RunRecaptureDetectResponse>(this, "POST", request, JsonUtils.DeSerialize<RunRecaptureDetectResponse>);
        }
        
    }
}