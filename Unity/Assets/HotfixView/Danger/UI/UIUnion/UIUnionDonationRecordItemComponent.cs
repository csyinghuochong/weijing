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
            if (donationRecord.Gold > 0)
            {
                self.TextContent.GetComponent<Text>().text =
                        string.Format(GameSettingLanguge.LoadLocalization("玩家 <color=#{0}>{1}</color> {2} 捐献： <color=#{3}>{4}</color>金币"), ComHelp.QualityReturnColor(4), donationRecord.Name, dateTime.ToShortTimeString(), ComHelp.QualityReturnColor(2), donationRecord.Gold);
            }
            else
            {
                self.TextContent.GetComponent<Text>().text =
                        string.Format(GameSettingLanguge.LoadLocalization("玩家 <color=#{0}>{1}</color> {2} 捐献： <color=#{3}>{4}</color>钻石"), ComHelp.QualityReturnColor(4), donationRecord.Name, dateTime.ToShortTimeString(), ComHelp.QualityReturnColor(2), donationRecord.Diamond);
            }

            UICommonHelper.ShowOccIcon(self.HeadIcon, donationRecord.Occ);
        }
    }
}
