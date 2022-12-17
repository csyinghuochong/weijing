using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamDungeonListComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject Button_Create;
        public GameObject ItemNodeList;
        public GameObject Text_LeftTime;
        public GameObject Text_XieZhuNum;

        public List<UI> TeamUIList = new List<UI>();
    }

    [ObjectSystem]
    public class UITeamDungeonListComponentAwake : AwakeSystem<UITeamDungeonListComponent, GameObject>
    {

        public override void Awake(UITeamDungeonListComponent self, GameObject gameObject)
        {
            self.TeamUIList.Clear();
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_XieZhuNum = rc.Get<GameObject>("Text_XieZhuNum");
            self.Text_LeftTime = rc.Get<GameObject>("Text_LeftTime");
            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");

            self.Button_Create = rc.Get<GameObject>("Button_Create");
            self.Button_Create.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Create(); });

            DataUpdateComponent.Instance.AddListener(DataType.TeamUpdate, self);
        }
    }

    public static class UITeamDungeonListComponentSystem
    {
        public static void  OnButton_Create(this UITeamDungeonListComponent self)
        {
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo != null && teamInfo.SceneId != 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经有队伍了");
                return;
            }

            UIHelper.Create(self.DomainScene(), UIType.UITeamDungeonCreate).Coroutine();
        }

        public static  void OnUpdateUI(this UITeamDungeonListComponent self)
        {
            TeamComponent teamComponent = self.ZoneScene().GetComponent<TeamComponent>();
            List<TeamInfo> teamList = teamComponent.TeamList;

            var path = ABPathHelper.GetUGUIPath("TeamDungeon/UITeamDungeonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            int number = 0;
            for (int i = 0; i < teamList.Count; i++)
            {
                if (teamList[i].SceneId == 0)
                {
                    continue;
                }
                UI uI_1 = null;
                if (number < self.TeamUIList.Count)
                {
                    uI_1 = self.TeamUIList[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ItemNodeList);
                    uI_1 = self.AddChild<UI, string, GameObject>("UIItem_" + i, go);
                    uI_1.AddComponent<UITeamDungeonItemComponent>();
                    self.TeamUIList.Add(uI_1);
                }
                uI_1.GetComponent<UITeamDungeonItemComponent>().OnUpdateUI(teamList[i]);

                number++;
            }

            for (int i = number; i < self.TeamUIList.Count; i++)
            {
                self.TeamUIList[i].GameObject.SetActive(false);
            }

            int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
            int times = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetTeamDungeonTimes();
            int leftTimes = totalTimes - times;
            self.Text_LeftTime.SetActive(true);
            self.Text_LeftTime.GetComponent<Text>().text = $"副本次数：{leftTimes}/{totalTimes}";

            totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(74).Value);
            times = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetTeamDungeonXieZhu();
            self.Text_XieZhuNum.GetComponent<Text>().text = $"副本次数：{leftTimes}/{totalTimes}";
        }
    }
}

