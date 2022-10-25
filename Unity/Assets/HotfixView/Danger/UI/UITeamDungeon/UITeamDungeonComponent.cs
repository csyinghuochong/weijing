using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    //按钮枚举
    public enum TeamDungeonPageEnum : int
    {
        AllDungeon = 0,
        MyDungeon = 1,
    }

    public class UITeamDungeonComponent : Entity, IAwake, IDestroy
    {
        public GameObject UITeamDungeonList;
        public GameObject UITeamDungeonMy;

        public GameObject Text_LeftTime;
        public GameObject Button_Create;
        public GameObject ItemNodeList;

        public List<UI> TeamUIList = new List<UI>();

        public UIPageButtonComponent UIPageButtonComponent_1;
        public UITeamDungeonMyComponent UITeamDungeonMyComponent;

        public GameObject CloseButton;
    }

    [ObjectSystem]
    public class UITeamDungeonComponentAwakeSystem : AwakeSystem<UITeamDungeonComponent>
    {

        public override void Awake(UITeamDungeonComponent self)
        {
            self.TeamUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeon); });

            self.Text_LeftTime = rc.Get<GameObject>("Text_LeftTime");
            self.UITeamDungeonList = rc.Get<GameObject>("UITeamDungeonList");
            self.UITeamDungeonMy = rc.Get<GameObject>("UITeamDungeonMy");
            self.UITeamDungeonMy.SetActive(false);

            self.Button_Create = rc.Get<GameObject>("Button_Create");
            self.Button_Create.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_Create().Coroutine(); });

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");

            //单选组件1
            GameObject BtnItemTypeSet = rc.Get<GameObject>("FunctionSetBtn");
            UI uiPage = self.AddChild<UI, string, GameObject>( "FunctionSetBtn", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton_1(page);
            });
            uIPageViewComponent.CheckHandler = (int page) => { return self.CheckPageButton_1(page); };      //注册回调
            uIPageViewComponent.ClickEnabled = false;
            self.UIPageButtonComponent_1 = uIPageViewComponent;

            UI uiDungeonMy = self.AddChild<UI, string, GameObject>( "TeamDungeonMy", self.UITeamDungeonMy);
            self.UITeamDungeonMyComponent = uiDungeonMy.AddComponent<UITeamDungeonMyComponent>();

            self.RequestTeamDungeonInfo().Coroutine();

            DataUpdateComponent.Instance.AddListener(DataType.TeamUpdate, self);
        }
    }

    [ObjectSystem]
    public class UITeamDungeonComponentDestroySystem : DestroySystem<UITeamDungeonComponent>
    {
        public override void Destroy(UITeamDungeonComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.TeamUpdate, self);
        }
    }

    public static class UITeamDungeonComponentSystem
    {
        public static async ETTask RequestTeamDungeonInfo(this UITeamDungeonComponent self)
        {
            int errorCode = await self.ZoneScene().GetComponent<TeamComponent>().RequestTeamDungeonList();
            self.UIPageButtonComponent_1.ClickEnabled = true;

            //判定当前是否有副本队伍
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null || teamInfo.SceneId == 0)
            {
                //无副本队伍
                self.UIPageButtonComponent_1.OnSelectIndex(0);
            }
            else {
                //有副本队伍
                self.UIPageButtonComponent_1.OnSelectIndex(1);
            }
            self.OnUpdateUI().Coroutine();
        }

        public static void OnTeamUpdate(this UITeamDungeonComponent self)
        {
            self.OnUpdateUI().Coroutine();
            self.UITeamDungeonMyComponent.OnUpdateUI();

            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null && self.UIPageButtonComponent_1.GetCurrentIndex() != 0)
            {
                self.UIPageButtonComponent_1.OnSelectIndex(0);
            }
        }

        public static bool CheckPageButton_1(this UITeamDungeonComponent self, int page)
        {
            if ((TeamDungeonPageEnum)page == TeamDungeonPageEnum.MyDungeon)
            {
                //判断当前是否有队伍
                TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
                if (teamInfo == null || teamInfo.SceneId == 0)
                {
                    FloatTipManager.Instance.ShowFloatTip("请先创建或加入副本队伍");
                    return false;
                }
                return true;
            }
            return true;
        }

        public static void OnClickPageButton_1(this UITeamDungeonComponent self, int page)
        {
            //全部
            if ((TeamDungeonPageEnum)page == TeamDungeonPageEnum.AllDungeon) {
                self.UITeamDungeonList.SetActive(true);
                self.UITeamDungeonMy.SetActive(false);
            }

            if ((TeamDungeonPageEnum)page == TeamDungeonPageEnum.MyDungeon)
            {
                self.OnBtn_Type_My();
            }
        }

        public static void OnBtn_Type_My(this UITeamDungeonComponent self)
        {
            self.UITeamDungeonList.SetActive(false);
            self.UITeamDungeonMy.SetActive(true);
            self.UITeamDungeonMyComponent.OnUpdateUI();
        }

        public static async ETTask  OnButton_Create(this UITeamDungeonComponent self)
        {
            TeamInfo  teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo != null && teamInfo.SceneId != 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经有队伍了");
                return;
            }

            UI ui = await UIHelper.Create( self.DomainScene(), UIType.UITeamDungeonCreate );
        }

        public static async ETTask OnUpdateUI(this UITeamDungeonComponent self)
        {
            TeamComponent teamComponent = self.ZoneScene().GetComponent<TeamComponent>();
            List<TeamInfo> teamList = teamComponent.TeamList;

            var path = ABPathHelper.GetUGUIPath("TeamDungeon/UITeamDungeonItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

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

            //if (fubenId == 0)
            //{
            //    self.Text_LeftTime.SetActive(false);
            //}
            //else
            {
                int totalTimes = int.Parse( GlobalValueConfigCategory.Instance.Get(19).Value );
                int times = self.ZoneScene().GetComponent<UserInfoComponent>().GetTeamDungeonTimes();
                int leftTimes = totalTimes - times;
                self.Text_LeftTime.SetActive(true);
                self.Text_LeftTime.GetComponent<Text>().text = $"进入副本剩余次数：{leftTimes}/{totalTimes}";
            }
        }      

    }

}
