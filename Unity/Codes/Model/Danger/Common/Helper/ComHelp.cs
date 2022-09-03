using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;
using UnityEngine;

namespace ET
{

    public static class ComHelp
    {

        public const int MaxZone = 202;

        //1000015[神秘商人,全服刷新]1000016[魔能商人，副本刷新]
        public const int ShenMiNpcId = 1000015;
        public const int MoNengNpcId = 1000016;

        public const string RobotPassWord = "et@#robot";

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
            int number = RechargeGive[key];
            return key * 100 + number;
        }

        public const int PetHeXinMax = 60;

        public const int RankNumber = 30;
        public const int CampRankNumber = 50;
        public const int PetRankNumber = 100;

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

        public static int GetPetMaxNumber(int level)
        {
            int petNumber = 1;
            string[] petInfos = GlobalValueConfigCategory.Instance.Get(34).Value.Split('@');
            for (int i = 0; i < petInfos.Length; i++)
            {
                string[] numberInfos = petInfos[i].Split(';');
                petNumber = int.Parse(numberInfos[1]);
                if (level <= int.Parse(numberInfos[0]))
                {
                    return petNumber;
                }
            }
            return petNumber;
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

#if SERVER
        public static bool IsInnerNet()
        {
            if (StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("127.0.0.1")
               || StartMachineConfigCategory.Instance.Get(1).OuterIP.Contains("192.168"))
            {
                return true;
            }
            return false;
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
        /// 
        /// </summary>
        /// <param name="bagInf0"></param>
        /// <param name="getType">1购买</param>
        public static void JianDingFuItem(BagInfo bagInf0, int shulianValue, int getType)
        {
            if (getType == 1)
            {
                bagInf0.ItemPar = GlobalValueConfigCategory.Instance.JianDingFuQulity.ToString();
                return;
            }
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInf0.ItemID);
            float minValuePro = (float)shulianValue / (float)int.Parse(itemCof.ItemUsePar);
            if (minValuePro >= 1)
            {
                minValuePro = 1;
            }
            if (minValuePro <= 0.25f)
            {
                minValuePro = 0.25f;
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

        public static ItemEquipType GetEquipType(int itemId)
        {
            if (itemId == 0)
            {
                return ItemEquipType.Common;
            }
            else
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                return (ItemEquipType)itemConfig.EquipType;
            }
        }

        //开服时间
        public static int DateDiff_Day(long time1, long time2)
        {
            long diff = time1 - time2;
            DateTime start = TimeInfo.Instance.ToDateTime(time1);
            DateTime end = TimeInfo.Instance.ToDateTime(time2);
            return Mathf.FloorToInt(1f * diff / TimeHelper.OneDay);
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

        //月卡 神秘商店
        public static int DateDiff_Time(long time1, long time2)
        {
            long diff = time1 - time2;
            if (diff <= 0)
            {
                return 0;
            }
            return Mathf.CeilToInt(1f * diff / TimeHelper.OneDay);
        }

        public static int GetDateByTime(long time)
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

        public static string OnWebRequestPost_1(string url, Dictionary<string, string> dic)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Clear();
                foreach (var kv in dic)
                {
                    httpClient.DefaultRequestHeaders.Add(kv.Key, kv.Value);
                }
                HttpContent httpContent = new StringContent("");
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                string statusCode = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    return result;
                }
                else
                {
                    return statusCode;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return "";
            }
        }

        public static async ETTask<string> OnWebRequestPost_2(string url, string xml)
        {
            try
            {
                //ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                var httpClient = new HttpClient();
                HttpContent httpContent = new StringContent(xml);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);
                response.EnsureSuccessStatusCode();//用来抛异常的
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return "";
            }
        }

