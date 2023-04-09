using System.Collections.Generic;
using UnityEngine;

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
        /// <summary>
        /// int32 Statu = 3;    //0停止散步 1开始散步
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unitid"></param>
        /// <param name="status"></param>
        public static void OnJiaYuanPetWalk(this JiaYuanComponent self, RolePetInfo rolePetInfo, int status)
        {
#if SERVER
            for (int i = self.JiaYuanPetList_2.Count - 1; i >= 0; i--)
            {
                if (self.JiaYuanPetList_2[i].unitId == rolePetInfo.Id)
                {
                    self.JiaYuanPetList_2.RemoveAt(i);
                }
            }

            if (status == 2)
            {
                self.JiaYuanPetList_2.Add( new JiaYuanPet()
                {
                    StartTime = TimeHelper.ServerNow(),
                    LastExpTime = TimeHelper.ServerNow(),
                    unitId = rolePetInfo.Id,
                    ConfigId = rolePetInfo.ConfigId,
                    PetLv = rolePetInfo.PetLv,
                    PlayerName = rolePetInfo.PlayerName,
                    PetName = rolePetInfo.PetName,  
                    CurExp = 0,
                    MoodValue = 0,
                    TotalExp  = 0,
                });
            }
#endif
        }

        public static JiaYuanPet GetJiaYuanPet(this JiaYuanComponent self, long unitid)
        {
            for (int i = 0; i < self.JiaYuanPetList_2.Count; i++)
            {
                if (self.JiaYuanPetList_2[i].unitId == unitid)
                {
                    return self.JiaYuanPetList_2[i];
                }
            }
            return new JiaYuanPet();
        }

        public static void CheckDaShiPro(this JiaYuanComponent self)
        {
#if SERVER
            UserInfo userInfo = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv);

            string proMax = jiaYuanConfig.ProMax;
            string[] prolist = proMax.Split(';');
            Dictionary<int, int> promaxvalue = new Dictionary<int, int>();
            for (int i = 0; i < prolist.Length; i++)
            {
                if (ComHelp.IfNull(prolist[i]))
                {
                    continue;
                }
                string[] proinfo = prolist[i].Split(',');
                promaxvalue.Add(int.Parse(proinfo[0]), int.Parse(proinfo[1]));
            }

            for (int i = self.JiaYuanProList_7.Count - 1; i >= 0; i--)
            {
                int numericType = self.JiaYuanProList_7[i].KeyId;
                int lvalue = int.Parse(self.JiaYuanProList_7[i].Value);
                int maxvlue = 0;
                promaxvalue.TryGetValue(numericType, out maxvlue);
                maxvlue = (int)(maxvlue * 0.8f);
                if (lvalue >= maxvlue)
                {
                    lvalue -= 10;
                }
                lvalue = Mathf.Max(lvalue, 0);
                self.JiaYuanProList_7[i].Value = lvalue.ToString();
            }
