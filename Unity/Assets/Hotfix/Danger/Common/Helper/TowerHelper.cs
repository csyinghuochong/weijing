using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class TowerHelper
    {

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
