using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UIAuctionRecodeItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextContent;
        public GameObject HeadIcon;
    }

    public class UIAuctionRecodeItemComponentAwake : AwakeSystem<UIAuctionRecodeItemComponent, GameObject>
    {
        public override void Awake(UIAuctionRecodeItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextContent = rc.Get<GameObject>("TextContent");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
        }
    }

    public  static  class UIAuctionRecodeItemComponentSystem
    {
        public static void OnInitUI(this UIAuctionRecodeItemComponent self, PaiMaiAuctionRecord record)
        { 
            
        }
    }
}
