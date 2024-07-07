using System;
using TapTap.Login;
using TapTap.AntiAddiction;
using TapTap.AntiAddiction.Model;
using UnityEngine;
using ET;

public sealed class TapSDKV20Helper
{

    //ʵ����֤�ص�
    // code == 500;   // ���δ�ܵ����ƣ�����������Ϸ
    // code == 1000;  // �˳���������֤����飬�������ߵ��� Exit �ӿ�ʱ���û���֤��Ϣ��Чʱ��������ϷӦ���ص���¼ҳ
    // code == 1001;  // �û�����л��˺ţ���ϷӦ���ص���¼ҳ
    // code == 1030;  // �û���ǰʱ���޷�������Ϸ����ʱ�û�ֻ���˳���Ϸ���л��˺�
    // code == 1050;  // �û��޿���ʱ������ʱ�û�ֻ���˳���Ϸ���л��˺�
    // code == 1100;  // ��ǰ�û��򴥷�Ӧ�����õ����������޷�������Ϸ
    // code == 1200;  // ��������ʧ�ܣ���Ϸ���鵱ǰ���õ�Ӧ����Ϣ�Ƿ���ȷ���жϵ�ǰ���������Ƿ�����
    // code == 9002;  // ʵ�������е���˹ر�ʵ��������Ϸ�����¿�ʼ��������֤
    /// <summary>
    /// ʵ����֤�ص�
    /// </summary>
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

    /// <summary>
    /// ��Ϸʣ��ʱ��
    /// </summary>
    /// <returns></returns>
    public int GetRemainingTime()
    {
        return AntiAddictionUIKit.RemainingTime;
    }

    // ��Ϸ�� TapTap ���������Ķ�Ӧ�� Client ID
    private string clientId = ConfigHelper.clientId;

    // �Ƿ��ѳ�ʼ��
    private bool hasInit = false;

    // �Ƿ���ͨ���Ϲ���֤���
    public bool hasCheckedAntiAddiction { get; private set; }

    private static readonly Lazy<TapSDKV20Helper> lazy
    = new Lazy<TapSDKV20Helper>(() => new TapSDKV20Helper());

    public static TapSDKV20Helper Instance { get { return lazy.Value; } }


    private TapSDKV20Helper() { }

    /// <summary>
    /// ��ʼ����¼��Ϲ���֤ SDK 
    /// </summary>
    public void InitSDK()
    {
        if (!hasInit)
        {
            hasInit = true;

            // �����Ϲ���֤�ص�
            Action<int, string> AntiAddictionCallback = (code, errorMsg) =>
            {
                // ���ݻص����صĲ��� code ��Ӳ�ͬ����Ĵ���
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
        //string userIdentifier = SystemInfo.deviceUniqueIdentifier + timestart;
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