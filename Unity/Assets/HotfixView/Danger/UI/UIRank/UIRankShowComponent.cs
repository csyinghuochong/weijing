using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankShowComponent : Entity, IAwake
    {
        public GameObject Button_Reward;
        public GameObject Text_MyRank;
        public GameObject RankListNode;
        public GameObject UISet;
        public List<UI> RankUIList;
    }


    public class UIRankShowComponentAwakeSystem : AwakeSystem<UIRankShowComponent>
    {
        public override void Awake(UIRankShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.RankUIList = new List<UI>();
            self.RankListNode = rc.Get<GameObject>("RankListNode");
            self.Text_MyRank = rc.Get<GameObject>("Text_MyRank");
            self.UISet = rc.Get<GameObject>("UISet");

            self.Button_Reward = rc.Get<GameObject>("Button_Reward");
            ButtonHelp.AddListenerEx(self.Button_Reward, () => { self.Button_Reward().Coroutine(); });

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIRankShowComponentSystem
    {
        public static  async ETTask Button_Reward(this UIRankShowComponent self)
        {
            self.UISet.SetActive(false);
            UI uiHelp =await  UIHelper.Create( self.ZoneScene(), UIType.UIRankReward );
            if (!self.IsDisposed && uiHelp != null)
            {
                uiHelp.GetComponent<UIRankRewardComponent>().ClickOnClose = self.OpenShow;
            }
        }

        public static void OpenShow(this UIRankShowComponent self)
        {
            self.UISet.SetActive(true);
        }

        public static async ETTask OnUpdateUI(this UIRankShowComponent self)
        {
            long instanceid = self.InstanceId;
            C2R_RankListRequest c2M_RankListRequest = new C2R_RankListRequest();
            R2C_RankListResponse r2C_Response = (R2C_RankListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RankListRequest);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            string path = ABPathHelper.GetUGUIPath("Main/Rank/UIRankShowItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            long selfId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            int myRank = -1;
            for (int i = 0; i < r2C_Response.RankList.Count; i++)
            {
                if (i % 5 == 0)
                {
                    await TimerComponent.Instance.WaitAsync(1);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }

                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, self.RankListNode);
                UI ui_1 = self.AddChild<UI, string, GameObject>("rewardItem_" + i, skillItem);
                UIRankShowItemComponent uIItemComponent = ui_1.AddComponent<UIRankShowItemComponent>();
                uIItemComponent.OnInitData(i + 1, r2C_Response.RankList[i]);

                if (selfId == r2C_Response.RankList[i].UserId)
                {
                    myRank = i + 1;
                }
            }

            if (myRank == -1)
            {
                self.Text_MyRank.GetComponent<Text>().text = "我的排名: 未上榜";
            }
            else
            {
                self.Text_MyRank.GetComponent<Text>().text = $"我的排名: {myRank}";
            }
        }

    }
}
