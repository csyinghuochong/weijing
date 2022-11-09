using UnityEngine;
using UnityEngine.UI;
#if !NOT_UNITY
#endif

namespace ET
{
    public class UIZhanQuCombatItemComponent : Entity, IAwake
    {

        public GameObject ItemListNode;
        public GameObject TextLeft;
        public GameObject Text_level;
        public GameObject TextTip2;             //领取人数已满
        public GameObject ButtonReceive;
        public GameObject YiLingQuSet;

        public ActivityConfig ActivityConfig;
    }

    [ObjectSystem]
    public class UIZhanQuCombatItemComponentAwakeSystem : AwakeSystem<UIZhanQuCombatItemComponent>
    {
        public override void Awake(UIZhanQuCombatItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.TextLeft = rc.Get<GameObject>("TextLeft");
            self.Text_level = rc.Get<GameObject>("Text_level");
            self.TextTip2 = rc.Get<GameObject>("TextTip2");
            self.TextTip2.SetActive(false);

            self.ButtonReceive = rc.Get<GameObject>("ButtonReceive");
            ButtonHelp.AddListenerEx(self.ButtonReceive, () => { self.OnButtonReceive().Coroutine(); });

            self.YiLingQuSet = rc.Get<GameObject>("YiLingQuSet");
            self.YiLingQuSet.SetActive(false);
        }
    }

    public static class UIZhanQuCombatItemComponentSystem
    {

        //Par_1 条件    Par_2 人数    Par_3奖励 
        public static void OnInitUI(this UIZhanQuCombatItemComponent self, ActivityConfig activityInfo)
        {
            self.ActivityConfig = activityInfo;
            self.OnUpdateLeftNumber();
            UICommonHelper.ShowItemList(activityInfo.Par_3, self.ItemListNode, self, 0.8f);
        }

        public static void OnUpdateLeftNumber(this UIZhanQuCombatItemComponent self)
        {
            ActivityConfig activityInfo = self.ActivityConfig;
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();

            int receiveNum = 0;
            int leftNumber = 0;
            for (int i = 0; i < activityComponent.ZhanQuReceiveNumbers.Count; i++)
            {
                if (activityComponent.ZhanQuReceiveNumbers[i].ActivityId == activityInfo.Id)
                {
                    receiveNum = activityComponent.ZhanQuReceiveNumbers[i].ReceiveNum;
                }
            }
            leftNumber = int.Parse(activityInfo.Par_2) - receiveNum;

            self.TextLeft.GetComponent<Text>().text = $"{leftNumber}/{activityInfo.Par_2}";
            self.Text_level.GetComponent<Text>().text = $"战力达到{activityInfo.Par_1}";

            self.YiLingQuSet.SetActive(activityComponent.ZhanQuReceiveIds.Contains(activityInfo.Id) && leftNumber > 0);
            self.ButtonReceive.SetActive(!activityComponent.ZhanQuReceiveIds.Contains(activityInfo.Id) && leftNumber > 0);
            self.TextTip2.SetActive(leftNumber == 0);
        }

        public static async ETTask OnButtonReceive(this UIZhanQuCombatItemComponent self)
        {
            ActivityConfig activityInfo = self.ActivityConfig;
            int needCombat = int.Parse(activityInfo.Par_1);
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Combat < needCombat)
            {
                FloatTipManager.Instance.ShowFloatTip("战力不足！");
                return;
            }
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.ZhanQuReceiveIds.Contains(self.ActivityConfig.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过该奖励！");
                return;
            }
            await activityComponent.GetZhanQuActivityReward(self.ActivityConfig.ActivityType, self.ActivityConfig.Id);
            self.OnUpdateLeftNumber();
        }
    }
}
