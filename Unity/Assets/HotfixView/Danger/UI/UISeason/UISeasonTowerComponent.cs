using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonTowerComponent: Entity, IAwake, IDestroy
    {
        public Text Text_Ceng;
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
            self.Text_Ceng = rc.Get<GameObject>("Text_Ceng").GetComponent<Text>();

            self.TimeText.GetComponent<Text>().text = string.Empty;
            self.LayerText.GetComponent<Text>().text = string.Empty;
            self.UISeasonTowerRankItem.SetActive(false);
            self.RewardShowBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnRewardShowBtn().Coroutine(); });
            self.EnterBtn.GetComponent<Button>().onClick.AddListener(self.OnEnterBtn);

            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);      
            
            self.UpdateInfo().Coroutine();
        }
    }

    public class UISeasonTowerComponentDestroy: DestroySystem<UISeasonTowerComponent>
    {
        public override void Destroy(UISeasonTowerComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UISeasonTowerComponentSystem
    {
        public static void OnLanguageUpdate(this UISeasonTowerComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            rc.Get<GameObject>("TextTip_1").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? new Vector2(480f, 168f) : new Vector2(480f, 197f);
            rc.Get<GameObject>("TextTip_2").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? new Vector2(480f, 116f) : new Vector2(480f, 137f);
            rc.Get<GameObject>("TextTip_3").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? new Vector2(480f, 61f) : new Vector2(480f, 54f);
            
            rc.Get<GameObject>("TextTip_1").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 30;
            rc.Get<GameObject>("TextTip_2").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 30;
            rc.Get<GameObject>("TextTip_3").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 30;
            
            rc.Get<GameObject>("Image_Ceng").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? new Vector2(117f, -200f) : new Vector2(77f, -117f);
            self.TimeText.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? new Vector2(734f, -154f) : new Vector2(743f, -154f);
            self.LayerText.GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? new Vector2(734f, -234f) : new Vector2(743f, -234f);
        }

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


            int cengshu = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsInt(NumericType.SeasonTowerId) % 250000;

            self.LayerText.GetComponent<Text>().text = $"{cengshu}/10";
            self.Text_Ceng.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}层"), cengshu);
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
                    if (GameSettingLanguge.Language == 0)
                    {
                        self.TimeText.GetComponent<Text>().text = string.Format("{0}小时{1}分{2}秒", rankList[i].TotalTime / 3600000, rankList[i].TotalTime % 3600000 / 60000, rankList[i].TotalTime % 3600000 % 60000 / 1000);
                    }
                    else
                    {
                        self.TimeText.GetComponent<Text>().text = string.Format("{0}h{1}m{2}s", rankList[i].TotalTime / 3600000, rankList[i].TotalTime % 3600000 / 60000, rankList[i].TotalTime % 3600000 % 60000 / 1000);
                    }
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