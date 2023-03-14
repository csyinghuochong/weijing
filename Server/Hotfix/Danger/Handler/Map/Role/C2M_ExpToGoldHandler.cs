using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ExpToGoldHandler : AMActorLocationRpcHandler<Unit, C2M_ExpToGoldRequest, M2C_ExpToGoldResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ExpToGoldRequest request, M2C_ExpToGoldResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            UserInfo userInfo = userInfoComponent.UserInfo;
            ServerInfo serverInfo = unit.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo;
            if (userInfo.Lv < serverInfo.WorldLv)
            {
                response.Error = ErrorCore.ERR_LevelNoEnough;
                reply();
                return;
            }

            //满级经验兑换效验等级
            GlobalValueConfig globalCof = GlobalValueConfigCategory.Instance.Get(41);
            if (request.OperateType == 2) {
                if (userInfo.Lv < globalCof.Value2) {
                    response.Error = ErrorCore.ERR_LevelNoEnough;
                    reply();
                    return;
                }
            }

            //低于20%经验无法兑换
            ExpConfig expCof = ExpConfigCategory.Instance.Get(userInfo.Lv);
            int costExp = (int)(expCof.UpExp * 0.2f);
            if (userInfo.Exp < costExp||costExp <= 0)
            {
                response.Error = ErrorCore.ERR_LevelNoEnough;
                reply();
                return;
            }

            switch (request.OperateType)
            {
                case 0:
                case 1:
                    int sendGold = (int)(10000 + expCof.RoseGoldPro * 10);
                    userInfoComponent.UpdateRoleMoneyAdd(UserDataType.Gold, sendGold.ToString(), true, 32);
                    userInfoComponent.UpdateRoleData(UserDataType.Exp, (costExp * -1).ToString());
                    Log.Debug($"Gold:  {userInfoComponent.Id} {sendGold} excharge");

                    sendGold = (int)(10000 + expCof.RoseGoldPro * 10);
                    userInfoComponent.UpdateRoleMoneyAdd(UserDataType.Gold, sendGold.ToString(), true, 32);
                    userInfoComponent.UpdateRoleData(UserDataType.Exp, (costExp * -1).ToString());
                    Log.Debug($"Gold:  {userInfoComponent.Id} {sendGold} excharge");
                    break;
                case 2:
                    string[] droplist = GlobalValueConfigCategory.Instance.Get(81).Value.Split(';');
                    int dropid = int.Parse(droplist[0]);
                    List<RewardItem> rewardItems = new List<RewardItem>();
                    DropHelper.DropIDToDropItem_2(dropid, rewardItems);
                    break;
                default:
                    break;
            }
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.ExpToGoldTimes, 1, 0);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
