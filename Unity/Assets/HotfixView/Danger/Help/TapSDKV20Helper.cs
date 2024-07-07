using System;
using TapTap.Login;
using TapTap.AntiAddiction;
using TapTap.AntiAddiction.Model;
using UnityEngine;
using ET;

public sealed class TapSDKV20Helper
{

    //实名认证回调
    // code == 500;   // 玩家未受到限制，正常进入游戏
    // code == 1000;  // 退出防沉迷认证及检查，当开发者调用 Exit 接口时或用户认证信息无效时触发，游戏应返回到登录页
    // code == 1001;  // 用户点击切换账号，游戏应返回到登录页
    // code == 1030;  // 用户当前时间无法进行游戏，此时用户只能退出游戏或切换账号
    // code == 1050;  // 用户无可玩时长，此时用户只能退出游戏或切换账号
    // code == 1100;  // 当前用户因触发应用设置的年龄限制无法进入游戏
    // code == 1200;  // 数据请求失败，游戏需检查当前设置的应用信息是否正确及判断当前网络连接是否正常
    // code == 9002;  // 实名过程中点击了关闭实名窗，游戏可重新开始防沉迷认证
    /// <summary>
    /// 实名认证回调
    /// </summary>
    public Action<int, string> AntiAddictionHandler;

    /// <summary>
    /// 年龄段
    /// -1	未知
    ///0	0 到 7 岁
    ///8	8 到 15 岁
    ///16	16 到 17 岁
    ///18	成年玩家
    /// </summary>
    /// <returns></returns>
    public int GetAgeRange()
    {
        return AntiAddictionUIKit.AgeRange;
    }

    /// <summary>
    /// 游戏剩余时长
    /// </summary>
    /// <returns></returns>
    public int GetRemainingTime()
    {
        return AntiAddictionUIKit.RemainingTime;
    }

    // 游戏在 TapTap 开发者中心对应的 Client ID
    private string clientId = TapSDKHelper.clientId;

    // 是否已初始化
    private bool hasInit = false;

    // 是否已通过合规认证检查
    public bool hasCheckedAntiAddiction { get; private set; }

    private static readonly Lazy<TapSDKV20Helper> lazy
    = new Lazy<TapSDKV20Helper>(() => new TapSDKV20Helper());

    public static TapSDKV20Helper Instance { get { return lazy.Value; } }


    private TapSDKV20Helper() { }

    /// <summary>
    /// 初始化登录与合规认证 SDK 
    /// </summary>
    public void InitSDK()
    {
        if (!hasInit)
        {
            hasInit = true;

            // 声明合规认证回调
            Action<int, string> AntiAddictionCallback = (code, errorMsg) =>
            {
                // 根据回调返回的参数 code 添加不同情况的处理
                switch (code)
                {

                    case 500: // 玩家未受限制，可正常进入
                              // TODO: 显示开始游戏按钮      
                        break;

                    case 1000: // 防沉迷认证凭证无效时触发
                    case 1001: // 当玩家触发时长限制时，点击了拦截窗口中「切换账号」按钮
                    case 9002: // 实名认证过程中玩家关闭了实名窗口
                        TapLogin.Logout(); // 如果游戏有其他账户系统，此时也应执行退出
                                           // TODO: 切换到登录页面 例如：SceneManager.LoadScene("Login");
                        break;

                    case 1100: // 当前用户因触发应用设置的年龄限制无法进入游戏
                               // TODO: 游戏应自行绘制适龄限制提示，并引导玩家退出游戏
                        break;

                    case 1200: // 数据请求失败，应用信息错误或网络连接异常  
                               // TODO: 引导玩家确认网络连接是否正常，并重新调用开始认证接口
                        break;

                    default:
                        Debug.Log("其他可选回调");
                        break;
                }

                UnityEngine.Debug.LogFormat($"code: {code} error Message: {errorMsg}");

                UnityEngine.Debug.LogFormat($"ageRange: {AntiAddictionUIKit.AgeRange}");
                UnityEngine.Debug.LogFormat($"remainingTime: {AntiAddictionUIKit.RemainingTime}");

                if (AntiAddictionHandler != null)
                {
                    AntiAddictionHandler(code, errorMsg);
                }
            };

            // 定义合规认证模块 config
            AntiAddictionConfig config = new AntiAddictionConfig()
            {
                gameId = clientId,           // TapTap 开发者中心对应 Client ID
                showSwitchAccount = true,    // 是否显示切换账号按钮
                                             //useAgeRange = false          // 是否使用年龄段信息
            };

            // 初始化 TapTap 登录
            TapLogin.Init(clientId);

            //初始化防沉迷 UI 模块，包括设置启动防沉迷功能的配置、注册防沉迷的消息监听。
            AntiAddictionUIKit.Init(config, AntiAddictionCallback);

            // 如果是 PC 平台还需要额外设置一下 gameId
            TapTap.AntiAddiction.TapTapAntiAddictionManager.AntiAddictionConfig.gameId = clientId;
        }


    }

    /// <summary>
    /// taptap实名认证
    /// </summary>
    public void RealNameAuther(string userid)
    {

        InitSDK();

        ///System.Guid.NewGuid();  系统方法生成唯一id
        // 注意唯一标识参数值长度不能超过 64 字符
        //int timestart = (int)Time.time;
        //string userIdentifier = SystemInfo.deviceUniqueIdentifier + timestart;
        AntiAddictionUIKit.Startup(userid);
    }

    /// <summary>
    /// 开始合规认证检查
    /// </summary>
    /// <param name="userIdentifier">用户唯一标识</param>
    public void StartAntiAddiction(string userIdentifier)
    {
        hasCheckedAntiAddiction = false;
        //AntiAddictionUIKit.StartupWithTapTap(userIdentifier);
    }
}