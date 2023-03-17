using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class FangChenMiComponentDestroySystem : DestroySystem<FangChenMiComponent>
    {
        public override void Destroy(FangChenMiComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }


    public static class FangChenMiComponentSystem
    {

        public static async ETTask OnLoginOut(this FangChenMiComponent self)
        {
            EventType.CommonHint.Instance.HintText = "防沉迷提示:当前可游玩时间结束,请安心休息吧！稍后将立即退出游戏";
            Game.EventSystem.PublishClass(EventType.CommonHint.Instance);

            await TimerComponent.Instance.WaitAsync(10000);

            EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
            Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
        }

        public static async ETTask OnLogin(this FangChenMiComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            bool jiari = await HttpHelper.IsHolidayByDate(dateTime);
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;
            if (self.GetPlayerAge() >= 18)
            {
                return;
            }
            if (!jiari && huor != 20)
            {
                self.OnLoginOut().Coroutine();
            }
            else
            {
                int leftTime = (60 - minute) * 60 - dateTime.Second;
                long instanceid = self.InstanceId;
                await TimerComponent.Instance.WaitAsync(leftTime * 1000);
                if (instanceid != self.InstanceId)
                {
                    return;
                }
                self.OnLoginOut().Coroutine();
            }
        }

        /// <summary>
        /// 是否未成年
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetPlayerAge(this FangChenMiComponent self)
        {
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            return ComHelp.GetBirthdayAgeSex(accountInfoComponent.PlayerInfo.IdCardNo);
        }

        public static int GetMouthTotal(this FangChenMiComponent self)
        {
            int total = 0;
            DateTime dateTime = TimeHelper.DateTimeNow();
            int monsth = dateTime.Month;

            List<RechargeInfo> rechargeInfos = self.ZoneScene().GetComponent<AccountInfoComponent>().PlayerInfo.RechargeInfos;
            for (int i = 0; i < rechargeInfos.Count; i++)
            {
                dateTime = TimeInfo.Instance.ToDateTime(rechargeInfos[i].Time);
                if (monsth == dateTime.Month)
                {
                    total += rechargeInfos[i].Amount;
                }
            }

            return total;
        }

        public static int CanRechage(this FangChenMiComponent self, int number)
        {
            
            int age = self.GetPlayerAge();
            if (age < 8)
            {
                return ErrorCore.ERR_FangChengMi_Tip3;
            }
            if (age < 16)
            {
                if (number > 50)
                {
                    return ErrorCore.ERR_FangChengMi_Tip4;
                }
                if (number + self.GetMouthTotal() > 200)
                {
                    return ErrorCore.ERR_FangChengMi_Tip4;
                }
            }
            if (age < 18)
            {
                if (number > 100)
                {
                    return ErrorCore.ERR_FangChengMi_Tip5;
                    //return ErrorCore.ERR_FangChengMi_Tip3;
                }
                if (number + self.GetMouthTotal() > 400)
                {
                    return ErrorCore.ERR_FangChengMi_Tip5;
                    //return ErrorCore.ERR_FangChengMi_Tip3;
                }
            }
            return ErrorCore.ERR_Success;
        }
    }
}
