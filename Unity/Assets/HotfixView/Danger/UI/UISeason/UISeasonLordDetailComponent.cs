using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonLordDetailComponent: Entity, IAwake
    {
        public GameObject PositionText;
        public GameObject RefreshTimeText;
        public GameObject UICommonItem;
        public GameObject ItemNameText;
        public GameObject ItemDesText;
        public GameObject ItemListNode;
        public GameObject UseItemBtn;
        public GameObject CloseBtn;

        public BagInfo BagInfo;
        public UIItemComponent CheckedItem;
        public List<UIItemComponent> ItemList = new List<UIItemComponent>();
        public long EndTime;
    }

    public class UISeasonLordDetailComponentAwakeSystem: AwakeSystem<UISeasonLordDetailComponent>
    {
        public override void Awake(UISeasonLordDetailComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PositionText = rc.Get<GameObject>("PositionText");
            self.RefreshTimeText = rc.Get<GameObject>("RefreshTimeText");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.ItemNameText = rc.Get<GameObject>("ItemNameText");
            self.ItemDesText = rc.Get<GameObject>("ItemDesText");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.UseItemBtn = rc.Get<GameObject>("UseItemBtn");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            self.EndTime = numericComponent.GetAsLong(NumericType.SeasonBossRefreshTime);
            self.ItemNameText.GetComponent<Text>().text = string.Empty;
            self.ItemDesText.GetComponent<Text>().text = string.Empty;
            self.CheckedItem = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);

            self.UseItemBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnUseItemBtn().Coroutine(); });
            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.DomainScene(), UIType.UISeasonLordDetail); });
            self.UpdateInfo();
            self.UpdateItemList().Coroutine();
            self.UpdateTime().Coroutine();
        }
    }

    public static class UISeasonLordDetailComponentSystem
    {
        public static async ETTask OnUseItemBtn(this UISeasonLordDetailComponent self)
        {
            if (self.BagInfo == null)
            {
                return;
            }

            List<long> fruidids = new List<long>();
            fruidids.Add(self.BagInfo.BagInfoID);
            C2M_SeasonUseFruitRequest reuqest = new C2M_SeasonUseFruitRequest() { BagInfoIDs = fruidids };
            M2C_SeasonUseFruitResponse response =
                    (M2C_SeasonUseFruitResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reuqest);

            self.CheckedItem.UpdateItem(new BagInfo(), ItemOperateEnum.None);
            self.UpdateItemList().Coroutine();
        }

        public static void UpdateInfo(this UISeasonLordDetailComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            int fubenid = numericComponent.GetAsInt(NumericType.SeasonBossFuben);
            DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(fubenid);
            self.PositionText.GetComponent<Text>().text = $"即将出现在{dungeonConfig.ChapterName}中...";
        }

        public static async ETTask UpdateItemList(this UISeasonLordDetailComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            List<BagInfo> bagInfos = bagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType == ItemTypeEnum.Consume && itemConfig.ItemSubType == 132)
                {
                    UIItemComponent uI = null;
                    if (number < self.ItemList.Count)
                    {
                        uI = self.ItemList[number];
                        uI.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject go = GameObject.Instantiate(bundleGameObject);
                        UICommonHelper.SetParent(go, self.ItemListNode);
                        uI = self.AddChild<UIItemComponent, GameObject>(go);
                        uI.SetClickHandler((bagInfo) => { self.OnSelect(bagInfo); });
                        self.ItemList.Add(uI);
                    }

                    number++;
                    uI.UpdateItem(bagInfos[i], ItemOperateEnum.None);
                }
            }

            for (int i = number; i < self.ItemList.Count; i++)
            {
                self.ItemList[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelect(this UISeasonLordDetailComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            self.CheckedItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            self.ItemNameText.GetComponent<Text>().text = itemConfig.ItemName;
            self.ItemDesText.GetComponent<Text>().text = itemConfig.ItemDes;
            for (int i = 0; i < self.ItemList.Count; i++)
            {
                self.ItemList[i].SetSelected(bagInfo);
            }
        }

        public static async ETTask UpdateTime(this UISeasonLordDetailComponent self)
        {
            while (!self.IsDisposed)
            {
                long endTime = self.EndTime - TimeHelper.ServerNow();
                DateTime bossTime = TimeInfo.Instance.ToDateTime(endTime);
                if (endTime > 0)
                {
                    self.RefreshTimeText.GetComponent<Text>().text = $"{bossTime.Day}天{bossTime.Hour}小时{bossTime.Minute}分{bossTime.Second}秒";
                }
                else
                {
                    self.RefreshTimeText.GetComponent<Text>().text = "出现了";
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }
    }
}