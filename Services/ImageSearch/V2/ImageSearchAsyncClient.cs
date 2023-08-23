using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.ImageSearch.V2.Model;

namespace HuaweiCloud.SDK.ImageSearch.V2
{
    public partial class ImageSearchAsyncClient : Client
    {
        public static ClientBuilder<ImageSearchAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ImageSearchAsyncClient>();
        }

        
        /// <summary>
        /// 添加数据
        ///
        /// 添加数据到指定服务实例中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunAddDataResponse> RunAddDataAsync(RunAddDataRequest runAddDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_name" , runAddDataRequest.ServiceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAddDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunAddDataResponse>(response);
        }
        
        /// <summary>
        /// 检查数据
        ///
        /// 检查指定服务实例中的对应数据，支持指定ID检查和条件检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunCheckDataResponse> RunCheckDataAsync(RunCheckDataRequest runCheckDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_name" , runCheckDataRequest.ServiceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/check",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runCheckDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunCheckDataResponse>(response);
        }
        
        /// <summary>
        /// 删除数据
        ///
        /// 删除指定服务实例中的对应数据，支持指定ID删除和条件删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunDeleteDataResponse> RunDeleteDataAsync(RunDeleteDataRequest runDeleteDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_name" , runDeleteDataRequest.ServiceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runDeleteDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunDeleteDataResponse>(response);
        }
        
        /// <summary>
        /// 搜索
        ///
        /// 从指定服务实例中进行搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunSearchResponse> RunSearchAsync(RunSearchRequest runSearchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_name" , runSearchRequest.ServiceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/search",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runSearchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunSearchResponse>(response);
        }
        
        /// <summary>
        /// 更新数据
        ///
        /// 更新指定服务实例中的对应数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunUpdateDataResponse> RunUpdateDataAsync(RunUpdateDataRequest runUpdateDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("service_name" , runUpdateDataRequest.ServiceName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/mms/{service_name}/data/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runUpdateDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RunUpdateDataResponse>(response);
        }
        
    }
}