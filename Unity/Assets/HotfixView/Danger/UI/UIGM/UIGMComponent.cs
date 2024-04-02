using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UIGMComponent : Entity, IAwake
    {
        public GameObject InputField_Common;
        public GameObject Button_Common;
        public GameObject InputField_ReLoadValue;
        public GameObject Button_ReLoad;
        public GameObject InputField_Broadcast;
        public GameObject InputField_EmailItem;
        public GameObject Button_Broadcast_1;
        public GameObject Button_Broadcast_2;
        public GameObject Button_Email;

        public GameObject Button_Close;
        public GameObject Text_OnLineNumber;
    }

    public class UIGMComponentAwakeSystem : AwakeSystem<UIGMComponent>
    {
        public override void Awake(UIGMComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_ReLoad = rc.Get<GameObject>("Button_ReLoad");
            self.InputField_Broadcast = rc.Get<GameObject>("InputField_Broadcast");
            self.InputField_EmailItem = rc.Get<GameObject>("InputField_EmailItem");

            self.InputField_ReLoadValue = rc.Get<GameObject>("InputField_ReLoadValue");
            self.Button_Broadcast_1 = rc.Get<GameObject>("Button_Broadcast_1");
            self.Button_Broadcast_1.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Broadcast_1(0).Coroutine(); });
            self.Button_Broadcast_2 = rc.Get<GameObject>("Button_Broadcast_2");
            self.Button_Broadcast_2.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Broadcast_1(1).Coroutine(); });

            self.Button_Email = rc.Get<GameObject>("Button_Email");
            self.Button_Email.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Email().Coroutine(); });

            self.Button_Close = rc.Get<GameObject>("Button_Close");
            self.Text_OnLineNumber = rc.Get<GameObject>("Text_OnLineNumber");
         
            self.Button_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Close(); });
            self.Button_ReLoad.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_ReLoad().Coroutine(); });

            self.InputField_Common = rc.Get<GameObject>("InputField_Common");
            self.Button_Common = rc.Get<GameObject>("Button_Common");
            self.Button_Common.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Common().Coroutine(); });
            self.Text_OnLineNumber.GetComponent<Text>().text = string.Empty;
            self.RequestGMInfo().Coroutine();
        }
    }

    public static class UIGMComponentSystem
    {

        /// <summary>
        /// boradType 0全服广播  1本服广播
        /// </summary>
        /// <param name="self"></param>
        /// <param name="boradType"></param>
        /// <returns></returns>
        public static async ETTask OnButton_Broadcast_1(this UIGMComponent self,int boradType)
        {
            if (self.InputField_Broadcast.GetComponent<InputField>().text.Length == 0)
            {
                return;
            }

            C2C_SendBroadcastRequest c2S_SendChatRequest = new C2C_SendBroadcastRequest() { ZoneType = boradType };
            c2S_SendChatRequest.ChatInfo = new ChatInfo();
            c2S_SendChatRequest.ChatInfo.ChatMsg = self.InputField_Broadcast.GetComponent<InputField>().text;
            C2C_SendBroadcastResponse sendChatResponse = (C2C_SendBroadcastResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2S_SendChatRequest);
        }

        public static async ETTask OnButton_Email(this UIGMComponent self)
        {
            string itemlist = self.InputField_EmailItem.GetComponent<InputField>().text;
            if (string.IsNullOrEmpty(itemlist))
            {
                FloatTipManager.Instance.ShowFloatTip("输入不能为空！");
                return;
            }
            
            C2E_GMEMailRequest c2E_GetAllMailRequest = new C2E_GMEMailRequest() { MailInfo = itemlist };
            E2C_GMEMailResponse sendChatResponse = (E2C_GMEMailResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);
            if (sendChatResponse.Error == ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("邮件发送成功！");
            }
        }

        public static void OnButton_Close(this UIGMComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UIGM );
        }

        public static async ETTask OnButton_Common(this UIGMComponent self)
        {
            string content = self.InputField_Common.GetComponent<InputField>().text;
            if (content.Length < 1)
            {
                return;
            }

            C2C_GMCommonRequest request = new C2C_GMCommonRequest() 
            {
                Account = self.ZoneScene().GetComponent<AccountInfoComponent>().Account,
                Context = content
            };
            C2C_GMCommonResponse repose = (C2C_GMCommonResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }

        public static async ETTask OnButton_ReLoad(this UIGMComponent self)
        {
            string reload = self.InputField_ReLoadValue.GetComponent<InputField>().text;
            if (reload.Length < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("请输入热重载类型！");
                return;
            }

            Session session = self.ZoneScene().GetComponent<SessionComponent>().Session;
            G2C_Reload m2C_Reload = await session.Call(new C2G_Reload()
            {
                Account = self.ZoneScene().GetComponent<AccountInfoComponent>().Account,
                LoadValue = reload
            }) as G2C_Reload;
        }

        public static async ETTask RequestGMInfo(this UIGMComponent self)
        {
            long instanceid = self.InstanceId;
            C2C_GMInfoRequest c2E_GetAllMailRequest = new C2C_GMInfoRequest() { Account = self.ZoneScene().GetComponent<AccountInfoComponent>().Account };
            C2C_GMInfoResponse sendChatResponse = (C2C_GMInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);
            if (instanceid == self.InstanceId )
            {
                return;
            }

            if (sendChatResponse.Error == 0)
            {
                self.Text_OnLineNumber.GetComponent<Text>().text = $"玩家:{sendChatResponse.OnLineNumber}机器人:{sendChatResponse.OnLineRobot}";
            }
            else
            {
                self.OnButton_Close();
            }
        }
    }
}
