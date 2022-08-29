using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class LingDiHelp
    {
        public static void OnAddLingDiExp(Unit unit, int addExp, bool notice)
        {
            int lingdiLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiLv);
            int lingdiExp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiExp);
            LingDiConfig lingDiConfig = LingDiConfigCategory.Instance.Get(lingdiLv);
           
            int maxLevel = LingDiConfigCategory.Instance.GetAll().Values.Count;
            if (lingdiLv >= maxLevel && lingdiExp >= lingDiConfig.UpExp)
            {
                return;
            }

            int needCoin = lingDiConfig.GoldUp;
            if (addExp + lingdiExp >= lingDiConfig.UpExp && lingdiLv < maxLevel)
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Ling_DiLv, lingdiLv + 1, notice);
                addExp = addExp + lingdiExp - lingDiConfig.UpExp;
            }
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Ling_DiExp, addExp + lingdiExp, notice);
        }


    }
}
