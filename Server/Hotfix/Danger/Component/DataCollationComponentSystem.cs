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

        public static void OnChouKa(this DataCollationComponent self, int choukaType)
        {
            self.ChouKaTimes += choukaType;
        }

        public static void OnPetChouKa(this DataCollationComponent self, int choukaType)
        {
            self.PetChouKaTimes += choukaType;
        }

        public static void OnPetDuiHuan(this DataCollationComponent self)
        {
            self.PetDuiHuanTimes += 1;
        }

        public static void UpdateData(this DataCollationComponent self)
        {
            Unit unit = self.GetParent<Unit>();

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            PetComponent petComponent = unit.GetComponent<PetComponent>();  
            BagComponent bagComponent = unit.GetComponent<BagComponent>();  

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

            self.PetPingfen = petComponent.GetPingfenList();

            self.UnionName = userInfoComponent.UserInfo.UnionName;

            self.JiaYuanLv = userInfoComponent.UserInfo.JiaYuanLv;

            self.JiaYuanFund = userInfoComponent.UserInfo.JiaYuanFund;

            self.PiLao = userInfoComponent.UserInfo.PiLao;

            self.Vitality = userInfoComponent.UserInfo.Vitality;

            int makeType = numericComponent.GetAsInt( NumericType.MakeType );
            self.MakeSkill = MakeHelper.GetMakeTypeName( makeType );

            self.MakeShuLianDu = numericComponent.GetAsInt( NumericType.MakeShuLianDu );

            self.PetFubenId = petComponent.GetPetFubenMax();

            self.TrialFubenId = numericComponent.GetAsInt( NumericType.TrialDungeonId );

            //self.ChouKaTimes 
            //self.PetChouKaTimes

            self.ChengZhuangNumber = ItemHelper.GetNumberByQulity(bagComponent.EquipList, 5);

            self.XiLianExp = numericComponent.GetAsInt( NumericType.ItemXiLianDu);

            self.LastSealTowerId = numericComponent.GetAsInt( NumericType.TowerOfSealArrived);


        }
    }
}
