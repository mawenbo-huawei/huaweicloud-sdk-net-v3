using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Live.V1.Model;

namespace HuaweiCloud.SDK.Live.V1
{
    public partial class LiveAsyncClient : Client
    {
        public static ClientBuilder<LiveAsyncClient> NewBuilder()
        {
            return new ClientBuilder<LiveAsyncClient>();
        }

        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowIpBelongsResponse> BatchShowIpBelongsAsync(BatchShowIpBelongsRequest batchShowIpBelongsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowIpBelongsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<BatchShowIpBelongsResponse>(response);
        }
        
        /// <summary>
        /// 创建直播域名
        ///
        /// 可单独创建直播播放域名或推流域名，每个租户最多可配置64条域名记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }
        
        /// <summary>
        /// 域名映射
        ///
        /// 将用户已创建的播放域名和推流域名建立域名映射关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainMappingResponse> CreateDomainMappingAsync(CreateDomainMappingRequest createDomainMappingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<CreateDomainMappingResponse>(response);
        }
        
        /// <summary>
        /// 创建录制回调配置
        ///
        /// 创建录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordCallbackConfigResponse> CreateRecordCallbackConfigAsync(CreateRecordCallbackConfigRequest createRecordCallbackConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordCallbackConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordCallbackConfigResponse>(response);
        }
        
        /// <summary>
        /// 创建录制视频索引文件
        ///
        /// Create Record Index
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordIndexResponse> CreateRecordIndexAsync(CreateRecordIndexRequest createRecordIndexRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordIndexRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordIndexResponse>(response);
        }
        
        /// <summary>
        /// 创建录制规则
        ///
        /// 创建录制规则接口，录制规则对新推送的流生效，对已经推送中的流不生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordRuleResponse> CreateRecordRuleAsync(CreateRecordRuleRequest createRecordRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建直播截图配置
        ///
        /// 创建直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSnapshotConfigResponse> CreateSnapshotConfigAsync(CreateSnapshotConfigRequest createSnapshotConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createSnapshotConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateSnapshotConfigResponse>(response);
        }
        
        /// <summary>
        /// 禁止直播推流
        ///
        /// 禁止直播推流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStreamForbiddenResponse> CreateStreamForbiddenAsync(CreateStreamForbiddenRequest createStreamForbiddenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>(response);
        }
        
        /// <summary>
        /// 创建直播转码模板
        ///
        /// 创建直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTranscodingsTemplateResponse> CreateTranscodingsTemplateAsync(CreateTranscodingsTemplateRequest createTranscodingsTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除直播域名
        ///
        /// 删除域名。只有在域名停用（off）状态时才能删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainResponse>(response);
        }
        
        /// <summary>
        /// 删除指定域名的Key防盗链配置
        ///
        /// 删除指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainKeyChainResponse> DeleteDomainKeyChainAsync(DeleteDomainKeyChainRequest deleteDomainKeyChainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainKeyChainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainKeyChainResponse>(response);
        }
        
        /// <summary>
        /// 删除直播域名映射关系
        ///
        /// 将播放域名和推流域名的域名映射关系删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainMappingResponse> DeleteDomainMappingAsync(DeleteDomainMappingRequest deleteDomainMappingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>(response);
        }
        
        /// <summary>
        /// 删除录制回调配置
        ///
        /// 删除录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordCallbackConfigResponse> DeleteRecordCallbackConfigAsync(DeleteRecordCallbackConfigRequest deleteRecordCallbackConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteRecordCallbackConfigRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordCallbackConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRecordCallbackConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除录制规则
        ///
        /// 删除录制规则接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordRuleResponse> DeleteRecordRuleAsync(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteRecordRuleRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除直播截图配置
        ///
        /// 删除直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSnapshotConfigResponse> DeleteSnapshotConfigAsync(DeleteSnapshotConfigRequest deleteSnapshotConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotConfigResponse>(response);
        }
        
        /// <summary>
        /// 禁推恢复
        ///
        /// 恢复直播推流接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStreamForbiddenResponse> DeleteStreamForbiddenAsync(DeleteStreamForbiddenRequest deleteStreamForbiddenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStreamForbiddenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteStreamForbiddenResponse>(response);
        }
        
        /// <summary>
        /// 删除直播转码模板
        ///
        /// 删除直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTranscodingsTemplateResponse> DeleteTranscodingsTemplateAsync(DeleteTranscodingsTemplateRequest deleteTranscodingsTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>(response);
        }
        
        /// <summary>
        /// 获取直播播放日志
        ///
        /// 获取直播播放日志，基于域名以5分钟粒度进行打包，日志内容以 \&quot;|\&quot; 进行分隔。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLiveSampleLogsResponse> ListLiveSampleLogsAsync(ListLiveSampleLogsRequest listLiveSampleLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveSampleLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLiveSampleLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询直播中的流信息
        ///
        /// 查询直播中的流信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLiveStreamsOnlineResponse> ListLiveStreamsOnlineAsync(ListLiveStreamsOnlineRequest listLiveStreamsOnlineRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>(response);
        }
        
        /// <summary>
        /// 查询录制回调配置列表
        ///
        /// 查询录制回调配置列表接口。通过指定条件，查询满足条件的配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordCallbackConfigsResponse> ListRecordCallbackConfigsAsync(ListRecordCallbackConfigsRequest listRecordCallbackConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordCallbackConfigsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordCallbackConfigsResponse>(response);
        }
        
        /// <summary>
        /// 录制完成内容的查询
        ///
        /// 录制完成的内容查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordContentsResponse> ListRecordContentsAsync(ListRecordContentsRequest listRecordContentsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordContentsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordContentsResponse>(response);
        }
        
        /// <summary>
        /// 查询录制规则列表
        ///
        /// 查询录制规则列表接口，通过指定条件，查询满足条件的录制规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordRulesResponse> ListRecordRulesAsync(ListRecordRulesRequest listRecordRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询直播截图配置
        ///
        /// 查询直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSnapshotConfigsResponse> ListSnapshotConfigsAsync(ListSnapshotConfigsRequest listSnapshotConfigsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotConfigsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotConfigsResponse>(response);
        }
        
        /// <summary>
        /// 查询禁止直播推流列表
        ///
        /// 查询禁播黑名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStreamForbiddenResponse> ListStreamForbiddenAsync(ListStreamForbiddenRequest listStreamForbiddenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStreamForbiddenResponse>(response);
        }
        
        /// <summary>
        /// 提交录制控制命令
        ///
        /// 对单条流的实时录制控制接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunRecordResponse> RunRecordAsync(RunRecordRequest runRecordRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RunRecordResponse>(response);
        }
        
        /// <summary>
        /// 查询直播域名
        ///
        /// 查询直播域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainResponse> ShowDomainAsync(ShowDomainRequest showDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }
        
        /// <summary>
        /// 查询指定域名的Key防盗链配置
        ///
        /// 查询指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainKeyChainResponse> ShowDomainKeyChainAsync(ShowDomainKeyChainRequest showDomainKeyChainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainKeyChainResponse>(response);
        }
        
        /// <summary>
        /// 查询录制回调配置
        ///
        /// 查询录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordCallbackConfigResponse> ShowRecordCallbackConfigAsync(ShowRecordCallbackConfigRequest showRecordCallbackConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showRecordCallbackConfigRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordCallbackConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询录制规则配置
        ///
        /// 查询录制规则接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordRuleResponse> ShowRecordRuleAsync(ShowRecordRuleRequest showRecordRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showRecordRuleRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询直播转码模板
        ///
        /// 查询直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTranscodingsTemplateResponse> ShowTranscodingsTemplateAsync(ShowTranscodingsTemplateRequest showTranscodingsTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>(response);
        }
        
        /// <summary>
        /// 修改直播域名
        ///
        /// 修改直播播放、RTMP推流加速域名相关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest updateDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainResponse>(response);
        }
        
        /// <summary>
        /// 配置域名IPV6开关
        ///
        /// 配置IPV6开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainIp6SwitchResponse> UpdateDomainIp6SwitchAsync(UpdateDomainIp6SwitchRequest updateDomainIp6SwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainIp6SwitchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainIp6SwitchResponse>(response);
        }
        
        /// <summary>
        /// 更新指定域名的Key防盗链配置
        ///
        /// 更新指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainKeyChainResponse> UpdateDomainKeyChainAsync(UpdateDomainKeyChainRequest updateDomainKeyChainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>(response);
        }
        
        /// <summary>
        /// 修改录制回调配置
        ///
        /// 修改录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordCallbackConfigResponse> UpdateRecordCallbackConfigAsync(UpdateRecordCallbackConfigRequest updateRecordCallbackConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateRecordCallbackConfigRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordCallbackConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改录制规则
        ///
        /// 修改录制规则接口，如果规则修改后，修改后的规则对正在录制的流无效，对新的流有效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordRuleResponse> UpdateRecordRuleAsync(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateRecordRuleRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }
        
        /// <summary>
        /// 修改直播截图配置
        ///
        /// 修改直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSnapshotConfigResponse> UpdateSnapshotConfigAsync(UpdateSnapshotConfigRequest updateSnapshotConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateSnapshotConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateSnapshotConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改禁推属性
        ///
        /// 修改禁推属性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStreamForbiddenResponse> UpdateStreamForbiddenAsync(UpdateStreamForbiddenRequest updateStreamForbiddenRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateStreamForbiddenRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateStreamForbiddenResponse>(response);
        }
        
        /// <summary>
        /// 配置直播转码模板
        ///
        /// 修改直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTranscodingsTemplateResponse> UpdateTranscodingsTemplateAsync(UpdateTranscodingsTemplateRequest updateTranscodingsTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除指定域名的https证书配置
        ///
        /// 删除指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainHttpsCertResponse> DeleteDomainHttpsCertAsync(DeleteDomainHttpsCertRequest deleteDomainHttpsCertRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainHttpsCertRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainHttpsCertResponse>(response);
        }
        
        /// <summary>
        /// 查询指定域名的https证书配置
        ///
        /// 查询指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainHttpsCertResponse> ShowDomainHttpsCertAsync(ShowDomainHttpsCertRequest showDomainHttpsCertRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainHttpsCertRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainHttpsCertResponse>(response);
        }
        
        /// <summary>
        /// 修改指定域名的https证书配置
        ///
        /// 修改指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainHttpsCertResponse> UpdateDomainHttpsCertAsync(UpdateDomainHttpsCertRequest updateDomainHttpsCertRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>(response);
        }
        
        /// <summary>
        /// OBS桶授权及取消授权
        ///
        /// OBS桶授权及取消授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateObsBucketAuthorityPublicResponse> UpdateObsBucketAuthorityPublicAsync(UpdateObsBucketAuthorityPublicRequest updateObsBucketAuthorityPublicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>(response);
        }
        
    }
}