using UnityEngine;
using UnityEngine.Purchasing;
using System;
using ET;

public class PurchasingManager : MonoBehaviour, IStoreListener
{
    public static readonly PurchasingManager Instance = new PurchasingManager();
    private IStoreController storeController;
    private static IExtensionProvider extensionProvider;
    private static IAppleExtensions appleExtension;
    //private static IGooglePlayStoreExtensions googleExtension;

    private Action<string> failedCallback;
    private Action<Product> successedCallback;

    private void Awake()
    {
        InitProduct();
    }

    //PurchasingManager()
    //{
    //    InitProduct();
    //}


    /// <summary>
    /// 初始化商品
    /// 建议在游戏初始化完成的时候就去初始化商品
    /// </summary>
    public void InitProduct()
    {
        if (IsInitialized()) return;

        ET.Log.ILog.Debug("InitProductInitProduct wj");
        var module = StandardPurchasingModule.Instance();
        ConfigurationBuilder builder = ConfigurationBuilder.Instance(module);

        builder.AddProduct("488SG", ProductType.Consumable);
        /*builder.AddProduct("6WJ", ProductType.Consumable);
        builder.AddProduct("30WJ", ProductType.Consumable);
        builder.AddProduct("50WJ", ProductType.Consumable);
        builder.AddProduct("98WJ", ProductType.Consumable);
        builder.AddProduct("198WJ", ProductType.Consumable);
        builder.AddProduct("298WJ", ProductType.Consumable);
        builder.AddProduct("488WJ", ProductType.Consumable);
        builder.AddProduct("648WJ", ProductType.Consumable);*/

        UnityPurchasing.Initialize(this, builder);
    }

    public void OnIOSPurchase(int rmb)
    {
        string product = $"{rmb}6WJ";

        Purchase(product, PurchaseSucess, PurchaseFail);
    }

    public void PurchaseSucess(Product product)
    {
        string payinfo = JsonHelper.ToJson(product);
        ET.Log.ILog.Debug("内购成功： " + payinfo);
    }
    public void PurchaseFail(string product)
    {
        ET.Log.ILog.Debug("内购失败： " + product.ToString());
    }

    /// <summary>
    /// 发起内购
    /// </summary>
    /// <param name="_productId">要购买的商品ID</param>
    /// <param name="_successedCallback">购买成功回调</param>
    /// <param name="_failedCallback">购买失败回调</param>
    public void Purchase(string _productId, Action<Product> _successedCallback, Action<string> _failedCallback)
    {
        _productId = "488SG";

        failedCallback = _failedCallback;
        successedCallback = _successedCallback;

        if (!IsInitialized())
        {
            OnFailedCallback("Not initialized.");
            return;
        }

        var product = storeController.products.WithID(_productId);
        if (product == null || !product.availableToPurchase)
        {
            OnFailedCallback("Either is not found or is not available for purchase");
            return;
        }

        Debug.Log($"Inicializando compra del producto {product.metadata.localizedTitle} en la tienda.");
        storeController.InitiatePurchase(product);
    }


    /// <summary>
    /// IOS恢复内购
    /// Google会在删除应用后，第一次安装是自动恢复
    /// </summary>
    /// <param name="restoreCallback">恢复回调</param>
    public void IosRestore(Action<bool> restoreCallback)
    {
        if (appleExtension != null)
        {
            appleExtension.RestoreTransactions(restoreCallback);
        }
        else
        {
            Debug.LogWarning("IAppleExtensions is null");
            restoreCallback(false);
        }
    }

    //======================================分割线=========================================


    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        storeController = controller;
        extensionProvider = extensions;
        appleExtension = extensions.GetExtension<IAppleExtensions>();
        //googleExtension = extensions.GetExtension<IGooglePlayStoreExtensions>();
        Debug.LogWarning("OnInitializedSucess");
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.LogWarning("OnInitializeFailed Reason:" + error);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.LogWarning("OnPurchaseFailedproduct:" + product.transactionID + "  failureReason:" + failureReason);
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
    {
        if (successedCallback != null)
        {
            successedCallback(purchaseEvent.purchasedProduct);
        }
        return PurchaseProcessingResult.Complete;
    }

    private bool IsInitialized()
    {
        return storeController != null && extensionProvider != null;
    }

    private void OnFailedCallback(string _reason)
    {
        if (failedCallback != null)
        {
            failedCallback(_reason);
        }
    }
}
