using System;
using System.Collections.Generic;

namespace ET
{
    [ObjectSystem]
    public class BagComponentAwakeSystem : AwakeSystem<BagComponent>
    {
        public override void Awake(BagComponent self)
        {
            self.ShowTip = true;
            self.AllItemList = new List<BagInfo>[(int)ItemLocType.ItemLocMax];
            for (int i = 0; i < (int)ItemLocType.ItemLocMax; i++)
            {
                self.AllItemList[i] = new List<BagInfo>();
            }
        }
    }

    public static class BagComponentSystem
    {
        //获取所有物品
        public static async ETTask GetAllBagItem(this BagComponent self)
        {
            Actor_ItemInitResponse r2C_Bag = (Actor_ItemInitResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(new Actor_ItemInitRequest());
            for (int i = 0; i < r2C_Bag.BagInfos.Count; i++)
            {
                int Loc = r2C_Bag.BagInfos[i].Loc;
                List<BagInfo> bagList = self.AllItemList[Loc];
                bagList.Add(r2C_Bag.BagInfos[i]);
            }
            self.QiangHuaLevel = r2C_Bag.QiangHuaLevel;
            self.QiangHuaFails = r2C_Bag.QiangHuaFails;
            HintHelp.GetInstance().DataUpdate(DataType.BagItemUpdate);
        }

        //回收
        public static async ETTask SendHuiShou(this BagComponent self, List<long> huishouList)
        {
            C2M_ItemHuiShouRequest c2M_ItemHuiShouRequest = new C2M_ItemHuiShouRequest() { OperateBagID = huishouList };
            M2C_ItemHuiShouResponse r2c_roleEquip = (M2C_ItemHuiShouResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);

            HintHelp.GetInstance().DataUpdate(DataType.EquipHuiShow);
        }

        //排序
        public static async ETTask SendSortByLoc(this BagComponent self, ItemLocType loc)
        {
            self.ShowTip = false;
            int loctype = (int)loc;
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 8, OperateBagID = 0, OperatePar = loctype.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            self.ShowTip = true;

            self.OnRecvItemSort(loc);
        }

        //仓库->背包
        public static async ETTask SendPutBag(this BagComponent self, BagInfo bagInfo)
        {
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 7, OperateBagID = bagInfo.BagInfoID, OperatePar = bagInfo.Loc.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
        }

        //背包->仓库
        public static async ETTask SendPutStoreHouse(this BagComponent self, BagInfo bagInfo)
        {
            int houseId = self.CurrentHouse;
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 6, OperateBagID = bagInfo.BagInfoID, OperatePar = houseId.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
        }

        //穿戴装备
        public static async ETTask SendWearEquip(this BagComponent self, BagInfo bagInfo)
        {
            if (self.GetEquipByItemId(bagInfo.ItemID)!=null)
            {
                HintHelp.GetInstance().ShowHint("已佩戴该装备！");
                return;
            }

            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            int weizhi = itemCof.ItemSubType;

            //获取之前的位置是否有装备
            //BagInfo beforeequip = self.GetEquipByWeizhi(weizhi);

            //获取之前的位置是否有装备
            BagInfo beforeequip = null;
            AccountInfoComponent accountInfo = self.ZoneScene().GetComponent<AccountInfoComponent>();
            if (weizhi == (int)ItemSubTypeEnum.Shiping && !ComHelp.IsBanHaoZone(accountInfo.CurrentServerId))
            {
                List<BagInfo> equipList = self.GetEquipListByWeizhi(weizhi);
                beforeequip = equipList.Count < 3 ? null : equipList[0];
            }
            else
            {
                beforeequip = self.GetEquipByWeizhi(weizhi);
            }

            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 3, OperateBagID = bagInfo.BagInfoID };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            if (r2c_roleEquip.Error > 0)
            {
                HintHelp.GetInstance().ShowHint("角色等级不足");
                return;
            }

            if (beforeequip != null)
            {
                self.ZoneScene().GetComponent<SkillSetComponent>().OnTakeOffEquip(beforeequip);
            }
            self.ZoneScene().GetComponent<SkillSetComponent>().OnWearEquip(bagInfo);

            string ItemModelID = "";
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (itemConfig.ItemSubType == (int)ItemSubTypeEnum.Wuqi)
            {
                ItemModelID = itemConfig.ItemModelID;
            }

            self.ZoneScene().GetComponent<AttackComponent>().UpdateComboTime();
            HintHelp.GetInstance().DataUpdate(DataType.EquipWear, ItemModelID);
        }

