using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using quicksdk;
using System;

public enum ChannelIdEnum
{ 
	XiaoMi = 15,
	ViVo = 17,
	OPPO = 23,
	HuaWei = 24,
}

public class EventHandle : QuickSDKListener
{

	public GameObject mExitDialogCanvas;

	public Action onLoginSuccessAction;
	public Action onLoginFailAction;
	public Action onInitSuccessAction;

	public GameObject Btn_RenZheng;

	public string ChannelId = "1";

	void showLog(string title, string message)
	{
		Debug.Log("title: " + title + ", message: " + message);
	}

	public static int onChannelType()
	{
#if MuBao
		return QuickSDK.getInstance().channelType();
#else
		return 0;
#endif
	}

	public static bool IsHuiWeiChannel()
	{
		return onChannelType() == (int)ChannelIdEnum.HuaWei;
	}

	public static bool IsQudaoPackage()
	{
		int type = onChannelType();
		return type > 0;
	}

	public static void CheckCreateRole(string zhanghao, string name)
	{
		if (!EventHandle.IsQudaoPackage())
		{
			return;
		}
		int channeltype = EventHandle.onChannelType();
		string roleKey = channeltype.ToString() + "_" + zhanghao;
		if (PlayerPrefs.GetInt(roleKey) != 1)
		{
			PlayerPrefs.SetInt(roleKey, 1);
			EventHandle.SendCreateRole($"{zhanghao}_{name}");
		}
		//EventHandle.SendEnterGame( );
	}

	public static void SendCreateRole(string info)
	{
		Debug.Log("SendCreateRole(): ");
		EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
		eventHandle.onCreatRole(info);
	}

	public static void SendPay(string[] parameter)
	{
		EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
		eventHandle.onPay(parameter);
	}

	// Use this for initialization
	void Start()
	{
		QuickSDK.getInstance().setListener(this);
		//mExitDialogCanvas = GameObject.Find("ExitDialog");
		//if (mExitDialogCanvas != null)
		//{
		//	mExitDialogCanvas.SetActive(false);
		//}
	}

	//init 已经在安卓层调用了
	public static void reInit()
	{
		//ongetDeviceId();
		QuickSDK.getInstance().reInit();
	}

	/*
	 *调用渠道SDK的登录（必接）
	 */
	public void onLogin()
	{
		QuickSDK.getInstance().login();
	}

	/// <summary>
	/// 注销账号（必接）
	/// ：调用渠道SDK的注销
	/// </summary>
	public void onLogout()
	{
		QuickSDK.getInstance().logout();
	}

	/// <summary>
	/// 定额支付（必接）, 调用渠道SDK的支付接口
	/// goodsID			产品ID，用来识别购买的产品
	/// goodsName		产品名称
	/// amount			支付总额（元）
	/// count			购买数量
	/// cpOrderID		产品订单号（游戏方的订单号）
	/// extrasParams	透传参数
	/// price			价格(可跟amount传一样的值)
	/// quantifier		购买商品单位，如：个
	/// goodsDesc		商品描述
	/// 接入要求：为了兼容各个渠道商品名称能够统一显示，订单应以如下案例的形式传值：
	/// amount:6.0 amount:10.0
	///count:60 count:1
	///goodsName:元宝 goodsName:月卡
	///goodsName产品名称以“月卡”、“钻石”、“元宝”的形式传入，不带数量；
	/// </summary>
	public void onPay(string[] parameter)
	{
		//model.amount + "," + dingDanID;
		string zhanghaoID = parameter[3];
		string name = parameter[4];

		OrderInfo orderInfo = new OrderInfo();
		GameRoleInfo gameRoleInfo = new GameRoleInfo();
		//orderInfo.callbackUrl
		orderInfo.goodsID = "1";
		orderInfo.goodsName = "钻石";
		orderInfo.goodsDesc = "钻石";
		orderInfo.quantifier = "个";
		orderInfo.extrasParams = "extparma";
		orderInfo.count = 1;
		orderInfo.amount = double.Parse(parameter[1]);
		orderInfo.price = double.Parse(parameter[1]);
		orderInfo.callbackUrl = "";
		orderInfo.cpOrderID = parameter[2];
		gameRoleInfo.gameRoleBalance = "0";
		gameRoleInfo.gameRoleID = zhanghaoID;
		gameRoleInfo.gameRoleLevel = "1";
		gameRoleInfo.gameRoleName = name;
		gameRoleInfo.partyName = "同济会";
		gameRoleInfo.serverID = "1";
		gameRoleInfo.serverName = "火星服务器";
		gameRoleInfo.vipLevel = "1";
		gameRoleInfo.roleCreateTime = "roleCreateTime";

		string userId = QuickSDK.getInstance().userId();
		Debug.Log("userId:  " + userId);
		QuickSDK.getInstance().pay(orderInfo, gameRoleInfo);
	}

