using System.Collections.Generic;
using System.Linq;

namespace ET
{

    /// <summary>
    /// 附加方法
    /// </summary>
    public static class ItemAddHelper
    {

        public static void OnGetItem(this Unit self, int itemId)
        {
            self.GetComponent<TaskComponent>().OnGetItem(itemId);
            self.GetComponent<ShoujiComponent>().OnGetItem(itemId);
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
            if (bagInf0.ItemID == 11200000)
            {
                bagInf0.ItemPar = "100";
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
            int maxValue = (int)(minValuePro * 102f);
            int randValue = RandomHelper.RandomNumber(minValue, maxValue);
            if (randValue > 100) {
                randValue = 100;
            }
            bagInf0.ItemPar = randValue.ToString();
        }

        public static void TreasureItem(Unit unit, BagInfo bagInfo)
        {

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (itemConfig.ItemSubType != 113 && itemConfig.ItemSubType != 127)
            {
                return;
            }
            List<DungeonConfig> dungeonConfigs = DungeonConfigCategory.Instance.GetAll().Values.ToList();
            int dungeonindex = RandomHelper.RandomNumber(0, dungeonConfigs.Count);
            int dungeonid = dungeonConfigs[dungeonindex].Id;

            List<DropConfig> dropConfigs = DropConfigCategory.Instance.GetAll().Values.ToList();
            int dropIndex = RandomHelper.RandomNumber(0, dropConfigs.Count);
            int dropId = dropConfigs[dropIndex].Id;
            List<RewardItem> rewardList = new List<RewardItem>();

            //获取最终奖励
            if (RandomHelper.RandFloat01() <= 0.7f)
            {
                DropHelper.DropIDToDropItem_2(dropId, rewardList);
            }
            else {
                int dropID2 = ComHelp.TreasureToDropID(dungeonid);
                DropHelper.DropIDToDropItem_2(dropID2, rewardList);
            }

            bagInfo.ItemPar = $"{dungeonid}@{"TaskMove_6"}@{rewardList[0].ItemID + ";" + rewardList[0].ItemNum}";
            Log.Debug($"生成藏宝图:  {unit.Id} {unit.GetComponent<UserInfoComponent>().UserName} {rewardList[0].ItemID}");
        }


        //获取装备的专精属性
        public static List<HideProList> GetEquipZhuanJingHidePro(int equipID, int itemID, int jianDingPinZhi, Unit unit, bool ifItem)
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

            if (ifItem == true && itemCof.UseLv < 30)
            {
                jianDingPinZhi = jianDingPinZhi + 5;
            }

            //鉴定符和当前装备的等级差
            float JianDingPro = (float)jianDingPinZhi / (float)pro;
            float addJianDingPro = 0;

            if (JianDingPro >= 1.5f)
            {
                JianDingPro = 1.5f;
                addJianDingPro += 0.2f;
            } else if (JianDingPro >= 1f) {
                addJianDingPro += 0.2f * (JianDingPro - 0.5f);
            }

            if (JianDingPro <= 0.5f)
            {
                JianDingPro = 0.5f;
            }

            int randomNum = 0;
            float randomFloat = RandomHelper.RandFloat01() + addJianDingPro;

            Log.Info("randomFloat == " + randomFloat + "  JianDingPro = " + JianDingPro + "addJianDingPro = " + addJianDingPro);

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
                //随机值(高品质保底属性)
                int minNum = 1;
                if (JianDingPro > 1f) {
                    minNum = (int)((float)equipCof.OneProRandomValue * (JianDingPro - 1f) * 0.68f);
                }

                int randomValueInt = RandomHelper.RandomNumber(minNum, equipCof.OneProRandomValue+1);
                randomValueInt = (int)(randomValueInt * JianDingPro);
                if (randomValueInt > equipCof.OneProRandomValue)
                {
                    randomValueInt = equipCof.OneProRandomValue;
                }
                //如果品质符足够好,保底为5
                if (randomValueInt < 5)
                {
                    if (JianDingPro >= 1.5f)
                    {
                        randomValueInt = 5;
                    }
                    else if (JianDingPro >= 1f)
                    {
                        randomValueInt = 3;
                    }
                }

                //保底为1点,防止出现0点属性
                if (randomValueInt < 1)
                {
                    randomValueInt = 1;
                }

                //随机属性类型
                int randomIDInt = RandomHelper.RandomNumber(1, 6);
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
    }
}
