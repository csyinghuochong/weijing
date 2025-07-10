using System;
using UnityEngine;
using System.Collections;

namespace cn.sharesdk.unity3d {
	[Serializable]
	public class DevInfoSet {

		public SinaWeiboDevInfo sinaweibo;
		public QQ qq;
		public QZone qzone;
		public WeChat wechat;
		public WeChatMoments wechatMoments;
		public WeChatFavorites wechatFavorites;
	}

	[Serializable]
	public class DevInfo {
		public bool Enable = true;

	}

	[Serializable]
	public class SinaWeiboDevInfo : DevInfo {

#if UNITY_ANDROID
        public const int type = (int)PlatformType.SinaWeibo;
        public string SortId = "4";
        public string AppKey = "568898243";
        public string AppSecret = "38a4f8204cc784f81f9f0daaf31e02e3";
        public string RedirectUrl = "http://www.sharesdk.cn";
        public bool ShareByAppClient = true;
#endif


#if UNITY_IPHONE || UNITY_IOS
		public int type = (int)PlatformType.SinaWeibo;
		public string app_key = "4243223096";
		public string app_secret = "a94b60256e1652fdcb379984db56a158";
		public string redirect_uri = "https://www.mob.com/";
		public string app_universalLink = "https://70imc.share2dlink.com/";
#endif

    }


    [Serializable]
	public class QQ : DevInfo {


#if UNITY_ANDROID
        public const int type = (int)PlatformType.QQ;
        public string SortId = "2";
        public string AppId = "1105893765";
        public string AppKey = "8DpWsEXj40TfCKzz";
        public bool ShareByAppClient = true;
#endif

#if UNITY_IPHONE || UNITY_IOS
		public int type = (int)PlatformType.QQ;
		public string app_id = "101883752";
		public string app_key = "ab9d332ee43d3259991047c7796767dd";
#endif

    }

    [Serializable]
	public class QZone : DevInfo {

#if UNITY_ANDROID
        public const int type = (int)PlatformType.QZone;
        public string SortId = "1";
        public string AppId = "1105893765";
        public string AppKey = "8DpWsEXj40TfCKzz";
        public bool ShareByAppClient = true;
#endif


#if UNITY_IPHONE || UNITY_IOS
		public int type = (int)PlatformType.QZone;
		public string app_id = "101883752";
		public string app_key = "ab9d332ee43d3259991047c7796767dd";
#endif


    }

    [Serializable]
	public class WeChat : DevInfo {

#if UNITY_ANDROID
        public const int type = (int)PlatformType.WeChat;
        public string SortId = "5";
        public string AppId = "wx638f7f0efe37a825";
        public string AppSecret = "c45e594ab681035a1cae6ab166f64a20";
        public string UserName = "gh_afb25ac019c9@app";
        public string Path = "/page/API/pages/share/share";
        public bool BypassApproval = false;
        public bool WithShareTicket = true;
        public string MiniprogramType = "0";
#endif


#if UNITY_IPHONE || UNITY_IOS
		public int type = (int)PlatformType.WeChat;
		public string app_id = "wx638f7f0efe37a825";
		public string app_secret = "c45e594ab681035a1cae6ab166f64a20";
		public string app_universalLink = "https://c4ovz.share2dlink.com/";
#endif


    }

    [Serializable]
	public class WeChatMoments : DevInfo {

#if UNITY_ANDROID
        public const int type = (int)PlatformType.WeChatMoments;
        public string SortId = "6";
        public string AppId = "wx638f7f0efe37a825";
        public string AppSecret = "c45e594ab681035a1cae6ab166f64a20";
        public bool BypassApproval = true;
#endif


#if UNITY_IPHONE || UNITY_IOS
		public int type = (int)PlatformType.WeChatMoments;
		public string app_id = "wx638f7f0efe37a825";
		public string app_secret = "c45e594ab681035a1cae6ab166f64a20";
		public string app_universalLink = "https://c4ovz.share2dlink.com/";
#endif

    }

    [Serializable]
	public class WeChatFavorites : DevInfo {

#if UNITY_ANDROID
        public const int type = (int)PlatformType.WeChatFavorites;
        public string SortId = "7";
        public string AppId = "wx638f7f0efe37a825";
        public string AppSecret = "c45e594ab681035a1cae6ab166f64a20";
#endif

#if UNITY_IPHONE || UNITY_IOS
		public int type = (int)PlatformType.WeChatFavorites;
		public string app_id = "wx638f7f0efe37a825";
		public string app_secret = "c45e594ab681035a1cae6ab166f64a20";
		public string app_universalLink = "https://c4ovz.share2dlink.com/";
#endif


    }

    [Serializable]
	public class RestoreSceneConfigure {

#if UNITY_IPHONE || UNITY_IOS
		public string capabilititesAssociatedDomain = "applinks:ahmn.t4m.cn";
		public string capabilititesEntitlementsPathInXcode = "Unity-iPhone/Base.entitlements";
#endif
		public bool Enable = false;

	}

	public class RestoreSceneInfo {
		public string path;
		public Hashtable customParams;
		public RestoreSceneInfo(string scenePath, Hashtable sceneCustomParams) {

		}


	}
}