using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPastureBuyHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPastureBuyRequest, M2C_JiaYuanPastureBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPastureBuyRequest request, M2C_JiaYuanPastureBuyResponse response, Action reply)
        {
            int mysteryId = request.MysteryItemInfo.MysteryId;
            JiaYuanPastureConfig mysteryConfig = JiaYuanPastureConfigCategory.Instance.Get(mysteryId);
            if (mysteryConfig == null)
            {
                response.Error = ErrorCore.ERR_NetWorkError;
                reply();
                return;
            }
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                response.Error = ErrorCore.ERR_NetWorkError;
                reply();
                return;
            }

            if (!unit.GetComponent<BagComponent>().CheckCostItem($"13;{mysteryConfig.BuyGold}"))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfoComponent.UserInfo.JiaYuanLv);
            if (jiaYuanComponent.GetPeopleNumber() >= jiaYuanConfig.PeopleNumMax)
            {
                response.Error = ErrorCore.ERR_PeopleNumber;
                reply();
                return;
            }

            request.MysteryItemInfo.ItemID = mysteryConfig.GetItemID;
            request.MysteryItemInfo.ItemNumber = 1;
            int errorCode = jiaYuanComponent.OnPastureBuyRequest(request.MysteryItemInfo);
            if (errorCode != ErrorCore.ERR_Success)
            {
                response.Error = errorCode;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().OnMysteryBuy(mysteryId);
            unit.GetComponent<BagComponent>().OnCostItemData($"13;{mysteryConfig.BuyGold}");
            //unit.GetComponent<BagComponent>().OnAddItemData($"{mysteryConfig.GetItemID};1", $"{ItemGetWay.MysteryBuy}_{TimeHelper.ServerNow()}");

            JiaYuanPastures jiaYuanPastures = new JiaYuanPastures()
            { 
                ConfigId = mysteryConfig.Id,
                StartTime = TimeHelper.ServerNow(),
                UnitId = IdGenerater.Instance.GenerateId(), 
            };

            UnitFactory.CreatePasture(unit.DomainScene(), jiaYuanPastures, unit.Id);
            List<JiaYuanPastures> JiaYuanPastureList_3 = unit.GetComponent<JiaYuanComponent>().JiaYuanPastureList_4;
            JiaYuanPastureList_3.Add(jiaYuanPastures);
            response.JiaYuanPastureList = JiaYuanPastureList_3;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
