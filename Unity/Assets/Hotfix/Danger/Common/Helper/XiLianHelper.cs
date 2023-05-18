using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public static class XiLianHelper
    {

        public static int returnProValue(int xuhao)
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

        public static string GenerateGemHoleInfo(int itemQuality, int itemLv, int xilianType)
        {
            string gemholeinfo = "";
            List<int> gemHoleId = new List<int>() { 0, 1, 2, 3, 4 };
            List<int> gemWeight = new List<int>() { 50, 25, 15, 10, 0 };
            int gemNumber = gemHoleId[RandomHelper.RandomByWeight(gemWeight)];

            //等级限制
            int maxNum = 1;
            if (itemLv > 1 && itemLv <= 19) {

                maxNum = 1;
            }

            if (itemLv > 20 && itemLv <= 29)
            {
                maxNum = 2;
            }

            if (itemLv > 30)
            {
                maxNum = 3;
            }

            if (gemNumber >= maxNum) {
                gemNumber = maxNum;
            }

            //打造保底出1个孔位
            if (xilianType == 2) {
                if (gemNumber < 1)
                {
                    gemNumber = 1;
                }
            }

            gemNumber = itemQuality >= 5 ? 4 : gemNumber;
            for (int i = 0; i < gemNumber; i++)
            {
                gemholeinfo += RandomHelper.RandomNumber(101, 105).ToString();
                gemholeinfo += "_";
            }
            return gemholeinfo.Length > 1 ? gemholeinfo.Substring(0, gemholeinfo.Length - 1) : gemholeinfo;
        }

        public static List<KeyValuePairInt> GetLevelSkill(int xilianLevel)
        {
            List<KeyValuePairInt> skills = new List<KeyValuePairInt>();
            int hideProId = 2001;
            while (hideProId != 0)
            {
                HideProListConfig proListConfig = HideProListConfigCategory.Instance.Get(hideProId);
                if (xilianLevel == proListConfig.NeedXiLianLv)
                {
                    skills.Add(new KeyValuePairInt() { KeyId = proListConfig.Id, Value = proListConfig.PropertyType });
                }
                hideProId = proListConfig.NtxtID;
            }
            return skills;
        }

        public static int GetXiLianId(int xilianDu)
        {
            int xilianid = 0;
            List<EquipXiLianConfig> equipXiLians = EquipXiLianConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < equipXiLians.Count; i++)
            {
                if (equipXiLians[i].XiLianType != 0)
                {
                    continue;
                }
                if (xilianDu <= equipXiLians[i].NeedShuLianDu)
                {
                    break;
                }
                xilianid = equipXiLians[i].Id;
            }
            return xilianid;
        }


