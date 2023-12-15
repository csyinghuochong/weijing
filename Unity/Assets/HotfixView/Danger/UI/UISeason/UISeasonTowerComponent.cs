using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonTowerComponent: Entity, IAwake
    {
        public GameObject UISeasonTowerRankItemListNode;
        public GameObject UISeasonTowerRankItem;
        public GameObject RewardShowBtn;
        public GameObject TimeText;
        public GameObject LayerText;
        public GameObject EnterBtn;
    }

    public class UISeasonTowerComponentAwakeSystem: AwakeSystem<UISeasonTowerComponent>
    {
        public override void Awake(UISeasonTowerComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UISeasonTowerRankItemListNode = rc.Get<GameObject>("UISeasonTowerRankItemListNode");
            self.UISeasonTowerRankItem = rc.Get<GameObject>("UISeasonTowerRankItem");
            self.RewardShowBtn = rc.Get<GameObject>("RewardShowBtn");
            self.TimeText = rc.Get<GameObject>("TimeText");
            self.LayerText = rc.Get<GameObject>("LayerText");
            self.EnterBtn = rc.Get<GameObject>("EnterBtn");

            self.TimeText.GetComponent<Text>().text = string.Empty;
            self.LayerText.GetComponent<Text>().text = string.Empty;
            self.UISeasonTowerRankItem.SetActive(false);
            self.RewardShowBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnRewardShowBtn().Coroutine(); });
            self.EnterBtn.GetComponent<Button>().onClick.AddListener(self.OnEnterBtn);

            self.UpdateInfo().Coroutine();
        }
    }

    public static class UISeasonTowerComponentSystem
    {
        public static async ETTask OnRewardShowBtn(this UISeasonTowerComponent self)
        {
            UI uiHelp = await UIHelper.Create(self.ZoneScene(), UIType.UISeasonTowerReward);
            uiHelp.GetComponent<UISeasonTowerRewardComponent>().OnInitUI(7);
        }

        public static  void OnEnterBtn(this UISeasonTowerComponent self)
        {
            int sceneId = BattleHelper.GetSceneIdByType(SceneTypeEnum.SeasonTower);
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.SeasonTower, sceneId, 0, "0").Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UISeason);
        }

        public static async ETTask UpdateInfo(this UISeasonTowerComponent self)
        {
            long instanceid = self.InstanceId;
            C2R_RankSeasonTowerRequest request = new C2R_RankSeasonTowerRequest();
            R2C_RankSeasonTowerResponse response =
                    (R2C_RankSeasonTowerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            self.LayerText.GetComponent<Text>().text =
                    $"{UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.SeasonTowerId) % 250000}/20";
            long selfId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            List<RankSeasonTowerInfo> rankList = response.RankList;
            for (int i = 0; i < rankList.Count; i++)
            {
                if (instanceid != self.InstanceId)
                {
                    return;
                }

                if (rankList[i].UserId == selfId)
                {
                    //NumericType.SeasonTowerId 当前通关的塔ID
                    self.TimeText.GetComponent<Text>().text =
                            $"{rankList[i].TotalTime / 3600000}小时{rankList[i].TotalTime % 3600000 / 60000}分{rankList[i].TotalTime % 3600000 % 60000 / 1000}秒";
                }

                GameObject go = UnityEngine.Object.Instantiate(self.UISeasonTowerRankItem);
                UISeasonTowerRankItemComponent component = self.AddChild<UISeasonTowerRankItemComponent, GameObject>(go);
                component.UpdateInfo(i + 1, rankList[i]);
                UICommonHelper.SetParent(go, self.UISeasonTowerRankItemListNode);
                go.SetActive(true);
            }
        }
    }
}