using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{ 

    public static class JianYuanComponentSystem
    {

        public static JiaYuanPlant GetCellPlant(this JiaYuanComponent self, int cell)
        {
            for (int i = 0; i < self.JianYuanPlants.Count; i++)
            {
                if (self.JianYuanPlants[i].CellIndex == cell)
                { 
                    return self.JianYuanPlants[i];
                }
            }

            return null;
        }

        public static void UpdatePlant(this JiaYuanComponent self, JiaYuanPlant jiaYuanPlant)
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
