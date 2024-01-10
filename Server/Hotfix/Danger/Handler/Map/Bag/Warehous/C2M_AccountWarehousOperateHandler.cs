using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_AccountWarehousOperateHandler : AMActorLocationRpcHandler<Unit, C2M_AccountWarehousOperateRequest, M2C_AccountWarehousOperateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_AccountWarehousOperateRequest request, M2C_AccountWarehousOperateResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Buy, unit.Id))
            {
                long accountId = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID;
                DBAccountInfo dBAccountWarehouse = await DBHelper.GetComponentCache<DBAccountInfo>(unit.DomainZone(), accountId);
                if (dBAccountWarehouse == null)
                {
                    response.Error = ErrorCode.ERR_NetWorkError;
                    reply();
                    return;
                }

                BagComponent bagComponent = unit.GetComponent<BagComponent>();
                switch (request.OperatateType)
                {
                    ///1放入仓库  2取出仓库 3整理仓库 
                    case 1:
                        if (dBAccountWarehouse.BagInfoList.Count >= GlobalValueConfigCategory.Instance.AccountBagMax)
                        {
                            response.Error = ErrorCode.ERR_WarehouseIsFull;
                            reply();
                            return;
                        }
                        BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
                        if (bagInfo == null)
                        {
                            response.Error = ErrorCode.ERR_ItemNotExist;
                            reply();
                            return;
                        }
                        if (bagInfo.isBinging || ItemHelper.GetGemIdList(bagInfo).Count > 0)
                        {
                            response.Error = ErrorCode.ERR_ItemUseError;
                            reply();
                            return;
                        }
                        ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                        if (itemConfig.ItemType != 3 || itemConfig.EquipType > 100)
                        {
                            response.Error = ErrorCode.ERR_ItemNotExist;
                            reply();
                            return;
                        }

                        if (dBAccountWarehouse.HaveItemById(bagInfo.BagInfoID) != -1)
                        {
                            response.Error = ErrorCode.ERR_AlreadyHave;
                            reply();
                            return;
                        }
                        dBAccountWarehouse.BagInfoList.Add(bagInfo);
                        bagComponent.OnCostItemData(new List<long>(){ bagInfo.BagInfoID }, ItemLocType.ItemLocBag);
                        break;
                    case 2:
                        if (bagComponent.GetBagLeftCell() < 1)
                        {
                            response.Error = ErrorCode.ERR_BagIsFull;
                            reply();
                            return;
                        }
                        int index = dBAccountWarehouse.HaveItemById(request.OperateBagID);
                        if (index == -1)
                        {
                            response.Error = ErrorCode.ERR_ItemNotExist;
                            reply();
                            return;
                        }
                        bagInfo = dBAccountWarehouse.BagInfoList[index];
                        dBAccountWarehouse.BagInfoList.RemoveAt(index);
                        bagComponent.OnAddItemData(bagInfo, bagInfo.GetWay);
                        break;
                    case 3:
                        ItemHelper.ItemLitSort(dBAccountWarehouse.BagInfoList);
                        break;
                    default:
                        break;
                }

                DBHelper.SaveComponent(unit.DomainZone(), unit.Id, bagComponent).Coroutine();
                DBHelper.SaveComponent(unit.DomainZone(), accountId, dBAccountWarehouse).Coroutine();
                reply();
            }
            await ETTask.CompletedTask;
        }
    }
}
