using System;
using System.Threading;
using UnityEngine;
using cn.sharesdk.unity3d;
using System.Collections;
using System.Runtime.InteropServices;

namespace ET
{
	public struct FenXiangContent
	{
		public string FenXiang_Title;          //分享标题
		public string FenXiang_Text;           //分享文本
		public string FenXiang_ImageUrl;       //分享图片路径
		public string FenXiang_ClickUrl;       //分享点击链接
		public int Fenxiangtype; 
	}

	// 1 mono模式 2 ILRuntime模式 3 mono热重载模式
	public enum CodeMode
	{
		Mono = 1,
		ILRuntime = 2,
		Reload = 3,
		HuaTuo = 4,
	}

	public class Init : MonoBehaviour
	{

		public bool Development;
		public bool EditorMode;
		public bool OueNetMode;
		public int BigVersion = 11;
		public int BigVersionIOS = 11;
		public GameObject Updater;
		public Action<int, bool> OnShareHandler;
		public Action<string> OnAuthorizeHandler;
		public Action<string> OnGetUserInfoHandler;
		public Action<string> OnGetPhoneNumHandler;
		public Action<bool> OnApplicationFocusHandler;
		public Action OnApplicationQuitHandler;

		public Action<int> OnGetKeyHandler;
		public Action OnGetMouseButtonDown_1;
		public Action OnGetMouseButtonDown_0;

		public ShareSDK ssdk;
		public MobSDK mobsdk;

		public string WXAppID = "wx638f7f0efe37a825";           //俄罗斯消除
		public string WXAppSecret = "c45e594ab681035a1cae6ab166f64a20"; 

		public string QQAppID = "101883752";
		//apk sign 1  b119680ac96937de65f5c989ce485fb3   user_weijing2.keystore	//圣光
		//apk sign 2  3a0a616cdbf889b3565ba81fca3bed49   user.keystore			//危境

		public AndroidJavaClass jc;
		public AndroidJavaObject jo;

		//是java里的类，一些静态方法可以直接通过这个调用。
		//androidjavaobject 调用的话，会生成一个对象，就和java里new一个对象一样，可以通过对象去调用里面的方法以及属性。
		public AndroidJavaClass javaClass;
		public AndroidJavaObject javaActive;

		//"com.mafeng.alinewsdk.AliSDKActivity"是2018.11.01日更新的版本 对应安卓工程中的alinewsdk Module
		//而"com.mafeng.aliopensdk.AliSDKActivity"是之前的版本 对应安卓工程中的aliopensdk Module
		public string javaClassStr = "com.example.alinewsdk.AliSDKActivity";  //"com.mafeng.aliopensdk.AliSDKActivity";
		public string javaActiveStr = "currentActivity";

		public CodeMode CodeMode = CodeMode.Mono;
		public VersionMode VersionMode = VersionMode.Alpha;

#if UNITY_IPHONE && !UNITY_EDITOR
     [DllImport("__Internal")]
     private static extern void CheckIphoneYueyu( string str );
#endif

		private void Awake()
		{
			//#if ENABLE_IL2CPP
			//			this.CodeMode = CodeMode.ILRuntime;
			//#endif
			Updater.SetActive(true);

			System.AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
			{
				Log.Error(e.ExceptionObject.ToString());
			};

			SynchronizationContext.SetSynchronizationContext(ThreadSynchronizationContext.Instance);

			DontDestroyOnLoad(gameObject);

			LitJson.UnityTypeBindings.Register();

			ETTask.ExceptionHandler -= Log.Error;
			ETTask.ExceptionHandler += Log.Error;
			Application.logMessageReceived -= OnLogMessageReceived;
			Application.logMessageReceived += OnLogMessageReceived;

			Log.ILog = new UnityLogger();

			Options.Instance = new Options();

			CodeLoader.Instance.CodeMode = this.CodeMode;
			Options.Instance.Develop =  OueNetMode ? 0 : 1;
			Options.Instance.LogLevel = OueNetMode ? 6 : 1;

#if UNITY_ANDROID && !UNITY_EDITOR
		jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("CallNative", "weijing" );
		jo.Call("WechatInit", WXAppID);
#endif

			GameObject sharesdk = GameObject.Find("Global");
			ssdk = sharesdk.GetComponent<ShareSDK>();
			ssdk.authHandler = OnAuthResultHandler;
			ssdk.shareHandler = OnShareResultHandler;
			ssdk.showUserHandler = OnGetUserInfoResultHandler;
			ssdk.getFriendsHandler = OnGetFriendsResultHandler;
			ssdk.followFriendHandler = OnFollowFriendResultHandler;
			mobsdk = gameObject.GetComponent<MobSDK>();

			///////需要在用户点击的时候调用
			SetIsPermissionGranted();
		}

