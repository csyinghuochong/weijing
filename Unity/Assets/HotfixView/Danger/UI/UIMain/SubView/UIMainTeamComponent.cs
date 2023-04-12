using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIMainTeamComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject TeamNodeList;
        public GameObject Btn_RoseTeam;
        public List<UIMainTeamItemComponent> TeamUIList = new List<UIMainTeamItemComponent>();
    }


    public class UIMainTeamComponentAwakeSystem : AwakeSystem<UIMainTeamComponent, GameObject>
    {
        public override void Awake(UIMainTeamComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TeamNodeList = rc.Get<GameObject>("TeamNodeList");
            
            self.Btn_RoseTeam = rc.Get<GameObject>("Btn_RoseTeam");
            ButtonHelp.AddListenerEx(self.Btn_RoseTeam, self.OnBtn_RoseTeam);

            self.TeamUIList.Clear();
            for (int i = 0; i < self.TeamNodeList.transform.childCount; i++)
            {
                GameObject item = self.TeamNodeList.transform.GetChild(i).gameObject;
                self.TeamUIList.Add(self.AddChild<UIMainTeamItemComponent, GameObject>(item));
                item.SetActive(false);
            }
        }
    }

    public static class UIMainTeamComponentSystem
    {

        public static void OnBtn_RoseTeam(this UIMainTeamComponent self)
        {
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null || teamInfo.PlayerList.Count == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("没有队伍！");
                return;
            }

            UIHelper.Create(self.DomainScene(), UIType.UITeam).Coroutine();
        }

        public static void OnUpdateDamage(this UIMainTeamComponent self, M2C_SyncMiJingDamage message)
        {
            for (int i = 0; i < message.DamageList.Count; i++)
            {
                UIMainTeamItemComponent uIMainTeamItemComponent = self.TeamUIList[i];
                uIMainTeamItemComponent.OnUpdateDamage(message.DamageList[i]);
            }
        }

        public static void OnUpdateHP(this UIMainTeamComponent self, Unit unit)
        {
            for (int i = 0; i < self.TeamUIList.Count; i++)
            {
                self.TeamUIList[i].OnUpdateHP(unit);
            }
        }

        public static void ResetUI(this UIMainTeamComponent self)
        {
            for (int i = 0; i < self.TeamUIList.Count; i++)
            {
                self.TeamUIList[i].OnReset();
            }
        }

        public static void OnUpdateUI(this UIMainTeamComponent self)
        {
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            for (int i = 0; i < self.TeamUIList.Count; i++)
            {
                self.TeamUIList[i].GameObject.SetActive(false);
            }
            if (teamInfo == null)
            {
                return;
            }

            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                self.TeamUIList[i].GameObject.SetActive(true);
                self.TeamUIList[i].OnUpdateItem(teamInfo.PlayerList[i]);
            }
        }

    }

}