#if SERVER
        /// <summary>
        /// 洗练装备
        /// </summary>
        /// <param name="bagInfo"></param>
        /// xilianType  洗炼类型   0 普通掉落  1 装备洗炼功能   2 (不显示广播消息)
        public static ItemXiLianResult XiLianItem(Unit unit, BagInfo bagInfo, int xilianType, int xilianLv)
        {

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            //获取装备等级和装备类型
            int equipID = itemConfig.ItemEquipID;
            //默认送四个宝石位
            List<HideProList> HideProList = new List<HideProList>();    //专精属性
            List<HideProList> BaseHideProList = new List<HideProList>();    //基础洗炼属性
            List<HideProList> TeShuHideProList = new List<HideProList>();    //基础洗炼属性
            List<int> HideSkillList = new List<int>();

            EquipConfig equipConfig = EquipConfigCategory.Instance.Get(equipID);
            int HideType = equipConfig.HideType;

            double hideShowPro = equipConfig.HideShowPro;
            if (xilianType == 1 || xilianType == 2)
            {
                hideShowPro = 1;        //洗炼100%出随机属性
            }

            //附加额外的极品属性
            float equipJiPinPro = 1f;
            float equipJiPinAddPro = 1f;
            //附加特殊技能
            float equipJiPinSkillPro = 0.05f;

            //如果是打造装备 特殊技能属性调高
            /*
            if (xilianType == 2) {
                equipJiPinPro = 1f;
                equipJiPinAddPro = 2f;
                equipJiPinSkillPro = 0.1f;
            }
            */
            //-------------------测试-------------------
            //附加额外的极品属性
            //equipJiPinPro = 1f;
            //附加特殊技能
            //equipJiPinSkillPro = 1f;

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
                            int addValue = ItemAddHelper.ReturnEquipRamdomValue(1, hideMaxStr, bagInfo.HideID);
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
                            int addValue = ItemAddHelper.ReturnEquipRamdomValue(1, hideMaxStr, bagInfo.HideID);
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
                            int addValue = ItemAddHelper.ReturnEquipRamdomValue(1, hideMaxStr, bagInfo.HideID);
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


                //如果是掉落,概率降低10倍
                /*
                if (bagInfo.HideID == 0)
                {
                    equipJiPinPro = 0.05f;
                }
                */

                float randValue = RandomHelper.RandFloat01();
                //Log.Info("randValue = " + randValue + " equipJiPinPro = " + equipJiPinPro);
                if (randValue <= equipJiPinPro)
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

                        if (hideProListConfig.NeedXiLianLv > xilianLv)
                        {
                            break;
                        }
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

                        //临时
                        /*
                        if (hintProListID == 1012) {
                            triggerPro = 1;
                        }
                        */

                        //触发隐藏属性
                        float ranValue = RandomHelper.RandFloat01();
                        //Log.Info("ranValue = " + ranValue + " triggerPro = " + triggerPro);
                        if (ranValue < triggerPro * equipJiPinAddPro)
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
                                hintProVlaue = ItemAddHelper.ReturnEquipRamdomValue((int)propertyValueMin, (int)(propertyValueMax), bagInfo.HideID);
                                if (hintProVlaue <= 0)
                                {
                                    hintProVlaue = propertyValueMin;
                                }
                            }
                            else
                            {
                                //表示浮点数
                                hintProVlaue = ItemAddHelper.ReturnEquipRamdomValue_float(propertyValueMin, propertyValueMax);
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

                //如果是掉落,概率降低10倍
                /*
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
                */

                bool ishaveSkill = false;
                if (RandomHelper.RandFloat01() <= equipJiPinSkillPro || ishaveSkill)
                {
                    int nextID = 0;
                    int hintProListID = 2001;
                    //获取隐藏条最大目数
                    int hintJiPinMaxNum = 1;
                    int hintJiPinMaxNumSum = 0;

                    //洗练到一定次数必得隐藏技能ID
                    /*
                    int teShuHintProListID = 0;

                    if (teShuHintProListID != 0)
                    {
                        hintProListID = teShuHintProListID;
                    }
                    */
                    do
                    {
                        //获取单条触发概率
                        HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(hintProListID);

                        //获取当前洗炼家等级 洗炼家等级不满足直接跳出
                        int xilianLevel = XiLianHelper.GetXiLianId(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu));
                        if (xilianLevel < hideProListConfig.NeedXiLianLv) {
                            //立即跳出循环
                            break;
                        }

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
                            if (RandomHelper.RandFloat01() < triggerPro)
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
                        /*
                        if (teShuHintProListID != 0)
                        {
                            break;
                        }
                        */

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
                //}
            }

            if (xilianType == 0|| xilianType == 2) //普通掉落和打造
            {
                bagInfo.GemHole = GenerateGemHoleInfo(itemConfig.ItemQuality, itemConfig.UseLv, xilianType);
            }

            if (HideSkillList.Count > 0)
            {
                string skillName = string.Empty;
                for (int i = 0; i < HideSkillList.Count; i++)
                {
                    skillName = skillName + $" {SkillConfigCategory.Instance.Get(HideSkillList[i]).SkillName}";

                    string name = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
                    string noticeContent = "";
                    if (xilianType == 1)
                    {
                        noticeContent = $"恭喜玩家<color=#B6FF00>{name}</color>洗练出隐藏技能:<color=#FFA313>{skillName}</color>";
                    }
                    if (xilianType == 0 && itemConfig.ItemQuality<=3)
                    {
                        noticeContent = $"恭喜玩家<color=#B6FF00>{name}</color>在拾取装备时,意外在装备上发现了隐藏技能:<color=#FFA313>{skillName}</color>";
                    }

                    //打造类型不弹出任何广播
                    if (xilianType != 2 && noticeContent!="")
                    {
                        ServerMessageHelper.SendBroadMessage(unit.DomainZone(), NoticeType.Notice, noticeContent);
                    }
                }
            }

            ItemXiLianResult itemXiLianResult = new ItemXiLianResult();
            itemXiLianResult.XiLianHideProLists = BaseHideProList;   //基础属性洗炼
            itemXiLianResult.HideSkillLists = HideSkillList;         //隐藏技能
            itemXiLianResult.XiLianHideTeShuProLists = TeShuHideProList;  //特殊属性洗炼
            return itemXiLianResult;
        }

        //生肖洗炼
        public static ItemXiLianResult XiLianShengXiao(BagInfo bagInfo)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            EquipConfig equipConfig = EquipConfigCategory.Instance.Get(itemConfig.ItemEquipID);

            List<HideProList> proList = new List<HideProList>();

            for (int i = 0; i < equipConfig.AddPropreListType.Length; i++) {
                int randInt = RandomHelper.NextInt(0, (equipConfig.HideMax));
                proList.Add(new HideProList() { HideID = equipConfig.AddPropreListType[i], HideValue = randInt });
            }

            ItemXiLianResult itemXiLianResult = new ItemXiLianResult();
            itemXiLianResult.XiLianHideProLists = proList;          //属性随机赋值
            //itemXiLianResult.XiLianHideTeShuProLists = proList;     //属性随机赋值
            return itemXiLianResult;

        }


        //传承洗练
        public static int XiLianChuanChengJianDing(ItemConfig itemCof,int occ,int occTwo) {

            int returnSkillID = 0;

            //获取部位   职业
            if (itemCof.ItemType == 3) {

                //饰品不能洗炼
                if (itemCof.ItemSubType == 5) {
                    return 0;
                }

                List<ConfigHelper.EquipChuanChengList> EquipChuanChengSkillCom = new List<ConfigHelper.EquipChuanChengList>();


                //攻击
                if (itemCof.ItemSubType == 1 || itemCof.ItemSubType == 10 || itemCof.ItemSubType == 11) {
                    EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkill[1]);
                }

                //防御
                if (itemCof.ItemSubType == 2 || itemCof.ItemSubType == 6 || itemCof.ItemSubType == 7 || itemCof.ItemSubType == 8) {
                    EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkill[2]);
                }

                //技能
                if (itemCof.ItemSubType == 3 || itemCof.ItemSubType == 4 || itemCof.ItemSubType == 9)
                {

                    //战士
                    if (occ == 1)
                    {
                        EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkill[11]);
                        EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOcc[1]);
                    }
                    //法师
                    if (occ == 2)
                    {
                        EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkill[12]);
                        EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOcc[2]);
                    }

                    switch (occTwo) {
                        case 11:
                            EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOccTwo[occTwo]);
                            break;
                        case 12:
                            EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOccTwo[occTwo]);
                            break;
                        case 13:
                            EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOccTwo[occTwo]);
                            break;
                        case 21:
                            EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOccTwo[occTwo]);
                            break;
                        case 22:
                            EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOccTwo[occTwo]);
                            break;
                        case 23:
                            EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillOccTwo[occTwo]);
                            break;
                    }
                }

                //通用
                EquipChuanChengSkillCom.AddRange(ConfigHelper.EquipChuanChengSkillCom);
                List<int> idList = new List<int>();
                List<int> randList = new List<int>();


                for (int i = 0;i < EquipChuanChengSkillCom.Count; i++) {

                    idList.Add(EquipChuanChengSkillCom[i].SkillID);
                    randList.Add(EquipChuanChengSkillCom[i].RandPro);
                }

                int index = RandomHelper.RandomByWeight(randList.ToArray());
                returnSkillID = idList[index];
            }

            return returnSkillID;
        }

#endif

    }
}
