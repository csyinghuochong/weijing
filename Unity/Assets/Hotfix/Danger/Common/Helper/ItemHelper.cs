
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class ItemHelper
    {

        public static string DefaultGem = "0_0_0_0";

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


        public static Dictionary<int, UserDataType> ItemToUserDataType = new Dictionary<int, UserDataType>()
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
            { 16, UserDataType.UnionZiJin },
            { 17, UserDataType.UnionExp }
        };

        public static UserDataType GetItemToUserDataType(int itemid)
        {
            UserDataType userDataType = UserDataType.None;
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
                string[] proInfos = itemparams[1].Split(';');
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

        public static int GetNeedCell(string needitems)
        {
            List<RewardItem> rewards = GetRewardItems(needitems);   
            return GetNeedCell(rewards);
        }

        public static int GetNeedCell(List<RewardItem> rewards)
        {
            int needcell = 1;
            for (int i = 0; i < rewards.Count; i++)
            {
                int itemId = rewards[i].ItemID;
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                if (itemConfig.ItemPileSum == 999999)
                {
                    continue;
                }
                needcell += Mathf.CeilToInt(rewards[i].ItemNum * 1f / itemConfig.ItemPileSum);
            }
            return 1;
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
            }


            return false;

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
