using System.Collections.Generic;
using System.Linq;

namespace ET
{

    /// <summary>
    /// 附加方法
    /// </summary>
    public static class ItemAddHelper
    {

        public static void OnItemUpdate( Unit self, BagInfo bagInfo)
        {
            //通知客户端背包道具发生改变
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
            MessageHelper.SendToClient(self, m2c_bagUpdate);
        }
        
        public static void OnGetItem(this Unit self, int getWay, int itemId, int itemNum)
        {
            self.GetComponent<TaskComponent>().OnGetItem_2(itemId);
            self.GetComponent<TaskComponent>().OnGetItemNumber( getWay, itemId, itemNum);       
            self.GetComponent<ShoujiComponent>().OnGetItem(itemId);
        }

        /// <summary>
        /// 任务类型2要检测一下道具数量
        /// </summary>
        /// <param name="self"></param>
        /// <param name="itemId"></param>
        public static void OnCostItem(this Unit self, int itemId)
        {
            self.GetComponent<TaskComponent>().OnGetItem_2(itemId);
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

            List<DungeonConfig> dungeonConfigs = new List<DungeonConfig>();
            List<DungeonConfig> dungeonConfigsAll = DungeonConfigCategory.Instance.GetAll().Values.ToList();

            int roleLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;

            for (int i = 0; i < dungeonConfigsAll.Count; i++)
            {
                if(DungeonSectionConfigCategory.Instance.MysteryDungeonList.Contains(dungeonConfigsAll[i].Id))
                {
                    continue;
                }
                if (dungeonConfigsAll[i].EnterLv <= roleLv)
                {
                    dungeonConfigs.Add(dungeonConfigsAll[i]);
                }
            }

            int dungeonindex = RandomHelper.RandomNumber(0, dungeonConfigs.Count);
            int dungeonid = dungeonConfigs[dungeonindex].Id;

            int dropId = int.Parse(itemConfig.ItemUsePar);
            List<RewardItem> rewardList = new List<RewardItem>();

            //获取最终奖励
            if (RandomHelper.RandFloat01() <= 0.7f)
            {
                DropHelper.DropIDToDropItem_2(dropId, rewardList);
            }
            else {
                int baotutype = 1;
                if (bagInfo.ItemID == 10010039) 
                {
                    baotutype = 1;
                }

                if (bagInfo.ItemID == 10010040)
                {
                    baotutype = 2;
                }
                int dropID2 = ComHelp.TreasureToDropID(dungeonid, roleLv, baotutype);
                DropHelper.DropIDToDropItem_2(dropID2, rewardList);
            }

            bagInfo.ItemPar = $"{dungeonid}@{"TaskMove_6"}@{rewardList[0].ItemID + ";" + rewardList[0].ItemNum}";
            Log.Debug($"生成藏宝图:  {unit.Id} {unit.GetComponent<UserInfoComponent>().UserName} {rewardList[0].ItemID}");
        }


        //获取装备的鉴定属性
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
            float randomFloat = RandomHelper.RandomNumberFloat(addJianDingPro,1) + addJianDingPro;
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

            //65级装备默认最低2条属性
            if (itemCof.UseLv >= 65 && randomNum<2) {
                randomNum = 2;
            }

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

            //获取随机属性的最大值和最小值
            JianDingDate jiandingDate = ItemHelper.GetEquipZhuanJingPro( equipID, itemID, jianDingPinZhi,ifItem);

            for (int i = 0; i < randomNum; i++)
            {
                //随机值(高品质保底属性)
                /*
                int minNum = 1;
                if (JianDingPro > 1f) {
                    minNum = (int)((float)equipCof.OneProRandomValue * (JianDingPro - 1f) * 0.68f);
                }
                int maxNum = (int)((float)equipCof.OneProRandomValue * JianDingPro * 0.8f);
                if (minNum > maxNum) {
                    maxNum = minNum;
                }
                if (maxNum > equipCof.OneProRandomValue) {
                    maxNum = equipCof.OneProRandomValue;
                }

                int randomValueInt = RandomHelper.RandomNumber(minNum, maxNum + 1);
                */
                int randomValueInt = RandomHelper.RandomNumber(jiandingDate.MinNum, jiandingDate.MaxNum + 1);
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
    }
}
