using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using System.Linq;

namespace ET
{

    public static class ComHelp
    {
        public const int MaxZone = 202;

        public const string RobotPassWord = "et@#robot";

        public const int Version = 20230518;

        //宠物魔法技能
        public static List<int> PetMagicSkill = new List<int>(2) { };
        //public static List<int> PetMagicSkill = new List<int>(2) { 80001003, 80002003 };
     
        public const int RankNumber = 30;
        public const int CampRankNumber = 50;
        public const int PetRankNumber = 100;
        public const int PetHeXinMax = 120;

        //熔炼获得道具
        public const int MeltingItemId = 1;

        public const int ShenYuanCostId = 10000150;

        public static int MaxShuLianDu()
        {
            return GlobalValueConfigCategory.Instance.Get(45).Value2;
        }

        public static int GetMaxBaoShiDu()
        {
            return 120;
        }


        public static int GetPetMaxNumber(Unit unit, int level)
        {
            int petNumber = 1;
            string[] petInfos = GlobalValueConfigCategory.Instance.Get(34).Value.Split('@');
            for (int i = 0; i < petInfos.Length; i++)
            {
                string[] numberInfos = petInfos[i].Split(';');
                petNumber = int.Parse(numberInfos[1]);
                if (level <= int.Parse(numberInfos[0]))
                {
                    return petNumber + unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetExtendNumber);
                }
            }
            return petNumber + unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetExtendNumber);
        }

        public static int MainCityID()
        {
            return GlobalValueConfigCategory.Instance.Get(47).Value2;
        }

        /// <summary>
        /// 经验加成
        /// </summary>
        /// <returns></returns>
        public static float GetExpAdd(int userLv, ServerInfo serverInfo)
        {
            int worldLv = serverInfo.WorldLv;                   //世界等级
            RankingInfo rankingInfo = serverInfo.RankingInfo;   //肝帝[可能为空]

            float pro = (worldLv - userLv) * 0.02f;
            if (pro > 0.2f) {
                pro = 0.2f;
            }

            if (pro < 0)
            {
                pro = 0f;
            }

            return pro;
        }

#if NOT_UNITY
        public static bool IsInnerNet()
        {
            if (StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("127.0.0.1")
               || StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("192.168"))
            {
                return true;
            }
            return false;
        }

