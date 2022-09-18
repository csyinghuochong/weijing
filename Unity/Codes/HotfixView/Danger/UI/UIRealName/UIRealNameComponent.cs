using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIRealNameComponent : Entity, IAwake
    {

        public GameObject Btn_FangChenMiTip;
        public GameObject Btn_ReadOk;
        public GameObject FangChenMiTip;
        public GameObject Btn_RealNameed;
        public GameObject Btn_Received;
        public GameObject Btn_Close;
        public GameObject ReardListNode;
        public GameObject Btn_RealName;
        public GameObject Btn_GetRewards;
        public GameObject InputFieldIDCard;
        public GameObject InputFieldName;
        public GameObject FangChenMiSet;

        public AccountInfoComponent PlayerComponent;

        public long AccountId;
        public float LoginTime;
    }

    [ObjectSystem]
    public class UIRealNameComponentAwakeSystem : AwakeSystem<UIRealNameComponent>
    {

        public override void Awake(UIRealNameComponent self)
        {
            self.LoginTime = 0f;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.Btn_RealName = rc.Get<GameObject>("Btn_RealName");
            self.Btn_RealName.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_RealName().Coroutine(); });

            self.Btn_GetRewards = rc.Get<GameObject>("Btn_GetRewards");
            self.Btn_GetRewards.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_GetRewards().Coroutine(); });

            self.InputFieldName = rc.Get<GameObject>("InputFieldName");
            self.InputFieldIDCard = rc.Get<GameObject>("InputFieldIDCard");

            self.Btn_Received = rc.Get<GameObject>("Btn_Received");
            self.ReardListNode = rc.Get<GameObject>("ReardListNode");
            self.Btn_RealNameed = rc.Get<GameObject>("Btn_RealNameed");

            self.Btn_ReadOk = rc.Get<GameObject>("Btn_ReadOk");
            self.Btn_ReadOk.GetComponent<Button>().onClick.AddListener(() => { self.ShowTips(false); });
            self.FangChenMiTip = rc.Get<GameObject>("FangChenMiTip");
            self.FangChenMiTip.SetActive(false);

            self.Btn_FangChenMiTip = rc.Get<GameObject>("Btn_FangChenMiTip");
            self.Btn_FangChenMiTip.GetComponent<Button>().onClick.AddListener(() => { self.ShowTips(true); });

            self.FangChenMiSet = rc.Get<GameObject>("FangChenMiSet");

            self.InitRewards();
            //self.OnUpdateUI();
            self.Btn_Received.SetActive(false);
            self.Btn_RealNameed.SetActive(false);

            self.PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();
        }
    }

    public static class UIRealNameComponentSystem
    {

        public static void InitRewards(this UIRealNameComponent self)
        {
            /*
            string globalValueConfig = GlobalValueConfigCategory.Instance.Get(6).Value;
            string[] itemCost = globalValueConfig.Split('@');

            string path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < itemCost.Length; i++)
            {
                string[] itemInfo = itemCost[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);

                GameObject skillItem = GameObject.Instantiate(bundleObj);
                CommonHelper.SetParent(skillItem, self.ReardListNode);
                UI ui_1 = self.AddChild<UI, string, GameObject>(self, "rewardItem_" + i.ToString(), skillItem);
                UIItemComponent uIItemComponent = ui_1.AddComponent<UIItemComponent>();
                uIItemComponent.UpdateItem(new BagInfo() {  ItemID = itemId, ItemNum = itemNum }, ItemOperateEnum.MailReward);
            }
            */
        }

        public static void OnUpdateUI(this UIRealNameComponent self)
        {
            self.Btn_GetRewards.SetActive(self.PlayerComponent.PlayerInfo.RealName == 1&& self.PlayerComponent.PlayerInfo.RealNameReward==0);
            self.Btn_Received.SetActive(self.PlayerComponent.PlayerInfo.RealNameReward == 1);
            self.Btn_RealNameed.SetActive(self.PlayerComponent.PlayerInfo.RealName == 1);
            self.Btn_RealName.SetActive(self.PlayerComponent.PlayerInfo.RealName == 0);
        }

        public static void OnBtn_Close(this UIRealNameComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIRealName);
        }


        public static async ETTask OnBtn_RealName(this UIRealNameComponent self)
        {
            string name = self.InputFieldName.GetComponent<InputField>().text;
            string idno = self.InputFieldIDCard.GetComponent<InputField>().text;

            UI uilogin = UIHelper.GetUI(self.DomainScene(), UIType.UILogin);
            uilogin.GetComponent<UILoginComponent>().LastLoginTime = 0;
            bool sucess =  await LoginHelper.RealName(self.DomainScene(), uilogin.GetComponent<UILoginComponent>().ServerInfo.ServerIp, self.AccountId,  name, idno);

            if (!sucess)
            {
                FloatTipManager.Instance.ShowFloatTip("实名认证失败!");
                return;
            }
            self.LoginTime = 0f;
            PopupTipHelp.OpenPopupTip_2(self.ZoneScene(), "认证提示", "实名认证成功!",
                () =>
                {
                    self.SendRealName();
                }).Coroutine();
        }

        public static void SendRealName(this UIRealNameComponent self)
        {
            if (Time.time - self.LoginTime < 10f)
            {
                return;
            }
            self.LoginTime = Time.time;
            //AccountInfoComponent PlayerComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            //await LoginHelper.Login(
            //    self.DomainScene(),
            //    PlayerComponent.ServerIp,
            //    PlayerComponent.Account,
            //    PlayerComponent.Password);
            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UILogin);
            uI.GetComponent<UILoginComponent>().OnReLogin();
            UIHelper.Remove(self.DomainScene(), UIType.UIRealName);
        }

        public static async ETTask OnBtn_RealName_2(this UIRealNameComponent self)
        {
            await ETTask.CompletedTask;
            string name = self.InputFieldName.GetComponent<InputField>().text;
            string idno = self.InputFieldIDCard.GetComponent<InputField>().text;

            self.PlayerComponent.PlayerInfo.RealName = 1;
            self.OnUpdateUI();
        }

        public static async ETTask OnBtn_GetRewards(this UIRealNameComponent self)
        {
            C2M_RealNameRewardRequest c2E_GetAllMailRequest = new C2M_RealNameRewardRequest() {  ActorId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId };
            M2C_RealNameRewardResponse sendChatResponse = (M2C_RealNameRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);
            if (sendChatResponse.Error != 0)
            {
                FloatTipManager.Instance.ShowFloatTipDi("背包已满!");
                return;
            }
            self.PlayerComponent.PlayerInfo.RealNameReward = 1;
            self.OnUpdateUI();
        }

        public static void ShowTips(this UIRealNameComponent self,bool ifShow) {
            if (ifShow)
            {
                self.FangChenMiSet.SetActive(false);
                self.FangChenMiTip.SetActive(true);
            }
            else {
                self.FangChenMiSet.SetActive(true);
                self.FangChenMiTip.SetActive(false);
            }

        }

    }

}