#endif
        }

        public static List<HideProList> GetJianYuanPro(this JiaYuanComponent self)
        {
            List<HideProList> proList = new List<HideProList>();

            for (int i = self.JiaYuanProList_7.Count - 1; i >= 0; i--)
            {
                int numericType = self.JiaYuanProList_7[i].KeyId;
                long lvalue = long.Parse(self.JiaYuanProList_7[i].Value );
                proList.Add(new HideProList() { HideID = numericType, HideValue = lvalue });
            }

            List<KeyValuePair> jiayuandashi = ConfigHelper.JiaYuanDaShiPro;
            for (int i = 0; i < jiayuandashi.Count; i++)
            {
                string[] attrilist = jiayuandashi[i].Value2.Split('@');

                int lvalue = 0;
                for (int a = 0; a < attrilist.Length; a++)
                {
                    string[] attriInfo = attrilist[a].Split(';');
                    if (self.JiaYuanDaShiTime_1 >= int.Parse(attriInfo[1]))
                    {
                        lvalue = int.Parse(attriInfo[0]);
                    }
                }
                if(lvalue > 0)
                {
                    proList.Add(new HideProList() { HideID = jiayuandashi[i].KeyId, HideValue = lvalue });
                }
            }
            return proList;
        }

        public static void UpdateDaShiProInfo(this JiaYuanComponent self, int keyid, int addvalue)
        {
            for (int i = 0; i < self.JiaYuanProList_7.Count; i++)
            {
                if (self.JiaYuanProList_7[i].KeyId == keyid)
                {
                    int oldvalue = int.Parse(self.JiaYuanProList_7[i].Value);
                    oldvalue += addvalue;
                    self.JiaYuanProList_7[i].Value = oldvalue.ToString();
                    return;
                }
            }
            self.JiaYuanProList_7.Add( new KeyValuePair() { KeyId = keyid, Value = addvalue.ToString() } );
        }

        public static KeyValuePair GetDaShiProInfo(this JiaYuanComponent self, int keyid)
        {
            for (int i = 0; i < self.JiaYuanProList_7.Count; i++)
            {
                if (self.JiaYuanProList_7[i].KeyId == keyid)
                {
                    return self.JiaYuanProList_7[i];
                }
            }
            return null;
        }

        public static bool IsMyJiaYuan(this JiaYuanComponent self, long selfId)
        {
#if !SERVER
            return self.MasterId == selfId;
#else
            return false;
#endif

        }

        /// <summary>
        /// 老的农场作物 过了24个小时自动去掉
        /// </summary>
        /// <param name="self"></param>
        public static void CheckOvertime(this JiaYuanComponent self)
        {
#if SERVER
            long serverTime = TimeHelper.ServerNow();
            //植物
            for (int i = self.JianYuanPlantList_7.Count- 1; i >= 0; i--)
            {
                JiaYuanPlant jiaYuanPlant = self.JianYuanPlantList_7[i];
                int state = JiaYuanHelper.GetPlanStage(jiaYuanPlant.ItemId, jiaYuanPlant.StartTime, jiaYuanPlant.GatherNumber);

                if (state != 4)
                {
                    continue;
                }
                if (serverTime - jiaYuanPlant.GatherLastTime <= TimeHelper.OneDay)
                {
                    continue;
                }

                self.JianYuanPlantList_7.RemoveAt (i);
            }

            //动物
            for (int i = self.JiaYuanPastureList_7.Count - 1; i>= 0; i--)
            {
                JiaYuanPastures jiaYuanPlant = self.JiaYuanPastureList_7[i];
                int state = JiaYuanHelper.GetPastureState(jiaYuanPlant.ConfigId, jiaYuanPlant.StartTime, jiaYuanPlant.GatherNumber);

                if (state != 4)
                {
                    continue;
                }
                if (serverTime - jiaYuanPlant.GatherLastTime <= TimeHelper.OneDay)
                {
                    continue;
                }

                self.JiaYuanPastureList_7.RemoveAt(i);
            }
#endif
        }

        public static List<int> InitOpenList(this JiaYuanComponent self)
        {
            if (self.PlanOpenList_7.Count == 0)
            {
                self.PlanOpenList_7.AddRange(new List<int>() { 0, 1, 2, 3 });
            }
            return self.PlanOpenList_7;
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

        public static void OnEnter(this JiaYuanComponent self)
        {
            self.CheckOvertime();
            self.CheckRefreshMonster();
            self.CheckPetExp();
        }

        public static void Check(this JiaYuanComponent self)
        {

        }

        public static void UpdatePetMood(this JiaYuanComponent self, long unitid, int addvalue)
        {
            for (int i = 0; i < self.JiaYuanPetList_2.Count; i++)
            {
                JiaYuanPet jiaYuanPet = self.JiaYuanPetList_2[i];
                if (jiaYuanPet.unitId != unitid)
                {
                    continue;
                }

                jiaYuanPet.MoodValue += addvalue;
            }
        }

        public static void CheckPetExp(this JiaYuanComponent self)
        {
            long serverTime = TimeHelper.ServerNow();

            for ( int i = 0; i < self.JiaYuanPetList_2.Count; i++)
            {
                JiaYuanPet jiaYuanPet = self.JiaYuanPetList_2[i];

                long passTime = serverTime - jiaYuanPet.LastExpTime;
                if (passTime < TimeHelper.Hour)
                {
                    continue;
                }
                ExpConfig expConfig = ExpConfigCategory.Instance.Get(jiaYuanPet.PetLv);
                int passHour = (int)(passTime / TimeHelper.Hour);
                passHour = Mathf.Min(12, passHour);
                jiaYuanPet.CurExp += (long)( passHour * expConfig.PetItemUpExp * JiaYuanHelper.GetPetExpCoff(jiaYuanPet.MoodValue));
                jiaYuanPet.LastExpTime += (passHour * TimeHelper.Hour);
            }
        }

        public static void OnRemoveUnit(this JiaYuanComponent self, long unitid)
        {
#if SERVER
            for (int i = self.JiaYuanMonster_2.Count - 1; i >= 0; i--)
            {
                JiaYuanMonster keyValuePair = self.JiaYuanMonster_2[i];
                if (keyValuePair.unitId == unitid)
                {
                    self.JiaYuanMonster_2.RemoveAt(i);
                }
            }
#endif
        }

        public static void CheckRefreshMonster(this JiaYuanComponent self)
        {
#if SERVER
            //keyValuePair.KeyId    怪物id
            //keyValuePair.Value    怪物出生时间戳
            //keyValuePair.Value2   怪物坐标
            long serverNow =  TimeHelper.ServerNow();
            for (int i = self.JiaYuanMonster_2.Count -1; i >= 0; i--)
            {
                JiaYuanMonster keyValuePair = self.JiaYuanMonster_2[i];
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(keyValuePair.ConfigId);
                long deathTime = monsterConfig.DeathTime * 1000;
                if (serverNow - keyValuePair.BornTime >= deathTime)
                {
                    self.JiaYuanMonster_2.RemoveAt(i);
                }
            }
            if (self.RefreshMonsterTime_1 == 0)
            {
                self.RefreshMonsterTime_1 = serverNow - TimeHelper.Hour * 5;
            }

            while (serverNow - self.RefreshMonsterTime_1 >= TimeHelper.Hour)
            {
                if (self.JiaYuanMonster_2.Count >= 10)
                {
                    break;
                }

                self.RefreshMonsterTime_1 += TimeHelper.Hour;
                JiaYuanMonster keyValuePair = new JiaYuanMonster();
                keyValuePair.ConfigId = JiaYuanHelper.GetRandomMonster();
                keyValuePair.BornTime = self.RefreshMonsterTime_1;
                Vector3 vector3 = JiaYuanHelper.GetMonsterPostion();
                keyValuePair.x = vector3.x;
                keyValuePair.y = vector3.y;
                keyValuePair.z = vector3.z;
                keyValuePair.unitId = IdGenerater.Instance.GenerateId();
                self.JiaYuanMonster_2.Add(keyValuePair);
            }
            self.RefreshMonsterTime_1 = serverNow;
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
            self.CheckDaShiPro();
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

        public static int GetRubbishNumber(this JiaYuanComponent self)
        {
#if SERVER
            return self.JiaYuanMonster_2.Count;
#else
            return 0;
#endif
        }

        public static int GetCanGatherNumber(this JiaYuanComponent self)
        {
#if SERVER
            int number = 0;
            for (int i = 0; i < self.JianYuanPlantList_7.Count; i++)
            {
                JiaYuanPlant jiaYuanPlan = self.JianYuanPlantList_7[i];
                int errorcode = JiaYuanHelper.GetPlanShouHuoItem(jiaYuanPlan.ItemId, jiaYuanPlan.StartTime, jiaYuanPlan.GatherNumber, jiaYuanPlan.GatherLastTime);
                if (errorcode == ErrorCore.ERR_Success)
                {
                    number++;
                }
            }
            return number;
#else
            return 0;
#endif
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
    }
}
