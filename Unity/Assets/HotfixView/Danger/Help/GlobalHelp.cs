using cn.sharesdk.unity3d;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class GlobalHelp
    {

        public static Dictionary<string, Shader> ShaderList = new Dictionary<string, Shader>();

        public static Shader Find(string path)
        { 
            Shader shader = null;
            ShaderList.TryGetValue(path, out shader);
            if (shader == null)
            {
                shader = Shader.Find(path);
                if (ShaderList.ContainsKey(path))
                {
                    ShaderList[path] = shader;  
                }
                else
                {
                    ShaderList.Add(path, shader);
                }
            }
            return shader;
        }

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

        public static int BigVersion = -1;
        public static int GetBigVersion()
        {
            if (BigVersion != -1)
            {
                return BigVersion;
            }

#if UNITY_IPHONE || UNITY_IOS
            BigVersion =  GameObject.Find("Global").GetComponent<Init>().BigVersionIOS;
            return BigVersion;
#else
            BigVersion =  GameObject.Find("Global").GetComponent<Init>().BigVersion;
            return BigVersion;
#endif
        }

        /// <summary>
        /// /0 默认 taptap1  QQ2 platform3 小说推广 platform4备用    ios20001
        /// </summary>
        /// <returns></returns>
        public static int GetPlatform()
        {
#if UNITY_IPHONE || UNITY_IOS
            return 20001;
#else
            if (GetBigVersion() < 15)
            {
                return 0;
            }
            return GameObject.Find("Global").GetComponent<Init>().Platform;
#endif
        }

        public static void OnButtonGetCode(string phone)
        {
            GameObject.Find("Global").GetComponent<SMSSDemo>().OnButtonGetCode(phone);
        }

        public static void OnButtonCommbitCode(Action<string> action, string phone, string code)
        {

#if UNITY_IPHONE || UNITY_IOS
        GameObject.Find("Global").GetComponent<SMSSDemo>().OnButtonCommbitCode(code);
#else
            EventType.SMSSVerify.Instance.Phone = phone;
            EventType.SMSSVerify.Instance.Code = code;
            EventType.SMSSVerify.Instance.Action = action;
            Game.EventSystem.PublishClass(EventType.SMSSVerify.Instance);
#endif

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
