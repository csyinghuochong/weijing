using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonLordDetailComponent: Entity, IAwake, IDestroy
    {
        public GameObject PositionText;
        public Text RefreshTimeText;
        public GameObject MonsterHeadImg;
        public GameObject UICommonItemBack;
        public GameObject UICommonItem;
        public GameObject ItemNameText;
        public GameObject ItemDesText;
        public GameObject ItemListNode;
        public GameObject UseItemBtn;
        public GameObject CloseBtn;

        public BagInfo BagInfo;
        public UIItemComponent CheckedItem;
        public List<UIItemComponent> ItemList = new List<UIItemComponent>();
        public List<string> AssetPath = new List<string>();
    }

    public class UISeasonLordDetailComponentAwakeSystem: AwakeSystem<UISeasonLordDetailComponent>
    {
        public override void Awake(UISeasonLordDetailComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PositionText = rc.Get<GameObject>("PositionText");
            self.RefreshTimeText = rc.Get<GameObject>("RefreshTimeText").GetComponent<Text>();
            self.MonsterHeadImg = rc.Get<GameObject>("MonsterHeadImg");
            self.UICommonItemBack = rc.Get<GameObject>("UICommonItemBack");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.ItemNameText = rc.Get<GameObject>("ItemNameText");
            self.ItemDesText = rc.Get<GameObject>("ItemDesText");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.UseItemBtn = rc.Get<GameObject>("UseItemBtn");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");

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

    public class UISeasonLordDetailComponentDestroy: DestroySystem<UISeasonLordDetailComponent>
    {
        public override void Destroy(UISeasonLordDetailComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UISeasonLordDetailComponentSystem
    {
        public static async ETTask OnUseItemBtn(this UISeasonLordDetailComponent self)
        {
            if (self.BagInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("未选择道具！");
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long now = TimeHelper.ServerNow();
            long end = numericComponent.GetAsLong(NumericType.SeasonBossRefreshTime);
            if (end - now <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("赛季首领已经出现！");
                return;
            }

            List<long> fruidids = new List<long>();
            fruidids.Add(self.BagInfo.BagInfoID);
            C2M_SeasonUseFruitRequest reuqest = new C2M_SeasonUseFruitRequest() { BagInfoIDs = fruidids };
            M2C_SeasonUseFruitResponse response =
                    (M2C_SeasonUseFruitResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reuqest);

            if (response.Error == ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("使用成功！");
                self.BagInfo = null;
                self.UICommonItem.SetActive(false);
                self.ItemNameText.GetComponent<Text>().text = string.Empty;
                self.ItemDesText.GetComponent<Text>().text = string.Empty;
                self.UpdateItemList().Coroutine();
            }
        }

        public static void UpdateInfo(this UISeasonLordDetailComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            int fubenid = numericComponent.GetAsInt(NumericType.SeasonBossFuben);
            DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(fubenid);
            self.PositionText.GetComponent<Text>().text = $"即将出现在{dungeonConfig.ChapterName}中...";

            int bossId = SeasonHelper.SeasonBossId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(bossId);
            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.MonsterIcon, monsterConfig.MonsterHeadIcon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            self.MonsterHeadImg.GetComponent<Image>().sprite = sp;
        }

        public static async ETTask UpdateItemList(this UISeasonLordDetailComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            if (self.ItemList.Count < 10)
            {
                // 先生成10个格子
                for (int i = 0; i < 10; i++)
                {
                    UIItemComponent uI = null;
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ItemListNode);
                    go.SetActive(true);
                    uI = self.AddChild<UIItemComponent, GameObject>(go);
                    uI.SetClickHandler((bagInfo) => { self.OnSelect(bagInfo); });
                    self.ItemList.Add(uI);
                    uI.UpdateItem(null, ItemOperateEnum.None);
                }
            }

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
                        go.SetActive(true);
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
                self.ItemList[i].UpdateItem(null, ItemOperateEnum.None);
                // self.ItemList[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelect(this UISeasonLordDetailComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            self.CheckedItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            self.UICommonItem.SetActive(true);
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
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            while (!self.IsDisposed)
            {
                long now = TimeHelper.ServerNow();
                long end = numericComponent.GetAsLong(NumericType.SeasonBossRefreshTime);
                if (end - now > 0)
                {
                    DateTime nowTime = TimeInfo.Instance.ToDateTime(now);
                    DateTime endTime = TimeInfo.Instance.ToDateTime(end);
                    TimeSpan ts = endTime - nowTime;
                    self.RefreshTimeText.text = $"剩余时间:{ts.Days}:{ts.Hours}:{ts.Minutes}:{ts.Seconds}";
                }
                else
                {
                    self.RefreshTimeText.text = "出现!!";
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