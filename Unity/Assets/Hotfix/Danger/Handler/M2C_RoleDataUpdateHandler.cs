

namespace ET
{

    //只同步自己的
    [MessageHandler]
    public class M2C_RoleDataUpdateHandler : AMHandler<M2C_RoleDataUpdate>
    {
        protected override  void Run(Session session, M2C_RoleDataUpdate message)
        {
            //UnitComponent unitComponent = session.Domain.GetComponent<UnitComponent>();
            //Log.Debug("M2C_UpdateRoleData: " + message);
            UserInfo userInfo = session.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            string updateValue = "0";

            switch (message.UpdateType)
            {
                //更新角色名称
                case (int)UserDataType.Name:
                    userInfo.Name = message.UpdateTypeValue;
                    updateValue = message.UpdateTypeValue;
                    break;
                //更新经验值
                case (int)UserDataType.Exp:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.Exp).ToString();
                    userInfo.Exp = long.Parse(message.UpdateTypeValue);
                    break;
                //更新等级
                case (int)UserDataType.Lv:
                    userInfo.Lv = int.Parse(message.UpdateTypeValue);
                    break;
                //更新金币
                case (int)UserDataType.Gold:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.Gold).ToString();
                    userInfo.Gold = long.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.RongYu:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.RongYu).ToString();
                    userInfo.RongYu = long.Parse(message.UpdateTypeValue);
                    break;
                //更新钻石
                case (int)UserDataType.Diamond:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.Diamond).ToString();
                    userInfo.Diamond = long.Parse(message.UpdateTypeValue);
                    break;
                //更新疲劳
                case (int)UserDataType.PiLao:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.PiLao).ToString();
                    userInfo.PiLao = long.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.DungeonTimes:
                    userInfo.DayFubenTimes.Clear();
                    break;
                case (int)UserDataType.HuoYue:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.HuoYue).ToString();
                    userInfo.HuoYue = long.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.Sp:
                    updateValue = (long.Parse(message.UpdateTypeValue) - userInfo.Sp).ToString();
                    userInfo.Sp = int.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.Union:
                    userInfo.UnionId = long.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.UnionName:
                    userInfo.UnionName = message.UpdateTypeValue;
                    break;
                case (int)UserDataType.Combat:
                    userInfo.Combat = int.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.Vitality:
                    updateValue = (int.Parse(message.UpdateTypeValue) - userInfo.Vitality).ToString();
                    userInfo.Vitality = int.Parse(message.UpdateTypeValue);
                    break;
            }

            //发送监听,更新当前信息显示
            HintHelp.GetInstance().DataUpdate(DataType.UpdateRoleData, $"{message.UpdateType}_{updateValue}");
        }
    }
}
