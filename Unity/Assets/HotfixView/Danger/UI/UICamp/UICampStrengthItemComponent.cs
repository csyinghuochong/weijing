using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICampStrengthItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextStrength;
        public GameObject TextPosition;
        public GameObject TextName;
        public GameObject TextRank;
        public GameObject PlayerIcon;
        public GameObject ImageRank;
    }


    public class UICampStrengthItemComponentAwakeSystem : AwakeSystem<UICampStrengthItemComponent, GameObject>
    {
        public override void Awake(UICampStrengthItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextStrength = rc.Get<GameObject>("TextStrength");
            self.TextPosition = rc.Get<GameObject>("TextPosition");
            self.TextName = rc.Get<GameObject>("TextName");
            self.TextRank = rc.Get<GameObject>("TextRank");
            self.PlayerIcon = rc.Get<GameObject>("PlayerIcon");
            self.ImageRank = rc.Get<GameObject>("ImageRank");
        }
    }

    public static class UICampStrengthItemComponentSystem
    {
        public static void OnInitUI(this UICampStrengthItemComponent self, int rank, RankingInfo rankingInfo)
        {
            self.TextStrength.GetComponent<Text>().text = rankingInfo.Combat.ToString();
            self.TextPosition.GetComponent<Text>().text = "门众";
            self.TextName.GetComponent<Text>().text = rankingInfo.PlayerName.ToString();
            UICommonHelper.ShowOccIcon(self.PlayerIcon, rankingInfo.Occ);

            self.TextRank.GetComponent<Text>().text = rank.ToString();
            self.ImageRank.SetActive(rank <= 3);
            self.TextRank.SetActive(rank > 3);
            for (int i = 0; i < 3; i++)
            {
                self.ImageRank.transform.Find((i + 1).ToString()).gameObject.SetActive(i+1 == rank);
            }
        }
    }
}
