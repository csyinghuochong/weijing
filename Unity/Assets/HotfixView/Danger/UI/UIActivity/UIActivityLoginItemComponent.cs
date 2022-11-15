using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UIActivityLoginItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageReceived;
        public GameObject GameObject;
        public GameObject Btn_Receive;
        public GameObject ItemNodeList;
        public GameObject Img_XuanZhong;
        public GameObject Lab_Name;

        public ActivityConfig ActivityConfig;
    }

    [ObjectSystem]
    public class UIActivityLoginItemComponentAwakeSystem : AwakeSystem<UIActivityLoginItemComponent, GameObject>
    {
        public override void Awake(UIActivityLoginItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Btn_Receive = rc.Get<GameObject>("Btn_Receive");
            ButtonHelp.AddListenerEx(self.Btn_Receive, () => { self.OnBtn_Receive().Coroutine(); });
            self.ImageReceived = rc.Get<GameObject>("ImageReceived");

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.Img_XuanZhong = rc.Get<GameObject>("Img_XuanZhong");
            self.Lab_Name = rc.Get<GameObject>("Lab_Name");
        }
    }

    public static class UIActivityLoginItemComponentSystem
    {
        public static bool CanReceive(this UIActivityLoginItemComponent self, int activityId)
        {
            List<int> allIds = new List<int>();
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 31)
                {
                    continue;
                }
                if (activityConfigs[i].Id < activityId)
                {
                    allIds.Add(activityConfigs[i].Id);
                }
            }
            for (int i = 0; i < allIds.Count; i++)
            {
                if (!activityComponent.ActivityReceiveIds.Contains(allIds[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static async ETTask OnBtn_Receive(this UIActivityLoginItemComponent self)
        {
            if (!self.CanReceive(self.ActivityConfig.Id))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("未达到领取条件！"));
                return;
            }

            long time = TimeHelper.ServerNow();
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (ComHelp.GetDayByTime(activityComponent.LastLoginTime) == ComHelp.GetDayByTime(time))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("未达到领取条件！"));
                return;
            }

            int errorCode = await activityComponent.GetActivityReward(self.ActivityConfig.ActivityType, self.ActivityConfig.Id);
            if (errorCode == ErrorCore.ERR_Success)
            {
                activityComponent.LastLoginTime = time;
                self.SetReceived(true);
            }
        }

        public static void OnUpdateUI(this UIActivityLoginItemComponent self, ActivityConfig activityConfig)
        {
            self.ActivityConfig = activityConfig;

            self.Lab_Name.GetComponent<Text>().text = activityConfig.Par_4;
            UICommonHelper.DestoryChild(self.ItemNodeList);
            UICommonHelper.ShowItemList(activityConfig.Par_3, self.ItemNodeList, self, 0.8f);
        }

        public static void SetReceived(this UIActivityLoginItemComponent self, bool received)
        {
            self.Btn_Receive.SetActive(!received);
            self.ImageReceived.SetActive(received);
        }
    }
}