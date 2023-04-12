using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UILobbyComponentAwakeSystem : AwakeSystem<UILobbyComponent>
    {
        public override void Awake(UILobbyComponent self)
        {
            self.CreateRoleListUI.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");
            self.ImageDi.SetActive(false);
            self.Text_Lv = rc.Get<GameObject>("Text_Lv");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.ObjRoleList = rc.Get<GameObject>("RoleList");
            self.ObjRoleList.SetActive(false);
            self.ObjRoleListSet = rc.Get<GameObject>("RoleListSet");
            self.Button_1 = rc.Get<GameObject>("Button_1");
            self.Button_2 = rc.Get<GameObject>("Button_2");
            ButtonHelp.AddListenerEx(self.Button_1, self.OnButton_1);
            ButtonHelp.AddListenerEx(self.Button_2, self.OnButton_2);


            //ios适配
            IPHoneHelper.SetPosition(self.ObjRoleListSet, new Vector2(350f, 400f));

            self.ObjBtnEnterGame = rc.Get<GameObject>("BtnEnterGame");

            self.ObjBtnDeleteRole = rc.Get<GameObject>("BtnDeleteRole");
         
            self.ObjCreateRoleShow = rc.Get<GameObject>("CreateRoleShow");
            self.ObjBtnReturnRole = rc.Get<GameObject>("BtnReturnRole");

            self.ObjInputCreateRoleName = rc.Get<GameObject>("InputCreateRoleName");
            self.ObjBtnRandomName = rc.Get<GameObject>("BtnRandomName");

            ButtonHelp.AddListenerEx(self.ObjBtnEnterGame, () => self.EnterGame().Coroutine());
            ButtonHelp.AddListenerEx(self.ObjBtnDeleteRole, () => self.DeleteRole());
            self.PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            self.PageIndex = 0;
            self.SeletRoleInfo = null;
            string lastUserID = PlayerPrefsHelp.GetString(PlayerPrefsHelp.LastUserID);
            if (!string.IsNullOrEmpty(lastUserID))
            {
                long useid = long.Parse(lastUserID);
                for (int i = 0; i < self.PlayerComponent.CreateRoleList.Count; i++)
                {
                    if (self.PlayerComponent.CreateRoleList[i].UserID == useid)
                    {
                        self.SeletRoleInfo = self.PlayerComponent.CreateRoleList[i];
                        self.PageIndex = i / self.PageCount;
                        break;
                    }
                }
            }


            //展示角色列表
            self.UpdateRoleList();
        }
    }

    //[ObjectSystem]
    public static class UILobbyComponentSystem
    {
        public static void OnCreateRoleData(this UILobbyComponent self, CreateRoleInfo roleinfo)
        {
            self.SeletRoleInfo = roleinfo;

            self.UpdateRoleList();
        }

        public static void Update_Page(this UILobbyComponent self)
        {
            int pagetotal = self.PlayerComponent.CreateRoleList.Count / 4;
            pagetotal += ((self.PlayerComponent.CreateRoleList.Count % 4 > 0) ? 1 : 0);

            self.Button_1.SetActive( self.PageIndex > 0 );
            self.Button_2.SetActive( self.PageIndex < pagetotal - 1);
        }

        public static void OnButton_2(this UILobbyComponent self)
        {
            int pagetotal = self.PlayerComponent.CreateRoleList.Count / 4;
            pagetotal += ( (self.PlayerComponent.CreateRoleList.Count % 4 > 0) ? 1 : 0 );
            if (self.PageIndex >= pagetotal -1)
            {
                return;
            }
            self.PageIndex++;
 
            self.UpdateRoleList();
        }

        public static void OnButton_1(this UILobbyComponent self)
        {
            if (self.PageIndex < 1)
            {
                return;
            }
            self.PageIndex--;
 
            self.UpdateRoleList();
        }

        //展示角色列表
        public static void UpdateRoleList(this UILobbyComponent self)
        {
          
            if (self.SeletRoleInfo == null)
            {
                if (self.PlayerComponent.CreateRoleList.Count > 0)
                {
                    self.SeletRoleInfo = self.PlayerComponent.CreateRoleList[0];
                }
                self.PageIndex = 0;
            }
            int pageIndex = self.PageIndex;
            int starIndex = pageIndex * self.PageCount; 

            //int num = self.PlayerComponent.CreateRoleList.Count +1;
            int num = self.PlayerComponent.CreateRoleList.Count - starIndex + 1;
            num = Mathf.Min(4, num);
            //显示列表
            for (int i = 0; i < num; i++)
            {
                UICreateRoleListComponent ui_1;
                if (i < self.CreateRoleListUI.Count)
                {
                    ui_1 = self.CreateRoleListUI[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.ObjRoleList);
                    UICommonHelper.SetParent(go, self.ObjRoleListSet);
                    ui_1 = self.AddChild<UICreateRoleListComponent, GameObject>( go);
                    go.SetActive(true);

                    //添加记录
                    self.CreateRoleListUI.Add(ui_1);
                }

                CreateRoleInfo CreateRoleList = null;
                if (i < self.PlayerComponent.CreateRoleList.Count - starIndex)
                {
                    CreateRoleList = self.PlayerComponent.CreateRoleList[starIndex + i];
                }
                ui_1.ShowRoleList(CreateRoleList);
            }
            for (int i = num; i < self.CreateRoleListUI.Count; i++)
            {
                self.CreateRoleListUI[i].ShowRoleList(null);
            }

            self.UpdateSelectShow().Coroutine();
            self.Update_Page();

        }

        //更新当前选中显示
        public static async ETTask UpdateSelectShow(this UILobbyComponent self)
        {
            for (int i = 0; i < self.CreateRoleListUI.Count; i++)
            {
                self.CreateRoleListUI[i].UpdateSelectStatus(self.SeletRoleInfo);
            }
            if (self.SeletRoleInfo != null)
            {
                self.Text_Name.GetComponent<Text>().text = self.SeletRoleInfo.PlayerName;
                self.Text_Lv.GetComponent<Text>().text = $"{self.SeletRoleInfo.PlayerLv}级";
                self.eTCancellation?.Cancel();
                self.eTCancellation = new ETCancellationToken();
                UICommonHelper.ShowHeroSelect(self.SeletRoleInfo.PlayerOcc, self.SeletRoleInfo.WeaponId, self.eTCancellation).Coroutine();
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
            if (Time.time - self.LastLoginTime < 4)
            {
                return;
            }
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

            Session session = self.ZoneScene().GetComponent<SessionComponent>().Session;
            if (session == null || session.IsDisposed)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已掉线，请重新连接!"));
                return;
            }

            self.LastLoginTime = Time.time;
            PlayerPrefsHelp.SetString(PlayerPrefsHelp.LastUserID, self.SeletRoleInfo.UserID.ToString());
            self.PlayerComponent.CurrentRoleId = self.SeletRoleInfo.UserID;
            int loginErroCode = await LoginHelper.GetRealmKey(self.ZoneScene());
            if (loginErroCode != ErrorCore.ERR_Success)
            {
                Log.Error(loginErroCode.ToString());
                return;
            }
            
            await  LoginHelper.EnterGame(self.ZoneScene(), SystemInfo.deviceName, false);
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

            self.UpdateRoleList();
        }
    }
}