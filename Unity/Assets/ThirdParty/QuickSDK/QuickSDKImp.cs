using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace quicksdk
{
	public class OrderInfo{
		public string goodsID;
		public string goodsName;
		public string goodsDesc;
		public string quantifier; //商品量词
		public string cpOrderID;
		public string callbackUrl;
		public string extrasParams;
		public double price;
		public double amount;
		public int count;
	}
	
	public class GameRoleInfo
	{
		public string serverName;
		public string serverID;
		public string gameRoleName;
		public string gameRoleID;
		public string gameRoleBalance;
		public string vipLevel;
		public string gameRoleLevel;
		public string partyName;
        public string roleCreateTime;

		public string gameRoleGender;
		public string gameRolePower;
		public string partyId;

		public String professionId;
		public String profession;
		public String partyRoleId;
		public String partyRoleName;
		public String friendlist;
	}
	public class ShareInfo
	{
		public String title;   //分享标题
		public String content;   //分享内容
		public String imgPath;   //分享图片本地地址
		public String imgUrl;   //分享图片网络地址
		public String url;   //分享链接
		public String type;   //分享类型
		public String shareTo;   //分享到哪里
		public String extenal;   //额外备注
	}
	
	public enum FuncType 
	{
		
		QUICK_SDK_FUNC_TYPE_UNDEFINED = 0,
		QUICK_SDK_FUNC_TYPE_ENTER_BBS = 101,/*进入论坛*/
		QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER = 102,/*进入用户中心*/
		QUICK_SDK_FUNC_TYPE_SHOW_TOOLBAR = 103,/*显示浮动工具栏*/
		QUICK_SDK_FUNC_TYPE_HIDE_TOOLBAR = 104,/*隐藏浮动工具栏*/
		QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER = 105,/*实名认证*/
		QUICK_SDK_FUNC_TYPE_ANTI_ADDICTION_QUERY = 106, /*防沉迷 （android）*/
		QUICK_SDK_FUNC_TYPE_PAUSED_GAME,/*暂停游戏 （iOS）*/
		QUICK_SDK_FUNC_TYPE_ENTER_CUSTOMER_CENTER,		/*进入客服中心*/
        QUICK_SDK_FUNC_TYPE_QUERY_GOODS_INFO,
		QUICK_SDK_FUNC_TYPE_GET_DEVICE_ID = 112     /*获取DeviceID*/
	}

	public enum ToolbarPlace
	{
		QUICK_SDK_TOOLBAR_TOP_LEFT  = 1,           /* 左上 */
		QUICK_SDK_TOOLBAR_TOP_RIGHT = 2,           /* 右上 */
		QUICK_SDK_TOOLBAR_MID_LEFT  = 3,           /* 左中 */
		QUICK_SDK_TOOLBAR_MID_RIGHT = 4,           /* 右中 */
		QUICK_SDK_TOOLBAR_BOT_LEFT  = 5,           /* 左下 */
		QUICK_SDK_TOOLBAR_BOT_RIGHT = 6            /* 右下 */
	}
	
	// 错误信息
	public class ErrorMsg
	{
		public string errMsg;
	}
	
	// 用户信息，登录回调中使用
	public class UserInfo : ErrorMsg
	{
		public string uid;
		public string userName;
		public string token;
	}
	
	// 支付信息，支付回调中使用
	public class PayResult
	{
		public string orderId;
		public string cpOrderId;
		public string extraParam;
	}
	
	public class QuickSDKImp
	{
		private static QuickSDKImp _instance;
		
		public static QuickSDKImp getInstance() {
			if( null == _instance ) {
				_instance = new QuickSDKImp();
			}
			return _instance;
		}
		
		public void setListener(QuickSDKListener listener)
		{
#if UNITY_IOS && !UNITY_EDITOR
			string gameObjectName = listener.gameObject.name;
			//quicksdk_nativeSetListener(gameObjectName);
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.setListener(listener);
#endif
		}

        public void init()
        {
#if UNITY_IOS && !UNITY_EDITOR

#elif UNITY_ANDROID && !UNITY_EDITOR
            QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
            androidSupport.init();
#endif
        }
		
		public void exit()
		{
#if UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.exit();
#endif
		}
		
		public void login ()
		{
#if UNITY_IOS && !UNITY_EDITOR
			//quicksdk_nativeLogin();
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.login();
#endif
		}
		public void logout ()
		{
#if UNITY_IOS && !UNITY_EDITOR
			//quicksdk_nativeLogout();
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.logout();
#endif
		}
		
		public void pay (OrderInfo orderInfo, GameRoleInfo gameRoleInfo)
		{
#if UNITY_IOS && !UNITY_EDITOR
			//quicksdk_nativePay(orderInfo.goodsID, orderInfo.goodsName, orderInfo.goodsDesc, orderInfo.quantifier, orderInfo.cpOrderID, orderInfo.callbackUrl, orderInfo.extrasParams, orderInfo.price, orderInfo.amount, orderInfo.count,
			 //                  gameRoleInfo.serverID, gameRoleInfo.serverName, gameRoleInfo.gameRoleName, gameRoleInfo.gameRoleID, gameRoleInfo.gameRoleBalance, gameRoleInfo.vipLevel, gameRoleInfo.gameRoleLevel, gameRoleInfo.partyName);
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.pay(orderInfo, gameRoleInfo);
#endif
		}
		public string userId()//uid
		{
#if UNITY_IOS && !UNITY_EDITOR
			//IntPtr intPtr = quicksdk_nativeUserId();
			//return Marshal.PtrToStringAnsi(intPtr);
			return "";
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.getUserId();
#else
			return "";
#endif
			
		}
		public string getDeviceId()//getDeviceId
		{
#if UNITY_IOS && !UNITY_EDITOR
			return "";
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.getDeviceId();
#else
			return "";
#endif

		}
		public void createRole(GameRoleInfo gameRoleInfo){
			updateRoleInfoWith (gameRoleInfo, true);
		}

		public void enterGame(GameRoleInfo gameRoleInfo){
			updateRoleInfoWith (gameRoleInfo, false);
		}

		public void updateRole(GameRoleInfo gameRoleInfo){
			updateRoleInfoWith (gameRoleInfo, false);
		}

		public int showToolBar(ToolbarPlace place)//1左上,2右上,3左中,4右中,5左下,6右下
		{
			#if UNITY_IOS && !UNITY_EDITOR
			return 0;//return (quicksdk_nativeShowToolBar((int)place) == -100?0:1);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.callFunc(FuncType.QUICK_SDK_FUNC_TYPE_SHOW_TOOLBAR);
			#else
			return 0;
			#endif
			
		}
		public int hideToolBar()
		{
			#if UNITY_IOS && !UNITY_EDITOR
			return 0;//return (quicksdk_nativeHideToolBar() == -100?0:1);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.callFunc(FuncType.QUICK_SDK_FUNC_TYPE_HIDE_TOOLBAR);
			#else
			return 0;
			#endif
			
		}

		public bool isFunctionSupported(FuncType type)//1暂停游戏,2进入用户中心,3进入论坛,4处理应用跳转(旧),5显示浮动工具栏,6隐藏浮动工具栏,7处理应用跳转(新)
		{
#if UNITY_IOS && !UNITY_EDITOR
/*
			switch (type) {
			case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS:
				return quicksdk_nativeIsFunctionTypeSupported(3);
			case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER:
				return quicksdk_nativeIsFunctionTypeSupported(2);
			case FuncType.QUICK_SDK_FUNC_TYPE_SHOW_TOOLBAR:
				return quicksdk_nativeIsFunctionTypeSupported(5);
			case FuncType.QUICK_SDK_FUNC_TYPE_HIDE_TOOLBAR:
				return quicksdk_nativeIsFunctionTypeSupported(6);
			case FuncType.QUICK_SDK_FUNC_TYPE_PAUSED_GAME:
				return quicksdk_nativeIsFunctionTypeSupported(1);
			case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_CUSTOMER_CENTER:
				return quicksdk_nativeIsFunctionTypeSupported(7);
			case FuncType.QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER:
				return quicksdk_nativeIsFunctionTypeSupported(8);
			default:
				return false;
			}
			*/
			return false;
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.isFuncSupport(type);
#else
			return false;
#endif
			
		}

        public void callFunction(FuncType type)
        {
#if UNITY_IOS && !UNITY_EDITOR
/*
			switch (type) {
			case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS:
				quicksdk_nativeEnterBBS();
				return;
			case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER:
				quicksdk_nativeEnterUserCenter();
				return;
			case FuncType.QUICK_SDK_FUNC_TYPE_SHOW_TOOLBAR:
				quicksdk_nativeShowToolBar(3);
				return;
			case FuncType.QUICK_SDK_FUNC_TYPE_HIDE_TOOLBAR:
				quicksdk_nativeHideToolBar();
				return;
			case FuncType.QUICK_SDK_FUNC_TYPE_PAUSED_GAME:
				quicksdk_nativePausedGame();
				return;
			case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_CUSTOMER_CENTER:
				quicksdk_nativeEnterCustomerCenter();
				return;
			default:
				return;
			}
			*/
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.callFunc(type);
#endif
		}


		public string channelName()          //获取渠道名称
		{
#if UNITY_IOS && !UNITY_EDITOR
			//IntPtr intPtr = quicksdk_nativeChannelName();
			//return Marshal.PtrToStringAnsi(intPtr);
			return "";
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.getChannelName();
#else 
			return "";
#endif
			
		}
		public string channelVersion()       //获取渠道版本
		{
#if UNITY_IOS && !UNITY_EDITOR
			//IntPtr intPtr = quicksdk_nativeChannelVersion();
			//return Marshal.PtrToStringAnsi(intPtr);
			return "";
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.getChannelVersion();
#else
			return "";
#endif
			
		}
		public int channelType()                 //获取渠道类别 渠道唯一标识
		{
#if UNITY_IOS && !UNITY_EDITOR
			//return quicksdk_nativeChannelType();
			return 0;
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.getChannelType();
#else
			return 0;
#endif
			
		}
		public string SDKVersion()      //QuickSDK版本
		{
#if UNITY_IOS && !UNITY_EDITOR
			//IntPtr intPtr = quicksdk_nativeSDKVersion();
			//return Marshal.PtrToStringAnsi(intPtr);
			return "";
#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.getSDKVersion();
#else
			return "";
#endif
			
		}

		public string getConfigValue(string key)      //QuickSDK版本
		{
#if UNITY_IOS && !UNITY_EDITOR
			//IntPtr intPtr = quicksdk_nativeGetConfigValue(key);
			//return Marshal.PtrToStringAnsi(intPtr);
			return "";
#elif UNITY_ANDROID && !UNITY_EDITOR
            QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
            return androidSupport.getConfigValue(key);
#else
            return "";
#endif
			
		}

        public bool isChannelHasExitDialog()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            //QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
            //return androidSupport.isChannelHasExitDialog();
			return false;
#else
            return false;
#endif
        }

        public void exitGame()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
            androidSupport.exitGame();
#endif

        }
	



		public void updateRoleInfoWith(GameRoleInfo gameRoleInfo, bool isCreateRole)
		{
			#if UNITY_IOS && !UNITY_EDITOR
			;//quicksdk_nativeUpdateRoleInfo(gameRoleInfo.serverID, gameRoleInfo.serverName, gameRoleInfo.gameRoleName, gameRoleInfo.gameRoleID, gameRoleInfo.gameRoleBalance, gameRoleInfo.vipLevel, gameRoleInfo.gameRoleLevel, gameRoleInfo.partyName, gameRoleInfo.roleCreateTime, isCreateRole);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.updateRoleInfo(gameRoleInfo, isCreateRole);
			#endif
		}
		public int enterUserCenter() //用户中心
		{
			#if UNITY_IOS && !UNITY_EDITOR
			return 0;//return (quicksdk_nativeEnterUserCenter() == -100?0:1);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.callFunc(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER);
			#else
			return 0;
			#endif
			
		}

		public void enterYunKeFuCenter(GameRoleInfo gameRoleInfo){
			#if UNITY_IOS && !UNITY_EDITOR
			;//quicksdk_nativeEnterYunKeFuCenter(gameRoleInfo.gameRoleID, gameRoleInfo.gameRoleName, gameRoleInfo.serverName, gameRoleInfo.vipLevel);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.callCustomPlugin(gameRoleInfo.gameRoleID, gameRoleInfo.gameRoleName, gameRoleInfo.serverName, gameRoleInfo.vipLevel);
			#endif
		}
		public void callSDKShare(ShareInfo shareInfo){
			#if UNITY_IOS && !UNITY_EDITOR

			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			androidSupport.callSDKShare(shareInfo.title, shareInfo.content, shareInfo.imgPath, shareInfo.imgUrl,shareInfo.url,shareInfo.type,shareInfo.shareTo,shareInfo.extenal);
			#endif
		}
		
		private int enterCustomerCenter() ////客服
		{
			#if UNITY_IOS && !UNITY_EDITOR
			return 0;//return (quicksdk_nativeEnterCustomerCenter() == -100?0:1);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			return 0;
			#else
			return 0;
			#endif
			
		}
		private int enterBBS()//BBS
		{
			#if UNITY_IOS && !UNITY_EDITOR
			return 0;//return (quicksdk_nativeEnterBBS() == -100?0:1);
			#elif UNITY_ANDROID && !UNITY_EDITOR
			QuickUnitySupportAndroid androidSupport = QuickUnitySupportAndroid.getInstance();
			return androidSupport.callFunc(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS);
			#else
			return 0;
			#endif
			
		}

		/*
		#if UNITY_IOS && !UNITY_EDITOR
		[DllImport("__Internal")]
		private static extern void quicksdk_nativeSetListener(string gameObjectName);
		[DllImport("__Internal")]
		private static extern void quicksdk_nativeLogin();
		[DllImport("__Internal")]
		private static extern void quicksdk_nativeLogout();
		[DllImport("__Internal")]
		private static extern void quicksdk_nativePay(string goodsId, string goodsName, string goodsDesc, string quantifier, string cpOrderId, string callbackUrl, string extrasParams, double price, double amount, int count,
		                                              string serverId, string serverName, string gameRoleName, string gameRoleId, string gameRoleBalance, string vipLevel, string gameRoleLevel, string partyName);
		[DllImport("__Internal")]
		private static extern IntPtr quicksdk_nativeUserId();
		[DllImport("__Internal")]
		private static extern void quicksdk_nativeUpdateRoleInfo(string serverId, string serverName, string gameRoleName, string gameRoleId, string gameRoleBalance, string vipLevel, string gameRoleLevel, string partyName, string creatTime, bool isCreate);
		[DllImport("__Internal")]
		private static extern void quicksdk_nativeEnterYunKeFuCenter(string gameRoleID, string gameRoleName, string serverName, string vipLevel);
		[DllImport("__Internal")]
		private static extern int quicksdk_nativeEnterUserCenter();
		[DllImport("__Internal")]
        private static extern int quicksdk_nativeEnterCustomerCenter();
		[DllImport("__Internal")]
		private static extern int quicksdk_nativeEnterBBS();
		[DllImport("__Internal")]
		private static extern int quicksdk_nativeShowToolBar(int place);
		[DllImport("__Internal")]
		private static extern int quicksdk_nativeHideToolBar();
		[DllImport("__Internal")]
		private static extern int quicksdk_nativePausedGame();
		[DllImport("__Internal")]
		private static extern bool quicksdk_nativeIsFunctionTypeSupported(int type);
		[DllImport("__Internal")]
		private static extern IntPtr quicksdk_nativeChannelName();
		[DllImport("__Internal")]
		private static extern IntPtr quicksdk_nativeChannelVersion();
		[DllImport("__Internal")]
		private static extern int quicksdk_nativeChannelType();
		[DllImport("__Internal")]
		private static extern IntPtr quicksdk_nativeSDKVersion();
		[DllImport("__Internal")]
		private static extern IntPtr quicksdk_nativeGetConfigValue(string key);
		#endif*/

	}

