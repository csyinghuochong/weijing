using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPhoneCodeComponent : Entity, IAwake
    {
        public GameObject ButtonGetCode;
        public GameObject ButtonCommitCode;
        public GameObject TextPhoneCode;

        public GameObject TextYanzheng;
        public GameObject PhoneNumber;
        public GameObject YanZheng;
        public GameObject SendYanzheng;
        public GameObject ImageClose;
    }

    [ObjectSystem]
    public class UIPhoneCodeComponentAwake : AwakeSystem<UIPhoneCodeComponent>
    {
        public override void Awake(UIPhoneCodeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPhoneCode); } );
       
            self.YanZheng = rc.Get<GameObject>("YanZheng");         //提交
            self.YanZheng.SetActive(false);

            self.SendYanzheng = rc.Get<GameObject>("SendYanzheng"); //获取
            self.SendYanzheng.SetActive(true);

            self.PhoneNumber = rc.Get<GameObject>("PhoneNumber");
            self.TextYanzheng= rc.Get<GameObject>("TextYanzheng");

            self.ButtonCommitCode = rc.Get<GameObject>("ButtonCommitCode");
            ButtonHelp.AddListenerEx(self.ButtonCommitCode, self.OnButtonCommitCode);

            self.ButtonGetCode = rc.Get<GameObject>("ButtonGetCode");
            ButtonHelp.AddListenerEx(self.ButtonGetCode, self.OnButtonGetCode);

            self.TextPhoneCode = rc.Get<GameObject>("TextPhoneCode");

            GameObject.Find("Global").GetComponent<SMSSDemo>().CommitCodeSucessHandler = (string text) => { self.OnCommitCodeHandler(text); };
        }
    }

    public static class UIPhoneCodeComponentSystem
    {

        public static void OnButtonGetCode(this UIPhoneCodeComponent self)
        {
            string phoneNum = self.PhoneNumber.GetComponent<InputField>().text;
            GlobalHelp.OnButtonGetCode(phoneNum);
            self.TextYanzheng.GetComponent<Text>().text = $"已向手机号{phoneNum}发送短信验证";
            self.SendYanzheng.SetActive(false);
            self.YanZheng.SetActive(true);
        }

        public static void OnButtonCommitCode(this UIPhoneCodeComponent self)
        {
            GlobalHelp.OnButtonCommbitCode(self.TextPhoneCode.GetComponent<InputField>().text);
        }

        public static void OnSendYanzheng(this UIPhoneCodeComponent self)
        {
            string phoneNum = self.PhoneNumber.GetComponent<InputField>().text;
            GlobalHelp.OnButtonGetCode(phoneNum);
            self.TextYanzheng.GetComponent<Text>().text = $"已向手机号{phoneNum}发送短信验证";
            self.SendYanzheng.SetActive(false);
            self.YanZheng.SetActive(true);
        }

        public static void OnCommitCodeHandler(this UIPhoneCodeComponent self, string phone)
        {
            Log.Debug($"OnCommitCodeHandler : {phone}");
        }

        public static async ETTask OnRquestBingPhone(this UIPhoneCodeComponent self, string phone)
        {
            VersionMode versionCode = GlobalHelp.VersionMode;
            IPAddress[] xxc = Dns.GetHostEntry("weijinggame.weijinggame.com").AddressList;
            //走的中心服
            string address = GlobalHelp.IsOutNetMode ? $"{xxc[0]}:{LoginHelper.GetAccountCenterPort(versionCode)}" : $"127.0.0.1:{LoginHelper.GetAccountCenterPort(versionCode)}";
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            Scene zoneScene = self.ZoneScene();
            NetKcpComponent netKcpComponent = zoneScene.GetComponent<NetKcpComponent>();
            Session session = netKcpComponent.Create(NetworkHelper.ToIPEndPoint(address));
            {
                Center2C_PhoneBinging m2C_Reload = await session.Call(new C2Center_PhoneBinging()
                {
                    
                }) as Center2C_PhoneBinging;
            }
            session.Dispose();
        }
    }
}
