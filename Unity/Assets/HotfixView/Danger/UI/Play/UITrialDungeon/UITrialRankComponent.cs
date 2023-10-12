using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITrialRankComponent : Entity, IAwake
    {
        public GameObject Button_Reward;
        public GameObject Text_MyRank;
        public GameObject RankListNode;
        public GameObject UISet;
        public GameObject CloseButton;
        public GameObject UITrialRankItem;

    }

    public class UITrialRankComponentAwake : AwakeSystem<UITrialRankComponent>
    {
        public override void Awake(UITrialRankComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.RankListNode = rc.Get<GameObject>("RankListNode");
            self.Text_MyRank = rc.Get<GameObject>("Text_MyRank");
            self.UISet = rc.Get<GameObject>("UISet");
            self.UITrialRankItem = rc.Get<GameObject>("UITrialRankItem");
            self.UITrialRankItem.SetActive(false);

            self.Button_Reward = rc.Get<GameObject>("Button_Reward");
            ButtonHelp.AddListenerEx(self.Button_Reward, () => { self.Button_Reward().Coroutine(); });

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UITrialRankComponentSystem
    {
        public static async ETTask Button_Reward(this UITrialRankComponent self)
        {
            self.UISet.SetActive(false);
            UI uiHelp = await UIHelper.Create(self.ZoneScene(), UIType.UITrialReward);
            if (!self.IsDisposed && uiHelp != null)
            {
                uiHelp.GetComponent<UITrialRewardComponent>().OnInitUI(6);
                uiHelp.GetComponent<UITrialRewardComponent>().ClickOnClose = self.OpenShow;
            }
        }

        public static void OpenShow(this UITrialRankComponent self)
        {
            self.UISet.SetActive(true);
        }

        public static async ETTask OnUpdateUI(this UITrialRankComponent self)
        {
            long instanceid = self.InstanceId;
            C2R_RankTrialListRequest c2M_RankListRequest = new C2R_RankTrialListRequest();
            R2C_RankTrialListResponse r2C_Response = (R2C_RankTrialListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RankListRequest);
            if (instanceid != self.InstanceId)
            {
                return;
            }

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

                GameObject skillItem = GameObject.Instantiate(self.UITrialRankItem);
                skillItem.SetActive(true);
                UICommonHelper.SetParent(skillItem, self.RankListNode);
                UIRankShowItemComponent uIItemComponent = self.AddChild<UIRankShowItemComponent, GameObject>(skillItem);
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