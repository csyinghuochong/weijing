using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityTeHuiItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ImageReceived;
        public GameObject TextPrice;
        public GameObject TextType;
        public GameObject ButtonBuy;
        public GameObject ItemListNode;
        public GameObject ImageTitle;

        public ActivityConfig ActivityConfig;
    }

    [ObjectSystem]
    public class UIActivityTeHuiItemComponentAwakeSystem : AwakeSystem<UIActivityTeHuiItemComponent, GameObject>
    {
        public override void Awake(UIActivityTeHuiItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            
            self.ImageReceived = rc.Get<GameObject>("ImageReceived");
            self.TextPrice = rc.Get<GameObject>("TextPrice");
            self.TextType = rc.Get<GameObject>("TextType");

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx( self.ButtonBuy, () => { self.OnButtonBuy().Coroutine();  } );

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.ImageTitle = rc.Get<GameObject>("ImageTitle");
        }
    }

    public static class UIActivityTeHuiItemComponentSystem
    {
        public static async ETTask OnButtonBuy(this UIActivityTeHuiItemComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.ActivityReceiveIds.Contains(self.ActivityConfig.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("已经购买过该礼包！");
                return;
            }

            int errorCode = await activityComponent.GetActivityReward(self.ActivityConfig.ActivityType, self.ActivityConfig.Id);
            if (errorCode == ErrorCore.ERR_Success)
            {
                self.ImageReceived.SetActive(true);
            }
        }

        public static void OnUpdateUI(this UIActivityTeHuiItemComponent self, int activityId, bool received)
        {
            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(activityId);
            self.ActivityConfig = activityConfig;
            self.ImageReceived.SetActive(received);
            self.ButtonBuy.SetActive(!received);
            self.TextPrice.GetComponent<Text>().text = activityConfig.Par_2.Split(';')[1];
            self.TextType.GetComponent<Text>().text = activityConfig.Par_4;

            UICommonHelper.DestoryChild(self.ItemListNode);
            UICommonHelper.ShowItemList(activityConfig.Par_3, self.ItemListNode, self, 1f, true).Coroutine();
        }
    }
}
