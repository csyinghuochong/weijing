using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UITeamComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonApplyList;
        public GameObject ButtonLeave;

        public GameObject[] UITeamNodeList = new GameObject[3];
        public List<UITeamItemComponent> TeamUIList = new List<UITeamItemComponent>();
    }


    public class UITeamComponentAwakeSystem : AwakeSystem<UITeamComponent>
    {

        public override void Awake(UITeamComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UITeamNodeList[2] = rc.Get<GameObject>("UITeamNode3");
            self.UITeamNodeList[1] = rc.Get<GameObject>("UITeamNode2");
            self.UITeamNodeList[0] = rc.Get<GameObject>("UITeamNode1");

            self.ButtonLeave = rc.Get<GameObject>("ButtonLeave");
            self.ButtonLeave.GetComponent<Button>().onClick.AddListener(() => { self.On_ButtonLeave(); });

            self.ButtonApplyList = rc.Get<GameObject>("ButtonApplyList");
            self.ButtonApplyList.GetComponent<Button>().onClick.AddListener(() => { self.On_ButtonApplyList(); });

            self.TeamUIList.Clear();

            DataUpdateComponent.Instance.AddListener(DataType.TeamUpdate, self);

            self.OnInitUI();
            self.OnUpdateUI();

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.TeamApply, self.Reddot_TeamApply);
        }
    }


    public class UITeamComponentDestroySystem : DestroySystem<UITeamComponent>
    {
        public override void Destroy(UITeamComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.TeamUpdate, self);

            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.TeamApply, self.Reddot_TeamApply);
        }
    }

    public static class UITeamComponentSystem
    {
        public static void Reddot_TeamApply(this UITeamComponent self, int num)
        {

            self.ButtonApplyList.transform.Find("Reddot").gameObject.SetActive(num > 0);
        }

        public static void OnTeamUpdate(this UITeamComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnInitUI(this UITeamComponent self)
        {
            for (int i = 0; i < 3; i++)
            {
                UITeamItemComponent ui_1 = self.AddChild<UITeamItemComponent, GameObject>( self.UITeamNodeList[i]);
                ui_1.OnInitUI(i);
                self.TeamUIList.Add(ui_1);
            }
        }

        public static void OnUpdateUI(this UITeamComponent self)
        {
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            self.TeamUIList[0].OnUpdateItem(null);
            self.TeamUIList[1].OnUpdateItem(null);
            self.TeamUIList[2].OnUpdateItem(null);
            if (teamInfo == null)
            {
                return;
            }

            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                self.TeamUIList[i].OnUpdateItem(teamInfo.PlayerList[i]);
            }
        }

        public static void SendLeaveRequest(this UITeamComponent self)
        {
            self.ZoneScene().GetComponent<TeamComponent>().SendLeaveRequest().Coroutine();
            UIHelper.Remove(self.DomainScene(), UIType.UITeam);
        }

        public static void On_ButtonApplyList(this UITeamComponent self)
        {
            ReddotComponent redPointComponent = self.ZoneScene().GetComponent<ReddotComponent>();
            redPointComponent.RemoveReddont(ReddotType.TeamApply);

            UIHelper.Create(self.ZoneScene(), UIType.UITeamApplyList).Coroutine();
        }

        public static void On_ButtonLeave(this UITeamComponent self)
        {
            bool isLeader = self.ZoneScene().GetComponent<TeamComponent>().IsTeamLeader();
            
            PopupTipHelp.OpenPopupTip( self.DomainScene(), "我的队伍", isLeader ? "是否解散队伍": "是否离开队伍？", 
                ()=> 
                {
                    self.SendLeaveRequest();
                }
                ).Coroutine();
        }

    }
}
