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
    public class Payload_Google
    {
        public string json;
        public string signature;
    }

    public class Payload_Google_json
    {
        public string productId;
        public string purchaseToken;
    }
}