using UnityEngine;

namespace ET
{
    [ObjectSystem]
    public class FsmComponentAwakeSystem: AwakeSystem<FsmComponent>
    {
        public override void Awake(FsmComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            GameObject gameObject = unit.GetComponent<GameObjectComponent>().GameObject;
            //self.SkillMoveTime = 0;
            //self.Animator = unit.GetComponent<AnimatorComponent>().Animator;
            FsmStateUI fsmStateUI = gameObject.GetComponent<FsmStateUI>();
            if (fsmStateUI == null)
            {
                fsmStateUI = gameObject.AddComponent<FsmStateUI>(); 
            }
            self.FsmStateUI = fsmStateUI;
            fsmStateUI.OnInitUI(unit.GetComponent<AnimatorComponent>().Animator);
            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            bool idle = moveComponent == null || moveComponent.IsArrived();
            int unitype = unit.GetComponent<UnitInfoComponent>().Type;
            fsmStateUI.ChangeState(idle ? FsmStateEnum.FsmIdleState : FsmStateEnum.FsmRunState, "", unitype);
        }
    }

    [ObjectSystem]
    public class FsmComponentDestroySystem : DestroySystem<FsmComponent>
    {
        public override void Destroy(FsmComponent self)
        {
            self.Destroy();
        }
    }

    /// <summary>
    /// 适用于动画切换的栈式状态机
    /// </summary>
    public static class FsmComponentSystem
    {
        public static void Destroy(this FsmComponent self)
        {
            self.CurrentFsm?.OnDestory();
            self.CurrentFsm = null;
        }

        public static int GetCurrentState(this FsmComponent self)
        {
            if (self.CurrentFsm != null)
            {
                return self.CurrentFsm.FsmType;
            }
            return FsmStateEnum.FsmNullState;
        }

        public static bool ChangeState(this FsmComponent self, int targetFsm, string paramss = "")
        {
            switch (targetFsm)
            {
                case FsmStateEnum.FsmComboState:
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
                    int EquipType = (int)ItemEquipType.Common;
                    int itemId = (int)self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Weapon);
                    if (itemId != 0)
                    {
                        ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
                        EquipType = itemConfig.EquipType;
                    }
                    paramss = $"{skillConfig.SkillAnimation}@{EquipType}";
                    break;
                case FsmStateEnum.FsmSkillState:
                    skillConfig = SkillConfigCategory.Instance.Get(int.Parse(paramss));
                    long SkillMoveTime = (skillConfig.Id >= 61012201 && skillConfig.Id <= 61012206) ? skillConfig.SkillLiveTime + TimeHelper.ClientNow() : 0;
                    paramss = $"{SkillMoveTime}@{skillConfig.SkillAnimation}@{skillConfig.SkillSingTime}@{skillConfig.SkillRigidity}";
                    break;
            }

            int unitType = self.GetParent<Unit>().GetComponent<UnitInfoComponent>().Type;
            self.FsmStateUI.ChangeState(targetFsm, paramss, unitType);
            return true;
        }

        public static bool ChangeState_Old(this FsmComponent self, int targetFsm, string paramss = "")
        {
            if (!self.Animator)
                return false;

            if (self.GetCurrentState() == targetFsm)
            {
                self.CurrentFsm.OnReEnter(paramss);
                return true;
            }

            AFsmHandler fsmHandler = FsmDispatchComponent.Instance.SkillFactory(targetFsm);
            if (fsmHandler == null)
            {
                Log.Error($"not found fsmHandler: {targetFsm.ToString()}");
                return false;
            }

            fsmHandler.FsmComponent = self;
            if (self.CurrentFsm != null)
            {
                self.CurrentFsm.OnExit();
            }

            self.CurrentFsm = fsmHandler;
            fsmHandler.FsmType = targetFsm;
            fsmHandler.OnInit();
            fsmHandler.OnEnter(paramss);

            return true;
        }
    }
}