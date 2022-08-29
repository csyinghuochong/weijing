using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Request;
using System.Collections.Generic;
using System.Net;

namespace ET
{

    public class AliPayOrderInfo : Entity, IAwake
    {
        public string objID = "";
        public AlipayTradeAppPayModel alipayTradeAppPayModel = new AlipayTradeAppPayModel();
    }
    public static class AliPayOrderInfoSystem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="totalFee"></param>
        /// <param name="dingDanID"></param>
        public static void SetInfo(this AliPayOrderInfo self, string totalFee, string dingDanID)
        {
            self.alipayTradeAppPayModel.Body = "游戏赞助";              //物品名称
            self.alipayTradeAppPayModel.Subject = "危境游戏赞助";          //商品的标题/交易标题/订单标题/订单关键字等。
            self.alipayTradeAppPayModel.TotalAmount = totalFee;                            //价格 单位为元
            self.alipayTradeAppPayModel.ProductCode = "QUICK_MSECURITY_PAY";               //官方提供的固定值
            self.alipayTradeAppPayModel.OutTradeNo = dingDanID;             //唯一订单号
            self.alipayTradeAppPayModel.TimeoutExpress = "30m";             //付款超时时间
        }
    }

    public class ReChargeAliComponent : Entity, IAwake
    {

        //#region APP_Private_Key and AliPay_Public_Key
        /// <summary>
        /// 应用密钥
        /// </summary>
        //string APP_Private_Key = @"MIIEpAIBAAKCAQEAqx0Ebk9Io0ROSf6uYWSn2fJttz7PQP+HfrkDxaZX+MqlIRsnkWlBwmujw/U6XLJ1KtCs2o7f9bBwNMDJQZC+tktTDsE0e0NbcjqdL2xWld8hyoYuOIUZ8fSM5ama04MLf7B5F56Vu/95k7nYSwtGXWjrASyQu247+ga4KrEe1U5JsY9oS1QffqNLq2riBg6Cs0XdiO3g6geU3b//2/X/pZz7qzPKvflsEBdRbs1PqPare8l6uoRB+xKbgG1dUApmzwi2FDSe+PwuuMtqdDmGgyfofNcU691ButSbPHCPL8QVJZi+CimI4M7wBGQ2wE5Jp1NcO7KD35laDxDnQSvBHwIDAQABAoIBAEGRj/YZKXNupDVUg0vMv0kTzZkPV2nHwQr9KIXfdQxf0qD5/9KHq+wtRQa8/I0y0RUD+4iQgR9racO9MCGQrpO6D2yy+kJVkEAYV80pTZCGfTNW8XU1A7kkha0nra1pJMncPLqhSS1N+y9xYoF3I5J9trevdRJtbkwjsQSi9Ha1tZxFfmgBvsR+W2rD9ORpfqtrZVL/+DJFAiD8ZozRRXYh0+oAU1WXYNYy8LQDDN+nM+2VmDBdMuRUGiVyaSqnmcN4S8QCwYVWVmVO39dNSVWY11q7LJcKCYTZmLgQa01oY3oUbZ7n154k8oDcbPVemdqqGVyH7BgZX2LeRqUiNQECgYEA2gO8eRYV9WAAJcWqP0f+k/4i3m71FGPobsoIuNQr0iz5D2rQ7UlhgZ2Y72LqN2/Srx2g+KTnPigBnck3MHxh6wiBvzwTbF3pzD6SLHoNGRjNmPE+HNXlOaSxXWM6Qvf/KN2J6vua6P0DwkZehOi58TTR1ZRQi/51xWWYp7F2uYECgYEAyO1Phx93kZ273oSz2Igxj7YVhdH/8V9cvx5SiSAnsZ8Eeq7IsFFOE6z/ttxA3qQIhHgTeF66+4LUftjBD6F3M6m39C42SJKcv+C15u31vZ9WyLwqi5RbYDlq62ITBeRIveT0G/Xc24t3vrjinobWgHSq5IX0NDT1d/lNQVnvip8CgYEA10zTRz1RaCZrXuILFD10IxDZvJMVQxK7SxYIcQdPU1uIhvo04/EQ8yEBFH+50A+Fn9yByKuJlm+J0RoSf7aGOMcI4yNgByfjqQmt73CFGODOwZiUf4OYwUlsw04oDlS9Ts0h08awICEmIii+VUFDx/ois2qp9ObRxaRkkk8GcYECgYBoQFlHLtiHQWQ87HW0H9Y3Tq6UJIW741LoBv+kDn8J9gwI669NbKIqK1TyuA0gd9PDh9nyVpSF8zf2KNjjF1AWCjVcCK45sXiLRjibfVRH8ujAdoFMsslGgAQt5VEheXUUsjrGVyck8pRK7PsIbcXWGLKip64xeFj0yvF+uv9C2QKBgQCfjoNp+wygYJlQTo6YzhsnIvdzsqv3Nyq+kldBw4QXFWoK/P69Sh0aUZ+pwSdQ3HwzynSd3EotLlfZNRgNdjK1w9td1GosMoQYJu+LKoRSb0rmCdy1cKuyHCEIkrtOiVvumGE+nUSWrHRPopdRTQo7k3nvzWwQRKB8Pq9iK0aHZA==";
        //string APP_Private_Key = @"MIIEowIBAAKCAQEAu42PycMzMCarwykHWHuabyYZTCoj6is7XAsS1oYGgzooKMjkwlGaDR9iv385rhH4vbe1XXKTfPt6lJPvbWl0r3NV6AJqLgDXeG5khX/S6TGx//udu4KlKk3v+20m8mnxo7+u9TZbTPmbcr5UgrcFO9/6dxCole3lzKLkC+uDnNWi2NwWtKBv2rXQmyrvUIeFpPQdGZrCyKxVxYYh1x/svSa5BJhL06kZqwA9/LoU/XXHqBnJjHnOMm4dT0bN1Sa5gGm+QKDDM5aUoemNI6kd7bPo56hJnpypiH3XRVufPlvjdjTH6cwFcTAXS0vJGX1xaaCxyWBLV4JaqgX2irhbWwIDAQABAoIBACIO4eaUsO30h8pn3/Kcd33poDxphp4WfbAIPsKAEhywaeyGFqyG3v+1DFyUAOhwUQg6nQ+8J7ZRgIAMoTTwKoVV32rDTX7PHlG7Uju/64/3O0it64XKgq28+3Bf8Ouie4Pt4hqbZVcEGMtsbrJSA/xMfxIyDzsyuUFA70KO4RaQkW2tSD1LqbgleNxu3OTT88Ec5Al4yG+VvwGwcaJ9Wgjz6MKOykGl7qRC07/Zd3257Y/kwOrCIMx+DBfz57OlVuuj9Egmeelyj3a9FcmdcAuK3peJPI5GkcNIFW5AxLdd63z9r/ghJHKdgnK+aJ65++IBVf31+prfp7yNAFSKwqkCgYEA3CFVhzioc9ZQvVJ/uzz3KdQqPjOySgoWLhfizLJgK9efmrofeNsxZ+iPtihwsaMl8qhcOmDDBLgT2BucBm5zDHzueckmAr9sT860W2LmoS9sWH5UKC/9Rnkt9oLCiIZLd2hL2nqbDjpazOeUtJ2EQqF/qKSxJX+UA8BA3zLHbM0CgYEA2h1HJgEfZFO+eVrJa0efk2XotsXL3UGrX5jTz5sfjSKTn014vfdz1nPqQozHtrP1t5N4Ru0uYATHJTcb3lzkXTV/LyAxop60DCM810N0WIqBQNARYW/unEKeWwUw7yLfgnhy9o8RYBsmUgU4pzpfu61+dQj6mHTIOxLh9hN96McCgYEAsqzP6lkfyh5cHL+48/bRO/99Zk252oUDadhze+kRTKTRZNrMLuHj4U6QT6/VgSpG5AaqDax6vvrXCKOoakP+WFWTkACoPLS5qrHCDSdiwdRnYhDwKEqDj09O8ndChWRUHxDl+OlpsAvHpegW+N+d+iNyJiW/sAs0zjKftUtXOcUCgYB1A1YDLoD/2umJw0nhkugqNHb3bv/isHNW8u9XJjp0BgO6Z96J03JCr6cSkuIlwz/kf2n8awwBGS8ZaQo7bgxZcPTNfHEEdC3VgSYHujl1ssCK29UnN9yD2j2ISS2qbUQJg8LxQWmp7IbPY9uz414umnIIKYv/NE+jWYr98BERSwKBgGLUIl3Soxh6d3yfYbapjpLiC5XdsuaRw381hyjLLiRL1Jd/gUPvLUFGjI+JYcScp7dHyL6K90WgenAWpk7kixMZsytzV/pb+Om7jSKTQKdIdYCrb4Ldgk8o/BCoEiAP8CEvaIfKPyTnBUa2aug+HZYvudOjHzdG8aRl7hQtidl9";
        public string APP_Private_Key = @"MIIEpAIBAAKCAQEAzlzjA43vtMtNABlhfDutJvedTJQmbuefFmrgd9PSrF9pCvHJVRSZPx1/eVltDo37iT/reqVFoL81ez3at7VX233USxsTwcRWyltQXTbizbxD+KOnfbQ5SddgjrGC+by0EeFuM4lByN36/pJBIEplde+3JPeCEAJSN1ei5ezgaRMiMea2GQDsf5DC7kiD2Y3Cs79QHWuBBAw4dmTkoSznh8/yuQ/pYug8TsN/JJ1xFRCxChHuSOclRzVfSSF3dJPa4kFHPyZHnCb0QEfiC8lroiOV5DfnXdcEiVceybBVLpraySZcLkcWYgzy2D1kGzt1Ehplr7JvVmPwavIwPu5puwIDAQABAoIBAQDN2X5iZ017zWiL9sV1xZmdy1bPsuD7tHTPSeGL5nK6m5oO3s10301W1jf4dqoA4MTPTkG5X++qv9G7lCH/KxfuzP/dw67blNz2kkwCD+QCUhCDj8xd6k9TR1L8RDpgoEoHpBXntr02f6gGFSJ98XhwQqUwbO0Cxy34IqVOMhJQ/IftYT4T3xFlXf1Gk7d4tojLi48KDpxKmB/wTpLc3I+atbkLvqKaGvkoTdynubdENEqnsZWECvHJWjXAix9bxZVwxziXFMlrgqwdF3WP0xICYhk7KbTlls6C1q17jRE1r8HbBoL5NiZjCfdlJ0H3pcD7dnzI6G2MzmNYP6lrGUzBAoGBAPIZ0xOqQt3VFyUB5SNaxJ3GqlKmRvi/BvGesq/sf83/mmw1Q+LAHoSmB2MyCoHLo1Wh5M2B7MWorvsfqkRM63Ca0Tv8+PWRaJkwVugGVrBmxvQGfEDNhJ62JAIvfR6U8RY79nsM+K7EN7EwsDUOX757k9hRGi/APzvDU07/HxGRAoGBANo10Uj9BvOG3bKc6heySbrJ1lU7EN15vDgT6838PPYahMjqWT2m3Lhr8J43bCG9bzW4V5504fZXm4RtISTLrUQi8EkK+QJwEmKc9KOvh7qvkA7LZx0B+p4tNuKrT3277Hs6AN9ieoXv1MrtTKsadJi0ZfyDiGkbLvT9slfmIeCLAoGAYeqD7i4sgR/QDo2nqRbq8o0JEghiJ/TK0CpJRtG2FxDL2fvpCup87VVhI4N3sGs2Eko6CcwEgSTqMHLsIFej2ZUkDskPv/IhheOBIrJ9mTbYPJXq5yK4AqDUC3Y9eoLuxvlVhQsIAVcm1ylD+xFnM9kzQIf8uVddu8QSC58vZ6ECgYAfUxp4H9qfmvy4Z04zmKR86/yYv6HsKU2bv0BakZsuuR/Wt82XzBxjXRttmwcq0MbmL1BkruLBOlJY8FGRtqto3Jsh4TFd6Di7b0yvMsOJSSqk9Q4YW/BeRJ9cars+kXuhNPJrHvf3wjYJ64bWCTYztbHuTfOHIx/ai5DOjXrPgQKBgQDKjQV3pkawsSGpotPL2zqfkmPrYxKoh2Y0TXrzmcHfddnB0WDyWDC8yyFsCSTTDqK93lil69WcFuEHVYlZ4WPJDcOAyFlCG4pM7rfFW66O0IHz81mhAL+n4kyWAUjc8zjigyLhhJe0U43A2DaGT94zqO01EbewWfAeCyMxaG6UGQ==";
        /// <summary>
        /// 支付宝公钥
        /// </summary>
        //string AliPay_Public_Key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA37vnkTXPnA83r39o1TowQh8WChOgkbrR3ylQqWGm8eeFGn+wi1bhmNyO4MobIwgejgthVWTs/hXKr5YXUgTH3kEEZQpc+CP2YFroMyYKu5tl8my8Ki5LuPtnOnvEHNtMfXmm1TmqJzv5a+igjN3XY4x+CxKrK9hzzRplmpdoeJOtbQ1twYKk0wKRDitVY4ikbvKKy6mDaBh69pYfCpjAL9fDbewU7QjWKBg1YIFRlwOveUNSBdbflpiAr4DIS75xYrg8X/4i6u7p7M5Ma/tAV/Y0No3P++3roaiLaRzBkvmjQcL4akOlQ6klOCiKkcxYC/hEwNs1C+Gh8KuEKTFXXwIDAQAB";
        //string AliPay_Public_Key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAgecSzelIGGSqjNOWIgYlMdMuhmKNyE3+suUCGqyuDQzoT3w97pV6OOrhM20LtfE0QrOl8O6JFCThKjX8WSiZABcrl5Lx74yj5foZvs6Im5L4lvCwIZDrrIzOhO7eFMrq+/os6myw0EP1rqd4QGcagkPp32BZS43fxsDVlCEMsfG/9tNbEP1HKsyMuzswUDDPkCBjYwlOdsw552mUTZNlrTQe2+koZcZgDaLnerQhaWWPg5BhqdZPiJvnq0vNLcZIB7dWl/UHtK4wBTV4RYDH/zjuGWlt3MptIguynRk3Za+aeRfTbmxdBlzjr9I8iSZRWwbn2h92ouBXaKAvKxLEGQIDAQAB";
        public string AliPay_Public_Key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAgecSzelIGGSqjNOWIgYlMdMuhmKNyE3+suUCGqyuDQzoT3w97pV6OOrhM20LtfE0QrOl8O6JFCThKjX8WSiZABcrl5Lx74yj5foZvs6Im5L4lvCwIZDrrIzOhO7eFMrq+/os6myw0EP1rqd4QGcagkPp32BZS43fxsDVlCEMsfG/9tNbEP1HKsyMuzswUDDPkCBjYwlOdsw552mUTZNlrTQe2+koZcZgDaLnerQhaWWPg5BhqdZPiJvnq0vNLcZIB7dWl/UHtK4wBTV4RYDH/zjuGWlt3MptIguynRk3Za+aeRfTbmxdBlzjr9I8iSZRWwbn2h92ouBXaKAvKxLEGQIDAQAB";
        //#endregion

        public string appid = "2021001109632344";

        // <summary> 订单的集合 实际上 要持久化到数据库或者硬盘上 放在内存中会因为服务器重启而丢失已有的订单 </summary>
        //从服务器开启到现在存储的所有游戏内的订单号
        public Dictionary<string, string> OrderDic = new Dictionary<string,  string>();

        public string DingdanlastTime;
        public long DingdanXuHao;

        public HttpListener HttpListener;

        public IAopClient client;
        public AlipayTradeAppPayRequest request;

        public string HttpListenerUrl = @"http://172.17.94.24:20002/";
        public string AliPayResultListenerUrl = @"http://39.96.194.143:20002/";
        public string AliServerURL = @"https://openapi.alipay.com/gateway.do";
    }
}
