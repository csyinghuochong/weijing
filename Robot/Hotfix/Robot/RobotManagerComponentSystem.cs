using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ObjectSystem]
    public class RobotManagerComponentAwakeSystem : AwakeSystem<RobotManagerComponent>
    {
        public override void Awake(RobotManagerComponent self)
        {
            self.ZoneIndex = Game.Options.Process * 10000;
        }
    }

    public static class RobotManagerComponentSystem
    {

        public static async ETTask RemoveRobot(this RobotManagerComponent self, Scene robotScene)
        {
            //self.ZoneIndex--;
            robotScene.GetComponent<SessionComponent>().Session.Dispose();
            await TimerComponent.Instance.WaitAsync(200);
            robotScene.Dispose();
        }

        public static async ETTask<Scene> NewRobot(this RobotManagerComponent self, int zone, int robotZone, int robotId)
        {
            Scene zoneScene = null;
            try
            {
                int robotNumber = 0;
                List<Entity> ts = self.Children.Values.ToList();
                for (int i = 0; i < ts.Count; i++)
                {
                    Scene robotScene = ts[i] as Scene;
                    if (robotScene.GetComponent<BehaviourComponent>().RobotConfig.Id == robotId)
                    {
                        robotNumber++;
                    }
                }

                //同一个进程robotZone是自增的
                zoneScene = SceneFactory.CreateZoneScene(robotZone, "Robot", self);
                string account = $"{robotId}_{zone}_{robotNumber}_abe";
                Log.Debug($"NewRobot  :{robotZone}  {account}");
                bool innernet = ComHelp.IsInnerNet();
                int registerCode = await LoginHelper.Register(zoneScene, !innernet, VersionMode.Beta, account, ComHelp.RobotPassWord);
                int errorCode = await LoginHelper.Login(zoneScene, ServerHelper.GetServerIpList(innernet, zone), account, ComHelp.RobotPassWord);
                if (registerCode == ErrorCore.ERR_Success)
                {
                    A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(zoneScene, 1, self.Parent.GetComponent<RandNameComponent>().GetRandomName());
                    AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                    playerComponent.ServerId = zone;
                    playerComponent.CurrentRoleId = g2cCreateRole.createRoleInfo.UserID;

                    errorCode = await LoginHelper.GetRealmKey(zoneScene);
                    errorCode = await LoginHelper.EnterGame(zoneScene);
                }
                if (registerCode == ErrorCore.ERR_AccountAlreadyRegister)
                {
                    AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                    if (playerComponent.CreateRoleList.Count > 0)
                    {
                        playerComponent.ServerId = zone;
                        playerComponent.CurrentRoleId = playerComponent.CreateRoleList[0].UserID;

                        errorCode = await LoginHelper.GetRealmKey(zoneScene);
                        errorCode = await LoginHelper.EnterGame(zoneScene);
                    }
                    else
                    {
                        Log.Error($"{account}  {zone} 角色为空");
                        zoneScene?.Dispose();
                        return null;
                    }
                }
                Log.Debug($"create robot ok: {robotZone}");
                return errorCode == ErrorCore.ERR_Success ?  zoneScene : null;
            }
            catch (Exception e)
            {
                zoneScene?.Dispose();
                throw new Exception($"RobotSceneManagerComponent create robot fail, zone: {robotZone}", e);
            }
        }

        public static void RemoveAll(this RobotManagerComponent self)
        {
            foreach (Entity robot in self.Children.Values.ToArray())        
            {
                robot.Dispose();
            }
        }
        
        public static void Remove(this RobotManagerComponent self, long id)
        {
            self.GetChild<Scene>(id)?.Dispose();
        }

        public static void Clear(this RobotManagerComponent self)
        {
            foreach (Entity entity in self.Children.Values.ToArray())
            {
                entity.Dispose();
            }
        }
    }
}