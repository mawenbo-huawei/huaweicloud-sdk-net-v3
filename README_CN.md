[English](./README.md) | 简体中文

<p align="center">
  <a href="https://www.huaweicloud.com/"><img width="270px" height="90px" src="https://console-static.huaweicloud.com/static/authui/20210202115135/public/custom/images/logo.svg"></a>
</p>

<h1 align="center">华为云开发者 .Net 软件开发工具包（.Net SDK）</h1>

欢迎使用华为云 .Net SDK 。

华为云 .Net SDK 让您无需关心请求细节即可快速使用弹性云服务器（ECS）、虚拟私有云（VPC）等多个华为云服务。

这里将向您介绍如何获取并使用华为云 .Net SDK 。

## 使用前提

- 要使用华为云 .Net SDK ，您需要拥有云账号以及该账号对应的 Access Key（AK）和 Secret Access Key（SK）。 请在华为云控制台“我的凭证-访问密钥”页面上创建和查看您的 AK&SK
  。更多信息请查看 [访问密钥](https://support.huaweicloud.com/usermanual-ca/zh-cn_topic_0046606340.html) 。

- 要使用华为云 .Net SDK 访问指定服务的 API
  ，您需要确认已在 [华为云控制台](https://console.huaweicloud.com/console/?locale=zh-cn&region=cn-north-4#/home) 开通当前服务。

- 华为云 .Net SDK 适用于：
  - **.NET and .NET Core 2.0** 及以上版本
  - **.NET Framework 4.6.2** 及以上版本

更多版本维护信息请参考 [.NET Core](https://learn.microsoft.com/zh-cn/lifecycle/faq/dotnet-core)、[.NET Framework](https://learn.microsoft.com/zh-cn/lifecycle/faq/dotnet-framework) 生命周期常见问题解答。

## SDK 获取和安装

您可以通过如下方式获取和安装 SDK ：

无论您要使用哪个产品/服务的开发工具包，都必须安装`HuaweiCloud.SDK.Core`。以使用虚拟私有云 VPC SDK 为例，您需要安装`HuaweiCloud.SDK.Core` 和 `HuaweiCloud.SDK.Vpc`：

- 使用 .NET CLI 工具

``` bash
dotnet add package HuaweiCloud.SDK.Core
dotnet add package HuaweiCloud.SDK.Vpc
```

- 使用 Package Manager

``` bash
Install-Package HuaweiCloud.SDK.Core
Install-Package HuaweiCloud.SDK.Vpc
```

您可以通过 [SDK中心](https://console.huaweicloud.com/apiexplorer/#/sdkcenter?language=.NET) 或 [NUGET](https://www.nuget.org/packages?q=HuaweiCloud.SDK) 查询SDK版本信息。

## 代码示例

- 使用如下代码同步查询指定 Region 下的 VPC 列表，实际使用中请将 `VpcClient` 替换为您使用的产品/服务相应的 `{Service}Client` 。
- 认证用的ak和sk直接写到代码中有很大的安全风险，建议在配置文件或者环境变量中密文存放，使用时解密，确保安全。
- 本示例中的ak和sk保存在环境变量中，运行本示例前请先在本地环境中配置环境变量`HUAWEICLOUD_SDK_AK`和`HUAWEICLOUD_SDK_SK`。

**精简示例**

``` csharp
using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace ListVpcsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配置认证信息
    		// 可通过环境变量等方式配置认证信息，参考2.3认证信息管理章节
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var auth = new BasicCredentials(ak, sk);

            // 创建客户端
            var client = VpcClient.NewBuilder()
                .WithCredential(auth)
                .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                .Build();

            // 创建请求
            var request = new ListVpcsRequest();
            try
            {
                // 发送请求并获取响应
                var response = client.ListVpcs(request);
                Console.WriteLine(response.HttpStatusCode);
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException clientRequestException)
            {
                Console.WriteLine(clientRequestException.HttpStatusCode);
                Console.WriteLine(clientRequestException.RequestId);
                Console.WriteLine(clientRequestException.ErrorCode);
                Console.WriteLine(clientRequestException.ErrorMsg);
            }
            catch (ConnectionException connectionException)
            {
                Console.WriteLine(connectionException.ErrorMessage);
            }
        }
    }
}
```

**详细示例**

```java
using System;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;
using Microsoft.Extensions.Logging;

namespace ListVpcsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配置认证信息
    		// 可通过环境变量等方式配置认证信息，参考2.3认证信息管理章节
            // 如果未填写projectId，SDK会自动调用IAM服务查询所在region对应的项目id
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var projectId = "{your projectId string}";
            var auth = new BasicCredentials(ak, sk, projectId: projectId)
                // 配置SDK内置的IAM服务地址
                .WithIamEndpoint("https://iam.cn-north-4.myhuaweicloud.com");

            // 使用默认配置
            var httpConfig = HttpConfig.GetDefaultConfig()
                // 配置是否忽略SSL证书校验， 默认不忽略
                .WithIgnoreSslVerification(true)
                // 默认超时时间为120秒，可根据需要配置
                .WithTimeout(120)
                // 根据需要配置网络代理
                // 请根据实际情况替换示例中的代理地址和端口号
                .WithProxyHost("proxy.huaweicloud.com")
                .WithProxyPort(8080)
                // 如果代理需要认证，请配置用户名和密码
                .WithIgnoreProxyUsername(Environment.GetEnvironmentVariable("PROXY_USERNAME"))
                .WithIgnoreProxyPassword(Environment.GetEnvironmentVariable("PROXY_PASSWORD"));

            // 配置HTTP监听器用于打印原始请求和响应信息,请勿用于生产环境
            var httpHandler = new HttpHandler()
                .AddRequestHandler((requestMessage, logger) => logger.LogDebug(requestMessage.ToString()))
                .AddResponseHandler((responseMessage, logger) => logger.LogDebug(responseMessage.ToString()));

            // 创建客户端
            var client = VpcClient.NewBuilder()
                // 配置认证信息
                .WithCredential(auth)
                // 配置地区, 如果地区不存在会抛出ArgumentNullException
                .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                // 配置日志级别
                .WithLogging(LogLevel.Debug)
                // 配置HTTP监听器
                .WithHttpHandler(httpHandler)
                // HTTP配置
                .WithHttpConfig(httpConfig)
                .Build();

            // 创建请求
            var request = new ListVpcsRequest();
            // 配置每页返回的个数
            request.Limit = 1;
            try
            {
                // 发送请求并获取响应
                var response = client.ListVpcs(request);
                foreach (var vpc in response.Vpcs)
                {
                    Console.WriteLine(vpc.Name);
                    Console.WriteLine(vpc.Description);
                }
            }
            catch (RequestTimeoutException requestTimeoutException)
            {
                Console.WriteLine(requestTimeoutException.ErrorMessage);
            }
            catch (ServiceResponseException clientRequestException)
            {
                Console.WriteLine(clientRequestException.HttpStatusCode);
                Console.WriteLine(clientRequestException.RequestId);
                Console.WriteLine(clientRequestException.ErrorCode);
                Console.WriteLine(clientRequestException.ErrorMsg);
            }
            catch (ConnectionException connectionException)
            {
                Console.WriteLine(connectionException.ErrorMessage);
            }
        }
    }
}
```

## 在线调试

[API Explorer](https://apiexplorer.developer.huaweicloud.com/apiexplorer/overview)
提供API检索、SDK示例及平台调试，支持全量快速检索、可视化调试、帮助文档查看、在线咨询。

## 变更日志

每个版本的详细更改记录可在 [变更日志](https://github.com/huaweicloud/huaweicloud-sdk-net-v3/blob/master/CHANGELOG_CN.md) 中查看。

## 用户手册 [:top:](#华为云开发者-net-软件开发工具包net-sdk)

* [1. 客户端连接参数](#1-客户端连接参数-top)
    * [1.1 默认配置](#11-默认配置-top)
    * [1.2 网络代理](#12-网络代理-top)
    * [1.3 超时配置](#13-超时配置-top)
    * [1.4 SSL 配置](#14-ssl-配置-top)
* [2. 认证信息配置](#2-认证信息配置-top)
    * [2.1 使用永久 AK 和 SK](#21-使用永久-ak-和-sk-top)
    * [2.2 使用临时 AK 和 SK](#22-使用临时-ak-和-sk-top)
    * [2.3 认证信息管理](#23-认证信息管理-top)
        * [2.3.1 环境变量](#231-环境变量-top)
        * [2.3.2 配置文件](#232-配置文件-top)
        * [2.3.3 认证信息提供链](#233-认证信息提供链-top)
* [3. 客户端初始化](#3-客户端初始化-top)
    * [3.1 指定云服务 Endpoint 方式](#31-指定云服务-endpoint-方式-top)
    * [3.2 指定 Region 方式（推荐）](#32-指定-region-方式-推荐-top)
    * [3.3 自定义配置](#33-自定义配置-top)
        * [3.3.1 IAM endpoint配置](#331-IAM-endpoint配置-top)
        * [3.3.2 Region配置](#332-Region配置-top)
* [4. 发送请求并查看响应](#4-发送请求并查看响应-top)
    * [4.1 异常处理](#41-异常处理-top)
* [5. 异步客户端使用](#5-异步客户端使用-top)
* [6. 故障处理](#6-故障处理-top)
    * [6.1 访问日志](#61-访问日志-top)
    * [6.2 HTTP 监听器](#62-http-监听器-top)
* [7. 接口调用器](#7-接口调用器-top)
    * [7.1 自定义请求头](#71-自定义请求头-top)
    * [7.2 请求重试](#72-请求重试-top)
* [8. 文件上传](#8-文件上传-top)
* [9. FAQ](#9-faq-top)

### 1. 客户端连接参数 [:top:](#用户手册-top)

#### 1.1 默认配置 [:top:](#用户手册-top)

``` csharp
// 使用默认配置
var httpConfig = HttpConfig.GetDefaultConfig();

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

#### 1.2 网络代理 [:top:](#用户手册-top)

根据需要配置网络代理

- 若配置代理时指定了端口号，则默认仅支持 HTTP 代理

``` csharp
var httpConfig = HttpConfig.GetDefaultConfig()
    // 请根据实际情况替换示例中的代理地址和端口号
    .WithProxyHost("proxy.huaweicloud.com")
    .WithProxyPort(8080)
    // 如果代理需要认证，请配置用户名和密码
    // 本示例中的账号和密码保存在环境变量中，运行本示例前请先在本地环境中配置环境变量PROXY_USERNAME和PROXY_PASSWORD
    .WithIgnoreProxyUsername(Environment.GetEnvironmentVariable("PROXY_USERNAME"))
    .WithIgnoreProxyPassword(Environment.GetEnvironmentVariable("PROXY_PASSWORD"));

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

- 若配置代理时未指定端口号，则可支持 HTTP 和 HTTPS 代理

``` csharp
var httpConfig = HttpConfig.GetDefaultConfig()
    // 协议和端口号均在host中
    .WithProxyHost("https://proxy.huaweicloud.com:8080")
    // 如果代理需要认证，请配置用户名和密码
    .WithIgnoreProxyUsername(Environment.GetEnvironmentVariable("PROXY_USERNAME"))
    .WithIgnoreProxyPassword(Environment.GetEnvironmentVariable("PROXY_PASSWORD"));

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

#### 1.3 超时配置 [:top:](#用户手册-top)

``` csharp
// 默认超时时间为120秒，可根据需要调整
var httpConfig = HttpConfig.GetDefaultConfig().WithTimeout(120);

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

#### 1.4 SSL 配置 [:top:](#用户手册-top)

``` csharp
// 根据需要配置是否跳过SSL证书验证
var httpConfig = HttpConfig.GetDefaultConfig().WithIgnoreSslVerification(true);

var client = VpcClient.NewBuilder()
    .WithHttpConfig(httpConfig)
    .Build();
```

### 2. 认证信息配置 [:top:](#用户手册-top)

华为云服务存在两种部署方式，Region 级服务和 Global 级服务。

Global 级服务有 IAM、TMS、EPS。

Region 级服务使用 BasicCredentials 初始化，需要提供 projectId 。

Global 级服务使用 GlobalCredentials 初始化，需要提供 domainId 。

**认证参数说明**：

- `ak` - 华为云账号 Access Key
- `sk` - 华为云账号 Secret Access Key
- `projectId` - 云服务所在项目 ID ，根据你想操作的项目所属区域选择对应的项目 ID
- `domainId` - 华为云账号 ID
- `securityToken` - 采用临时 AK&SK 认证场景下的安全票据

客户端认证可以使用永久 AK&SK 认证，也可以使用临时 AK&SK&SecurityToken 认证。

#### 2.1 使用永久 AK 和 SK [:top:](#用户手册-top)

``` csharp
// Region级服务
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var projectId = "{your projectId string}";
            
Credentials basicCredentials = new BasicCredentials(ak, sk, projectId);

// Global级服务
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var domainId = "{your domainId string}";

Credentials globalCredentials = new GlobalCredentials(ak, sk, domainId);
```

**说明**：

- `3.0.26-beta` 及以上版本支持自动获取 projectId/domainId ，用户需要指定当前华为云账号的永久 AK&SK 和 对应的 region_id，同时在初始化客户端时配合 `WithRegion()`
  方法使用，代码示例详见 [3.2 指定Region方式（推荐）](#32-指定-region-方式-推荐-top) 。

#### 2.2 使用临时 AK 和 SK [:top:](#用户手册-top)

首先需要获得临时 AK、SK 和 SecurityToken ，可以从永久 AK&SK 获得，或者通过委托授权获得。

- 通过永久 AK&SK 获得可以参考文档：https://support.huaweicloud.com/api-iam/iam_04_0002.html ，对应 IAM SDK
  中的 `CreateTemporaryAccessKeyByToken` 方法。

- 通过委托授权获得可以参考文档：https://support.huaweicloud.com/api-iam/iam_04_0101.html ，对应 IAM SDK
  中的 `CreateTemporaryAccessKeyByAgency` 方法。

临时 AK&SK&SecurityToken 获取成功后，可使用如下方式初始化认证信息：

``` csharp
// Region级服务
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var securityToken = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SECURITY_TOKEN");
var projectId = "{your projectId string}";

Credentials basicCredentials = new BasicCredentials(ak, sk, projectId).WithSecurityToken(securityToken);
    
// Global级服务
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var securityToken = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SECURITY_TOKEN");
var domainId = "{your domainId string}";

Credentials globalCredentials = new GlobalCredentials(ak, sk, domainId).WithSecurityToken(securityToken);
```

#### 2.3 认证信息管理 [:top:](#用户手册-top)

从**3.1.62**版本起，支持从各类提供器中获取认证信息

**Region级服务** 请使用 `XxxCredentialProvider.GetBasic()`

**Global级服务** 请使用 `XxxCredentialProvider.GetGlobal()`

##### 2.3.1 环境变量 [:top:](#用户手册-top)

**AK/SK认证**

| 环境变量  |  说明 |
| ------------ | ------------ |
| HUAWEICLOUD_SDK_AK  | 必填，AccessKey  |
| HUAWEICLOUD_SDK_SK  |  必填，SecretKey |
| HUAWEICLOUD_SDK_SECURITY_TOKEN  | 可选, 使用临时ak/sk认证时需要指定该参数  |
| HUAWEICLOUD_SDK_PROJECT_ID  | 可选，用于Region级服务，多ProjectId场景下必填  |
| HUAWEICLOUD_SDK_DOMAIN_ID  | 可选，用于Global级服务  |

配置环境变量：

```
// Linux
export HUAWEICLOUD_SDK_AK=YOUR_AK
export HUAWEICLOUD_SDK_SK=YOUR_SK

// Windows
set HUAWEICLOUD_SDK_AK=YOUR_AK
set HUAWEICLOUD_SDK_SK=YOUR_SK
```

从配置的环境变量中获取认证信息：

```csharp
using HuaweiCloud.SDK.Core.Auth;

// basic
var basicProvider = EnvCredentialProvider.GetBasic();
var basicCredentials = basicProvider.GetCredentials();

// global
var globalProvider = EnvCredentialProvider.GetGlobal();
var globalCredentials = globalProvider.GetCredentials();
```

##### 2.3.2 配置文件 [:top:](#用户手册-top)

默认会从用户主目录下读取认证信息配置文件，linux为`~/.huaweicloud/credentials`，windows为`C:\Users\USER_NAME\.huaweicloud\credentials`，可以通过配置环境变量`HUAWEICLOUD_SDK_CREDENTIALS_FILE`来修改默认文件的路径

**AK/SK认证**

| 配置参数  |  说明 |
| ------------ | ------------ |
| ak  | 必填，AccessKey  |
| sk  |  必填，SecretKey |
| security_token  | 可选, 使用临时ak/sk认证时需要指定该参数  |
| project_id  | 可选，用于Region级服务，多ProjectId场景下必填  |
| domain_id  | 可选，用于Global级服务  |
| iam_endpoint  | 可选，用于身份认证的endpoint，默认为`https://iam.myhuaweicloud.com` |

配置文件内容如下：

```ini
[basic]
ak = your_ak
sk = your_sk

[global]
ak = your_ak
sk = your_sk
```

从配置文件中读取认证信息：

```csharp
using HuaweiCloud.SDK.Core.Auth;

// basic
var basicProvider = ProfileCredentialProvider.GetBasic();
var basicCredentials = basicProvider.GetCredentials();

// global
var globalProvider = ProfileCredentialProvider.GetGlobal();
var globalCredentials = globalProvider.GetCredentials();
```

##### 2.3.3 认证信息提供链 [:top:](#用户手册-top)

在创建服务客户端，未显式指定认证信息时，按照顺序 **环境变量 -> 配置文件** 尝试加载认证信息

通过提供链获取认证信息：

```csharp
using HuaweiCloud.SDK.Core.Auth;

// basic
var basicChain = CredentialProviderChain.GetBasic();
var basicCredentials = basicChain.GetCredentials();

// global
var globalChain = CredentialProviderChain.GetGlobal();
var globalCredentials = globalChain.GetCredentials();
```

支持自定义认证信息提供链：

```csharp
using HuaweiCloud.SDK.Core.Auth;

var providers = new ICredentialProvider[]
{
    ProfileCredentialProvider.GetBasic(),
    EnvCredentialProvider.GetBasic()
};
var chain = new CredentialProviderChain(providers);
var credentials = chain.GetCredentials();
```

### 3. 客户端初始化 [:top:](#用户手册-top)

客户端初始化有两种方式，可根据需要选择下列两种方式中的一种：

#### 3.1 指定云服务 Endpoint 方式 [:top:](#用户手册-top)

``` csharp
// 指定终端节点，以 VPC 服务北京四的 endpoint 为例
String endpoint = "https://vpc.cn-north-4.myhuaweicloud.com";

// 初始化客户端认证信息，需要填写相应 projectId/domainId，以初始化 BasicCredentials 为例
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var projectId = "{your projectId string}";
Credentials basicCredentials = new BasicCredentials(ak, sk, projectId);

// 初始化指定云服务的客户端 {Service}Client，以初始化 Region 级服务 VPC 的 VpcClient 为例
VpcClient vpcClient = VpcClient.NewBuilder()
    .WithCredential(basicCredentials)
    .WithEndPoint(endpoint)
    .WithHttpConfig(config)
    .WithLogging(LogLevel.Information)
    .Build();
```

**说明:**

- `endpoint` 是华为云各服务应用区域和各服务的终端节点，详情请查看 [地区和终端节点](https://developer.huaweicloud.com/endpoint) 。
- 当用户使用指定 Region 方式无法自动获取 projectId 时，可以使用当前方式调用接口。

#### 3.2 指定 Region 方式 **（推荐）** [:top:](#用户手册-top)

``` csharp
// 初始化客户端认证信息，使用当前客户端初始化方式可不填 projectId/domainId，以初始化 GlobalCredentials 为例
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
Credentials globalCredentials = new GlobalCredentials(ak, sk);

// 初始化指定云服务的客户端 {Service}Client ，以初始化 Global 级服务 IAM 的 IamClient 为例
IamClient iamClient = IamClient.NewBuilder()
    .WithCredential(globalCredentials)
    .WithRegion(IamRegion.CN_NORTH_4)
    .WithHttpConfig(config)
    .Build();
```

**说明：**

- 指定 Region 方式创建客户端的场景，支持自动获取用户的 projectId 或者 domainId，初始化认证信息时可无需指定相应参数。

- **不适用**于 `多ProjectId` 的场景。

- 支持指定的 Region 可通过[地区和终端节点](https://console.huaweicloud.com/apiexplorer/#/endpoint)查询。调用不支持的 region 可能会抛出 `Unsupported regionId` 的异常信息。

**两种方式对比：**

| 初始化方式 | 优势 | 劣势 |
| :---- | :---- | :---- | 
| 指定云服务 Endpoint 方式 | 只要接口已在当前环境发布就可以成功调用 | 需要用户自行查找并填写 projectId 和 endpoint
| 指定 Region 方式 | 无需指定 projectId 和 endpoint，按照要求配置即可自动获取该值并回填 | 支持的服务和 region 有限制

#### 3.3 自定义配置 [:top:](#用户手册-top)

**注：** 3.1.62版本起支持

##### 3.3.1 IAM endpoint配置 [:top:](#用户手册-top)

自动获取用户的 projectId 和 domainId 会分别调用统一身份认证服务的 [KeystoneListProjects](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product=IAM&api=KeystoneListProjects) 和 [KeystoneListAuthDomains](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product=IAM&api=KeystoneListAuthDomains) 接口。

默认访问的endpoint会从[映射表](./Core/Resources/iam_endpoints.json)中查询，如果查不到则会使用默认值 **https://iam.myhuaweicloud.com**

**欧洲站用户需要指定 endpoint 为 https://iam.eu-west-101.myhuaweicloud.eu** ，用户可以通过以下两种方式来修改endpoint

###### 3.3.1.1 全局级 [:top:](#用户手册-top)

全局范围生效，通过环境变量`HUAWEICLOUD_SDK_IAM_ENDPOINT`指定

```
//linux
export HUAWEICLOUD_SDK_IAM_ENDPOINT=https://iam.cn-north-4.myhuaweicloud.com

//windows
set HUAWEICLOUD_SDK_IAM_ENDPOINT=https://iam.cn-north-4.myhuaweicloud.com
```

###### 3.3.1.2 凭证级 [:top:](#用户手册-top)

只对单个凭证生效，会覆盖全局配置

```csharp
using System;
using HuaweiCloud.SDK.Core.Auth;

var iamEndpoint = "https://iam.cn-north-4.myhuaweicloud.com";
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var credentials = new BasicCredentials(ak, sk).WithIamEndpoint(iamEndpoint);
```

##### 3.3.2 Region配置 [:top:](#用户手册-top)

###### 3.3.2.1 代码配置 [:top:](#用户手册-top)

```csharp
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ecs.V2;

// 使用自定义的regionId和endpoint创建一个region
var region = new Region("cn-north-9", "https://ecs.cn-north-9.myhuaweicloud.com")

var client = EcsClient.NewBuilder()
    .WithCredential(auth)
    .WithRegion(region)
    .Build();
```

###### 3.3.2.2 环境变量 [:top:](#用户手册-top)

通过环境变量配置，一个region可以对应多个endpoint，主要endpoint无法连接会自动切换到备用endpoint

格式为`HUAWEICLOUD_SDK_REGION_{SERVICE_NAME}_{REGION_ID}={endpoint1},{endpoint2}`, 多个endpoint之间用英文逗号隔开

注：环境变量名全大写，中划线替换为下划线

```
// linux
export HUAWEICLOUD_SDK_REGION_ECS_CN_NORTH_9=https://ecs.cn-north-9.myhuaweicloud.com,https://ecs.cn-north-9.myhuaweicloud.cn

// windows
set HUAWEICLOUD_SDK_REGION_ECS_CN_NORTH_9=https://ecs.cn-north-9.myhuaweicloud.com,https://ecs.cn-north-9.myhuaweicloud.cn
```

###### 3.3.2.3 文件配置 [:top:](#用户手册-top)

通过yaml文件配置，默认会从用户主目录下读取region配置文件，linux为`~/.huaweicloud/regions.yaml`，windows为`C:\Users\USER_NAME\.huaweicloud\regions.yaml`，默认配置文件可以不存在，但是如果配置文件存在且内容格式不对会解析错误抛出异常。

可以通过配置环境变量`HUAWEICLOUD_SDK_REGIONS_FILE`来修改默认文件的路径，如`HUAWEICLOUD_SDK_REGIONS_FILE=/tmp/my_regions.yml`

一个region可以对应多个endpoint，主要endpoint无法连接会自动切换到备用endpoint，文件内容格式如下：

```yaml
# 服务名不区分大小写
ECS:
  - id: 'cn-north-9'
    endpoints:
      - 'https://ecs.cn-north-9.myhuaweicloud.com'
      - 'https://ecs.cn-north-9.myhuaweicloud.cn'
```

###### 3.3.2.4 Region提供链 [:top:](#用户手册-top)

**Region.ValueOf(regionId)** 方法默认查找顺序为 **环境变量 -> 配置文件 -> SDK中已定义Region**，以上方式都找不到region会抛出异常 **ArgumentException**，获取region示例：

```csharp
using HuaweiCloud.SDK.Ecs.V2;

var region = EcsRegion.ValueOf("cn-north-9");
```

### 4. 发送请求并查看响应 [:top:](#用户手册-top)

``` csharp
// 初始化请求，以调用接口 ListVpcs 为例
var request = new ListVpcsRequest
{
    Limit = 1,
};

var response = vpcClient.ListVpcs(request)
Console.WriteLine(JsonUtils.Serialize(response.Vpcs));
```

#### 4.1 异常处理 [:top:](#用户手册-top)

| 一级分类 | 一级分类说明 | 二级分类 | 二级分类说明 |
| :---- | :---- | :---- | :---- |
| ConnectionException | 连接类异常 | HostUnreachableException | 网络不可达、被拒绝 |
| | | SslHandShakeException | SSL认证异常 |
| RequestTimeoutException | 响应超时异常 | CallTimeoutException | 单次请求，服务器处理超时未返回 |
| | | RetryOutageException | 在重试策略消耗完成已后，仍无有效的响应 |
| ServiceResponseException | 服务器响应异常 | ServerResponseException | 服务端内部错误，Http响应码：[500,] |
| | | ClientRequestException | 请求参数不合法，Http响应码：[400, 500) |

``` csharp
// 异常处理
try
{
    var request = new ListVpcsRequest
    {
        Limit = 1,
    };

    var response = vpcClient.ListVpcs(request);
    Console.WriteLine(JsonUtils.Serialize(response.Vpcs));
}
catch (ServiceResponseException serviceResponseException)
{
    Console.WriteLine(serviceResponseException.HttpStatusCode);
    Console.WriteLine(serviceResponseException.ErrorCode);
    Console.WriteLine(serviceResponseException.ErrorMsg);
    Console.WriteLine(serviceResponseException.RequestId);
}
```

### 5. 异步客户端使用 [:top:](#用户手册-top)

``` csharp
// 初始化异步客户端，以初始化 VpcAsyncClient 为例
var vpcAsyncClient = VpcAsyncClient.NewBuilder()
    .WithCredential(auth)
    .WithEndPoint(endpoint)
    .WithHttpConfig(config)
    .Build();


var request = new ListVpcsRequest();

// 异步发送请求，获取响应
var response = await vpcAsyncClient.ListVpcsAsync(request);
Console.WriteLine(JsonUtils.Serialize(response));
```

### 6. 故障处理 [:top:](#用户手册-top)

SDK 提供 Access 级别的访问日志及 Debug 级别的原始 HTTP 监听器日志，用户可根据需要进行配置。

#### 6.1 访问日志 [:top:](#用户手册-top)

SDK 支持打印访问日志，需要用户手动打开日志开关，支持打印到控制台。示例代码如下：

``` csharp
var vpcClient = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithEndPoint(endpoint)
    // 设置打印日志的级别即可在控制台打印日志
    .WithLogging(LogLevel.Information)
    .WithHttpConfig(config)
    .Build();
```

打开日志开关后，每次请求都会有以下记录，如：

``` text
info: System.Net.Http.HttpClient.SdkHttpClient.LogicalHandler[100]
      Start processing HTTP request GET https://vpc.cn-north-1.myhuaweicloud.com/v1/076958154900d2492f8bc0197405c803/vpcs?limit=1
info: System.Net.Http.HttpClient.SdkHttpClient.ClientHandler[100]
      Sending HTTP request GET https://vpc.cn-north-1.myhuaweicloud.com/v1/076958154900d2492f8bc0197405c803/vpcs?limit=1
info: System.Net.Http.HttpClient.SdkHttpClient.ClientHandler[101]
      Received HTTP response after 517.5326ms - OK
info: System.Net.Http.HttpClient.SdkHttpClient.LogicalHandler[101]
      End processing HTTP request after 543.6428ms - OK
```

#### 6.2 HTTP 监听器 [:top:](#用户手册-top)

在某些场景下可能对业务发出的 HTTP 请求进行 Debug ，需要看到原始的 HTTP 请求和返回信息， SDK 提供监听器功能来获取原始的为加密的 HTTP 请求和返回信息。

> :warning:  Warning: 原始信息打印仅在 Debug 阶段使用，请不要在生产系统中将原始的 HTTP 头和 Body 信息打印到日志，这些信息并未加密且其中包含敏感数据，例如所创建虚拟机的密码，IAM 用户的密码等；当 Body 体为二进制内容，即 Content-Type 标识为二进制时，Body 为"***"，详细内容不输出。

``` csharp
private void RequestHandler(HttpRequestMessage message, ILogger logger)
{
    logger.LogDebug(message.ToString());
}

private void ResponseHandler(HttpResponseMessage message, ILogger logger)
{
    logger.LogDebug(message.ToString());
}

var client = VpcClient.NewBuilder()
    .WithLogging(LogLevel.Debug)
    .WithHttpHandler(new HttpHandler()
        .AddRequestHandler(RequestHandler)
        .AddResponseHandler(ResponseHandler))
    .Build();
```

**说明:**

HttpHandler 支持如下方法 `AddRequestHandler` 、`AddResponseHandler` 。

### 7. 接口调用器 [:top:](#用户手册-top)

#### 7.1 自定义请求头 [:top:](#用户手册-top)

可以根据需要灵活地配置请求头域参数，非必要**请勿**指定诸如`Host`、`Authorization`、`User-Agent`、`Content-Type`等通用请求头，可能会导致接口调用错误。

**同步调用**

```csharp
using System;
using System.Net.Http;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

var client = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
    .Build();

var req = new ListVpcsRequest();
var resp = client.ListVpcsInvoker(req)
    // 自定义请求头
    .AddHeader("key1", "value1")
    .AddHeader("key2", "value2")
    .Invoke();
Console.WriteLine(resp.HttpStatusCode);
```

**异步调用**

```csharp
using System;
using System.Net.Http;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

var client = VpcAsyncClient.NewBuilder()
    .WithCredential(auth)
    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
    .Build();

var req = new ListVpcsRequest();
var resp = await client.ListVpcsAsyncInvoker(req)
    // 自定义请求头
    .AddHeader("key1", "value1")
    .AddHeader("key2", "value2")
    .Invoke();
Console.WriteLine(resp.HttpStatusCode);
```

#### 7.2 请求重试 [:top:](#用户手册-top)

`v3.1.96`版本起支持请求重试，需要配置以下参数：

- 重试条件：根据上一次请求的响应或异常来判断是否重试
- 最大重试次数：当符合重试条件时的最大重试次数，指定范围[1, 10]
- 重试策略：计算每次重试前的等待时间（毫秒）

**同步调用**

```csharp
using System;
using System.Net.Http;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

var client = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
    .Build();

var req = new ListVpcsRequest();
// 当发生连接异常的时候进行请求重试，最大重试3次，重试间隔的策略为立即重试
var resp = client.ListVpcsInvoker(req)
         .WithRetry((response, exception) => exception is ConnectionException, 3, BackoffStrategies.None).Invoke();

// 当服务不可用时进行重试，最大重试3次，重试间隔的策略为等抖动指数退避
// var resp = client.ListVpcsInvoker(req)
//       .WithRetry((response, exception) => exception is ServerResponseException exc && exc.HttpStatusCode == 503, 3, BackoffStrategies.EqualJitter).Invoke();
```

**异步调用**

```csharp
using System;
using System.Net.Http;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

var client = VpcAsyncClient.NewBuilder()
    .WithCredential(auth)
    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
    .Build();

var req = new ListVpcsRequest();
// 当发生连接异常的时候进行请求重试，最大重试3次，重试间隔的策略为立即重试
var resp = await client.ListVpcsAsyncInvoker(req)
         .WithRetry((response, exception) => exception is ConnectionException, 3, BackoffStrategies.None).Invoke();

// 当服务不可用时进行重试，最大重试3次，重试间隔的策略为等抖动指数退避
// var resp = await client.ListVpcsAsyncInvoker(req)
//       .WithRetry((response, exception) => exception is ServerResponseException exc && exc.HttpStatusCode == 503, 3, BackoffStrategies.EqualJitter).Invoke();
```

### 8. 文件上传 [](#用户手册-top)

以设备接入服务的上传批量任务文件接口为例：

```csharp
using System;
using System.IO;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.IoTDA.V5;
using HuaweiCloud.SDK.IoTDA.V5.Model;

namespace UploadBatchTaskFileDemo
{
    class Program
    {

        static void UploadBatchTaskFile(IoTDAClient client)
        {
            var file = File.OpenRead("/tmp/template.xlsx");
            var filePart = new FormDataFilePart(file, "template.xlsx");

            var body = new UploadBatchTaskFileRequestBody()
            {
                File = filePart
            };

            var req = new UploadBatchTaskFileRequest
            {
                Body = body
            };

            var resp = client.UploadBatchTaskFile(req);
            var respStatusCode = resp.HttpStatusCode;
            Console.WriteLine(respStatusCode);
        }

        static void Main(string[] args)
        {
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var projectId = "{your project id}";
            var endpoint = "{your endpoint string}";

            var auth = new BasicCredentials(ak, sk, projectId);

            var client = IoTDAClient.NewBuilder()
                .WithCredential(auth)
                .WithEndPoint(endpoint)
                .Build();

            UploadBatchTaskFile(client);
        }
    }
}
```

### 9. FAQ [:top:](#用户手册-top)

1、使用 .NET Framework 集成 .Net SDK, 报错 System.Net.ProtocolViolationException: 无法发送具有此谓词类型的内容正文

【问题原因】：.NET Framework 不支持生成带有请求体的 GET 请求

【解决方案】：配置参数`IgnoreBodyForGetRequest` 使GET请求不带请求体， 如下：

```c#
var httpConfig = HttpConfig.GetDefaultConfig();
httpConfig.IgnoreBodyForGetRequest = true;

var client = VpcClient.NewBuilder()
    .WithCredential(auth)
    .WithHttpConfig(httpConfig)
    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
    .Build();
```

2、使用 .NET Framework 4.7 集成 .NET SDK，发生死锁问题

【问题现象】：使用 **同步客户端** 调用某接口，任务启动后程序挂死，无任何报错信息，也不会超时退出

【问题原因】：.NET SDK 内部 **同步客户端** 发送请求的实现是先发送 **异步** 请求，然后等待异步任务返回。在此场景下，.Net Framework UI 的线程上下文和 SDK 的异步任务上下文发生了**死锁**，导致
SDK 的异步任务无法启动。[原文链接](https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html)

【解决方案】：**将同步客户端切换成异步客户端**，从 UI 事件到 API 请求均为异步就不会存在死锁问题，以下为MVC和WPF解决方案的示例：

MVC

```c#
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly VpcAsyncClient _vpcAsyncClient = InitAsyncClient();

        private static VpcAsyncClient InitAsyncClient()
        {
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var auth = new BasicCredentials(ak, sk);
			
            // 使用异步客户端
            var client = VpcAsyncClient.NewBuilder()
                    .WithCredential(auth)
                    .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                    .Build();
            return client;
        }

        private async Task<ListVpcsResponse> ListVpcsAsync()
        {
            var req = new ListVpcsRequest();
            
            // 异步发送请求，使用await不会阻塞线程
            var resp = await _vpcAsyncClient.ListVpcsAsync(req);
            Console.WriteLine(resp.GetHttpStatusCode());
            return resp;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        // 使用异步方法替换同步方法
        public async Task<ActionResult> About()
        {
            var resp = await ListVpcsAsync();
            var respString = JsonUtils.Serialize(resp);

            ViewBag.Message = respString;
            return View();
        }
    }
}
```

WPF

```c#
using System;
using System.Threading.Tasks;
using System.Windows;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Core.Auth;
using HuaweiCloud.SDK.Vpc.V2;
using HuaweiCloud.SDK.Vpc.V2.Model;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        private readonly VpcAsyncClient _asyncClient = InitAsyncClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private static VpcAsyncClient InitAsyncClient()
        {
            var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
            var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
            var auth = new BasicCredentials(ak, sk);

            // 使用异步客户端
            var client = VpcAsyncClient.NewBuilder()
                .WithCredential(auth)
                .WithRegion(VpcRegion.ValueOf("cn-north-4"))
                .Build();

            return client;
        }

        private async Task<ListVpcsResponse> ListVpcs()
        {
            var req = new ListVpcsRequest();

            // 异步发送请求，使用await不会阻塞线程
            var resp = await _asyncClient.ListVpcsAsync(req);
            Console.WriteLine(resp.GetHttpStatusCode());
            return resp;
        }

        // 使用异步方法替换同步方法
        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var resp = await ListVpcs();
            var respString = JsonUtils.Serialize(resp);
            MessageBox.Show(respString);
        }
    }
}
```

3、云联盟场景如何调用

``` csharp
// 指定终端节点，以 云联盟都柏林节点调用 VPC 服务为例
String endpoint = "https://vpc.eu-west-101.myhuaweicloud.com";

// 初始化客户端认证信息，需要填写相应 projectId/domainId，以初始化 BasicCredentials 为例
var ak = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_AK");
var sk = Environment.GetEnvironmentVariable("HUAWEICLOUD_SDK_SK");
var projectId = "{your projectId string}";
Credentials basicCredentials = new BasicCredentials(ak, sk, projectId);

// 初始化指定云服务的客户端 {Service}Client，以初始化 Region 级服务 VPC 的 VpcClient 为例
VpcClient vpcClient = VpcClient.NewBuilder()
    .WithCredential(basicCredentials)
    .WithEndPoint(endpoint)
    .Build();
```