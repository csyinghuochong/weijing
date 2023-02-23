using System.Collections.Generic;


namespace ET
{
    public partial class LifeShieldConfigCategory
    {
        public MultiDictionary<int, int, int> LifeShieldList = new MultiDictionary<int, int, int>();

        public override void AfterEndInit()
        {
            foreach (LifeShieldConfig lifeShield in this.GetAll().Values)
            {
                if (!LifeShieldList.ContainsKey(lifeShield.ShieldType))
                {
                    LifeShieldList.Add(lifeShield.ShieldType, new Dictionary<int, int>());
                }
                if (!LifeShieldList[lifeShield.ShieldType].ContainsKey(lifeShield.ShieldLevel))
                {
                    LifeShieldList[lifeShield.ShieldType].Add(lifeShield.ShieldLevel, lifeShield.Id);
                }
                else
                {
                    Log.Error($"LifeShieldConfig：配置错误 {lifeShield.ShieldType} {lifeShield.ShieldLevel}");
                }
            }

            Log.Debug(GetShieldId(1, 2).ToString());
        }

        public int GetShieldId(int stype, int lv)
        {
            if (LifeShieldList.ContainsKey(stype) && LifeShieldList[stype].ContainsKey(lv))
            {
                return LifeShieldList[stype][lv];
            }
            else
            {
                return 0;
            }
        }
    }
}
