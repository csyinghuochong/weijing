using System;
using TapTap.Login;
using TapTap.AntiAddiction;
using TapTap.AntiAddiction.Model;
using UnityEngine;
using ET;

public sealed class TapSDKV20Helper
{

    //500	LOGIN_SUCCESS 玩家未受到限制，正常进入游戏
    //1000	EXITED 退出防沉迷认证及检查，当开发者调用 Exit 接口时或用户认证信息无效时触发，游戏应返回到登录页
    //1001	SWITCH_ACCOUNT 用户点击切换账号，游戏应返回到登录页
    //1030	PERIOD_RESTRICT 用户当前时间无法进行游戏，此时用户只能退出游戏或切换账号
    //1050	DURATION_LIMIT 用户无可玩时长，此时用户只能退出游戏或切换账号
    //1100	AGE_LIMIT 当前用户因触发应用设置的年龄限制无法进入游戏
    //1200	INVALID_CLIENT_OR_NETWORK_ERROR 数据请求失败，游戏需检查当前设置的应用信息是否正确及判断当前网络连接是否正常
    //9002	REAL_NAME_STOP 实名过程中点击了关闭实名窗，游戏可重新开始防沉迷认证

    public Action<int, string> AntiAddictionHandler;

    /// <summary>
    /// �����
    /// -1	δ֪
    ///0	0 �� 7 ��
    ///8	8 �� 15 ��
    ///16	16 �� 17 ��
    ///18	�������
    /// </summary>
    /// <returns></returns>
    public int GetAgeRange()
    {
        return AntiAddictionUIKit.AgeRange;
    }


    public int GetRemainingTime()
    {
        return AntiAddictionUIKit.RemainingTime;
    }

    private string clientId = ConfigHelper.clientId;


    private bool hasInit = false;


    public bool hasCheckedAntiAddiction { get; private set; }

    private static readonly Lazy<TapSDKV20Helper> lazy
    = new Lazy<TapSDKV20Helper>(() => new TapSDKV20Helper());

    public static TapSDKV20Helper Instance { get { return lazy.Value; } }


    private TapSDKV20Helper() { }


    public void InitSDK()
    {
        if (!hasInit)
        {
            hasInit = true;


            Action<int, string> AntiAddictionCallback = (code, errorMsg) =>
            {
               
                switch (code)
                {

                    case 500: // ���δ�����ƣ�����������
                              // TODO: ��ʾ��ʼ��Ϸ��ť      
                        break;

                    case 1000: // ��������֤ƾ֤��Чʱ����
                    case 1001: // ����Ҵ���ʱ������ʱ����������ش����С��л��˺š���ť
                    case 9002: // ʵ����֤��������ҹر���ʵ������
                        TapLogin.Logout(); // �����Ϸ�������˻�ϵͳ����ʱҲӦִ���˳�
                                           // TODO: �л�����¼ҳ�� ���磺SceneManager.LoadScene("Login");
                        break;

                    case 1100: // ��ǰ�û��򴥷�Ӧ�����õ����������޷�������Ϸ
                               // TODO: ��ϷӦ���л�������������ʾ������������˳���Ϸ
                        break;

                    case 1200: // ��������ʧ�ܣ�Ӧ����Ϣ��������������쳣  
                               // TODO: �������ȷ�����������Ƿ������������µ��ÿ�ʼ��֤�ӿ�
                        break;

                    default:
                        Debug.Log("������ѡ�ص�");
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

            // ����Ϲ���֤ģ�� config
            AntiAddictionConfig config = new AntiAddictionConfig()
            {
                gameId = clientId,           // TapTap ���������Ķ�Ӧ Client ID
                showSwitchAccount = true,    // �Ƿ���ʾ�л��˺Ű�ť
                                             //useAgeRange = false          // �Ƿ�ʹ���������Ϣ
            };

            // ��ʼ�� TapTap ��¼
            TapLogin.Init(clientId);

            //��ʼ�������� UI ģ�飬����������������Թ��ܵ����á�ע������Ե���Ϣ������
            AntiAddictionUIKit.Init(config, AntiAddictionCallback);

            // ����� PC ƽ̨����Ҫ��������һ�� gameId
            TapTap.AntiAddiction.TapTapAntiAddictionManager.AntiAddictionConfig.gameId = clientId;
        }


    }

    /// <summary>
    /// taptapʵ����֤
    /// </summary>
    public void RealNameAuther(string userid)
    {

        InitSDK();

        ///System.Guid.NewGuid();  ϵͳ��������Ψһid
        // ע��Ψһ��ʶ����ֵ���Ȳ��ܳ��� 64 �ַ�
        //int timestart = (int)Time.time;
        AntiAddictionUIKit.Startup(userid);
    }

    /// <summary>
    /// ��ʼ�Ϲ���֤���
    /// </summary>
    /// <param name="userIdentifier">�û�Ψһ��ʶ</param>
    public void StartAntiAddiction(string userIdentifier)
    {
        hasCheckedAntiAddiction = false;
        //AntiAddictionUIKit.StartupWithTapTap(userIdentifier);
    }




}