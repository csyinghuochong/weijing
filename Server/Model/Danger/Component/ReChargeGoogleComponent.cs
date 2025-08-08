using System.Collections.Generic;
using Google.Apis.AndroidPublisher.v3;

namespace ET
{
    public class ReChargeGoogleComponent: Entity, IAwake
    {
        public AndroidPublisherService AndroidPublisherService;
        public List<string> PayLoadList = new List<string>();
    }

    // https://docs.unity3d.com/2022.3/Documentation/Manual/UnityIAPPurchaseReceipts.html
    // {"json":"{\"orderId\":\"GPA.3323-8102-8907-22463\",\"packageName\":\"com.goinggame.weijing\",\"productId\":\"pay_1\",\"purchaseTime\":1754620478148,\"purchaseState\":0,\"purchaseToken\":\"pefpdbngkpancdmlnojjlkah.AO-J1OzeiNoNuwuhqLDhAGDYjaZogeUMAgLtZ8pLDfDrM0wVVcoonfaFv_BSlnYsC31g5Lkrwh_uvc8sSXNW1NytSl-E7GaMSPckDncobLFFHhUMQmhzRpQ\",\"quantity\":1,\"acknowledged\":false}","signature":"UV3Jo20TumY6pe0BVi5OY4l9niFdiVsB3sPcSaRPG5UrAjoqZDoHXTbtWmOM2JJhNEvn2hUqUk9qBqYm6ObFMlcS8tJOe4I9LVatM9WZdeO/8iqr9EpVFLNTtl5DZuju9jMWeXQeAnfFwZeSlPMqklhc48DCxvn/WY0Zu3SN4zq0Zb99Gclq65l4QNNY8IT/SgPZnwDp1EPhgahgyKdEnZL1w6BnbpOIa/b9fMI/4eYcVac3L+LyT4x7GLocfNbat+kYmtOFmWyGZLUqPbZR9xvE5l5vCpStX8rDnCw17IrCp8A8Mq+Aoj62c7vnXMg46846v9YBHqHNi3eE1I7hLw==","skuDetails":["{\"productId\":\"pay_1\",\"type\":\"inapp\",\"title\":\"600\\u94bb\\u77f3 (\\u5371\\u5883)\",\"name\":\"600\\u94bb\\u77f3\",\"description\":\"\\u53ef\\u4ee5\\u83b7\\u5f97600\\u94bb\\u77f3\",\"price\":\"JP\\u00a5147\",\"price_amount_micros\":147000000,\"price_currency_code\":\"JPY\"}"]}
    public class Payload_Google
    {
        public string json;
        public string signature;
    }

    public class Payload_Google_json
    {
        public string productId;
        public int purchaseState;
        public string purchaseToken;
    }
}