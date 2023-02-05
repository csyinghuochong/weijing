using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public static class QiangHuaHelper
    {

        public static int GetQiangHuaId(int itemSubType, int level)
        {
            EquipQiangHuaConfig equipQiangHuaConfig = GetQiangHuaConfig(itemSubType, level);
            return equipQiangHuaConfig.Id;
        }

        public static EquipQiangHuaConfig GetQiangHuaConfig(int itemSubType, int level)
        { 
            List<EquipQiangHuaConfig> qiangHuaConfigs = EquipQiangHuaConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < qiangHuaConfigs.Count; i++)
            {
                EquipQiangHuaConfig equipQiangHuaConfig = qiangHuaConfigs[i];
                if (equipQiangHuaConfig.ItemSubType == itemSubType && equipQiangHuaConfig.QiangHuaLv == level)
                {
                    return equipQiangHuaConfig;
                }
            }
            return null;
        }

        public static int GetQiangHuaMaxLevel(int subType)
        {
            int maxLevel = 0;
            List<EquipQiangHuaConfig> qiangHuaConfigs = EquipQiangHuaConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < qiangHuaConfigs.Count; i++)
            {
                EquipQiangHuaConfig equipQiangHuaConfig = qiangHuaConfigs[i];
                if (equipQiangHuaConfig.ItemSubType == subType)
                {
                    maxLevel++;
                    if (equipQiangHuaConfig.NextID == 0)
                    {
                        break;
                    }
                }
            }
            return maxLevel;
        }
    }
}
