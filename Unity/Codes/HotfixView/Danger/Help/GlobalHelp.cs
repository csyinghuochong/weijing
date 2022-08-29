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
            get { return GameObject.Find("Global").GetComponent<Init>().BanHaoMode; }
        }

        public static bool IsOutNetMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().OueNetMode; }
        }

        public static CodeMode GetCodeMode
        {
            get { return GameObject.Find("Global").GetComponent<Init>().CodeMode; }
        }

        public static void FenXiang(string shareType)
        {
            GameObject.Find("Global").GetComponent<Init>().FenXiang(shareType);
        }

        public static void Authorize(string shareType)
        {
            GameObject.Find("Global").GetComponent<Init>().Authorize(shareType);
        }

        public static void GetUserInfo(string shareType)
        {
            GameObject.Find("Global").GetComponent<Init>().GetUserInfo(shareType);
        }

        public static void AliPay(string orderInfo)
        {
            GameObject.Find("Global").GetComponent<Init>().AliPay(orderInfo);
        }

        public static void WeChatPay(string orderInfo)
        {
            GameObject.Find("Global").GetComponent<Init>().WeChatPay(orderInfo);
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
        }

        public static int GetVersion()
        {
            int versioncode = libx.Versions.LoadVersion(Application.persistentDataPath + '/' + libx.Versions.Filename);
            return versioncode > 0 ? versioncode : 1;
        }
    }
}
