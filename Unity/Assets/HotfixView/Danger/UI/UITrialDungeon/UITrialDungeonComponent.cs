using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITrialDungeonComponent : Entity, IAwake
    {
        public GameObject UIListNode;
        public GameObject Btn_Enter;
        public GameObject Btn_Receive;
        public GameObject Btn_Add;
        public GameObject Btn_Sub;
        public GameObject TextLayer;
        public GameObject BuildingList;
        public UICommonItemListComponent UICommonItemList;
        public List<UITrialDungeonItemComponent> UITrialDungeonItems = new List<UITrialDungeonItemComponent>();

        public int TowerId;
    }

    [ObjectSystem]
    public class UITrialDungeonComponentAwake : AwakeSystem<UITrialDungeonComponent>
    {
        public override void Awake(UITrialDungeonComponent self)
        {
            self.UITrialDungeonItems.Clear();
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.UIListNode = rc.Get<GameObject>("UIListNode");

            self.Btn_Enter = rc.Get<GameObject>("Btn_Enter");
            ButtonHelp.AddListenerEx(self.Btn_Enter, () => { self.OnBtn_Enter().Coroutine(); });

            self.Btn_Receive = rc.Get<GameObject>("Btn_Receive");
            ButtonHelp.AddListenerEx(self.Btn_Receive, () => { self.OnBtn_Receive().Coroutine(); });
            self.Btn_Receive.SetActive(false);

            self.Btn_Add = rc.Get<GameObject>("Btn_Add");
            self.Btn_Add.GetComponent<Button>().onClick.AddListener(self.OnBtn_Add);

            self.Btn_Sub = rc.Get<GameObject>("Btn_Sub");
            self.Btn_Sub.GetComponent<Button>().onClick.AddListener(self.OnBtn_Sub);

            self.TextLayer = rc.Get<GameObject>("TextLayer");
            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.UICommonItemList = self.AddChild<UICommonItemListComponent, GameObject>(self.BuildingList);

            int cengNum = self.GetCengNum();
            self.OnUpdateUI(cengNum).Coroutine();
        }
    }

    public static class UITrialDungeonComponentSystem
    {

        public static int GetCengNum(this UITrialDungeonComponent self)
        {
            int towerId = TowerHelper.GetCurrentTowerId(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()), SceneTypeEnum.TrialDungeon);
            int nextId = TowerHelper.GetNextTowerId(SceneTypeEnum.TrialDungeon,towerId);
            //nextId == 0通关了
            return TowerConfigCategory.Instance.Get(nextId == 0 ? towerId : nextId).CengNum;
        }

        public static int GetMaxCengNum(this UITrialDungeonComponent self)
        {
            int maxCeng = 0;
            List<TowerConfig> towerConfigs = TowerConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < towerConfigs.Count; i++)
            {
                TowerConfig towerConfig = towerConfigs[i];
                if (towerConfig.MapType != SceneTypeEnum.TrialDungeon)
                {
                    continue;
                }
                if (maxCeng < towerConfig.CengNum)
                {
                    maxCeng = towerConfig.CengNum;
                }
            }
            return maxCeng;
        }

        public static void OnBtn_Add(this UITrialDungeonComponent self)
        {
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(self.TowerId);
            if (towerConfig.CengNum >= self.GetMaxCengNum())
            {
                return;
            }
            self.OnUpdateUI(towerConfig.CengNum+1).Coroutine();
        }

        public static void OnBtn_Sub(this UITrialDungeonComponent self)
        {
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(self.TowerId);
            if (towerConfig.CengNum == 1)
            {
                return;
            }
            self.OnUpdateUI(towerConfig.CengNum - 1).Coroutine();
        }
        public static async ETTask OnUpdateUI(this UITrialDungeonComponent self, int cengNum)
        {
            var path = ABPathHelper.GetUGUIPath("TrialDungeon/UITrialDungeonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            List<TowerConfig> towerConfigs = TowerConfigCategory.Instance.GetAll().Values.ToList();
            int towerId = TowerHelper.GetCurrentTowerId(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()), SceneTypeEnum.TrialDungeon);
            int nextId = TowerHelper.GetNextTowerId(SceneTypeEnum.TrialDungeon, towerId);

            int showNum = 0;
            int showIndex = 0;
            for (int i = 0; i < towerConfigs.Count; i++)
            { 
                TowerConfig towerConfig = towerConfigs[i];
                if (towerConfig.MapType != SceneTypeEnum.TrialDungeon)
                {
                    continue;
                }
                if (cengNum != towerConfig.CengNum)
                {
                    continue;
                }
                
                UITrialDungeonItemComponent uiitem = null;
                if (towerConfig.Id == nextId)
                {
                    showIndex = showNum;
                }
                if (showNum < self.UITrialDungeonItems.Count)
                {
                    uiitem = self.UITrialDungeonItems[showNum];
                    uiitem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.UIListNode);
                    uiitem = self.AddChild<UITrialDungeonItemComponent>();
                    uiitem.GameObject = go;
                    self.UITrialDungeonItems.Add(uiitem);
                }
                uiitem.OnInitUI(towerConfig, self.OnSelectDungeonItem);
                showNum++;
            }
            for (int i = showNum; i < self.UITrialDungeonItems.Count; i++)
            {
                self.UITrialDungeonItems[i].GameObject.SetActive(false);
            }

            self.MoveToIndex(showIndex);
            self.UITrialDungeonItems[showIndex].OnBtn_XuanZhong();
            self.TextLayer.GetComponent<Text>().text = $"第{cengNum}层";
        }

        public static void  MoveToIndex(this UITrialDungeonComponent self, int showIndex)
        {
            self.UIListNode.GetComponent<RectTransform>().localPosition = new Vector2(0, showIndex * 150);
        }

        public static void OnSelectDungeonItem(this UITrialDungeonComponent self, int towerId)
        {
            self.TowerId = towerId;
            for (int i = 0; i < self.UITrialDungeonItems.Count; i++)
            {
                self.UITrialDungeonItems[i].OnSelected(towerId);
            }

            self.UpdateButtons();
            self.ShowRewardList();
        }

        public static void UpdateButtons(this UITrialDungeonComponent self)
        {
            int curId = TowerHelper.GetCurrentTowerId(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()), SceneTypeEnum.TrialDungeon);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            self.Btn_Enter.SetActive(self.TowerId > curId);
            self.Btn_Receive.SetActive(self.TowerId <= curId && !userInfo.TowerRewardIds.Contains(self.TowerId));
        }

        public static void ShowRewardList(this UITrialDungeonComponent self)
        {
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(self.TowerId);
            self.UICommonItemList.OnUpdateUI(towerConfig.DropShow, 1f, false);
        }

        public static async ETTask OnBtn_Receive(this UITrialDungeonComponent self)
        {
            await NetHelper.RequestTowerReward(self.ZoneScene(), self.TowerId);
            self.UpdateButtons();
        }

        public static async ETTask OnBtn_Enter(this UITrialDungeonComponent self)
        {
            if (self.TowerId == 0)
            {
                return;
            }
            int towerId = TowerHelper.GetCurrentTowerId(UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()), SceneTypeEnum.TrialDungeon);
            int nextId = TowerHelper.GetNextTowerId(SceneTypeEnum.TrialDungeon, towerId);
            if (self.TowerId < nextId)
            {
                FloatTipManager.Instance.ShowFloatTip("已通关该关卡！");
                return;
            }
            if (self.TowerId > nextId)
            {
                FloatTipManager.Instance.ShowFloatTip("请激活前置关卡！");
                return;
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.TrialDungeon, BattleHelper.GetSceneIdByType(SceneTypeEnum.TrialDungeon),0, self.TowerId.ToString());
            if (errorCode == ErrorCore.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITrialDungeon);
            }
        }
    }
}
