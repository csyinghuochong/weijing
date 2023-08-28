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

        public Text TransformTimeText;
        public Text EndTimeText;
        public long NextTransformTime;

        public long EndTime;
        public UISkillGridComponent UISkillGrid;
        public List<GameObject> Rankings = new List<GameObject>();
    }

    public class UIRunRaceMainComponentAwake : AwakeSystem<UIRunRaceMainComponent>
    {
        public override void Awake(UIRunRaceMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.GetParent<UI>().GameObject.transform.SetAsFirstSibling();

            self.RankingListNode = rc.Get<GameObject>("RankingListNode");
            self.PlayerInfoItem = rc.Get<GameObject>("PlayerInfoItem");
            self.EndTimeText = rc.Get<GameObject>("EndTimeText").GetComponent<Text>();

            self.TransformTimeText = rc.Get<GameObject>("TransformTimeText").GetComponent<Text>();

            self.Rankings.Add(self.PlayerInfoItem);
            self.PlayerInfoItem.SetActive(false);
            self.EndTime = FunctionHelp.GetCloseTime(1058);

            GameObject UI_MainRoseSkill_item = rc.Get<GameObject>("UI_MainRoseSkill_item");
            self.UISkillGrid = self.AddChild<UISkillGridComponent, GameObject>(UI_MainRoseSkill_item);
            self.UISkillGrid.SkillCancelHandler = self.ShowCancelButton;
            self.UISkillGrid.GameObject.SetActive(false);

            self.OnInitUI();
            self.UpdateRanking().Coroutine();
            self.ShoweEndTime().Coroutine();
        }
    }

    public static class UIRunRaceMainComponentSystem
    {

        public static void OnInitUI(this UIRunRaceMainComponent self)
        {
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

                long leftTime = ( self.NextTransformTime - TimeHelper.ServerNow() ) / 1000;
                self.TransformTimeText.GetComponent<Text>().text = $"变身剩余时间: {leftTime}";

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static void OnTransform(this UIRunRaceMainComponent self, int monsterId)
        {
            self.UISkillGrid.GameObject.SetActive(true);
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterId);
            self.UISkillGrid.UpdateSkillInfo(new SkillPro() { SkillID = monsterConfig.ActSkillID, SkillSetType = (int)SkillSetEnum.Skill });
        }

        public static void UpdateNextTransformTime(this UIRunRaceMainComponent self, M2C_RunRaceBattleInfo message)
        {
            Log.ILog.Debug($"下次变身时间:  {message.NextTransforTime - TimeHelper.ServerNow()}");
            self.NextTransformTime = message.NextTransforTime;
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