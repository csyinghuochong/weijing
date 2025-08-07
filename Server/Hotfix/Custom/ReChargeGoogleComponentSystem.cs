using System;
using Google.Apis.AndroidPublisher.v3;
using Google.Apis.AndroidPublisher.v3.Data;
using Google.Apis.Auth.OAuth2;

namespace ET
{
    [ObjectSystem]
    public class ReChargeGoogleComponentAwake: AwakeSystem<ReChargeGoogleComponent>
    {
        public override void Awake(ReChargeGoogleComponent self)
        {
            Log.Warning($"ReChargeGoogleComponent.Awake");

            // 登录Google Cloud 控制台
            // 选择或创建你的项目
            // 进入 "IAM 与管理" → "服务账号"
            // 创建新的服务账号或选择现有账号，并添加权限角色
            // 为服务账号创建并下载 JSON 格式的密钥文件
            // 从下载的 JSON 文件中：
            // client_email字段对应serviceAccountEmail
            // private_key字段对应privateKey
            // ------------
            // Google Cloud → API和服务 ，启动 Google Play Android Developer API
            // Google Play Console → 用户与权限 ，添加服务账号并设置权限
            // ------------
            // 如果报错显示没有权限，可能情况：如果在添加账号之前就创建过商品，要修改一下商品的描述。。。。这么做应该是主动刷新一下服务器的配置
            // 本地测试连接得挂VPN才能连接，云服务器未知
            // 测试支付，Google Play Console → 设置 → 许可测试 ，添加测试账号
            string serviceAccountEmail = "weijing@awesome-tube-464511-j5.iam.gserviceaccount.com";
            string privateKey = "-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCuo7XlrSTqhrDY\nYrQzJWNfqi8Y+keIdjC3evQcBeOBz9vOgBqVSztBZSudef7pIE04qEoqO/e500zJ\ntSHmgZVleMFrPjkDhJubRyjJ7c0ayVQe6Tg0687WbqGXb6GuWR9p1JqsJwCqY+g1\nhFt2t6AIAUKGaQsAg76gEm2Qhe7SQah/yBFi0+xrPNOcJTiq4LWtKsGpBUTsZZm3\nh332eQvgGr0JeRFk4G6j03r4nPV3rY0r2CAR1i11mXmj/Ii1t8Bqato1GT7UNsA6\nAV/UKjaKVIYWbXsVSWhAsnLLqq1HzLR8QvCL1WKqVVLu8Ra995txaOkdeB7COmG3\nyshgJDk9AgMBAAECggEAE54sVsqmdPoAb65W09AFY7+4XrPuyTONsW7McUFwFysE\nZCQb2F2FIIl+5sfHjOSmCBFPk4L9BxDndVk1n7E62RVBlQx+VxjUahMKT/S4r6Oi\nIX7NY5SBvbDb0ikmHnHAh6DsZx5SgtGKSki+BY4HGh8aHAM8yygBh/XJ/QwukcvC\nkorEU+CTY5ZCDYw2qRqCBOAjYYOaVdTbkjSoMSH+CLsHaZbEqW8Hh3khdeNmtN72\nnYD9YYFXxBEvyQ2YmsT5Uacj9WGyo0ZnKGJxxwd43e3EqT/YRBUBt7iTqI2Ly6sk\nh0qfmzjZjWkH6X2EBMQMIcRSzd64AzwpV4NbReVJOQKBgQDtJovBkK3FADWTIsr9\nNwAMv/3uaf0N9cLEBCkqfuz89B+YaO0yH2VpfOjTEw33Yxqg/w1+S5kozMg7CCRz\nlycwDLZM0V/fUPD7wbRJmxNP15zo+pOZpkeQHDl6+NEN1Y4v/HJDVyf9JF+907vD\n+fHwcJ9oZldgt8kY+9zAHKdRuwKBgQC8hTY7JKtKiIc6xypgi2nEI/jde0tm1Lm8\nfOff9TX9KY/lzimYMCP79FVggbrJNzgutuyb/ByQvwn/3qFKuhW993TKthQzLY4m\nbu0bdRCBqwuJHRXYrF9ST19TuX5L4P+13LBgOS6WMlgnNHk3s9DIFHPw4wc5EeC/\nLsvJxHoVZwKBgCJJN11l0Gmx7Qz3s8dGI2C0hT7p3ecdx+nU/CqjrRmpJcRAL0LW\n3S+SGoshrxw8HMZ3+Xhv75XBfZVjSPnZOZYt0FFs1+KObjjHuYwGupUJhCr+x0Yo\njyIboofP31GTtXnkkpR/zk0/7AOiz/u2cC8l6TYLzcgy6gUNrM2tltcvAoGAUpat\nbnWfERUE4Uw1lXweBs6XjTghjVguUpQJ5USAtXsKzmtmL4UPjqa47IGI+fPWCikb\nOS7WuNboo4697IXfVozdPp1L9ivD9bRs7bV4WMY9VIFIe9bwH5gkNAK0gLt+awbW\nwiDq9uPxWKOVY0DEe5LyRBrBpE/fvQHcR3Vq4osCgYEApfTyh7VTPP9av+f1w1ma\nrM5uT25FlAFVBwxKE/BXdKTZr1GTP2vah8KlSAUHzewXlrOVAZv2DPW72d8kpzaL\nRMKr/VlOOEaE4Xka4khV1gvf8wdMa1jcdlRJUWH6bUBYpYk1vHmvjx6H3XeZZTcT\nNiq4lfwiaB1vIzjjMSVOncc=\n-----END PRIVATE KEY-----\n";
            // 加载服务账号凭据
            ServiceAccountCredential credential = new ServiceAccountCredential(new ServiceAccountCredential.Initializer(serviceAccountEmail)
            {
                Scopes = new[] { AndroidPublisherService.Scope.Androidpublisher }
            }.FromPrivateKey(privateKey));

            // 创建AndroidPublisher服务
            self.AndroidPublisherService = new AndroidPublisherService(new Google.Apis.Services.BaseClientService.Initializer
            {
                HttpClientInitializer = credential, ApplicationName = "weijing"
            });
            
            self.PayLoadList.Clear();
        }
    }