	public void onEnterYunKeFuCenter()
	{
		GameRoleInfo gameRoleInfo = new GameRoleInfo();
		gameRoleInfo.gameRoleBalance = "0";
		gameRoleInfo.gameRoleID = "11111";
		gameRoleInfo.gameRoleLevel = "1";
		gameRoleInfo.gameRoleName = "钱多多";
		gameRoleInfo.partyName = "同济会";
		gameRoleInfo.serverID = "1";
		gameRoleInfo.serverName = "火星服务器";
		gameRoleInfo.vipLevel = "1";
		gameRoleInfo.roleCreateTime = "roleCreateTime";
		QuickSDK.getInstance().enterYunKeFuCenter(gameRoleInfo);
	}

	public void onCallSDKShare()
	{
		ShareInfo shareInfo = new ShareInfo();
		shareInfo.title = "这是标题";
		shareInfo.content = "这是描述";
		shareInfo.imgPath = "https://www.baidu.com/";
		shareInfo.imgUrl = "https://www.baidu.com/";
		shareInfo.url = "https://www.baidu.com/";
		shareInfo.type = "url_link";
		shareInfo.shareTo = "0";
		shareInfo.extenal = "extenal";
		QuickSDK.getInstance().callSDKShare(shareInfo);
	}


	/// <summary>
	/// 上传角色信息（必接）
	/// </summary>
	public void onCreatRole(string info)
	{
		//注：GameRoleInfo的字段，如果游戏有的参数必须传，没有则不用传
		string[] infolist = info.Split('_');
		string zhanghaoID = infolist[0];
		; string name = infolist[1];

		GameRoleInfo gameRoleInfo = new GameRoleInfo();
		gameRoleInfo.gameRoleBalance = "0";
		gameRoleInfo.gameRoleID = zhanghaoID;
		gameRoleInfo.gameRoleLevel = "1";
		gameRoleInfo.gameRoleName = name;
		gameRoleInfo.partyName = "同济会";
		gameRoleInfo.serverID = "1";
		gameRoleInfo.serverName = "火星服务器";
		gameRoleInfo.vipLevel = "1";
		gameRoleInfo.roleCreateTime = GetTimeStamp(true);//UC与1881渠道必传，值为10位数时间戳
		gameRoleInfo.gameRoleGender = "男";//360渠道参数
		gameRoleInfo.gameRolePower = "38";//360渠道参数，设置角色战力，必须为整型字符串
		gameRoleInfo.partyId = "1100";//360渠道参数，设置帮派id，必须为整型字符串
		gameRoleInfo.professionId = "11";//360渠道参数，设置角色职业id，必须为整型字符串
		gameRoleInfo.profession = "法师";//360渠道参数，设置角色职业名称
		gameRoleInfo.partyRoleId = "1";//360渠道参数，设置角色在帮派中的id
		gameRoleInfo.partyRoleName = "帮主"; //360渠道参数，设置角色在帮派中的名称
		gameRoleInfo.friendlist = "无";//360渠道参数，设置好友关系列表，格式请参考：http://open.quicksdk.net/help/detail/aid/190

		QuickSDK.getInstance().createRole(gameRoleInfo);//创建角色
	}

	/// <summary>
	/// 获取当前时间戳  
	/// </summary>
	/// <param name="bflag"></param>为真时获取10位时间戳,为假时获取13位时间戳.bool bflag = true</param>  
	/// <returns></returns>
	public static string GetTimeStamp(bool bflag)
	{
		TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
		string ret = string.Empty;
		if (bflag)
			ret = Convert.ToInt64(ts.TotalSeconds).ToString();
		else
			ret = Convert.ToInt64(ts.TotalMilliseconds).ToString();

		return ret;
	}

