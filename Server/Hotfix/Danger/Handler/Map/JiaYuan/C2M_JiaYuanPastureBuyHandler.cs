using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPastureBuyHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPastureBuyRequest, M2C_JiaYuanPastureBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPastureBuyRequest request, M2C_JiaYuanPastureBuyResponse response, Action reply)
        {
            int mysteryId = request.MysteryId;
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

   
            int errorCode = jiaYuanComponent.OnPastureBuyRequest(request.ProductId);
            if (errorCode != ErrorCore.ERR_Success)
            {
                response.Error = errorCode;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().OnMysteryBuy(mysteryId);
            unit.GetComponent<BagComponent>().OnCostItemData($"13;{mysteryConfig.BuyGold}");
          
            JiaYuanPastures jiaYuanPastures = new JiaYuanPastures()
            { 
                ConfigId = mysteryConfig.Id,
                StartTime = TimeHelper.ServerNow(),
                UnitId = IdGenerater.Instance.GenerateId(), 
            };

            UnitFactory.CreatePasture(unit.DomainScene(), jiaYuanPastures, unit.Id);
            List<JiaYuanPastures> JiaYuanPastureList_3 = unit.GetComponent<JiaYuanComponent>().JiaYuanPastureList_7;
            JiaYuanPastureList_3.Add(jiaYuanPastures);

            DBHelper.SaveComponent( unit.DomainZone(), unit.Id, jiaYuanComponent ).Coroutine();
            response.JiaYuanPastureList = JiaYuanPastureList_3;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
