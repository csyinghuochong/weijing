using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanOneKeyPlantComponent: Entity, IAwake
    {
        public GameObject NumText;
        public GameObject ItemListNode;
        public GameObject SeedToggle;
        public GameObject Btn_Close;
        public GameObject Btn_OnePlant;

        public List<int> Lands = new List<int>();
        public List<int> Seeds = new List<int>();
        public Dictionary<int, int> SeedToggles = new Dictionary<int, int>(); // index,BagInfo.ItemID
        public Dictionary<int, GameObject> SeedToggleGameObjects = new Dictionary<int, GameObject>();
    }

    public class UIJiaYuanOneKeyPlantComponentAwakeSystem: AwakeSystem<UIJiaYuanOneKeyPlantComponent>
    {
        public override void Awake(UIJiaYuanOneKeyPlantComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NumText = rc.Get<GameObject>("NumText");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.SeedToggle = rc.Get<GameObject>("SeedToggle");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_OnePlant = rc.Get<GameObject>("Btn_OnePlant");

            self.SeedToggle.SetActive(false);

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanOneKeyPlant); });
            self.Btn_OnePlant.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_OnePlant().Coroutine(); });

            self.UpdateInfo();
        }
    }

    public static class UIJiaYuanOneKeyPlantComponentSystem
    {
        public static void UpdateInfo(this UIJiaYuanOneKeyPlantComponent self)
        {
            self.Lands.Clear();
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            foreach (int cellIndex in jiaYuanComponent.PlanOpenList_7)
            {
                Unit unit = JiaYuanHelper.GetUnitByCellIndex(self.ZoneScene().CurrentScene(), cellIndex);
                if (unit == null)
                {
                    self.Lands.Add(cellIndex);
                }
            }

            self.NumText.GetComponent<Text>().text = $"可种植地数量:{self.Lands.Count}/{jiaYuanComponent.PlanOpenList_7.Count}";

            self.SeedToggles.Clear();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(2);
            int num = 0;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType != 2 || itemConfig.ItemSubType != 101)
                {
                    continue;
                }
                
                for (int j = 0; j < bagInfos[i].ItemNum; j++)
                {
                    GameObject go = GameObject.Instantiate(self.SeedToggle);

                    go.GetComponent<ReferenceCollector>().Get<GameObject>("Text").GetComponent<Text>().text = itemConfig.ItemName;
                    int index = num;
                    go.GetComponent<ReferenceCollector>().Get<GameObject>("Btn_Click").GetComponent<Button>().onClick
                            .AddListener(() => { self.OnSeedToggle(index); });

                    if (num < self.Lands.Count) // 默认是从1开始全部勾选指定数量的
                    {
                        go.GetComponent<ReferenceCollector>().Get<GameObject>("Image_Click").SetActive(true);
                        self.Seeds.Add(bagInfos[i].ItemID);
                    }
                    else
                    {
                        go.GetComponent<ReferenceCollector>().Get<GameObject>("Image_Click").SetActive(false);
                    }

                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.ItemListNode);
                    self.SeedToggles.Add(num, bagInfos[i].ItemID);
                    self.SeedToggleGameObjects.Add(num, go);
                    num++;
                }
            }
        }

        public static void OnSeedToggle(this UIJiaYuanOneKeyPlantComponent self, int index)
        {
            bool active = self.SeedToggleGameObjects[index].GetComponent<ReferenceCollector>().Get<GameObject>("Image_Click").activeSelf;

            if (active)
            {
                self.Seeds.Remove(self.SeedToggles[index]);
                self.SeedToggleGameObjects[index].GetComponent<ReferenceCollector>().Get<GameObject>("Image_Click").SetActive(false);
            }
            else
            {
                if (self.Seeds.Count < self.Lands.Count)
                {
                    self.Seeds.Add(self.SeedToggles[index]);
                    self.SeedToggleGameObjects[index].GetComponent<ReferenceCollector>().Get<GameObject>("Image_Click").SetActive(true);
                }
                else
                {
                    FloatTipManager.Instance.ShowFloatTip("空地数量不足！");
                }
            }
        }

        public static async ETTask OnBtn_OnePlant(this UIJiaYuanOneKeyPlantComponent self)
        {
            if (self.Seeds.Count <= 0)
            {
                return;
            }

            C2M_JiaYuanPlantRequest request =
                    new C2M_JiaYuanPlantRequest();
            for (int i = 0; i < self.Seeds.Count; i++)
            {
                request.CellIndex = self.Lands[i];
                request.ItemId = self.Seeds[i];
                M2C_JiaYuanPlantResponse response =
                        (M2C_JiaYuanPlantResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            }

            UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanOneKeyPlant);
        }
    }
}