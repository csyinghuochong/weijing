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

        //宠物魔法技能
        public static List<int> PetMagicSkill = new List<int>(2) { };
        //public static List<int> PetMagicSkill = new List<int>(2) { 80001003, 80002003 };
        //赠送钻石数量
        public static Dictionary<int, int> RechargeGive = new Dictionary<int, int>(8){
            { 6,        0},
            { 30,       300},
            { 50,       600},
            { 98,       1200},
            { 198,      2888},
            { 298,      4888},
            { 488,      8888},
            { 648,      12888},
        };

        public static int GetDiamondNumber(int key)
        {
            if (!RechargeGive.ContainsKey(key))
            {
                return 0;
            }
            int number = RechargeGive[key];
            return key * 100 + number;
        }

        public const int RankNumber = 30;
        public const int CampRankNumber = 50;
        public const int PetRankNumber = 100;
        public const int PetHeXinMax = 120;

        //熔炼获得道具
        public const int MeltingItemId = 1;

        public const int ShenYuanCostId = 10000150;

        public static int ReturnMeltingItem(int type) 
        {
            //根据不同的专业技能熔炼不同的道具
            int getItemId = 1;
            switch (type)
            {

                //锻造
                case 1:
                    getItemId = 10000144;
                    break;

                //裁缝
                case 2:
                    getItemId = 10000145;
                    break;

                //炼金
                case 3:
                    getItemId = 10000146;
                    break;

                //附魔
                case 6:
                    getItemId = 10000147;
                    break;

            }

            return getItemId;

        }

        public static int BagMaxCapacity()
        {
            return GlobalValueConfigCategory.Instance.Get(3).Value2;
        }

        public static int StoreCapacity()
        {
            return GlobalValueConfigCategory.Instance.Get(4).Value2;
        }

        public static int MaxShuLianDu()
        {
            return GlobalValueConfigCategory.Instance.Get(45).Value2;
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

#if SERVER
        public static int GetPlayerLimit(int sceneId)
        {
            return SceneConfigCategory.Instance.Get(sceneId).PlayerLimit;
        }

        public static void LoginInfo(string log)
        {
            string filePath = "../Logs/login.txt"; 
            if (File.Exists(filePath))
            {
                StreamWriter sw = File.AppendText(filePath);
                sw.WriteLineAsync(log);
                sw.Flush();
                sw.Close();
            }
            else
            {
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.WriteLineAsync(log);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// 鉴定符根据熟练度算品质的方法
        /// </summary>
        /// <param name="bagInf0"></param>
        /// <param name="getType">1购买</param>
        public static void JianDingFuItem(BagInfo bagInf0, int shulianValue, int getType)
        {
            if (ItemHelper.IsBuyItem(getType))
            {
                bagInf0.ItemPar = GlobalValueConfigCategory.Instance.JianDingFuQulity.ToString();
                return;
            }

            //万能鉴定符固定为60
            if (bagInf0.ItemID == 11200000) {
                bagInf0.ItemPar = "99";
                return;
            }

            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInf0.ItemID);
            float minValuePro = (float)shulianValue / (float)int.Parse(itemCof.ItemUsePar);
            if (minValuePro >= 1)
            {
                minValuePro = 1;
            }
            if (minValuePro <= 0.2f)
            {
                minValuePro = 0.2f;
            }
            int minValue = (int)(minValuePro * 50f);
            int maxValue = (int)(minValuePro * 100f);
            bagInf0.ItemPar = RandomHelper.RandomNumber(minValue, maxValue).ToString();
        }

        public static void TreasureItem(BagInfo bagInfo)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (itemConfig.ItemSubType != 113)
            {
                return;
            }
            List<DungeonConfig> dungeonConfigs = DungeonConfigCategory.Instance.GetAll().Values.ToList();
            int dungeonindex = RandomHelper.RandomNumber(0, dungeonConfigs.Count);
            int dungeonid = dungeonConfigs[dungeonindex].Id;

            List<DropConfig> dropConfigs = DropConfigCategory.Instance.GetAll().Values.ToList();
            int dropIndex = RandomHelper.RandomNumber(0, dropConfigs.Count);
            int dropId = dropConfigs[dropIndex].Id;

            bagInfo.ItemPar = $"{dungeonid}@{"TaskMove_6"}@{dropId}";
        }


        //获取装备的专精属性
        public static List<HideProList> GetEquipZhuanJingHidePro(int equipID, int itemID, int jianDingPinZhi, Unit unit,bool ifItem)
        {
            //获取最大值
            EquipConfig equipCof = EquipConfigCategory.Instance.Get(equipID);
            List<HideProList> hideList = new List<HideProList>();

            //获取当前鉴定系数
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(itemID);

            //鉴定符品质大于装备等级
            /*
            float JianDingPro = 1f;
            if (jianDingPinZhi >= itemCof.UseLv)
            {
   
            }
            else
            {
                JianDingPro = jianDingPinZhi / itemCof.UseLv * 0.5f;
            }
            */

            //测试
            //jianDingPinZhi = 99;

            //最低系数是20
            int pro = itemCof.UseLv;
            if (pro <= 20)
            {
                pro = 20;
            }

            if (ifItem == true && itemCof.UseLv < 30) {
                jianDingPinZhi = jianDingPinZhi + 5;
            }

            //鉴定符和当前装备的等级差
            float JianDingPro = (float)jianDingPinZhi / (float)pro;
            float addJianDingPro = 0;

            if (JianDingPro >= 1.5f)
            {
                JianDingPro = 1.5f;
                addJianDingPro += 0.1f;
            }

            if (JianDingPro <= 0.5f)
            {
                JianDingPro = 0.5f;
            }

            int randomNum = 0;
            float randomFloat = RandomHelper.RandFloat() + addJianDingPro;

            Log.Info("randomFloat == " + randomFloat + "  JianDingPro = " + JianDingPro);

            randomFloat = randomFloat * JianDingPro;

            if (randomFloat <= 0.25f)
            {
                randomNum = 0;
            }
            else if (randomFloat <= 0.6f)
            {
                randomNum = 1;
            }
            else if (randomFloat <= 1f)
            {
                randomNum = 2;
            }
            else
            {
                randomNum = 3;
            }
            /*
            else if (randomFloat <= 0.9f)
            {
                randomNum = 3;
            }
            */

            if (ifItem)
            {
                if (randomNum >= 2)
                {
                    string noticeContent = $"恭喜玩家<color=#B6FF00>{unit.GetComponent<UserInfoComponent>().UserInfo.Name}</color>使用鉴定符鉴定装备时,一道金光装备出现<color=#FFA313>{randomNum}条极品属性</color>";
                    ServerMessageHelper.SendBroadMessage(unit.DomainZone(), NoticeType.Notice, noticeContent);
                }
            }


            if (randomNum == 0)
            {
                return null;
            }

            for (int i = 0; i < randomNum; i++)
            {
                //随机值
                int randomValueInt = RandomHelper.RandomNumber(1, equipCof.OneProRandomValue);
                randomValueInt = (int)(randomValueInt * JianDingPro);
                if (randomValueInt > equipCof.OneProRandomValue) {
                    randomValueInt = equipCof.OneProRandomValue;
                }
                //如果品质符足够好,保底为5
                if (randomValueInt < 5) {
                    if (JianDingPro >= 1.5f) {
                        randomValueInt = 5;
                    }
                }

                //保底为1点,防止出现0点属性
                if (randomValueInt < 1) {
                    randomValueInt = 1;
                }

                //随机属性类型
                int randomIDInt = RandomHelper.RandomNumber(1, 5);
                //
                int proID = 105101;
                switch (randomIDInt)
                {
                    case 1:
                        proID = 105101;
                        break;
                    case 2:
                        proID = 105201;
                        break;
                    case 3:
                        proID = 105301;
                        break;
                    case 4:
                        proID = 105401;
                        break;
                    case 5:
                        proID = 105501;
                        break;
                }

                HideProList hideProList = new HideProList();
                hideProList.HideID = proID;
                hideProList.HideValue = randomValueInt;
                hideList.Add(hideProList);

            }

            return hideList;

        }

#endif

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

        public static int GetEquipType(int itemId)
        {
            if (itemId == 0)
            {
                return ItemEquipType.Sword;
            }
            else
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                return itemConfig.EquipType;
            }
        }

        public static int GetWorldLvLastDay()
        {
            int lastDay = 0;
            string[] lvlist = GlobalValueConfigCategory.Instance.Get(42).Value.Split('@');
            for (int i = 0; i < lvlist.Length; i++)
            {
                string[] levelinfo = lvlist[i].Split(';');
                int day = int.Parse(levelinfo[0]);
                if (day > lastDay)
                {
                    lastDay = day;
                }
            }
            return lastDay;
        }

        public static int GetWorldLv(int openserverDay)
        {
            int worldLv = 0;
            string[] lvlist = GlobalValueConfigCategory.Instance.Get(42).Value.Split('@');
            for (int i = 0; i < lvlist.Length; i++)
            {
                string[] levelinfo = lvlist[i].Split(';');
                worldLv = int.Parse(levelinfo[1]);
                if (openserverDay <= int.Parse(levelinfo[0]))
                {
                    return worldLv;
                }
            }
            return worldLv;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gandiLv">肝帝等级</param>
        /// <param name="userLv">自身等级</param>
        /// <returns></returns>
        public static float GetExpRate(int gandiLv, int userLv)
        {
            return 0.5f; 
        }

        //开服时间[有问题呢]
        public static int DateDiff_Day(long time1, long time2)
        {
            long diff = time1 - time2;
            DateTime start = TimeInfo.Instance.ToDateTime(time1);
            DateTime end = TimeInfo.Instance.ToDateTime(time2);
            return Mathf.FloorToInt(1f * diff / TimeHelper.OneDay);
        }

        public static int DateDiff_Time(long time1, long time2)
        {
            DateTime d1 = TimeInfo.Instance.ToDateTime(time1);
            DateTime d2 = TimeInfo.Instance.ToDateTime(time2);
            DateTime d3 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", d1.Year, d1.Month, d1.Day));

            DateTime d4 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", d2.Year, d2.Month, d2.Day));
            int days = (d3 - d4).Days + 1;
            return days;
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

        //道具数量显示返回
        public static string ReturnNumStr(long num) {

            if (num < 10000)
            {
                return num.ToString();
            }
            else {
                //float floatNum = (float)num / 10000f;
                return ((float)num / 10000.0f).ToString("0.##") + "万";
            }

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

        public static int CanLogin(string identityCard, bool isHoliday)
        {
            int age = ComHelp.GetBirthdayAgeSex(identityCard);
            if (age >= 18)
            {
                return ErrorCore.ERR_Success;
            }
            if (age < 12)
            {
                return ErrorCore.ERR_FangChengMi_Tip6;
            }
            DateTime dateTime = TimeHelper.DateTimeNow();
            if (isHoliday)
            {
                if (dateTime.Hour == 20)
                {
                    return ErrorCore.ERR_Success;           //允许登录
                }
                else
                {
                    return ErrorCore.ERR_FangChengMi_Tip7;
                }
            }
            else
            {
                return ErrorCore.ERR_FangChengMi_Tip7;
            }
        }

        public static int GetBirthdayAgeSex(string identityCard)
        {
            if (string.IsNullOrEmpty(identityCard))
            {
                return 0;
            }
            else
            {
                if (identityCard.Length != 15 && identityCard.Length != 18)//身份证号码只能为15位或18位其它不合法
                {
                    return 0;
                }
            }

            string birthday = "";
            if (identityCard.Length == 18)//处理18位的身份证号码从号码中得到生日和性别代码
            {
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
            }
            if (identityCard.Length == 15)
            {
                birthday = "19" + identityCard.Substring(6, 2) + "-" + identityCard.Substring(8, 2) + "-" + identityCard.Substring(10, 2);
            }

            return CalculateAge(birthday);//根据生日计算年龄
        }

        /// <summary>
        /// 根据出生日期，计算精确的年龄
        /// </summary>
        /// <param name="birthDate">生日</param>
        /// <returns></returns>
        public static int CalculateAge(string birthDay)
        {
            string[] times = birthDay.Split('-');
            DateTime nowDateTime = DateTime.Now;
            int age = nowDateTime.Year - int.Parse(times[0]);
            //再考虑月、天的因素
            if (nowDateTime.Month < int.Parse(times[1]) || (nowDateTime.Month == int.Parse(times[1]) && nowDateTime.Day < int.Parse(times[2])))
            {
                age--;
            }
            return age;
        }


        public static Dictionary<int, UserDataType> ItemToUserDataType = new Dictionary<int, UserDataType>()
        {
            {  1, UserDataType.Gold },
            {  2, UserDataType.Exp },
            {  3, UserDataType.Diamond },
            {  4, UserDataType.Vitality },
            {  5, UserDataType.PiLao },
            {  6, UserDataType.RongYu },
            { 7, UserDataType.FangRong},
            { 8, UserDataType.MaoXianExp},
            { 9, UserDataType.DungeonTimes},
            { 10,UserDataType.Recharge},
            { 11,UserDataType.HuoYue},
            { 12,UserDataType.Sp},
        };

        public static UserDataType GetItemToUserDataType(int itemid)
        {
            UserDataType userDataType = UserDataType.None;
            ItemToUserDataType.TryGetValue(itemid, out userDataType);
            return userDataType;
        }

        //传入随机范围,生成一个随机数,越到后面的随机数获取概率越低
        public static int ReturnEquipRamdomValue(int randomMinValue, int randomMaxValue, int hideID = 0)
        {

            int randomChaValue = randomMaxValue - randomMinValue;
            //随机4次,获得取值范围
            /*
            0-25%       0.5
            26%-50%     0.3
            51%-75%     0.15
            76%-100%    0.05
            */
            float randomRangeValue = RandomHelper.RandFloat01();
            float randomRangeValue_Now = 0;
            if (randomRangeValue <= 0.5f)
            {
                //0-0.25f
                randomRangeValue_Now = randomRangeValue / 4;

            }
            if (randomRangeValue > 0.5f && randomRangeValue <= 0.8f)
            {
                //0.25-0.5
                randomRangeValue_Now = randomRangeValue / 4 + 0.25f;
            }
            if (randomRangeValue > 0.8f && randomRangeValue <= 0.95f)
            {
                //0.5-0.75
                randomRangeValue_Now = randomRangeValue / 4 + 0.5f;
            }
            if (randomRangeValue > 0.95f && randomRangeValue <= 1f)
            {
                //0.75-1
                randomRangeValue_Now = randomRangeValue / 4 + 0.75f;
            }

            //极品大师
            if (hideID != 0)
            {
                float hintSkillProValue = 0f;
                if (hintSkillProValue != 0f)
                {
                    randomRangeValue_Now = randomRangeValue_Now * (1 + hintSkillProValue);
                }
            }
            if (randomRangeValue_Now > 1)
            {
                randomRangeValue_Now = 1;
            }

            //计算最终值
            int retunrnValue = (int)(randomMinValue + randomChaValue * randomRangeValue_Now);
            return retunrnValue;
        }

        //获得装备洗炼隐藏属性
        public static List<HideProList> GetEquipXiLianHidePro(int equipID)
        {
            //获取最大值
            EquipConfig equipCof = EquipConfigCategory.Instance.Get(equipID);
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(equipID);
            List<HideProList> hideList = new List<HideProList>();
            float randomFloat = RandomHelper.RandFloat();

            //装备概率才会出现隐藏属性
            /*
            if (randomFloat <= 0.9f)
            {
                return null;
            }
            */

            //--------------随机基础属性--------------
            List<int> baseHideProList = new List<int>();
            baseHideProList.Add(NumericType.Base_MaxHp_Base);
            baseHideProList.Add(NumericType.Base_MaxAct_Base);
            baseHideProList.Add(NumericType.Base_MaxDef_Base);
            baseHideProList.Add(NumericType.Base_MaxAdf_Base);

            for (int i = 0; i < baseHideProList.Count; i++)
            {
                if (RandomHelper.RandFloat() <= equipCof.HideShowPro)
                {
                    //随机洗炼值
                    int randomValueInt = RandomHelper.RandomNumber(1, equipCof.HideMax);
                    //赋值属性
                    HideProList hideProList = new HideProList();
                    hideProList.HideID = (int)baseHideProList[i];
                    hideProList.HideValue = randomValueInt;
                    hideList.Add(hideProList);
                }
            }


            //---------------随机特殊属性---------------
            int nextID = 0;
            int hintProListID = 1001;
            //获取隐藏条最大目数
            int hintJiPinMaxNum = 3;
            int hintJiPinMaxNumSum = 0;

            do
            {
                //获取单条触发概率
                HideProListConfig hintProListCof = HideProListConfigCategory.Instance.Get(hintProListID);
                //判定当条属性位置是否激活
                //string[] equipSpaceList = hintProListCof.EquipSpace;
                bool equipStatus = false;
                if (hintProListCof.EquipSpace[0] != 0)
                {
                    for (int i = 0; i < hintProListCof.EquipSpace.Length; i++)
                    {
                        if (itemCof.ItemSubType == hintProListCof.EquipSpace[i])
                        {
                            equipStatus = true;
                        }
                    }
                }

                if (!equipStatus)
                {
                    break;
                }

                //触发隐藏属性
                hintProListCof.TriggerPro = 1;  //测试
                if (RandomHelper.RandFloat() < hintProListCof.TriggerPro)
                {
                    //读取隐藏属性类型和对应随机值
                    int hintProType = hintProListCof.PropertyType;
                    float propertyValueMin = float.Parse(hintProListCof.PropertyValueMin);
                    float propertyValueMax = float.Parse(hintProListCof.PropertyValueMax);
                    int hintProValueType = hintProListCof.HideProValueType;

                    //判定是随着等级变动
                    int ifEquipLvUp = hintProListCof.IfEquipLvUp;
                    if (ifEquipLvUp == 1)
                    {

                        //获取等级
                        int itemlv = itemCof.UseLv;
                        if (itemlv < 10)
                        {
                            itemlv = 10;
                        }
                        int itemNum = (int)(itemlv / 10);
                        itemNum = itemNum - 1;
                        if (itemNum < 1)
                        {
                            itemNum = 1;
                        }

                        //获取属性
                        propertyValueMax = propertyValueMax + propertyValueMax / 2 * itemNum;

                    }

                    //隐藏属性值得类型
                    float hintProVlaue = 0;
                    if (hintProValueType == 1)
                    {
                        //表示整数
                        hintProVlaue = ReturnEquipRamdomValue((int)(propertyValueMin), (int)(propertyValueMax));
                        if (hintProVlaue <= 0)
                        {
                            hintProVlaue = propertyValueMin;
                        }
                    }
                    else
                    {
                        //表示浮点数
                        hintProVlaue = ReturnEquipRamdomValue_float(propertyValueMin, propertyValueMax);
                        if (hintProVlaue <= 0)
                        {
                            hintProVlaue = propertyValueMin;
                        }

                        hintProVlaue = hintProVlaue * 10000;
                    }

                    //存储本次洗炼属性
                    HideProList hideProList = new HideProList();
                    hideProList.HideID = hintProListCof.Id;
                    hideProList.HideValue = (long)hintProVlaue;
                    Log.Info("HideID = " + hideProList.HideID + " hideProList.HideValue = " + hideProList.HideValue);
                    hideList.Add(hideProList);

                    hintJiPinMaxNumSum = hintJiPinMaxNumSum + 1;
                    if (hintJiPinMaxNumSum >= hintJiPinMaxNum)
                    {
                        //立即跳出循环
                        break;
                    }
                }

                nextID = hintProListCof.NtxtID;
                hintProListID = nextID;

            } while (nextID != 0);

            return hideList;
        }

        //传入随机范围,生成一个随机数,越到后面的随机数获取概率越低
        public static int ReturnEquipRamdomValue(int randomMinValue, int randomMaxValue)
        {

            int randomChaValue = randomMaxValue - randomMinValue;
            //随机4次,获得取值范围
            /*
            0-25%       0.5
            26%-50%     0.3
            51%-75%     0.15
            76%-100%    0.05
            */
            float randomRangeValue = RandomHelper.RandFloat();
            float randomRangeValue_Now = 0;
            if (randomRangeValue <= 0.5f)
            {
                //0-0.25f
                randomRangeValue_Now = RandomHelper.RandFloat() / 4;

            }
            if (randomRangeValue > 0.5f && randomRangeValue <= 0.8f)
            {
                //0.25-0.5
                randomRangeValue_Now = RandomHelper.RandFloat() / 4 + 0.25f;
            }
            if (randomRangeValue > 0.8f && randomRangeValue <= 0.95f)
            {
                //0.5-0.75
                randomRangeValue_Now = RandomHelper.RandFloat() / 4 + 0.5f;
            }
            if (randomRangeValue > 0.95f && randomRangeValue <= 1f)
            {
                //0.75-1
                randomRangeValue_Now = RandomHelper.RandFloat() / 4 + 0.75f;
            }

            if (randomRangeValue_Now > 1)
            {
                randomRangeValue_Now = 1;
            }

            //计算最终值
            int retunrnValue = (int)(randomMinValue + randomChaValue * randomRangeValue_Now);
            return retunrnValue;
        }

        //传入随机范围,生成一个随机数,越到后面的随机数获取概率越低
        public static float ReturnEquipRamdomValue_float(float randomMinValue, float randomMaxValue)
        {

            float randomChaValue = randomMaxValue - randomMinValue;
            //随机4次,获得取值范围
            /*
            0-25%       0.5
            26%-50%     0.3
            51%-75%     0.15
            76%-100%    0.05
            */
            float randomRangeValue = RandomHelper.RandFloat();
            float randomRangeValue_Now = 0;
            if (randomRangeValue <= 0.5f)
            {
                //0-0.25f
                randomRangeValue_Now = RandomHelper.RandFloat() / 4;

            }
            if (randomRangeValue > 0.5f && randomRangeValue <= 0.8f)
            {
                //0.25-0.5
                randomRangeValue_Now = RandomHelper.RandFloat() / 4 + 0.25f;
            }
            if (randomRangeValue > 0.8f && randomRangeValue <= 0.95f)
            {
                //0.5-0.75
                randomRangeValue_Now = RandomHelper.RandFloat() / 4 + 0.5f;
            }
            if (randomRangeValue > 0.95f && randomRangeValue <= 1f)
            {
                //0.75-1
                randomRangeValue_Now = RandomHelper.RandFloat() / 4 + 0.75f;
            }

            if (randomRangeValue_Now > 1)
            {
                randomRangeValue_Now = 1;
            }

            //计算最终值
            float retunrnValue = (float)(randomMinValue + randomChaValue * randomRangeValue_Now);
            retunrnValue = (float)(System.Math.Round(retunrnValue, 3));
            return retunrnValue;
        }

        //金币鉴定消费
        public static int GetJianDingCoin(int level)
        {
            int gold = 25000;
            bool ifStatus = false;

            if (level <= 18) {
                gold = 25000;
                ifStatus = true;
            }

            if (level <= 29 && ifStatus == false)
            {
                gold = 30000;
            }

            if (level <= 39 && ifStatus == false)
            {
                gold = 35000;
            }

            if (level <= 49 && ifStatus == false)
            {
                gold = 40000;
            }

            if (level <= 100 && ifStatus == false)
            {
                gold = 50000;
            }

            return gold;
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
                
                if (subType == 1 || subType == 101 || subType == 121)
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

        /// <summary>
        /// 单人副本
        /// </summary>
        /// <param name="sceneTypeEnum"></param>
        /// <returns></returns>
        public static bool IsSingleFuben(int sceneTypeEnum)
        {
            return sceneTypeEnum == SceneTypeEnum.CellDungeon
                || sceneTypeEnum == SceneTypeEnum.PetTianTi
                || sceneTypeEnum == SceneTypeEnum.Tower
                || sceneTypeEnum == SceneTypeEnum.LocalDungeon
                || sceneTypeEnum == SceneTypeEnum.PetDungeon
                || sceneTypeEnum == SceneTypeEnum.RandomTower
                || sceneTypeEnum == SceneTypeEnum.TrialDungeon;
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


        /// <summary>
        /// 根据出生日期，计算精确的年龄
        /// </summary>
        /// <param name="birthDate">生日</param>
        /// <returns></returns>
        //public static int CalculateAge_old(string birthDay)
        //{
        //    // 1985-12-28
        //    DateTime birthDate = DateTime.Parse(birthDay);
        //    DateTime nowDateTime = DateTime.Now;
        //    int age = nowDateTime.Year - birthDate.Year;
        //    //再考虑月、天的因素
        //    if (nowDateTime.Month < birthDate.Month || (nowDateTime.Month == birthDate.Month && nowDateTime.Day < birthDate.Day))
        //    {
        //        age--;
        //    }
        //    return age;
        //}
    }
}
