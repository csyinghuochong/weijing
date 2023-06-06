using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanCookBookOpenHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanCookBookOpen, M2C_JiaYuanCookBookOpen>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanCookBookOpen request, M2C_JiaYuanCookBookOpen response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(request.LearnMakeId);
            long needzijin = JiaYuanHelper.GetCookBookCost(itemCof.UseLv);

            if (userInfoComponent.UserInfo.JiaYuanFund < needzijin)
            {
                response.Error = ErrorCore.ERR_HouBiNotEnough;
                reply();
                return;
            }

            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            if (jiaYuanComponent.LearnMakeIds_7.Contains(request.LearnMakeId))
            {
                response.Error = ErrorCore.ERR_AlreadyLearn;
                reply();
                return;
            }

            jiaYuanComponent.LearnMakeIds_7.Add(request.LearnMakeId);
            userInfoComponent.UpdateRoleData(  UserDataType.JiaYuanFund, (needzijin * -1).ToString() );
            DBHelper.SaveComponent(unit.DomainZone(), unit.Id, jiaYuanComponent).Coroutine();

            response.LearnMakeIds = jiaYuanComponent.LearnMakeIds_7;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
