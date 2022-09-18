using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIMainTeamComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject TeamNodeList;
        public GameObject UIMainTeamItem;
        public GameObject Btn_RoseTeam;
        public List<UIMainTeamItemComponent> TeamUIList = new List<UIMainTeamItemComponent>();
    }

    [ObjectSystem]
    public class UIMainTeamComponentAwakeSystem : AwakeSystem<UIMainTeamComponent, GameObject>
    {
        public override void Awake(UIMainTeamComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TeamNodeList = rc.Get<GameObject>("TeamNodeList");
            self.UIMainTeamItem = rc.Get<GameObject>("UIMainTeamItem");
            self.UIMainTeamItem.SetActive(false);

            self.Btn_RoseTeam = rc.Get<GameObject>("Btn_RoseTeam");
            self.Btn_RoseTeam.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_RoseTeam(); });

            self.TeamUIList.Clear();
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

        public static void OnUpdateDamage(this UIMainTeamComponent self, Unit unit)
        {
            long userId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            for (int i = 0; i < self.TeamUIList.Count; i++)
            {
                UIMainTeamItemComponent uIMainTeamItemComponent = self.TeamUIList[i];
                if (uIMainTeamItemComponent.PlayerID == userId)
                {
                    uIMainTeamItemComponent.OnUpdateDamage(unit.GetComponent<NumericComponent>().GetAsInt( (int)NumericType.Now_Damage ));
                }
            }
        }

        public static void OnUpdateHP(this UIMainTeamComponent self, Unit unit)
        {
            if (unit.GetComponent<UnitInfoComponent>().Type != UnitType.Player)
            {
                return;
            }
            for (int i = 0; i < self.TeamUIList.Count; i++)
            {
                self.TeamUIList[i].OnUpdateHP(unit);
            }
        }

        public static void OnReset(this UIMainTeamComponent self)
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
                UIMainTeamItemComponent ui_1 = null;
                if (i < self.TeamUIList.Count)
                {
                    ui_1 = self.TeamUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject item = GameObject.Instantiate(self.UIMainTeamItem);
                    item.SetActive(true);
                    UICommonHelper.SetParent(item, self.TeamNodeList);

                    ui_1 = self.AddChild<UIMainTeamItemComponent, GameObject>(item);
                    self.TeamUIList.Add(ui_1);
                }
                ui_1.OnUpdateItem(teamInfo.PlayerList[i]);
            }
        }

    }

}