    public static class ReChargeGoogleComponentSystem
    {
        public static async ETTask<int> OnGooglePayVerify(this ReChargeGoogleComponent self, M2R_RechargeRequest request)
        {
            Log.Warning($"支付订单[Google]回调执行 " + "id:" + request.UnitId);

            try
            {
                string payLoad = request.payMessage;
                Payload_Google payloadGoogle = JsonHelper.FromJson<Payload_Google>(payLoad);
                Payload_Google_json payloadGoogleJson = JsonHelper.FromJson<Payload_Google_json>(payloadGoogle.json);

                if (self.PayLoadList.Contains(payloadGoogleJson.purchaseToken))
                {
                    return ErrorCode.ERR_GoogleVerify;
                }

                // 验证订单
                var response = await self.AndroidPublisherService.Purchases.Products.Get("com.goinggame.weijing", payloadGoogleJson.productId, payloadGoogleJson.purchaseToken).ExecuteAsync();

                if (response == null)
                {
                    Log.Warning($"Google充值回调ERROR1 返回消息null");
                    return ErrorCode.ERR_GoogleVerify;
                }

                // 检查订单是否有效
                GoogleVerifyPayResult googleVerifyPayResult = new GoogleVerifyPayResult(response);
                if (googleVerifyPayResult.PurchaseState != 0)
                {
                    Log.Warning($"Google充值回调ERROR1 {googleVerifyPayResult.PurchaseState}");
                    return ErrorCode.ERR_GoogleVerify;
                }

                string prefix = "pay_";
                if (!googleVerifyPayResult.ProductId.Contains(prefix))
                {
                    Log.Warning($"Google充值回调ERROR6 : !{prefix}");
                    return ErrorCode.ERR_GoogleVerify;
                }

                int rechargeNumber = 0;
                try
                {
                    rechargeNumber = int.Parse(googleVerifyPayResult.ProductId.Substring(prefix.Length));
                }
                catch (Exception ex)
                {
                    Log.Warning(ex.ToString());
                    return ErrorCode.ERR_GoogleVerify;
                }

                self.PayLoadList.Add(payloadGoogleJson.purchaseToken);
                if (self.PayLoadList.Count >= 100)
                {
                    self.PayLoadList.RemoveAt(0);
                }

                string postReturnStr = JsonHelper.ToJson(googleVerifyPayResult);

                string serverName = ServerHelper.GetGetServerItem(false, request.Zone).ServerName;
                Log.Warning($"支付订单[Google]支付成功: 区：{serverName}    玩家名字：{request.UnitName}     充值额度：{rechargeNumber}");
                Log.Console($"支付订单[Google]支付成功: 区：{serverName}    玩家名字：{request.UnitName}     充值额度：{rechargeNumber}  时间:{TimeHelper.DateTimeNow().ToString()}");
                await RechargeHelp.OnPaySucessToGate(request.Zone, request.UnitId, rechargeNumber, postReturnStr, PayTypeEnum.Google);
            }
            catch (Exception ex)
            {
                Log.Warning($"Google充值回调11_1 {ex.ToString()}");
                return ErrorCode.ERR_GoogleVerify;
            }

            return ErrorCode.ERR_Success;
        }

        public static async ETTask OnTest(this ReChargeGoogleComponent self)
        {
            string productId = "pay_1";
            // string purchaseToken = "pnggilmjjliinlommjgndhhh.AO-J1Oy4zRl-WWHqUp3O4QaxR8HZwRS1Oq1xOUiC6TEsWQpL95raRrmt9r2fmIutFKPxJ4ImlxXd-QrEsrqaRqgXnc2JRr8ZplKt_YRmTVlyj9wMHw2PXKs";
            string purchaseToken = "pimgdcjdkjniiaoeijfnplei.AO-J1OwUKm0Lqbq9VBpQ1jyYPJFZD-l8wB2CvoPjXDm5lJ-15vnlp4vU4zvIqayPMHhFdXBXtTPpRQ05DGCK1GA1GSR3RGGkjT8GgPzpNPX6XhPHTUNKsqE";
            // 验证订单
            var response = await self.AndroidPublisherService.Purchases.Products.Get("com.goinggame.weijing", productId, purchaseToken).ExecuteAsync();

            if (response == null)
            {
                Console.WriteLine($"Google充值回调ERROR1 返回消息null");
                return;
            }

            // 检查订单是否有效
            GoogleVerifyPayResult googleVerifyPayResult = new GoogleVerifyPayResult(response);
            if (googleVerifyPayResult.PurchaseState == 0)
            {
                Console.WriteLine($"Google充值成功 ProductId:{productId} purchaseToken:{purchaseToken}");
            }
            else
            {
                Console.WriteLine($"Google充值失败 ProductId:{productId} purchaseToken:{purchaseToken}");
            }
        }
    }
}