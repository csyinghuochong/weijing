namespace ET
{

    [ObjectSystem]
    public class DataCollationComponentAwake : AwakeSystem<DataCollationComponent>
    {
        public override void Awake(DataCollationComponent self)
        {
            self.CreateRoleTime = TimeHelper.DateTimeNow().ToString();
        }
    }


    public static class DataCollationComponentSystem
    {

        public static void Check(this DataCollationComponent self)
        {
            self.TodayOnLine++;
        }

        public static void UpdateData(this DataCollationComponent self)
        {
            Unit unit = self.GetParent<Unit>();

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            self.Name = userInfoComponent.UserInfo.Name;
            self.Lv = userInfoComponent.UserInfo.Lv;

            self.Occ = OccupationConfigCategory.Instance.Get(userInfoComponent.UserInfo.Occ).OccupationName;

            if (userInfoComponent.UserInfo.OccTwo > 0)
            {
                self.OccTwo = OccupationTwoConfigCategory.Instance.Get(userInfoComponent.UserInfo.OccTwo).OccupationName;
            }

            self.Combat = userInfoComponent.UserInfo.Combat;

            self.Gold = userInfoComponent.UserInfo.Gold;    

            self.Diamond = userInfoComponent.UserInfo.Diamond;

            self.Recharge = numericComponent.GetAsLong( NumericType.RechargeNumber );

            self.TodayOnLine = userInfoComponent.TodayOnLine;

            self.LastLoginTime = TimeHelper.DateTimeNow().ToString();

            self.MainTaskId = unit.GetComponent<TaskComponent>().GetMainTaskId();   


        }
    }
}
