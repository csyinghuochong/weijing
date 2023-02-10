

using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class ItemHelper
    {

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

        public static List<int> IsHaveGem(BagInfo bagInfo)
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

        //获取装备子类型名称
        public static string GetEquipType(int type)
        {

            switch (type)
            {
                case 0:
                    return "首饰";
                //break;

                case 1:
                    return "剑";
                //break;

                case 2:
                    return "刀";

                case 3:
                    return "法杖";

                case 4:
                    return "魔法书";
                //break;

                case 11:
                    return "布甲";
                //break;

                case 12:
                    return "轻甲";
                //break;

                case 13:
                    return "重甲";
                    //break;
            }

            return "";
        }

        public static string GetEquipSonType(string itemSubType) {

            string textEquipType = "";

            switch (itemSubType)
            {
                case "1":
                    textEquipType = "武器";
                    break;

                case "2":
                    textEquipType = "衣服";
                    break;

                case "3":
                    textEquipType = "护符";

                    break;

                case "4":
                    textEquipType = "戒指";

                    break;

                case "5":
                    textEquipType = "饰品";
                    break;

                case "6":
                    textEquipType = "鞋子";
                    break;

                case "7":
                    textEquipType = "裤子";
                    break;

                case "8":
                    textEquipType = "腰带";
                    break;

                case "9":
                    textEquipType = "手套";
                    break;

                case "10":
                    textEquipType = "头盔";
                    break;

                case "11":
                    textEquipType = "项链";
                    break;
            }

            return textEquipType;
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
    }
}
