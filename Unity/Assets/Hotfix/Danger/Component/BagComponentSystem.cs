using System;
using System.Collections.Generic;

namespace ET
{
    [ObjectSystem]
    public class BagComponentAwakeSystem : AwakeSystem<BagComponent>
    {
        public override void Awake(BagComponent self)
        {
            self.RealAddItem = true;
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
            self.BagAddedCell = r2C_Bag.BagAddedCell;
            self.WarehouseAddedCell = r2C_Bag.WarehouseAddedCell;
            self.FashionActiveIds = r2C_Bag.FashionActiveIds;
            self.FashionEquipList = r2C_Bag.FashionEquipList;
            self.SeasonJingHePlan = r2C_Bag.SeasonJingHePlan;
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
            self.RealAddItem = false;
            int loctype = (int)loc;
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 8, OperateBagID = 0, OperatePar = loctype.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            self.RealAddItem = true;

            self.OnRecvItemSort(loc);
        }

        //仓库->背包
        public static async ETTask SendPutBag(this BagComponent self, BagInfo bagInfo)
        {
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 7, OperateBagID = bagInfo.BagInfoID, OperatePar = bagInfo.Loc.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            if (self.IsDisposed)
            {
                return;
            }
            self.CheckSameId();
        }

        public static void CheckSameId(this BagComponent self)
        {
            List<long> idlist = new List<long>();

            for (int i = 0; i < self.AllItemList.Length; i++)
            {
                List<BagInfo> baglist = self.AllItemList[i];
                for (int k = 0; k < baglist.Count; k++)
                {
                    if (idlist.Contains(baglist[k].BagInfoID))
                    {
                        EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
                        EventType.ReturnLogin.Instance.ErrorCode = ErrorCode.ERR_ModifyData;
                        Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
                        return;
                    }

                    idlist.Add(baglist[k].BagInfoID);
                }
            }
        }

        //背包->仓库
        public static async ETTask SendPutStoreHouse(this BagComponent self, BagInfo bagInfo)
        {
            int houseId = self.CurrentHouse;
            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 6, OperateBagID = bagInfo.BagInfoID, OperatePar = houseId.ToString() };
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
            if (self.IsDisposed)
            {
                return;
            }
            self.CheckSameId();
        }

        /// <summary>
        /// 穿戴晶核
        /// </summary>
        /// <param name="self"></param>
        /// <param name="bagInfo"></param>
        /// <param name="operateType">1穿戴 2卸下</param>
        /// <returns></returns>
        public static async ETTask<int> SendWearJingHe(this BagComponent self, BagInfo bagInfo, int operateType, string operatePar)
        {
            try
            {
                C2M_JingHeWearRequest request = new C2M_JingHeWearRequest() { OperateBagID = bagInfo.BagInfoID, OperateType = 1, OperatePar = operatePar };
                M2C_JingHeWearResponse response = (M2C_JingHeWearResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                return response.Error;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
        }

        //穿戴装备
        public static async ETTask SendWearEquip(this BagComponent self, BagInfo bagInfo)
        {
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (self.GetEquipByItemId(bagInfo.ItemID)!=null && itemCof.ItemSubType == 5)
            {
                HintHelp.GetInstance().ShowHint("已佩戴该装备！");
                return;
            }

            //猎人单独处理
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            if (occ == 3 && itemCof.ItemSubType == (int)ItemSubTypeEnum.Wuqi)
            {
                C2M_ItemOperateWearRequest c2M_ItemOperate = new C2M_ItemOperateWearRequest() { OperateType = 3, OperateBagID = bagInfo.BagInfoID };
                M2C_ItemOperateWearResponse m2C_ItemOperate= (M2C_ItemOperateWearResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemOperate);
                if (self.IsDisposed || m2C_ItemOperate.Error > 0)
                {
                    return;
                }
            }
            else
            {
                C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 3, OperateBagID = bagInfo.BagInfoID };
                M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
                if (self.IsDisposed || r2c_roleEquip.Error > 0)
                {
                    return;
                }
            }
            string ItemModelID = "";
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (itemConfig.ItemSubType == (int)ItemSubTypeEnum.Wuqi)
            {
                ItemModelID = itemConfig.ItemModelID;
            }
            self.ZoneScene().GetComponent<AttackComponent>().UpdateComboTime();
            HintHelp.GetInstance().DataUpdate(DataType.EquipWear, ItemModelID);
        }

        //卸下装备
        public static async ETTask SendTakeEquip(this BagComponent self, BagInfo bagInfo)
        {
            //猎人单独处理
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            if (occ == 3 && itemCof.ItemSubType == (int)ItemSubTypeEnum.Wuqi)
            {
                C2M_ItemOperateWearRequest c2M_ItemOperate = new C2M_ItemOperateWearRequest() { OperateType = 4, OperateBagID = bagInfo.BagInfoID };
                M2C_ItemOperateWearResponse m2C_ItemOperate = (M2C_ItemOperateWearResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemOperate);
                if (self.IsDisposed || m2C_ItemOperate.Error > 0)
                {
                    return;
                }
            }
            else
            {
                C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 4, OperateBagID = bagInfo.BagInfoID };
                M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
                if (r2c_roleEquip.Error != 0)
                {
                    return;
                }
            }
            self.ZoneScene().GetComponent<AttackComponent>().UpdateComboTime();
            HintHelp.GetInstance().DataUpdate(DataType.EquipWear);
        }


