

using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class ItemHelper
    {

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

        //ItemSubType
        //1 武器
        //2 衣服
        //3 护符
        //4 戒指
        //5 饰品
        //6 鞋子
        //7 裤子
        //8 腰带
        //9 手镯
        //10 头盔
        //11 项链
        //12 宠物之核
        //传入装备类型返回对应的角色装备格子
        public static int ReturnEquipSpaceNum(int equipType)
        {
            int equipSpaceNum = 0;
            switch (equipType)
            {
                //武器
                case 1:
                    equipSpaceNum = 1;
                    break;
                //衣服
                case 2:
                    equipSpaceNum = 2;
                    break;
                //护符
                case 3:
                    equipSpaceNum = 3;
                    break;
                //灵石
                case 4:
                    equipSpaceNum = 4;
                    break;
                //饰品
                case 5:
                    equipSpaceNum = 5;
                    break;
                //鞋子
                case 6:
                    equipSpaceNum = 8;
                    break;
                //裤子
                case 7:
                    equipSpaceNum = 9;
                    break;
                //腰带
                case 8:
                    equipSpaceNum = 10;
                    break;
                //手镯
                case 9:
                    equipSpaceNum = 11;
                    break;
                //头盔
                case 10:
                    equipSpaceNum = 12;
                    break;
                //项链
                case 11:
                    equipSpaceNum = 13;
                    break;

            }
            return equipSpaceNum;
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
    }
}
