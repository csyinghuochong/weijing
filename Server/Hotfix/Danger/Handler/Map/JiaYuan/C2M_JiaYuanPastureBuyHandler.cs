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
            JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(mysteryId);
            if (jiaYuanPastureConfig == null)
            {
                response.Error = ErrorCode.ERR_NetWorkError;
                reply();
                return;
            }
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.JiaYuan)
            {
                response.Error = ErrorCode.ERR_NetWorkError;
                reply();
                return;
            }

            if (!unit.GetComponent<BagComponent>().CheckCostItem($"13;{(int)(jiaYuanPastureConfig.BuyGold * 1.5f)}"))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfoComponent.UserInfo.JiaYuanLv);

            if (jiaYuanPastureConfig.BuyJiaYuanLv > jiaYuanConfig.Lv)
            {
                response.Error = ErrorCode.ERR_LvNoHigh;
                reply();
                return;
            }
            
            if (jiaYuanComponent.GetPeopleNumber() >= jiaYuanConfig.PeopleNumMax)
            {
                response.Error = ErrorCode.ERR_PeopleNumber;
                reply();
                return;
            }
            if (jiaYuanComponent.GetPeopleNumber() + jiaYuanPastureConfig.PeopleNum > jiaYuanConfig.PeopleNumMax)
            {
                response.Error = ErrorCode.ERR_PeopleNoEnough;
                reply();
                return;
            }

            if (request.ProductId != -1)
            {
                int errorCode = jiaYuanComponent.OnPastureBuyRequest(request.ProductId);
                if (errorCode != ErrorCode.ERR_Success)
                {
                    response.Error = errorCode;
                    reply();
                    return;
                }
            }
            
            unit.GetComponent<UserInfoComponent>().OnMysteryBuy(mysteryId);
            unit.GetComponent<BagComponent>().OnCostItemData($"13;{(int)(jiaYuanPastureConfig.BuyGold * 1.5f)}");
            unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.JiaYuanPastureNumber_94, 0, 1);
            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.JiaYuanPastureNumber_94, 0, 1);

            JiaYuanPastures jiaYuanPastures = new JiaYuanPastures()
            { 
                ConfigId = jiaYuanPastureConfig.Id,
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
