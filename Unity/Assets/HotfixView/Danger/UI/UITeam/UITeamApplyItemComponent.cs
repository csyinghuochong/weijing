using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamApplyItemComponent : Entity, IAwake
    {

        public GameObject TextCombat;
        public GameObject TextLevel;
        public GameObject TextName;
        public GameObject TextOcc;
        public GameObject RootShowSet;
        public GameObject ButtonAgree;
        public GameObject ButtonRefuse;

        public TeamPlayerInfo TeamPlayerInfo;
    }


    public class UITeamApplyItemComponentAwakeSystem : AwakeSystem<UITeamApplyItemComponent>
    {
        public override void Awake(UITeamApplyItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextCombat = rc.Get<GameObject>("TextCombat");
            self.TextLevel = rc.Get<GameObject>("TextLevel");
            self.TextName = rc.Get<GameObject>("TextName");
            self.TextOcc = rc.Get<GameObject>("TextOcc");
            self.RootShowSet = rc.Get<GameObject>("RootShowSet");

            self.ButtonAgree = rc.Get<GameObject>("ButtonAgree");
            ButtonHelp.AddListenerEx(self.ButtonAgree, () => { self.OnButtonAgree().Coroutine();  });

            self.ButtonRefuse = rc.Get<GameObject>("ButtonRefuse");
            ButtonHelp.AddListenerEx(self.ButtonRefuse, () => { self.OnButtonRefuse().Coroutine(); });
        }
    }

    public static class UITeamApplyItemComponentSystem
    {
        public static void OnUpdateUI(this UITeamApplyItemComponent self, TeamPlayerInfo teamPlayerInfo)
        {
            self.TeamPlayerInfo = teamPlayerInfo;
            self.TextName.GetComponent<Text>().text = teamPlayerInfo.PlayerName;
            self.TextCombat.GetComponent<Text>().text = $"战力：{teamPlayerInfo.Combat}";
            self.TextLevel.GetComponent<Text>().text = $"等级：{teamPlayerInfo.PlayerLv}";
            
            string occName = "";
            if (teamPlayerInfo.OccTwo != 0)
            {
                OccupationTwoConfig occtwoCof = OccupationTwoConfigCategory.Instance.Get(teamPlayerInfo.OccTwo);
                occName = occtwoCof.OccupationName;
            }
            else {
                OccupationConfig occCof = OccupationConfigCategory.Instance.Get(teamPlayerInfo.Occ);
                occName = occCof.OccupationName;
            }
            self.TextOcc.GetComponent<Text>().text = occName;
            //是否是人机
            if (teamPlayerInfo.RobotId > 0)
            {
                self.RootShowSet.SetActive(true);
            }
            else {
                self.RootShowSet.SetActive(false);
            }

        }

        public static async ETTask OnButtonAgree(this UITeamApplyItemComponent self)
        {
            await self.ZoneScene().GetComponent<TeamComponent>().AgreeTeamApply(self.TeamPlayerInfo, 1);

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UITeamApplyList);
            uI.GetComponent<UITeamApplyListComponent>().OnUpdateUI();
        }

        public static async ETTask OnButtonRefuse(this UITeamApplyItemComponent self)
        {
            await self.ZoneScene().GetComponent<TeamComponent>().AgreeTeamApply(self.TeamPlayerInfo, 0);

            UI uI = UIHelper.GetUI( self.ZoneScene(), UIType.UITeamApplyList  );
            uI.GetComponent<UITeamApplyListComponent>().OnUpdateUI();
        }
    }

}
