using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareDrawComponent: Entity, IAwake
    {
        public GameObject DrawList;
        public GameObject DrawItem;
        public GameObject DrawBtn;
        public List<GameObject> Draws = new List<GameObject>();
        
    }

    public class UIWelfareDrawComponentAwakeSystem: AwakeSystem<UIWelfareDrawComponent>
    {
        public override void Awake(UIWelfareDrawComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.DrawList = rc.Get<GameObject>("DrawList");
            self.DrawItem = rc.Get<GameObject>("DrawItem");
            self.DrawBtn = rc.Get<GameObject>("DrawBtn");
            
            self.DrawItem.SetActive(false);
        }
    }

    public static class UIWelfareDrawComponentSystem
    {
        public static void InitDraw(this UIWelfareDrawComponent self)
        {
            for (int i = 0; i < self.DrawList.transform.childCount; i++)
            {
                GameObject go = self.DrawList.transform.GetChild(i).gameObject;
                self.Draws.Add(go);
                UICommonHelper.DestoryChild(go.GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode"));
                UICommonHelper.ShowItemList(ConfigHelper.WelfareDrawList[i].Value,
                    go.GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode"), self, 0.8f);
            }
            
        }

        public static async ETTask StartDraw(this UIWelfareDrawComponent self)
        {
            // 开始抽奖，生成奖励格子。如果 NumericType.WelfareDraw > 0则不需要发送此协议，客户端直接做展示即可。将格子转到NumericType.WelfareDraw - 1即可
            
            
            
            //C2M_WelfareDrawRequest request2     = new C2M_WelfareDrawRequest();
            //M2C_WelfareDrawResponse response2 = (M2C_WelfareDrawResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request2);

            //////抽奖有一个转圈的效果，转圈结束后获取道具
            // C2M_WelfareDrawRewardRequest reques3 = new C2M_WelfareDrawRewardRequest();
            //M2C_WelfareDrawRewardResponse response13 = (M2C_WelfareDrawRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
        }
    }
}