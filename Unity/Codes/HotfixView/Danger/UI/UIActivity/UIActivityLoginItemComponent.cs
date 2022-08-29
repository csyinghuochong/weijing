using UnityEngine;
using UnityEngine.UI;

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
        public static async ETTask OnBtn_Receive(this UIActivityLoginItemComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            long time = TimeHelper.ServerNow();
            if (ComHelp.GetDateByTime(activityComponent.LastLoginTime) == ComHelp.GetDateByTime(time))
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
            UICommonHelper.ShowItemList(activityConfig.Par_3, self.ItemNodeList, self, 0.8f).Coroutine();
        }

        public static void SetReceived(this UIActivityLoginItemComponent self, bool received)
        {
            self.Btn_Receive.SetActive(!received);
            self.ImageReceived.SetActive(received);
        }
    }
}