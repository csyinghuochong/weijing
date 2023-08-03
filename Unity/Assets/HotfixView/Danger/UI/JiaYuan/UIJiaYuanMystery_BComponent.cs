using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMystery_BComponent: Entity, IAwake, IDestroy
    {
        public GameObject cellContainer1;
        public GameObject Text_CDTime;
        public List<UIJiaYuanMysteryItemComponent> SellList = new List<UIJiaYuanMysteryItemComponent>();
    }

    public class UIJiaYuanMystery_BComponentAwakeSystem: AwakeSystem<UIJiaYuanMystery_BComponent>
    {
        public override void Awake(UIJiaYuanMystery_BComponent self)
        {
            self.Awake();
        }
    }

    public class UIJiaYuanMystery_BComponentDestroySystem: DestroySystem<UIJiaYuanMystery_BComponent>
    {
        public override void Destroy(UIJiaYuanMystery_BComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIJiaYuanMystery_BComponentSystem
    {
        public static void Awake(this UIJiaYuanMystery_BComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.Text_CDTime = rc.Get<GameObject>("Text_CDTime");
            
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
            
            self.RequestMystery().Coroutine();
            self.ShowCDTime().Coroutine();
        }

        public static void Destroy(this UIJiaYuanMystery_BComponent self)
        {
        }

        public static void OnUpdateUI(this UIJiaYuanMystery_BComponent self)
        {
            self.RequestMystery().Coroutine();
        }
        public static async ETTask UpdateMysteryItem(this UIJiaYuanMystery_BComponent self, List<MysteryItemInfo> mysteryItemInfos)
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

        public static async ETTask RequestMystery(this UIJiaYuanMystery_BComponent self)
        {
            int npcID = 30000001;
            if (UIHelper.CurrentNpcId != 0)
            {
                npcID = UIHelper.CurrentNpcId;
            }

            //显示当前商品
            C2M_JiaYuanMysteryListRequest c2A_MysteryListRequest = new C2M_JiaYuanMysteryListRequest() { NpcID = npcID };
            M2C_JiaYuanMysteryListResponse r2c_roleEquip =
                    (M2C_JiaYuanMysteryListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2A_MysteryListRequest);
            self.UpdateMysteryItem(r2c_roleEquip.MysteryItemInfos).Coroutine();
        }

        public static async ETTask ShowCDTime(this UIJiaYuanMystery_BComponent self)
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