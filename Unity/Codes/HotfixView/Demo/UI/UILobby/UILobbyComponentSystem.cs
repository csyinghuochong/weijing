using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [ObjectSystem]
    public class UILobbyComponentAwakeSystem : AwakeSystem<UILobbyComponent>
    {
        public override void Awake(UILobbyComponent self)
        {
            self.SeletRoleInfo = null;
            self.createRoleListUI = new List<UI>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");
            self.ImageDi.SetActive(false);
            self.Text_Lv = rc.Get<GameObject>("Text_Lv");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.ObjRoleList = rc.Get<GameObject>("RoleList");
            self.ObjRoleList.SetActive(false);
            self.ObjRoleListSet = rc.Get<GameObject>("RoleListSet");
            self.ObjBtnEnterGame = rc.Get<GameObject>("BtnEnterGame");
            self.ObjRoleList.SetActive(false);

            self.ObjBtnDeleteRole = rc.Get<GameObject>("BtnDeleteRole");
         
            self.ObjCreateRoleShow = rc.Get<GameObject>("CreateRoleShow");
            self.ObjBtnReturnRole = rc.Get<GameObject>("BtnReturnRole");

            self.ObjInputCreateRoleName = rc.Get<GameObject>("InputCreateRoleName");
            self.ObjBtnRandomName = rc.Get<GameObject>("BtnRandomName");

            ButtonHelp.AddListenerEx(self.ObjBtnEnterGame, () => self.EnterGame().Coroutine());
            ButtonHelp.AddListenerEx(self.ObjBtnDeleteRole, () => self.DeleteRole());
            self.PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            string lastUserID = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastUserID);
            if (!string.IsNullOrEmpty(lastUserID))
            {
                long useid = long.Parse(lastUserID);
                for (int i = 0; i < self.PlayerComponent.CreateRoleList.Count; i++)
                {
                    if (self.PlayerComponent.CreateRoleList[i].UserID == useid)
                    {
                        self.SeletRoleInfo = self.PlayerComponent.CreateRoleList[i];
                    }
                }
            }

            //展示角色列表
            self.ShowRoleList();
        }
    }

    //[ObjectSystem]
    public static class UILobbyComponentSystem
    {
        public static void OnCreateRoleData(this UILobbyComponent self, CreateRoleListInfo roleinfo)
        {
            self.SeletRoleInfo = roleinfo;

            self.ShowRoleList();
        }

        //展示角色列表
        public static void ShowRoleList(this UILobbyComponent self)
        {
            if (self.SeletRoleInfo == null && self.PlayerComponent.CreateRoleList.Count> 0)
            {
                self.SeletRoleInfo = self.PlayerComponent.CreateRoleList[0];
            }

            int num = self.PlayerComponent.CreateRoleList.Count +1;
            num = Mathf.Min(3, num);
            //显示列表
            for (int i = 0; i < num; i++)
            {
                UI ui_1;
                if (i < self.createRoleListUI.Count)
                {
                    ui_1 = self.createRoleListUI[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.ObjRoleList);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.ObjRoleListSet);
                    ui_1 = self.AddChild<UI, string, GameObject>("RoleList" + i, go);
                    ui_1.AddComponent<UICreateRoleListComponent>();
                }
  
                CreateRoleListInfo CreateRoleList = null;
                if (i < self.PlayerComponent.CreateRoleList.Count)
                {
                    CreateRoleList = self.PlayerComponent.CreateRoleList[i];
                }
                ui_1.GetComponent<UICreateRoleListComponent>().CreateRoleInfo = CreateRoleList;
                ui_1.GetComponent<UICreateRoleListComponent>().ShowRoleList();

                //添加记录
                self.createRoleListUI.Add(ui_1);
            }

            self.UpdateSelectShow().Coroutine();
        }

        //更新当前选中显示
        public static async ETTask UpdateSelectShow(this UILobbyComponent self)
        {
            for (int i = 0; i < self.createRoleListUI.Count; i++)
            {
                self.createRoleListUI[i].GetComponent<UICreateRoleListComponent>().UpdateSelectStatus(self.SeletRoleInfo);
            }
            if (self.SeletRoleInfo != null)
            {
                self.Text_Name.GetComponent<Text>().text = self.SeletRoleInfo.PlayerName;
                self.Text_Lv.GetComponent<Text>().text = $"{self.SeletRoleInfo.PlayerLv}级";
                UICommonHelper.ShowHeroSelect(self.SeletRoleInfo.PlayerOcc);
                long instanceid = self.InstanceId;
                await TimerComponent.Instance.WaitAsync(100);
                if (self.InstanceId != instanceid)
                    return;
                GameObject go = GameObject.Find("HeroPosition");
                go.transform.localPosition = Vector3.zero;
            }
            else
            {
                GameObject go = GameObject.Find("HeroPosition");
                go.transform.localPosition = new Vector3(100, 0, 100);
            }
            self.ObjRoleListSet.SetActive(false);
            self.ObjRoleListSet.SetActive(true);
            await ETTask.CompletedTask;
        }

        //选择角色进入游戏
        public static async ETTask EnterGame(this UILobbyComponent self)
        {
            if (self.PlayerComponent.CreateRoleList.Count == 0)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请先创建角色!"));
                return;
            }
            if (self.SeletRoleInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("进入角色为空!"));
                return;
            }
            self.PlayerComponent.CurrentRoleId = self.SeletRoleInfo.UserID;
            PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastUserID, self.SeletRoleInfo.UserID.ToString());
            int errorCode = await LoginHelper.GetRealmKey(self.ZoneScene());
            if (errorCode != ErrorCore.ERR_Success)
            {
                Log.Error(errorCode.ToString());
                return;
            }
            
            LoginHelper.EnterGame(self.ZoneScene()).Coroutine();
        }

        //删除角色
        public static void  DeleteRole(this UILobbyComponent self)
        {
            //Log.Info("删除角色..");
            //判断当前选中栏是否有角色
            if (self.SeletRoleInfo == null)
            {
                return;
            }
            if (self.SeletRoleInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("删除列表种没有角色!"));
                return;
            }
            PopupTipHelp.OpenPopupTip
                (
                    self.ZoneScene(),
                    "删除角色",
                    "是否删除当前角色？",
                    () => 
                    {
                        self.RequestDeleteRole().Coroutine();
                    }
                )
                .Coroutine();

           
        }

        public static async ETTask RequestDeleteRole(this UILobbyComponent self)
        {
            //发送删除
            A2C_DeleteRoleData g2cCreateRole = (A2C_DeleteRoleData)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(new C2A_DeleteRoleData()
            {
                DeleUserID = self.SeletRoleInfo.UserID,
                AccountId = self.PlayerComponent.AccountId
            });

            //删除成功刷新当前角色列表

            self.PlayerComponent.CreateRoleList.Remove(self.SeletRoleInfo);
            self.SeletRoleInfo = null;
            self.ShowRoleList();
        }
    }
}