using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UITeamDungeonMyComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonApplyList;
        public GameObject Button_Leave;
        public GameObject Lab_FuBenLv;
        public GameObject Button_Enter;
        public GameObject Button_Call;
        public GameObject Obj_Lab_FuBenName;

        public GameObject[] UITeamNodeList = new GameObject[3];
        public List<UI> TeamUIList = new List<UI>();
    }

    [ObjectSystem]
    public class UITeamDungeonMyComponentDestroySystem : DestroySystem<UITeamDungeonMyComponent>
    {

        public override void Destroy(UITeamDungeonMyComponent self)
        {

            ReddotViewComponent redPointComponent = self.DomainScene().GetComponent<ReddotViewComponent>();
            redPointComponent.UnRegisterReddot(ReddotType.TeamApply, self.Reddot_TeamApply);
        }
    }

    [ObjectSystem]
    public class UITeamDungeonMyComponentAwakeSystem : AwakeSystem<UITeamDungeonMyComponent>
    {

        public override void Awake(UITeamDungeonMyComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_Enter = rc.Get<GameObject>("Button_Enter");
            ButtonHelp.AddListenerEx( self.Button_Enter, ()=> { self.OnButton_Enter().Coroutine();  } );

            self.Button_Call = rc.Get<GameObject>("Button_Call");
            ButtonHelp.AddListenerEx(self.Button_Call, () => { self.OnButton_Call(); });

            self.Button_Leave = rc.Get<GameObject>("Button_Leave");
            ButtonHelp.AddListenerEx(self.Button_Leave, () => { self.OnButton_Leave(); });

            self.ButtonApplyList = rc.Get<GameObject>("ButtonApplyList");
            ButtonHelp.AddListenerEx(self.ButtonApplyList, () => { self.OnButtonApplyList(); });

            self.Lab_FuBenLv = rc.Get<GameObject>("Lab_FuBenLv");
            self.Obj_Lab_FuBenName = rc.Get<GameObject>("Lab_FuBenName");
            self.UITeamNodeList[0] = rc.Get<GameObject>("UITeamNode1");
            self.UITeamNodeList[1] = rc.Get<GameObject>("UITeamNode2");
            self.UITeamNodeList[2] = rc.Get<GameObject>("UITeamNode3");
            self.TeamUIList.Clear();

            self.OnInitUI();

            ReddotViewComponent redPointComponent = self.ZoneScene().GetComponent<ReddotViewComponent>();
            redPointComponent.RegisterReddot(ReddotType.TeamApply, self.Reddot_TeamApply);
        }
    }

    public static class UITeamDungeonMyComponentSystem
    {

        public static void Reddot_TeamApply(this UITeamDungeonMyComponent self, int num)
        {
            self.ButtonApplyList.transform.Find("Reddot").gameObject.SetActive(num > 0);
        }

        public static void OnInitUI(this UITeamDungeonMyComponent self)
        {
            for (int i = 0; i < 3; i++)
            {
                UI ui_1 = self.AddChild<UI, string, GameObject>( "TaskShowItem_" + i.ToString(), self.UITeamNodeList[i]);
                UITeamItemComponent uIItemComponent = ui_1.AddComponent<UITeamItemComponent, int>(i);
                self.TeamUIList.Add(ui_1);
            }
        }

        public static void OnButtonApplyList(this UITeamDungeonMyComponent self)
        {
            ReddotComponent redPointComponent = self.ZoneScene().GetComponent<ReddotComponent>();
            redPointComponent.RemoveReddont(ReddotType.TeamApply);

            UIHelper.Create(self.ZoneScene(), UIType.UITeamApplyList).Coroutine();
        }

        public static void OnButton_Leave(this UITeamDungeonMyComponent self)
        {
            bool isLeader = self.ZoneScene().GetComponent<TeamComponent>().IsTeamLeader();
          
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "我的队伍", isLeader ? "是否离开队伍" : "是否离开队伍？",
                () =>
                {
                    self.ZoneScene().GetComponent<TeamComponent>().SendLeaveRequest().Coroutine();
                }
                ).Coroutine();
        }

        public static void OnButton_Call(this UITeamDungeonMyComponent self)
        {
            //<link=“id”>111111111</link>点击取出“id”
            TeamComponent teamComponent = self.ZoneScene().GetComponent<TeamComponent>();
            TeamInfo teamInfo = teamComponent.GetSelfTeam();
            if (teamInfo == null || teamInfo.SceneId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("没有副本队伍");
                return;
            }
            string text = $" 副本:{SceneConfigCategory.Instance.Get(teamInfo.SceneId).Name}开启冒险,现邀请你的加入！ <link=team_{teamInfo.TeamId}_{teamInfo.SceneId}_{teamInfo.FubenType}_{teamInfo.PlayerList[0].PlayerLv}><color=#B5FF28><u>点击申请加入</u></color></link>";
            self.ZoneScene().GetComponent<ChatComponent>().SendChat(ChannelEnum.Word, text).Coroutine();
        }

        public static async ETTask OnButton_Enter(this UITeamDungeonMyComponent self)
        {
            TeamComponent teamComponent = self.ZoneScene().GetComponent<TeamComponent>();
            int errorCode = await teamComponent.RequestTeamDungeonOpen();
            if (errorCode != ErrorCore.ERR_Success)
            {
                ErrorHelp.Instance.ErrorHint(errorCode);
            }
        }

        public static void OnUpdateUI(this UITeamDungeonMyComponent self)
        {
            TeamComponent teamComponent = self.ZoneScene().GetComponent<TeamComponent>();
            TeamInfo teamInfo = teamComponent.GetSelfTeam();
            self.TeamUIList[0].GetComponent<UITeamItemComponent>().OnUpdateItem(null);
            self.TeamUIList[1].GetComponent<UITeamItemComponent>().OnUpdateItem(null);
            self.TeamUIList[2].GetComponent<UITeamItemComponent>().OnUpdateItem(null);
            if (teamInfo == null)
            {
                return;
            }

            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                UI ui_1 = self.TeamUIList[i];
                ui_1.GetComponent<UITeamItemComponent>().OnUpdateItem(teamInfo.PlayerList[i]);
            }

            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(teamInfo.SceneId);
            self.Obj_Lab_FuBenName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("挑战副本") + ":" + sceneConfig.Name;
            self.Lab_FuBenLv.GetComponent<Text>().text = $"{GameSettingLanguge.LoadLocalization("等级")}: {sceneConfig.EnterLv} - 50";
        }

    }

}