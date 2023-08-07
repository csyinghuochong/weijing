using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPasture_AComponent: Entity, IAwake, IDestroy
    {
        public GameObject cellContainer1;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UIJiaYuanPastureItem_AComponent> SellList = new List<UIJiaYuanPastureItem_AComponent>();
    }

    public class UIJiaYuanPasture_AComponentAwakeSystem: AwakeSystem<UIJiaYuanPasture_AComponent>
    {
        public override void Awake(UIJiaYuanPasture_AComponent self)
        {
            self.Awake();
        }
    }

    public class UIJiaYuanPasture_AComponentDestroySystem: DestroySystem<UIJiaYuanPasture_AComponent>
    {
        public override void Destroy(UIJiaYuanPasture_AComponent self)
        {
            self.Destroy();
        }
    }

    public static class UIJiaYuanPasture_AComponentSystem
    {
        public static void Awake(this UIJiaYuanPasture_AComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
        }

        public static void Destroy(this UIJiaYuanPasture_AComponent self)
        {
        }

        public static void OnUpdateUI(this UIJiaYuanPasture_AComponent self)
        {
            self.UpdateMysteryItem().Coroutine();
        }

        public static List<int> GetMysteryList(this UIJiaYuanPasture_AComponent self, int mysteryStartId)
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

        public static async ETTask UpdateMysteryItem(this UIJiaYuanPasture_AComponent self)
        {
            string path_1 = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPastureItem_A");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path_1);
            List<JiaYuanPastureConfig> jiaYuanPastureConfigs = new List<JiaYuanPastureConfig>();
            foreach (JiaYuanPastureConfig jiaYuanPastureConfig in JiaYuanPastureConfigCategory.Instance.GetAll().Values)
            {
                jiaYuanPastureConfigs.Add(jiaYuanPastureConfig);
            }

            int number = 0;
            for (int i = 0; i < jiaYuanPastureConfigs.Count; i++)
            {
                UIJiaYuanPastureItem_AComponent ui_1 = null;
                if (number < self.SellList.Count)
                {
                    ui_1 = self.SellList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UIJiaYuanPastureItem_AComponent, GameObject>(storeItem);
                    self.SellList.Add(ui_1);
                }

                MysteryItemInfo mysteryItemInfos = new MysteryItemInfo()
                {
                    ItemID = jiaYuanPastureConfigs[i].GetItemID, ItemNumber = 1, MysteryId = jiaYuanPastureConfigs[i].Id, ProductId = -1
                };
                ui_1.OnUpdateUI(mysteryItemInfos, i);
                number++;
            }

            for (int i = number; i < self.SellList.Count; i++)
            {
                self.SellList[i].GameObject.SetActive(false);
            }
        }
    }
}