#if UNITY_ANDROID && !UNITY_EDITOR

    public class QuickUnitySupportAndroid {

        AndroidJavaObject ao;

        private static QuickUnitySupportAndroid instance;

        private QuickUnitySupportAndroid() {
            
            AndroidJavaClass ac = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            ao = ac.GetStatic<AndroidJavaObject>("currentActivity");
        }

        public static QuickUnitySupportAndroid getInstance()
        {
            if (instance == null)
            {
                instance = new QuickUnitySupportAndroid();
            }

            return instance;
        }

		public void setListener(QuickSDKListener listener)
        {
            Debug.Log("gameObject is " + listener.gameObject.name);
            if (listener == null)
            {
                Debug.LogError("set QuickSDKListener error, listener is null");
                return;
            }
            string gameObjectName = listener.gameObject.name;
            if (ao == null)
            {
                Debug.LogError("setListener error, current activity is null");
            }
            else
            {
                ao.Call("setUnityGameObjectName", gameObjectName);
            }
        }

        public void init()
        {
			ao.Call("requestInit");
        }

        public void exit()
        {
            ao.Call("requestExit");
        }

        public void login()
        {
            ao.Call("requestLogin");
        }

        public void logout()
        {
            ao.Call("requestLogout");
        }

		public void callCustomPlugin(String roleId,String roleName,String serverName,String vip)
		{
			ao.Call("requestCallCustomPlugin",roleId,roleName,serverName,vip);
		}
		public void callSDKShare(String title,String content,String imgPath,String imgUrl,String url,String type,String shareTo,String extenal)
		{
			ao.Call("requestCallSDKShare",title,content,imgPath,imgUrl,url,type,shareTo,extenal);
		}


        public void pay(OrderInfo orderInfo, GameRoleInfo gameRoleInfo)
        {
            if (orderInfo == null)
            {
                Debug.LogError("call pay error, orderInfo is null");
                return;
            }
            ao.Call("requestPay",
                orderInfo.goodsID, orderInfo.goodsName, 
                orderInfo.goodsDesc, orderInfo.quantifier, 
                orderInfo.cpOrderID, orderInfo.callbackUrl, 
                orderInfo.extrasParams, orderInfo.price+"", 
                orderInfo.amount + "", orderInfo.count+"",
                
                gameRoleInfo.serverName, gameRoleInfo.serverID,
                gameRoleInfo.gameRoleName, gameRoleInfo.gameRoleID,
                gameRoleInfo.gameRoleBalance, gameRoleInfo.vipLevel,
                gameRoleInfo.gameRoleLevel, gameRoleInfo.partyName, gameRoleInfo.roleCreateTime);
        }

        public string getUserId()
        {
            return ao.Call<string>("getUserId");
        }

	     public string getDeviceId()
        {
			return ao.Call<string>("getDeviceID");
        }

        public void updateRoleInfo(GameRoleInfo gameRoleInfo, bool isCreate)
        {
            if (gameRoleInfo.Equals(null))
            {
                Debug.LogError("updateRoleInfo is error, gameRoleInfo is null");
                return;
            }

            string serverName = String.IsNullOrEmpty(gameRoleInfo.serverName) ? "" : gameRoleInfo.serverName;
            string serverId = String.IsNullOrEmpty(gameRoleInfo.serverID) ? "" : gameRoleInfo.serverID;
            string roleName = String.IsNullOrEmpty(gameRoleInfo.gameRoleName) ? "" : gameRoleInfo.gameRoleName;
            string roleId = String.IsNullOrEmpty(gameRoleInfo.gameRoleID) ? "" : gameRoleInfo.gameRoleID;
            string roleBalance = String.IsNullOrEmpty(gameRoleInfo.gameRoleBalance) ? "" : gameRoleInfo.gameRoleBalance;
            string vipLevel = String.IsNullOrEmpty(gameRoleInfo.vipLevel) ? "" : gameRoleInfo.vipLevel;
            string roleLevel = String.IsNullOrEmpty(gameRoleInfo.gameRoleLevel) ? "" : gameRoleInfo.gameRoleLevel;
            string partyName = String.IsNullOrEmpty(gameRoleInfo.partyName) ? "" : gameRoleInfo.partyName;
            string roleCreateTime = String.IsNullOrEmpty(gameRoleInfo.roleCreateTime) ? "" : gameRoleInfo.roleCreateTime;

			string gameRoleGender = String.IsNullOrEmpty(gameRoleInfo.gameRoleGender) ? "" : gameRoleInfo.gameRoleGender;
			string gameRolePower = String.IsNullOrEmpty(gameRoleInfo.gameRolePower) ? "" : gameRoleInfo.gameRolePower;
			string partyId = String.IsNullOrEmpty(gameRoleInfo.partyId) ? "" : gameRoleInfo.partyId;

			string professionId = String.IsNullOrEmpty(gameRoleInfo.professionId) ? "" : gameRoleInfo.professionId;
			string profession = String.IsNullOrEmpty(gameRoleInfo.profession) ? "" : gameRoleInfo.profession;
			string partyRoleId = String.IsNullOrEmpty(gameRoleInfo.partyRoleId) ? "" : gameRoleInfo.partyRoleId;
			string partyRoleName = String.IsNullOrEmpty(gameRoleInfo.partyRoleName) ? "" : gameRoleInfo.partyRoleName;
			string friendlist = String.IsNullOrEmpty(gameRoleInfo.friendlist) ? "" : gameRoleInfo.friendlist;


            ao.Call("requestUpdateRole",
                serverId,
                serverName,
                roleName,
                roleId,
                roleBalance,
                vipLevel,
                roleLevel,
                partyName,
			    roleCreateTime,
			    gameRoleGender,
			    gameRolePower,
			    partyId,
			    professionId,
			    profession,
			    partyRoleId,
			    partyRoleName,
			    friendlist,
                isCreate + "");
            Debug.LogWarning("updateRoleInfo executed");
        }

        /**
         * return 0 success, -100 false or not support such function
         */
        public int callFunc(FuncType funcType)
        {
            int androidFuncType = 0;
            switch (funcType)
            {
                case FuncType.QUICK_SDK_FUNC_TYPE_UNDEFINED:
                    // Do nothing
                    break;
                case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS:
                    androidFuncType = 101;
                    break;

                case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER:
                    androidFuncType = 102;
                    break;

                case FuncType.QUICK_SDK_FUNC_TYPE_SHOW_TOOLBAR:
                    androidFuncType = 103;
                    break;

                case FuncType.QUICK_SDK_FUNC_TYPE_HIDE_TOOLBAR:
                    androidFuncType = 104;
                    break;
                case FuncType.QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER:
                    androidFuncType = 105;
                    break;
                case FuncType.QUICK_SDK_FUNC_TYPE_ANTI_ADDICTION_QUERY:
                    androidFuncType = 106;
                    break;
            }

            // TODO
            return ao.Call<int>("callFunc", androidFuncType);
        }
       public int callFunc(FuncType funcType,string s)
        {
			int androidFuncType =(int) funcType;

            // TODO
			return ao.Call<int>("callFunc", androidFuncType,s);
        }

        public bool isFuncSupport(FuncType funcType)
        {
            int androidFuncType = 0;
            switch (funcType)
            {
                case FuncType.QUICK_SDK_FUNC_TYPE_UNDEFINED:
                    // Do nothing
                    break;
                case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS:
                    androidFuncType = 101;
                    break;

                case FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER:
                    androidFuncType = 102;
                    break;

                case FuncType.QUICK_SDK_FUNC_TYPE_SHOW_TOOLBAR:
                    androidFuncType = 103;
                    break;

                case FuncType.QUICK_SDK_FUNC_TYPE_HIDE_TOOLBAR:
                    androidFuncType = 104;
                    break;
                case FuncType.QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER:
                    androidFuncType = 105;
                    break;
                case FuncType.QUICK_SDK_FUNC_TYPE_ANTI_ADDICTION_QUERY:
                    androidFuncType = 106;
                    break;
            }
            return ao.Call<bool>("isFuncSupport", androidFuncType);
        }

        public string getChannelName()
        {
            return ao.Call<string>("getChannelName");
        }

        public string getChannelVersion()
        {
            return ao.Call<string>("getChannelVersion");
        }

        public int getChannelType()
        {
            return ao.Call<int>("getChannelType");
        }

        public string getSDKVersion()
        {
            return ao.Call<string>("getSDKVersion");
        }

        public string getConfigValue(string key)
        {
            if (String.IsNullOrEmpty(key))
            {
                return null;
            }
            return ao.Call<string>("getConfigValue", key);
        }

        public bool isChannelHasExitDialog()
        {
            return ao.Call<bool>("isChannelHasExitDialog");
        }

        public void exitGame()
        {
            ao.Call("exitGame");
        }




}
#endif
}