		public void OnLogMessageReceived(string condition, string stackTrace, LogType type)
		{
			if (type == LogType.Error || type == LogType.Assert
					|| type == LogType.Exception)
			{
				UnityEngine.Debug.LogError(stackTrace);
			}
		}

		public void SetIsPermissionGranted()
		{

#if UNITY_ANDROID && !UNITY_EDITOR
			//传入的第一个参数为Boolean类型的，true 代表同意授权、false代表不同意授权
			//该接口必须接入，否则可能造成无法使用MobTech各SDK提供的相关服务。
			mobsdk.submitPolicyGrantResult(true);
			jo.Call("SetIsPermissionGranted", QQAppID);
#endif
		}

		public void OpenBuglyAgent(long userId)
		{
#if UNITY_ANDROID
			Log.ILog.Info("OpenBuglyAgent: " + userId);
			// 开启SDK的日志打印，发布版本请务必关闭
			BuglyAgent.ConfigDebugMode(false);
			// 注册日志回调，替换使用 'Application.RegisterLogCallback(Application.LogCallback)'注册日志回调的方式
			// BuglyAgent.RegisterLogCallback (CallbackDelegate.Instance.OnApplicationLogCallbackHandler);
			BuglyAgent.ConfigDefault(null, Application.version, userId.ToString(), 0);
#if UNITY_IPHONE || UNITY_IOS
			BuglyAgent.InitWithAppId (BuglyInit.BuglyAppID);
#elif UNITY_ANDROID
			BuglyAgent.InitWithAppId(BuglyInit.BuglyAppID);
#endif
			// 如果你确认已在对应的iOS工程或Android工程中初始化SDK，那么在脚本中只需启动C#异常捕获上报功能即可
			BuglyAgent.EnableExceptionHandler();

#endif
		}

		private void Start()
		{
			CodeLoader.Instance.Start();
		}

		private void Update()
		{
			CodeLoader.Instance.Update();

			this.CheckMouseInput();
		}

