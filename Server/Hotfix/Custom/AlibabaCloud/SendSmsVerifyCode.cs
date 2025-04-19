// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AlibabaCloud.SDK.Sample
{

    //发送短信验证码
    public class SendSmsVerifyCode
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
            };
            // Endpoint 请参考 https://api.aliyun.com/product/Dypnsapi
            config.Endpoint = "dypnsapi.aliyuncs.com";
            return new AlibabaCloud.SDK.Dypnsapi20170525.Client(config);
        }

        public static void Main(string[] args)
        {
            AlibabaCloud.SDK.Dypnsapi20170525.Client client = CreateClient();
            AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest sendSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest
            {
                PhoneNumber = "18319670288",
                TemplateCode = "azsq_*****",
                TemplateParam = "{\"code\":\"##code##\"}",
                SignName = "{\"code\":\"##code##\"}",
            };
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            try
            {
                // 复制代码运行请自行打印 API 的返回值
                client.SendSmsVerifyCodeWithOptions(sendSmsVerifyCodeRequest, runtime);
            }
            catch (TeaException error)
            {
                // 此处仅做打印展示，请谨慎对待异常处理，在工程项目中切勿直接忽略异常。
                // 错误 message
                Console.WriteLine(error.Message);
                // 诊断地址
                Console.WriteLine(error.Data["Recommend"]);
                AlibabaCloud.TeaUtil.Common.AssertAsString(error.Message);
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
            }
        }


    }
}