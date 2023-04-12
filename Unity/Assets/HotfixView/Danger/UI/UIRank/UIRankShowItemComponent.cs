using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankShowItemComponent : Entity, IAwake
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

        public RankingInfo RankingInfo;
    }


    public class UIRankShowItemComponentAwakeSystem : AwakeSystem<UIRankShowItemComponent>
    {
        public override void Awake(UIRankShowItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

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

    public static class UIRankShowItemComponentSystem
    {
        public static async ETTask OnButtonWatch(this UIRankShowItemComponent self)
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


        public static void OnInitData(this UIRankShowItemComponent self, int rank, RankingInfo rankingInfo)
        {
            self.RankingInfo = rankingInfo;

            self.Text_Combat.GetComponent<Text>().text = rankingInfo.Combat.ToString();
            self.Text_Level.GetComponent<Text>().text = rankingInfo.PlayerLv.ToString();
            self.Text_Name.GetComponent<Text>().text = rankingInfo.PlayerName.ToString();
            self.Text_Rank.GetComponent<Text>().text = rank.ToString();
            UICommonHelper.ShowOccIcon(self.ImageHeadIcon, rankingInfo.Occ);

            if (rank >= 4)
            {
                self.RankShowSet.SetActive(false);
            }
            else {
                self.RankShowSet.SetActive(true);
                self.Text_Rank.SetActive(false);
                switch (rank) {

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
