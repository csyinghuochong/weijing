using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonHomeComponent: Entity, IAwake
    {
        public GameObject SeasonText;
        public GameObject SeasonTimeText;
        public GameObject SeasonExperienceText;
        public GameObject SeasonExperienceImg;
        public GameObject SeasonLvText;
        public GameObject MonsterHeadImg;
        public GameObject MonsterNameText;
        public GameObject MonsterPositionText;
        public GameObject MonsterRefreshTimeText;
        public GameObject ShowBtn;
        public GameObject SeasonRewardText;
        public GameObject RewardsListNode;
        public GameObject GetBtn;
        public GameObject AcvityedImg;

        public DateTime EndTime;
    }

    public class UISeasonHomeComponentAwakeSystem: AwakeSystem<UISeasonHomeComponent>
    {
        public override void Awake(UISeasonHomeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SeasonText = rc.Get<GameObject>("SeasonText");
            self.SeasonTimeText = rc.Get<GameObject>("SeasonTimeText");
            self.SeasonExperienceText = rc.Get<GameObject>("SeasonExperienceText");
            self.SeasonExperienceImg = rc.Get<GameObject>("SeasonExperienceImg");
            self.SeasonLvText = rc.Get<GameObject>("SeasonLvText");
            self.MonsterHeadImg = rc.Get<GameObject>("MonsterHeadImg");
            self.MonsterNameText = rc.Get<GameObject>("MonsterNameText");
            self.MonsterPositionText = rc.Get<GameObject>("MonsterPositionText");
            self.MonsterRefreshTimeText = rc.Get<GameObject>("MonsterRefreshTimeText");
            self.ShowBtn = rc.Get<GameObject>("ShowBtn");
            self.SeasonRewardText = rc.Get<GameObject>("SeasonRewardText");
            self.RewardsListNode = rc.Get<GameObject>("RewardsListNode");
            self.GetBtn = rc.Get<GameObject>("GetBtn");
            self.AcvityedImg = rc.Get<GameObject>("AcvityedImg");

            self.GetBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnGetBtn().Coroutine(); });
            self.ShowBtn.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Create(self.DomainScene(), UIType.UISeasonLordDetail).Coroutine();
            });

            self.UpdateInfo();
            self.UpdateTime().Coroutine();
        }
    }

    public static class UISeasonHomeComponentSystem
    {
        public static void UpdateInfo(this UISeasonHomeComponent self)
        {
            DateTime startTime = TimeInfo.Instance.ToDateTime(SeasonHelper.SeasonOpenTime);
            DateTime endTime = TimeInfo.Instance.ToDateTime(SeasonHelper.SeasonCloseTime);
            self.SeasonTimeText.GetComponent<Text>().text =
                    $"赛季时间:{startTime.Year}.{startTime.Month}.{startTime.Day}-{endTime.Year}.{endTime.Month}.{endTime.Day}";

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int seasonExp = userInfo.SeasonExp;
            int maxLv = SeasonLevelConfigCategory.Instance.GetAll().Count;
            for (int i = 1; i <= maxLv; i++)
            {
                SeasonLevelConfig seasonLevelConfig = SeasonLevelConfigCategory.Instance.Get(i);
                if (i == maxLv)
                {
                    if (seasonExp > seasonLevelConfig.UpExp)
                    {
                        seasonExp = seasonLevelConfig.UpExp;
                    }

                    self.SeasonExperienceText.GetComponent<Text>().text = $"赛季经验:{userInfo.SeasonExp}/{seasonLevelConfig.UpExp}";
                    self.SeasonExperienceImg.GetComponent<Image>().fillAmount = userInfo.SeasonExp / seasonLevelConfig.UpExp;
                    break;
                }

                if (seasonExp >= seasonLevelConfig.UpExp)
                {
                    seasonExp -= seasonLevelConfig.UpExp;
                }
                else
                {
                    self.SeasonExperienceText.GetComponent<Text>().text = $"赛季经验:{userInfo.SeasonExp}/{seasonLevelConfig.UpExp}";
                    self.SeasonExperienceImg.GetComponent<Image>().fillAmount = userInfo.SeasonExp / seasonLevelConfig.UpExp;
                    break;
                }
            }

            self.SeasonLvText.GetComponent<Text>().text = userInfo.SeasonLevel.ToString();

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            int fubenid = numericComponent.GetAsInt(NumericType.SeasonBossFuben);
            DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(fubenid);
            self.MonsterPositionText.GetComponent<Text>().text = $"出现位置:{dungeonConfig.ChapterName}";

            UICommonHelper.ShowItemList(SeasonLevelConfigCategory.Instance.Get(userInfo.SeasonLevel).Reward, self.RewardsListNode, self, 0.9f);
            if (numericComponent.GetAsInt(NumericType.SeasonReward) >= userInfo.SeasonLevel)
            {
                // 已经领取
                self.AcvityedImg.SetActive(true);
                self.GetBtn.SetActive(false);
            }
            else
            {
                self.AcvityedImg.SetActive(false);
                self.GetBtn.SetActive(true);
            }
        }

        public static async ETTask UpdateTime(this UISeasonHomeComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            while (!self.IsDisposed)
            {
                self.EndTime = TimeInfo.Instance.ToDateTime(numericComponent.GetAsLong(NumericType.SeasonBossRefreshTime));
                DateTime nowTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                TimeSpan ts = self.EndTime - nowTime;
                if (ts.TotalMinutes > 0)
                {
                    self.MonsterRefreshTimeText.GetComponent<Text>().text = $"刷新时间:{ts.Days}天{ts.Hours}小时{ts.Minutes}分";
                }
                else
                {
                    self.MonsterRefreshTimeText.GetComponent<Text>().text = "出现!!";
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static async ETTask OnGetBtn(this UISeasonHomeComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.SeasonReward) >= userInfo.SeasonLevel)
            {
                return;
            }

            C2M_SeasonLevelRewardRequest request = new C2M_SeasonLevelRewardRequest() { SeasonLevel = userInfo.SeasonLevel };
            M2C_SeasonLevelRewardResponse response =
                    (M2C_SeasonLevelRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error == ErrorCode.ERR_Success)
            {
                self.AcvityedImg.SetActive(true);
                self.GetBtn.SetActive(false);
            }
        }
    }
}