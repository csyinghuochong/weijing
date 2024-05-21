using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_DungeonHappyMoveHandler : AMActorLocationRpcHandler<Unit, C2M_DungeonHappyMoveRequest, M2C_DungeonHappyMoveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_DungeonHappyMoveRequest request, M2C_DungeonHappyMoveResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();

            if (request.OperatateType != 1 && request.OperatateType != 2 && request.OperatateType != 3)
            {
                Log.Error($"C2M_DungeonHappyMoveRequest.1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (request.OperatateType == 1)
            {
                if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HappyMoveNumber) >= 5)
                {
                    response.Error = ErrorCode.ERR_TimesIsNot;
                    reply();
                    return;
                }

                //非免费时间则返回
                long happmoveTime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.HappyMoveTime);
                if (TimeHelper.ServerNow() < happmoveTime)
                {
                    response.Error = ErrorCode.ERR_HappyMove_CD;
                    reply();
                    return;
                }

                long mianfeicd = TimeHelper.Second * 5 ;
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HappyMoveTime, TimeHelper.ServerNow() + mianfeicd);
                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.HappyMoveNumber,1, 0);
            }
            if (request.OperatateType == 2)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(94);
                if (userInfoComponent.UserInfo.Gold < globalValueConfig.Value2)
                {
                    response.Error = ErrorCode.ERR_GoldNotEnoughError;
                    reply();
                    return;
                }
                userInfoComponent.UpdateRoleMoneySub(UserDataType.Gold, (globalValueConfig.Value2 * -1).ToString(), true, ItemGetWay.HappyMove);
            }
            if (request.OperatateType == 3)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(95);
                if (userInfoComponent.UserInfo.Diamond < globalValueConfig.Value2)
                {
                    response.Error = ErrorCode.ERR_DiamondNotEnoughError;
                    reply();
                    return;
                }
                userInfoComponent.UpdateRoleMoneySub(UserDataType.Diamond, (globalValueConfig.Value2 * -1).ToString(), true, ItemGetWay.HappyMove);
            }

            for (int r = 10; r > 0; r--)
            {
                int newCell = RandomHelper.RandomNumber(0, HappyHelper.PositionList.Count);

                bool haveorange = false;
                List<Unit> droplist = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.DropItem);
                for (int i = 0; i < droplist.Count; i++)
                {
                    int itemid = droplist[i].GetComponent<DropComponent>().ItemID;
                    if (ItemConfigCategory.Instance.Get(itemid).ItemQuality >= 5)
                    {
                        haveorange = true;
                        break;
                    }
                }
                
                //遇到橙色道具真实随机率 30%在当前橙色格子
                if (haveorange && r > 1 && RandomHelper.RandFloat01() > 0.3f)
                {
                    continue;
                }

                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HappyCellIndex, newCell + 1);
                Vector3 vector3 = HappyHelper.PositionList[newCell];
                unit.Position = vector3;
                break;
            }

            unit.Stop(-2);
            reply();
            await ETTask.CompletedTask;
        }
    }
}