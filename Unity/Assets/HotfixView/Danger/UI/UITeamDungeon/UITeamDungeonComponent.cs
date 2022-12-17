using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    //按钮枚举
    public static class TeamDungeonPageEnum
    {
        public const int TeamDungeonList = 0;
        public const int TeamDungeonMy = 1;
        public const int TeamDungeonShop = 2;
    }

    public class UITeamDungeonComponent : Entity, IAwake, IDestroy
    {
        public UIPageButtonComponent UIPageButtonComponent_1;

        public UITeamDungeonMyComponent UITeamDungeonMyComponent;
        public UITeamDungeonListComponent UITeamDungeonListComponent;
        public UITeamDungeonShopComponent UITeamDungeonShopComponent;

        public GameObject CloseButton;
    }

    [ObjectSystem]
    public class UITeamDungeonComponentAwakeSystem : AwakeSystem<UITeamDungeonComponent>
    {

        public override void Awake(UITeamDungeonComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UITeamDungeon); });

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

            self.UITeamDungeonListComponent = self.AddChild<UITeamDungeonListComponent, GameObject>(rc.Get<GameObject>("UITeamDungeonList"));
            self.UITeamDungeonMyComponent = self.AddChild<UITeamDungeonMyComponent, GameObject>(rc.Get<GameObject>("UITeamDungeonMy"));
            self.UITeamDungeonShopComponent = self.AddChild<UITeamDungeonShopComponent, GameObject>(rc.Get<GameObject>("UITeamDungeonShop"));

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
            await self.ZoneScene().GetComponent<TeamComponent>().RequestTeamDungeonList();
            if (self.IsDisposed)
            {
                return;
            }

            self.UIPageButtonComponent_1.ClickEnabled = true;
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null || teamInfo.SceneId == 0)
            {
                //无副本队伍
                self.UIPageButtonComponent_1.OnSelectIndex(0);
            }
            else
            {
                //有副本队伍
                self.UIPageButtonComponent_1.OnSelectIndex(1);
            }

        }

        public static void OnTeamUpdate(this UITeamDungeonComponent self)
        {
            self.UITeamDungeonMyComponent.OnUpdateUI();

            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null && self.UIPageButtonComponent_1.GetCurrentIndex() != 0)
            {
                self.UIPageButtonComponent_1.OnSelectIndex(0);
            }
        }

        public static bool CheckPageButton_1(this UITeamDungeonComponent self, int page)
        {
            if ((TeamDungeonPageEnum)page != TeamDungeonPageEnum.TeamDungeonMy)
            {
                return true;
            }
            //判断当前是否有队伍
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null || teamInfo.SceneId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请先创建或加入副本队伍");
                return false;
            }
            return true;
        }

        public static void OnClickPageButton_1(this UITeamDungeonComponent self, int page)
        {
            self.UITeamDungeonListComponent.GameObject.SetActive(page == (int)TeamDungeonPageEnum.TeamDungeonList);
            self.UITeamDungeonMyComponent.GameObject.SetActive(page == (int)TeamDungeonPageEnum.TeamDungeonMy);
            self.UITeamDungeonShopComponent.GameObject.SetActive(page == (int)TeamDungeonPageEnum.TeamDungeonShop);
            
            switch (page)
            {
                case (int)TeamDungeonPageEnum.TeamDungeonList:
                    self.UITeamDungeonListComponent.OnUpdateUI();
                    break;
                case (int)TeamDungeonPageEnum.TeamDungeonMy:
                    self.UITeamDungeonMyComponent.OnUpdateUI();
                    break;
                case (int)TeamDungeonPageEnum.TeamDungeonShop:
                    self.UITeamDungeonShopComponent.OnUpdateUI();
                    break;
                default:
                    break;
            }
        }

    }

}
