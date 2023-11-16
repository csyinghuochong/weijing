using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITrialRankShowItemComponent : Entity, IAwake<GameObject>
    {

        public GameObject ImageHeadIcon;
        public GameObject ImageBg2;
        public GameObject ImageBg1;
        public GameObject Button_WatchPet;
        public GameObject Button_WatchEquip;
        public GameObject Text_Combat;
        public GameObject Text_Level;
        public GameObject Text_Name;
        public GameObject Text_Rank;
        public GameObject RankShowSet;

        public GameObject Rank_1;
        public GameObject Rank_2;
        public GameObject Rank_3;

        public RankingTrialInfo RankingInfo;
    }


    public class UITrialRankShowItemComponentAwake : AwakeSystem<UITrialRankShowItemComponent, GameObject>
    {
        public override void Awake(UITrialRankShowItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            //self.ImageBg2 = rc.Get<GameObject>("ImageBg2");
            //self.ImageBg1 = rc.Get<GameObject>("ImageBg1");

            self.Button_WatchPet = rc.Get<GameObject>("Button_WatchPet");
            self.Button_WatchEquip = rc.Get<GameObject>("Button_WatchEquip");
            ButtonHelp.AddListenerEx(self.Button_WatchEquip, () => { self.OnButtonWatch().Coroutine(); });

            self.Text_Combat = rc.Get<GameObject>("Text_Combat");
            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Rank = rc.Get<GameObject>("Text_Rank");

            self.RankShowSet = rc.Get<GameObject>("RankShowSet");
            self.Rank_1 = rc.Get<GameObject>("Rank_1");
            self.Rank_2 = rc.Get<GameObject>("Rank_2");
            self.Rank_3 = rc.Get<GameObject>("Rank_3");
            self.ImageHeadIcon = rc.Get<GameObject>("ImageHeadIcon");
        }
    }

    public static class UITrialRankShowItemComponentSystem
    {
        public static async ETTask OnButtonWatch(this UITrialRankShowItemComponent self)
        {
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.RankingInfo.UserId };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
            if (self.IsDisposed)
            {
                return;
            }

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatch);
            if (self.IsDisposed)
            {
                return;
            }
            uI.GetComponent<UIWatchComponent>().OnUpdateUI(m2C_SkillSet);
        }


        public static void OnInitData(this UITrialRankShowItemComponent self, int rank, RankingTrialInfo rankingInfo)
        {
            self.RankingInfo = rankingInfo;

            //试炼之塔排行先按照层树排序,层序一样按照秒伤 试炼排行榜得秒伤处也显示层数和秒伤,
            //比如40层50000秒伤 显示格式为: 40层(50000/秒)
            if (rankingInfo.FubenId == 0)
            {
                rankingInfo.FubenId = 20001;
            }
            TowerConfig towerConfig = TowerConfigCategory.Instance.Get(rankingInfo.FubenId);

            self.Text_Combat.GetComponent<Text>().text = $" {towerConfig.CengNum}层({rankingInfo.Hurt}/ 秒)";
            self.Text_Level.GetComponent<Text>().text = rankingInfo.PlayerLv.ToString();
            self.Text_Name.GetComponent<Text>().text = rankingInfo.PlayerName.ToString();
            self.Text_Rank.GetComponent<Text>().text = rank.ToString();
            UICommonHelper.ShowOccIcon(self.ImageHeadIcon, rankingInfo.Occ);

            if (rank >= 4)
            {
                self.RankShowSet.SetActive(false);
            }
            else
            {
                self.RankShowSet.SetActive(true);
                self.Text_Rank.SetActive(false);
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
