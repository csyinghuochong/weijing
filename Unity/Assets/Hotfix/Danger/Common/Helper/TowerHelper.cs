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

        public static int GetNextTowerId(int sceneType, int toweId)
        {
            if (toweId == 0)
            {
                return GetFirstTowerId(sceneType);
            }
            else
            {
                if (toweId < GetLastTowerId(sceneType))
                {
                    return toweId + 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int GetFirstTowerId(int sceneType)
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

        public static List<TowerConfig> GetTowerList(int sceneType)
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

        public static int GetLastTowerId(int sceneType)
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
