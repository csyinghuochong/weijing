namespace ET
{

    //角色信息广播
    [MessageHandler]
    public class M2C_RoleDataBroadcastHandler : AMHandler<M2C_RoleDataBroadcast>
    {
        protected override void  Run(Session session, M2C_RoleDataBroadcast message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.UnitId);
            if (unit == null)
            {
                return;
            }
            switch (message.UpdateType)
            {
                //更新角色名称
                case (int)UserDataType.Name:
                    unit.GetComponent<UnitInfoComponent>().UnitName = message.UpdateTypeValue;
                    break;
                case (int)UserDataType.Lv:
                    //int.Parse(message.UpdateTypeValue);
                    break;
                case (int)UserDataType.StallName:
                    unit.GetComponent<UnitInfoComponent>().StallName = message.UpdateTypeValue;
                    break;
                case (int)UserDataType.UnionName:
                    unit.GetComponent<UnitInfoComponent>().UnionName = message.UpdateTypeValue;
                    break;
                default:
                    break;
            }

            EventType.RoleDataBroadcase.Instance.Unit = unit;
            EventType.RoleDataBroadcase.Instance.UserDataType = (UserDataType)message.UpdateType;
            EventType.RoleDataBroadcase.Instance.UserDataValue = message.UpdateTypeValue;
            //发送监听,更新当前信息显示
            EventSystem.Instance.PublishClass(EventType.RoleDataBroadcase.Instance);
        }
    }
}
