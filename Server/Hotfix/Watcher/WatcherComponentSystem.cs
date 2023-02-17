using System;
using System.Collections;
using System.Diagnostics;

namespace ET
{
    public class WatcherComponentAwakeSystem: AwakeSystem<WatcherComponent>
    {
        public override void Awake(WatcherComponent self)
        {
            WatcherComponent.Instance = self;
        }
    }
    
    public class WatcherComponentDestroySystem: DestroySystem<WatcherComponent>
    {
        public override void Destroy(WatcherComponent self)
        {
            WatcherComponent.Instance = null;
        }
    }
    
    public static class WatcherComponentSystem
    {

        public static async ETTask CheckLoginServer(this WatcherComponent self)
        {
            try
            {
                long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(3, "Gate1").InstanceId;
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                      (gateServerId, new T2G_GateUnitInfoRequest()
                      {
                          UserID = 1484890230006808576
                      });

            }
            catch (Exception ex)
            { 
                Log.Error(ex.ToString())
            }
        }

        public static void Start(this WatcherComponent self, int createScenes = 0)
        {
            string[] localIP = NetworkHelper.GetAddressIPs();
            var processConfigs = StartProcessConfigCategory.Instance.GetAll();
            foreach (StartProcessConfig startProcessConfig in processConfigs.Values)
            {
                if (!WatcherHelper.IsThisMachine(startProcessConfig.InnerIP, localIP))
                {
                    continue;
                }
                Process process = WatcherHelper.StartProcess(startProcessConfig.Id, createScenes);
                self.Processes.Add(startProcessConfig.Id, process);
            }
        }
    }
}