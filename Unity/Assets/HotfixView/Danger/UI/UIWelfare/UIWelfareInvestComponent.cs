using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareInvestComponent: Entity, IAwake
    {
        public GameObject TaskListNode;
        public GameObject UIWelfareInvestItem;
        public GameObject InvestNumText;
        public GameObject ProfitNumText;
        public GameObject TotalReturnNumText;
        public GameObject TimeText;
        public GameObject ReceiveBtn;
        public GameObject ReceivedImg;

        public DateTime EndTime;
        public List<UIWelfareInvestItemComponent> UIWelfareInvestItemComponents = new List<UIWelfareInvestItemComponent>();
    }

    public class UIWelfareInvestComponentAwakeSystem: AwakeSystem<UIWelfareInvestComponent>
    {
        public override void Awake(UIWelfareInvestComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.UIWelfareInvestItem = rc.Get<GameObject>("UIWelfareInvestItem");
            self.InvestNumText = rc.Get<GameObject>("InvestNumText");
            self.ProfitNumText = rc.Get<GameObject>("ProfitNumText");
            self.TotalReturnNumText = rc.Get<GameObject>("TotalReturnNumText");
            self.TimeText = rc.Get<GameObject>("TimeText");
            self.ReceiveBtn = rc.Get<GameObject>("ReceiveBtn");
            self.ReceivedImg = rc.Get<GameObject>("ReceivedImg");

            self.UIWelfareInvestItem.SetActive(false);
            self.ReceiveBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnReceiveBtn().Coroutine(); });
            self.EndTime = TimeInfo.Instance.ToDateTime(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.CreateTime).AddDays(6);

            self.InitTask();
            self.UpdateTime().Coroutine();
        }
    }

    public static class UIWelfareInvestComponentSystem
    {
        public static void InitTask(this UIWelfareInvestComponent self)
        {
            int number = 0;
            for (int i = 0; i < 6; i++)
            {
                UIWelfareInvestItemComponent uiWelfareInvestItemComponent = null;
                if (number < self.UIWelfareInvestItemComponents.Count)
                {
                    uiWelfareInvestItemComponent = self.UIWelfareInvestItemComponents[number];
                    uiWelfareInvestItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskItem = GameObject.Instantiate(self.UIWelfareInvestItem);
                    taskItem.SetActive(true);
                    UICommonHelper.SetParent(taskItem, self.TaskListNode);
                    uiWelfareInvestItemComponent = self.AddChild<UIWelfareInvestItemComponent, GameObject>(taskItem);
                    self.UIWelfareInvestItemComponents.Add(uiWelfareInvestItemComponent);
                }

                uiWelfareInvestItemComponent.OnUpdateData(i);
                number++;
            }

            for (int k = number; k < self.UIWelfareInvestItemComponents.Count; k++)
            {
                self.UIWelfareInvestItemComponents[k].GameObject.SetActive(false);
            }
        }

        public static void UpdateInfo(this UIWelfareInvestComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int touzi = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.InvestMent);
            self.InvestNumText.GetComponent<Text>().text = touzi.ToString();

            int createDay = self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay();
            int lirun = ComHelp.GetWelfareTotalLiRun(touzi, createDay);
            self.ProfitNumText.GetComponent<Text>().text = (touzi * createDay * 0.25f).ToString();

            self.TotalReturnNumText.GetComponent<Text>().text = lirun.ToString();

            // 是否领过
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.InvestReward) == 1)
            {
                self.ReceiveBtn.SetActive(false);
                self.ReceivedImg.SetActive(true);
            }
            else
            {
                self.ReceiveBtn.SetActive(true);
                self.ReceivedImg.SetActive(false);
            }
        }

        public static async ETTask OnReceiveBtn(this UIWelfareInvestComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.InvestReward) == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取!");
                return;
            }

            if (self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1 < 6)
            {
                FloatTipManager.Instance.ShowFloatTip("今天还不能领取!");
                return;
            }

            // 投资奖励. 第七天领取奖励
            C2M_WelfareInvestRewardRequest request5 = new C2M_WelfareInvestRewardRequest();
            M2C_WelfareInvestRewardResponse response5 =
                    (M2C_WelfareInvestRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request5);

            self.UpdateInfo();
        }

        public static async ETTask UpdateTime(this UIWelfareInvestComponent self)
        {
            while (!self.IsDisposed)
            {
                DateTime nowTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                TimeSpan ts = self.EndTime - nowTime;
                if (ts.TotalMinutes > 0)
                {
                    self.TimeText.GetComponent<Text>().text = $"{ts.Days}天{ts.Hours}小时{ts.Minutes}分";
                }
                else
                {
                    self.TimeText.GetComponent<Text>().text = "赶快领取!!";
                }

                await TimerComponent.Instance.WaitAsync(60000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }
    }
}