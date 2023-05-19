using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMysteryComponent : Entity, IAwake, IDestroy
    {
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;
        public GameObject Text_CDTime;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UIJiaYuanMysteryItemComponent> SellList = new List<UIJiaYuanMysteryItemComponent>();
    }



    public class UIJiaYuanMysteryComponentAwake : AwakeSystem<UIJiaYuanMysteryComponent>
    {

        public override void Awake(UIJiaYuanMysteryComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStore(); });

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.Text_CDTime = rc.Get<GameObject>("Text_CDTime");
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.InitModelShowView().Coroutine();
            self.RequestMystery().Coroutine();
            self.ShowCDTime().Coroutine();
        }
    }

    public static class UIJiaYuanMysteryComponentSystem
    {
        public static async ETTask InitModelShowView(this UIJiaYuanMysteryComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(UIHelper.CurrentNpcId);
            self.uIModelShowComponent.ShowOtherModel("Npc/" + npcConfig.Asset.ToString()).Coroutine();
        }

        public static void OnCloseStore(this UIJiaYuanMysteryComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanMystery);
        }

        public static async ETTask UpdateMysteryItem(this UIJiaYuanMysteryComponent self, List<MysteryItemInfo> mysteryItemInfos)
        {
            string path_1 = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanMysteryItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path_1);

            int number = 0;
            for (int i = 0; i < mysteryItemInfos.Count; i++)
            {
                if (mysteryItemInfos[i].ItemNumber <= 0)
                {
                    continue;
                }

                UIJiaYuanMysteryItemComponent ui_1 = null;
                if (number < self.SellList.Count)
                {
                    ui_1 = self.SellList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UIJiaYuanMysteryItemComponent, GameObject>(storeItem);
                    self.SellList.Add(ui_1);
                }
                ui_1.OnUpdateUI(mysteryItemInfos[i]);
                number++;
            }

            for (int i = number; i < self.SellList.Count; i++)
            {
                self.SellList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask RequestMystery(this UIJiaYuanMysteryComponent self)
        {
            C2M_JiaYuanMysteryListRequest c2A_MysteryListRequest = new C2M_JiaYuanMysteryListRequest() {  };
            M2C_JiaYuanMysteryListResponse r2c_roleEquip = (M2C_JiaYuanMysteryListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2A_MysteryListRequest);
            self.UpdateMysteryItem(r2c_roleEquip.MysteryItemInfos).Coroutine();
        }

        public static async ETTask ShowCDTime(this UIJiaYuanMysteryComponent self)
        {
            while (!self.IsDisposed)
            {
                DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                long curTime = dateTime.Hour * 60 * 60 + dateTime.Minute * 60 + dateTime.Second;
                long cdTime = 0;

                if (dateTime.Hour < 6)
                {
                    cdTime = 6 * 60 * 60 - curTime;
                }
                else if (dateTime.Hour < 12)
                {
                    cdTime = 12 * 60 * 60 - curTime;
                }
                else if (dateTime.Hour < 18)
                {
                    cdTime = 18 * 60 * 60 - curTime;
                }
                else
                {
                    cdTime = 24 * 60 * 60 - curTime;
                }
                self.Text_CDTime.GetComponent<Text>().text = $"刷新倒计时: {TimeHelper.ShowLeftTime(cdTime * 1000)}";
                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

    }
}