        //商店购买
        public static async ETTask SendBuyItem(this BagComponent self, int sellId,int buyNum)
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

            C2M_StoreBuyRequest c2M_StoreBuyRequest = new C2M_StoreBuyRequest() { SellItemID = sellId,SellItemNum = buyNum };
            M2C_StoreBuyResponse r2c_roleEquip = (M2C_StoreBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_StoreBuyRequest);
        }

        public static async ETTask SendBuyBagCell(this BagComponent self, int itemlocktype)
        {
            C2M_ItemBuyCellRequest request  = new C2M_ItemBuyCellRequest() { OperateType = itemlocktype };
            M2C_ItemBuyCellResponse response = (M2C_ItemBuyCellResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error == ErrorCode.ERR_Success)
            {
                self.BagAddedCell = response.BagAddedCell;
                self.WarehouseAddedCell = response.WarehouseAddedCell;

                HintHelp.GetInstance().DataUpdate(DataType.BuyBagCell, response.GetItem);
            }
        }

      
        //出售道具
        public static async ETTask SendSellItem(this BagComponent self, BagInfo bagInfo, string parinfo)
        {
            if (bagInfo.IsProtect)
            {
                HintHelp.GetInstance().ShowHint("锁定道具不能出售!");
                return;
            }

            C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 2, OperateBagID = bagInfo.BagInfoID, OperatePar = $"{bagInfo.ItemID}_{parinfo}"};
            M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);

            if (r2c_roleEquip.Error == ErrorCode.ERR_Success)
            {
                HintHelp.GetInstance().ShowHint("出售完成!");
            }
        }


        //镶嵌宝石
        public static async ETTask<int> SendXiangQianGem(this BagComponent self, BagInfo bagInfo, string par = "")
        {
            C2M_ItemOperateGemRequest m_ItemOperateWear = new C2M_ItemOperateGemRequest() { OperateType = 9, OperateBagID = bagInfo.BagInfoID, OperatePar = par };
            M2C_ItemOperateGemResponse r2c_roleEquip = (M2C_ItemOperateGemResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);

            if (r2c_roleEquip.Error != ErrorCode.ERR_Success)
            {
                return r2c_roleEquip.Error;
            }
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> SendXieXiaGem(this BagComponent self, BagInfo bagInfo, string par = "")
        {
            C2M_ItemOperateGemRequest m_ItemOperateWear = new C2M_ItemOperateGemRequest() { OperateType = 10, OperateBagID = bagInfo.BagInfoID, OperatePar = par };
            M2C_ItemOperateGemResponse r2c_roleEquip = (M2C_ItemOperateGemResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);

            if (r2c_roleEquip.Error != ErrorCode.ERR_Success)
            {
                return r2c_roleEquip.Error;
            }
            return ErrorCode.ERR_Success;
        }

        //拆分道具
        public static async ETTask<int> SendSplitItem(this BagComponent self, BagInfo bagInfo, int splitnumber)
        {
            C2M_ItemSplitRequest  c2M_ItemSplit = new C2M_ItemSplitRequest() { OperateBagID = bagInfo.BagInfoID, OperatePar = splitnumber.ToString() };
            M2C_ItemSplitResponse m2C_ItemSplitResponse= (M2C_ItemSplitResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemSplit);
            return m2C_ItemSplitResponse.Error; 
        }

        /// <summary>
        /// 销毁道具
        /// </summary>
        /// <param name="self"></param>
        /// <param name="bagInfo"></param>
        /// <returns></returns>
        public static async ETTask<int> SendDestoryItem(this BagComponent self, BagInfo bagInfo)
        {
            C2M_ItemDestoryRequest c2M_ItemSplit = new C2M_ItemDestoryRequest() { OperateBagID = bagInfo.BagInfoID};
            M2C_ItemDestoryResponse m2C_ItemSplitResponse = (M2C_ItemDestoryResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemSplit);
            return m2C_ItemSplitResponse.Error;
        }

        public static async ETTask<int> SendFumoUse(this BagComponent self, BagInfo bagInfo, List<HideProList> hideProLists)
        {
            C2M_ItemFumoUseRequest  c2M_ItemFumo = new C2M_ItemFumoUseRequest() { OperateBagID = bagInfo.BagInfoID, FuMoProList = hideProLists };
            M2C_ItemFumoUseResponse m2C_ItemFumo = (M2C_ItemFumoUseResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemFumo);
            return m2C_ItemFumo.Error;
        }

        public static async ETTask<int> SendFumoPro(this BagComponent self, int index)
        {
            C2M_ItemFumoProRequest c2M_ItemFumo = new C2M_ItemFumoProRequest() { Index = index };
            M2C_ItemFumoProResponse m2C_ItemFumo = (M2C_ItemFumoProResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemFumo);
            return m2C_ItemFumo.Error;
        }

        /// <summary>
        /// 发送装备增幅消息
        /// </summary>
        /// <param name="self"></param>
        /// <param name="equipmentBagInfo">待增幅的装备BagInfo</param>
        /// <param name="reelBagInfo">所使用的卷轴BagInfo</param>
        /// <returns></returns>
        public static async ETTask<int> SendEquipmentIncrease(this BagComponent self,BagInfo equipmentBagInfo,BagInfo reelBagInfo)
        {
            C2M_EquipmentIncreaseRequest c2MEquipmentIncreaseRequest =
                    new C2M_EquipmentIncreaseRequest() { EquipmentBagInfo = equipmentBagInfo, ReelBagInfo = reelBagInfo };
            M2C_EquipmentIncreaseResponse m2CEquipmentIncreaseResponse =
                    (M2C_EquipmentIncreaseResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2MEquipmentIncreaseRequest);
            return m2CEquipmentIncreaseResponse.Error;
        }

        //使用道具
        public static async ETTask<int> SendUseItem(this BagComponent self, BagInfo bagInfo, string par = "")
        {
            try
            {
                UserInfoComponent infoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                int occ = infoComponent.UserInfo.Occ;
                if (itemConfig.UseOcc != 0 && itemConfig.UseOcc != occ)
                {
                    return ErrorCode.ERR_ItemOnlyUseOcc;
                }

                C2M_ItemOperateRequest m_ItemOperateWear = new C2M_ItemOperateRequest() { OperateType = 1, OperateBagID = bagInfo.BagInfoID, OperatePar = par };
                M2C_ItemOperateResponse r2c_roleEquip = (M2C_ItemOperateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_ItemOperateWear);
                if (r2c_roleEquip.Error != ErrorCode.ERR_Success)
                {
                    return r2c_roleEquip.Error;
                }

                if (itemConfig.ItemSubType == 2)
                {
                    HintHelp.GetInstance().ShowHint($"恭喜你获得{itemConfig.ItemUsePar}经验!");
                }
                if (itemConfig.ItemSubType == 16)
                {
                    EquipMakeConfig equipMake = EquipMakeConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
                    HintHelp.GetInstance().ShowHint($"恭喜你学习 {ItemConfigCategory.Instance.Get(equipMake.MakeItemID).ItemName}!");
                    infoComponent.UserInfo.MakeList.Add(int.Parse(itemConfig.ItemUsePar));
                }
                if (itemConfig.ItemSubType == 112)
                {
                    HintHelp.GetInstance().ShowHint($"恭喜你获得{r2c_roleEquip.OperatePar}经验!");
                }
                if (itemConfig.ItemSubType == 115)
                {
                    self.ZoneScene().GetComponent<PetComponent>().OnUnlockSkin(itemConfig.ItemUsePar);
                }
                if (itemConfig.ItemSubType == 125)
                {
                    self.ZoneScene().GetComponent<UserInfoComponent>().OnHorseActive(int.Parse(itemConfig.ItemUsePar), true);
                }
                if (itemConfig.ItemSubType == 128)
                {
                    self.ZoneScene().GetComponent<TitleComponent>().OnActiveTile(int.Parse(itemConfig.ItemUsePar));
                }
                if (itemConfig.ItemSubType == 129)
                {
                    self.ZoneScene().GetComponent<ChengJiuComponent>().OnActiveJingLing(int.Parse(itemConfig.ItemUsePar));
                }

                if (itemConfig.DayUseNum > 0)
                {
                    infoComponent.OnDayItemUse(itemConfig.Id);
                }

                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCode.ERR_NetWorkError;
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
                return ErrorCode.ERR_NetWorkError;
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
                ItemConfig itemConfig_a = ItemConfigCategory.Instance.Get(itemIda);
                ItemConfig itemConfig_b = ItemConfigCategory.Instance.Get(itemIdb);
                int quliatya = itemConfig_a.ItemQuality;
                int quliatyb = itemConfig_b.ItemQuality;
                int jianDingLva = itemConfig_a.ItemSubType == 121 && !string.IsNullOrEmpty(a.ItemPar) ? int.Parse(a.ItemPar) : 0;
                int jianDingLvb = itemConfig_b.ItemSubType == 121 && !string.IsNullOrEmpty(b.ItemPar) ? int.Parse(b.ItemPar) : 0;
                int dungeonida = (itemConfig_a.ItemSubType == 113 || itemConfig_a.ItemSubType == 127) ? int.Parse(a.ItemPar.Split('@')[0]) : 0;
                int dungeonidb = (itemConfig_b.ItemSubType == 113 || itemConfig_b.ItemSubType == 127) ? int.Parse(b.ItemPar.Split('@')[0]) : 0;

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
            if (self.RealAddItem)
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
                        continue;
                    }
                 
                    if (newInfo.Loc == (int)ItemLocType.ItemLocBag && newInfo.ItemNum > oldInfo.ItemNum)
                    {
                        self.ShowGetItemTip(newInfo, newInfo.ItemNum - oldInfo.ItemNum);
                    }
                    if (newInfo.Loc == (int)ItemLocType.ChouKaWarehouse)
                    {
                        HintHelp.GetInstance().DataUpdate(DataType.ChouKaWarehouseAddItem);
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
                    if (bagInfo.Loc == (int)ItemLocType.ChouKaWarehouse)
                    {
                        HintHelp.GetInstance().DataUpdate(DataType.ChouKaWarehouseAddItem);
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

        public static List<BagInfo> GetItemsByTypeAndSubType(this BagComponent self, int itemType,int itemSubType)
        {
            List<BagInfo> bagInfos = self.GetBagList();
            if (itemType == ItemTypeEnum.ALL)
                return bagInfos;

            List<BagInfo> typeList = new List<BagInfo>();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType == (int)itemType && itemConfig.ItemSubType == itemSubType)
                {
                    typeList.Add(bagInfos[i]);
                }
            }

            return typeList;
        }

        public static long GetItemNumber(this BagComponent self, int itemId)
        {
            int userDataType = ItemHelper.GetItemToUserDataType(itemId);
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            long number = 0;
            switch (userDataType)
            {
                case UserDataType.None:
                    List<BagInfo> bagInfos = self.GetBagList();
                    for (int i = 0; i < bagInfos.Count; i++)
                    {
                        if (bagInfos[i].ItemID == itemId)
                        {
                            number += bagInfos[i].ItemNum;
                        }
                    }
                    break;
                case UserDataType.Gold:
                    number = userInfo.Gold;
                    break;
                case UserDataType.Diamond:
                    number = userInfo.Diamond;
                    break;
                case UserDataType.JiaYuanFund:
                    number = userInfo.JiaYuanFund;
                    break;
                case UserDataType.UnionZiJin:
                    number = userInfo.UnionZiJin;
                    break;
                case UserDataType.SeasonCoin:
                    number = userInfo.SeasonCoin;
                    break;
                default:
                    number = 0;
                    break;
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
            long instanceid = self.InstanceId;
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

                BagInfo equipInfo = self.GetEquipBySubType(ItemLocType.ItemLocEquip, itemConfig.ItemSubType);
                if (equipInfo == null)
                {
                    await self.SendWearEquip(bagList[i]);
                    if (instanceid != self.InstanceId)
                    {
                        break;
                    }
                    continue;
                }
                if (itemConfig.UseLv > ItemConfigCategory.Instance.Get(equipInfo.ItemID).UseLv)
                {
                    await self.SendWearEquip(bagList[i]);
                    if (instanceid != self.InstanceId)
                    {
                        break;
                    }
                    continue;
                }
                await TimerComponent.Instance.WaitAsync(200);
                if (instanceid != self.InstanceId)
                {
                    break;
                }
            }
        }

        public static List<BagInfo> GetEquipList(this BagComponent self)
        {
             return self.AllItemList[(int)ItemLocType.ItemLocEquip];
        }

        public static List<BagInfo> GetEquipList_2(this BagComponent self)
        {
            return self.AllItemList[(int)ItemLocType.ItemLocEquip_2];
        }

        //字符串添加道具 
        public static bool CheckAddItemData(this BagComponent self, string rewardItems)
        {
            int cellNumber = 0;
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

                if (itemId <= (int)UserDataType.Max)
                {
                    continue;
                }
                int ItemPileSum = ItemConfigCategory.Instance.Get(itemId).ItemPileSum;
                if (ItemPileSum == 1)
                {
                    cellNumber += itemNum;
                }
                else
                {
                    cellNumber += (int)(1f * itemNum / ItemPileSum);
                    cellNumber += (itemNum % ItemPileSum > 0 ? 1 : 0);
                }
            }
            return self.GetLeftSpace() >= cellNumber;
        }

        public static int GetLeftSpace(this BagComponent self)
        {
            return self.BagAddedCell +  GlobalValueConfigCategory.Instance.BagMaxCapacity - self.GetBagList().Count;
        }

        public static int GetTotalSpace(this BagComponent self)
        {
            return self.BagAddedCell + GlobalValueConfigCategory.Instance.BagMaxCapacity;
        }

        public static int GetPetHeXinLeftSpace(this BagComponent self)
        {
            return ComHelp.PetHeXinMax - self.GetItemsByLoc(ItemLocType.ItemPetHeXinBag).Count;
        }

        public static List<BagInfo> GetCurJingHeList(this BagComponent self)
        {
            List<BagInfo> bagInfos = new List<BagInfo>();
            List<BagInfo> jingheList = self.GetItemsByLoc(  ItemLocType.SeasonJingHe );
            for (int i = 0; i < jingheList.Count; i++)
            {
                if (jingheList[i].EquipPlan == self.SeasonJingHePlan)
                {
                    bagInfos.Add(jingheList[i]);
                }
            }
            return bagInfos;
        }

        public static BagInfo GetJingHeByWeiZhi(this BagComponent self, int subType)
        {
            List<BagInfo> bagInfos = self.GetCurJingHeList();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemSubType == subType)
                {
                    return bagInfos[i];
                }
            }
            return null;
        }

        public static List<BagInfo> GetEquipListByWeizhi(this BagComponent self, int position)
        {
            List<BagInfo> bagInfos = new List<BagInfo>();
            List<BagInfo> equipList = self.GetEquipList();
            for (int i = 0; i < equipList.Count; i++)
            {
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(equipList[i].ItemID);
                if (itemCof.ItemSubType == position)
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

        public static int GetQiangHuaLevel(this BagComponent self, int subType)
        {
            if (subType > 1000)
            {
                return 0;
            }
            return self.QiangHuaLevel[subType];
        }
      
        public static BagInfo GetEquipBySubType(this BagComponent self,  ItemLocType itemLocType, int subType)
        {
            List<BagInfo> bagInfos = self.GetItemsByLoc(itemLocType);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemSubType == subType)
                {
                    return bagInfos[i];
                }
            }
            return null;
        }

        public static async ETTask RequestOneSell(this BagComponent self , ItemLocType itemLocType)
        {
            List<long> baginfoids = new List<long>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByLoc(itemLocType);

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string value = userInfoComponent.GetGameSettingValue(GameSettingEnum.OneSellSet);
            string[] setvalues = value.Split('@');  //绿色 蓝色 宝石
            string[] set2Values = userInfoComponent.GetGameSettingValue(GameSettingEnum.OneSellSet2).Split('@'); // 低级、中级、高级
            
            for (int i = 0; i < bagInfos.Count; i++)
            {
                //锁定装备不能一键出售
                if (bagInfos[i].IsProtect) {
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);

                if (itemConfig.ItemType == ItemTypeEnum.Gemstone)
                {
                    if (setvalues[2] == "1" && itemConfig.ItemQuality <= 3)
                    {
                        baginfoids.Add(bagInfos[i].BagInfoID);
                        continue;
                    }
                }

                if (itemConfig.ItemType == ItemTypeEnum.Equipment)
                {
                    if (setvalues[0] == "1" && itemConfig.ItemQuality <= 2)
                    {
                        // 绿色品质的生肖不出售
                        if (itemConfig.EquipType == 101)
                        {
                            continue;
                        }
                        baginfoids.Add(bagInfos[i].BagInfoID);
                        continue;
                    }
                    if (setvalues[1] == "1" && itemConfig.ItemQuality <= 3)
                    {
                        // 蓝色品质的生肖不出售
                        if (itemConfig.EquipType == 101)
                        {
                            continue;
                        }
                        baginfoids.Add(bagInfos[i].BagInfoID);
                        continue;
                    }
                }
                
                // 一键出售 低级、中级、高级、超级、神级
                for (int j = 0; j < 5; j++)
                {
                    if (set2Values[j] == "1")
                    {
                        if (ConfigHelper.OneSellList[j].Contains(bagInfos[i].ItemID))
                        {
                            baginfoids.Add(bagInfos[i].BagInfoID);
                            break;
                        }
                    }
                }
            }

            C2M_ItemOneSellRequest request = new C2M_ItemOneSellRequest() { BagInfoIds = baginfoids , OperateType = (int)itemLocType};
            M2C_ItemOneSellResponse response = (M2C_ItemOneSellResponse) await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }
    }
}