using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_SkillJueXingHandler : AMActorLocationRpcHandler<Unit, C2M_SkillJueXingRequest, M2C_SkillJueXingResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_SkillJueXingRequest request, M2C_SkillJueXingResponse response, Action reply)
        {
            //判断条件
            OccupationJueXingConfig occupationJueXingConfig = OccupationJueXingConfigCategory.Instance.Get(request.JueXingId);
            if (occupationJueXingConfig == null)
            {
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong(NumericType.JueXingExp) < occupationJueXingConfig.costExp)
            {
                response.Error = ErrorCore.ERR_ExpNoEnough;
                reply();
                return;
            }

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Gold < occupationJueXingConfig.costGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.CheckCostItem(occupationJueXingConfig.costItem))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            SkillSetComponent skillSetComponent = unit.GetComponent<SkillSetComponent>();       

            bool preerror = false;
            if (occupationJueXingConfig.Pre_Condition!=null)
            {
                for (int i = 0; i < occupationJueXingConfig.Pre_Condition.Length; i++)
                {
                    SkillPro skillPro = skillSetComponent.GetBySkillID(occupationJueXingConfig.Pre_Condition[i]);
                    if (skillPro == null)
                    {
                        preerror = true;
                        break;
                    }
                }
            }
            if (preerror)
            {
                response.Error = ErrorCore.Pre_Condition_Error;
                reply();
                return;
            }

            numericComponent.ApplyValue(NumericType.JueXingExp, 0);

            userInfoComponent.UpdateRoleMoneySub(  UserDataType.Gold,(occupationJueXingConfig.costGold * -1).ToString(), true, ItemGetWay.JueXing  );

            bagComponent.OnCostItemData( occupationJueXingConfig.costItem );

            //增加技能
            skillSetComponent.OnJueXing( request.JueXingId );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
