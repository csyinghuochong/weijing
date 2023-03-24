using System.Collections.Generic;

namespace ET
{

    public static class JianYuanComponentSystem
    {
        public static List<BagInfo> GetWareHouseItem(this JiaYuanComponent self, JiaYuanItemLoc itemEquipType)
        {
            List<BagInfo> ItemTypeList = null;
            switch (itemEquipType)
            {
                case JiaYuanItemLoc.JianYuanWareHouse1:
                    ItemTypeList = self.Warehouse1;
                    break;
                case JiaYuanItemLoc.JianYuanWareHouse2:
                    ItemTypeList = self.Warehouse2;
                    break;
                case JiaYuanItemLoc.JianYuanWareHouse3:
                    ItemTypeList = self.Warehouse3;
                    break;
                case JiaYuanItemLoc.JianYuanWareHouse4:
                    ItemTypeList = self.Warehouse4;
                    break;
            }
            return ItemTypeList;
        }

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

        public static void UprootPlant(this JiaYuanComponent self, int cellIndex)
        {
            for (int i = self.JianYuanPlants.Count - 1; i >= 0; i--)
            {
                if (self.JianYuanPlants[i].CellIndex == cellIndex)
                {
                    self.JianYuanPlants.RemoveAt(i);
                }
            }
        }

        public static void UpdatePlant(this JiaYuanComponent self, JiaYuanPlant jiaYuanPlant)
        {
            for (int i = 0; i < self.JianYuanPlants.Count; i++)
            {
                if (self.JianYuanPlants[i].CellIndex != jiaYuanPlant.CellIndex)
                {
                    continue;
                }
                self.JianYuanPlants[i] = jiaYuanPlant;
            }
            if (jiaYuanPlant.ItemId > 0)
            {
                self.JianYuanPlants.Add(jiaYuanPlant);
            }
        }
    }
}