		private void CheckMouseInput()
		{
			if (InputHelper.GetKey(257))
			{
				this.OnGetKeyHandler?.Invoke(257);
			}
			if (InputHelper.GetKey(119))
			{
				this.OnGetKeyHandler?.Invoke(119);
			}
			if (InputHelper.GetKey(97))
			{
				this.OnGetKeyHandler?.Invoke(97);
			}
			if (InputHelper.GetKey(115))
			{
				this.OnGetKeyHandler?.Invoke(115);
			}
			if (InputHelper.GetKey(100))
			{
				this.OnGetKeyHandler?.Invoke(100);
			}
			if (InputHelper.GetMouseButtonDown(1))
			{
				this.OnGetMouseButtonDown_1?.Invoke();
				return;
			}
			if (InputHelper.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
			{
				this.OnGetMouseButtonDown_0?.Invoke();
				return;
			}
		}

		private void LateUpdate()
		{
			CodeLoader.Instance.LateUpdate();
		}

		private void OnApplicationQuit()
		{
			OnApplicationQuitHandler?.Invoke();
			CodeLoader.Instance.OnApplicationQuit();
			CodeLoader.Instance.Dispose();
		}

		/// 当程序获得或者是去焦点时
		/// </summary>
		/// <param name="focus"></param>
		private void OnApplicationFocus(bool hasFocus)
		{
			try
			{
				OnApplicationFocusHandler?.Invoke(hasFocus);
			}
			catch (System.Exception)
			{

				throw;
			}
		}

		public void Authorize(string fenxiangtype)
		{
			switch (fenxiangtype)
			{
				case "1":
					ssdk.Authorize(PlatformType.WeChat);
					break;
				case "2":
					ssdk.Authorize(PlatformType.QQ);
					break;
			}
		}

		public void GetUserInfo(string fenxiangtype)
		{
			Log.ILog.Debug($"sharesdk GetUserInfo1");
#if !UNITY_EDITOR
			Log.ILog.Debug($"sharesdk GetUserInfo2");

			switch (fenxiangtype)
			{
				case "1":
					ssdk.GetUserInfo(PlatformType.WeChat);
					break;
				case "2":
					ssdk.GetUserInfo(PlatformType.QQ);
					break;
			}
#else
			string add = fenxiangtype == "1" ? "wx" : "qq";
			this.OnGetUserInfoHandler($"{add}{PhoneNumberHelper.getRandomTel()}");
#endif
		}

		public void OnNativeToUnit(string msg)
		{
			string[] msginfo = msg.Split('_');
			switch (msginfo[0])
			{
				case "QQLogin":
					string openid = msginfo[1];
					if (string.IsNullOrEmpty(openid))
					{
						return;
					}
					Log.ILog.Debug($"QQLogin:  {openid}");
					this.OnGetUserInfoHandler($"qq{openid}");
					break;
			}
		}

		void OnGetUserInfoResultHandler(int reqID, ResponseState state, PlatformType type, Hashtable result)
		{
			print("get user info result:" );
			print( MiniJSON.jsonEncode(result));
			print("get user info sucess ! platform :" + type);
			if (type == PlatformType.WeChat)
			{
				print("WXAuthInfo:   " + MiniJSON.jsonEncode(ssdk.GetAuthInfo(type)));
				if (state == ResponseState.Success)
				{
					this.OnGetUserInfoHandler("wx"+result["openid"].ToString());
				}
				else
				{
					this.OnGetUserInfoHandler("fail");
				}
			}
			if (type == PlatformType.QQ)
			{
				print("QQAuthInfo:   " + MiniJSON.jsonEncode(ssdk.GetAuthInfo(type)));
				if (state == ResponseState.Success)
				{
					result = ssdk.GetAuthInfo(type);
#if UNITY_ANDROID
					string openId = result["unionID"].ToString();
#elif UNITY_IPHONE
					string openId = result["uid"].ToString();
#endif
					Log.ILog.Debug($"openId: {openId}");
					this.OnGetUserInfoHandler("qq"+openId);
				}
				else
				{
					this.OnGetUserInfoHandler("fail");
				}
			}
		}

		void OnAuthResultHandler(int reqID, ResponseState state, PlatformType type, Hashtable result)
		{
			Log.ILog.Debug("OnAuthResultHandler:" + MiniJSON.jsonEncode(result));
			if (state == ResponseState.Success)
			{
				this.OnAuthorizeHandler("sucess_" + result["openid"].ToString());
			}
			else
			{
				this.OnAuthorizeHandler("fail");
			}
		}

		public void FenXiang(FenXiangContent fenxiangConent)
		{
			//auth和getuser接口都可以实现授权登录功能，可以任意调用一个
			//授权（每次都会跳转到第三方平台进行授权）进行授权
			//ssdk.Authorize(PlatformType.WeChat);
			//ssdk.GetUserInfo(PlatformType.WeChat);
			//设置分享
			ShareContent content = new ShareContent();
			//title标题，印象笔记、邮箱、信息、微信、人人网、QQ和QQ空间使用
			content.SetTitle(fenxiangConent.FenXiang_Title);
			//分享文本
			content.SetText(fenxiangConent.FenXiang_Text);
			//分享网络图片，新浪微博分享网络图片需要通过审核后申请高级写入接口，否则请注释掉测试新浪微博
			content.SetImageUrl(fenxiangConent.FenXiang_ImageUrl);
			// titleUrl是标题的网络链接，仅在Linked-in,QQ和QQ空间使用
			content.SetTitleUrl(fenxiangConent.FenXiang_ClickUrl);
			// imagePath是图片的本地路径，Linked-In以外的平台都支持此参数
			//content.SetImagePath("/sdcard/test.jpg");//确保SDcard下面存在此张图片
			// url仅在微信（包括好友和朋友圈）中使用
			content.SetUrl(fenxiangConent.FenXiang_ClickUrl);
			// site是分享此内容的网站名称，仅在QQ空间使用
			content.SetSite(fenxiangConent.FenXiang_Title);
			// siteUrl是分享此内容的网站地址，仅在QQ空间使用
			content.SetSiteUrl(fenxiangConent.FenXiang_ClickUrl);
			//设置分享类型
			content.SetShareType(ContentType.Webpage);
			//content.SetShareType(ContentType.Text);

			FenXiangShareContent(content, fenxiangConent.Fenxiangtype);
		}

		public void FenXiangShareContent(ShareContent content, int fenxiangtype)
		{
			switch (fenxiangtype)
			{
				//微信朋友圈
				case 1:
					//弹出菜单
					ssdk.ShareContent(PlatformType.WeChatMoments, content);
					break;
				//QQ空间
				case 2:
					//弹出菜单
					ssdk.ShareContent(PlatformType.QZone, content);
					break;
				//新浪微博
				case 3:
					//弹出菜单
					ssdk.ShareContent(PlatformType.SinaWeibo, content);
					break;
				//微信好友
				case 4:
					//弹出菜单
					ssdk.ShareContent(PlatformType.WeChat, content);
					break;
				//QQ好友
				case 5:
					//弹出菜单
					ssdk.ShareContent(PlatformType.QQ, content);
					break;
			}
		}

		void OnShareResultHandler(int reqID, ResponseState state, PlatformType type, Hashtable result)
		{
			//Game_PublicClassVar.Get_function_UI.GameGirdHint_Front("进入微信用户回调！" + state);
			Debug.Log("进入微信用户回调1！" + state);
			Log.ILog.Debug("进入微信用户回调2: " + MiniJSON.jsonEncode(result));
			string showText = "进入微信用户回调！";

			if (state == ResponseState.Success)
			{
				showText = "分享成功1！";
				this.OnShareHandler((int)type, true);
			}
			else if (state == ResponseState.Fail)
			{
				showText = "分享失败！";
#if UNITY_ANDROID
				Log.ILog.Debug("fail! throwable stack = " + result["stack"] + "; error msg = " + result["msg"]);
#elif UNITY_IPHONE
				Log.ILog.Debug("fail! error code = " + result["error_code"] + "; error msg = " + result["error_msg"]);
#endif
				this.OnShareHandler((int)type, false);
			}
			else if (state == ResponseState.Cancel)
			{
				showText = "进入指定用户回调取消！";
				Log.ILog.Debug("cancel !");
				this.OnShareHandler((int)type, false);
			}
			Log.ILog.Debug(showText);
		}

		void OnGetFriendsResultHandler(int reqID, ResponseState state, PlatformType type, Hashtable result)
		{
			Log.ILog.Debug("OnGetFriendsResultHandler");
		}

		void OnFollowFriendResultHandler(int reqID, ResponseState state, PlatformType type, Hashtable result)
		{
			Log.ILog.Debug("OnFollowFriendResultHandler");
		}

		/// <summary>
		/// 支付宝支付
		/// </summary>
		public void AliPay(string OrderInfo)
		{
			Log.ILog.Debug("AliPay: " + OrderInfo);
#if UNITY_ANDROID && !UNITY_EDITOR
			if (javaActive == null)
			{
				javaActive = new AndroidJavaObject(javaClassStr);
			}

			object[] objs = new object[] { OrderInfo, "Global", "AliPayCallback" };
			javaActive.Call("AliPay", objs);
#endif
		}

		/// <summary>支付宝支付回调</summary>
		//这里是同步调用,由SDK反馈支付结果
		public void AliPayCallback(string result)
		{
			Log.ILog.Debug("支付宝支付结果来了：" + result);
			//aliPayCallBack(result);
			//告诉服务器已经支付 等待返回结果
			//再监听结果 进行发放奖励 实际上都是独立的
			if (result == "支付成功")
			{
				Log.ILog.Debug("支付宝支付成功");
			}
			else
			{
				Log.ILog.Debug("支付宝支付失败");
				//清理支付信息
			}
		}

		/// <summary>微信充值</summary>
		public void WeChatPay(string orderInfo)
		{
			string[] orderInfos = orderInfo.Split(',');
			string appid = orderInfos[0];
			string mchid = orderInfos[1];
			string prepayid = orderInfos[2];
			string noncestr = orderInfos[3];
			string timestamp = orderInfos[4];
			string packageValue = orderInfos[5];
			string sign = orderInfos[6];
#if UNITY_ANDROID && !UNITY_EDITOR
		//将服务器返回的参数 封装到object数组里 分别是:会话ID,随机字符串,时间戳,签名,支付结果通知回调的物体,物体上的某个回调函数名称
		object[] objs = new object[] { appid, mchid, prepayid, noncestr, timestamp, sign, "Global", "WechatPayCallback" };
		//调用安卓层的WeiChatPayReq方法 进行支付
		jo.Call("WeChatPayReq", objs);
#endif
		}

		public void OnGetPhoneNum()
		{
#if UNITY_ANDROID && !UNITY_EDITOR
			jo.Call("GetPhoneNum", "+86");
#elif UNITY_IPHONE && !UNITY_EDITOR
			Log.ILog.Debug($"UNITY_IPHONE:");
#else
			this.OnGetPhoneNumHandler(PhoneNumberHelper.getRandomTel());
#endif
		}

		public void OnRecvPhoneNum(string phoneNum)
		{
			Log.ILog.Debug($"OnRecvPhoneNum: {phoneNum}");
			this.OnGetPhoneNumHandler(phoneNum);
		}
	}
}