	/// <summary>
	/// 进入游戏时上传
	/// 登录完成之后，进入游戏时向渠道SDK上传角色信息
	/// </summary>
	public void onEnterGame(string info)
	{
		string[] infos = info.Split('_');
		string zhanghaoID = infos[0];
		string name = infos[1];

		QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER);
		//注：GameRoleInfo的字段，如果游戏有的参数必须传，没有则不用传
		GameRoleInfo gameRoleInfo = new GameRoleInfo();

		gameRoleInfo.gameRoleBalance = "0";
		gameRoleInfo.gameRoleID = zhanghaoID;
		gameRoleInfo.gameRoleLevel = "1";
		gameRoleInfo.gameRoleName = name;
		gameRoleInfo.partyName = "同济会";
		gameRoleInfo.serverID = "1";
		gameRoleInfo.serverName = "火星服务器";
		gameRoleInfo.vipLevel = "1";
		gameRoleInfo.roleCreateTime = GetTimeStamp(true);//UC与1881渠道必传，值为10位数时间戳

		gameRoleInfo.gameRoleGender = "男";//360渠道参数
		gameRoleInfo.gameRolePower = "38";//360渠道参数，设置角色战力，必须为整型字符串
		gameRoleInfo.partyId = "1100";//360渠道参数，设置帮派id，必须为整型字符串

		gameRoleInfo.professionId = "11";//360渠道参数，设置角色职业id，必须为整型字符串
		gameRoleInfo.profession = "法师";//360渠道参数，设置角色职业名称
		gameRoleInfo.partyRoleId = "1";//360渠道参数，设置角色在帮派中的id
		gameRoleInfo.partyRoleName = "帮主"; //360渠道参数，设置角色在帮派中的名称
		gameRoleInfo.friendlist = "无";//360渠道参数，设置好友关系列表，格式请参考：http://open.quicksdk.net/help/detail/aid/190

		QuickSDK.getInstance().enterGame(gameRoleInfo);//开始游戏