#endif

        public static int GetPlayerLimit(int sceneId)
        {
            return SceneConfigCategory.Instance.Get(sceneId).PlayerLimit;
        }

        //版号专区
        public static bool IsBanHaoZone(int zone)
        {
            return zone == 201;
        }

        //内部专区
        public static bool IsAlphaZone(int zone)
        {
            return zone == 200;
        }

        public static bool IfNull(string value) {

            if (value == "" || value == "0" || value == null) {
                return true;
            }
            else {
                return false;
            }
        }

        public static int GetDayByTime(long time)
        {
            DateTime dateTime = TimeInfo.Instance.ToDateTime(time);
            return dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day;
        }

        //字符串转换整形List
        public static List<int> StringArrToIntList(string[] stringArr) {

            List<int> listValue = new List<int>();

            for (int i = 0; i < stringArr.Length; i++) {
                listValue.Add(int.Parse(stringArr[i]));
            }

            return listValue;
        }

        //根据品质返回一个Color
        public static string QualityReturnColor(int ItenQuality)
        {
            string color = "FFFFFF";
            switch (ItenQuality)
            {
                case 1:
                    //color = new Color(1, 1, 1);
                    break;

                case 2:
                    color = "00FF00";
                    break;
                case 3:
                    color = "0CC2D8";
                    break;

                case 4:
                    color = "EF7FFF";
                    break;
                case 5:
                    color = "FF7F00";
                    break;
                case 6:
                    color = "CC7F30";
                    break;
            }
            return color;
        }


        //浅拷贝即可
        public static T DeepCopy<T>(T obj)
        {
            //如果是字符串或值类型则直接返回
            if (obj == null || obj is string || obj.GetType().IsValueType) return obj;

            object retval = Activator.CreateInstance(obj.GetType());
            System.Reflection.FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (System.Reflection.FieldInfo field in fields)
            {
                //try { field.SetValue(retval, DeepCopy(field.GetValue(obj))); }
                try { field.SetValue(retval, (field.GetValue(obj))); }
                catch { }
            }
            return (T)retval;
        }

        public static T DeepCopy_2<T>(T obj)
        {
            //如果是字符串或值类型则直接返回
            if (obj == null || obj is string || obj.GetType().IsValueType) return obj;

            object retval = Activator.CreateInstance(obj.GetType());
            System.Reflection.FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (System.Reflection.FieldInfo field in fields)
            {
                try { field.SetValue(retval, DeepCopy(field.GetValue(obj))); }
                catch { }
            }
            return (T)retval;
        }

        public static bool IsShowPaiMai(int itemType, int subType)
        {
            if (itemType == 1)
            {
                if (subType == 101 || subType == 106 || subType == 114 || subType == 121 || subType == 15 || subType == 102)
                {
                    return true;
                }
            }

            if (itemType == 2)
            {
                
                if (subType == 1 || subType == 101 || subType == 121 || subType == 122)
                {
                    return true;
                }
                
            }

            if (itemType == 3 || itemType == 4)
            {
                return true;
            }
            return  false;
        }

        //根据时间蛋计算剩余消耗钻石
        public static int ReturnPetOpenTimeDiamond(int itemID,long endTime) {

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemID);
            string[] itemUseinfo = itemConfig.ItemUsePar.Split('@');
            float costValue = float.Parse(itemUseinfo[1]);

            long timeNow = endTime - TimeHelper.ServerNow();
            if (timeNow <= 0)
            {
                return 0;
            }

            float proValue = (float)timeNow / 86400000f;
            int renturnInt = (int)(proValue * costValue);

            if (renturnInt < 10) {
                renturnInt = 10;
            }

            return renturnInt;
        }


        //暴击等级等属性转换成实际暴击率的方法
        public static float LvProChange(long value, int lv)
        {
            float proValue = (float)value / (float)(7500 + lv * 250);
            if (proValue < 0)
            {
                proValue = 0;
            }
            if (proValue > 0.75f)
            {
                proValue = 0.75f;
            }
            return proValue;
        }


        //藏宝图等级对应掉落
        public static int TreasureToDropID(int dungeonID,int roleLv) {

            DungeonConfig dungCof = DungeonConfigCategory.Instance.Get(dungeonID);
            int lv = dungCof.EnterLv;
            if (RandomHelper.RandFloat01() <= 0.5f)
            {
                lv = roleLv;
            }

            if (lv <= 18)
            {
                return 60801101;
            }

            if (lv <= 29)
            {
                return 60801201;
            }

            if (lv <= 39)
            {
                return 60801301;
            }

            if (lv <= 49)
            {
                return 60801401;
            }

            if (lv <= 100)
            {
                return 60801501;
            }


            return 0;

        }


        public static int GetZhuPuGaiLv(int monsterid, int itemid, int jiacheng)
        {
            if (monsterid == 0)
            {
                return 0;
            }
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
            int[] Parameter = monsterConfig.Parameter;
            if (Parameter == null)
            {
                return 0;
            }
            int gailv = Parameter[0];
            if (itemid > 0)
            {
                int add = GlobalValueConfigCategory.Instance.ZhuaPuItem[itemid];

                //抓捕怪物加成
                if (monsterConfig.MonsterSonType == 58) {
                    add = add * 2;
                }

                gailv += add;

            }
            //触点加成
            if (jiacheng == 2)
            {
                gailv += 50;
            }
            return gailv;
        }

        public static int GetJiaYuanPetExp(int petLv, int xinqingValue) {

            ExpConfig expCof = ExpConfigCategory.Instance.Get(petLv);
            float ProValue = 1;
            switch (xinqingValue) {
                case 0:
                    ProValue = 0.3f;
                    break;

                case 1:
                    ProValue = 0.5f;
                    break;

                case 2:
                    ProValue = 0.65f;
                    break;

                case 3:
                    ProValue = 0.8f;
                    break;

                case 4:
                    ProValue = 0.9f;
                    break;

                case 5:
                    ProValue = 1f;
                    break;
            }
            return (int)(expCof.PetItemUpExp* ProValue);
        }


        //宠物守护
        public static float GetPetShouHuPro(int mainValue, int fightValue)
        {

            mainValue = mainValue - 2000;
            if (mainValue < 2000)
            {
                mainValue = 0;
            }

            fightValue = fightValue - 8000;
            if (fightValue < 0)
            {
                fightValue = 0;
            }

            float mainPro = LvProChange((long)(mainValue * 0.1f), 70);
            float otherPro = LvProChange((long)(fightValue / 4 * 0.1f), 70);

            if (mainPro < 0)
            {
                mainPro = 0;
            }

            if (otherPro < 0)
            {
                otherPro = 0;
            }

            float pro = mainPro + otherPro;

            return pro;
        }

    }
}
