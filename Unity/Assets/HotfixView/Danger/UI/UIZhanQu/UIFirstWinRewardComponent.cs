using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFirstWinRewardComponent : Entity, IAwake<GameObject>
    {

        public GameObject TextTip_Title;
        public GameObject TextHintTips;

        public GameObject Button_Complete_3;
        public GameObject Button_Complete_2;
        public GameObject Button_Complete_1;

        public GameObject Button_Get_3;
        public GameObject Button_Get_2;
        public GameObject Button_Get_1;

        public GameObject ImageButton;
        public GameObject RewardListNode3;
        public GameObject RewardListNode2;
        public GameObject RewardListNode1;

        public GameObject GameObject;
        public int FristWinId;
    }


    public class UIFirstWinRewardComponentAwakeSystem : AwakeSystem<UIFirstWinRewardComponent, GameObject>
    {
        public override void Awake(UIFirstWinRewardComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.RewardListNode3 = rc.Get<GameObject>("RewardListNode3");
            self.RewardListNode2 = rc.Get<GameObject>("RewardListNode2");
            self.RewardListNode1 = rc.Get<GameObject>("RewardListNode1");
            self.ImageButton = rc.Get<GameObject>("ImageButton");

            self.Button_Get_3 = rc.Get<GameObject>("Button_Get_3");
            self.Button_Get_2 = rc.Get<GameObject>("Button_Get_2");
            self.Button_Get_1 = rc.Get<GameObject>("Button_Get_1");
            self.Button_Get_3.SetActive(false);
            self.Button_Get_2.SetActive(false);
            self.Button_Get_1.SetActive(false);
            ButtonHelp.AddListenerEx(self.Button_Get_1, () => { self.RequestGetFirstWinSelf(1).Coroutine(); });
            ButtonHelp.AddListenerEx(self.Button_Get_2, () => { self.RequestGetFirstWinSelf(2).Coroutine(); });
            ButtonHelp.AddListenerEx(self.Button_Get_3, () => { self.RequestGetFirstWinSelf(3).Coroutine(); });

            self.Button_Complete_3 = rc.Get<GameObject>("Button_Complete_3");
            self.Button_Complete_2 = rc.Get<GameObject>("Button_Complete_2");
            self.Button_Complete_1 = rc.Get<GameObject>("Button_Complete_1");
            self.Button_Complete_3.SetActive(false);
            self.Button_Complete_2.SetActive(false);
            self.Button_Complete_1.SetActive(false);

            self.TextTip_Title = rc.Get<GameObject>("TextTip_Title");
            self.TextHintTips = rc.Get<GameObject>("TextHintTips");

            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.GameObject.SetActive(false); });
        }
    }

    public static class UIFirstWinRewardComponentSystem
    {
        public static void OnUpdateUI(this UIFirstWinRewardComponent self, int firstWinId)
        {
            self.FristWinId = firstWinId;
            self.TextTip_Title.GetComponent<Text>().text = "首胜奖励";
            self.GameObject.SetActive(true);
            self.Button_Get_3.SetActive(false);
            self.Button_Get_2.SetActive(false);
            self.Button_Get_1.SetActive(false);
            self.Button_Complete_3.SetActive(false);
            self.Button_Complete_2.SetActive(false);
            self.Button_Complete_1.SetActive(false);

            UICommonHelper.DestoryChild(self.RewardListNode1);
            UICommonHelper.DestoryChild(self.RewardListNode2);
            UICommonHelper.DestoryChild(self.RewardListNode3);

            FirstWinConfig firstWin = FirstWinConfigCategory.Instance.Get(firstWinId);
            UICommonHelper.ShowItemList(firstWin.RewardList_1, self.RewardListNode1, self, 0.9f, true);
            UICommonHelper.ShowItemList(firstWin.RewardList_2, self.RewardListNode2, self, 0.9f, true);
            UICommonHelper.ShowItemList(firstWin.RewardList_3, self.RewardListNode3, self, 0.9f, true);

            self.TextHintTips.SetActive(true);
        }

        public static async ETTask RequestGetFirstWinSelf(this UIFirstWinRewardComponent self, int diff)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (!userInfoComponent.IsHaveGetFristWinReward(self.FristWinId, diff))
            {
                FloatTipManager.Instance.ShowFloatTip("对应难度的领主怪物未被击败,请先击败对应怪物") ;
                return;
            }

            C2M_FirstWinSelfRewardRequest request = new C2M_FirstWinSelfRewardRequest() { FirstWinId = self.FristWinId, Difficulty = diff };
            M2C_FirstWinSelfRewardResponse  response = (M2C_FirstWinSelfRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.ZoneScene().GetComponent<UserInfoComponent>().OnGetFirstWinSelf( self.FristWinId, diff );

            self.OnUpdateUISelf( self.FristWinId );
        }

        public static void OnUpdateUISelf(this UIFirstWinRewardComponent self, int firstWinId)
        {
            self.FristWinId = firstWinId;
            self.GameObject.SetActive(true);
            self.TextTip_Title.GetComponent<Text>().text = "个人奖励";

            UICommonHelper.DestoryChild(self.RewardListNode1);
            UICommonHelper.DestoryChild(self.RewardListNode2);
            UICommonHelper.DestoryChild(self.RewardListNode3);

            FirstWinConfig firstWin = FirstWinConfigCategory.Instance.Get(firstWinId);
            UICommonHelper.ShowItemList(firstWin.Self_RewardList_1, self.RewardListNode1, self, 0.9f, true);
            UICommonHelper.ShowItemList(firstWin.Self_RewardList_2, self.RewardListNode2, self, 0.9f, true);
            UICommonHelper.ShowItemList(firstWin.Self_RewardList_3, self.RewardListNode3, self, 0.9f, true);

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.Button_Complete_1.SetActive(userInfoComponent.IsReceivedFristWinReward(firstWinId, 1));
            self.Button_Complete_2.SetActive(userInfoComponent.IsReceivedFristWinReward(firstWinId, 2));
            self.Button_Complete_3.SetActive(userInfoComponent.IsReceivedFristWinReward(firstWinId, 3));
            self.Button_Get_1.SetActive( !self.Button_Complete_1.activeSelf );
            self.Button_Get_2.SetActive( !self.Button_Complete_2.activeSelf );
            self.Button_Get_3.SetActive( !self.Button_Complete_3.activeSelf);

            self.TextHintTips.SetActive(false);
        }
    }
}
