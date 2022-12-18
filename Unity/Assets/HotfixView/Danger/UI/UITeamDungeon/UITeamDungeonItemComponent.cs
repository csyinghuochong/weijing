using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;
using System;

namespace ET
{

    public class UITeamDungeonItemComponent : Entity, IAwake
    {

        public GameObject Text_Tuijian;
        public GameObject Button_Apply;
        public GameObject[] ImagePlayerList = new GameObject[3];
        public GameObject[] ImagePlayerNullList = new GameObject[3];
        public GameObject Text_Condition;
        public GameObject Text_Name;

        public TeamInfo TeamInfo;
    }


    [ObjectSystem]
    public class UITeamDungeonItemComponentAwakeSystem : AwakeSystem<UITeamDungeonItemComponent>
    {
        public override void Awake(UITeamDungeonItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tuijian = rc.Get<GameObject>("Text_Tuijian");
            self.Button_Apply = rc.Get<GameObject>("Button_Apply");
            self.Button_Apply.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Apply(); });

            self.ImagePlayerList[0] = rc.Get<GameObject>("ImagePlayer1");
            self.ImagePlayerList[1] = rc.Get<GameObject>("ImagePlayer2");
            self.ImagePlayerList[2] = rc.Get<GameObject>("ImagePlayer3");

            self.ImagePlayerNullList[0] = rc.Get<GameObject>("ImagePlayerNull_1");
            self.ImagePlayerNullList[1] = rc.Get<GameObject>("ImagePlayerNull_2");
            self.ImagePlayerNullList[2] = rc.Get<GameObject>("ImagePlayerNull_3");
            

            self.Text_Condition = rc.Get<GameObject>("Text_Condition");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
        }

    }

    public static class UITeamDungeonItemComponentSystem
    {

        public static void OnButton_Apply(this UITeamDungeonItemComponent self)
        {
            self.ZoneScene().GetComponent<TeamComponent>().SendTeamApply(self.TeamInfo.TeamId, self.TeamInfo.SceneId, self.TeamInfo.FubenType, self.TeamInfo.PlayerList[0].PlayerLv).Coroutine();
        }

        public static void OnUpdateUI(this UITeamDungeonItemComponent self, TeamInfo teamInfo)
        {
            self.TeamInfo = teamInfo;

            for (int i = 0; i < self.ImagePlayerList.Length; i++)
            {
                if (i >= teamInfo.PlayerList.Count)
                {
                    self.ImagePlayerList[i].SetActive(false);
                    self.ImagePlayerNullList[i].SetActive(true);
                    
                    continue;
                }

                TeamPlayerInfo teamPlayerInfo = teamInfo.PlayerList[i];
                self.ImagePlayerList[i].SetActive(true);
                self.ImagePlayerNullList[i].SetActive(false);
                self.ImagePlayerList[i].transform.Find("Text_Level").GetComponent<Text>().text = $"{teamPlayerInfo.PlayerLv}级";
                UICommonHelper.ShowOccIcon(self.ImagePlayerList[i].transform.Find("ImageMask/ImageHead").gameObject, teamPlayerInfo.Occ);
            }

            SceneConfig teamDungeonConfig = SceneConfigCategory.Instance.Get(teamInfo.SceneId);
            self.Text_Condition.GetComponent<Text>().text = $"进入条件: {teamDungeonConfig.EnterLv}级";

            string addStr = "";

            if (teamInfo.FubenType == TeamFubenType.XieZhu)
            {
                int lvCha = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv - teamDungeonConfig.EnterLv;
                if (lvCha >= 10)
                {
                    addStr = "(帮助模式)";
                }
            }

            self.Text_Name.GetComponent<Text>().text = teamDungeonConfig.Name + addStr;

            self.Text_Tuijian.GetComponent<Text>().text = $"推荐等级： {teamDungeonConfig.TuiJianLv[0]}-{teamDungeonConfig.TuiJianLv[1]}级";
        }

    }
}
