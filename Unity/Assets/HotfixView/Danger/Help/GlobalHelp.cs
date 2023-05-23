using cn.sharesdk.unity3d;
using UnityEngine;

namespace ET
{
    public static class GlobalHelp
    {

        public static bool IsEditorMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().EditorMode; }
        }

        public static bool IsBanHaoMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().VersionMode == VersionMode.BanHao; }
        }

        public static bool IsOutNetMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().OueNetMode; }
        }

        public static VersionMode VersionMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().VersionMode; }
        }

        public static CodeMode GetCodeMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().CodeMode; }
        }

        public static void FenXiang(FenXiangContent fenXiangContent)
        {
            GameObject.Find("Global").GetComponent<Init>().FenXiang(fenXiangContent);
        }

        public static void SSDKOperate(string shareType)
        {
            ShareSDK ssdk = GameObject.Find("Global").GetComponent<Init>().ssdk;
        }

        public static void PemoveAccount(string shareType)
        {
            GameObject.Find("Global").GetComponent<Init>().PemoveAccount(shareType);
        }

        public static void AliPay(string orderInfo)
        {
            GameObject.Find("Global").GetComponent<Init>().AliPay(orderInfo);
        }

        public static void WeChatPay(string orderInfo)
        {
            GameObject.Find("Global").GetComponent<Init>().WeChatPay(orderInfo);
        }

        public static int GetBigVersion()
        {
#if UNITY_IPHONE || UNITY_IOS
            return GameObject.Find("Global").GetComponent<Init>().BigVersionIOS;
#else
            return GameObject.Find("Global").GetComponent<Init>().BigVersion;
#endif
        }

        public static void OnButtonGetCode(string phone)
        {
            GameObject.Find("Global").GetComponent<SMSSDemo>().OnButtonGetCode(phone);
        }

        public static void OnButtonCommbitCode(string code)
        {
            GameObject.Find("Global").GetComponent<SMSSDemo>().OnButtonCommbitCode(code);
        }

        public static void OnButtonGetPhoneNum( )
        {
            GameObject.Find("Global").GetComponent<Init>().OnGetPhoneNum();
            //GameObject.Find("Global").GetComponent<Init>().OnGetPhoneNum_2();
            //GameObject.Find("Global").GetComponent<Init>().OnGetPhoneNum_3();
        }

        public static void OnIOSPurchase(int rmb)
        {
            string product =  $"{rmb}WJ";
            GameObject.Find("Global").GetComponent<PurchasingManager>().OnIOSPurchase(product);
        }

        public static void InitIOSPurchase( )
        {
            //builder.AddProduct("6WJ", ProductType.Consumable);
            //builder.AddProduct("30WJ", ProductType.Consumable);
            //builder.AddProduct("50WJ", ProductType.Consumable);
            //builder.AddProduct("98WJ", ProductType.Consumable);
            //builder.AddProduct("198WJ", ProductType.Consumable);
            //builder.AddProduct("298WJ", ProductType.Consumable);
            //builder.AddProduct("488WJ", ProductType.Consumable);
            //builder.AddProduct("488SG", ProductType.Consumable);
            //builder.AddProduct("648WJ", ProductType.Consumable);
            string products = "6WJ_30WJ_50WJ_98WJ_198WJ_298WJ_488WJ_488SG_648WJ";
            GameObject.Find("Global").GetComponent<PurchasingManager>().InitProduct(products);
        }

        public static int GetVersion()
        {
            int versioncode = libx.Versions.LoadVersion(Application.persistentDataPath + '/' + libx.Versions.Filename);
            return versioncode > 0 ? versioncode : 1;
        }
    }
}
