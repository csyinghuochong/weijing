using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMailComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonOneKey;
        public GameObject ButtonGet;
        public GameObject MailListNode;
        public GameObject Btn_Close;
        public GameObject RewardList;
        public GameObject MailContent;
        public GameObject TextMailTitle;
        public GameObject TextMailContent;
        public GameObject Obj_MailContent;
        public GameObject Obj_NoMail;

        public MailComponent MailComponent;
        public List<UIMailItemComponent> MailListUI = new List<UIMailItemComponent>();
        public List<UIItemComponent> RewardListUI = new List<UIItemComponent>();
    }


    public class UIMailComponentAwakeSystem : AwakeSystem<UIMailComponent>
    {
        public override void Awake(UIMailComponent self)
        {
            self.MailListUI.Clear();
            self.RewardListUI.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.MailListNode = rc.Get<GameObject>("MailListNode");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.RewardList = rc.Get<GameObject>("RewardList");
            self.MailContent = rc.Get<GameObject>("MailContent");
            self.TextMailTitle = rc.Get<GameObject>("TextMailTitle");
            self.TextMailContent = rc.Get<GameObject>("TextMailContent");
            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            self.Obj_MailContent = rc.Get<GameObject>("MailContent");
            self.Obj_NoMail = rc.Get<GameObject>("NoMail");
            self.ButtonOneKey = rc.Get<GameObject>("ButtonOneKey");

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseMail(); });
            ButtonHelp.AddListenerEx(self.ButtonGet, self.OnButtonGet);

            ButtonHelp.AddListenerEx(self.ButtonOneKey, () => { self.OnButtonOneKey().Coroutine(); });

            self.MailComponent = self.ZoneScene().GetComponent<MailComponent>();

            DataUpdateComponent.Instance.AddListener(DataType.OnMailUpdate, self);
            self.RequestMaiList();
        }
    }


    public class UIMailComponentDestroySystem : DestroySystem<UIMailComponent>
    {
        public override void Destroy(UIMailComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.OnMailUpdate, self);
        }
    }

    public static class UIMailComponentSystem
    {
        public static void OnCloseMail(this UIMailComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIMail);
        }

        public static void  RequestMaiList(this UIMailComponent self)
        {
            self.MailComponent.SendGetMailList().Coroutine();
            NetHelper.SendReddotRead(self.ZoneScene(), ReddotType.Email).Coroutine();
        }

        public static void OnButtonGet(this UIMailComponent self)
        {
            self.MailComponent.SendReceiveMail().Coroutine();
        }

        public static async ETTask OnButtonOneKey(this UIMailComponent self)
        {
            long instanceid = self.InstanceId;
            while(self.MailComponent.MailInfoList.Count > 0)
            {
                int errorCode = await self.MailComponent.SendReceiveMail();
                if (errorCode != 0)
                {
                    break;
                }
                if (instanceid != self.InstanceId)
                {
                    break;
                }
            }
        }

        public static void OnSelectMail(this UIMailComponent self)
        {
            self.UpdateMailSelected();
            self.UpdateMailContent();
        }

        public static void UpdateMailSelected(this UIMailComponent self)
        {
            if (self.MailComponent.SelectMail == null)
            {
                self.MailContent.SetActive(false);
                self.Obj_NoMail.SetActive(true);
                return;
            }
            self.MailContent.SetActive(true);
            self.Obj_NoMail.SetActive(false);

            for (int I = 0; I < self.MailListUI.Count; I++)
            {
                self.MailListUI[I].SetSelected(self.MailComponent.SelectMail);
            }
        }

        public static  void UpdateMailContent(this UIMailComponent self)
        {
            for (int i = 0; i < self.RewardListUI.Count; i++)
            {
                self.RewardListUI[i].GameObject.SetActive(false);
            }
            MailInfo mailInfos = self.MailComponent.SelectMail;
            self.TextMailTitle.GetComponent<Text>().text = mailInfos.Title;
            self.TextMailContent.GetComponent<Text>().text = mailInfos.Context;

            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < mailInfos.ItemList.Count; i++)
            {
                UIItemComponent ui_2 = null;
                if (i < self.RewardListUI.Count)
                {
                    ui_2 = self.RewardListUI[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.RewardList);
                    ui_2 = self.AddChild<UIItemComponent, GameObject>( itemSpace);
                    self.RewardListUI.Add(ui_2);
                }
                ui_2.UpdateItem(mailInfos.ItemList[i], ItemOperateEnum.MailReward);
            }
        }

        public static  void OnMailUpdate(this UIMailComponent self)
        {
            for (int I = 0; I < self.MailListUI.Count; I++)
            {
                self.MailListUI[I].GameObject.SetActive(false);
                self.MailListUI[I].ResetUI();
            }

            //增删改
            List<MailInfo> mailInfos = self.MailComponent.MailInfoList;
            if (mailInfos.Count == 0)
            {
                self.MailComponent.SelectMail = null;
                self.MailContent.SetActive(false);
                self.Obj_NoMail.SetActive(true);
                return;
            }
            self.MailContent.SetActive(true);
            self.Obj_NoMail.SetActive(false);

            GameObject mailItem =ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetUGUIPath("Main/Mail/UIMailItem"));
            for (int i = 0; i < mailInfos.Count; i++)
            {
                UIMailItemComponent ui_2 = null;
                if (i < self.MailListUI.Count)
                {
                    ui_2 = self.MailListUI[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(mailItem);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.MailListNode);
                    ui_2 = self.AddChild<UIMailItemComponent, GameObject>(itemSpace);
                    ui_2.SetClickHandler(() => { self.OnSelectMail(); });
                    self.MailListUI.Add(ui_2);
                }
                ui_2.OnUpdateUI(mailInfos[i]);
            }

            self.MailComponent.SelectMail = mailInfos[0];
            self.OnSelectMail();
        }

    }

}
