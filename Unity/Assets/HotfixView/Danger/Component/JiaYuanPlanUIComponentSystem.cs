using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static  class JiaYuanPlanUIComponentSystem
    {

        public static void OnUpdateUI(this JiaYuanPlanUIComponent self, JianYuanPlant jianYuanPlant)
        {
            Log.Debug("jianYuanPlant: " + jianYuanPlant.ItemId);
            self.JianYuanPlant = jianYuanPlant; 

        }
    }
}
