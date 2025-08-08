using System;
using System.Security.Cryptography;
using System.Text;
using Google.Apis.AndroidPublisher.v3;
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
            // awesome-tube-464511-j5-c991b6d4e499.json
            // {
            //  "type": "service_account",
            //  "project_id": "awesome-tube-464511-j5",
            //  "private_key_id": "c991b6d4e4994529822511c4f96c8265032aafa2",
            //  "private_key": "-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCuo7XlrSTqhrDY\nYrQzJWNfqi8Y+keIdjC3evQcBeOBz9vOgBqVSztBZSudef7pIE04qEoqO/e500zJ\ntSHmgZVleMFrPjkDhJubRyjJ7c0ayVQe6Tg0687WbqGXb6GuWR9p1JqsJwCqY+g1\nhFt2t6AIAUKGaQsAg76gEm2Qhe7SQah/yBFi0+xrPNOcJTiq4LWtKsGpBUTsZZm3\nh332eQvgGr0JeRFk4G6j03r4nPV3rY0r2CAR1i11mXmj/Ii1t8Bqato1GT7UNsA6\nAV/UKjaKVIYWbXsVSWhAsnLLqq1HzLR8QvCL1WKqVVLu8Ra995txaOkdeB7COmG3\nyshgJDk9AgMBAAECggEAE54sVsqmdPoAb65W09AFY7+4XrPuyTONsW7McUFwFysE\nZCQb2F2FIIl+5sfHjOSmCBFPk4L9BxDndVk1n7E62RVBlQx+VxjUahMKT/S4r6Oi\nIX7NY5SBvbDb0ikmHnHAh6DsZx5SgtGKSki+BY4HGh8aHAM8yygBh/XJ/QwukcvC\nkorEU+CTY5ZCDYw2qRqCBOAjYYOaVdTbkjSoMSH+CLsHaZbEqW8Hh3khdeNmtN72\nnYD9YYFXxBEvyQ2YmsT5Uacj9WGyo0ZnKGJxxwd43e3EqT/YRBUBt7iTqI2Ly6sk\nh0qfmzjZjWkH6X2EBMQMIcRSzd64AzwpV4NbReVJOQKBgQDtJovBkK3FADWTIsr9\nNwAMv/3uaf0N9cLEBCkqfuz89B+YaO0yH2VpfOjTEw33Yxqg/w1+S5kozMg7CCRz\nlycwDLZM0V/fUPD7wbRJmxNP15zo+pOZpkeQHDl6+NEN1Y4v/HJDVyf9JF+907vD\n+fHwcJ9oZldgt8kY+9zAHKdRuwKBgQC8hTY7JKtKiIc6xypgi2nEI/jde0tm1Lm8\nfOff9TX9KY/lzimYMCP79FVggbrJNzgutuyb/ByQvwn/3qFKuhW993TKthQzLY4m\nbu0bdRCBqwuJHRXYrF9ST19TuX5L4P+13LBgOS6WMlgnNHk3s9DIFHPw4wc5EeC/\nLsvJxHoVZwKBgCJJN11l0Gmx7Qz3s8dGI2C0hT7p3ecdx+nU/CqjrRmpJcRAL0LW\n3S+SGoshrxw8HMZ3+Xhv75XBfZVjSPnZOZYt0FFs1+KObjjHuYwGupUJhCr+x0Yo\njyIboofP31GTtXnkkpR/zk0/7AOiz/u2cC8l6TYLzcgy6gUNrM2tltcvAoGAUpat\nbnWfERUE4Uw1lXweBs6XjTghjVguUpQJ5USAtXsKzmtmL4UPjqa47IGI+fPWCikb\nOS7WuNboo4697IXfVozdPp1L9ivD9bRs7bV4WMY9VIFIe9bwH5gkNAK0gLt+awbW\nwiDq9uPxWKOVY0DEe5LyRBrBpE/fvQHcR3Vq4osCgYEApfTyh7VTPP9av+f1w1ma\nrM5uT25FlAFVBwxKE/BXdKTZr1GTP2vah8KlSAUHzewXlrOVAZv2DPW72d8kpzaL\nRMKr/VlOOEaE4Xka4khV1gvf8wdMa1jcdlRJUWH6bUBYpYk1vHmvjx6H3XeZZTcT\nNiq4lfwiaB1vIzjjMSVOncc=\n-----END PRIVATE KEY-----\n",
            //  "client_email": "weijing@awesome-tube-464511-j5.iam.gserviceaccount.com",
            //  "client_id": "107573788031122372747",
            //  "auth_uri": "https://accounts.google.com/o/oauth2/auth",
            //  "token_uri": "https://oauth2.googleapis.com/token",
            //  "auth_provider_x509_cert_url": "https://www.googleapis.com/oauth2/v1/certs",
            //  "client_x509_cert_url": "https://www.googleapis.com/robot/v1/metadata/x509/weijing%40awesome-tube-464511-j5.iam.gserviceaccount.com",
            //  "universe_domain": "googleapis.com"
            // }
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
            Log.Warning($"支付订单[Google]回调执行 id:" + request.UnitId);
            Log.Warning($"支付订单[Google]回调执行 request.payMessage: " +  request.payMessage);

            try
            {
                string payLoad = request.payMessage;
                Payload_Google payloadGoogle = JsonHelper.FromJson<Payload_Google>(payLoad);
                Payload_Google_json payloadGoogleJson = JsonHelper.FromJson<Payload_Google_json>(payloadGoogle.json);

                if (self.PayLoadList.Contains(payloadGoogleJson.purchaseToken))
                {
                    return ErrorCode.ERR_GoogleVerify;
                }

                // 验证订单 国内云服务器可能访问不了外网
                Google.Apis.AndroidPublisher.v3.Data.ProductPurchase response = await self.AndroidPublisherService.Purchases.Products.Get("com.goinggame.weijing", payloadGoogleJson.productId, payloadGoogleJson.purchaseToken).ExecuteAsync();

                if (response == null)
                {
                    Log.Warning($"Google充值回调ERROR1 返回消息null");
                    return ErrorCode.ERR_GoogleVerify;
                }

                // 检查订单是否有效
                if (response.PurchaseState != 0)
                {
                    Log.Warning($"Google充值回调ERROR1 {response.PurchaseState}");
                    return ErrorCode.ERR_GoogleVerify;
                }

                string prefix = "pay_";
                if (!payloadGoogleJson.productId.Contains(prefix))
                {
                    Log.Warning($"Google充值回调ERROR6 : !{prefix}");
                    return ErrorCode.ERR_GoogleVerify;
                }
                
                int rechargeNumber = int.Parse(payloadGoogleJson.productId.Substring(prefix.Length));
                
                string postReturnStr = JsonHelper.ToJson(response);

                self.PayLoadList.Add(payloadGoogleJson.purchaseToken);
                if (self.PayLoadList.Count >= 100)
                {
                    self.PayLoadList.RemoveAt(0);
                }

                string serverName = ServerHelper.GetGetServerItem(false, request.Zone).ServerName;
                Log.Warning($"支付订单[Google]支付成功: 区：{serverName}    玩家名字：{request.UnitName}     充值额度：{rechargeNumber}");
                Log.Console($"支付订单[Google]支付成功: 区：{serverName}    玩家名字：{request.UnitName}     充值额度：{rechargeNumber}  时间:{TimeHelper.DateTimeNow().ToString()}");
                await RechargeHelp.OnPaySucessToGate(request.Zone, request.UnitId, rechargeNumber, postReturnStr, PayTypeEnum.Google);
            }
            catch (Exception ex)
            {
                Log.Warning($"Google支付验证未知错误: {ex}");
                return ErrorCode.ERR_GoogleVerify;
            }

            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> OnGooglePayVerify2(this ReChargeGoogleComponent self, M2R_RechargeRequest request)
        {
            Log.Warning($"支付订单[Google]回调执行 id:" + request.UnitId);
            Log.Warning($"支付订单[Google]回调执行 request.payMessage: " +  request.payMessage);

            try
            {
                string payLoad = request.payMessage;
                Payload_Google payloadGoogle = JsonHelper.FromJson<Payload_Google>(payLoad);
                Payload_Google_json payloadGoogleJson = JsonHelper.FromJson<Payload_Google_json>(payloadGoogle.json);

                if (self.PayLoadList.Contains(payloadGoogleJson.purchaseToken))
                {
                    return ErrorCode.ERR_GoogleVerify;
                }

                if (!self.Verify(payloadGoogle.json, payloadGoogle.signature))
                {
                    Log.Warning($"Google充值回调ERROR Google支付验证签名错误");
                    return ErrorCode.ERR_GoogleVerify;
                }

                // 检查订单是否有效
                if (payloadGoogleJson.purchaseState != 0)
                {
                    Log.Warning($"Google充值回调ERROR1 {payloadGoogleJson.purchaseState}");
                    return ErrorCode.ERR_GoogleVerify;
                }

                string prefix = "pay_";
                if (!payloadGoogleJson.productId.Contains(prefix))
                {
                    Log.Warning($"Google充值回调ERROR6 : !{prefix}");
                    return ErrorCode.ERR_GoogleVerify;
                }
                
                int rechargeNumber = int.Parse(payloadGoogleJson.productId.Substring(prefix.Length));

                self.PayLoadList.Add(payloadGoogleJson.purchaseToken);
                if (self.PayLoadList.Count >= 100)
                {
                    self.PayLoadList.RemoveAt(0);
                }

                string serverName = ServerHelper.GetGetServerItem(false, request.Zone).ServerName;
                Log.Warning($"支付订单[Google]支付成功: 区：{serverName}    玩家名字：{request.UnitName}     充值额度：{rechargeNumber}");
                Log.Console($"支付订单[Google]支付成功: 区：{serverName}    玩家名字：{request.UnitName}     充值额度：{rechargeNumber}  时间:{TimeHelper.DateTimeNow().ToString()}");
                await RechargeHelp.OnPaySucessToGate(request.Zone, request.UnitId, rechargeNumber, payLoad, PayTypeEnum.Google);
            }
            catch (Exception ex)
            {
                Log.Warning($"Google支付验证未知错误: {ex}");
                return ErrorCode.ERR_GoogleVerify;
            }

            return ErrorCode.ERR_Success;
        }

        /// <summary>
        /// 使用Google Play控制台中的RSA公钥验证签名
        /// </summary>
        public static bool Verify(this ReChargeGoogleComponent self, string json, string signature)
        {
            try
            {
                // 借助Play变现 -> 创收设置 -> 许可
                string base64PublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAmIVIrFQ5gO11Bcdz6lyqNPn0UKa4HmBe8v8GheQNLL2nt8muFuHgwn39XjiN3FQjNCHzTkQ+HR5ZSApTiYbl9fPTnYu1qwCPLdM2QLLjCHv+gpV5zosnHLxg6bGkAQFJS6y+ap3YXIhh9EzqH6Uz4RsMPTWuk4aSJggy6vd7pgd2yaSGb7pEix5wEuK7ek1LLKumVCwSjOBVe3/xlblqhJiEyjbsGPppO9SAYXVNNMRx1piMAUC2doi0QwA3+5x0Zki0wZdag0xpKBPHIabrU6kobYGYLD947Y2fy5uTmU/17qnw+DTdCMmjfEMDsnQMVvYGzUsGr8gp6CEqMayw6wIDAQAB";
                byte[] keyBytes = Convert.FromBase64String(base64PublicKey);
                byte[] signatureBytes = Convert.FromBase64String(signature);
                byte[] dataBytes = Encoding.UTF8.GetBytes(json);

                using (var rsa = RSA.Create())
                {
                    rsa.ImportSubjectPublicKeyInfo(keyBytes, out _);

                    return rsa.VerifyData(
                        dataBytes,
                        signatureBytes,
                        HashAlgorithmName.SHA1,  // Google Play 默认使用 SHA1
                        RSASignaturePadding.Pkcs1
                    );
                }
            }
            catch (Exception ex)
            {
                Log.Warning($"Google支付验证签名错误: {ex}");
                return false;
            }
        }

        public static void OnTest2(this ReChargeGoogleComponent self)
        {
            string payLoad = "{\"json\":\"{\\\"orderId\\\":\\\"GPA.3323-8102-8907-22463\\\",\\\"packageName\\\":\\\"com.goinggame.weijing\\\",\\\"productId\\\":\\\"pay_1\\\",\\\"purchaseTime\\\":1754620478148,\\\"purchaseState\\\":0,\\\"purchaseToken\\\":\\\"pefpdbngkpancdmlnojjlkah.AO-J1OzeiNoNuwuhqLDhAGDYjaZogeUMAgLtZ8pLDfDrM0wVVcoonfaFv_BSlnYsC31g5Lkrwh_uvc8sSXNW1NytSl-E7GaMSPckDncobLFFHhUMQmhzRpQ\\\",\\\"quantity\\\":1,\\\"acknowledged\\\":false}\",\"signature\":\"UV3Jo20TumY6pe0BVi5OY4l9niFdiVsB3sPcSaRPG5UrAjoqZDoHXTbtWmOM2JJhNEvn2hUqUk9qBqYm6ObFMlcS8tJOe4I9LVatM9WZdeO/8iqr9EpVFLNTtl5DZuju9jMWeXQeAnfFwZeSlPMqklhc48DCxvn/WY0Zu3SN4zq0Zb99Gclq65l4QNNY8IT/SgPZnwDp1EPhgahgyKdEnZL1w6BnbpOIa/b9fMI/4eYcVac3L+LyT4x7GLocfNbat+kYmtOFmWyGZLUqPbZR9xvE5l5vCpStX8rDnCw17IrCp8A8Mq+Aoj62c7vnXMg46846v9YBHqHNi3eE1I7hLw==\",\"skuDetails\":[\"{\\\"productId\\\":\\\"pay_1\\\",\\\"type\\\":\\\"inapp\\\",\\\"title\\\":\\\"600\\\\u94bb\\\\u77f3 (\\\\u5371\\\\u5883)\\\",\\\"name\\\":\\\"600\\\\u94bb\\\\u77f3\\\",\\\"description\\\":\\\"\\\\u53ef\\\\u4ee5\\\\u83b7\\\\u5f97600\\\\u94bb\\\\u77f3\\\",\\\"price\\\":\\\"JP\\\\u00a5147\\\",\\\"price_amount_micros\\\":147000000,\\\"price_currency_code\\\":\\\"JPY\\\"}\"]}";
            Payload_Google payloadGoogle = JsonHelper.FromJson<Payload_Google>(payLoad);
            if (self.Verify(payloadGoogle.json, payloadGoogle.signature))
            {
                Console.WriteLine($"Google支付验证签名成功");
            }
            else
            {
                Console.WriteLine($"Google支付验证签名错误");
            }
        }
        
        public static async ETTask OnTest(this ReChargeGoogleComponent self)
        {
            string productId = "pay_1";
            // string purchaseToken = "pnggilmjjliinlommjgndhhh.AO-J1Oy4zRl-WWHqUp3O4QaxR8HZwRS1Oq1xOUiC6TEsWQpL95raRrmt9r2fmIutFKPxJ4ImlxXd-QrEsrqaRqgXnc2JRr8ZplKt_YRmTVlyj9wMHw2PXKs"; //假的
            // string purchaseToken = "pnggilmjjliinlommjgndhhh.AO-J1Oy4zRl-WWHqUp3O4QaxR8HZwRS1Oq1xOUiC6TEsWQpL95raRrmt9r2fmIutFKPxJ4ImlxXd-QrEsrqaRqgXnc2JRr8ZplKt_YRmTVlyj9wMHw2PXKs"; //退款
            string purchaseToken = "pimgdcjdkjniiaoeijfnplei.AO-J1OwUKm0Lqbq9VBpQ1jyYPJFZD-l8wB2CvoPjXDm5lJ-15vnlp4vU4zvIqayPMHhFdXBXtTPpRQ05DGCK1GA1GSR3RGGkjT8GgPzpNPX6XhPHTUNKsqE"; //支付成功
            // 验证订单
            Google.Apis.AndroidPublisher.v3.Data.ProductPurchase response = await self.AndroidPublisherService.Purchases.Products.Get("com.goinggame.weijing", productId, purchaseToken).ExecuteAsync();

            if (response == null)
            {
                Console.WriteLine($"Google充值回调ERROR1 返回消息null");
                return;
            }

            // 检查订单是否有效
            if (response.PurchaseState == 0)
            {
                string prefix = "pay_";
                int rechargeNumber = int.Parse(productId.Substring(prefix.Length));
                string postReturnStr = JsonHelper.ToJson(response);
                Console.WriteLine($"Google充值成功 ProductId:{productId} PurchaseToken:{purchaseToken} RechargeNumber:{rechargeNumber} PostReturnStr:{postReturnStr}");
            }
            else
            {
                Console.WriteLine($"Google充值失败 ProductId:{productId} PurchaseToken:{purchaseToken}");
            }
        }
    }
}