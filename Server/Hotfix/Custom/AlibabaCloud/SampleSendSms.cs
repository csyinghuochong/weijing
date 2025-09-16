// This file is auto-generated, don't edit it. Thanks.

using ET;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AlibabaCloud.SDK.Sample
{
    public class Sample
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
        public static AlibabaCloud.SDK.Dysmsapi20170525.Client CreateClient()
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
            // Endpoint 请参考 https://api.aliyun.com/product/Dysmsapi
            config.Endpoint = "dysmsapi.aliyuncs.com";
            return new AlibabaCloud.SDK.Dysmsapi20170525.Client(config);
        }

        public static void Send(string phoneNum, int templateParam, int signtype)
        {
            AlibabaCloud.SDK.Dysmsapi20170525.Client client = CreateClient();
            AlibabaCloud.SDK.Dysmsapi20170525.Models.SendSmsRequest sendSmsRequest = new AlibabaCloud.SDK.Dysmsapi20170525.Models.SendSmsRequest
            {
                SignName = signtype == 1 ? "烟台贺寒信息科技" : "危境",
                TemplateCode = "SMS_317195299",
                PhoneNumbers = phoneNum,
                TemplateParam = "{\"code\":\"1234\"}",
                //templateParam == 1 ?  "您的验证码为：${code}，请勿泄露于他人！" : "{\"code\":\"##code##\"}",
                // "{\"code\":\"1234\"}",
            };
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            try
            {
                // 复制代码运行请自行打印 API 的返回值
                Console.WriteLine($"Send :  {phoneNum}    {signtype}");
                var response = client.SendSmsWithOptions(sendSmsRequest, runtime);
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response));
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



        public static void Send_2(string phoneNum, int templateParam, int signtype, string code)
        {
            AlibabaCloud.SDK.Dysmsapi20170525.Client client = CreateClient();
            AlibabaCloud.SDK.Dysmsapi20170525.Models.SendSmsRequest sendSmsRequest = new AlibabaCloud.SDK.Dysmsapi20170525.Models.SendSmsRequest
            {
                SignName = signtype == 1 ? "烟台贺寒信息科技" : "危境",
                TemplateCode = "SMS_317195299",
                PhoneNumbers = phoneNum,
                TemplateParam = "{\"code\":\"" + code + "\"}"
                //templateParam == 1 ?  "您的验证码为：${code}，请勿泄露于他人！" : "{\"code\":\"##code##\"}",
                // "{\"code\":\"1234\"}",
            };

            //AlibabaCloud.SDK.Dysmsapi20170525.Models.SendSmsRequest sendSmsRequest = new AlibabaCloud.SDK.Dysmsapi20170525.Models.SendSmsRequest
            //{
            //    SignName = "速通互联验证平台",
            //    TemplateCode = "100001",
            //    PhoneNumbers = phoneNum,
            //    TemplateParam = "{\"code\":\"" + code + "\"}"
            //    //templateParam == 1 ?  "您的验证码为：${code}，请勿泄露于他人！" : "{\"code\":\"##code##\"}",
            //    // "{\"code\":\"1234\"}",
            //};


            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            try
            {
                // 复制代码运行请自行打印 API 的返回值
                Console.WriteLine($"Send :  {phoneNum}    {signtype}");
                var response = client.SendSmsWithOptions(sendSmsRequest, runtime);
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response));
                Log.Debug("11");
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