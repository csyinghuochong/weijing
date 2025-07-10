// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ET;
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
                // 您的AccessKey ID
                AccessKeyId = Environment.GetEnvironmentVariable("access_key_id"),
                // 您的AccessKey Secret
                AccessKeySecret = Environment.GetEnvironmentVariable("access_key_secret"),
            };
            // Endpoint 请参考 https://api.aliyun.com/product/Dypnsapi
            config.Endpoint = "dypnsapi.aliyuncs.com";
            return new AlibabaCloud.SDK.Dypnsapi20170525.Client(config);
        }

        public static int Send(string phoneNum)
        {

            //短信模板变量填写的参数值。验证码位置使用"##code##"替代。

            //示例：如模板内容为：“您的验证码是${ authCode}，5 分钟内有效，请勿告诉他人。”。此时，该字段传入：{ "authCode":"##code##"}
            //AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest sendSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest
            //{
            //    PhoneNumber = phoneNum,
            //    TemplateCode = "SMS_154950909",
            //    //TemplateParam = "{\"code\":\"##code##\"}",
            //    // TemplateParam = "您的验证码为：${code}，请勿泄露于他人！",
            //    TemplateParam = "{\"code\":\"##code##\"}",
            //    SignName = "阿里云短信测试",
            //    Interval = 10,
            //    OutId = TimeHelper.ServerNow().ToString(),
            //    CodeType = 1,
            //    CodeLength = 4,
            //    ReturnVerifyCode = true,
            //};

            AlibabaCloud.SDK.Dypnsapi20170525.Client client = CreateClient();
            AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest sendSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest
            {
                PhoneNumber = phoneNum,
                TemplateCode = "100001",
                TemplateParam = "{\"code\":\"##code##\",\"min\":10}",
                SignName = "速通互联验证平台",
                Interval = 10,
                OutId = TimeHelper.ServerNow().ToString(),
                CodeType = 1,
                CodeLength = 4,
                ReturnVerifyCode = true,
            };
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            try
            {
                Console.WriteLine($"Send PhoneNumber: {phoneNum}");
                // 复制代码运行请自行打印 API 的返回值
                var response =  client.SendSmsVerifyCodeWithOptions(sendSmsVerifyCodeRequest, runtime);
                if (response != null && response.Body!=null)
                {
                    // 打印返回结果的 JSON 字符串
                    Console.WriteLine($"{TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}" +  Newtonsoft.Json.JsonConvert.SerializeObject(response));
                    Log.Debug($"Send PhoneNumber: {phoneNum}" + Newtonsoft.Json.JsonConvert.SerializeObject(response));
                    // 你可以根据具体的返回类型和需求，访问返回对象的属性
                    // 例如：Console.WriteLine(response.Body.SomeProperty);
                    if (response.Body.Success == true && response.Body.Code == "OK" )
                    {
                        return 0;
                    }
                    return ErrorCode.MOBILE_SEND_ILLEGAL;
                }
                return ErrorCode.MOBILE_SEND_ILLEGAL;
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
            return ErrorCode.MOBILE_SEND_ILLEGAL;
        }


        public static int Send_2(string phoneNum, int templateParam, int signtype)
        {

            //短信模板变量填写的参数值。验证码位置使用"##code##"替代。

            //示例：如模板内容为：“您的验证码是${ authCode}，5 分钟内有效，请勿告诉他人。”。此时，该字段传入：{ "authCode":"##code##"}
            //AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest sendSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest
            //{
            //    PhoneNumber = phoneNum,
            //    TemplateCode = "SMS_154950909",
            //    //TemplateParam = "{\"code\":\"##code##\"}",
            //    // TemplateParam = "您的验证码为：${code}，请勿泄露于他人！",
            //    TemplateParam = "{\"code\":\"##code##\"}",
            //    SignName = "阿里云短信测试",
            //    Interval = 10,
            //    OutId = TimeHelper.ServerNow().ToString(),
            //    CodeType = 1,
            //    CodeLength = 4,
            //    ReturnVerifyCode = true,
            AlibabaCloud.SDK.Dypnsapi20170525.Client client = CreateClient();
            AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest sendSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest
            {
                PhoneNumber = phoneNum,
                TemplateCode = "SMS_317195299",
                TemplateParam = templateParam == 1 ? "您的验证码为：${code}，请勿泄露于他人！" : "{\"code\":\"##code##\"}",
                SignName = signtype == 1 ? "烟台贺寒信息科技" : "危境",
                Interval = 10,
                OutId = TimeHelper.ServerNow().ToString(),
                CodeType = 1,
                CodeLength = 4,
                ReturnVerifyCode = true,
            };

            //AlibabaCloud.SDK.Dypnsapi20170525.Client client = CreateClient();
            //AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest sendSmsVerifyCodeRequest = new AlibabaCloud.SDK.Dypnsapi20170525.Models.SendSmsVerifyCodeRequest
            //{
            //    PhoneNumber = phoneNum,
            //    TemplateCode = "100001",
            //    TemplateParam = "{\"code\":\"##code##\",\"min\":10}",
            //    SignName = "云渚科技验证平台",
            //    Interval = 10,
            //    OutId = TimeHelper.ServerNow().ToString(),
            //    CodeType = 1,
            //    CodeLength = 4,
            //    ReturnVerifyCode = true,
            //};
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            try
            {
                Console.WriteLine($"Send PhoneNumber: {phoneNum}");
                // 复制代码运行请自行打印 API 的返回值
                var response = client.SendSmsVerifyCodeWithOptions(sendSmsVerifyCodeRequest, runtime);
                if (response != null && response.Body != null)
                {
                    // 打印返回结果的 JSON 字符串
                    Console.WriteLine($"{TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}" + Newtonsoft.Json.JsonConvert.SerializeObject(response));
                    // 你可以根据具体的返回类型和需求，访问返回对象的属性
                    // 例如：Console.WriteLine(response.Body.SomeProperty);
                    if (response.Body.Success == true && response.Body.Code == "OK")
                    {
                        string VerifyCode = response.Body.Model.VerifyCode;
                        if (!string.IsNullOrEmpty(VerifyCode))
                        {
                            CheckSmsVerifyCode.Check(phoneNum, VerifyCode, response.Body.Model.OutId);
                        }
                        return 0;
                    }

                    return ErrorCode.MOBILE_SEND_ILLEGAL;
                }
                return ErrorCode.MOBILE_SEND_ILLEGAL;
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
            return ErrorCode.MOBILE_SEND_ILLEGAL;
        }
    }
}