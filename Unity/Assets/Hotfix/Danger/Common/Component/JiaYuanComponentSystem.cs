using System.Collections.Generic;

namespace ET
{

    public static class JianYuanComponentSystem
    {

        public static void OnLogin(this JiaYuanComponent self)
        {
            //if (self.MysteryItems.Count == 0 || self.PastureItems.Count == 0)
            {
                self.OnZeroClockUpdate();
            }
        }

        public static int OnPastureBuyRequest(this JiaYuanComponent self, MysteryItemInfo mysteryInfo)
        {
#if SERVER
            for (int i = 0; i < self.PastureGoods.Count; i++)
            {
                MysteryItemInfo mysteryItemInfo1 = self.PastureGoods[i];

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
#endif
            return ErrorCore.ERR_ItemNotEnoughError;
        }

        public static int OnMysteryBuyRequest(this JiaYuanComponent self, MysteryItemInfo mysteryInfo)
        {
#if SERVER
            for (int i = 0; i < self.PlantGoods.Count; i++)
            {
                MysteryItemInfo mysteryItemInfo1 = self.PlantGoods[i];

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
#endif
            return ErrorCore.ERR_ItemNotEnoughError;
        }

        public static void OnZeroClockUpdate(this JiaYuanComponent self)
        {
#if SERVER
            int openday = DBHelper.GetOpenServerDay(self.DomainZone());
            self.PlantGoods = MysteryShopHelper.InitJiaYuanMysteryItemInfos(openday, 5);  //self.JiaYuanLeve
            self.PastureGoods =JiaYuanHelper.InitJiaYuanPastureList(5);    
#endif
        }

        public static JiaYuanPlant GetCellPlant(this JiaYuanComponent self, int cell)
        {
#if SERVER
            for (int i = 0; i < self.JianYuanPlantList_1.Count; i++)
            {
                if (self.JianYuanPlantList_1[i].CellIndex == cell)
                { 
                    return self.JianYuanPlantList_1[i];
                }
            }
#endif
            return null;
        }

        public static void UprootPlant(this JiaYuanComponent self, int cellIndex)
        {
#if SERVER
            for (int i = self.JianYuanPlantList_1.Count - 1; i >= 0; i--)
            {
                if (self.JianYuanPlantList_1[i].CellIndex == cellIndex)
                {
                    self.JianYuanPlantList_1.RemoveAt(i);
                }
            }
#endif
        }

        public static void UpdatePlant(this JiaYuanComponent self, JiaYuanPlant jiaYuanPlant)
        {
#if SERVER
            for (int i = 0; i < self.JianYuanPlantList_1.Count; i++)
            {
                if (self.JianYuanPlantList_1[i].CellIndex != jiaYuanPlant.CellIndex)
                {
                    continue;
                }
                self.JianYuanPlantList_1[i] = jiaYuanPlant;
                return;
            }

            if (jiaYuanPlant.ItemId > 0)
            {
                self.JianYuanPlantList_1.Add(jiaYuanPlant);
            }
#endif
        }
    }
}
