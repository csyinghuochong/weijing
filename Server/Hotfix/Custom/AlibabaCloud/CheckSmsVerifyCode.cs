// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;
using ET;


namespace AlibabaCloud.SDK.Sample
{
    public class CheckSmsVerifyCode
    {

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>使用凭据初始化账号Client</para>
        /// </description>
        /// 
        /// <returns>
        /// Client
        /// </returns>
        /// 
        /// <term><b>Exception:</b></term>
        /// Exception
        public static AlibabaCloud.SDK.Dypnsapi20170525.Client CreateClient()
        {
            // 工程代码建议使用更安全的无AK方式，凭据配置方式请参见：https://help.aliyun.com/document_detail/378671.html。
            Aliyun.Credentials.Client credential = new Aliyun.Credentials.Client();
            AlibabaCloud.OpenApiClient.Models.Config config = new AlibabaCloud.OpenApiClient.Models.Config
            {
                Credential = credential,
                // 您的AccessKey ID
                AccessKeyId = Environment.GetEnvironmentVariable("access_key_id"),
                // 您的AccessKey Secret
                AccessKeySecret = Environment.GetEnvironmentVariable("access_key_secret"),
            };
            // Endpoint 请参考 https://api.aliyun.com/product/Dypnsapi
            config.Endpoint = "dypnsapi.aliyuncs.com";
            return new AlibabaCloud.SDK.Dypnsapi20170525.Client(config);
        }

        public static int Check(string phoneNum, string code, string outid)
        {
            AlibabaCloud.SDK.Dypnsapi20170525.Client client = CreateClient();
            AlibabaCloud.SDK.Dypnsapi20170525.Models.CheckSmsVerifyCodeRequest checkSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.CheckSmsVerifyCodeRequest()
            {
                PhoneNumber = phoneNum,
                VerifyCode = code   ,
                OutId = outid,
            };
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            try
            {
                Console.WriteLine($"Check PhoneNumber: {phoneNum}");

                // 复制代码运行请自行打印 API 的返回值
                var response = client.CheckSmsVerifyCodeWithOptions(checkSmsVerifyCodeRequest, runtime);
                if (response != null && response.Body != null)
                {
                    // 打印返回结果的 JSON 字符串
                    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response));
                    // 你可以根据具体的返回类型和需求，访问返回对象的属性
                    // 例如：Console.WriteLine(response.Body.SomeProperty);
                    if (response.Body.Success == true && response.Body.Code == "OK")
                    {
                        return 0;
                    }
                    return ErrorCode.MOBILE_CHECK_ILLEGAL;
                }
                return ErrorCode.MOBILE_CHECK_ILLEGAL;
            }
            catch (TeaException error)
            {
                // 此处仅做打印展示，请谨慎对待异常处理，在工程项目中切勿直接忽略异常。
                // 错误 message
                Console.WriteLine(error.Message);
                // 诊断地址
                Console.WriteLine(error.Data["Recommend"]);
                AlibabaCloud.TeaUtil.Common.AssertAsString(error.Message);
                return ErrorCode.MOBILE_CHECK_ILLEGAL;
            }
            catch (Exception _error)
            {
                TeaException error = new TeaException(new Dictionary<string, object>
                {
                    { "message", _error.Message }
                });
                // 此处仅做打印展示，请谨慎对待异常处理，在工程项目中切勿直接忽略异常。
                // 错误 message
                Console.WriteLine(error.Message);
                // 诊断地址
                Console.WriteLine(error.Data["Recommend"]);
                AlibabaCloud.TeaUtil.Common.AssertAsString(error.Message);
                return ErrorCode.MOBILE_CHECK_ILLEGAL;
            }
        }

    }
}