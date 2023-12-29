
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class ItemHelper
    {

        public static string DefaultGem = "0_0_0_0";
        public static List<int> GemHoleId = new List<int>() { 0, 1, 2, 3, 4 };
        public static List<int> GemWeight = new List<int>() { 50, 25, 15, 10, 0 };



        /// <summary>
        /// 晶核增加品质
        /// </summary>
        /// <param name="qulitylv">传入消耗晶核的品质。 baginfo.itempar</param>
        /// <returns>返回一个本次预计增加品质范围(客户端显示用， 服务器随机取值)</returns>
        public static List<int> GetJingHeAddQulity(List<int> qulitylv)
        {
            int min = 10;
            int max = 20;
            return new List<int>() { min, max };
        }

        //晶核初始品质
        public static int GetJingHeInitQulity(int itemid)
        {
            //1,30@1;202103,0.01,0.03
            //初始品质最小值,初始品质最大值;属性类型;属性值
            //下面时属性类型
            //1; 属性ID,属性最大值,属性最小值
            //2;附带技能
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            string[] parmainfos = itemConfig.ItemUsePar.Split('@');
            string[] qulityinfo = parmainfos[0].Split(',');
            int lowlevel = int.Parse(qulityinfo[0]);
            int highlevel = int.Parse((qulityinfo[1]));

            return RandomHelper.RandomNumber(lowlevel, highlevel + 1);
        }

#if SERVER
        //晶核属性类型
        public static int GetJingHeProType(int itemid)
        {
            //1,30@1;202103,0.01,0.03   增加属性
            //1,30@2;62000001           增加技能
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            string[] parmainfos = itemConfig.ItemUsePar.Split('@');
            string[] attriinfos = parmainfos[1].Split(';');
            int addType = int.Parse(attriinfos[0]);
            return addType;
        }

        //晶核属性类型
        public static int GetJingHeSkillId(int itemid)
        {
            //1,30@1;202103,0.01,0.03   增加属性
            //1,30@2;62000001           增加技能
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            string[] parmainfos = itemConfig.ItemUsePar.Split('@');
            string[] attriinfos = parmainfos[1].Split(';');
            int addType = int.Parse(attriinfos[0]);
            if (addType != 2)
            {
                return 0;
            }
            return int.Parse(attriinfos[1]);
        }

        //生成晶核属性. 
        public static HideProList GetJingHeHidePro(int itemid, int qulity) 
        {
            //1,30@1;202103,0.01,0.03   增加属性
            //1,30@2;62000001           增加技能

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            string[] parmainfos = itemConfig.ItemUsePar.Split('@');
            string[] attriinfos = parmainfos[1].Split(';'); 

            int addType = int.Parse(attriinfos[0]);
            if (addType != 1)
            {
                return null;
            }

            string[] hidevalueinfo = attriinfos[1].Split(',');
            int hideid = int.Parse(hidevalueinfo[0]);
            int showType = NumericHelp.GetNumericValueType(hideid);
            if (showType == 2)
            {
                float hidevaluemin = float.Parse(hidevalueinfo[1]);
                float hidevaluemax = float.Parse(hidevalueinfo[2]);
                (hidevaluemin, hidevaluemax) = ItemHelper.GetJingHeHideProRange(hidevaluemin, hidevaluemax, qulity);
                float hidevalue = RandomHelper.RandomNumberFloat(hidevaluemin, hidevaluemax);
                // float hidevalue = RandomHelper.RandomNumberFloat(hidevaluemin, hidevalueman - hidevaluemin);
                // if (qulity < 90) {
                //     hidevalue = hidevaluemin +  hidevalue * (0.4f + qulity / 100 * 0.6f);
                // }
                //保底
                return new HideProList() { HideID = hideid, HideValue = (long)(hidevalue * 10000) };
            }
            else
            {
                int hidevaluemin = int.Parse(hidevalueinfo[1]);
                int hidevaluemax = int.Parse(hidevalueinfo[2]);
                (hidevaluemin, hidevaluemax) = ItemHelper.GetJingHeHideProRange(hidevaluemin, hidevaluemax, qulity);
                int hidevalue = RandomHelper.RandomNumber(hidevaluemin, hidevaluemax);
                // int hidevalue = RandomHelper.RandomNumber(hidevaluemin, hidevaluemax - hidevaluemin);
                // if (qulity < 90)
                // {
                //     hidevalue = hidevaluemin + (int)((float)hidevalue * (0.4f + qulity / 100 * 0.6f));
                // }

                return new HideProList() { HideID = hideid, HideValue = hidevalue };
            }
        }
#endif

        public static (float, float) GetJingHeHideProRange(float min, float max, int qulity)
        {
            float med = min + (max - min) * qulity / 100f;
            float activatedMinValue = 0;
            float activatedMaxValue = 0;
            if (med - 0.005f < min)
            {
                activatedMinValue = min;
            }
            else
            {
                activatedMinValue = med - 0.005f;
            }

            if (med + 0.005f > max)
            {
                activatedMaxValue = max;
            }
            else
            {
                activatedMaxValue = med + 0.005f;
            }

            return (activatedMinValue, activatedMaxValue);
        }

        public static (int, int) GetJingHeHideProRange(int min, int max, int qulity)
        {
            int med = min + (int)((max - min) * qulity / 100f);
            int activatedMinValue = 0;
            int activatedMaxValue = 0;
            if (med - 10 < min)
            {
                activatedMinValue = min;
            }
            else
            {
                activatedMinValue = med - 10;
            }

            if (med + 10 > max)
            {
                activatedMaxValue = max;
            }
            else
            {
                activatedMaxValue = med + 10;
            }

            return (activatedMinValue, activatedMaxValue);
        }

        /// <summary>
        /// 套装属性
        /// </summary>
        /// <param name="bagInfos"></param>
        /// <param name="occ"></param>
        /// <returns></returns>
        public static List<PropertyValue> GetSuiPros(BagComponent bagComponent, int occ)
        {
            return new List<PropertyValue>();
        }

        /// <summary>
        /// //5 橙装
        /// </summary>
        /// <param name="bagInfos"></param>
        /// <param name="qulity"></param>
        /// <returns></returns>
        public static int GetNumberByQulity(List<BagInfo> bagInfos, int qulity)
        {
            int number = 0;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID );
                if (itemConfig.ItemQuality >= qulity)
                { 
                    number++;   
                }
            }

            return number;
        }


        public static List<BagInfo> GetSeedList(List<BagInfo> bagInfos)
        {
            List <BagInfo>  seedlist = new List<BagInfo> ();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType == 2 &&
                    (itemConfig.ItemSubType == 101 || itemConfig.ItemSubType == 131 || itemConfig.ItemSubType == 201 || itemConfig.ItemSubType == 301))
                {
                    seedlist.Add(bagInfos[i]);
                }

                if (itemConfig.ItemType == 1 && itemConfig.ItemSubType == 131)
                {
                    seedlist.Add(bagInfos[i]);
                }
            }
            return seedlist;
        }

        /// <summary>
        /// 从背包中获取所有藏宝图
        /// </summary>
        /// <param name="bagInfos"></param>
        /// <returns></returns>
        public static List<BagInfo> GetTreasureMapList(List<BagInfo> bagInfos)
        {
            List<BagInfo> treasureMapList = new List<BagInfo>();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);

                if (itemConfig.ItemType == 1 && itemConfig.ItemSubType == 127)
                {
                    treasureMapList.Add(bagInfos[i]);
                }
            }

            return treasureMapList;
        }

        /// <summary>
        /// 从背包中获取生活材料,用于家园藏宝图的第二页分页
        /// </summary>
        /// <param name="bagInfos"></param>
        /// <returns></returns>
        public static List<BagInfo> GetTreasureMapList2(List<BagInfo> bagInfos)
        {
            List<BagInfo> treasureMapList = new List<BagInfo>();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);

                if ((itemConfig.ItemType == 2 && (itemConfig.ItemSubType == 121)) ||
                    (itemConfig.ItemType == 1 && (itemConfig.ItemSubType == 15 || itemConfig.ItemSubType == 101)))
                {
                    treasureMapList.Add(bagInfos[i]);
                }
            }

            return treasureMapList;
        }
        
        public static Dictionary<int, int> ItemToUserDataType = new Dictionary<int, int>()
        {
            {  1, UserDataType.Gold },
            {  2, UserDataType.Exp },
            {  3, UserDataType.Diamond },
            {  4, UserDataType.Vitality },
            {  5, UserDataType.PiLao },
            {  6, UserDataType.RongYu },
            { 7,  UserDataType.FangRong},
            { 8,  UserDataType.MaoXianExp},
            { 9,  UserDataType.DungeonTimes},
            { 10, UserDataType.Recharge},
            { 11, UserDataType.HuoYue},
            { 12, UserDataType.Sp},
            { 13, UserDataType.JiaYuanFund},
            { 14, UserDataType.JiaYuanExp},
            { 15, UserDataType.BaoShiDu },
            { 16, UserDataType.UnionContri },
            { 17, UserDataType.UnionExp },
            { 18, UserDataType.JueXingExp },
            { 31, UserDataType.SeasonExp },
            { 32, UserDataType.SeasonCoin },
            { 34, UserDataType.InvestMent },
            { 35, UserDataType.UnionGold },
        };

        public static int GetItemToUserDataType(int itemid)
        {
            int userDataType = UserDataType.None;
            ItemToUserDataType.TryGetValue(itemid, out userDataType);
            return userDataType;
        }

        public static List<HideProList> GetItemFumoPro(int itemid)
        {
            List<HideProList> hideProLists = new List<HideProList>();

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            string itemParams = itemConfig.ItemUsePar;
            string[] itemparams = itemParams.Split('@');
            for (int i = 1; i < itemparams.Length; i++)
            {
                string[] proInfos = itemparams[i].Split(';');
                int hideId = int.Parse(proInfos[0]);
                int hideValue_1 = 0;
                int hideValue_2 = 0;
                if (1 == NumericHelp.GetNumericValueType(hideId))
                {
                    hideValue_1 = int.Parse(proInfos[1]);
                    hideValue_2 = int.Parse(proInfos[2]);
                }
                else
                {
                    hideValue_1 = (int)(10000 * float.Parse(proInfos[1]));
                    hideValue_2 = (int)(10000 * float.Parse(proInfos[2]));
                }
                hideProLists.Add(new HideProList() { HideID = hideId, HideValue = RandomHelper.RandomNumber(hideValue_1, hideValue_2) });
            }
            return hideProLists;
        }

        /// <summary>
        /// 从HideProListConfig配置表中读取属性加成数据 , 1属性 2技能
        /// </summary>
        /// <param name="ItemconfigId"></param>
        /// <returns>属性</returns>
        public static List<HideProList> GetHidePro(int itemConfigId)
        {
            // 1@2312312;1231231231;213412342
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemConfigId);
            string[] itemparams = itemConfig.ItemUsePar.Split(';');
            List<HideProList> hideProLists = new List<HideProList>();
            for (int j = 0; j + 1 < itemparams.Length; j += 2)
            {
                string[] hideProConfigIDs = itemparams[j + 1].Split('@');
                if (itemparams[j] == "1")
                {
                    for (int i = 0; i < hideProConfigIDs.Length; i++)
                    {
                        HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(int.Parse(hideProConfigIDs[i]));
                        int hideValue_1 = 0;
                        int hideValue_2 = 0;

                        // 整形
                        if (hideProListConfig.HideProValueType == 1)
                        {
                            hideValue_1 = int.Parse(hideProListConfig.PropertyValueMin);
                            hideValue_2 = int.Parse(hideProListConfig.PropertyValueMax);
                        }
                        // 浮点型
                        else
                        {
                            hideValue_1 = (int)(10000 * float.Parse(hideProListConfig.PropertyValueMin));
                            hideValue_2 = (int)(10000 * float.Parse(hideProListConfig.PropertyValueMax));
                        }

                        hideProLists.Add(new HideProList()
                        {
                            HideID = hideProListConfig.Id, HideValue = RandomHelper.RandomNumber(hideValue_1, hideValue_2)
                        });
                    }
                }
            }

            return hideProLists;
        }

        /// <summary>
        /// 从HideProListConfig配置表中读取技能id
        /// </summary>
        /// <param name="itemCongfigId"></param>
        /// <returns></returns>
        public static List<int> GetHideSkill(int itemConfigId)
        {
            // 2@2341223;235213412;2134126
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemConfigId);
            string[] itemparams = itemConfig.ItemUsePar.Split(';');
            List<int> skillListConfig = new List<int>();
            for (int j = 0; j + 1 < itemparams.Length; j += 2)
            {
                if (itemparams[j] == "2")
                {
                    string[] hideProConfigIDs = itemparams[j + 1].Split('@');
                    for (int i = 0; i < hideProConfigIDs.Length; i++)
                    {
                        skillListConfig.Add(int.Parse(hideProConfigIDs[i]));
                    }
                }
            }
            return skillListConfig;
        }

        public static int GetEquipType(int occ, int itemId)
        {
            if (itemId == 0)
            {
                if (occ == 1)
                {
                    return ItemEquipType.Sword;
                }
                if (occ == 2)
                {
                    return ItemEquipType.Wand;
                }
                if (occ == 3)
                {
                    return ItemEquipType.Bow;
                }
               
                Log.Error($"{occ} 没有配置此职业的默认武器！");
                return ItemEquipType.Sword;
            }
            else
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                return itemConfig.EquipType;
            }
        }

        public static int GetNeedCell(string needitems)
        {
            List<RewardItem> rewards = GetRewardItems(needitems);   
            return GetNeedCell(rewards);
        }

        public static int GetNeedCell(List<RewardItem> rewardItems_1)
        {
            Dictionary<int, int > rewardItems = new Dictionary<int, int>();
            for (int i = 0; i < rewardItems_1.Count; i++)
            {
                if (!rewardItems.ContainsKey(rewardItems_1[i].ItemID))
                {
                    rewardItems.Add(rewardItems_1[i].ItemID, 0);
                }
                rewardItems[rewardItems_1[i].ItemID] += rewardItems_1[i].ItemNum;
            }

            int bagCellNumber = 1;
            foreach( var item in rewardItems )
            {
                int itemId = item.Key;
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                if (itemConfig.ItemPileSum == 999999)
                {
                    bagCellNumber += 1;
                    continue;

                }
                int ItemPileSum = itemConfig.ItemPileSum;
                if (item.Value <= ItemPileSum)
                {
                    bagCellNumber += 1;
                }
                else
                {
                    bagCellNumber += (int)(1f * item.Value / ItemPileSum);
                    bagCellNumber += (item.Value % ItemPileSum > 0 ? 1 : 0);
                }
                //needcell += Mathf.CeilToInt(rewards[i].ItemNum * 1f / itemConfig.ItemPileSum);
            }
            return bagCellNumber;
        }

        public static List<RewardItem> GetRewardItems(string needitems)
        {
            List<RewardItem> costItems = new List<RewardItem>();
            if (ComHelp.IfNull(needitems))
            {
                return costItems;
            }
            string[] needList = needitems.Split('@');
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
            }
            return costItems;
        }

        public static List<int> GetGemIdList(BagInfo bagInfo)
        {
            string[] gemIdInfos = bagInfo.GemIDNew.Split('_');
            List<int> getIds = new List<int>();
            for (int i = 0; i < gemIdInfos.Length; i++)
            {
                int getItemId = int.Parse(gemIdInfos[i]);
                if (getItemId > 0)
                {
                    getIds.Add(getItemId);
                }
            }
            return getIds;
        }

        //金币鉴定消费
        public static int GetJianDingCoin(int level)
        {
            int gold = 25000;
            bool ifStatus = false;

            if (level <= 18)
            {
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


        public static bool IsBuyItem(int getType) 
        {
            return getType == ItemGetWay.StoreBuy || getType == ItemGetWay.MysteryBuy || getType == ItemGetWay.PaiMaiShop;
        }

        public static BagInfo GetEquipByWeizhi( List<BagInfo> bagInfos, int pos)
        {
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemSubType == pos)
                {
                    return bagInfos[i];
                }
            }
            return null;
        }

        //客户端线条用的
        public static bool IfShengXiaoActiveLine(string shengXiaoItemID, List<BagInfo> equipList) {

            List<int> idList = new List<int>();
            for (int i = 0; i < equipList.Count; i++)
            {
                idList.Add(equipList[i].ItemID);
            }

            switch (shengXiaoItemID)
            {

                case "16000104a":
                    if (idList.Contains(16000102) && idList.Contains(16000103))
                    {
                        return true;
                    }
                    return false;

                case "16000104b":
                    if (idList.Contains(16000101))
                    {
                        return true;
                    }
                    return false;

                case "16000111a":
                    if (idList.Contains(16000109) && idList.Contains(16000110))
                    {
                        return true;
                    }
                    return false;

                case "16000111b":
                    if (idList.Contains(16000112))
                    {
                        return true;
                    }
                    return false;

                case "16000204a":
                    if (idList.Contains(16000202) && idList.Contains(16000203))
                    {
                        return true;
                    }
                    return false;

                case "16000204b":
                    if (idList.Contains(16000201))
                    {
                        return true;
                    }
                    return false;

                case "16000211a":
                    if (idList.Contains(16000209) && idList.Contains(16000210))
                    {
                        return true;
                    }
                    return false;

                case "16000211b":
                    if (idList.Contains(16000212))
                    {
                        return true;
                    }
                    return false;

                case "16000304a":
                    if (idList.Contains(16000302) && idList.Contains(16000303))
                    {
                        return true;
                    }
                    return false;

                case "16000304b":
                    if (idList.Contains(16000301))
                    {
                        return true;
                    }
                    return false;

                case "16000311a":
                    if (idList.Contains(16000309) && idList.Contains(16000310))
                    {
                        return true;
                    }
                    return false;

                case "16000311b":
                    if (idList.Contains(16000312))
                    {
                        return true;
                    }
                    return false;
            }

            return IfShengXiaoActive(int.Parse(shengXiaoItemID), equipList);
        }


        //生肖激活前缀
        public static bool IfShengXiaoActive(int shengXiaoItemID,List<BagInfo> equipList) {

            List<int> idList = new List<int>();
            for (int i = 0; i < equipList.Count; i++) {
                idList.Add(equipList[i].ItemID);
            }

            switch (shengXiaoItemID){

                case 16000101:
                    return true;

                case 16000102:
                    return true;

                case 16000103:
                    if (idList.Contains(16000102)) {
                        return true;
                    }
                    break;

                case 16000104:
                    if (idList.Contains(16000102)&& idList.Contains(16000103)|| idList.Contains(16000101))
                    {
                        return true;
                    }
                    break;
                case 16000105:
                    return true;

                case 16000106:
                    if (idList.Contains(16000105))
                    {
                        return true;
                    }
                    break;

                case 16000107:
                    if (idList.Contains(16000105)&& idList.Contains(16000106))
                    {
                        return true;
                    }
                    break;

                case 16000108:
                    if (idList.Contains(16000105) && idList.Contains(16000106) && idList.Contains(16000108))
                    {
                        return true;
                    }
                    break;

                case 16000109:
                    return true;

                case 16000110:
                    if (idList.Contains(16000109))
                    {
                        return true;
                    }
                    break;

                case 16000111:
                    if (idList.Contains(16000109)&& idList.Contains(16000110)|| idList.Contains(16000112))
                    {
                        return true;
                    }
                    break;

                case 16000112:
                    return true;

                case 16000201:
                    return true;

                case 16000202:
                    return true;

                case 16000203:
                    if (idList.Contains(16000202))
                    {
                        return true;
                    }
                    break;

                case 16000204:
                    if (idList.Contains(16000202) && idList.Contains(16000203) || idList.Contains(16000201))
                    {
                        return true;
                    }
                    break;
                case 16000205:
                    return true;

                case 16000206:
                    if (idList.Contains(16000205))
                    {
                        return true;
                    }
                    break;

                case 16000207:
                    if (idList.Contains(16000205) && idList.Contains(16000206))
                    {
                        return true;
                    }
                    break;

                case 16000208:
                    if (idList.Contains(16000205) && idList.Contains(16000206) && idList.Contains(16000208))
                    {
                        return true;
                    }
                    break;

                case 16000209:
                    return true;

                case 16000210:
                    if (idList.Contains(16000209))
                    {
                        return true;
                    }
                    break;

                case 16000211:
                    if (idList.Contains(16000209) && idList.Contains(16000210) || idList.Contains(16000212))
                    {
                        return true;
                    }
                    break;

                case 16000212:
                    return true;

                case 16000301:
                    return true;

                case 16000302:
                    return true;

                case 16000303:
                    if (idList.Contains(16000302))
                    {
                        return true;
                    }
                    break;

                case 16000304:
                    if (idList.Contains(16000302) && idList.Contains(16000303) || idList.Contains(16000301))
                    {
                        return true;
                    }
                    break;
                case 16000305:
                    return true;

                case 16000306:
                    if (idList.Contains(16000305))
                    {
                        return true;
                    }
                    break;

                case 16000307:
                    if (idList.Contains(16000305) && idList.Contains(16000306))
                    {
                        return true;
                    }
                    break;

                case 16000308:
                    if (idList.Contains(16000305) && idList.Contains(16000306) && idList.Contains(16000308))
                    {
                        return true;
                    }
                    break;

                case 16000309:
                    return true;

                case 16000310:
                    if (idList.Contains(16000309))
                    {
                        return true;
                    }
                    break;

                case 16000311:
                    if (idList.Contains(16000309) && idList.Contains(16000310) || idList.Contains(16000312))
                    {
                        return true;
                    }
                    break;

                case 16000312:
                    return true;
                case 16000401:
                    return true;

                case 16000402:
                    return true;

                case 16000403:
                    if (idList.Contains(16000402))
                    {
                        return true;
                    }
                    break;

                case 16000404:
                    if (idList.Contains(16000402) && idList.Contains(16000403) || idList.Contains(16000401))
                    {
                        return true;
                    }
                    break;
                case 16000405:
                    return true;

                case 16000406:
                    if (idList.Contains(16000405))
                    {
                        return true;
                    }
                    break;

                case 16000407:
                    if (idList.Contains(16000405) && idList.Contains(16000406))
                    {
                        return true;
                    }
                    break;

                case 16000408:
                    if (idList.Contains(16000405) && idList.Contains(16000406) && idList.Contains(16000408))
                    {
                        return true;
                    }
                    break;

                case 16000409:
                    return true;

                case 16000410:
                    if (idList.Contains(16000409))
                    {
                        return true;
                    }
                    break;

                case 16000411:
                    if (idList.Contains(16000409) && idList.Contains(16000410) || idList.Contains(16000412))
                    {
                        return true;
                    }
                    break;

                case 16000412:
                    return true;
            }
            return false;
        }

        public static string ItemGetWayName(int itemgetWay)
        { 
            string getname = string.Empty;
            ItemGetWayNameList.TryGetValue(itemgetWay, out getname);
            return getname; 
        }

        public static void ItemLitSort(List<BagInfo> ItemTypeList)
        {
            ItemTypeList.Sort(delegate (BagInfo a, BagInfo b)
            {
                int itemIda = a.ItemID;
                int itemIdb = b.ItemID;
                int isBinginga = a.isBinging ? 1 : 0;
                int isBingingb = b.isBinging ? 1 : 0;
                ItemConfig itemConfig_a = ItemConfigCategory.Instance.Get(itemIda);
                ItemConfig itemConfig_b = ItemConfigCategory.Instance.Get(itemIdb);
                int quliatya = itemConfig_a.ItemQuality;
                int quliatyb = itemConfig_b.ItemQuality;
                int jianDingLva = itemConfig_a.ItemSubType == 121 && !string.IsNullOrEmpty(a.ItemPar) ? int.Parse(a.ItemPar) : 0;
                int jianDingLvb = itemConfig_b.ItemSubType == 121 && !string.IsNullOrEmpty(b.ItemPar) ? int.Parse(b.ItemPar) : 0;
                int dungeonida = (itemConfig_a.ItemSubType == 113 || itemConfig_a.ItemSubType == 127) ? int.Parse(a.ItemPar.Split('@')[0]) : 0;
                int dungeonidb = (itemConfig_b.ItemSubType == 113 || itemConfig_b.ItemSubType == 127) ? int.Parse(b.ItemPar.Split('@')[0]) : 0;
                //bagInfo.ItemPar = $"{dungeonid}@{"TaskMove_6"}@{rewardList[0].ItemID + ";" + rewardList[0].ItemNum}";

                if (isBinginga == isBingingb)
                {
                    if (quliatya == quliatyb)
                    {
                        if (jianDingLva == jianDingLvb)
                        {
                            if (dungeonida == dungeonidb)
                            {
                                if (itemIda == itemIdb)
                                {
                                    return b.ItemNum - a.ItemNum;
                                }
                                else
                                {
                                    return itemIda - itemIdb;
                                }
                            }
                            else
                            {
                                return dungeonidb - dungeonida;
                            }
                        }
                        else
                        {
                            return jianDingLvb - jianDingLva;
                        }
                    }
                    else
                    {
                        return quliatyb - quliatya;
                    }
                }
                else
                {
                    return isBinginga - isBingingb;
                }
            });
        }

        //以下途径获取的道具为非绑定道具,其他途径为绑定道具
        public static Dictionary<int, string> ItemGetWayNameList = new Dictionary<int, string>
        {
                { ItemGetWay.System, "系统赠与" },
                { ItemGetWay.FubenGetReward, "副本结算奖励" },
                { ItemGetWay.ChouKa, "抽卡" },
                { ItemGetWay.Energy, "正能量" },
                { ItemGetWay.GM, "GM" },
                { ItemGetWay.ItemBox_6, "道具盒子" },
                { ItemGetWay.XiLianLevel, "洗练大师" },
                { ItemGetWay.LingDiReward, "领地" },
                { ItemGetWay.MysteryBuy, "神秘商店" },
                { ItemGetWay.PetFubenReward, "宠物副本奖励" },
                { ItemGetWay.PetHeXinHeCheng, "宠物之核合成" },
                { ItemGetWay.RandomTowerReward, "随机塔奖励" },
                { ItemGetWay.ShoujiReward, "收集奖励" },
                { ItemGetWay.StoreBuy, "商店购买" },
                { ItemGetWay.TaskCountry, "活跃任务" },
                { ItemGetWay.YueKaReward, "月卡奖励" },
                { ItemGetWay.ChengJiuRward, "成就奖励" },
                { ItemGetWay.RankReward, "排行榜奖励" },
                { ItemGetWay.FirstWin, "首胜" },
                { ItemGetWay.PickItem, "拾取" },
                { ItemGetWay.PaiMaiShop, "拍賣商店" },
                { ItemGetWay.PetEggDuiHuan, "宠物蛋兑换" },
                { ItemGetWay.TaskReward, "任务奖励" },
                { ItemGetWay.PetFenjie, "宠物分解" },
                { ItemGetWay.BattleWin, "战场胜利" },
                { ItemGetWay.ReceieMail, "邮件" },
                { ItemGetWay.Melting, "熔炼" },
                { ItemGetWay.TiaoZhan, "挑战之地" },
                { ItemGetWay.SkillMake, "生活制造" },
                { ItemGetWay.HuiShou, "回收系统" },
                { ItemGetWay.XiaJia, "拍卖行下架" },
                { ItemGetWay.DuiHuan, "兑换" },
                { ItemGetWay.HongBao, "红包系统" },
                { ItemGetWay.CostItem, "扣除道具" },
                { ItemGetWay.Share, "分享" },
                { ItemGetWay.PaiMaiBuy, "拍卖购买" },
                { ItemGetWay.XiuLian, "修炼" },
                { ItemGetWay.TreasureMap, "藏宝图获得" },
                { ItemGetWay.Sell, "出售获得" },
                { ItemGetWay.PaiMaiSell, "拍賣出售" },
                { ItemGetWay.BuChang, "补偿" },
                { ItemGetWay.JingLing, "精灵" },
                { ItemGetWay.JiaYuanGather, "家园种植" },
                { ItemGetWay.JiaYuanMale, "JiaYuanMale" },
                { ItemGetWay.JiaYuanSell, "家园出售" },
                { ItemGetWay.JiaYuanCost, "家园资金兑换" },
                { ItemGetWay.Popularize, "推广" },
                { ItemGetWay.Serial, "序列号奖励" },
                { ItemGetWay.JiaYuanCook, "家园厨房" },
                { ItemGetWay.Donation, "捐献" },
                { ItemGetWay.UnionXiuLian, "家族修炼" },
                { ItemGetWay.UnionBoss, "家族BOSS" },
                { ItemGetWay.UnionRace, "家族争霸" },
                { ItemGetWay.Auction, "竞拍" },
                { ItemGetWay.PetChouKa, "宠物抽卡" },
                { ItemGetWay.ItemBox_8, "道具盒子" },
                { ItemGetWay.ItemBox_9, "道具盒子" },
                { ItemGetWay.ItemBox_104, "道具盒子" },
                { ItemGetWay.ItemBox_106, "道具盒子" },
                { ItemGetWay.PetTianTiReward, "宠物天梯" },
                { ItemGetWay.JiaYuanExchange, "家园兑换" },
                { ItemGetWay.GemHuiShou, "宝石回收" },
                { ItemGetWay.ArenaWin, "角斗场胜利" },
                { ItemGetWay.MiJingBoss, "密境BOSS" },
                { ItemGetWay.AuctionJoin, "竞拍保证金" },
                { ItemGetWay.UnionUpLv, "家族升级" },
                { ItemGetWay.GemHeCheng, "宝石合成" },
                { ItemGetWay.SoloReward, "竞技场奖励" },
                { ItemGetWay.Activity_MaoXianJia, "冒险家" },
                { ItemGetWay.Activity_ZhanQu, "战区活动" },
                { ItemGetWay.Recharge, "充值" },
                { ItemGetWay.TowerOfSealCost, "封印之塔消耗钻石" },
                { ItemGetWay.JueXing, "觉醒" },
                { ItemGetWay.Activity_DayTeHui, "每日特惠" },
                { ItemGetWay.UnionMysteryBuy, "家族神秘商店" },
                { ItemGetWay.HappyMove, "喜从天降" },
                { ItemGetWay.Turtle, "小龟大赛" },
                { ItemGetWay.ShowLie, "狩猎" },
                { ItemGetWay.RunRace, "奔跑大赛" },
                { ItemGetWay.Demon, "恶魔活动" },
                { ItemGetWay.PetMine, "宠物矿场" },
                { ItemGetWay.Season, "赛季奖励" },
                { ItemGetWay.Welfare, "福利奖励" },
                { ItemGetWay.LeavlReward, "等级奖励" },
                { ItemGetWay.KillMonsterReward, "击败怪物奖励" },
                { ItemGetWay.StallBuy, "摆摊购买" },
                { ItemGetWay.ActivityChouKa, "抽卡" },
                { ItemGetWay.ActivityConsume, "消耗钻石" },
                { ItemGetWay.ActivityHongBao, "充值红包" },
                { ItemGetWay.PetExplore, "宠物探索" },
                
                { ItemGetWay.Activity, "活动" },
        };

        public static List<int> GetItemSkill(string skillpar)
        {
            ////69000013;69000017
            List<int> skillids = new List<int>();
            if (ComHelp.IfNull(skillpar))
            { 
                return skillids;    
            }
            string[] skillinfos = skillpar.Split(';');
            for (int i = 0;i < skillinfos.Length; i++)
            {
                int skillid = int.Parse(skillinfos[i]);
                if (skillid != 0)
                { 
                    skillids.Add(skillid);  
                }
            }
            return skillids;
        }

        //获取装备的鉴定属性
        public static JianDingDate GetEquipZhuanJingPro(int equipID, int itemID, int jianDingPinZhi, bool ifItem)
        {
            //获取最大值
            EquipConfig equipCof = EquipConfigCategory.Instance.Get(equipID);

            //获取当前鉴定系数
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(itemID);

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
            }
            else if (JianDingPro >= 1f)
            {
                addJianDingPro += 0.2f * (JianDingPro - 0.5f);
            }

            if (JianDingPro <= 0.5f)
            {
                JianDingPro = 0.5f;
            }


            //随机值(高品质保底属性)
            int minNum = 1;
            if (JianDingPro > 1f)
            {
                minNum = (int)((float)equipCof.OneProRandomValue * (JianDingPro - 1f) * 0.8f);
            }
            int maxNum = (int)((float)equipCof.OneProRandomValue * JianDingPro * 0.8f);
            if (minNum > maxNum)
            {
                maxNum = minNum;
            }
            if (maxNum > equipCof.OneProRandomValue)
            {
                maxNum = equipCof.OneProRandomValue;
            }

            JianDingDate data = new JianDingDate();
            data.MinNum = minNum;
            data.MaxNum = maxNum;
            return data;
        }
    }
}
