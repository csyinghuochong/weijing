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
            self.TextContent.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("玩家 <color=#{0}>{1}</color> {2} 出价： <color=#{3}>{4}</color>"), ComHelp.QualityReturnColor(4), record.PlayerName, dateTime.ToShortTimeString(), ComHelp.QualityReturnColor(2), record.Price);
        }
    }
}