        //商店购买
        public static async ETTask SendBuyItem(this BagComponent self, int sellId)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(sellId);

            int costType = storeSellConfig.SellType;
            if (self.GetLeftSpace() == 0)
            {
                HintHelp.GetInstance().ShowHint("背包已满");
                return;
            }
            if (costType == 1 && userInfo.Gold < storeSellConfig.SellValue)
            {
                HintHelp.GetInstance().ShowHint("金币不足");
                return;
            }
            if (costType == 3 && userInfo.Diamond < storeSellConfig.SellValue)
            {
                HintHelp.GetInstance().ShowHint("钻石不足");
                return;
            }
            if (self.GetItemNumber(costType) < storeSellConfig.SellValue)
            {
                HintHelp.GetInstance().ShowHint("道具不足");
                return;
            }

            C2M_StoreBuyRequest c2M_StoreBuyRequest = new C2M_StoreBuyRequest() { SellItemID = sellId };
            M2C_StoreBuyResponse r2c_roleEquip = (M2C_StoreBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_StoreBuyRequest);
        }

        //卸下装备
        public static async ETTask SendTakeEquip(this BagComponent self, BagInfo bagInfo)
        {
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 4, OperateBagID = bagInfo.BagInfoID };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);

            if (r2c_roleEquip.Error != 0)
            {
                return;
            }
            self.ZoneScene().GetComponent<SkillSetComponent>().OnTakeOffEquip(bagInfo);
            self.ZoneScene().GetComponent<AttackComponent>().UpdateComboTime();
            HintHelp.GetInstance().DataUpdate(DataType.EquipWear);
        }

        //出售道具
        public static async ETTask SendSellItem(this BagComponent self, BagInfo bagInfo)
        {
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 2, OperateBagID = bagInfo.BagInfoID, OperatePar = bagInfo.ItemID.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
        }


        //镶嵌宝石
        public static async ETTask<int> SendXiangQianGem(this BagComponent self, BagInfo bagInfo, string par = "")
        {
            C2M_ItemOperateGemRequest m_ItemOperateWear = new C2M_ItemOperateGemRequest() { OperateType = 9, OperateBagID = bagInfo.BagInfoID, OperatePar = par };
            M2C_ItemOperateGemResponse r2c_roleEquip = (M2C_ItemOperateGemResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);

            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return r2c_roleEquip.Error;
            }
            return ErrorCore.ERR_Success;
        }

        public static async ETTask<int> SendXieXiaGem(this BagComponent self, BagInfo bagInfo, string par = "")
        {
            C2M_ItemOperateGemRequest m_ItemOperateWear = new C2M_ItemOperateGemRequest() { OperateType = 10, OperateBagID = bagInfo.BagInfoID, OperatePar = par };
            M2C_ItemOperateGemResponse r2c_roleEquip = (M2C_ItemOperateGemResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);

            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return r2c_roleEquip.Error;
            }
            return ErrorCore.ERR_Success;

        }

        //使用道具
        public static async ETTask<int> SendUseItem(this BagComponent self, BagInfo bagInfo, string par = "")
        {
            try
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
                if (itemConfig.UseOcc != 0 && itemConfig.UseOcc != occ)
                {
                    return ErrorCore.ERR_ItemOnlyUseOcc;
                }

                C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 1, OperateBagID = bagInfo.BagInfoID, OperatePar = par };
                M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
                if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
                {
                    return r2c_roleEquip.Error;
                }

                if (itemConfig.ItemSubType == 2)
                {
                    HintHelp.GetInstance().ShowHint($"恭喜你获得{itemConfig.ItemUsePar}经验!");
                }
                if (itemConfig.ItemSubType == 112)
                {
                    HintHelp.GetInstance().ShowHint($"恭喜你获得{r2c_roleEquip.OperatePar}经验!");
                }
                //永久技能
                if (itemConfig.ItemSubType == 107)
                {
                    self.ZoneScene().GetComponent<SkillSetComponent>().OnAddSkill(SkillSourceEnum.Book, int.Parse(itemConfig.ItemUsePar));
                }
                if (itemConfig.ItemSubType == 115)
                {
                    self.ZoneScene().GetComponent<PetComponent>().OnUnlockSkin(itemConfig.ItemUsePar);
                }

                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        //JianDing道具
        public static async ETTask<int> SendAppraisalItem(this BagComponent self, BagInfo bagInfo, long appID = 0)
        {
            try
            {
                C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 5, OperateBagID = bagInfo.BagInfoID, OperatePar = appID.ToString() };
                M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCore.ERR_NetWorkError;
            }
        }

        private static List<BagInfo> GetItemListByItem(this BagComponent self, int loc)
        {
            return self.AllItemList[loc];
        }

        public static BagInfo GetBagInfo(this BagComponent self, int itemId)
        {
            for (int i = 0; i < self.AllItemList.Length; i++)
            {
                List<BagInfo> baglist = self.AllItemList[i];
                for (int k = 0; k < baglist.Count; k++)
                {
                    if (baglist[k].ItemID == itemId)
                    {
                        return baglist[k];
                    }
                }
            }
            return null;
        }

        public static BagInfo GetBagInfo(this BagComponent self, long id)
        {
            for (int i = 0; i < self.AllItemList.Length; i++)
            {
                List<BagInfo> baglist = self.AllItemList[i];
                for (int k = 0; k < baglist.Count; k++)
                {
                    if (baglist[k].BagInfoID == id)
                    {
                        return baglist[k];
                    }
                }
            }
            return null;
        }

        public static void OnRecvItemSort(this BagComponent self, ItemLocType itemEquipType)
        {
            List<BagInfo> ItemTypeList = self.GetItemsByLoc(itemEquipType);

            ItemTypeList.Sort(delegate (BagInfo a, BagInfo b)
            {
                int itemIda = a.ItemID;
                int itemIdb = b.ItemID;
                int isBinginga = a.isBinging ? 1 : 0;
                int isBingingb = b.isBinging ? 1 : 0;
                int quliatya = ItemConfigCategory.Instance.Get(itemIda).ItemQuality;
                int quliatyb = ItemConfigCategory.Instance.Get(itemIdb).ItemQuality;
                if (isBinginga == isBingingb)
                {
                    if (quliatya == quliatyb)
                    {
                        if (itemIda == itemIdb)
                            return b.ItemNum - a.ItemNum;
                        else
                            return itemIda - itemIdb;
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

            HintHelp.GetInstance().DataUpdate(DataType.BagItemUpdate);
        }

        public static void ShowGetItemTip(this BagComponent self, BagInfo bagInfo, int addNum)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (itemConfig.IfAutoUse == 1)
            {
                self.SendUseItem( bagInfo).Coroutine();
                return;
            }
            if (self.ShowTip)
            {
                self.ZoneScene().GetComponent<ShoujiComponent>().OnGetItem(bagInfo.ItemID);
                HintHelp.GetInstance().DataUpdate(DataType.BagItemAdd, $"{bagInfo.ItemID}_{addNum}");
            }
        }

        public static void OnRecvBagUpdate(this BagComponent self, M2C_RoleBagUpdate message)
        {
            var bagUpdate = message.BagInfoUpdate;
            var bagAdd = message.BagInfoAdd;
            var bagDelete = message.BagInfoDelete;

            if (bagUpdate != null && bagUpdate.Count > 0)
            {
                for (int i = 0; i < bagUpdate.Count; i++)
                {
                    BagInfo newInfo = bagUpdate[i];
                    BagInfo oldInfo = self.GetBagInfo(bagUpdate[i].BagInfoID);
                    if (oldInfo == null)
                    {
                        Log.ILog.Debug($"oldInfo == null {newInfo.ItemID}");
                        continue;
                    }
                 
                    if (newInfo.Loc == (int)ItemLocType.ItemLocBag && newInfo.ItemNum > oldInfo.ItemNum)
                    {
                        self.ShowGetItemTip(newInfo, newInfo.ItemNum - oldInfo.ItemNum);
                    }
                    if (oldInfo.Loc != newInfo.Loc)
                    {
                        List<BagInfo> oldTemp = self.GetItemListByItem(oldInfo.Loc);
                        for (int k = oldTemp.Count - 1; k >= 0; k--)
                        {
                            if (oldTemp[k].BagInfoID == newInfo.BagInfoID)
                            {
                                oldTemp.RemoveAt(k);
                                break;
                            }
                        }

                        List<BagInfo> temp = self.GetItemListByItem(newInfo.Loc);
                        temp.Add(bagUpdate[i]);
                    }
                    else
                    {
                        List<BagInfo> temp = self.GetItemListByItem(newInfo.Loc);
                        for (int k = 0; k < temp.Count; k++)
                        {
                            if (temp[k].BagInfoID == newInfo.BagInfoID)
                            {
                                temp[k] = newInfo;
                                break;
                            }
                        }
                    }
                }
            }

            if (bagAdd != null && bagAdd.Count > 0)
            {
                for (int i = 0; i < bagAdd.Count; i++)
                {
                    BagInfo bagInfo = bagAdd[i];
                    if (bagInfo.Loc == (int)ItemLocType.ItemLocBag)
                    {
                        self.ShowGetItemTip(bagInfo, bagInfo.ItemNum);
                    }
                    List<BagInfo> temp = self.GetItemListByItem(bagInfo.Loc);
                    temp.Add(bagInfo);
                }
            }

            if (bagDelete != null && bagDelete.Count > 0)
            {
                for (int i = 0; i < bagDelete.Count; i++)
                {
                    List<BagInfo> temp = self.GetItemListByItem(bagDelete[i].Loc);
                    for (int k = temp.Count - 1; k >= 0; k--)
                    {
                        if (temp[k].BagInfoID == bagDelete[i].BagInfoID)
                        {
                            temp.RemoveAt(k);
                            break;
                        }
                    }
                }
            }
            HintHelp.GetInstance().DataUpdate(DataType.BagItemUpdate);
        }

        public static List<BagInfo> GetItemsByType(this BagComponent self, int itemType)
        {
            List<BagInfo> bagInfos = self.GetBagList();
            if (itemType == ItemTypeEnum.ALL)
                return bagInfos;

            List<BagInfo> typeList = new List<BagInfo>();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType == (int)itemType)
                {
                    typeList.Add(bagInfos[i]);
                }
            }

            return typeList;
        }

        public static long GetItemNumber(this BagComponent self, int itemId)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (itemId == (int)UserDataType.Gold)
            {
                return userInfo.Gold;
            }
            if (itemId == (int)UserDataType.Diamond)
            {
                return userInfo.Diamond;
            }

            long number = 0;
            List<BagInfo> bagInfos = self.GetBagList();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (bagInfos[i].ItemID == itemId)
                {
                    number += bagInfos[i].ItemNum;
                }
            }
            return number;
        }

        //检测
        public static bool CheckNeedItem(this BagComponent self, string needitems)
        {
            string[] needList = needitems.Split('@');

            List<RewardItem> costItems = new List<RewardItem>();
            for (int i = 0; i < needList.Length; i++)
            {
                string[] itemInfo = needList[i].Split(';');
                int itemId = int.Parse(itemInfo[0]);
                int itemNum = int.Parse(itemInfo[1]);
                costItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNum });
            }
            return self.CheckNeedItem(costItems);
        }

        public static bool CheckNeedItem(this BagComponent self, List<RewardItem> costItems)
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
            return true;
        }

        public static List<BagInfo> GetItemsByLoc(this BagComponent self, ItemLocType itemLocType)
        {
            return self.AllItemList[(int)itemLocType];
        }

        public static List<BagInfo> GetBagList(this BagComponent self)
        {
            return self.AllItemList[(int)ItemLocType.ItemLocBag];
        }

        public static bool IsHaveEquipSkill(this BagComponent self, int skillId)
        {
            List<BagInfo> equipList = self.GetEquipList();
            for (int i = 0; i < equipList.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipList[i].ItemID);
                if (itemConfig.SkillID.Equals(skillId.ToString()))
                {
                    return true;
                }
                if (equipList[i].HideSkillLists.Contains(skillId))
                {
                    return true;
                }
            }
            return false;
        }

        public static async ETTask CheckEquipList(this BagComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            List<BagInfo> bagList = new List<BagInfo>();
            bagList.AddRange( self.GetBagList() );
            for (int i = bagList.Count - 1; i >= 0; i--)
            {
                if (bagList[i].IfJianDing)
                {
                    continue;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagList[i].ItemID);
                if (itemConfig.ItemType != (int)ItemTypeEnum.Equipment)
                {
                    continue;
                }
                if (userInfoComponent.UserInfo.Lv < itemConfig.UseLv)
                {
                    continue;
                }

                BagInfo equipInfo = self.GetEquipByWeizhi(itemConfig.ItemSubType);
                if (equipInfo == null)
                {
                    Log.ILog.Debug($"SendWearEquip1:  {bagList[i].ItemID}");
                    await self.SendWearEquip(bagList[i]);
                    continue;
                }
                if (itemConfig.UseLv > ItemConfigCategory.Instance.Get(equipInfo.ItemID).UseLv)
                {
                    Log.ILog.Debug($"Behaviour_Attack: SendWearEquip2:  {bagList[i].ItemID}   {equipInfo.ItemID}");
                    await self.SendWearEquip(bagList[i]);
                    continue;
                }
            }
        }

        public static async ETTask CheckYaoShui(this BagComponent self)
        {
            List<BagInfo> bagList = self.GetBagList();
            if (bagList.Count >= ComHelp.BagMaxCapacity())
            {
                await self.SendSellItem(bagList[0]);
            }

            //购买生命药水
            int lv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int itemId = 10010001;
            int storeId = 10001101;
            if (self.GetItemNumber(itemId) < 20)
            {
                Log.ILog.Debug("Behaviour_Attack: SendBuyYaoShui");
                await self.SendBuyItem(storeId);
                await self.SendBuyItem(storeId);
                await self.SendBuyItem(storeId);
                await self.SendBuyItem(storeId);
                await self.SendBuyItem(storeId);
            }
        }

        public static List<BagInfo> GetEquipList(this BagComponent self)
        {
             return self.AllItemList[(int)ItemLocType.ItemLocEquip];
        }

        //字符串添加道具 
        public static bool OnAddItemData(this BagComponent self, string rewardItems)
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
            return self.OnAddItemData(costItems);
        }

        public static bool OnAddItemData(this BagComponent self, List<RewardItem> rewardItems)
        {
            int cellNumber = 0;
            for (int i = rewardItems.Count - 1; i >= 0; i--)
            {
                if (rewardItems[i].ItemID <= (int)UserDataType.Max)
                {
                    continue;
                }
                int ItemPileSum = ItemConfigCategory.Instance.Get(rewardItems[i].ItemID).ItemPileSum;
                if (ItemPileSum == 1)
                {
                    cellNumber += rewardItems[i].ItemNum;
                }
                else
                {
                    cellNumber += (int)(1f * rewardItems[i].ItemNum / ItemPileSum);
                    cellNumber += (rewardItems[i].ItemNum % ItemPileSum > 0 ? 1 : 0);
                }
            }
            if (cellNumber + self.GetBagList().Count > ComHelp.BagMaxCapacity())
                return false;
            return true;
        }

        public static int GetLeftSpace(this BagComponent self)
        {
            return ComHelp.BagMaxCapacity() - self.GetBagList().Count;
        }

        public static int GetPetHeXinLeftSpace(this BagComponent self)
        {
            return ComHelp.PetHeXinMax - self.GetItemsByLoc(ItemLocType.ItemPetHeXinBag).Count;
        }

        public static int GetWuqiItemID(this BagComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int itemId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
            return itemId;
        }

        public static int GetEquipType(this BagComponent self)
        {
            return ComHelp.GetEquipType(self.GetWuqiItemID());
        }

        public static List<BagInfo> GetEquipListByWeizhi(this BagComponent self, int position)
        {
            List<BagInfo> bagInfos = new List<BagInfo>();
            List<BagInfo> equipList = self.GetEquipList();
            for (int i = 0; i < equipList.Count; i++)
            {
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(equipList[i].ItemID);
                int weizhi = itemCof.ItemSubType;
                if (weizhi == position)
                {
                    bagInfos.Add(equipList[i]);
                }
            }
            return bagInfos;
        }

        public static BagInfo GetEquipByItemId(this BagComponent self, int itemId)
        {
            List<BagInfo> bagInfos = self.GetEquipList();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (bagInfos[i].ItemID == itemId)
                {
                    return bagInfos[i];
                }
            }
            return null;
        }

        public static BagInfo GetEquipByWeizhi(this BagComponent self, int pos)
        {
            List<BagInfo> bagInfos = self.GetEquipList();
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
    }
}