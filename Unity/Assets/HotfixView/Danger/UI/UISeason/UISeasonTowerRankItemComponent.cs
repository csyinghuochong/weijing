using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonTowerRankItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject NuText;
        public GameObject RankShowSet;
        public GameObject Rank_1;
        public GameObject Rank_2;
        public GameObject Rank_3;
        public GameObject NameText;
        public GameObject LayerText;
        public GameObject TimeText;
    }

    public class UISeasonTowerRankItemComponentAwake: AwakeSystem<UISeasonTowerRankItemComponent, GameObject>
    {
        public override void Awake(UISeasonTowerRankItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NuText = rc.Get<GameObject>("NuText");
            self.RankShowSet = rc.Get<GameObject>("RankShowSet");
            self.Rank_1 = rc.Get<GameObject>("Rank_1");
            self.Rank_2 = rc.Get<GameObject>("Rank_2");
            self.Rank_3 = rc.Get<GameObject>("Rank_3");
            self.NameText = rc.Get<GameObject>("NameText");
            self.LayerText = rc.Get<GameObject>("LayerText");
            self.TimeText = rc.Get<GameObject>("TimeText");
        }
    }

    public static class UISeasonTowerRankItemComponentSystem
    {
        public static void UpdateInfo(this UISeasonTowerRankItemComponent self, int rank, RankSeasonTowerInfo info)
        {
            self.NuText.GetComponent<Text>().text = rank.ToString();
            self.NameText.GetComponent<Text>().text = info.PlayerName;
            self.LayerText.GetComponent<Text>().text = $"{info.FubenId % 250000}层";
            self.TimeText.GetComponent<Text>().text =
                    $"{info.TotalTime / 3600000}小时{info.TotalTime % 3600000 / 60000}分{info.TotalTime % 3600000 % 60000 / 1000}秒";

            if (rank >= 4)
            {
                self.RankShowSet.SetActive(false);
            }
            else
            {
                self.RankShowSet.SetActive(true);
                self.NuText.SetActive(false);
                switch (rank)
                {
                    case 1:
                        self.Rank_1.SetActive(true);
                        break;

                    case 2:
                        self.Rank_2.SetActive(true);
                        break;

                    case 3:
                        self.Rank_3.SetActive(true);
                        break;
                }
            }
        }
    }
}