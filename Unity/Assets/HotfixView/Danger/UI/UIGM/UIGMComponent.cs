using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UIGMComponent : Entity, IAwake
    {

        public GameObject InputField_ReLoadValue;
        public GameObject InputField_ReLoadType;
        public GameObject Button_ServerClose;
        public GameObject Button_ReLoad;
        public GameObject InputField_Broadcast;
        public GameObject InputField_EmailTitle;
        public GameObject InputField_EmailContent;
        public GameObject InputField_EmailItem;
        public GameObject Button_Broadcast;
        public GameObject Button_Email;

        public GameObject Button_Close;
        public GameObject Text_OnLineNumber;
    }


    [ObjectSystem]
    public class UIGMComponentAwakeSystem : AwakeSystem<UIGMComponent>
    {
        public override void Awake(UIGMComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_ServerClose = rc.Get<GameObject>("Button_ServerClose");
            ButtonHelp.AddListenerEx( self.Button_ServerClose, () => { self.OnButton_ServerClose().Coroutine();  } );

            self.Button_ReLoad = rc.Get<GameObject>("Button_ReLoad");
            self.InputField_Broadcast = rc.Get<GameObject>("InputField_Broadcast");
            self.InputField_EmailTitle = rc.Get<GameObject>("InputField_EmailTitle");
            self.InputField_EmailContent = rc.Get<GameObject>("InputField_EmailContent");
            self.InputField_EmailItem = rc.Get<GameObject>("InputField_EmailItem");

            self.InputField_ReLoadValue = rc.Get<GameObject>("InputField_ReLoadValue");
            self.InputField_ReLoadType = rc.Get<GameObject>("InputField_ReLoadType");

            self.Button_Broadcast = rc.Get<GameObject>("Button_Broadcast");
            self.Button_Broadcast.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Broadcast().Coroutine(); });
            self.Button_Email = rc.Get<GameObject>("Button_Email");
            self.Button_Email.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Email().Coroutine(); });

            self.Button_Close = rc.Get<GameObject>("Button_Close");
            self.Text_OnLineNumber = rc.Get<GameObject>("Text_OnLineNumber");
         
            self.Button_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Close(); });
            self.Button_ReLoad.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_ReLoad().Coroutine(); });

            self.RequestGMInfo().Coroutine();
        }
    }

    public static class UIGMComponentSystem
    {

        public static async ETTask OnButton_Broadcast(this UIGMComponent self)
        {
            C2C_GMBroadcastRequest c2S_SendChatRequest = new C2C_GMBroadcastRequest() { NoticeText = self.InputField_Broadcast.GetComponent<InputField>().text };
            C2C_GMBroadcastResponse sendChatResponse = (C2C_GMBroadcastResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2S_SendChatRequest);
        }

        public static async ETTask OnButton_Email(this UIGMComponent self)
        {
            MailInfo mailInfo = new MailInfo();

            mailInfo.Title = self.InputField_EmailTitle.GetComponent<InputField>().text;
            mailInfo.Context = self.InputField_EmailContent.GetComponent<InputField>().text;

            List<BagInfo> rewardItems = new List<BagInfo>();
            string[] itemlist = self.InputField_EmailItem.GetComponent<InputField>().text.Split('@');
            for (int i = 0; i < itemlist.Length; i++)
            {
                string[] itemInfo = itemlist[i].Split(';');
                if (itemInfo.Length < 2)
                {
                    continue;
                }
                rewardItems.Add(new BagInfo() { ItemID = int.Parse(itemInfo[0]), ItemNum = int.Parse(itemInfo[1]) } );
            }
            mailInfo.ItemList = rewardItems;

            C2E_GMEMailRequest c2E_GetAllMailRequest = new C2E_GMEMailRequest() { MailInfo = mailInfo };
            E2C_GMEMailResponse sendChatResponse = (E2C_GMEMailResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);
        }

        public static void OnButton_Close(this UIGMComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UIGM );
        }

        public static async ETTask OnButton_ReLoad(this UIGMComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            NetKcpComponent netKcpComponent = zoneScene.GetComponent<NetKcpComponent>();
            Init init = GameObject.Find("Global").GetComponent<Init>();
            string ip = init.OueNetMode ? "39.96.194.143:20105" : "127.0.0.1:20105";

            if (self.InputField_ReLoadType.GetComponent<InputField>().text.Length == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请输入热重载类型！");
                return;
            }
            int loadType = int.Parse(self.InputField_ReLoadType.GetComponent<InputField>().text);
            string loadValue = self.InputField_ReLoadType.GetComponent<InputField>().text;
            Session session = netKcpComponent.Create(NetworkHelper.ToIPEndPoint(ip));
            {
                M2C_Reload m2C_Reload = await session.Call(new C2M_Reload() {
                    Account = "tcg", Password = "tcg" ,
                    LoadType = loadType,
                    LoadValue = loadValue
                }) as M2C_Reload;
            }
            session.Dispose();
            //self.ZoneScene().GetComponent<SessionComponent>().Session.Call(new C2M_Reload() { Account = "tcg", Password = "tcg" }) as M2C_Reload;
        }

        public static async ETTask OnButton_ServerClose(this UIGMComponent self)
        {
            Session session = self.DomainScene().GetComponent<SessionComponent>().Session;
            {
                M2C_ServerStop m2C_Reload = await session.Call(new C2M_ServerStop() { Account = "tcg", Password = "tcg" }) as M2C_ServerStop;
            }
            session.Dispose();
            await ETTask.CompletedTask;
        }

        public static async ETTask RequestGMInfo(this UIGMComponent self)
        {
            C2C_GMInfoRequest c2E_GetAllMailRequest = new C2C_GMInfoRequest() { UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId };
            C2C_GMInfoResponse sendChatResponse = (C2C_GMInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);

            if (sendChatResponse.Error == 0)
            {
                self.Text_OnLineNumber.GetComponent<Text>().text = sendChatResponse.OnLineNumber.ToString();
            }
            else
            {
                self.OnButton_Close();
            }
        }
    }
}
