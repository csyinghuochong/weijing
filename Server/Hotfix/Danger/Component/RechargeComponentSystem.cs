namespace ET
{

    public static class RechargeComponentSystem
    {

        public static void OnLogin(this RechargeComponent self)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            int rechageBuchang = numericComponent.GetAsInt(NumericType.RechargeBuChang);
            numericComponent.Set(NumericType.RechargeBuChang, 0);
            RechargeHelp.OnLogin(self.GetParent<Unit>(), rechageBuchang);
        }
    }
}
