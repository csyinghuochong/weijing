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

    public class GoogleVerifyPayResult
    {
        public GoogleVerifyPayResult(Google.Apis.AndroidPublisher.v3.Data.ProductPurchase purchase)
        {
            this.AcknowledgementState = purchase.AcknowledgementState;
            this.ConsumptionState = purchase.ConsumptionState;
            this.DeveloperPayload = purchase.DeveloperPayload;
            this.Kind = purchase.Kind;
            this.ObfuscatedExternalProfileId = purchase.ObfuscatedExternalProfileId;
            this.ObfuscatedExternalAccountId = purchase.ObfuscatedExternalAccountId;
            this.OrderId = purchase.OrderId;
            this.ProductId = purchase.ProductId;
            this.PurchaseTimeMillis = purchase.PurchaseTimeMillis;
            this.PurchaseToken = purchase.PurchaseToken;
            this.PurchaseState = purchase.PurchaseState;
            this.PurchaseType = purchase.PurchaseType;
            this.Quantity = purchase.Quantity;
            this.RefundableQuantity = purchase.RefundableQuantity;
            this.ETag = purchase.ETag;
        }

        /// <summary>
        /// 内购产品的确认状态,(1-被确认)
        /// </summary>
        public int? AcknowledgementState { get; set; }

        /// <summary>
        /// 产品的消费状态(0-未消费，1-已消费)
        /// </summary>
        public int? ConsumptionState { get; set; }

        /// <summary>
        /// 开发人员指定的字符串
        /// </summary>
        public string DeveloperPayload { get; set; }

        /// <summary>
        /// 这种表示androidpublisher服务中的inappPurchase对象。
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// 与用户帐户唯一关联的id的模糊版本
        /// </summary>
        public string ObfuscatedExternalAccountId { get; set; }

        /// <summary>
        /// 用户配置文件唯一关联的id的模糊版本
        /// </summary>
        public string ObfuscatedExternalProfileId { get; set; }

        /// <summary>
        /// 与购买inapp产品相关联的订单id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        ///  内购产品标识
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 订单的购买状态。可能的值为：0。购买1。取消
        /// </summary>
        public int? PurchaseState { get; set; }

        /// <summary>
        /// 自纪元（1970年1月1日）以来，购买产品的时间（以毫秒为单位）
        /// </summary>
        public long? PurchaseTimeMillis { get; set; }

        /// <summary>
        /// 标识此购买而生成的购买令牌
        /// </summary>
        public string PurchaseToken { get; set; }

        /// <summary>
        /// 不是使用标准的应用内计费流制作的。可能的值为：0。
        /// 测试（即从许可证测试帐户购买）
        /// 1。促销（即购买使用促销代码）
        /// 2。奖励（即观看视频广告而非付费）
        /// </summary>
        public int? PurchaseType { get; set; }

        /// <summary>
        /// 相关联的数量
        /// </summary>
        public int? Quantity { get; set; }

        /// <summary>
        /// 退款数量
        /// </summary>
        public int? RefundableQuantity { get; set; }

        public string RegionCode { get; set; }

        /// <summary>
        /// The ETag of the item.
        /// </summary>
        public string ETag { get; set; }
    }
}