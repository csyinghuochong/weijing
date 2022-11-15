using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ObjectSystem]
    public class FubenCenterComponentAwakeSystem : AwakeSystem<FubenCenterComponent>
    {
        public override void Awake(FubenCenterComponent self)
        {
            self.InitYeWaiScene();
        }
    }

    public static class FubenCenterComponentSystem
    {
        public static void  InitYeWaiScene(this FubenCenterComponent self)
        {
            List<SceneConfig> sceneConfigs =  SceneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < sceneConfigs.Count; i++)
            {
                if (sceneConfigs[i].MapType != SceneTypeEnum.YeWaiScene)
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
                mapComponent.SetMapInfo((int)SceneTypeEnum.Battle, sceneConfigs[i].Id, 0);
                mapComponent.NavMeshId = sceneConfigs[i].MapID.ToString();
                fubnescene.AddComponent<YeWaiRefreshComponent>();
                fubnescene.GetComponent<ServerInfoComponent>().ServerInfo = self.ServerInfo;
                FubenHelp.CreateMonsterList(fubnescene, sceneConfigs[i].CreateMonster, FubenDifficulty.None);
                FubenHelp.CreateMonsterList(fubnescene, sceneConfigs[i].CreateMonsterPosi, FubenDifficulty.None);
            }
        }
    }
}
