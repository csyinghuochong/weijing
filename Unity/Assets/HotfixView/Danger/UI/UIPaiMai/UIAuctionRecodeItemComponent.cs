using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

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
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextContent = rc.Get<GameObject>("TextContent");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
        }
    }

    public  static  class UIAuctionRecodeItemComponentSystem
    {
        public static void OnInitUI(this UIAuctionRecodeItemComponent self, PaiMaiAuctionRecord record)
        {
            DateTime dateTime =  TimeInfo.Instance.ToDateTime(record.Time);
            self.TextContent.GetComponent<Text>().text = $"玩家 {record.PlayerName} {dateTime.ToString()} 出价：{record.Price}";
        }
    }
}
