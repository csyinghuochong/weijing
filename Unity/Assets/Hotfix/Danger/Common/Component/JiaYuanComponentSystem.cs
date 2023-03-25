using System.Collections.Generic;

namespace ET
{

    public static class JianYuanComponentSystem
    {

        public static void OnLogin(this JiaYuanComponent self)
        {
#if SERVER
            if (self.MysteryItems.Count == 0)
            {
                self.OnZeroClockUpdate();
            }
#else
#endif     
        }

        public static int OnMysteryBuyRequest(this JiaYuanComponent self, MysteryItemInfo mysteryInfo)
        {
            for (int i = 0; i < self.MysteryItems.Count; i++)
            {
                MysteryItemInfo mysteryItemInfo1 = self.MysteryItems[i];

                if (mysteryItemInfo1.ItemID != mysteryInfo.ItemID)
                {
                    continue;
                }
                if (mysteryItemInfo1.ItemNumber < mysteryInfo.ItemNumber)
                {
                    return ErrorCore.ERR_ItemNotEnoughError;
                }

                mysteryItemInfo1.ItemNumber -= mysteryInfo.ItemNumber;
                return ErrorCore.ERR_Success;
            }
            return ErrorCore.ERR_ItemNotEnoughError;
        }

        public static void OnZeroClockUpdate(this JiaYuanComponent self)
        {
#if SERVER
            int openday = DBHelper.GetOpenServerDay(self.DomainZone());
            self.MysteryItems = MysteryShopHelper.InitJiaYuanMysteryItemInfos(openday, 10);  //self.JiaYuanLeve
#else
#endif
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
                return;
            }

            if (jiaYuanPlant.ItemId > 0)
            {
                self.JianYuanPlants.Add(jiaYuanPlant);
            }
        }
    }
}
