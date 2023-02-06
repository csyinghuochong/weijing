

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public struct NumericAttribute
    {
        public string Name;
        public bool Float;
        public string Icon;
    }

    public static class UIItemHelp
    {

        public static Dictionary<int, List<int>> OccWeaponList = new Dictionary<int, List<int>>()
        {
            { 1, new List<int>(){0, 1, 2} },
            { 2, new List<int>(){0, 3, 4}  },
        };

        public static Dictionary<int, NumericAttribute> AttributeToName = new Dictionary<int, NumericAttribute>()
        {
            { NumericType.Now_MaxHp, new NumericAttribute(){ Name = "生命", Icon = "PetPro_1" }},
            { NumericType.Now_MaxAct, new NumericAttribute(){ Name = "攻击", Icon = "PetPro_2" }},
            { NumericType.Now_Mage, new NumericAttribute(){ Name = "魔法", Icon = "PetPro_3" }},
            { NumericType.Now_MaxDef, new NumericAttribute(){ Name = "物防", Icon = "PetPro_4" }},
            { NumericType.Now_MaxAdf, new NumericAttribute(){ Name = "魔防", Icon = "PetPro_5" }},

            { NumericType.Now_Cri, new NumericAttribute(){ Name = "暴击概率", Icon = string.Empty }},
            { NumericType.Now_Res, new NumericAttribute(){ Name = "抗暴概率", Icon = string.Empty }},
            { NumericType.Now_Hit, new NumericAttribute(){ Name = "命中概率", Icon = string.Empty }},
            { NumericType.Now_Dodge, new NumericAttribute(){ Name = "闪避概率", Icon = string.Empty }},

            { NumericType.Now_MinAct, new NumericAttribute(){ Name = "最小攻击", Icon = string.Empty }},
            { NumericType.Now_MinDef, new NumericAttribute(){ Name = "最小物防", Icon = string.Empty }},
            { NumericType.Now_MinAdf, new NumericAttribute(){ Name = "最小魔防", Icon = string.Empty }},
            //{ NumericType.Now_Mage, new NumericAttribute(){ Name = "技能伤害", Icon = "" }},
             
            { NumericType.Now_Power, new NumericAttribute(){ Name = "力量", Icon = string.Empty }},
            { NumericType.Now_Agility, new NumericAttribute(){ Name = "敏捷", Icon = string.Empty }},
            { NumericType.Now_Intellect, new NumericAttribute(){ Name = "智力", Icon = string.Empty }},
            { NumericType.Now_Stamina, new NumericAttribute(){ Name = "耐力", Icon = string.Empty }},
            { NumericType.Now_Constitution, new NumericAttribute(){ Name = "体质", Icon = string.Empty }},

            { NumericType.Now_DamgeAddPro, new NumericAttribute(){ Name = "伤害加成", Icon = string.Empty }},
            { NumericType.Now_DamgeSubPro, new NumericAttribute(){ Name = "伤害减免", Icon = string.Empty }},
            { NumericType.Now_Luck, new NumericAttribute(){ Name = "幸运值", Icon = string.Empty }},
            { NumericType.Now_Speed, new NumericAttribute(){ Name = "移动速度", Icon = string.Empty }},
            { NumericType.Now_CriLv, new NumericAttribute(){ Name = "暴击等级", Icon = string.Empty }},
            { NumericType.Now_ResLv, new NumericAttribute(){ Name = "韧性等级", Icon = string.Empty }},
            { NumericType.Now_HitLv, new NumericAttribute(){ Name = "命中等级", Icon = string.Empty }},
            { NumericType.Now_DodgeLv, new NumericAttribute(){ Name = "闪避等级", Icon = string.Empty }},
            { NumericType.Now_ActDamgeAddPro, new NumericAttribute(){ Name = "物理伤害加成", Icon = string.Empty }},
            { NumericType.Now_MageDamgeAddPro, new NumericAttribute(){ Name = "魔法伤害加成", Icon = string.Empty }},
            { NumericType.Now_ActDamgeSubPro, new NumericAttribute(){ Name = "物理伤害减免", Icon = string.Empty }},
            { NumericType.Now_MageDamgeSubPro, new NumericAttribute(){ Name = "魔法伤害减免", Icon = string.Empty }},
            { NumericType.Now_ZhongJiPro, new NumericAttribute(){ Name = "重击概率", Icon = string.Empty }},
            { NumericType.Now_ZhongJi, new NumericAttribute(){ Name = "重击附加伤害", Icon = string.Empty }},
            { NumericType.Now_HuShiActPro, new NumericAttribute(){ Name = "攻击穿透", Icon = string.Empty }},
            { NumericType.Now_HuShiMagePro, new NumericAttribute(){ Name = "魔法穿透", Icon = string.Empty }},
            { NumericType.Now_HuShiDef, new NumericAttribute(){ Name = "忽视目标防御", Icon = string.Empty }},
            { NumericType.Now_HuShiAdf, new NumericAttribute(){ Name = "忽视目标魔御", Icon = string.Empty }},
            { NumericType.Now_XiXuePro, new NumericAttribute(){ Name = "吸血概率", Icon = string.Empty }},
            { NumericType.Now_SkillCDTimeCostPro, new NumericAttribute(){ Name = "技能冷却缩减", Icon = string.Empty }},
            { NumericType.Now_GeDang, new NumericAttribute(){ Name = "格挡值", Icon = string.Empty }},
            { NumericType.Now_ZhenShi, new NumericAttribute(){ Name = "真实伤害", Icon = string.Empty }},
            { NumericType.Now_HuiXue, new NumericAttribute(){ Name = "回血值", Icon = string.Empty }},


            { NumericType.Now_ExpAdd, new NumericAttribute(){ Name = "经验收益", Icon = string.Empty }},
            { NumericType.Now_GoldAdd, new NumericAttribute(){ Name = "金币收益", Icon = string.Empty }},

            { NumericType.Now_MonsterDis, new NumericAttribute(){ Name = "怪物发现目标距离", Icon = string.Empty }},
            { NumericType.Now_JumpDisAdd, new NumericAttribute(){ Name = "冲锋距离加成", Icon = string.Empty }},
            { NumericType.Now_ActQiangDuAdd, new NumericAttribute(){ Name = "攻击强度", Icon = string.Empty }},
            { NumericType.Now_MageQiangDuAdd, new NumericAttribute(){ Name = "法术强度", Icon = string.Empty }},


            { NumericType.Now_ActBossPro, new NumericAttribute(){ Name = "领主攻击加成", Icon = string.Empty }},
            { NumericType.Now_MageBossPro, new NumericAttribute(){ Name = "领主技能加成", Icon = string.Empty }},
            { NumericType.Now_ActBossSubPro, new NumericAttribute(){ Name = "领主攻击免伤", Icon = string.Empty }},
            { NumericType.Now_MageBossSubPro, new NumericAttribute(){ Name = "领主技能免伤", Icon = string.Empty }},

            { NumericType.Now_MiaoSha_Pro, new NumericAttribute(){ Name = "致命一击", Icon = string.Empty }},
            { NumericType.Now_FuHuoPro, new NumericAttribute(){ Name = "重生几率", Icon = string.Empty }},
            { NumericType.Now_WuShiFangYuPro, new NumericAttribute(){ Name = "无视防御", Icon = string.Empty }},
            { NumericType.Now_SkillNoCDPro, new NumericAttribute(){ Name = "技能零冷却", Icon = string.Empty }},
            { NumericType.Now_SkillMoreDamgePro, new NumericAttribute(){ Name = "技能额外伤害", Icon = string.Empty }},
            { NumericType.Now_SkillDodgePro, new NumericAttribute(){ Name = "技能闪避", Icon = string.Empty }},
            { NumericType.Now_ShenNongPro, new NumericAttribute(){ Name = "神农", Icon = string.Empty }},
            { NumericType.Now_SecHpAddPro, new NumericAttribute(){ Name = "每秒恢复", Icon =  string.Empty }},
            { NumericType.Now_DiKangPro, new NumericAttribute(){ Name = "抵抗减益状态", Icon =  string.Empty }},
            { NumericType.Now_MageDodgePro, new NumericAttribute(){ Name = "魔法闪避", Icon =  string.Empty }},
            { NumericType.Now_ZhuanZhuPro, new NumericAttribute(){ Name = "专注概率", Icon =  string.Empty }},
            { NumericType.Now_ActDodgePro, new NumericAttribute(){ Name = "物理闪避", Icon =  string.Empty }},
            { NumericType.Now_ActSpeedPro, new NumericAttribute(){ Name = "攻击速度", Icon =  string.Empty }},
        };

        public static Dictionary<int, string> ItemTypeName = new Dictionary<int, string>()
        {
            {  ItemTypeEnum.Consume,  GameSettingLanguge.LoadLocalization("消耗品") },
            {  ItemTypeEnum.Material,  GameSettingLanguge.LoadLocalization("材料") },
            {  ItemTypeEnum.Equipment,   GameSettingLanguge.LoadLocalization("装备") },
            {  ItemTypeEnum.Gemstone,   GameSettingLanguge.LoadLocalization("宝石") },
            {  ItemTypeEnum.PetHeXin,   GameSettingLanguge.LoadLocalization("宠物之核") },
        };

        //Administrator:
        //当道具类型为1（消耗品）时该字段的意义
        //1 获得金币值
        //2 获得经验值
        //101 触发某个技能ID
        //103 宠物蛋
        //104 随机道具盒子
        //105 宠物洗炼相关道具
        //106 道具盒子,打开获取指定东西
        //当道具类型为3（装备）时该字段的意义
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
        /// <summary>
        /// ItemSubType To Name
        /// </summary>
        public static Dictionary<int, string> ItemSubType3Name = new Dictionary<int, string>()
        {
           {  0,  GameSettingLanguge.LoadLocalization("全部") },
           {  1,  GameSettingLanguge.LoadLocalization("武器") },
           {  2,  GameSettingLanguge.LoadLocalization("衣服") },
           {  3,  GameSettingLanguge.LoadLocalization("护符") },
           {  4,  GameSettingLanguge.LoadLocalization("戒指") },
           {  5,  GameSettingLanguge.LoadLocalization("饰品") },
           {  6,  GameSettingLanguge.LoadLocalization("鞋子") },
           {  7,  GameSettingLanguge.LoadLocalization("裤子") },
           {  8,  GameSettingLanguge.LoadLocalization("腰带") },
           {  9,  GameSettingLanguge.LoadLocalization("手镯") },
           {  10,  GameSettingLanguge.LoadLocalization("头盔") },
           {  11,  GameSettingLanguge.LoadLocalization("项链") },
           {  1202,  GameSettingLanguge.LoadLocalization("丑牛·破风") },
        };

        public static string GetItemSubType3Name(int subType)
        { 
            string name = string.Empty;
            ItemSubType3Name.TryGetValue(subType, out name);
            return name;
        }

        public struct EquipWeiZhiInfo
        {
            public string Name;
            public string Icon;
        }
        /// <summary>
        /// 装备位置配置
        /// </summary>
        public static Dictionary<int, EquipWeiZhiInfo> EquipWeiZhiToName = new Dictionary<int, EquipWeiZhiInfo>()
        {
           {  1,  new EquipWeiZhiInfo(){ Icon = "Img_24",   Name = "武器" } },
           {  2,  new EquipWeiZhiInfo(){ Icon = "Img_28",   Name = "衣服" } },
           {  3,  new EquipWeiZhiInfo(){ Icon = "Img_29",   Name = "护符" } },
           {  4,  new EquipWeiZhiInfo(){ Icon = "Img_19",   Name = "戒指" } },
           {  5,  new EquipWeiZhiInfo(){ Icon = "Img_21",   Name = "饰品" } },
           {  6,  new EquipWeiZhiInfo(){ Icon = "Img_26",   Name = "鞋子" } },
           {  7,  new EquipWeiZhiInfo(){ Icon = "Img_20",   Name = "裤子" } },
           {  8,  new EquipWeiZhiInfo(){ Icon = "Img_27",   Name = "腰带" } },
           {  9,  new EquipWeiZhiInfo(){ Icon = "Img_22",  Name = "手镯" } },
           {  10,  new EquipWeiZhiInfo(){ Icon = "Img_23",  Name = "头盔" } },
           {  11,  new EquipWeiZhiInfo(){ Icon = "Img_25",  Name = "项链" } },
        };

        //宝石槽位
        public static Dictionary<int, string> GemHoleName = new Dictionary<int, string>()
        {
            {  101,  GameSettingLanguge.LoadLocalization("黄色插槽") },
            {  102,  GameSettingLanguge.LoadLocalization("紫色插槽") },
            {  103,  GameSettingLanguge.LoadLocalization("蓝色插槽") },
            {  104,  GameSettingLanguge.LoadLocalization("绿色插槽") },
            {  105,  GameSettingLanguge.LoadLocalization("橙色插槽") },
        };

        //消耗品
        public static Dictionary<int, string> ItemSubType1Name = new Dictionary<int, string>()
        {
             {  0,  GameSettingLanguge.LoadLocalization("全部") },
             {  101,  GameSettingLanguge.LoadLocalization("药剂") },
             {  15,  GameSettingLanguge.LoadLocalization("附魔") },
             /*
             {  1,  GameSettingLanguge.LoadLocalization("金币") },
             {  2,  GameSettingLanguge.LoadLocalization("经验") },
             {  101,  GameSettingLanguge.LoadLocalization("触发某个技能ID") },
             {  102,  GameSettingLanguge.LoadLocalization("宠物蛋") },
             {  103,  GameSettingLanguge.LoadLocalization("随机宠物蛋") },
             {  104,  GameSettingLanguge.LoadLocalization("随机道具") },
             {  105,  GameSettingLanguge.LoadLocalization("宠物洗练") },

             {  106,  GameSettingLanguge.LoadLocalization("道具盒子") },
             */
             
        };

        //材料
        public static Dictionary<int, string> ItemSubType2Name = new Dictionary<int, string>()
        {
             {  0,  GameSettingLanguge.LoadLocalization("全部") },
             {  1,  GameSettingLanguge.LoadLocalization("材料") },
             {  121,  GameSettingLanguge.LoadLocalization("鉴定符") },
             {  122,  GameSettingLanguge.LoadLocalization("宠物技能") },
             /*
             {  1,  GameSettingLanguge.LoadLocalization("金币") },
             {  2,  GameSettingLanguge.LoadLocalization("经验") },
             {  101,  GameSettingLanguge.LoadLocalization("触发某个技能ID") },
             {  102,  GameSettingLanguge.LoadLocalization("宠物蛋") },
             {  103,  GameSettingLanguge.LoadLocalization("随机宠物蛋") },
             {  104,  GameSettingLanguge.LoadLocalization("随机道具") },
             {  105,  GameSettingLanguge.LoadLocalization("宠物洗练") },
             {  106,  GameSettingLanguge.LoadLocalization("道具盒子") },
             */
             
        };

        //材料
        public static Dictionary<int, string> ItemSubType4Name = new Dictionary<int, string>()
        {
            {  0,  GameSettingLanguge.LoadLocalization("全部") },
            {  101,  GameSettingLanguge.LoadLocalization("黄色插槽") },
            {  102,  GameSettingLanguge.LoadLocalization("紫色插槽") },
            {  103,  GameSettingLanguge.LoadLocalization("蓝色插槽") },
            {  104,  GameSettingLanguge.LoadLocalization("绿色插槽") },
            {  105,  GameSettingLanguge.LoadLocalization("橙色插槽") },
        };

        public static string XiLianWeiZhiTip(int hideId)
        {
            string tip = string.Empty;
            HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hideId);
            int[] spaces = hideProListConfig.EquipSpace;
            if (spaces == null)
            {
                return tip;
            }
            tip += "\n\r";
            tip += "<color=#ACFF23FF>此属性可出现的装备部位：\n";

            //string str = hideProListConfig.EquipSpace.ArrayToString();
            //Log.Info("hideProListConfig.EquipSpace.ArrayToString() = " + hideProListConfig.EquipSpace.ArrayToString());
            //if (hideProListConfig.EquipSpace.ArrayToString() != " [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]")
            //{
            for (int i = 0; i < spaces.Length; i++)
            {
                tip += GetItemSubType3Name(spaces[i]) + "、";
            }
            tip = tip.Substring(0, tip.Length - 1);
            //}
            /*
            else {
                tip += "全部位";
            }
            */
            tip += "</color>";
            return tip;
        }

        public static string GetAttributeName(int numberType)
        {
            NumericAttribute numericAttribute;
            AttributeToName.TryGetValue(numberType, out numericAttribute);
            string name = numericAttribute.Name;
            if (string.IsNullOrEmpty(name) && numberType > NumericType.Max)
            {
                return GetAttributeName(numberType / 100);
            }
            return GameSettingLanguge.LoadLocalization(name);
        }

        public static string GetAttributeIcon(int numberType)
        {
            NumericAttribute numericAttribute;
            AttributeToName.TryGetValue(numberType, out numericAttribute);
            string icon = numericAttribute.Icon;
            if (string.IsNullOrEmpty(icon) && numberType > NumericType.Max)
            {
                return GetAttributeIcon(numberType / 100);
            }
            return numericAttribute.Icon;
        }

        public static string GetAttributeDesc(List<HideProList> hideProLists)
        {
            string desc = "";
            for (int i = 0; i < hideProLists.Count; i++)
            {
                desc += $"{hideProLists[i].HideID} {hideProLists[i].HideValue}  ";
            }
            return desc;
        }

        public static string GetItemDesc(BagInfo baginfo, ref int i1)
        {
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(baginfo.ItemID);
            string Text_ItemDes = itemconf.ItemDes;
            int itemType = itemconf.ItemType;
            int itemSubType = itemconf.ItemSubType;

            string[] itemDesArray = Text_ItemDes.Split(';');
            string itemMiaoShu = "";
            for (int i = 0; i <= itemDesArray.Length - 1; i++)
            {
                if (itemMiaoShu == "")
                {
                    itemMiaoShu = itemDesArray[i];
                }
                else
                {
                    itemMiaoShu = itemMiaoShu + "\n" + itemDesArray[i];
                }
            }

            //数组大于2表示有换行符,否则显示原来的描述
            if (itemDesArray.Length >= 2)
            {
                Text_ItemDes = itemMiaoShu;
            }

            //根据Tips描述长度缩放底的大小
            i1 = 0;
            i1 = (int)((Text_ItemDes.Length) / 16) + 1;
            if (itemDesArray.Length > i1)
            {
                i1 = itemDesArray.Length;
            }
            string langStr = "";
            //宝石显示额外的描述
            if (itemType == 4)
            {
                string holeStr = "";
                //string baoshitype = "101, 102, 103, 104, 105";
                string baoshitype = itemconf.ItemSubType.ToString();
                string[] holeStrList = baoshitype.Split(',');
                for (int i = 0; i < holeStrList.Length; i++)
                {
                    switch (holeStrList[i])
                    {
                        case "101":
                            langStr = GameSettingLanguge.LoadLocalization("黄色");
                            holeStr = holeStr + langStr + "、";
                            break;
                        case "102":
                            langStr = GameSettingLanguge.LoadLocalization("紫色");
                            holeStr = holeStr + langStr + "、";
                            break;
                        case "103":
                            langStr = GameSettingLanguge.LoadLocalization("蓝色");
                            holeStr = holeStr + langStr + "、";
                            break;
                        case "104":
                            langStr = GameSettingLanguge.LoadLocalization("绿色");
                            holeStr = holeStr + langStr + "、";
                            break;
                            /*
                            case "105":
                                langStr = GameSettingLanguge.LoadLocalization("白色");
                                holeStr = holeStr + langStr + "、";
                                break;
                            case "110":
                                langStr = GameSettingLanguge.LoadLocalization("多彩");
                                holeStr = holeStr + langStr + "、";
                                break;
                            */
                    }
                }

                if (holeStr != "")
                {
                    holeStr = holeStr.Substring(0, holeStr.Length - 1);
                }

                //特殊处理
                /*
                if (itemSubType == 101)
                {
                    string langStr_B = GameSettingLanguge.LoadLocalization("任意颜色的");
                    holeStr = langStr_B;
                }
                */

                i1 = i1 + 2;

                string langStr_2 = GameSettingLanguge.LoadLocalization("可镶嵌在");
                string langStr_3 = GameSettingLanguge.LoadLocalization("孔位");
                Text_ItemDes = Text_ItemDes + "\n" + "\n" + @"" + langStr_2 + holeStr + @langStr_3 + "";
            }

            //宠物之核
            if (itemType == 5)
            {
                string holeStr = "";
                //string baoshitype = "101, 102, 103, 104, 105";
                string baoshitype = itemconf.ItemSubType.ToString();
                string[] holeStrList = baoshitype.Split(',');
                for (int i = 0; i < holeStrList.Length; i++)
                {
                    switch (holeStrList[i])
                    {
                        case "1":
                            langStr = GameSettingLanguge.LoadLocalization("进攻能量");
                            holeStr = holeStr + langStr + "、";
                            break;
                        case "2":
                            langStr = GameSettingLanguge.LoadLocalization("守护能量");
                            holeStr = holeStr + langStr + "、";
                            break;
                        case "3":
                            langStr = GameSettingLanguge.LoadLocalization("生命能量");
                            holeStr = holeStr + langStr + "、";
                            break;
                    }
                }

                if (holeStr != "")
                {
                    holeStr = holeStr.Substring(0, holeStr.Length - 1);
                }

                //特殊处理
                /*
                if (itemSubType == 101)
                {
                    string langStr_B = GameSettingLanguge.LoadLocalization("任意颜色的");
                    holeStr = langStr_B;
                }
                */

                i1 = i1 + 2;

                string langStr_2 = GameSettingLanguge.LoadLocalization("可装备在宠物的");
                string langStr_3 = GameSettingLanguge.LoadLocalization("槽位");
                Text_ItemDes = Text_ItemDes + "\n" + "\n" + @"" + langStr_2 + holeStr + @langStr_3 + "";
            }

            //藏宝图额外描述
            if (itemType == 1 && itemType == 32)
            {
                string langStr_4 = GameSettingLanguge.LoadLocalization("挖宝位置");
                string itemPar = baginfo.ItemPar;
                string scenceName = ChapterSonConfigCategory.Instance.Get(int.Parse(itemPar)).Name;
                Text_ItemDes = Text_ItemDes + "\n" + "\n" + langStr_4 + ":" + scenceName;
                i1 = i1 + 2;
            }

            //牧场道具额外描述
            if (itemType == 6)
            {
                string langStr_5 = GameSettingLanguge.LoadLocalization("品质");

                string itemPar = "0";
                if (itemSubType == 1)
                {
                    itemPar = "";
                }
                if (itemSubType == 2)
                {
                    itemPar = baginfo.ItemPar;
                }
                Text_ItemDes = Text_ItemDes + "\n" + "\n" + "<color=#F0E2C0FF>" + langStr_5 + ":" + itemPar + "</color>";
                i1 = i1 + 2;
            }

            return Text_ItemDes;
        }

        //展示单条列表信息//
        public static GameObject ShowPropertyText(string showText, string showType, GameObject proItem, GameObject parObj)
        {
            GameObject propertyObj = (GameObject)GameObject.Instantiate(proItem);
            propertyObj.transform.SetParent(parObj.transform);
            propertyObj.transform.localScale = new Vector3(1, 1, 1);
            propertyObj.GetComponent<Text>().text = showText;
            //propertyObj.transform.localPosition = new Vector3(-12, -30 - 25 * self.properShowNum, 0);
            propertyObj.transform.localPosition = new Vector3(0, 0, 0);
            propertyObj.SetActive(true);

            switch (showType)
            {
                //极品提示  绿色
                case "1":
                    //propertyObj.GetComponent<Text>().color = new Color(0.5f, 1f, 0f);
                    propertyObj.GetComponent<Text>().color = new Color(80f / 255f, 160f / 255f, 0f);
                    break;
                //隐藏技能  橙色
                case "2":
                    propertyObj.GetComponent<Text>().color = new Color(248 / 255f, 62f / 255, 191f / 255f);
                    break;
                //红色
                case "3":
                    propertyObj.GetComponent<Text>().color = Color.red;
                    break;
                //蓝色
                case "4":
                    propertyObj.GetComponent<Text>().color = new Color(1f, 0.5f, 1f);
                    break;
                //白色
                case "5":
                    //propertyObj.GetComponent<Text>().color = new Color(1f, 1f, 1f);
                    propertyObj.GetComponent<Text>().color = new Color(100f / 255f, 80f / 255f, 60f / 255f);
                    break;
                //灰色
                case "11":
                    propertyObj.GetComponent<Text>().color = new Color(0.66f, 0.66f, 0.66f);
                    break;
            }

            return propertyObj;
        }

        public static string ShowDuiHuanPet(int configId)
        {
            GlobalValueConfig globalValue = GlobalValueConfigCategory.Instance.Get(configId);
            string[] configInfo = globalValue.Value.Split('@');
            string[] iteminfo = configInfo[0].Split(';');

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(int.Parse(iteminfo[0]));
            PetConfig petConfig = PetConfigCategory.Instance.Get(int.Parse(configInfo[1]));
            string info = $"消耗{itemConfig.ItemName}X{iteminfo[1]}兑换{petConfig.PetName}";
            return info;
        }

        //装备镶嵌宝石
        public static void TipsShowEquipGem(Scene zoneScene, GameObject icon, GameObject text, int gemHole, int gemId)
        {
            if (gemHole == 0)
            {
                return;
            }
            if (gemId != 0)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(gemId);
                text.GetComponent<Text>().text = itemConfig.ItemName;
                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
                icon.GetComponent<Image>().sprite = sp;
            }
            else
            {
                text.GetComponent<Text>().text = UIItemHelp.GemHoleName[gemHole];
                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"Img_hole_{gemHole}");
                icon.GetComponent<Image>().sprite = sp;
            }
        }

        //装备基础属性
        public static int ShowBaseAttribute(BagInfo baginfo, GameObject Obj_EquipPropertyText, GameObject Obj_EquipBaseSetList)
        {
            int properShowNum = 0;
            ItemConfig itemconf = ItemConfigCategory.Instance.Get(baginfo.ItemID);
            string ItemIcon = itemconf.Icon;
            int ItemQuality = itemconf.ItemQuality;
            string equip_ID = itemconf.ItemEquipID.ToString();
            string equipName = itemconf.ItemName;
            string equipLv = itemconf.UseLv.ToString();
            string ItemBlackDes = itemconf.ItemDes;

            EquipConfig equipconf = EquipConfigCategory.Instance.Get(itemconf.ItemEquipID);
            int equip_Hp = equipconf.Equip_Hp;
            int equip_MinAct = equipconf.Equip_MinAct;
            int equip_MaxAct = equipconf.Equip_MaxAct;
            int equip_MinMagAct = equipconf.Equip_MinMagAct;
            int equip_MaxMagAct = equipconf.Equip_MaxMagAct;
            int equip_MinDef = equipconf.Equip_MinDef;
            int equip_MaxDef = equipconf.Equip_MaxDef;
            int equip_MinAdf = equipconf.Equip_MinAdf;
            int equip_MaxAdf = equipconf.Equip_MaxAdf;
            double equip_Cri = equipconf.Equip_Cri;
            double equip_Hit = equipconf.Equip_Hit;
            double equip_Dodge = equipconf.Equip_Dodge;
            double equip_DamgeAdd = equipconf.Equip_DamgeAdd;
            double equip_DamgeSub = equipconf.Equip_DamgeSub;
            double equip_Speed = equipconf.Equip_Speed;
            double equip_Lucky = equipconf.Equip_Lucky;

            /*
            HideProList hide1 = new HideProList();
            hide1.HideID = (int)NumericType.Base_MaxAct_Base;
            hide1.HideValue = 12;
            baginfo.XiLianHideProLists.Add(hide1);
            */

            //换算总显示数值
            if (baginfo.XiLianHideProLists != null)
            {
                for (int i = 0; i < baginfo.XiLianHideProLists.Count; i++)
                {

                    int hidePropertyType = baginfo.XiLianHideProLists[i].HideID;
                    int hidePropertyValue = (int)baginfo.XiLianHideProLists[i].HideValue;

                    switch (hidePropertyType)
                    {
                        case NumericType.Base_MaxHp_Base:
                            equip_Hp = equip_Hp + hidePropertyValue;
                            break;
                        case NumericType.Base_MaxAct_Base:
                            equip_MaxAct = equip_MaxAct + hidePropertyValue;
                            break;
                        case NumericType.Base_MaxDef_Base:
                            equip_MaxDef = equip_MaxDef + hidePropertyValue;
                            break;
                        case NumericType.Base_MaxAdf_Base:
                            equip_MaxAdf = equip_MaxAdf + hidePropertyValue;
                            break;
                    }

                }
            }

            //显示职业护甲加成
            string occShowStr = "";
            string textShow = "";
            string langStr = "";

            if (equip_Hp != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("生命");
                textShow = langStr + "  " + equip_Hp + occShowStr;
                //textNum = textNum + 1;

                bool ifHideProperty = false;
                if (baginfo.XiLianHideProLists != null)
                {
                    for (int i = 0; i < baginfo.XiLianHideProLists.Count; i++)
                    {
                        int hidePropertyType = baginfo.XiLianHideProLists[i].HideID;
                        int hidePropertyValue = (int)baginfo.XiLianHideProLists[i].HideValue;

                        if (hidePropertyType == NumericType.Base_MaxHp_Base)
                        {
                            textShow = langStr + " ： " + equip_Hp + "(+" + hidePropertyValue + ")" + occShowStr + occShowStr;
                            ifHideProperty = true;
                        }
                    }
                }

                if (ifHideProperty)
                {
                    ShowPropertyText(textShow, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
                else
                {
                    ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
            }

            if (equip_MinAct != 0 || equip_MaxAct != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("攻击");
                textShow = langStr + " ：" + equip_MinAct + " - " + equip_MaxAct;
                //textShow = langStr + "  " + equip_MaxAct + occShowStr;
                //textNum = textNum + 1;
                //ShowPropertyText(textShow);
                bool ifHideProperty = false;
                if (baginfo.XiLianHideProLists != null)
                {
                    for (int i = 0; i < baginfo.XiLianHideProLists.Count; i++)
                    {
                        int hidePropertyType = baginfo.XiLianHideProLists[i].HideID;
                        int hidePropertyValue = (int)baginfo.XiLianHideProLists[i].HideValue;

                        if (hidePropertyType == NumericType.Base_MaxAct_Base)
                        {
                            textShow = langStr + " ： " + equip_MinAct + " - " + equip_MaxAct + "(+" + hidePropertyValue + ")" + occShowStr;
                            //textShow = langStr + "  " + equip_MaxAct + "(+" + hidePropertyValue + ")" + occShowStr;
                            ifHideProperty = true;
                        }
                    }
                }
                if (ifHideProperty)
                {
                    ShowPropertyText(textShow, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
                else
                {
                    ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
            }

            if (equip_MinDef != 0 || equip_MaxDef != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("防御");
                textShow = langStr + " ：" + equip_MinDef + " - " + equip_MaxDef;
                //textShow = langStr + "  " + equip_MaxDef + occShowStr;
                //textNum = textNum + 1;
                //ShowPropertyText(textShow);
                bool ifHideProperty = false;
                if (baginfo.XiLianHideProLists != null)
                {
                    for (int i = 0; i < baginfo.XiLianHideProLists.Count; i++)
                    {
                        int hidePropertyType = baginfo.XiLianHideProLists[i].HideID;
                        int hidePropertyValue = (int)baginfo.XiLianHideProLists[i].HideValue;

                        if (hidePropertyType == NumericType.Base_MaxDef_Base)
                        {
                            textShow = langStr + " ： " + equip_MinDef + " - " + equip_MaxDef + "(+" + hidePropertyValue + ")" + occShowStr;
                            //textShow = langStr + "  " + equip_MaxDef + "(+" + hidePropertyValue + ")" + occShowStr;
                            ifHideProperty = true;
                        }

                    }
                }
                if (ifHideProperty)
                {
                    ShowPropertyText(textShow, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
                else
                {
                    ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
            }

            if (equip_MinAdf != 0 || equip_MaxAdf != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("魔防");
                textShow = langStr + " ：" + equip_MinAdf + " - " + equip_MaxAdf;
                //textShow = langStr + "  " + equip_MaxAdf + occShowStr;
                bool ifHideProperty = false;
                if (baginfo.XiLianHideProLists != null)
                {
                    for (int i = 0; i < baginfo.XiLianHideProLists.Count; i++)
                    {
                        int hidePropertyType = baginfo.XiLianHideProLists[i].HideID;
                        int hidePropertyValue = (int)baginfo.XiLianHideProLists[i].HideValue;

                        if (hidePropertyType == NumericType.Base_MaxAdf_Base)
                        {
                            textShow = langStr + " ： " + equip_MinAdf + " - " + equip_MaxAdf + "(+" + hidePropertyValue + ")" + occShowStr;
                            //textShow = langStr + "  " + equip_MaxAdf + "(+" + hidePropertyValue + ")" + occShowStr;
                            ifHideProperty = true;
                        }
                    }
                }
                if (ifHideProperty)
                {
                    ShowPropertyText(textShow, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
                else
                {
                    ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
            }
            if (equip_Cri != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("暴击");
                textShow = langStr + "  " + equip_Cri * 100 + "%\n";
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }
            if (equip_Hit != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("命中");
                textShow = langStr + "  " + equip_Hit * 100 + "%\n";
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }
            if (equip_Dodge != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("闪避");
                textShow = langStr + "  " + equip_Dodge * 100 + "%\n";
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }

            if (equip_DamgeAdd != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("伤害加成");
                textShow = langStr + "  " + equip_DamgeAdd * 100 + "%\n";
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }

            if (equip_DamgeSub != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("伤害减免");
                textShow = langStr + "  " + equip_DamgeSub * 100 + "%\n";
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }
            if (equip_Speed != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("移动速度");
                textShow = langStr + "  " + equip_Dodge;
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }

            if (equip_Lucky != 0)
            {
                langStr = GameSettingLanguge.LoadLocalization("幸运值");
                textShow = langStr + "  " + equip_Lucky;
                //textNum = textNum + 1;
                ShowPropertyText(textShow, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }

            //显示隐藏洗炼属性
            if (baginfo.XiLianHideTeShuProLists != null)
            {
                for (int i = 0; i < baginfo.XiLianHideTeShuProLists.Count; i++)
                {
                    int nowType = baginfo.XiLianHideTeShuProLists[i].HideID;
                    if (nowType != NumericType.Base_MaxHp_Base && nowType != NumericType.Base_MaxAct_Base && nowType != NumericType.Base_MaxDef_Base && nowType != NumericType.Base_MaxAdf_Base)
                    {
                        int hidePropertyType = baginfo.XiLianHideTeShuProLists[i].HideID;
                        long hidePropertyValue = baginfo.XiLianHideTeShuProLists[i].HideValue;
                        HideProListConfig hidePro = HideProListConfigCategory.Instance.Get(hidePropertyType);
                        string proStr = "";
                        if (NumericHelp.GetNumericValueType(hidePro.PropertyType) == 2)
                        {
                            proStr = hidePro.Name + GameSettingLanguge.LoadLocalization("提升") + ((float)hidePropertyValue / 100.0f).ToString("0.##") + "%";     // 0.82   0.80
                        }
                        else
                        {
                            proStr = hidePro.Name + GameSettingLanguge.LoadLocalization("提升") + hidePropertyValue + GameSettingLanguge.LoadLocalization("点");
                        }
                        ShowPropertyText(proStr, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                        properShowNum += 1;
                    }
                }
            }

            //显示隐藏技能
            if (baginfo.HideSkillLists != null)
            {
                for (int i = 0; i < baginfo.HideSkillLists.Count; i++)
                {
                    int skillID = baginfo.HideSkillLists[i];
                    SkillConfig skillCof = SkillConfigCategory.Instance.Get(skillID);
                    string proStr = GameSettingLanguge.LoadLocalization("隐藏技能") + ":" + skillCof.SkillName;
                    ShowPropertyText(proStr, "2", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
            }

            //显示装备附加属性
            for (int i = 0; i < equipconf.AddPropreListType.Length; i++)
            {
                if (equipconf.AddPropreListIfShow.Length <= i)
                {
                    continue;
                }

                if (equipconf.AddPropreListIfShow[i] == 0)
                {
                    int numericType = equipconf.AddPropreListType[i];
                    if (numericType == 0)
                    {
                        continue;
                    }
                    string attribute = "";
                    long numericValue = equipconf.AddPropreListValue[i];
                    int showType = NumericHelp.GetNumericValueType(numericType);
                    if (showType == 2)
                    {
                        float value = (float)numericValue / 100f;
                        //attribute = $"{ItemViewHelp.GetAttributeName(showType)} + {numericValue * 0.01f}%";
                        attribute = $"{UIItemHelp.GetAttributeName(numericType)} + " + value.ToString("0.##") + "%";
                    }
                    else
                    {
                        attribute = $"{UIItemHelp.GetAttributeName(numericType)} + {numericValue}";
                    }
                    ShowPropertyText(attribute, "0", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                    properShowNum += 1;
                }
            }


            //显示附魔属性
            for (int i = 0; i < baginfo.FumoProLists.Count; i++)
            {
                HideProList hideProList = baginfo.FumoProLists[i];
                int showType = NumericHelp.GetNumericValueType(hideProList.HideID);
                string attribute;
                if (showType == 2)
                {
                    float value = (float)hideProList.HideValue / 100f;
                    attribute = $"附魔属性: {UIItemHelp.GetAttributeName(hideProList.HideID)} + " + value.ToString("0.##") + "%";
                }
                else
                {
                    attribute = $"附魔属性: {UIItemHelp.GetAttributeName(hideProList.HideID)} + {hideProList.HideValue}";
                }
                ShowPropertyText(attribute, "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                properShowNum += 1;
            }


            //显示描述
            if (itemconf.ItemDes != "" && itemconf.ItemDes != "0" && itemconf.ItemDes != null)
            {
                int allLength = itemconf.ItemDes.Length;
                int addNum = Mathf.CeilToInt(allLength / 18f);
                for (int a = 0; a < addNum; a++)
                {
                    int leftNum = allLength - a * 18;
                    leftNum = Math.Min(leftNum, 18);
                    ShowPropertyText(itemconf.ItemDes.Substring(a * 18, leftNum), "1", Obj_EquipPropertyText, Obj_EquipBaseSetList);
                }
                //int zifuLenght = GetNumbers(itemconf.ItemDes) + GetTeShu(itemconf.ItemDes);
                //int lenght = (allLength - zifuLenght) + (int)(zifuLenght * 0.5f);
                properShowNum += addNum;
            }

            return properShowNum;
        }

        public static int GetTeShu(string p_str)
        {
            char[] one = p_str.ToCharArray();
            char[] two = new char[one.Length];
            int c = 0;
            for (int i = 0; i < one.Length; i++)
            {
                if (!Char.IsLetterOrDigit(one[i]))
                {
                    two[c] = one[i];
                    c++;
                }
            }
            return c;
        }

        ///<summary>   
        /// 从字符串中提取所有数字   
        /// Returns：所有数字   
        /// </summary>     
        /// <param name = "p_str">需要提取的字符串</param>   
        /// <returns>所有数字</returns>   
        public static int GetNumbers(string p_str)
        {
            //取出字符串中所有的英文字母   
            string strSplit1 = Regex.Replace(p_str, "[0-9]", "", RegexOptions.IgnoreCase);
            //取出字符串中所有的数字   
            string strSplit2 = Regex.Replace(p_str, "[a-z]", "", RegexOptions.IgnoreCase);

            return p_str.Length - strSplit1.Length + p_str.Length - strSplit2.Length; 
            //string strReturn = string.Empty;
            //if (p_str == null || p_str.Trim() == "")
            //{
            //    strReturn = "";
            //}
            //foreach (char chrTemp in p_str)
            //{
            //    if (!Char.IsNumber(chrTemp))
            //    {
            //        strReturn += chrTemp.ToString();
            //    }
            //}
            //return strReturn;
        }
    }
}
