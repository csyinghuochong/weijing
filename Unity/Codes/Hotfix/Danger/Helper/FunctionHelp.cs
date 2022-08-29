
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ET
{

    public class FunctionHelp : Singleton<FunctionHelp>
    {
        public delegate bool FunctionDelegate(Scene unit, int param);

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
        public  bool CheckPlayerLv(Scene zongScene, int parame)
        {
            return zongScene.GetComponent<UserInfoComponent>().UserInfo.Lv >= parame;
        }

        public bool CheckTaskID(Scene zongScene, int parame)
        {
            return zongScene.GetComponent<TaskComponent>().IsTaskFinished(parame);
        }

        public bool CheckFuncitonOn(Scene zongScene, FuntionConfig funtionOpenConfig)
        {
            int[] contion_1 = funtionOpenConfig.ConditionType;
            int[] contion_2 = funtionOpenConfig.ConditionParam;
            for (int i = 0; i < contion_1.Length; i++)
            {
                if (!functionCheck[contion_1[i]](zongScene, contion_2[i]))
                    return false;
            }
            return true;
        }

        public bool CheckTaskOn(Scene scene, TaskConfig taskConfig)
        {
            if (!functionCheck[taskConfig.TriggerType](scene, taskConfig.TriggerValue))
                return false;
            return true;
        }

        public float[] DoubleArrToFloatArr(Double[] arr)
        {

            float[] nowFloat = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                nowFloat[i] = (float)arr[i];
            }
            return nowFloat;

        }

    }
}
