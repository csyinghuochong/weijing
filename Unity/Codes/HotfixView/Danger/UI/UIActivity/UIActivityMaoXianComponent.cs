using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityMaoXianComponent : Entity, IAwake
    {
        public GameObject Text_Progress;
        public GameObject ImageReceived;
        public GameObject ButtonRight;
        public GameObject ButtonLeft;
        public GameObject ItemListNode;
        public GameObject ImageProgress;
        public GameObject Btn_GoToSupport;
        public GameObject Btn_GetReward;
        public GameObject Text_Title;
        public int CurActivityId;
    }

    [ObjectSystem]
    public class UIActivityMaoXianComponentAwakeSystem : AwakeSystem<UIActivityMaoXianComponent>
    {
        public override void Awake(UIActivityMaoXianComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Progress = rc.Get<GameObject>("Text_Progress");
            self.ImageReceived = rc.Get<GameObject>("ImageReceived");

            self.ButtonRight = rc.Get<GameObject>("ButtonRight");
            ButtonHelp.AddListenerEx(self.ButtonRight, () => { self.OnButtonActivty(1); });
            self.ButtonLeft = rc.Get<GameObject>("ButtonLeft");
            ButtonHelp.AddListenerEx( self.ButtonLeft, () => { self.OnButtonActivty(-1); } );

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.ImageProgress = rc.Get<GameObject>("ImageProgress");
            self.ButtonRight.SetActive(false);
            self.ButtonLeft.SetActive(false);

            self.Btn_GoToSupport = rc.Get<GameObject>("Btn_GoToSupport");
            ButtonHelp.AddListenerEx(self.Btn_GoToSupport, () => { self.OnBtn_GoToSupport(); });
            self.Btn_GetReward = rc.Get<GameObject>("Btn_GetReward");
            ButtonHelp.AddListenerEx(self.Btn_GetReward, () => { self.OnBtn_GetReward().Coroutine(); });

            self.Text_Title = rc.Get<GameObject>("Text_Title");
            self.OnInitUI();
        }
    }

    public static class UIActivityMaoXianComponentSystem
    {

        public static void OnBtn_GoToSupport(this UIActivityMaoXianComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIRecharge).Coroutine();
        }

        public static async ETTask OnBtn_GetReward(this UIActivityMaoXianComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.CurActivityId);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int rechargeNum = self.GetMaoXianExp();
            int needNumber = int.Parse(activityConfig.Par_2);
            if (rechargeNum < needNumber)
            {
                FloatTipManager.Instance.ShowFloatTip("冒险家积分不足！");
                return;
            }
            if (activityComponent.ActivityReceiveIds.Contains(self.CurActivityId))
            {
                FloatTipManager.Instance.ShowFloatTip("当前奖励已领取！");
                return;
            }
            int errorCode = await activityComponent.GetActivityReward(activityConfig.ActivityType, activityConfig.Id);
            if (errorCode != ErrorCore.ERR_Success)
            {
                return;
            }
            self.Btn_GetReward.SetActive(!activityComponent.ActivityReceiveIds.Contains(self.CurActivityId));
            self.ImageReceived.SetActive(activityComponent.ActivityReceiveIds.Contains(self.CurActivityId));
            self.OnUpdateUI(self.GetCurActivityId());
        }

        /// <summary>
        /// 取到当前可以领取的最小等级
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetCurActivityId(this UIActivityMaoXianComponent self)
        {
            int activityId = 0;
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            int rechargeNumb = self.GetMaoXianExp();
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 101)
                {
                    continue;
                }
                activityId = activityConfigs[i].Id;
                int needNumber = int.Parse(activityConfigs[i].Par_2);
                if (rechargeNumb < needNumber)
                {
                    break;
                }
                if (rechargeNumb >= needNumber && !activityComponent.ActivityReceiveIds.Contains(activityId))
                {
                    break;
                }
            }
            return activityId;
        }

        public static void OnInitUI(this UIActivityMaoXianComponent self)
        {
            self.OnUpdateUI(self.GetCurActivityId());
        }

        public static void OnButtonActivty(this UIActivityMaoXianComponent self, int index)
        {
            //if (!ActivityConfigCategory.Instance.Contain(self.CurActivityId + index))
            //{
            //    return;
            //}
            //self.OnUpdateUI(self.CurActivityId + index);
        }

        public static int GetMaoXianExp(this UIActivityMaoXianComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int rechargeNum = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);
            //self.ZoneScene().GetComponent<AccountInfoComponent>().GetRechargeNumber(userInfo.UserId);
            rechargeNum += unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MaoXianExp);
            return rechargeNum;
        }

        public static void OnUpdateUI(this UIActivityMaoXianComponent self, int maoxianId)
        {
            if (maoxianId == 0)
            {
                return;
            }
            self.CurActivityId = maoxianId;
            //self.ButtonRight.SetActive(ActivityConfigCategory.Instance.Contain(maoxianId + 1));
            ActivityComponent activityComponent =  self.ZoneScene().GetComponent<ActivityComponent>();

            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(maoxianId);
            self.Text_Title.GetComponent<Text>().text = activityConfig.Par_4;

            int rechargeNum = self.GetMaoXianExp();
            int needNumber = int.Parse( activityConfig.Par_2);
            float value = rechargeNum * 1f / needNumber;
            value = Mathf.Clamp01(value);
            self.ImageProgress.transform.localScale = new Vector3(value, 1f, 1f);
            self.Text_Progress.GetComponent<Text>().text = $"{rechargeNum}/{needNumber}";
            self.Btn_GetReward.SetActive(!activityComponent.ActivityReceiveIds.Contains(self.CurActivityId));
            self.ImageReceived.SetActive(activityComponent.ActivityReceiveIds.Contains(self.CurActivityId));

            UICommonHelper.DestoryChild(self.ItemListNode);
            UICommonHelper.ShowItemList(activityConfig.Par_3, self.ItemListNode, self, 0.8f).Coroutine();
        }

    }

}
