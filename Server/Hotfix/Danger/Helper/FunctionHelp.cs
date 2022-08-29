
using System.Collections.Generic;
using System.Reflection;

namespace ET
{

    public class FunctionHelp : Singleton<FunctionHelp>
    {

        public delegate bool FunctionDelegate(Unit unit, int param);

        //功能开启条件判断
        public Dictionary<int, FunctionDelegate> functionCheck;

        protected override void InternalInit()
        {
            base.InternalInit();
            functionCheck = new Dictionary<int, FunctionDelegate>();
            functionCheck.Add(FunctionContionEnum.PlayerLv, CheckPlayerLv);
            functionCheck.Add(FunctionContionEnum.TaskId, CheckTaskID);
        }

        //检测函数也可以放在对应的功能模块
        public bool CheckPlayerLv(Unit unit, int parame)
        {
            return unit.GetComponent<UserInfoComponent>().UserInfo.Lv >= parame;
        }

        public bool CheckTaskID(Unit unit, int parame)
        {
            return unit.GetComponent<TaskComponent>().IsTaskComplete(parame);
        }

        public bool CheckFuncitonOn(Unit unit, FuntionConfig funtionOpenConfig)
        {
            int[] contion_1 = funtionOpenConfig.ConditionType;
            int[] contion_2 = funtionOpenConfig.ConditionParam;
            for (int i = 0; i < contion_1.Length; i++)
            {
                if (!functionCheck[contion_1[i]](unit, contion_2[i]))
                    return false;
            }
            return true;
        }

        public bool CheckTaskOn(Unit unit, TaskConfig taskConfig)
        {
            if (!functionCheck[taskConfig.TriggerType](unit, taskConfig.TriggerValue))
                return false;
            return true;
        }

    }
}
