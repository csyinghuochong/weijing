using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanInitRequest, M2C_JiaYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanInitRequest request, M2C_JiaYuanInitResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.MasterId);
            UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(unit.DomainZone(), request.MasterId);
            if (unit.Id != request.MasterId)
            {
                long gateServerId = DBHelper.GetGateServerId(unit.DomainZone());
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = request.MasterId
                    });

                //玩家在线
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    JiaYuanOperate jiaYuanOperate = new JiaYuanOperate();
                    jiaYuanOperate = new JiaYuanOperate();
                    jiaYuanOperate.OperateType = JiaYuanOperateType.Pick;
                    jiaYuanOperate.PlayerName = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
                    M2M_JiaYuanOperateMessage opmessage = new M2M_JiaYuanOperateMessage()
                    {
                        JiaYuanOperate = jiaYuanOperate,
                    };
                    MessageHelper.SendToLocationActor(request.MasterId, opmessage);
                }
                else
                {
                    jiaYuanComponent.AddJiaYuanRecord(new JiaYuanRecord()
                    {
                        OperateType = JiaYuanOperateType.Visit,
                        OperateId = 0,
                        PlayerName = unit.GetComponent<UserInfoComponent>().UserInfo.Name,
                        Time = TimeHelper.ServerNow(),
                    });
                    await DBHelper.SaveComponent(unit.DomainZone(), request.MasterId, jiaYuanComponent);
                }
            }

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
