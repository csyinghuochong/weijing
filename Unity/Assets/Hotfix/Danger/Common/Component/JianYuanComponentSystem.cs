using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{ 

    public static class JianYuanComponentSystem
    {

        public static bool HavePlant(this JianYuanComponent self, int cell)
        {
            for (int i = 0; i < self.JianYuanPlants.Count; i++)
            {
                if (self.JianYuanPlants[i].CellIndex == cell)
                { 
                    return true;
                }
            }

            return false;
        }

        public static void UpdatePlant(this JianYuanComponent self, JiaYuanPlant jiaYuanPlant)
        {
            for (int i = 0; i < self.JianYuanPlants.Count; i++)
            {
                if (self.JianYuanPlants[i].CellIndex == jiaYuanPlant.CellIndex)
                {
                    self.JianYuanPlants[i] = jiaYuanPlant;
                    return;
                }
            }

            self.JianYuanPlants.Add(jiaYuanPlant);
        }
    }
}
