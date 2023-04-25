using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDonationShowItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject ImageHeadIcon;
        public GameObject Button_WatchEquip;
        public GameObject Text_Combat;
        public GameObject Text_Level;
        public GameObject Text_Name;
        public GameObject Text_Rank;

        public RankingInfo RankingInfo;
    }

    public class UIDonationShowItemComponentAwake : AwakeSystem<UIDonationShowItemComponent, GameObject>
    {
        public override void Awake(UIDonationShowItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageHeadIcon = rc.Get<GameObject>("ImageHeadIcon");

            self.Button_WatchEquip = rc.Get<GameObject>("Button_WatchEquip");
            self.Button_WatchEquip.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.OnButtonWatch().Coroutine();
            });

            self.Text_Combat = rc.Get<GameObject>("Text_Combat");
            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Rank = rc.Get<GameObject>("Text_Rank");
        }
    }

    public static class UIDonationShowItemComponentSystem
    {
        public static async ETTask OnButtonWatch(this UIDonationShowItemComponent self)
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

        public static void OnUpdateUI(this UIDonationShowItemComponent self, int rank, RankingInfo rankingInfo)
        {
            self.RankingInfo = rankingInfo;

            self.Text_Combat.GetComponent<Text>().text = rankingInfo.Combat.ToString();
            self.Text_Level.GetComponent<Text>().text = rankingInfo.PlayerLv.ToString();
            self.Text_Name.GetComponent<Text>().text = rankingInfo.PlayerName.ToString();
            self.Text_Rank.GetComponent<Text>().text = rank.ToString();
            UICommonHelper.ShowOccIcon(self.ImageHeadIcon, rankingInfo.Occ);
        }
    }
}
