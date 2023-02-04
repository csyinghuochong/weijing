using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ObjectSystem]
    public class FubenCenterComponentAwakeSystem : AwakeSystem<FubenCenterComponent>
    {
        public override void Awake(FubenCenterComponent self)
        {
            self.InitYeWaiScene().Coroutine();
        }
    }

    public static class FubenCenterComponentSystem
    {
        public static async ETTask  InitYeWaiScene(this FubenCenterComponent self)
        {
            await TimerComponent.Instance.WaitAsync(self.DomainZone() * 100);
            int openDay =  DBHelper.GetOpenServerDay(self.DomainZone());

            List<SceneConfig> sceneConfigs =  SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != SceneTypeEnum.BaoZang 
                && sceneConfigs[i].MapType != SceneTypeEnum.MiJing)
                {
                    continue;
                }

                //动态创建副本
                long fubenid = IdGenerater.Instance.GenerateId();
                long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();

                self.FubenInstanceList.Add(fubenInstanceId);
                self.YeWaiFubenList.Add(sceneConfigs[i].Id, fubenInstanceId);

                Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "Map" + sceneConfigs[i].Id.ToString(), SceneType.Map);
                MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
                mapComponent.SetMapInfo(sceneConfigs[i].MapType, sceneConfigs[i].Id, 0);
                mapComponent.NavMeshId = sceneConfigs[i].MapID.ToString(); 
                fubnescene.GetComponent<ServerInfoComponent>().ServerInfo = self.ServerInfo;
                YeWaiRefreshComponent yeWaiRefreshComponen = fubnescene.AddComponent<YeWaiRefreshComponent>();
                yeWaiRefreshComponen.SceneId = sceneConfigs[i].Id;
                if (sceneConfigs[i].MapType == SceneTypeEnum.MiJing)
                {
                    fubnescene.AddComponent<MiJingComponent>();
                }

                FubenHelp.CreateMonsterList(fubnescene, sceneConfigs[i].CreateMonster);
                FubenHelp.CreateMonsterList(fubnescene, sceneConfigs[i].CreateMonsterPosi);
                yeWaiRefreshComponen.OnZeroClockUpdate(openDay);
            }
        }
    }
}
