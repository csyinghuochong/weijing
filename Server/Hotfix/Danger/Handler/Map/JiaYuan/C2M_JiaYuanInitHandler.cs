using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanInitRequest, M2C_JiaYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanInitRequest request, M2C_JiaYuanInitResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();

            JiaYuanComponent jiaYuanComponent_2 = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.MasterId);
            if (unit.Id == request.MasterId)
            {
                //缓存的数据为最新数据
                jiaYuanComponent.JiaYuanMonster_2 = jiaYuanComponent_2.JiaYuanMonster_2;
                jiaYuanComponent.JiaYuanPastureList_7 = jiaYuanComponent_2.JiaYuanPastureList_7;
                jiaYuanComponent.JianYuanPlantList_7 = jiaYuanComponent_2.JianYuanPlantList_7;
                jiaYuanComponent.JiaYuanPetList_2 = jiaYuanComponent_2.JiaYuanPetList_2;
            }

            UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(unit.DomainZone(), request.MasterId);

            response.PlanOpenList = jiaYuanComponent.InitOpenList();
            response.PurchaseItemList = jiaYuanComponent.PurchaseItemList_7;
            response.LearnMakeIds = jiaYuanComponent.LearnMakeIds_7;
            response.JiaYuanPastureList = jiaYuanComponent.JiaYuanPastureList_7;
            response.JiaYuanProList = jiaYuanComponent.JiaYuanProList_7;
            response.JiaYuanDaShiTime = jiaYuanComponent.JiaYuanDaShiTime_1;
            response.JiaYuanPetList = jiaYuanComponent.JiaYuanPetList_2;

            response.JiaYuanLv = userInfoComponent.UserInfo.JiaYuanLv;
            response.MasterName = userInfoComponent.UserInfo.Name;
            reply();
        }
    }
}
