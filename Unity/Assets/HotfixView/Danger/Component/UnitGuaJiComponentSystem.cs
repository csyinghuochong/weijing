using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public class UnitGuaJiComponentSystemAwake : AwakeSystem<UnitGuaJiComponen>
    {
        public override void Awake(UnitGuaJiComponen self)
        {
            //触发挂机
            self.ActTarget();

            //触发时间间隔
            self.TimeTriggerActTarget().Coroutine();
        }
    }

    public class UnitGuaJiComponentSystemDestroy : DestroySystem<UnitGuaJiComponen>
    {
        public override void Destroy(UnitGuaJiComponen self)
        {

        }
    }

    public static class UnitGuaJiComponentSystem {

        //触发挂机目标
        public static bool ActTarget(this UnitGuaJiComponen self) {

            //判断是否有体力,没体力不能挂机,减少服务器开销
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0) {
                FloatTipManager.Instance.ShowFloatTip("体力已经消耗完毕,请确保体力充足喔!");
                self.ZoneScene().RemoveComponent<UnitGuaJiComponen>();      //移除体力组件
                return false;
            };


            //判定攻击目标是否有攻击目标
            //self.ZoneScene().GetComponent<SkillIndicatorComponent>().ShowCommonAttackZhishi();        //展示攻击范围
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.UIAttackGrid.PointerUp(null);

            //获取当前攻击目标
            //Log.ILog.Debug("LastLockId = " + self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId);
            //Log.ILog.Debug("LastLockIndex = " + self.ZoneScene().GetComponent<LockTargetComponent>().LastLockIndex);

            self.forNum = 0;

            if (self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId == 0) {

                //表示附近没有玩家,给服务器发送消息
                self.MoveStatus = true;
                self.MovePosition().Coroutine();
                return false;
            }


            self.MoveStatus = false;        //关闭自动移动状态
            return true;
        }


        //触发挂机持续执行间隔
        public static async ETTask TimeTriggerActTarget(this UnitGuaJiComponen self) {

            for (self.forNum = 0; self.forNum < 100; self.forNum++) {

                //每10秒执行一次
                await TimerComponent.Instance.WaitAsync(10000);

                bool ifAct = self.ActTarget();
                if (ifAct == false)
                {
                    if (self.MoveStatus == false && self.ZoneScene().GetComponent<LockTargetComponent>().LastLockId == 0)
                    {
                        //如果当前不是移动状态,且目标ID为0
                        self.MovePosition().Coroutine();
                    }
                }
            }


            await ETTask.CompletedTask;
            return;
        }


        public static async ETTask MovePosition(this UnitGuaJiComponen self) {

            C2M_FindNearMonsterRequest c2M_FindNearMonsterRequest = new C2M_FindNearMonsterRequest();
            M2C_FindNearMonsterResponse m2C_FindNearMonsterResponse = (M2C_FindNearMonsterResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_FindNearMonsterRequest);

            if (m2C_FindNearMonsterResponse.IfFindStatus == true)
            {
                List<Vector3> movePosiList = new List<Vector3>();
                movePosiList.Add(new Vector3(m2C_FindNearMonsterResponse.x, m2C_FindNearMonsterResponse.y, m2C_FindNearMonsterResponse.z));
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                float speed = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
                bool ifSucc = await self.ZoneScene().GetComponent<MoveComponent>().MoveToAsync(movePosiList, speed);
                if (ifSucc)
                {
                    self.ActTarget();
                }
            }
            else {
                FloatTipManager.Instance.ShowFloatTip("附近未发现怪物");
            }

            return;
        }
    }
}
