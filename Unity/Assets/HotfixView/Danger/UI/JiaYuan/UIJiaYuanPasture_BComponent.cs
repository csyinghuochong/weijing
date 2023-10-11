using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPasture_BComponent: Entity, IAwake, IDestroy
    {
        public string AssetPath = string.Empty;
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UIJiaYuanPastureItemComponent> SellList = new List<UIJiaYuanPastureItemComponent>();
        public GameObject Text_CDTime;
    }

    public class UIJiaYuanPasture_BComponentDestroy : DestroySystem<UIJiaYuanPasture_BComponent>
    {
        public override void Destroy(UIJiaYuanPasture_BComponent self)
        {
            if (!string.IsNullOrEmpty(self.AssetPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);
            }
            self.AssetPath = string.Empty;
        }
    }

    public class UIJiaYuanPasture_BComponentAwake: AwakeSystem<UIJiaYuanPasture_BComponent>
    {
        public override void Awake(UIJiaYuanPasture_BComponent self)
        {
            self.SellList.Clear();
            self.AssetPath = string.Empty;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStore(); });

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            self.Text_CDTime = rc.Get<GameObject>("Text_CDTime");
            
            self.RequestMystery().Coroutine();
            self.ShowCDTime().Coroutine();
        }
    }

    public static class UIJiaYuanPasture_BComponentSystem
    {
        public static async ETTask ShowCDTime(this UIJiaYuanPasture_BComponent self)
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
        
        public static void OnCloseStore(this UIJiaYuanPasture_BComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanPasture);
        }

        public static async ETTask UpdateMysteryItem(this UIJiaYuanPasture_BComponent self, List<MysteryItemInfo> mysteryItemInfos)
        {
            string path_1 = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPastureItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path_1);
            self.AssetPath = path_1;
            int number = 0;
            for (int i = 0; i < mysteryItemInfos.Count; i++)
            {
                if (mysteryItemInfos[i].ItemNumber == 0)
                {
                    continue;
                }

                UIJiaYuanPastureItemComponent ui_1 = null;
                if (number < self.SellList.Count)
                {
                    ui_1 = self.SellList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UIJiaYuanPastureItemComponent, GameObject>(storeItem);
                    self.SellList.Add(ui_1);
                }

                ui_1.OnUpdateUI(mysteryItemInfos[i], i);
                number++;
            }

            for (int i = number; i < self.SellList.Count; i++)
            {
                self.SellList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask RequestMystery(this UIJiaYuanPasture_BComponent self)
        {
            C2M_JiaYuanPastureListRequest c2A_MysteryListRequest = new C2M_JiaYuanPastureListRequest() { };
            M2C_JiaYuanPastureListResponse r2c_roleEquip =
                    (M2C_JiaYuanPastureListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2A_MysteryListRequest);
            self.UpdateMysteryItem(r2c_roleEquip.MysteryItemInfos).Coroutine();
        }
    }
}