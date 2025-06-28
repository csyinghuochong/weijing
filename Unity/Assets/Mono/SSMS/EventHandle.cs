using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using quicksdk;
using System;
using ET;


/// <summary>
/// 避免冲突 
/// </summary>
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

    public Action<string, string> onLoginSuccessAction;

    public Action onSwitchAccountSuccessAction;
    public Action onLoginFailAction;
    public Action onInitSuccessAction;

    public string ChannelId = "1";

    void showLog(string title, string message)
    {
        Debug.Log("title: " + title + ", message: " + message);
    }

    // Use this for initialization
    void Start()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().setListener(this);
        //mExitDialogCanvas?.SetActive(false);
    }

    //隐私
    public void callShowPrivace()
    {
        QuickSDK.getInstance().showPrivace();
    }

    //init 已经在安卓层调用了
    public static void reInit()
    {
        Log.ILog.Debug("QuickSDK.getInstance().reInit");
        QuickSDK.getInstance().reInit();
    }

    /*
	 *调用渠道SDK的登录（必接）
	 */
    public void onLogin()
    {
        bool qudao = EventHandle.IsQudaoPackage();
        int qudaotype = onChannelType();
        Log.ILog.Debug($"quicksdk onLogin.. qudaotype: {qudaotype}");
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().login();
        //QuickSDK.getInstance().callFunctionWithParamsCallBack(217, new string[] { "1", "分享title", "分享content", "分享图片的地址path" });
    }

    /// <summary>
    /// 注销账号（必接）
    /// ：调用渠道SDK的注销
    /// </summary>
    public void onLogout()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
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
    public void onPay(string info)
    {
        //6_2963328665821184000_1_筱薰魅_159_星辰之巅_qd17503252454260
        //model.amount + "," + dingDanID;
        showLog("onPay", info);
        string[] infolist = info.Split('_');

        OrderInfo orderInfo = new OrderInfo();
        GameRoleInfo gameRoleInfo = new GameRoleInfo();

        orderInfo.goodsID = $"Pay_{infolist[0]}";       //产品ID，用来识别购买的产品
        orderInfo.goodsName = $"{int.Parse(infolist[0]) * 100}钻石";  //产品名称
        orderInfo.goodsDesc = "钻石";
        orderInfo.quantifier = "个";
        orderInfo.extrasParams = "";   //透传参数  服务器发送异步通知时原样回传(需要传纯字符串，不能传json格式)
        orderInfo.count = 1;            //购买数量
        orderInfo.amount = double.Parse(infolist[0]);            //支付总额（元）
        orderInfo.price = double.Parse(infolist[0]);            //价格(可跟amount传一样的值)

        //测试商品 1分钱
        //if (infolist[0] == "1")
        //{
        //    orderInfo.amount = 0.01;            //支付总额（元）
        //    orderInfo.price = 0.01;            //价格(可跟amount传一样的值)
        //}

        orderInfo.callbackUrl = "";     //游戏支付回调地址，如后台也有配置，则优先通知后台设置的地址
        orderInfo.cpOrderID = infolist[6];  //产品订单号（游戏方的订单号）

        gameRoleInfo.gameRoleBalance = "0";
        gameRoleInfo.gameRoleID = infolist[1];
        gameRoleInfo.gameRoleLevel = infolist[2];
        gameRoleInfo.gameRoleName = infolist[3];
        gameRoleInfo.partyName = "0";
        gameRoleInfo.serverID = infolist[4];
        gameRoleInfo.serverName = infolist[5];
        gameRoleInfo.vipLevel = "1";
        gameRoleInfo.roleCreateTime = TimeHelper.ServerNow().ToString();

        Log.Debug(gameRoleInfo.ToString());

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
        showLog("onCreatRole", info);
        string[] infolist = info.Split('_');

        GameRoleInfo gameRoleInfo = new GameRoleInfo();
        gameRoleInfo.gameRoleBalance = "0";
        gameRoleInfo.gameRoleID = infolist[0];
        gameRoleInfo.gameRoleLevel = "1";
        gameRoleInfo.gameRoleName = infolist[1];
        gameRoleInfo.partyName = "同济会";
        gameRoleInfo.serverID = infolist[2];
        gameRoleInfo.serverName = infolist[3];
        gameRoleInfo.vipLevel = "1";
        gameRoleInfo.roleCreateTime = TimeHelper.ServerNow().ToString();//值为10位数时间戳
        gameRoleInfo.gameRoleGender = "男";
        gameRoleInfo.gameRolePower = "38";//设置角色战力，必须为整型字符串
        gameRoleInfo.partyId = "0";//设置帮派id，必须为整型字符串
        gameRoleInfo.professionId = infolist[4];//设置角色职业id，必须为整型字符串
        gameRoleInfo.profession = infolist[5];//设置角色职业名称
        gameRoleInfo.partyRoleId = "0";//设置角色在帮派中的id
        gameRoleInfo.partyRoleName = "0"; //设置角色在帮派中的名称
        gameRoleInfo.friendlist = "无";//设置好友关系列表，格式请参考：http://open.quicksdk.net/help/detail/aid/190

        QuickSDK.getInstance().createRole(gameRoleInfo);//创建角色
    }


    /// <summary>
    /// 进入游戏时上传
    /// 登录完成之后，进入游戏时向渠道SDK上传角色信息
    /// </summary>
    public void onEnterGame(string info)
    {
        showLog("onEnterGame", info);
        string[] infolist = info.Split('_');

        QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_REAL_NAME_REGISTER);
        //注：GameRoleInfo的字段，如果游戏有的参数必须传，没有则不用传
        GameRoleInfo gameRoleInfo = new GameRoleInfo();

        gameRoleInfo.gameRoleBalance = "0";
        gameRoleInfo.gameRoleID = infolist[0];
        gameRoleInfo.gameRoleLevel = "1";
        gameRoleInfo.gameRoleName = infolist[1];
        gameRoleInfo.partyName = "同济会";
        gameRoleInfo.serverID = infolist[2];
        gameRoleInfo.serverName = infolist[3];
        gameRoleInfo.vipLevel = "1";
        gameRoleInfo.roleCreateTime = TimeHelper.ServerNow().ToString();//UC与1881渠道必传，值为10位数时间戳

        gameRoleInfo.gameRoleGender = "男";//360渠道参数
        gameRoleInfo.gameRolePower = "38";//360渠道参数，设置角色战力，必须为整型字符串
        gameRoleInfo.partyId = "0";//360渠道参数，设置帮派id，必须为整型字符串

        gameRoleInfo.professionId = infolist[4];//360渠道参数，设置角色职业id，必须为整型字符串
        gameRoleInfo.profession = infolist[5];//360渠道参数，设置角色职业名称
        gameRoleInfo.partyRoleId = "1";//360渠道参数，设置角色在帮派中的id
        gameRoleInfo.partyRoleName = "0"; //360渠道参数，设置角色在帮派中的名称
        gameRoleInfo.friendlist = "无";//360渠道参数，设置好友关系列表，格式请参考：http://open.quicksdk.net/help/detail/aid/190

        QuickSDK.getInstance().enterGame(gameRoleInfo);//开始游戏
    }

    /// <summary>
    ///  角色升级时上传, 角色升级时向渠道SDK上传角色信息
    ///  1) 在创建游戏角色、进入游戏和角色升级时候需要上传角色信息；
    ///  2) GameRoleInfo所有字段均不能传null，游戏没有的字段传一个默认值；
    ///  
    /// </summary>
    public void onUpdateRoleInfo(string info)
    {
        showLog("onUpdateRoleInfo", info);
        string[] infolist = info.Split('_');
        //注：GameRoleInfo的字段，如果游戏有的参数必须传，没有则不用传
        GameRoleInfo gameRoleInfo = new GameRoleInfo();

        gameRoleInfo.gameRoleBalance = "0";
        gameRoleInfo.gameRoleID = infolist[0];
        gameRoleInfo.gameRoleLevel = infolist[1];
        gameRoleInfo.gameRoleName = infolist[2];
        gameRoleInfo.partyName = "0";
        gameRoleInfo.serverID = infolist[3];
        gameRoleInfo.serverName = infolist[4];
        gameRoleInfo.vipLevel = "1";
        gameRoleInfo.roleCreateTime = TimeHelper.ServerNow().ToString();//UC与1881渠道必传，值为10位数时间戳

        gameRoleInfo.gameRoleGender = "男";//360渠道参数
        gameRoleInfo.gameRolePower = "38";//360渠道参数，设置角色战力，必须为整型字符串
        gameRoleInfo.partyId = "0";//360渠道参数，设置帮派id，必须为整型字符串

        gameRoleInfo.professionId = infolist[5];//360渠道参数，设置角色职业id，必须为整型字符串
        gameRoleInfo.profession = infolist[6];//360渠道参数，设置角色职业名称
        gameRoleInfo.partyRoleId = "0";//360渠道参数，设置角色在帮派中的id
        gameRoleInfo.partyRoleName = "0"; //360渠道参数，设置角色在帮派中的名称
        gameRoleInfo.friendlist = "无";//360渠道参数，设置好友关系列表，格式请参考：http://open.quicksdk.net/help/detail/aid/190

        QuickSDK.getInstance().updateRole(gameRoleInfo);


        showLog("test", "QuickSDK.getInstance().callExtendFunction(105);");
        QuickSDK.getInstance().callExtendFunction(105);
    }

    public void onNext()
    {
        Application.LoadLevel("scene3");




    }

    public void onCallFunctionWithParamTest()
    {
        //QuickSDK.getInstance().callFunctionWithParams(FuncType.QUICK_SDK_FUNC_TYPE_URL, "https://hotfix.public.manasisrefrain.com/Resources/GaCha/8003/8003.html");
    }

    /// <summary>
    ///  退出（必接）
    ///  退出游戏。需先通过isChannelHasExitDialog接口判断渠道是否有退出框，若渠道有退出框，直接调用QuickSDK的exit接口，若渠道没有退出框，则调用游戏自身的退出
    /// </summary>
    public void onExit()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        if (QuickSDK.getInstance().isChannelHasExitDialog())
        {
            QuickSDK.getInstance().exit();
        }
        else
        {
            //游戏调用自身的退出对话框，点击确定后，调用QuickSDK的exit()方法
            //mExitDialogCanvas.SetActive(true);
            // QuickSDK.getInstance().exit();
            Application.Quit();
        }
    }

    //退出游戏 【取消】
    public void onExitCancel()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        mExitDialogCanvas?.SetActive(false);
    }

    //退出游戏 【确定】
    public void onExitConfirm()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        mExitDialogCanvas?.SetActive(false);
        QuickSDK.getInstance().exit();
    }

    public void onShowToolbar()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().showToolBar(ToolbarPlace.QUICK_SDK_TOOLBAR_BOT_LEFT);
    }

    public void onHideToolbar()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().hideToolBar();
    }

    public void onEnterUserCenter()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_USER_CENTER);
    }

    public void onOpenFloatUserCenter()
    {
        QuickSDK.getInstance().openFloatUserCenter();
    }

    public void onEnterBBS()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_BBS);
    }
    public void onEnterCustomer()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_ENTER_CUSTOMER_CENTER);
    }
    public void onGetGoodsInfos()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        showLog("onGetGoodsInfos", "onGetGoodsInfos 方法已被调用");
        QuickSDK.getInstance().callFunction(FuncType.QUICK_SDK_FUNC_TYPE_QUERY_GOODS_INFO);
    }
    public void onUserId()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        string uid = QuickSDK.getInstance().userId();
        showLog("userId", uid);
    }

    public void ongetDeviceId()
    {
        if (!EventHandle.IsQudaoPackage())
            return;
        string deviceId = QuickSDK.getInstance().getDeviceId();
        showLog("deviceId", deviceId);
    }


    public static int onChannelType()
    {
#if QuDao
		return QuickSDK.getInstance().channelType();
#else
        return -1;
#endif
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
        if (!EventHandle.IsQudaoPackage())
            return;
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
        showLog("onInitSuccess", "onInitSuccess....QuickSDK");

        string channelid = EventHandle.onChannelType().ToString();
        this.ChannelId = channelid;

        onInitSuccessAction?.Invoke();
        //QuickSDK.getInstance ().login (); //如果游戏需要启动时登录，需要在初始化成功之后调用
        //如果游戏需要启动时登录，需要在初始化成功之后调用
    }

    public override void onInitFailed(ErrorMsg errMsg)
    {
        //初始化失败的回调
        showLog("onInitFailed", "msg: " + errMsg.errMsg);
    }

    public override void onLoginSuccess(UserInfo userInfo)
    {
        String code = QuickSDK.getInstance().callFunctionWithResult(0);
        int qudaotype = onChannelType();
        showLog("onLoginSuccess", "code: " + code + "uid: " + userInfo.uid + " ,username: " + userInfo.userName + " ,userToken: " + userInfo.token + ", msg: " + userInfo.errMsg + "  qudaotype" + qudaotype);


        //登录成功的回调
        //      if (EventHandle.IsHuiWeiChannel())
        //{
        //	onEnterGame($"{userInfo.uid}_{userInfo.userName}");
        //}
        //else
        //{
        //	//其他渠道不需要处理实名，直接返回
        //	onLoginSuccessAction?.Invoke();
        //}

        onLoginSuccessAction?.Invoke(userInfo.token, qudaotype + "_" + userInfo.uid);
    }

    public override void onSwitchAccountSuccess(UserInfo userInfo)
    {
        //切换账号成功，清除原来的角色信息，使用获取到新的用户信息，回到进入游戏的界面，不需要再次调登录
        // 切换账号成功的回调
        //一些渠道在悬浮框有切换账号的功能，此回调即切换成功后的回调。游戏应清除当前的游戏角色信息。在切换账号成功后回到选择服务器界面，请不要再次调用登录接口。
        showLog("onLoginSuccess", "uid: " + userInfo.uid + " ,username: " + userInfo.userName + " ,userToken: " + userInfo.token + ", msg: " + userInfo.errMsg);
        onSwitchAccountSuccessAction?.Invoke();
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
        showLog("onSucceed 222222", infos);

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

            //onLoginSuccessAction?.Invoke();
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
    public override void onPrivaceAgree()
    {
        QuickSDKImp.getInstance().init();
    }

    public override void onPrivaceRefuse()
    {
        showLog("onPrivaceRefuse", "onPrivaceRefuse");
    }

    public override void onCallbackSuccess(string msg)
    {
        showLog("onCallbackSuccess", msg);
    }

    public override void onCallbackFaild(string msg)
    {
        showLog("onCallbackFaild", msg);
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

    public static bool IsHuiWeiChannel()
    {
        return onChannelType() == (int)ChannelIdEnum.HuaWei;
    }

    public static bool IsQudaoPackage()
    {
        int type = onChannelType();
        return type >= 0;
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

}

