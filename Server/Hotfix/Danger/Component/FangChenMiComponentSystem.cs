using System;

namespace ET
{

    public class FangChenMiComponentAwakeSystem : AwakeSystem<FangChenMiComponent>
    {
        public override void Awake(FangChenMiComponent self)
        {
            self.StopServer = !ComHelp.IsInnerNet();
            self.CheckHoliday().Coroutine();
        }
    }

    public class FangChenMiComponentDestroySystem : DestroySystem<FangChenMiComponent>
    {
        public override void Destroy(FangChenMiComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class FangChenMiComponentSystem
    {
        public static async ETTask CheckHoliday(this FangChenMiComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            self.IsHoliday = await HttpHelper.IsHolidayByDate(dateTime);
        }

    }
}
