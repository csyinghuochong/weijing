
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICreateRoleListComponent : Entity, IAwake
    {
        //public int SelectXuHaoID;
        public GameObject ImageDi;
        public GameObject ObjRoleName;
        public GameObject ObjRoleLv;
        public GameObject ObjImgSelect;
        public GameObject ObjBtnSelectRole;
        public GameObject ObjImgOccHeadIcon;
        public GameObject RoleOcc;
        public GameObject NoRole;
        public GameObject Role;
        public CreateRoleListInfo CreateRoleInfo;
    }

    [ObjectSystem]
    public class UICreateRoleListComponentAwakeSystem : AwakeSystem<UICreateRoleListComponent>
    {
        public override void Awake(UICreateRoleListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ObjRoleName = rc.Get<GameObject>("RoleName");
            self.ObjRoleLv = rc.Get<GameObject>("RoleLv");
            self.ObjImgSelect = rc.Get<GameObject>("ImgSelect");
            self.ObjImgOccHeadIcon = rc.Get<GameObject>("Img_RoleHeadIcon");
            self.ImageDi = rc.Get<GameObject>("ImageDi");
            self.ObjBtnSelectRole = rc.Get<GameObject>("BtnSelectRole");
            self.RoleOcc = rc.Get<GameObject>("RoleOcc");
            self.NoRole = rc.Get<GameObject>("NoRole");
            self.Role = rc.Get<GameObject>("Role");
            self.ObjBtnSelectRole.GetComponent<Button>().onClick.AddListener(() => { self.ClickOnSeleRoleList().Coroutine(); });
        }
    }

    
    public static class UICreateRoleListComponentSystem
    {

        //展示角色列表
        public static void ShowRoleList(this UICreateRoleListComponent self)
        {
            if (self.CreateRoleInfo != null)
            {
                self.ObjRoleName.GetComponent<Text>().text = self.CreateRoleInfo.PlayerName;
                self.ObjRoleLv.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("等级:") + self.CreateRoleInfo.PlayerLv.ToString();
                self.ObjRoleLv.SetActive(true);
                OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(self.CreateRoleInfo.PlayerOcc);
                self.RoleOcc.GetComponent<Text>().text = $"职业:{occupationConfig.OccupationName}";
                UICommonHelper.ShowOccIcon(self.ObjImgOccHeadIcon, self.CreateRoleInfo.PlayerOcc);
                self.NoRole.SetActive(false);
                self.Role.SetActive(true);
            }
            else 
            {
                //显示为空
                self.NoRole.SetActive(true);
                self.Role.SetActive(false);
                self.ObjRoleName.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("点击创建角色");
                self.ObjRoleLv.SetActive(false);
                self.ObjImgOccHeadIcon.SetActive(false);
                self.RoleOcc.GetComponent<Text>().text = "职业:战士/法师";
            }
            self.ImageDi.SetActive(self.CreateRoleInfo == null);
        }

        //选择角色界面
        public static async ETTask ClickOnSeleRoleList(this UICreateRoleListComponent self)
        {
            //Log.Info("提示啦提示啦！！！！");
            //更新选中提示
            UI ui = UIHelper.GetUI(self.DomainScene(), UIType.UILobby);
            ui.GetComponent<UILobbyComponent>().SeletRoleInfo = self.CreateRoleInfo;
            ui.GetComponent<UILobbyComponent>().UpdateSelectShow().Coroutine();

            if (self.CreateRoleInfo != null)
            {
                //选择进入游戏的角色
                //ui.GetComponent<UILobbyComponent>().SeletXuHaoID = self.SelectXuHaoID;
            }
            else
            {
                //点击开始创建,显示创建角色界面
                //ui.GetComponent<UILobbyComponent>().SeletXuHaoID = -1;           // -1表示创建一个新的角色

                //打开创建界面
                //ui.GetComponent<UILobbyComponent>().OpenCreateRoleShow();
                UI createRole = await UIHelper.Create( self.DomainScene(), UIType.UICreateRole );
                createRole.GetComponent<UICreateRoleComponent>().ShowHeroSelect(2);
                UIHelper.Remove( self.DomainScene(), UIType.UILobby);
            }
        }

        //更新选中状态
        public static void UpdateSelectStatus(this UICreateRoleListComponent self, CreateRoleListInfo createRoleListInfo)
        {

            //Log.Info("self.SelectXuHaoID = " + self.SelectXuHaoID);
            if (createRoleListInfo != null && createRoleListInfo == self.CreateRoleInfo)
            {
                self.ObjImgSelect.SetActive(true);
                self.GetParent<UI>().GameObject.transform.localScale = Vector3.one * 1.2f;
            }
            else
            {
                self.ObjImgSelect.SetActive(false);
                self.GetParent<UI>().GameObject.transform.localScale = Vector3.one;
            }
        }
    }

}
