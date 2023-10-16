using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRunRaceMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject RankingListNode;
        public GameObject PlayerInfoItem_1;
        public GameObject PlayerInfoItem_2;
        public GameObject PlayerInfoItem_3;
        public GameObject PlayerInfoItem_Other;

        public Text ReadyTimeText;
        public Text TransformTimeText;
        public long NextTransformTime;

        public long EndTime;
        public long ReadyTime;
        public List<GameObject> Rankings = new List<GameObject>();

        public List<UISkillGridComponent> UISkillGrids = new List<UISkillGridComponent>() ;
    }

    public class UIRunRaceMainComponentAwake : AwakeSystem<UIRunRaceMainComponent>
    {
        public override void Awake(UIRunRaceMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RankingListNode = rc.Get<GameObject>("RankingListNode");
            self.PlayerInfoItem_1 = rc.Get<GameObject>("PlayerInfoItem_1");
            self.PlayerInfoItem_2 = rc.Get<GameObject>("PlayerInfoItem_2");
            self.PlayerInfoItem_3 = rc.Get<GameObject>("PlayerInfoItem_3");
            self.PlayerInfoItem_Other = rc.Get<GameObject>("PlayerInfoItem_Other");
            self.ReadyTimeText = rc.Get<GameObject>("ReadyTimeText").GetComponent<Text>();
          
            self.TransformTimeText = rc.Get<GameObject>("TransformTimeText").GetComponent<Text>();

            self.Rankings.Add(self.PlayerInfoItem_1);
            self.Rankings.Add(self.PlayerInfoItem_2);
            self.Rankings.Add(self.PlayerInfoItem_3);
            self.Rankings.Add(self.PlayerInfoItem_Other);

            self.PlayerInfoItem_1.SetActive(false);
            self.PlayerInfoItem_2.SetActive(false);
            self.PlayerInfoItem_3.SetActive(false);
            self.PlayerInfoItem_Other.SetActive(false);
            
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1058);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            self.ReadyTime = (int.Parse(openTimes[1].Split(';')[0]) * 60 + int.Parse(openTimes[1].Split(';')[1])) * 60;
            self.EndTime = (int.Parse(openTimes[2].Split(';')[0]) * 60 + int.Parse(openTimes[2].Split(';')[1])) * 60;

            self.UISkillGrids.Clear();
            GameObject Transforms = UIHelper.GetUI( self.ZoneScene(), UIType.UIMain ).GetComponent<UIMainComponent>().UIMainSkillComponent.Transforms;
            for (int i = 0; i < 2; i++)
            {
                ReferenceCollector rcskill = Transforms.GetComponent<ReferenceCollector>();
                GameObject go_1 = rcskill.Get<GameObject>($"UI_MainRoseSkill_item_{i+1}");
                UISkillGridComponent uiSkillGridComponent_1 = self.AddChild<UISkillGridComponent, GameObject>(go_1);
                uiSkillGridComponent_1.SkillCancelHandler = self.ShowCancelButton;
                uiSkillGridComponent_1.GameObject.SetActive(false);
                self.UISkillGrids.Add(uiSkillGridComponent_1);
            }
 
            self.OnInitUI();
            self.UpdateRanking().Coroutine();
            self.ShoweEndTime().Coroutine();

            DataUpdateComponent.Instance.AddListener(DataType.OnSkillUse, self);
            DataUpdateComponent.Instance.AddListener(DataType.UpdateUserBuffSkill, self);
        }
    }

    public class UIRunRaceMainComponentDestroy : DestroySystem<UIRunRaceMainComponent>
    {
        public override void Destroy(UIRunRaceMainComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.OnSkillUse, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.UpdateUserBuffSkill, self);
        }
    }

    public static class UIRunRaceMainComponentSystem
    {

        public static void OnSkillUse(this UIRunRaceMainComponent self, long skillId)
        {
            for (int i = 0; i < self.UISkillGrids.Count; i++)
            {
                if (self.UISkillGrids[i].SkillPro != null && self.UISkillGrids[i].SkillPro.SkillID == skillId)
                {
                    self.UISkillGrids[i].GameObject.SetActive(false);
                    break;
                }
            }
        }

        public static void OnUpdateUserBuffSkill(this UIRunRaceMainComponent self, long skillId) 
        {
            for (int i = 0; i < self.UISkillGrids.Count; i++)
            {
                if (self.UISkillGrids[i].GameObject.activeSelf)
                {
                    continue;
                }
                self.UISkillGrids[i].GameObject.SetActive(true);
                SkillPro skillPro = new SkillPro();
                skillPro.SkillID = (int)skillId;
                skillPro.SkillSetType = (int)SkillSetEnum.Skill;
                skillPro.SkillSource = (int)SkillSourceEnum.Buff;
                self.UISkillGrids[i].UpdateSkillInfo(skillPro);
                break;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            FunctionEffect.GetInstance().PlaySelfEffect(unit, 60000002);
        }

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
                long leftTime = (self.NextTransformTime - TimeHelper.ServerNow()) / 1000;

                long readyTime = self.ReadyTime - curTime;
                if (readyTime > 0)
                {
                    self.ReadyTimeText.GetComponent<Text>().text = $"奔跑准备时间 {readyTime / 60}:{readyTime % 60}";
                    self.TransformTimeText.GetComponent<Text>().text = string.Empty;
                }
                else if(endTime > 0)
                {
                    self.ReadyTimeText.GetComponent<Text>().text = $"活动结束倒计时 {endTime / 60}:{endTime % 60}";
                    self.TransformTimeText.GetComponent<Text>().text = $"下次变身时间:  {leftTime / 60}:{leftTime % 60}";
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
            self.NextTransformTime = message.NextTransforTime;
        }

        public static async ETTask UpdateRanking(this UIRunRaceMainComponent self)
        {
            long instacnid = self.InstanceId;
            C2R_RankRunRaceRequest request = new C2R_RankRunRaceRequest();
            R2C_RankRunRaceResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as R2C_RankRunRaceResponse;
            
            if (instacnid != self.InstanceId)
            {
                return;
            }

            self.GetParent<UI>().GameObject.transform.SetAsFirstSibling();

            if (response.RankList == null || response.RankList.Count < 1)
            {
                return;
            }
            int num = 0;
            for (int i = 0; i < response.RankList.Count; i++)
            {
                if (i == 0)
                {
                    self.PlayerInfoItem_1.GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.PlayerInfoItem_1.SetActive(true);
                }
                else if (i == 1)
                {
                    self.PlayerInfoItem_2.GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.PlayerInfoItem_2.SetActive(true);
                }
                else if (i == 2)
                {
                    self.PlayerInfoItem_3.GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    self.PlayerInfoItem_3.SetActive(true);
                }
                else
                {
                    if (num < self.Rankings.Count)
                    {
                        self.Rankings[i].SetActive(true);
                        self.Rankings[i].GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                    }
                    else
                    {
                        GameObject go = GameObject.Instantiate(self.PlayerInfoItem_Other);
                        go.GetComponentInChildren<Text>().text = $"第{i + 1}名 {response.RankList[i].PlayerName}";
                        go.SetActive(true);
                        UICommonHelper.SetParent(go, self.RankingListNode);
                        self.Rankings.Add(go);
                    }
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
                if (i == 0)
                {
                    self.PlayerInfoItem_1.GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.PlayerInfoItem_1.SetActive(true);
                }
                else if (i == 1)
                {
                    self.PlayerInfoItem_2.GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.PlayerInfoItem_2.SetActive(true);
                }
                else if (i == 2)
                {
                    self.PlayerInfoItem_3.GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    self.PlayerInfoItem_3.SetActive(true);
                }
                else
                {
                    if (num < self.Rankings.Count)
                    {
                        self.Rankings[i].SetActive(true);
                        self.Rankings[i].GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                    }
                    else
                    {
                        GameObject go = GameObject.Instantiate(self.PlayerInfoItem_Other);
                        go.GetComponentInChildren<Text>().text = $"第{i + 1}名 {message.RankList[i].PlayerName}";
                        go.SetActive(true);
                        UICommonHelper.SetParent(go, self.RankingListNode);
                        self.Rankings.Add(go);
                    }
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