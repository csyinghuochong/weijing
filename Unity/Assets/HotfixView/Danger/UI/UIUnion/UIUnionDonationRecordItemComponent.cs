using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionDonationRecordItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextContent;
        public GameObject HeadIcon;
    }

    public class UIUnionDonationRecordItemComponentAwake : AwakeSystem<UIUnionDonationRecordItemComponent, GameObject>
    {
        public override void Awake(UIUnionDonationRecordItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextContent = rc.Get<GameObject>("TextContent");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
        }
    }

    public static class UIUnionDonationRecordItemComponentSystem
    {
        public static void OnInitUI(this UIUnionDonationRecordItemComponent self, DonationRecord donationRecord)
        {
            DateTime dateTime = TimeInfo.Instance.ToDateTime(donationRecord.Time);
            self.TextContent.GetComponent<Text>().text = $"玩家 <color=#{ComHelp.QualityReturnColor(4)}>{donationRecord.Name}</color> {dateTime.ToShortTimeString()} 捐献： <color=#{ComHelp.QualityReturnColor(2)}>{donationRecord.Gold}</color>";

            UICommonHelper.ShowOccIcon(self.HeadIcon, donationRecord.Occ);
        }
    }
}
