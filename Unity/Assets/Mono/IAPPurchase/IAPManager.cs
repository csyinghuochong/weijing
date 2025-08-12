using System;
using UnityEngine;
using UnityEngine.Purchasing;

#if UNITY_2022_1_OR_NEWER 
using Unity.Services.Core;
using Unity.Services.Core.Environments;
#endif

public class IAPManager : MonoBehaviour, IStoreListener
{
    private string k_Environment = "production";
    
    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;

    // 产品ID（与Google Play Console中一致）
    private string kProductIDConsumable = "com.goinggame.weijing";
    private string kProductIDNonConsumable = "com.yourcompany.yourgame.nonconsumable";
    private string kProductIDSubscription = "com.yourcompany.yourgame.subscription";

    public Action<string> SuccessedCallback;
    public Action FailedCallback;

    void Awake()
    {
#if UNITY_2022_1_OR_NEWER 
        if (UnityServices.State == ServicesInitializationState.Uninitialized)
        {
            InitializeGamingServices();
        }
#endif
    }

    void Start()
    {
    }

    void InitializeGamingServices()
    {
        try
        {

#if UNITY_2022_1_OR_NEWER
            var options = new InitializationOptions().SetEnvironmentName(k_Environment);

            UnityServices.InitializeAsync(options).ContinueWith(task =>
            {
                Debug.Log("Congratulations!\nUnity Gaming Services has been successfully initialized.");
            });
#endif
        }
        catch (Exception exception)
        {
            Debug.LogError($"Unity Gaming Services failed to initialize with error: {exception.Message}.");
        }
    }
    
    public void InitializePurchasing(string productlst)
    {
        if (m_StoreController != null)
        {
            return;
        }

        Debug.Log("InitProductInitProduct wj");
        
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        // 添加产品到配置中
        //builder.AddProduct(kProductIDConsumable, ProductType.Consumable);
        //builder.AddProduct(kProductIDNonConsumable, ProductType.NonConsumable);
        //builder.AddProduct(kProductIDSubscription, ProductType.Subscription);
        string[] productList = productlst.Split('@');
        for (int i = 0; i < productList.Length; i++)
        {
            builder.AddProduct(productList[i], ProductType.Consumable);
        }
        UnityPurchasing.Initialize(this, builder);
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
        Debug.Log("IAP初始化成功");
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("IAP初始化失败: " + error);
    }

    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        Debug.Log("IAP初始化失败: " + error + "  message" + message );
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {

        Debug.Log($"ProcessPurchase: {args.ToString()}");
        Debug.Log($"ProcessPurchase: {args.purchasedProduct.receipt}");
        // 处理购买成功的逻辑
        if (string.Equals(args.purchasedProduct.definition.id, kProductIDConsumable, System.StringComparison.Ordinal))
        {
            Debug.Log("购买消耗品成功");
            this.SuccessedCallback?.Invoke(args.purchasedProduct.receipt);
            // 给予玩家消耗品
        }
        else if (string.Equals(args.purchasedProduct.definition.id, kProductIDNonConsumable, System.StringComparison.Ordinal))
        {
            Debug.Log("购买非消耗品成功");
            // 给予玩家非消耗品
        }
        else if (string.Equals(args.purchasedProduct.definition.id, kProductIDSubscription, System.StringComparison.Ordinal))
        {
            Debug.Log("购买订阅成功");
            // 处理订阅逻辑
        }
        else
        {
            Debug.Log("未知产品: " + args.purchasedProduct.definition.id);
        }

        return PurchaseProcessingResult.Complete;
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log($"购买失败 - 产品: {product.definition.id}, 原因: {failureReason}");
        this.FailedCallback?.Invoke();
    }

    // 购买产品的公共方法
    public void BuyConsumable()
    {
        BuyProductID(kProductIDConsumable);
    }

    public void BuyNonConsumable()
    {
        BuyProductID(kProductIDNonConsumable);
    }

    public void BuySubscription()
    {
        BuyProductID(kProductIDSubscription);
    }

    public void BuyProduct_WJ(string productId)
    {
        kProductIDConsumable = productId;
        BuyProductID(productId);
    }

    private void BuyProductID(string productId)
    {
        if (m_StoreController == null)
        {
            Debug.Log("IAP控制器未初始化，无法购买");
            return;
        }

        var product = m_StoreController.products.WithID(productId);

        if (product != null && product.availableToPurchase)
        {
            Debug.Log($"购买产品: {product.definition.id}");
            m_StoreController.InitiatePurchase(product);
        }
        else
        {
            Debug.Log("产品不可用或不存在: " + productId);
        }
    }
}