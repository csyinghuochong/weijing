using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMystery_AComponent: Entity, IAwake, IDestroy
    {
        public string AssetPath;
        public GameObject cellContainer1;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UIJiaYuanMysteryItem_AComponent> SellList = new List<UIJiaYuanMysteryItem_AComponent>();
    }

    public class UIJiaYuanMystery_AComponentAwakeSystem: AwakeSystem<UIJiaYuanMystery_AComponent>
    {
        public override void Awake(UIJiaYuanMystery_AComponent self)
        {
            self.AssetPath = string.Empty;
            self.Awake();
        }
    }

    public class UIJiaYuanMystery_AComponentDestroySystem: DestroySystem<UIJiaYuanMystery_AComponent>
    {
        public override void Destroy(UIJiaYuanMystery_AComponent self)
        {
            if (!string.IsNullOrEmpty(self.AssetPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);
            }
            self.AssetPath = string.Empty;  
            self.Destroy();
        }
    }

    public static class UIJiaYuanMystery_AComponentSystem
    {
        public static void Awake(this UIJiaYuanMystery_AComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.RequestMystery();
        }

        public static void Destroy(this UIJiaYuanMystery_AComponent self)
        {
        }

        public static void OnUpdateUI(this UIJiaYuanMystery_AComponent self)
        {
            self.RequestMystery();
        }

        public static void OnCloseStore(this UIJiaYuanMystery_AComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIMystery);
        }

        public static List<int> GetMysteryList(this UIJiaYuanMystery_AComponent self, int mysteryStartId)
        {
            List<int> itemList = new List<int>();

            while (mysteryStartId != 0)
            {
                itemList.Add(mysteryStartId);

                MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mysteryStartId);
                mysteryStartId = mysteryConfig.NextId;
            }

            return itemList;
        }

        public static async ETTask UpdateMysteryItem(this UIJiaYuanMystery_AComponent self, int mysteryStartId)
        {
            string path_1 = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanMysteryItem_A");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path_1);
            self.AssetPath = path_1;
            List<int> itemList = self.GetMysteryList(mysteryStartId);

            int number = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                UIJiaYuanMysteryItem_AComponent ui_1 = null;
                if (number < self.SellList.Count)
                {
                    ui_1 = self.SellList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UIJiaYuanMysteryItem_AComponent, GameObject>(storeItem);
                    self.SellList.Add(ui_1);
                }

                MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(itemList[i]);

                MysteryItemInfo mysteryItemInfo = new MysteryItemInfo()
                {
                    ItemID = mysteryConfig.SellItemID, ItemNumber = 1, MysteryId = itemList[i], ProductId = -1
                };
                ui_1.OnUpdateUI(mysteryItemInfo);

                number++;
            }

            for (int i = number; i < self.SellList.Count; i++)
            {
                self.SellList[i].GameObject.SetActive(false);
            }
        }

        public static void  RequestMystery(this UIJiaYuanMystery_AComponent self)
        {
            if (UIHelper.CurrentNpcId == 0)
            {
                return;
            }

            int npcID = UIHelper.CurrentNpcId;
            int mysteryStartId = 0;
            if (npcID == 30000001) // 农场管理员
            {
                mysteryStartId = 500001;
            }
            else if (npcID == 30000002) // 牧场管理员
            {
            }
            else if (npcID == 30000013) // 家园商店
            {
            }

            //显示当前商品
            self.UpdateMysteryItem(mysteryStartId).Coroutine();
        }
    }
}