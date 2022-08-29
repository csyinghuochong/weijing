using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public static class QiangHuaHelper
    {

        public static EquipQiangHuaConfig GetQiangHuaConfig(int index, int level)
        { 
            List<EquipQiangHuaConfig> qiangHuaConfigs = EquipQiangHuaConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < qiangHuaConfigs.Count; i++)
            {
                EquipQiangHuaConfig equipQiangHuaConfig = qiangHuaConfigs[i];
                if (equipQiangHuaConfig.ItemSubType == index && equipQiangHuaConfig.QiangHuaLv == level)
                {
                    return equipQiangHuaConfig;
                }
            }
            return null;
        }

        public static int GetQiangHuaMaxLevel(int index)
        {
            int maxLevel = 0;
            List<EquipQiangHuaConfig> qiangHuaConfigs = EquipQiangHuaConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < qiangHuaConfigs.Count; i++)
            {
                EquipQiangHuaConfig equipQiangHuaConfig = qiangHuaConfigs[i];
                if (equipQiangHuaConfig.ItemSubType == index)
                {
                    maxLevel++;
                }
            }
            return maxLevel;
        }
    }
}
