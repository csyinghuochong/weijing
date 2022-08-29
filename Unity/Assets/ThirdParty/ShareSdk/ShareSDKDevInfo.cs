using UnityEngine;
using System.Collections;
using System;

namespace cn.sharesdk.unity3d 
{
	[Serializable]
	public class DevInfoSet
	{
		public SinaWeiboDevInfo sinaweibo;
		public QQ qq;
		public QZone qzone;
		public WeChat wechat;
		public WeChatMoments wechatMoments; 
		public WeChatFavorites wechatFavorites;
    }

    [Serializable]
    public class DevInfo 
	{	
		public bool Enable = true;
	}

    [Serializable]
    public class SinaWeiboDevInfo : DevInfo 
	{
#if UNITY_ANDROID
		public const int type = (int)PlatformType.SinaWeibo;
		public string SortId = "4";
		public string AppKey = "4243223096";
		public string AppSecret = "a94b60256e1652fdcb379984db56a158";
		public string RedirectUrl = "http://www.sharesdk.cn";
		public bool ShareByAppClient = true;
#elif UNITY_IPHONE
		public const int type = (int) PlatformType.SinaWeibo;
		public string app_key = "568898243";
		public string app_secret = "38a4f8204cc784f81f9f0daaf31e02e3";
		public string redirect_uri = "http://www.sharesdk.cn";
		public string app_universalLink = "https://bj2ks.share2dlink.com/";
//		public string auth_type = "both";	//can pass "both","sso",or "web"  
#endif
	}

	[Serializable]
	public class QQ : DevInfo 
	{
#if UNITY_ANDROID
		public const int type = (int)PlatformType.QQ;
		public string SortId = "2";
		public string AppId = "101883752";
		public string AppKey = "ab9d332ee43d3259991047c7796767dd";
		public bool ShareByAppClient = true;

		//========================================================
		//when you test QQ miniprogram, you should use this params
		//At the same time, the package name and signature should 
		//correspond to the package name signature of the specific 
		//QQ sharing small program applied in the background of tencent
		//========================================================
		//public const int type = (int) PlatformType.QQ;
		//public string SortId = "2";
		//public string AppId = "222222";
		//public string AppKey = "aed9b0303e3ed1e27bae87c33761161d";
		//public bool ShareByAppClient = true;
		//========================================================
#elif UNITY_IPHONE
		public const int type = (int) PlatformType.QQ;
		public string app_id = "101883752";
		public string app_key = "ab9d332ee43d3259991047c7796767dd";
//		public string auth_type = "both";  //can pass "both","sso",or "web" 
#endif
	}

	[Serializable]
	public class QZone : DevInfo 
	{
#if UNITY_ANDROID
		public string SortId = "1";
		public const int type = (int)PlatformType.QZone;
		public string AppId = "101883752";
		public string AppKey = "ab9d332ee43d3259991047c7796767dd";
		public bool ShareByAppClient = true;
#elif UNITY_IPHONE
		public const int type = (int) PlatformType.QZone;
		public string app_id = "101883752";
		public string app_key = "ab9d332ee43d3259991047c7796767dd";
//		public string auth_type = "both";  //can pass "both","sso",or "web" 
#endif
	}



	[Serializable]
	public class WeChat : DevInfo 
	{
#if UNITY_ANDROID
		public string SortId = "5";
		public const int type = (int)PlatformType.WeChat;
		public string AppId = "wx0f24f5e538739f0d";
		public string AppSecret = "dd075324e0a4ab44bd49d972efcffedc";
		public string UserName = "gh_afb25ac019c9@app";
		public string Path = "/page/API/pages/share/share";
		public bool BypassApproval = false;
		public bool WithShareTicket = true;
		public string MiniprogramType = "0";
#elif UNITY_IPHONE
		public const int type = (int) PlatformType.WeChat;
		public string app_id = "wx0f24f5e538739f0d";
        public string app_secret = "dd075324e0a4ab44bd49d972efcffedc";
        public string app_universalLink = "https://c4ovz.share2dlink.com/";
#endif
	}

	[Serializable]
	public class WeChatMoments : DevInfo 
	{
#if UNITY_ANDROID
		public string SortId = "6";
		public const int type = (int)PlatformType.WeChatMoments;
		public string AppId = "wx0f24f5e538739f0d";
		public string AppSecret = "dd075324e0a4ab44bd49d972efcffedc";
		public bool BypassApproval = true;
#elif UNITY_IPHONE
		public const int type = (int) PlatformType.WeChatMoments;
		public string app_id = "wx0f24f5e538739f0d";
		public string app_secret = "dd075324e0a4ab44bd49d972efcffedc";
        public string app_universalLink = "https://c4ovz.share2dlink.com/";
#endif
	}

	[Serializable]
	public class WeChatFavorites : DevInfo 
	{
#if UNITY_ANDROID
		public string SortId = "7";
		public const int type = (int)PlatformType.WeChatFavorites;
		public string AppId = "wx0f24f5e538739f0d";
		public string AppSecret = "dd075324e0a4ab44bd49d972efcffedc";
#elif UNITY_IPHONE
		public const int type = (int) PlatformType.WeChatFavorites;
		public string app_id = "wx0f24f5e538739f0d";
		public string app_secret = "dd075324e0a4ab44bd49d972efcffedc";
        public string app_universalLink = "https://c4ovz.share2dlink.com/";
#endif
	}

	// 下列为闭环分享相关类
	[Serializable]
    public class RestoreSceneConfigure
    {
        public bool Enable = false;
#if UNITY_ANDROID

#elif UNITY_IPHONE
        public string capabilititesAssociatedDomain = "applinks:ahmn.t4m.cn";
        public string capabilititesEntitlementsPathInXcode = "Unity-iPhone/Base.entitlements";
#endif
    }

    public class RestoreSceneInfo
    {
        public string path;
        public Hashtable customParams;

        public RestoreSceneInfo(string scenePath, Hashtable sceneCustomParams)
        {
            try 
            {
                this.path = scenePath;
                this.customParams = sceneCustomParams;
            } catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e); 
            }
        }
    }


}
