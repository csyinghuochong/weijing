using System;
using System.Linq;
using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class RobotManagerComponentAwakeSystem : AwakeSystem<RobotManagerComponent>
    {
        public override void Awake(RobotManagerComponent self)
        {
            self.ZoneIndex = Game.Options.Process * 10000;
            self.RobotList.Clear();
        }
    }

    public static class RobotManagerComponentSystem
    {

        public static async ETTask<Scene> NewRobot(this RobotManagerComponent self, int zone, int robotId)
        {
            Scene zoneScene = null;
            try
            {
                zoneScene = SceneFactory.CreateZoneScene(zone, "Robot", self);

                int number = 1;
                if (!self.RobotList.ContainsKey(robotId))
                {
                    self.RobotList.Add(robotId, 1);
                }
                else
                {
                    number = self.RobotList[robotId]++;
                }
                string account = $"{robotId}_{number}";
                bool outnet = false;
                int registerCode = await LoginHelper.Register(zoneScene, outnet, VersionMode.Beta, account, ComHelp.RobotPassWord);
                int errorCode = await LoginHelper.Login(zoneScene, LoginHelper.GetServerIpList(outnet, 1), account, ComHelp.RobotPassWord);
                if (registerCode == ErrorCore.ERR_Success)
                {
                    A2C_CreateRoleData g2cCreateRole = await LoginHelper.CreateRole(zoneScene, 1, self.Parent.GetComponent<RandNameComponent>().GetRandomName());
                    AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                    playerComponent.CurrentServerId = 1;
                    playerComponent.CurrentRoleId = g2cCreateRole.createRoleInfo.UserID;

                    errorCode = await LoginHelper.GetRealmKey(zoneScene);
                    errorCode = await LoginHelper.EnterGame(zoneScene);
                }
                if (registerCode == ErrorCore.ERR_AccountAlreadyRegister)
                {
                    AccountInfoComponent playerComponent = zoneScene.GetComponent<AccountInfoComponent>();
                    playerComponent.CurrentServerId = 1;
                    playerComponent.CurrentRoleId = playerComponent.CreateRoleList[0].UserID;

                    errorCode = await LoginHelper.GetRealmKey(zoneScene);
                    errorCode = await LoginHelper.EnterGame(zoneScene);
                }
                Log.Debug($"create robot ok: {zone}");
                return errorCode == ErrorCore.ERR_Success ?  zoneScene : null;
            }
            catch (Exception e)
            {
                zoneScene?.Dispose();
                throw new Exception($"RobotSceneManagerComponent create robot fail, zone: {zone}", e);
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