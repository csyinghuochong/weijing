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

        public GameObject UIRankShowItem;
        public UIPageButtonComponent UIPageButton;
    }


    public class UIRankShowComponentAwakeSystem : AwakeSystem<UIRankShowComponent>
    {
        public override void Awake(UIRankShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.RankListNode = rc.Get<GameObject>("RankListNode");
            self.Text_MyRank = rc.Get<GameObject>("Text_MyRank");
            self.UISet = rc.Get<GameObject>("UISet");
            self.UIRankShowItem = rc.Get<GameObject>("UIRankShowItem");
            self.UIRankShowItem.SetActive(false);
            
            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIRankShowComponentSystem
    {
        public static void OnClickPageButton(this UIRankShowComponent self,  int page)
        {
            self.OnUpdateUI(page).Coroutine();
        }

        public static void OpenShow(this UIRankShowComponent self)
        {
            self.UISet.SetActive(true);
        }

        public static async ETTask OnUpdateUI(this UIRankShowComponent self,int type = 0)
        {
            long instanceid = self.InstanceId;
            C2R_RankListRequest c2M_RankListRequest = new C2R_RankListRequest();
            R2C_RankListResponse r2C_Response = (R2C_RankListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RankListRequest);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            long selfId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            int myRank = -1;
            int rank = 1;
            UICommonHelper.DestoryChild(self.RankListNode);
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

                if (type != 0 && r2C_Response.RankList[i].Occ != type)
                {
                    continue;
                }

                GameObject uirankShowItem = UnityEngine.Object.Instantiate(self.UIRankShowItem);
                uirankShowItem.SetActive(true);
                UICommonHelper.SetParent(uirankShowItem, self.RankListNode);
                UIRankShowItemComponent uIItemComponent = self.AddChild<UIRankShowItemComponent, GameObject>(uirankShowItem);
                uIItemComponent.OnInitData(rank, r2C_Response.RankList[i]);

                if (selfId == r2C_Response.RankList[i].UserId)
                {
                    myRank = rank;
                }

                rank++;
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
