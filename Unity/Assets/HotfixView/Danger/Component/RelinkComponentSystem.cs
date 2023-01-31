using System;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class RelinkComponentAwakeSystem : AwakeSystem<RelinkComponent>
    {
        public override void Awake(RelinkComponent self)
        {
            self.Relink = false;
            GameObject.Find("Global").GetComponent<Init>().OnApplicationFocusHandler = (bool value) => 
            {
                self.OnApplicationFocusHandler(value);
            };
            GameObject.Find("Global").GetComponent<Init>().OnApplicationQuitHandler = () =>
            {
                self.OnApplicationQuitHandler().Coroutine();
            };
        }
    }

    [ObjectSystem]
    public class RelinkComponentDestroySystem : DestroySystem<RelinkComponent>
    {
        public override void Destroy(RelinkComponent self)
        {
            self.Relink = false;
        }
    }

    public static class RelinkComponentSystem
    {
        public static async ETTask OnApplicationQuitHandler(this RelinkComponent self)
        {
            SessionComponent sessionComponent = self.DomainScene().GetComponent<SessionComponent>();
            if (sessionComponent == null)
            {
                return;
            }
            if (sessionComponent.Session == null || sessionComponent.Session.IsDisposed)
            {
                return;
            }
            try
            {
                G2C_ExitGameGate response = await sessionComponent.Session.Call(new C2G_ExitGameGate() {  }) as G2C_ExitGameGate;
            }
            catch (Exception e)
            {
                Log.Debug(e.ToString());
            }
        }

        public static void OnApplicationFocusHandler(this RelinkComponent self, bool value)
        {
            if (!value)
            {
                return;
            }
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LoginScene)
            {
                return;
            }
            SessionComponent sessionComponent = self.DomainScene().GetComponent<SessionComponent>();
            if (sessionComponent == null)
            {
                return;
            }
            if (sessionComponent.Session == null || sessionComponent.Session.IsDisposed)
            {
                self.CheckRelink().Coroutine();
            }
        }

        public static async ETTask CheckRelink(this RelinkComponent self)
        {
            if (self.Relink)
            {
                return;
            }
            self.Relink = true;
            UIHelper.Create(self.DomainScene(), UIType.UIRelink).Coroutine();
            for (int i = 0; i < 5; i++)
            {
                long instanceid = self.InstanceId;
                if (TimerComponent.Instance == null)
                {
                    break;
                }
                await TimerComponent.Instance.WaitAsync(4000);
                if (instanceid != self.InstanceId)
                {
                    break;
                }
                int code = await self.SendLogin();
                if (code == ErrorCore.ERR_Success)
                {
                    self.Relink = false;
                    Log.ILog.Debug("重连成功！！");
 
                    UIHelper.Remove(self.DomainScene(), UIType.UIRelink);
                    EventType.RelinkSucess.Instance.ZoneScene = self.DomainScene();
                    Game.EventSystem.PublishClass(EventType.RelinkSucess.Instance);
                    break;
                }
                if(i == 4)
                {
                    UIHelper.Remove(self.DomainScene(), UIType.UIRelink);
                    EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
                    Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
                    break;
                }
            }
        }


        /// <summary>
        /// 断线重连，重新走登录流程
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask<int> SendLogin(this RelinkComponent self)
        {   
            AccountInfoComponent PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            int code = await LoginHelper.Login(
                        self.DomainScene(),
                        PlayerComponent.ServerIp,
                        PlayerComponent.Account,
                        PlayerComponent.Password, true);
            if (code != ErrorCore.ERR_Success)
            {
                return code;
            }
            await TimerComponent.Instance.WaitAsync(1500);
            code = await LoginHelper.GetRealmKey(self.DomainScene());
            if (code != ErrorCore.ERR_Success)
            {
                return code;
            }
            code = await LoginHelper.EnterGame(self.ZoneScene(), true);
            return code;
        }

    }
}