        /// <summary>
        /// 判断是不是周末/节假日
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns>周末和节假日返回true，工作日返回false</returns>
        public static async Task<bool> IsHolidayByDate(DateTime date)
        {
            try
            {
                var isHoliday = false;
                var httpClient = new HttpClient();

                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                param.Add(new KeyValuePair<string, string>("d", date.ToString("yyyyMMdd")));

                var day = date.DayOfWeek;
                //周五一点可以进
                if (day == DayOfWeek.Friday)
                    return true;
                string str = "";
                HttpContent httpContent = new StringContent(str);
                HttpResponseMessage response = await httpClient.PostAsync("http://tool.bitefu.net/jiari/", new FormUrlEncodedContent(param));
                response.EnsureSuccessStatusCode();//用来抛异常的
                string responseBody = await response.Content.ReadAsStringAsync();
                //0为工作日，1为周末，2为法定节假日
                if (responseBody == "1" || responseBody == "2")
                    isHoliday = true;

                return isHoliday;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
            return false;
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
            { 7, UserDataType.FangRong}
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


        //获取附魔相关字符串
        public static string GetHideFuMoValue(int hideID)
        {
            string fuMoStr = "";
            if (hideID != 0)
            {
            }
            return fuMoStr;
        }

        //获取装备的专精属性
        public static List<HideProList> GetEquipZhuanJingHidePro(int equipID)
        {
            //获取最大值
            EquipConfig equipCof = EquipConfigCategory.Instance.Get(equipID);
            List<HideProList> hideList = new List<HideProList>();

            int randomNum = 0;
            float randomFloat = RandomHelper.RandFloat();

            if (randomFloat <= 0.2f)
            {
                randomNum = 0;
            }
            else if (randomFloat <= 0.55f)
            {
                randomNum = 1;
            }
            else if (randomFloat <= 0.75f)
            {
                randomNum = 2;
            }
            else if (randomFloat <= 0.9f)
            {
                randomNum = 3;
            }
            else
            {
                randomNum = 4;
            }

            if (randomNum == 0)
            {
                return null;
            }

            for (int i = 0; i < randomNum; i++)
            {
                //随机值
                int randomValueInt = RandomHelper.RandomNumber(1, equipCof.OneProRandomValue);
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

        /// <summary>
        /// 洗练装备
        /// </summary>
        /// <param name="bagInfo"></param>
        /// xilianType  洗炼类型   0 普通掉落  1 装备洗炼功能
        public static void XiLianItem(BagInfo bagInfo, int xilianType = 0)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            //获取装备等级和装备类型
            int equipID = itemConfig.ItemEquipID;
            if (equipID == 0)
            {
                return;
            }
            //默认送四个宝石位
            string gemhole = "";
            List<int> gemHoleId = new List<int>() { 0,  1,  2,  3,  4 };
            List<int> gemWeight = new List<int>() { 50, 20, 15, 10, 5 };
            int gemNumber = gemHoleId[ RandomHelper.RandomByWeight(gemWeight) ];
            for (int i = 0; i < gemNumber; i++)
            {
                gemhole += RandomHelper.RandomNumber(101, 104).ToString();
                gemhole += "_";
            }
            bagInfo.GemHole = gemhole.Length > 1 ?  gemhole.Substring(0, gemhole.Length - 1) : gemhole;

            string fuMoStr = ComHelp.GetHideFuMoValue(bagInfo.HideID);
            List<HideProList> HideProList = new List<HideProList>();    //专精属性
            List<HideProList> BaseHideProList = new List<HideProList>();    //基础洗炼属性
            List<HideProList> TeShuHideProList = new List<HideProList>();    //基础洗炼属性
            List<int> HideSkillList = new List<int>();

            EquipConfig equipConfig = EquipConfigCategory.Instance.Get(equipID);
            int HideType = equipConfig.HideType;

            double hideShowPro = equipConfig.HideShowPro;
            if (xilianType == 1)
            {
                hideShowPro = 1;
            }
            //hideShowPro = 1;
            //获取装备是否有锻造大师属性
            /*
            float hintSkillProValue = 0.2f;
            if (hintSkillProValue != 0)
            {
                hideShowPro = hideShowPro * (1 + hintSkillProValue);
            }
            */
            //float hideShowPro = 0.25f;              //每个特殊属性出现的概率
            int roseEquipHideNumID = 0;
            string roseEquipHideNumID_Now = (roseEquipHideNumID + 1).ToString();
            /*
            1:血量上限
            2:物理攻击最大值
            3:物理防御最大值
            4:魔法防御最大值
            */
            switch (HideType)
            {
                //可出现随机属性
                case 1:
                    int numer1 = 2;
                    int numer2 = 4;
                    for (int i = numer1; i <= numer2; i++)
                    {
                        //检测概率是否触发随机概率
                        if (RandomHelper.RandFloat01() <= hideShowPro)
                        {
                            //获取随机范围,并随机获取一个值
                            int hideMaxStr = equipConfig.HideMax;
                            int addValue = ComHelp.ReturnEquipRamdomValue(1, hideMaxStr, bagInfo.HideID);
                            BaseHideProList.Add(new HideProList() { HideID = returnProValue(i), HideValue = addValue });
                        }
                    }
                    break;

                //可出现随机属性
                case 2:
                    int numer21 = 1;
                    int numer22 = 4;
                    for (int i = numer21; i <= numer22; i++)
                    {
                        //检测概率是否触发随机概率
                        if (RandomHelper.RandFloat01() <= hideShowPro)
                        {
                            //获取随机范围,并随机获取一个值
                            int hideMaxStr = equipConfig.HideMax;
                            //血量属性翻5倍
                            if (i == 1)
                            {
                                hideMaxStr = hideMaxStr * 5;
                            }
                            int addValue = ComHelp.ReturnEquipRamdomValue(1, hideMaxStr, bagInfo.HideID);
                            BaseHideProList.Add(new HideProList() { HideID = returnProValue(i), HideValue = addValue });
                        }
                    }
                    break;

                //可出现随机属性
                case 3:
                    int numer31 = 1;
                    for (int i = numer31; i <= numer31; i++)
                    {
                        //检测概率是否触发随机概率
                        if (RandomHelper.RandFloat01() <= hideShowPro)
                        {
                            //获取随机范围,并随机获取一个值
                            int hideMaxStr = equipConfig.HideMax;
                            //血量属性翻5倍
                            if (i == 1)
                            {
                                hideMaxStr = hideMaxStr * 5;
                            }
                            int addValue = ComHelp.ReturnEquipRamdomValue(1, hideMaxStr, bagInfo.HideID);
                            BaseHideProList.Add(new HideProList() { HideID = returnProValue(i), HideValue = addValue });
                        }
                    }
                    break;
            }

            //宠物装备不会有其他极品属性
            bool hideSkillStatus = true;
            //bool hidePetEquipStatus = false;
            int itemSubType = itemConfig.ItemSubType;
            if (itemSubType >= 201 && itemSubType <= 204)
            {
                //hidePetEquipStatus = true;
            }

            if (hideSkillStatus)
            {
                /*
                //附加幸运值(100属性类型表示幸运值)
                float luckProValue = 0.99f;
                //如果是掉落,概率降低10倍
                if (bagInfo.HideID == 0)
                {
                    luckProValue = 0.999f;
                }

                if (RandomHelper.RandFloat01() >= luckProValue && hidePetEquipStatus == false)
                {
                    int addValue = 1;
                    HideProList.Add(new HideProList() { HideID = 100, HideValue = addValue });
                }
                */
                //附加额外的极品属性
                float equipJiPinPro = 0.3f;

                //如果是掉落,概率降低10倍
                /*
                if (bagInfo.HideID == 0)
                {
                    equipJiPinPro = 0.05f;
                }
                */

                if (RandomHelper.RandFloat01() <= equipJiPinPro)
                {

                    int nextID = 0;
                    int hintProListID = 1001;
                    //获取隐藏条最大目数
                    int hintJiPinMaxNum = 3;
                    int hintJiPinMaxNumSum = 0;

                    /*
                    if (hidePetEquipStatus)
                    {
                        hintProListID = 3001;
                    }
                    */
                    do
                    {
                        HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hintProListID);
                        //获取单条触发概率
                        double triggerPro = hideProListConfig.TriggerPro;
                        //判定当条属性位置是否激活
                        //string itemSubType = Game_PublicClassVar.Get_function_DataSet.DataSet_ReadData("ItemSubType", "ID", itemID, "Item_Template");
                        //string[] equipSpaceList = hideProListConfig.EquipSpace;
                        bool equipStatus = false;
                        //if (equipSpaceList.Length > 0 && equipSpaceList[0] != "" && equipSpaceList[0] != "0")
                        //{
                        for (int i = 0; i < hideProListConfig.EquipSpace.Length; i++)
                        {
                            if (itemSubType == hideProListConfig.EquipSpace[i])
                            {
                                equipStatus = true;
                            }
                        }
                        //}

                        if (!equipStatus)
                        {
                            break;
                        }


                        //触发隐藏属性
                        if (RandomHelper.RandFloat01() < triggerPro)
                        {
                            //读取隐藏属性类型和对应随机值

                            int hintProType = hideProListConfig.PropertyType;
                            float propertyValueMin = float.Parse(hideProListConfig.PropertyValueMin);
                            float propertyValueMax = float.Parse(hideProListConfig.PropertyValueMax);

                            //判定是随着等级变动
                            int ifEquipLvUp = hideProListConfig.IfEquipLvUp;
                            if (ifEquipLvUp == 1)
                            {
                                //获取等级
                                int itemlv = 1;
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
                           ;
                            //隐藏属性值得类型
                            int hintProValueType = hideProListConfig.HideProValueType;
                            float hintProVlaue = 0;
                            if (hintProValueType == 1)
                            {
                                //表示整数
                                hintProVlaue = ComHelp.ReturnEquipRamdomValue((int)propertyValueMin, (int)(propertyValueMax), bagInfo.HideID);
                                if (hintProVlaue <= 0)
                                {
                                    hintProVlaue = propertyValueMin;
                                }
                            }
                            else
                            {
                                //表示浮点数
                                hintProVlaue = ComHelp.ReturnEquipRamdomValue_float(propertyValueMin, propertyValueMax);
                                if (hintProVlaue <= 0)
                                {
                                    hintProVlaue = propertyValueMin;
                                }
                            }

                            //取随机值
                            //float hintProVlaue = propertyValueMin + (propertyValueMax - propertyValueMin)* Random.value;
                            //取小数点的后两位
                            //hintProVlaue = (float)(System.Math.Round(hintProVlaue, 2));

                            TeShuHideProList.Add(new HideProList() { HideID = hintProListID, HideValue = NumericHelp.NumericValueSaveType(hideProListConfig.PropertyType, hintProVlaue) });
                            //Log.Info("随机属性值:" + hideProListConfig.HideProValueType + "值：" + hintProVlaue);
                            hintJiPinMaxNumSum = hintJiPinMaxNumSum + 1;
                            if (hintJiPinMaxNumSum >= hintJiPinMaxNum)
                            {
                                //立即跳出循环
                                break;
                            }
                        }

                        nextID = hideProListConfig.NtxtID;
                        hintProListID = hideProListConfig.NtxtID;

                    } while (nextID != 0);
                }

                //判定是否需要写入特殊技能
                if (bagInfo.HideID != 0)
                {
                    //附加特殊技能
                    float equipJiPinSkillPro = 0.0108f;
                    //如果是掉落,概率降低10倍

                    //洗炼大师附加
                    string xilianJiaID = "";
                    if (xilianJiaID != "" && xilianJiaID != null)
                    {
                        string xiLianValueStr = "";
                        if (xiLianValueStr != "" && xiLianValueStr != null)
                        {
                            float xilianAddValue = float.Parse(xiLianValueStr);
                            equipJiPinSkillPro = equipJiPinSkillPro + xilianAddValue;
                        }
                    }

                    bool ishaveSkill = false;
                    if (RandomHelper.RandFloat01() <= equipJiPinSkillPro || ishaveSkill)
                    {
                        int nextID = 0;
                        int hintProListID = 2001;
                        //获取隐藏条最大目数
                        int hintJiPinMaxNum = 3;
                        int hintJiPinMaxNumSum = 0;

                        //洗练到一定次数必得隐藏技能ID
                        int teShuHintProListID = 0;

                        if (teShuHintProListID != 0)
                        {
                            hintProListID = teShuHintProListID;
                        }

                        do
                        {
                            //获取单条触发概率
                            HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hintProListID);
                            double triggerPro = hideProListConfig.TriggerPro;
                            //判定当条属性位置是否激活
                            //string itemSubType = Game_PublicClassVar.Get_function_DataSet.DataSet_ReadData("ItemSubType", "ID", itemID, "Item_Template");
                            int[] equipSpaceList = hideProListConfig.EquipSpace;
                            bool equipStatus = false;
                            if (equipSpaceList[0] != 0)
                            {
                                for (int i = 0; i < equipSpaceList.Length; i++)
                                {
                                    if (itemSubType == equipSpaceList[i])
                                    {
                                        equipStatus = true;
                                    }
                                }
                            }

                            if (equipStatus)
                            {

                                //触发隐藏属性
                                if (RandomHelper.RandFloat01() < triggerPro || teShuHintProListID != 0)
                                {

                                    //读取隐藏属性类型和对应随机值
                                    int hideSkillID = hideProListConfig.PropertyType;

                                    float propertyValueMin = float.Parse(hideProListConfig.PropertyValueMin);
                                    float propertyValueMax = float.Parse(hideProListConfig.PropertyValueMax);

                                    HideSkillList.Add(hideSkillID);

                                    hintJiPinMaxNumSum = hintJiPinMaxNumSum + 1;
                                    if (hintJiPinMaxNumSum >= hintJiPinMaxNum)
                                    {
                                        //立即跳出循环
                                        break;
                                    }
                                }
                            }

                            nextID = hideProListConfig.NtxtID;
                            hintProListID = nextID;

                            if (teShuHintProListID != 0)
                            {
                                break;
                            }

                        } while (nextID != 0);

                    }
                }
                else
                {
                    if (xilianType == 0)
                    {
                        //获取当前装备的技能属性进行叠加
                        if (bagInfo.HideID != 0)
                        {
                            string hideProListStr = "";
                            string[] hideProperty = hideProListStr.Split(';');

                            //循环加入之前的隐藏属性
                            if (hideProListStr != "")
                            {
                                for (int y = 0; y <= hideProperty.Length - 1; y++)
                                {
                                    int hidePropertyType = int.Parse(hideProperty[y].Split(',')[0]);
                                    int hidePropertyValue = int.Parse(hideProperty[y].Split(',')[1]);

                                    if (hidePropertyType == 10001)
                                    {
                                        HideProList.Add(new HideProList() { HideID = hidePropertyType, HideValue = hidePropertyValue });
                                    }
                                }
                            }

                            //bagInfo.HideProLists = HideProList;             //精炼
                        }
                    }
                }
            }

            bagInfo.XiLianHideProLists = BaseHideProList;   //基础属性洗炼
            bagInfo.HideSkillLists = HideSkillList;         //隐藏技能
            bagInfo.XiLianHideTeShuProLists = TeShuHideProList;  //特殊属性洗炼

        }

        private static int returnProValue(int xuhao)
        {

            switch (xuhao)
            {
                //血量
                case 1:
                    return 100201;
                //break;
                //攻击
                case 2:
                    return 100401;
                //break;
                //物防
                case 3:
                    return 100601;
                //break;
                //魔防
                case 4:
                    return 100801;
                    //break;

            }
            return 0;
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