		//Application.LoadLevel("scene4");
	}


	/// <summary>
	///  角色升级时上传, 角色升级时向渠道SDK上传角色信息
	///  1) 在创建游戏角色、进入游戏和角色升级时候需要上传角色信息；
	///  2) GameRoleInfo所有字段均不能传null，游戏没有的字段传一个默认值；
	///  
	/// </summary>
	public void onUpdateRoleInfo(string info)
	{
		string[] infos = info.Split('_');
		string zhanghaoID = infos[0];
		string name = infos[1];
		//注：GameRoleInfo的字段，如果游戏有的参数必须传，没有则不用传
		GameRoleInfo gameRoleInfo = new GameRoleInfo();

		gameRoleInfo.gameRoleBalance = "0";
		gameRoleInfo.gameRoleID = zhanghaoID;
		gameRoleInfo.gameRoleLevel = "1";
		gameRoleInfo.gameRoleName = name;
		gameRoleInfo.partyName = "同济会";
		gameRoleInfo.serverID = "1";
		gameRoleInfo.serverName = "火星服务器";
		gameRoleInfo.vipLevel = "1";
		gameRoleInfo.roleCreateTime = GetTimeStamp(true);//UC与1881渠道必传，值为10位数时间戳

		gameRoleInfo.gameRoleGender = "男";//360渠道参数
		gameRoleInfo.gameRolePower = "38";//360渠道参数，设置角色战力，必须为整型字符串
		gameRoleInfo.partyId = "1100";//360渠道参数，设置帮派id，必须为整型字符串

		gameRoleInfo.professionId = "11";//360渠道参数，设置角色职业id，必须为整型字符串
		gameRoleInfo.profession = "法师";//360渠道参数，设置角色职业名称
		gameRoleInfo.partyRoleId = "1";//360渠道参数，设置角色在帮派中的id
		gameRoleInfo.partyRoleName = "帮主"; //360渠道参数，设置角色在帮派中的名称
		gameRoleInfo.friendlist = "无";//360渠道参数，设置好友关系列表，格式请参考：http://open.quicksdk.net/help/detail/aid/190

		QuickSDK.getInstance().updateRole(gameRoleInfo);
	}

	/// <summary>
	///  退出（必接）
	///  退出游戏。需先通过isChannelHasExitDialog接口判断渠道是否有退出框，若渠道有退出框，直接调用QuickSDK的exit接口，若渠道没有退出框，则调用游戏自身的退出
	/// </summary>
	public void onExit()
	{
		if (QuickSDK.getInstance().isChannelHasExitDialog())
		{
			QuickSDK.getInstance().exit();
		}
		else
		{
			//游戏调用自身的退出对话框，点击确定后，调用QuickSDK的exit()方法
			//mExitDialogCanvas.SetActive(true);
			QuickSDK.getInstance().exit();
		}
	}

	public void onExitCancel()
	{
		mExitDialogCanvas?.SetActive(false);
	}

	public void onExitConfirm()
	{
		mExitDialogCanvas?.SetActive(false);
		QuickSDK.getInstance().exit();
	}

	public void onShowToolbar()
	{
		QuickSDK.getInstance().showToolBar(ToolbarPlace.QUICK_SDK_TOOLBAR_BOT_LEFT);
	}

	public void onHideToolbar()
	{
		QuickSDK.getInstance().hideToolBar();
	}

	public void onEnterUserCenter()
	{
		QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER);
	}

	public void onEnterBBS()
	{
		QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS);
	}
	public void onEnterCustomer()
	{
		QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_CUSTOMER_CENTER);
	}
	public void onGetGoodsInfos()
	{
		showLog("onGetGoodsInfos", "onGetGoodsInfos 方法已被调用");
		QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_QUERY_GOODS_INFO);
	}
	public void onUserId()
	{
		string uid = QuickSDK.getInstance().userId();
		showLog("userId", uid);
	}

	public void ongetDeviceId()
	{
		string deviceId = QuickSDK.getInstance().getDeviceId();
		showLog("deviceId", deviceId);
	}

	public void onFuctionSupport(int type)
	{
		bool supported = QuickSDK.getInstance().isFunctionSupported((FuncType)type);
		showLog("fuctionSupport", supported ? "yes" : "no");
	}
	public void onGetConfigValue(string key)
	{
		string value = QuickSDK.getInstance().getConfigValue(key);
		showLog("onGetConfigValue", key + ": " + value);
	}

	public void onOk()
	{
		//messageBox.SetActive(false);
	}

	public void onPauseGame()
	{
		Time.timeScale = 0;
		QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_PAUSED_GAME);
	}

	public void onResumeGame()
	{
		Time.timeScale = 1;
	}

	//************************************************************以下是需要实现的回调接口*************************************************************************************************************************
	//callback
	//初始化成功的回调
	public override void onInitSuccess()
	{
		showLog("onInitSuccess", "onInitSuccess");

		string channelid = EventHandle.onChannelType().ToString();
		this.ChannelId = channelid;

		if (IsHuiWeiChannel())
		{
			Btn_RenZheng?.SetActive(false);
			showLog("callFunction[channelid]: ", "huawei");
		}
		else
		{
			showLog("callFunction[channelid]: ", "not huawei");
		}

		onInitSuccessAction?.Invoke();
		//如果游戏需要启动时登录，需要在初始化成功之后调用
	}

	public override void onInitFailed(ErrorMsg errMsg)
	{
		//初始化失败的回调
		showLog("onInitFailed", "msg: " + errMsg.errMsg);
	}

	public override void onLoginSuccess(UserInfo userInfo)
	{
		//登录成功的回调
		if (EventHandle.IsHuiWeiChannel())
		{
			onEnterGame($"{userInfo.uid}_{userInfo.userName}");
		}
		else
		{
			//其他渠道不需要处理实名，直接返回
			onLoginSuccessAction?.Invoke();
		}
	}

	public override void onSwitchAccountSuccess(UserInfo userInfo)
	{
		//切换账号成功，清除原来的角色信息，使用获取到新的用户信息，回到进入游戏的界面，不需要再次调登录
		showLog("onLoginSuccess", "uid: " + userInfo.uid + " ,username: " + userInfo.userName + " ,userToken: " + userInfo.token + ", msg: " + userInfo.errMsg);
		//Application.LoadLevel("scene2");
	}

	public override void onLoginFailed(ErrorMsg errMsg)
	{
		//登录失败的回调
		//如果游戏没有登录按钮，应在这里再次调用登录接口
		//我们的游戏有登录按钮，如果失败，给个提示，再次点击登录
		onLoginFailAction?.Invoke();
		showLog("onLoginFailed", "msg: " + errMsg.errMsg);
	}

	public override void onLogoutSuccess()
	{
		//注销成功的回调
		//游戏应该清除当前角色信息，回到登陆界面，并自动调用一次登录接口
		showLog("onLogoutSuccess", "");

		//注销成功后回到登陆界面
		//Application.LoadLevel("scene1");
	}

	public override void onPaySuccess(PayResult payResult)
	{
		//支付成功的回调
		//一些渠道支付成功的通知并不准确，因此客户端的通知仅供参考，游戏发货请以服务端通知为准，不能以客户端的通知为准
		showLog("onPaySuccess", "orderId: " + payResult.orderId + ", cpOrderId: " + payResult.cpOrderId + " ,extraParam" + payResult.extraParam);
		//ClearnPayValue?.invoke
	}

	public override void onPayCancel(PayResult payResult)
	{
		//支付取消的回调
		showLog("onPayCancel", "orderId: " + payResult.orderId + ", cpOrderId: " + payResult.cpOrderId + " ,extraParam" + payResult.extraParam);
		//ClearnPayValue?.invoke
	}

	public override void onPayFailed(PayResult payResult)
	{
		//支付失败的回调
		showLog("onPayFailed", "orderId: " + payResult.orderId + ", cpOrderId: " + payResult.cpOrderId + " ,extraParam" + payResult.extraParam);
		//ClearnPayValue?.invoke
	}

	public override void onExitSuccess()
	{
		//SDK退出成功的回调
		showLog("onExitSuccess", "");
		//退出成功的回调里面调用  QuickSDK.getInstance ().exitGame ();  即可实现退出游戏，杀进程。为避免与渠道发生冲突，请不要使用  Application.Quit ();
		QuickSDK.getInstance().exitGame();
	}

	public override void onSucceed(string infos)
	{
		//华为渠道。 目前只有华为有返回！！！
		showLog("onSucceed", infos);

		LitJson.JsonData jo = LitJson.JsonMapper.ToObject(infos);
		//{ "uid":"1178471402501092","age":20,"realName":true,"resumeGame":true,"other":"","FunctionType":105}
		//JObject jo = (JObject)JsonConvert.DeserializeObject(infos);
		string functionType = jo["FunctionType"].ToString();
		if (int.Parse(functionType) == (int)FuncType.QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER)
		{
			string sage = jo["age"].ToString();
			string realName = jo["realName"].ToString();
			if (realName == "false")
			{
				PlayerPrefs.SetInt("FangChenMi_Year", 0);
				showLog("realName: ", "=false.  没有实名认证. ");
			}
			else
			{
				int age = int.Parse(sage);
				PlayerPrefs.SetInt("FangChenMi_Year", age);
				showLog("年龄[SetInt]: ", age.ToString());
			}

			onLoginSuccessAction?.Invoke();
		}
		else
		{
			showLog("functionType: ", functionType);
		}
	}

	public override void onFailed(string message)
	{
		showLog("onFailed", "msg: " + message);
	}

	public void onNext()
	{
		//Application.LoadLevel("scene3");
	}

	public void onRecvPermissionsResult(string open)
	{
		UnityEngine.Debug.Log("onRecvPermissionsResult！");

		if (open == "1")
		{
			UnityEngine.Debug.Log("安卓同意了权限！");
		}
		else
		{
			//弹出界面
			UnityEngine.Debug.Log("安卓拒绝了权限！");
		}
	}

	public void QuDaoRequestPermissions()
	{
		if (!EventHandle.IsQudaoPackage())
			return;
#if UNITY_ANDROID && !UNITY_EDITOR
        using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                UnityEngine.Debug.Log("unitycall: yyyy");
                jo.Call("QuDaoRequestPermissions" );
            }
        }
#endif
	}
}

