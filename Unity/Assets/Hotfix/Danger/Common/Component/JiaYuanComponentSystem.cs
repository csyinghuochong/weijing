using System.Collections.Generic;

namespace ET
{

    public class JianYuanComponentAwake : AwakeSystem<JiaYuanComponent>
    {
        public override void Awake(JiaYuanComponent self)
        {
#if SERVER
            self.InitOpenList();
#endif
        }
    }

    public static class JianYuanComponentSystem
    {

        public static List<int> InitOpenList(this JiaYuanComponent self)
        {
            if (self.PlanOpenList_7.Count == 0)
            {
                self.PlanOpenList_7.AddRange(new List<int>() { 0, 1, 2, 3 });
            }
            return self.PlanOpenList_7;
        }

        public static void OnUpdatePurchase(this JiaYuanComponent self)
        { 
            
        }

        public static void OnLogin(this JiaYuanComponent self)
        {
#if SERVER
            int openday = DBHelper.GetOpenServerDay(self.DomainZone());
            UserInfo userInfo = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo;
            int jiayuanlv = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv).Lv ;
            if (self.PlantGoods_7.Count == 0)
            {
                self.PlantGoods_7 = MysteryShopHelper.InitJiaYuanPlanItemInfos(openday, jiayuanlv); 
                self.PastureGoods_7 = JiaYuanHelper.InitJiaYuanPastureList(jiayuanlv);
            }
            if (self.PurchaseItemList_7.Count == 0)
            {
                self.UpdatePurchaseItemList(false);
            }
#endif
        }

        public static int OnPastureBuyRequest(this JiaYuanComponent self, int ProductId)
        {
#if SERVER
            for (int i = 0; i < self.PastureGoods_7.Count; i++)
            {
                MysteryItemInfo mysteryItemInfo1 = self.PastureGoods_7[i];

                if (mysteryItemInfo1.ProductId != ProductId)
                {
                    continue;
                }
                if (mysteryItemInfo1.ItemNumber < 1)
                {
                    return ErrorCore.ERR_ItemNotEnoughError;
                }

                self.PastureGoods_7.RemoveAt(i);
                return ErrorCore.ERR_Success;
            }
#endif
            return ErrorCore.ERR_ItemNotEnoughError;
        }

        public static int OnMysteryBuyRequest(this JiaYuanComponent self, int ProductId)
        {
#if SERVER
            for (int i = 0; i < self.PlantGoods_7.Count; i++)
            {
                MysteryItemInfo mysteryItemInfo1 = self.PlantGoods_7[i];

                if (mysteryItemInfo1.ProductId != ProductId)
                {
                    continue;
                }
                if (mysteryItemInfo1.ItemNumber < 1)
                {
                    return ErrorCore.ERR_ItemNotEnoughError;
                }

                self.PlantGoods_7.RemoveAt(i);    
                return ErrorCore.ERR_Success;
            }
#endif
            return ErrorCore.ERR_ItemNotEnoughError;
        }

        /// <summary>
        /// 零点刷新
        /// </summary>
        /// <param name="self"></param>
        public static void OnZeroClockUpdate(this JiaYuanComponent self, bool notice)
        {
#if SERVER
            UserInfo userInfo = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo;
            int jiayuanlv = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv).Lv;
            int openday = DBHelper.GetOpenServerDay(self.DomainZone());
            self.PlantGoods_7 = MysteryShopHelper.InitJiaYuanPlanItemInfos(openday, jiayuanlv);  //self.JiaYuanLeve
            self.PastureGoods_7 =JiaYuanHelper.InitJiaYuanPastureList(jiayuanlv);
            self.UpdatePurchaseItemList(notice);
#endif
        }

        /// <summary>
        /// 12点刷新
        /// </summary>
        /// <param name="self"></param>
        /// <param name="hour_1"></param>
        /// <param name="hour_2"></param>
        public static void OnHour12Update(this JiaYuanComponent self, int hour_1, int hour_2)
        {
            if (hour_1 < 12 && hour_2 >= 12)
            {
                self.UpdatePurchaseItemList(true);
            }
        }

        public static void UpdatePurchaseItemList(this JiaYuanComponent self, bool notice)
        {
#if SERVER
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < self.PurchaseItemList_7.Count; i++)
            {
                if (self.PurchaseItemList_7[i].EndTime < serverTime)
                {
                    self.PurchaseItemList_7.RemoveAt(i);
                }
            }

            UserInfo userInfo = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo;
            JiaYuanHelper.InitPurchaseItemList(userInfo.JiaYuanLv, self.PurchaseItemList_7);
            if (notice)
            {
                M2C_JiaYuanPurchaseUpdate m2C_JiaYuan = new M2C_JiaYuanPurchaseUpdate() { PurchaseItemList = self.PurchaseItemList_7 };
                MessageHelper.SendToClient( self.GetParent<Unit>(), m2C_JiaYuan);
            }
#endif
        }

        public static void UprootPasture(this JiaYuanComponent self, long unitid)
        {
#if SERVER
            for (int i = self.JiaYuanPastureList_7.Count - 1; i >= 0; i--)
            {
                if (self.JiaYuanPastureList_7[i].UnitId == unitid)
                {
                    self.JiaYuanPastureList_7.RemoveAt(i);
                }
            }
#endif
        }

        public static JiaYuanPastures GetJiaYuanPastures(this JiaYuanComponent self, long unitid)
        {
#if SERVER
            for (int i = 0; i < self.JiaYuanPastureList_7.Count; i++)
            {
                if (self.JiaYuanPastureList_7[i].UnitId == unitid)
                {
                    return self.JiaYuanPastureList_7[i];
                }
            }
#endif

            return null;
        }

        public static JiaYuanPlant GetCellPlant(this JiaYuanComponent self, int cell)
        {
#if SERVER
            for (int i = 0; i < self.JianYuanPlantList_7.Count; i++)
            {
                if (self.JianYuanPlantList_7[i].CellIndex == cell)
                { 
                    return self.JianYuanPlantList_7[i];
                }
            }
#endif
            return null;
        }

        public static void UprootPlant(this JiaYuanComponent self, int cellIndex)
        {
#if SERVER
            for (int i = self.JianYuanPlantList_7.Count - 1; i >= 0; i--)
            {
                if (self.JianYuanPlantList_7[i].CellIndex == cellIndex)
                {
                    self.JianYuanPlantList_7.RemoveAt(i);
                }
            }
#endif
        }

        public static int GetPeopleNumber(this JiaYuanComponent self)
        {
            int number = 0;
            for (int i = 0; i < self.JiaYuanPastureList_7.Count; i++)
            {
                JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(self.JiaYuanPastureList_7[i].ConfigId);
                number += jiaYuanPastureConfig.PeopleNum;
            }
            return number;
        }

        public static int GetOpenPlanNumber(this JiaYuanComponent self)
        {
            return self.PlanOpenList_7.Count;
        }

        public static void UpdatePlant(this JiaYuanComponent self, JiaYuanPlant jiaYuanPlant)
        {
#if SERVER
            for (int i = 0; i < self.JianYuanPlantList_7.Count; i++)
            {
                if (self.JianYuanPlantList_7[i].CellIndex != jiaYuanPlant.CellIndex)
                {
                    continue;
                }
                self.JianYuanPlantList_7[i] = jiaYuanPlant;
                return;
            }

            if (jiaYuanPlant.ItemId > 0)
            {
                self.JianYuanPlantList_7.Add(jiaYuanPlant);
            }
#endif
        }
    }
}
