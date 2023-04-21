using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class BagComponentAwakeSystem : AwakeSystem<BagComponent>
    {

        public override void Awake(BagComponent self)
        {
            self.OnAddItemData(GlobalValueConfigCategory.Instance.Get(9).Value, $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", false);
            if (ComHelp.IsBanHaoZone(self.DomainZone()))
            {
                self.OnAddItemData($"10030001;1", $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", false);
            }

            int robotId = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.RobotId;
            if (robotId != 0)
            { 
                int[] equipList = new int[0];
                RobotConfig robotConfig = RobotConfigCategory.Instance.Get(robotId);
                if (robotConfig.EquipList != null)
                {
                    equipList = robotConfig.EquipList!=null ? robotConfig.EquipList: equipList;
                }
                for (int i = 0; i < equipList.Length; i++)
                {
                    self.OnAddItemData($"{equipList[i]};1", $"{ItemGetWay.System}_{TimeHelper.ServerNow()}", false);
                }
                NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
                numericComponent.ApplyValue(NumericType.PointLiLiang, robotConfig.PointList[0]);
                numericComponent.ApplyValue(NumericType.PointZhiLi, robotConfig.PointList[1]);
                numericComponent.ApplyValue(NumericType.PointTiZhi, robotConfig.PointList[2]);
                numericComponent.ApplyValue(NumericType.PointNaiLi, robotConfig.PointList[3]);
                numericComponent.ApplyValue(NumericType.PointMinJie, robotConfig.PointList[4]);
            }
        }
    }

    public static class BagComponentSystem
    {

        public static List<HideProList> GetGemProLists(this BagComponent self)
        {
            List <HideProList>  list = new List<HideProList>(); 
            for (int i = 0; i < self.GemList.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.GemList[i].ItemID);
                string itemUsePar = itemConfig.ItemUsePar;
                if (string.IsNullOrEmpty(itemUsePar) || itemUsePar == "0")
                {
                    continue;
                }
                string[] attributes = itemUsePar.Split('@');
                for (int a = 0; a < attributes.Length; a++)
                {
                    string[] attributeItem = attributes[a].Split(';');
                    int hideId = int.Parse(attributeItem[0]);
                    long hide_value = 0;
                    if (NumericHelp.GetNumericValueType(hideId) == 2)
                    {
                        hide_value = (long)(float.Parse(attributeItem[1]) * 10000);
                    }
                    else
                    {
                        hide_value = long.Parse(attributeItem[1]);
                    }
                    list.Add( new HideProList() {  HideID = hideId, HideValue = hide_value } );
                }
            }

            return list;
        }

        public static List<BagInfo> GetItemByLoc(this BagComponent self, ItemLocType itemEquipType)
        {
            List<BagInfo> ItemTypeList = null;
            switch (itemEquipType)
            {
                case ItemLocType.ItemLocBag:
                    ItemTypeList = self.BagItemList;
                    break;
                case ItemLocType.ItemPetHeXinBag:
                    ItemTypeList = self.BagItemPetHeXin;
                    break;
                case ItemLocType.ItemLocGem:
                    ItemTypeList = self.GemList;
                    break;
                case ItemLocType.ItemLocEquip:
                    ItemTypeList = self.EquipList;
                    break;
                case ItemLocType.ItemPetHeXinEquip:
                    ItemTypeList = self.PetHeXinList;
                    break;
                case ItemLocType.ItemWareHouse1:
                    ItemTypeList = self.Warehouse1;
                    break;
                case ItemLocType.ItemWareHouse2:
                    ItemTypeList = self.Warehouse2;
                    break;
                case ItemLocType.ItemWareHouse3:
                    ItemTypeList = self.Warehouse3;
                    break;
                case ItemLocType.ItemWareHouse4:
                    ItemTypeList = self.Warehouse4;
                    break;
                case ItemLocType.JianYuanWareHouse1:
                    ItemTypeList = self.JianYuanWareHouse1;
                    break;
                case ItemLocType.JianYuanWareHouse2:
                    ItemTypeList = self.JianYuanWareHouse2;
                    break;
                case ItemLocType.JianYuanWareHouse3:
                    ItemTypeList = self.JianYuanWareHouse3;
                    break;
                case ItemLocType.JianYuanWareHouse4:
                    ItemTypeList = self.JianYuanWareHouse4;
                    break;
            }
            return ItemTypeList;
        }

        public static void OnRecvItemSort(this BagComponent self, ItemLocType itemEquipType)
        {
            List<BagInfo> ItemTypeList = self.GetItemByLoc(itemEquipType);

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            Dictionary<int, List<BagInfo>> ItemSameList = new Dictionary<int, List<BagInfo>>();
            //找出可以堆叠并且格子未放满的道具
            for (int i = 0; i < ItemTypeList.Count; i++)
            {
                BagInfo bagInfo = ItemTypeList[i];

                //最大堆叠数量
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                if (bagInfo.ItemNum == itemCof.ItemPileSum)
                {
                    continue;
                }

                if (!ItemSameList.ContainsKey(bagInfo.ItemID))
                {
                    ItemSameList[bagInfo.ItemID] = new List<BagInfo>();
                }
                ItemSameList[bagInfo.ItemID].Add(bagInfo);
            }

            foreach (var item in ItemSameList)
            {
                List<BagInfo> bagInfos = item.Value;
                if (bagInfos.Count == 1)
                {
                    continue;
                }
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfos[0].ItemID);

                int totalNum = 0;
                int needGrid = 0;
                int finalNum = 0;
                for (int i = 0; i < bagInfos.Count; i++)
                {
                    totalNum += bagInfos[i].ItemNum;
                }
                needGrid = totalNum / itemCof.ItemPileSum;
                needGrid += (totalNum % itemCof.ItemPileSum > 0 ? 1 : 0);
                finalNum = totalNum - (needGrid - 1) * itemCof.ItemPileSum;

                if (needGrid <= 0 || needGrid >= bagInfos.Count)
                {
                    LogHelper.LogDebug($"RecvItemSortError: {self.GetParent<Unit>().Id} {bagInfos[0].ItemID} {needGrid}");
                    continue;
                }
                bagInfos[needGrid - 1].ItemNum = finalNum;
                m2c_bagUpdate.BagInfoUpdate.Add(bagInfos[needGrid - 1]);
                for (int i = 0; i < needGrid - 1; i++)
                {
                    bagInfos[i].ItemNum = itemCof.ItemPileSum;
                    m2c_bagUpdate.BagInfoUpdate.Add(bagInfos[i]);
                }
                //删除后面的空格子
                for (int i = needGrid; i < bagInfos.Count; i++)
                {
                    bagInfos[i].ItemNum = 0;
                    m2c_bagUpdate.BagInfoDelete.Add(bagInfos[i]);
                }
            }

            for (int i = ItemTypeList.Count - 1; i >= 0; i--)
            {
                if (ItemTypeList[i].ItemNum == 0)
                {
                    ItemTypeList.RemoveAt(i);
                }
            }

            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);

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

                if (isBinginga == isBingingb)
                {
                    if (quliatya == quliatyb)
                    {
                        if (jianDingLva == jianDingLvb)
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

        public static void CheckValiedItem(this BagComponent self, List<BagInfo> bagInfos)
        {
            for (int i = bagInfos.Count -1; i >= 0; i--)
            {
                if (!ItemConfigCategory.Instance.Contain(bagInfos[i].ItemID))
                {
                    bagInfos.RemoveAt(i);
                }
            }
        }

        //获取自身所有的道具
        public static List<BagInfo> GetAllItems(this BagComponent self)
        {
            List<BagInfo> bagList = new List<BagInfo>();

            self.CheckValiedItem(self.GemList);
            self.CheckValiedItem(self.BagItemList);
            self.CheckValiedItem(self.BagItemPetHeXin);
            self.CheckValiedItem(self.Warehouse1);
            self.CheckValiedItem(self.Warehouse2);
            self.CheckValiedItem(self.Warehouse3);
            self.CheckValiedItem(self.Warehouse4);

            bagList.AddRange(self.GemList);
            bagList.AddRange(self.BagItemList);
            bagList.AddRange(self.BagItemPetHeXin);
            bagList.AddRange(self.EquipList);
            bagList.AddRange(self.PetHeXinList);
            bagList.AddRange(self.Warehouse1);
            bagList.AddRange(self.Warehouse2);
            bagList.AddRange(self.Warehouse3);
            bagList.AddRange(self.Warehouse4);
            bagList.AddRange(self.JianYuanWareHouse1);
            bagList.AddRange(self.JianYuanWareHouse2);
            bagList.AddRange(self.JianYuanWareHouse3);
            bagList.AddRange(self.JianYuanWareHouse4);
            return bagList;
        }

        //获取某个道具的数量[只取背包的]
        public static long GetItemNumber(this BagComponent self, int itemId)
        {
            if (itemId == (int)UserDataType.Gold)
            {
                return self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Gold;
            }
            if (itemId == (int)UserDataType.Diamond)
            {
                return self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Diamond;
            }
            if (itemId == (int)UserDataType.RongYu)
            {
                return self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.RongYu;
            }
            if (itemId == (int)UserDataType.JiaYuanFund)
            {
                return self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.JiaYuanFund;
            }

            long number = 0;
            for (int i = 0; i < self.BagItemList.Count; i++)
            {
                if (self.BagItemList[i].ItemID == itemId)
                {
                    number += self.BagItemList[i].ItemNum;
                }
            }
            return number;
        }

        public static bool IsBagFull(this BagComponent self)
        {
            return self.GetLeftSpace() <= 0;
        }

        public static int GetLeftSpace(this BagComponent self)
        {
            return self.BagAddedCell + GlobalValueConfigCategory.Instance.BagMaxCapacity - self.BagItemList.Count;
        }

        public static int GetTotalSpace(this BagComponent self)
        {
            return self.BagAddedCell + GlobalValueConfigCategory.Instance.BagMaxCapacity;
        }

        //根据ID获取对应的背包数据
        public static BagInfo GetItemByLoc(this BagComponent self, ItemLocType itemLocType, long bagId)
        {
            if (bagId == 0)
                return null;
            List<BagInfo> ItemTypeList = self.GetItemByLoc(itemLocType);
            for (int i = 0; i < ItemTypeList.Count; i++)
            {
                if (ItemTypeList[i].BagInfoID == bagId)
                {
                    return ItemTypeList[i];
                }
            }
            return null;
        }

        public static bool IsHourseFullByLoc(this BagComponent self, int hourseId)
        {
            List<BagInfo> ItemTypeList = self.GetItemByLoc((ItemLocType)hourseId);
            return ItemTypeList.Count >= self.GetStoreTotalCell(hourseId);
        }

        public static int GetStoreTotalCell(this BagComponent self, int hourseId)
        {
            return GlobalValueConfigCategory.Instance.StoreCapacity + self.WarehouseAddedCell[hourseId - 5];
        }

        public static void OnChangeItemLoc(this BagComponent self, BagInfo bagInfo, ItemLocType itemLocTypeDest, ItemLocType itemLocTypeSour)
        {
            List<BagInfo> ItemTypeListSour = self.GetItemByLoc(itemLocTypeSour);
            for (int i = ItemTypeListSour.Count - 1; i >= 0; i--)
            {
                if (ItemTypeListSour[i].BagInfoID == bagInfo.BagInfoID)
                {
                    ItemTypeListSour.RemoveAt(i);
                }
            }

            List<BagInfo> ItemTypeListDest = self.GetItemByLoc(itemLocTypeDest);
            bagInfo.Loc = (int)itemLocTypeDest;
            ItemTypeListDest.Add(bagInfo);
        }

        /// <summary>
        /// 是否有装备技能
        /// </summary>
        /// <param name="self"></param>
        /// <param name="skillId"></param>
        /// <returns></returns>
        public static bool IsHaveEquipSkill(this BagComponent self, int skillId)
        {
            for (int i = 0; i < self.EquipList.Count; i++)
            {

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.EquipList[i].ItemID);
                if (itemConfig.SkillID.Equals(skillId.ToString()))
                {
                    return true;
                }
                if ( self.EquipList[i].HideSkillLists.Contains(skillId) )
                {
                    return true;
                }
            }
            return false;
        }


        public static List<BagInfo> GetEquipListByWeizhi(this BagComponent self, int position)
        {
            List<BagInfo> bagInfos = new List<BagInfo>(); 
            for (int i = 0; i < self.EquipList.Count; i++)
            {
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(self.EquipList[i].ItemID);
                int weizhi = itemCof.ItemSubType;
                if (weizhi == position)
                {
                    bagInfos.Add(self.EquipList[i]);
                }
            }
            return bagInfos;
        }

        //获取某个装备位置的道具数据
        public static BagInfo GetEquipBySubType(this BagComponent self, int subType)
        {
            for (int i = 0; i < self.EquipList.Count; i++)
            {
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(self.EquipList[i].ItemID);
                if (itemCof.ItemSubType == subType)
                {
                    return self.EquipList[i];
                }
            }
            return null;
        }

        public static void OnLogin(this BagComponent self)
        {
            int zodiacnumber = self.GetZodiacnumber();
            self.GetParent<Unit>().GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ZodiacEquipNumber_215, 0, zodiacnumber);
        }

        public static int GetZodiacnumber(this BagComponent self)
        {
            int number = 0;
            for (int i = 0; i < self.EquipList.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.EquipList[i].ItemID);
                if (itemConfig.EquipType == 101)
                {
                    number++;
                }
            }

            return number;
        }

        public static int GetWuqiItemId(this BagComponent self)
        {
            BagInfo bagInfo = self.GetEquipBySubType((int)ItemSubTypeEnum.Wuqi);
            return bagInfo != null ? bagInfo.ItemID : 0;
        }

        public static int GetEquipType(this BagComponent self)
        {
            BagInfo bagInfo = self.GetEquipBySubType((int)ItemSubTypeEnum.Wuqi);
            return ItemHelper.GetEquipType(bagInfo!= null ? bagInfo.ItemID:0);
        }

        //字符串添加道具 
        public static bool OnAddItemData(this BagComponent self, string rewardItems, string getType, bool  notice = true)
        {
            List<RewardItem> costItems = new List<RewardItem>();
            string[] needList = rewardItems.Split('@');
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                if (itemInfo.Length < 2)
                {
                    continue;
                }
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
            }
            return self.OnAddItemData(costItems, string.Empty, getType, notice);
        }

        public static void OnAddItemData(this BagComponent self, List<BagInfo> bagInfos, string getType)
        {
            for (int i = 0; i < bagInfos.Count; i++)
            {
                self.OnAddItemData(bagInfos[i], getType);
            }
        }

        public static void OnAddItemData(this BagComponent self, BagInfo bagInfo, string getType)
        {
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            int maxPileSum = itemCof.ItemPileSum;

            if (maxPileSum > 1 || bagInfo.BagInfoID == 0)
            {
                self.OnAddItemData($"{bagInfo.ItemID};{bagInfo.ItemNum}", string.IsNullOrEmpty(bagInfo.GetWay) ? getType : bagInfo.GetWay);
            }
            else
            {
                self.BagItemList.Add(bagInfo);

                M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
                m2c_bagUpdate.BagInfoAdd.Add(bagInfo);
                //通知客户端背包道具发生改变
                MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);

                //检测任务需求道具
                ItemAddHelper.OnGetItem(self.GetParent<Unit>(), bagInfo.ItemID);
            }
        }

        public static void OnAddItemToStore(this BagComponent self, int itemlockType, int itemid, int itemnumber, string getType)
        {
            BagInfo useBagInfo = new BagInfo();
            useBagInfo.ItemID = itemid;
            useBagInfo.ItemNum = itemnumber;
            useBagInfo.Loc = itemlockType;
            useBagInfo.BagInfoID = IdGenerater.Instance.GenerateId();
            useBagInfo.GemHole = "0_0_0_0";
            useBagInfo.GemIDNew = "0_0_0_0";
            useBagInfo.GetWay = getType;
            self.GetItemByLoc((ItemLocType)useBagInfo.Loc).Add(useBagInfo);

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoAdd.Add(useBagInfo);
            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);
        }

        public static void OnAddItemDataNewCell(this BagComponent self, int itemid, int itemnumber, string getType)
        {
            BagInfo useBagInfo = new BagInfo();
            useBagInfo.ItemID = itemid;
            useBagInfo.ItemNum = itemnumber;
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(itemid);
            useBagInfo.Loc = itemCof.ItemType == (int)ItemTypeEnum.PetHeXin ? (int)ItemLocType.ItemPetHeXinBag : (int)ItemLocType.ItemLocBag;
            useBagInfo.BagInfoID = IdGenerater.Instance.GenerateId();
            useBagInfo.GemHole = "0_0_0_0";
            useBagInfo.GemIDNew = "0_0_0_0";
            useBagInfo.GetWay = getType;
            self.GetItemByLoc((ItemLocType)useBagInfo.Loc).Add(useBagInfo);

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoAdd.Add(useBagInfo);
            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);
        }

        //添加背包道具道具[支持同时添加多个]
        public static bool OnAddItemData(this BagComponent self, List<RewardItem> rewardItems, string makeUserID, string getWay, bool notice = true, bool gm = false, ItemLocType UseLocType = ItemLocType.ItemLocBag)
        {
            int bagCellNumber = 0;
            int petHeXinNumber = 0;
            int getType = int.Parse(getWay.Split('_')[0]);
            Unit unit = self.GetParent<Unit>();
            if (unit.IsRobot() && getType == ItemGetWay.PickItem)
            {
                return true;
            }

            for (int i = rewardItems.Count - 1; i >= 0; i--)
            {
                if (rewardItems[i].ItemID == 0 || !ItemConfigCategory.Instance.Contain(rewardItems[i].ItemID)) 
                { 
                    continue;
                }

                ItemConfig itemCof = ItemConfigCategory.Instance.Get(rewardItems[i].ItemID);
                UserDataType userDataType = ItemHelper.GetItemToUserDataType(rewardItems[i].ItemID);
                if (userDataType != UserDataType.None)
                {
                    continue;
                }
                int ItemPileSum = gm ? 1000000 : itemCof.ItemPileSum;
                if (UseLocType >= ItemLocType.ItemWareHouse1)
                {
                    continue;
                }
                if (itemCof.ItemType == ItemTypeEnum.PetHeXin)
                {
                    petHeXinNumber += rewardItems[i].ItemNum;
                    continue;
                }

                if (itemCof.ItemType == ItemTypeEnum.Equipment)
                {
                    ItemPileSum = itemCof.ItemPileSum;
                }
                if (ItemPileSum == 1)
                {
                    bagCellNumber += rewardItems[i].ItemNum;
                }
                else
                {
                    bagCellNumber += (int)(1f* rewardItems[i].ItemNum / ItemPileSum);
                    bagCellNumber += (rewardItems[i].ItemNum % ItemPileSum > 0 ? 1 : 0);
                }
            }
            if (rewardItems.Count == 0)
            {
                return true;
            }
            if (bagCellNumber > self.GetLeftSpace() && UseLocType == ItemLocType.ItemLocBag)
            {
                return false;
            }
            if ((petHeXinNumber + self.BagItemPetHeXin.Count > ComHelp.PetHeXinMax) && UseLocType == ItemLocType.ItemLocBag)
            {
                return false;
            }

            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = self.message;
            m2c_bagUpdate.BagInfoAdd.Clear();
            m2c_bagUpdate.BagInfoUpdate.Clear();
            m2c_bagUpdate.BagInfoDelete.Clear();    
            for (int i = rewardItems.Count - 1; i >= 0; i--)
            {
                int itemID = rewardItems[i].ItemID;
                if (itemID == 0 || !ItemConfigCategory.Instance.Contain(itemID))
                {
                    continue;
                }

                int leftNum = rewardItems[i].ItemNum;
                UserDataType userDataType = ItemHelper.GetItemToUserDataType(itemID);
                if (userDataType == UserDataType.Gold && rewardItems[i].ItemNum > 1000000)
                {
                    LogHelper.LogWarning($"[获取金币]UserDataType.Gold  {unit.Id} {unit.GetComponent<UserInfoComponent>().UserName} {rewardItems[i].ItemNum} {getType}");
                }
                if (userDataType == UserDataType.Diamond)
                {
                    LogHelper.LogWarning($"[获取钻石]UserDataType.Diamond  {unit.Id} {unit.GetComponent<UserInfoComponent>().UserName} {rewardItems[i].ItemNum} {getType}");
                }
                if (userDataType != UserDataType.None)
                {
                    unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(userDataType, leftNum.ToString(), true, getType);
                    continue;
                }

                //最大堆叠数量
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(itemID);
                if (itemCof.EquipType == 101 || itemCof.ItemQuality >= 4 || (itemCof.Id >= 16000101 && itemCof.Id<= 16000312) || (itemCof.Id >= 10030011 && itemCof.Id <= 10030019))
                {
                    LogHelper.LogWarning($"[获取道具] {unit.Id} {itemID} {rewardItems[i].ItemNum} {getType}");
                }
                if (leftNum >= 99)
                {
                    LogHelper.LogWarning($"[获取道具]leftNum >= 99  {unit.Id} {itemID} {rewardItems[i].ItemNum} {getType}");
                }

                int maxPileSum = gm ? 1000000 :  itemCof.ItemPileSum;
                ItemLocType itemLockType = ItemLocType.ItemLocBag;
                List<BagInfo> itemlist = null;
                if (itemCof.ItemType == ItemTypeEnum.Equipment)
                {
                    maxPileSum = itemCof.ItemPileSum;
                }
                if (itemCof.ItemType == ItemTypeEnum.PetHeXin)
                {
                    maxPileSum = itemCof.ItemPileSum;
                    itemLockType = ItemLocType.ItemPetHeXinBag;
                    itemlist = self.GetItemByLoc(itemLockType);
                }
                else
                {
                    itemLockType = UseLocType;
                    itemlist = self.GetItemByLoc(itemLockType);
                }

                for (int k = 0; k < itemlist.Count; k++)
                {
                    BagInfo userBagInfo = itemlist[k];
                    if (userBagInfo.ItemID != itemID)
                    {
                        continue;
                    }
                    if (userBagInfo.ItemNum >= maxPileSum)
                    {
                        continue;
                    }
                    int newNum = leftNum + userBagInfo.ItemNum;
                    if (newNum > maxPileSum)
                    {
                        leftNum = newNum - maxPileSum;
                        newNum = maxPileSum;
                    }
                    else
                    {
                        leftNum = 0;
                    }
                    userBagInfo.ItemNum = newNum;
                    m2c_bagUpdate.BagInfoUpdate.Add(userBagInfo);

                    if (leftNum == 0)
                    {
                        //跳出循环
                        break;
                    }
                }

                //还没有插入完，需要开启新格子
                while (leftNum > 0)
                {
                    BagInfo useBagInfo = new BagInfo();
                    useBagInfo.ItemID = itemID;
                    useBagInfo.ItemNum = (leftNum > maxPileSum) ? maxPileSum : leftNum;
                    useBagInfo.Loc = (int)itemLockType;
                    useBagInfo.BagInfoID = IdGenerater.Instance.GenerateId();
                    useBagInfo.GemHole = "0_0_0_0";
                    useBagInfo.GemIDNew = "0_0_0_0";
                    useBagInfo.GetWay = getWay;
                    leftNum -= useBagInfo.ItemNum;

                    //记录制造的玩家
                    useBagInfo.MakePlayer = makeUserID;
                    //蓝色品质的装备需要进行鉴定
                    if (!ItemHelper.IsBuyItem(getType) && itemCof.ItemType == 3)
                    {
                        if (itemCof.ItemQuality >= 4)
                        {
                            useBagInfo.IfJianDing = true;
                        }
                        else
                        {
                            //白色和绿色品质都是100% 紫色概率出鉴定
                            float jianDingPro = 0f;

                            if (itemCof.ItemQuality == 1)
                            {
                                jianDingPro = 0f;
                            }
                            if (itemCof.ItemQuality == 2)
                            {
                                jianDingPro = 0f;
                            }
                            if (itemCof.ItemQuality == 3)
                            {
                                jianDingPro = 0f;
                            }
                            if (itemCof.ItemQuality == 4)
                            {
                                jianDingPro = 0.75f;
                            }

                            if (RandomHelper.RandFloat() <= jianDingPro)
                            {
                                useBagInfo.IfJianDing = true;
                            }
                        }
                        int equipId = itemCof.ItemEquipID;
                        if (equipId!= 0 && EquipConfigCategory.Instance.Get(equipId).AppraisalItem == 0)
                        {
                            useBagInfo.IfJianDing = false ;
                        }

                        if (itemCof.EquipType == 101) 
                        {
                            useBagInfo.IfJianDing = false;
                        }
                    }
                    //默认洗练
                    if (!ItemHelper.IsBuyItem(getType) && itemCof.ItemEquipID != 0)
                    {
                        int xilianLevel = XiLianHelper.GetXiLianId(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu));
                        xilianLevel = xilianLevel != 0 ? EquipXiLianConfigCategory.Instance.Get(xilianLevel).XiLianLevel : 0;

                        int xilianType = 0;
                        if (getType == ItemGetWay.SkillMake || getType == ItemGetWay.TreasureMap) {
                            xilianType = 2;
                        }

                        //装备洗炼
                        ItemXiLianResult itemXiLian = new ItemXiLianResult();
                        if (itemCof.EquipType != 101)
                        {
                            itemXiLian = XiLianHelper.XiLianItem(unit, useBagInfo, xilianType, xilianLevel);
                        }
                        else
                        {
                            //生肖洗炼
                            itemXiLian = XiLianHelper.XiLianShengXiao(useBagInfo);
                        }

                        for(int skill = 0; skill < itemXiLian.HideSkillLists.Count; skill++)
                        {
                            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.EquipActiveSkillId_222, itemXiLian.HideSkillLists[skill], 1);
                        }

                        useBagInfo.XiLianHideProLists = itemXiLian.XiLianHideProLists;              //基础属性洗炼
                        useBagInfo.HideSkillLists = itemXiLian.HideSkillLists;                      //隐藏技能
                        useBagInfo.XiLianHideTeShuProLists = itemXiLian.XiLianHideTeShuProLists;    //特殊属性洗炼
                    }
                    //掉落的橙色装备默认为绑定的物品
                    if (( (getType == ItemGetWay.PickItem 
                        || getType == ItemGetWay.ChouKa) 
                        && itemCof.ItemQuality >= 5  )|| itemCof.IfLock == 1)
                    {
                        useBagInfo.isBinging = true;
                    }
                    if (getType == ItemGetWay.System)
                    {
                        useBagInfo.IfJianDing = false;
                    }
                    //藏宝图
                    if (itemCof.ItemSubType == 113 || itemCof.ItemSubType == 127)
                    {
                        ItemAddHelper.TreasureItem(unit, useBagInfo);
                    }
                    //鉴定符
                    if (itemCof.ItemSubType == 121)
                    {
                        int shuliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.MakeShuLianDu);
                        ItemAddHelper.JianDingFuItem(useBagInfo, shuliandu, getType);
                    }
                    //食物
                    if (itemCof.ItemType == 1 && itemCof.ItemSubType == 131)
                    {
                        useBagInfo.ItemPar = RandomHelper.RandomNumber(1, 100).ToString(); 
                    }
                    //家园烹饪
                    if (getType == ItemGetWay.JiaYuanCook)
                    {
                        useBagInfo.ItemPar = RandomHelper.RandomNumber(1, 100).ToString(); 
                    }
                    //拾取到橙色装备
                    if (itemCof.ItemType == 3 && itemCof.ItemQuality >= 5 && getType == ItemGetWay.PickItem)
                    {
                        string name = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
                        string noticeContent = $"恭喜玩家 {name} 获得装备: <color=#{ComHelp.QualityReturnColor(5)}>{itemCof.ItemName}</color>";
                        ServerMessageHelper.SendBroadMessage(self.DomainZone(), NoticeType.Notice, noticeContent);
                    }

                    self.GetItemByLoc((ItemLocType)useBagInfo.Loc).Add(useBagInfo);
                    m2c_bagUpdate.BagInfoAdd.Add(useBagInfo);
                }
                //检测任务需求道具
                ItemAddHelper.OnGetItem(unit, itemID);
            }

            //通知客户端背包道具发生改变
            if (notice)
            {
                MessageHelper.SendToClient(unit, m2c_bagUpdate);
            }

            return true;
        }

        public static bool CheckCostItem(this BagComponent self, string rewardItems)
        {
            string[] needList = rewardItems.Split('@');
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                if (itemInfo.Length < 2)
                {
                    continue;
                }
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                if (self.GetItemNumber(itemId) < itemNum)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckCostItem(this BagComponent self, List<RewardItem> rewardItems)
        {
            for (int i = 0; i < rewardItems.Count; i++)
            {
                RewardItem itemInfo = rewardItems[i];
                if (self.GetItemNumber(itemInfo.ItemID) < itemInfo.ItemNum)
                {
                    return false;
                }
            }
            return true;
        }

        //字符串删除道具
        public static bool OnCostItemData(this BagComponent self, string rewardItems)
        {
            List<RewardItem> costItems = new List<RewardItem>();
            string[] needList = rewardItems.Split('@');
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                if (itemInfo.Length < 2)
                {
                    continue;
                }
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
            }
            return self.OnCostItemData(costItems);
        }


        //删除背包道具道具[支持同时添加多个]
        public static bool OnCostItemData(this BagComponent self, List<long> costItems, ItemLocType itemLocType = ItemLocType.ItemLocBag)
        {
            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            List<BagInfo> ItemTypeList = self.GetItemByLoc(itemLocType);

            for (int i = 0; i < costItems.Count; i++)
            {
                for (int k = ItemTypeList.Count - 1; k >= 0; k--)
                {
                    if (ItemTypeList[k].BagInfoID == costItems[i])
                    {
                        m2c_bagUpdate.BagInfoDelete.Add(ItemTypeList[k]);
                        ItemTypeList.RemoveAt(k);
                        break;
                    }
                }
            }

            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);
            return true;
        }

        //指定某一个格子的ID
        public static bool OnCostItemData(this BagComponent self, long uid, int number)
        {
            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            List<BagInfo> ItemTypeList = self.GetItemByLoc(ItemLocType.ItemLocBag);
            for (int k = ItemTypeList.Count - 1; k >= 0; k--)
            {
                if (ItemTypeList[k].BagInfoID == uid)
                {
                    ItemTypeList[k].ItemNum -= number;

                    if (ItemTypeList[k].ItemNum <= 0)
                    {
                        m2c_bagUpdate.BagInfoDelete.Add(ItemTypeList[k]);
                        ItemTypeList.RemoveAt(k);
                    }
                    else
                    {
                        m2c_bagUpdate.BagInfoUpdate.Add(ItemTypeList[k]);
                    }
                    break;
                }
            }
            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);
            return true;
        }

        //删除背包道具道具[支持同时添加多个]
        public static bool OnCostItemData(this BagComponent self, List<RewardItem> costItems)
        {
            for (int i = costItems.Count - 1; i >= 0; i--)
            {
                int itemID = costItems[i].ItemID;
                long itemNum = costItems[i].ItemNum;

                //获取背包内的道具是否足够
                if (self.GetItemNumber(itemID) < itemNum)
                {
                    return false;
                }
            }

            //通知客户端背包刷新
            Unit unit = self.GetParent<Unit>();
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoAdd = new List<BagInfo>();

            for (int i = costItems.Count - 1; i >= 0; i--)
            {
                int itemID = costItems[i].ItemID;
                int itemNum = costItems[i].ItemNum;

                //扣除金币
                if (itemID == (int)UserDataType.Gold)
                {
                    itemNum = -1 * itemNum;
                    unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, itemNum.ToString(), true, ItemGetWay.CostItem);
                    continue;
                }
                if (itemID == (int)UserDataType.Diamond)
                {
                    itemNum = -1 * itemNum;
                    unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Diamond, itemNum.ToString(), true, ItemGetWay.CostItem);
                    continue;
                }
                if (itemID == (int)UserDataType.RongYu)
                {
                    itemNum = -1 * itemNum;
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.RongYu, itemNum.ToString());
                    continue;
                }
                if (itemID == (int)UserDataType.JiaYuanFund)
                {
                    itemNum = -1 * itemNum;
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.JiaYuanFund, itemNum.ToString());
                    continue;
                }

                LogHelper.LogWarning($"消耗道具: {unit.Id} {itemID} {itemNum}");
                for (int k = self.BagItemList.Count - 1; k >= 0; k--)
                {
                    BagInfo userBagInfo = self.BagItemList[k];
                    if (userBagInfo.ItemID == itemID)
                    {
                        if (userBagInfo.ItemNum >= itemNum)
                        {
                            //满足扣除数
                            int costNum = itemNum;
                            itemNum -= userBagInfo.ItemNum;
                            userBagInfo.ItemNum -= costNum;
                            if (userBagInfo.ItemNum <= 0)
                            {
                                m2c_bagUpdate.BagInfoDelete.Add(userBagInfo);
                                self.BagItemList.RemoveAt(k);
                            }
                            else
                            {
                                m2c_bagUpdate.BagInfoUpdate.Add(userBagInfo);
                            }
                        }
                        else
                        {
                            itemNum -= userBagInfo.ItemNum;
                            //完全删除道具
                            userBagInfo.ItemNum = 0;
                            m2c_bagUpdate.BagInfoDelete.Add(userBagInfo);
                            self.BagItemList.RemoveAt(k);
                        }

                        //扣除完道具直接跳出当前循环
                        if (itemNum <= 0)
                        {
                            break;
                        }
                    }
                }
                unit.GetComponent<TaskComponent>().OnGetItem(itemID);
            }

            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            return true;
        }

        public static int GetQiangHuaLevel(this BagComponent self, int subType)
        {
            if (subType > 1000)
            {
                return 0;
            }
            return self.QiangHuaLevel[subType];
        }

        public static void OnEquipFuMo(this BagComponent self, int itemid, int index)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            string[] itemparams = itemConfig.ItemUsePar.Split('@');
            int weizhi = int.Parse(itemparams[0]);
            List<BagInfo> bagInfos = self.GetEquipListByWeizhi(weizhi);
            if (bagInfos.Count <= index)
            {
                return;
            }
            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfos[index]);

            //9@200103; 0.03; 0.03
            bagInfos[index].FumoProLists.Clear();
            bagInfos[index].FumoProLists.AddRange( ItemHelper.GetItemFumoPro(itemid) );

            //通知客户端背包道具发生改变
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2c_bagUpdate);
            Function_Fight.GetInstance().UnitUpdateProperty_Base(self.GetParent<Unit>(), true, true);
        }

        public static bool OnCostItemData(this BagComponent self, BagInfo bagInfo, ItemLocType locType,  int number)
        {
            List<BagInfo> bagInfos = self.GetItemByLoc(locType);

            if (bagInfo.ItemNum >= number)
            {
                bagInfo.ItemNum -= number;

                if (bagInfo.ItemNum == 0)
                {
                    bagInfos.Remove(bagInfo);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}