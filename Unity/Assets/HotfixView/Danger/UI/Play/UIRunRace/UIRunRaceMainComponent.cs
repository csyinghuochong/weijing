using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRunRaceMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject RankingListNode;
        public GameObject PlayerInfoItem;

        public Text EndTimeText;

        public long EndTime;
        public UISkillGridComponent UISkillGrid;
        public List<GameObject> Rankings = new List<GameObject>();
    }

    public class UIRunRaceMainComponentAwake : AwakeSystem<UIRunRaceMainComponent>
    {
        public override void Awake(UIRunRaceMainComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RankingListNode = rc.Get<GameObject>("RankingListNode");
            self.PlayerInfoItem = rc.Get<GameObject>("PlayerInfoItem");
            self.EndTimeText = rc.Get<GameObject>("EndTimeText").GetComponent<Text>();

            self.Rankings.Add(self.PlayerInfoItem);
            self.PlayerInfoItem.SetActive(false);
            self.EndTime = FunctionHelp.GetCloseTime(1058);

            GameObject UI_MainRoseSkill_item = rc.Get<GameObject>("UI_MainRoseSkill_item");
            self.UISkillGrid = self.AddChild<UISkillGridComponent, GameObject>(UI_MainRoseSkill_item);
            self.UISkillGrid.SkillCancelHandler = self.ShowCancelButton;

            self.OnInitUI();
            self.UpdateRanking().Coroutine();
            self.ShoweEndTime().Coroutine();
        }
    }

    public static class UIRunRaceMainComponentSystem
    {

        public static void OnInitUI(this UIRunRaceMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene() );
            int monsterId = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.RunRaceMonster );
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get( monsterId );

            self.UISkillGrid.UpdateSkillInfo(new SkillPro() { SkillID = monsterConfig.ActSkillID, SkillSetType = (int)SkillSetEnum.Skill });
       
            BattleMessageComponent battleMessageComponent =self.ZoneScene().GetComponent<BattleMessageComponent>();
            self.UpdateNextTransformTime( battleMessageComponent.M2C_RunRaceBattleInfo );
        }
        
        public static async ETTask ShoweEndTime(this UIRunRaceMainComponent self)
        {
            while (!self.IsDisposed)
            {
                DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                long curTime = (dateTime.Hour * 60 + dateTime.Minute ) * 60 + dateTime.Second;
                long endTime = self.EndTime - curTime;
                if (endTime > 0)
                {
                    self.EndTimeText.GetComponent<Text>().text = $"活动结束倒计时 {endTime / 60}:{endTime % 60}";
                }
                else
                {
                    self.EndTimeText.GetComponent<Text>().text = "未到活动时间";
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static void UpdateNextTransformTime(this UIRunRaceMainComponent self, M2C_RunRaceBattleInfo message)
        {
            Log.ILog.Debug($"下次变身时间:  {message.NextTransforTime - TimeHelper.ServerNow()}");
        }

        public static async ETTask UpdateRanking(this UIRunRaceMainComponent self)
        {
            long instacnid = self.InstanceId;
            C2R_RankRunRaceRequest request = new C2R_RankRunRaceRequest();
            R2C_RankRunRaceResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as R2C_RankRunRaceResponse;
            if (response.RankList == null || response.RankList.Count < 1)
            {
                return;
            }

            if (instacnid != self.InstanceId)
            {
                return;
            }

            int num = 0;
            for (int i = 0; i < response.RankList.Count; i++)
            {
                if (num < self.Rankings.Count)
                {
                    self.Rankings[i].GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.Rankings[i].SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.PlayerInfoItem);
                    go.GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    UICommonHelper.SetParent(go, self.RankingListNode);
                    self.Rankings.Add(go);
                }

                num++;
            }

            for (int i = num; i < self.Rankings.Count; i++)
            {
                self.Rankings[i].SetActive(false);
            }

            await ETTask.CompletedTask;
        }

        public static void UpdateRanking(this UIRunRaceMainComponent self, M2C_RankRunRaceMessage message)
        {
            int num = 0;
            for (int i = 0; i < message.RankList.Count; i++)
            {
                if (num < self.Rankings.Count)
                {
                    self.Rankings[i].GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.Rankings[i].SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.PlayerInfoItem);
                    go.GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    UICommonHelper.SetParent(go, self.RankingListNode);
                    self.Rankings.Add(go);
                }

                num++;
            }

            for (int i = num; i < self.Rankings.Count; i++)
            {
                self.Rankings[i].SetActive(false);
            }
        }

        public static void ShowCancelButton(this UIRunRaceMainComponent self, bool show)
        { 
            
        }
    }
}