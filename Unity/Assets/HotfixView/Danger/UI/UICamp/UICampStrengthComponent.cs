using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UICampStrengthComponent : Entity, IAwake
    {
        public GameObject Text_Tip_2;
        public GameObject Text_Tip_1;

        public GameObject StrengthNodeList_2;
        public GameObject StrengthNodeList_1;
    }

    [ObjectSystem]
    public class UICampStrengthComponentAwake : AwakeSystem<UICampStrengthComponent>
    {
        public override void Awake(UICampStrengthComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip_2 = rc.Get<GameObject>("Text_Tip_2");
            self.Text_Tip_1 = rc.Get<GameObject>("Text_Tip_1");
            self.StrengthNodeList_2 = rc.Get<GameObject>("StrengthNodeList_2");
            self.StrengthNodeList_1 = rc.Get<GameObject>("StrengthNodeList_1");

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UICampStrengthComponentSystem
    {

        public static async ETTask UpdateCampRank(this UICampStrengthComponent self, List<RankingInfo> rankingInfos, GameObject bundleObj,  GameObject itemNode)
        {
            long instanceid = self.InstanceId;
            for (int i = 0; i < rankingInfos.Count; i++)
            {
                if (i % 10 == 0)
                {
                    await TimerComponent.Instance.WaitAsync(1);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }

                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, itemNode);
                UICampStrengthItemComponent itemComponent = self.AddChild<UICampStrengthItemComponent, GameObject>(skillItem);
                itemComponent.OnInitUI(i+1, rankingInfos[i]);
            }
        }
             
        public static async ETTask OnUpdateUI(this UICampStrengthComponent self)
        {
            C2R_CampRankListRequest c2M_RankListRequest = new C2R_CampRankListRequest();
            R2C_CampRankListResponse r2C_Response = (R2C_CampRankListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RankListRequest);

            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Camp/UICampStrengthItem");
            GameObject bundleObj =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            self.UpdateCampRank(r2C_Response.RankList_1, bundleObj, self.StrengthNodeList_1).Coroutine();
            self.UpdateCampRank(r2C_Response.RankList_2, bundleObj, self.StrengthNodeList_2).Coroutine();
        }
    }
}
