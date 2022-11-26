using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class TowerHelper
    {
        public static int GetCurrentTowerId(this Unit self, int sceneType)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            if (sceneType == SceneTypeEnum.TrialDungeon)
            {
                return numericComponent.GetAsInt(NumericType.TrialDungeonId);
            }
            if (sceneType == SceneTypeEnum.RandomTower)
            {
                return numericComponent.GetAsInt(NumericType.RandomTowerId);
            }
            if (sceneType == SceneTypeEnum.Tower)
            {
                return numericComponent.GetAsInt(NumericType.TowerId);
            }
            return 0;
        }

        public static int GetNextTowerIdByScene(int sceneType, int toweId)
        {
            if (toweId == 0)
            {
                return GetFirstTowerIdByScene(sceneType);
            }
            else
            {
                if (toweId < GetLastTowerIdByScene(sceneType))
                {
                    return toweId + 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int GetFirstTowerIdByScene(int sceneType)
        {
            int towerId = 0;    
            List<TowerConfig> towerConfigs = TowerConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < towerConfigs.Count; i++)
            {
                if (towerConfigs[i].MapType!=sceneType)
                {
                    continue;
                }
                towerId = towerConfigs[i].Id;
                break;
            }
            return towerId;
        }

        public static List<TowerConfig> GetTowerListByScene(int sceneType)
        {
            List<TowerConfig> towerList = new List<TowerConfig>();
            List<TowerConfig> towerConfigs = TowerConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < towerConfigs.Count; i++)
            {
                if (towerConfigs[i].MapType != sceneType)
                {
                    continue;
                }
                towerList.Add( towerConfigs[i] );
            }
            return towerList;
        }

        public static int GetLastTower(int fubenDifficulty)
        {
            string[] ids = GlobalValueConfigCategory.Instance.Get(71).Value.Split(';');
            return (int.Parse(ids[fubenDifficulty - 1]));
        }

        public static int GetLastTowerIdByScene(int sceneType)
        {
            int towerId = 0;
            List<TowerConfig> towerConfigs = TowerConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < towerConfigs.Count; i++)
            {
                if (towerConfigs[i].MapType != sceneType)
                {
                    continue;
                }
                towerId = towerConfigs[i].Id;
            }
            return towerId;
        }

    }
}
