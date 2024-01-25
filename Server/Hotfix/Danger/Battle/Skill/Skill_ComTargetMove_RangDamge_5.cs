using UnityEngine;

namespace ET
{
    /// <summary>
    /// 前方投掷一个球,球会向前方移动，触碰到单位爆炸
    /// 脚本对应参数【是否冲锋，伤害间隔时间】
    /// 0表示不冲锋，1表示跟随弹道冲锋
    /// </summary>
    public class Skill_ComTargetMove_RangDamge_5: SkillHandler
    {
        private int isChonFeng;
        private float SpeedAddValue = 0f;
        private Vector3 UnitTargetPos;

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            this.isChonFeng = int.Parse(paraminfos[0]);
            if (paraminfos[1] != "0")
            {
                this.SkillTriggerInvelTime = (long)(float.Parse(paraminfos[1]) * 1000);
            }

            this.SkillExcuteNum = 1;

            this.UnitTargetPos = this.TheUnitFrom.Position;
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.CreateBullet();
            if (TimeHelper.ServerNow() > SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
        }

        public override void OnFinished()
        {
            if (this.isChonFeng == 1)
            {
                this.ReSetUnit(this.TheUnitFrom);
            }

            UnitComponent unitComponent = this.TheUnitFrom.GetParent<UnitComponent>();
            foreach (long id in this.HurtIds)
            {
                Unit unit = unitComponent.Get(id);
                if (unit == null)
                {
                    continue;
                }

                this.ReSetUnit(unit);
            }

            this.Clear();
        }

        public void CreateBullet()
        {
            if (TimeHelper.ServerNow() < this.SkillExcuteHurtTime)
            {
                return;
            }

            if (this.SkillExcuteNum <= 0)
            {
                return;
            }

            long serverTime = TimeHelper.ServerNow();
            if (serverTime - this.SkillTriggerLastTime < this.SkillTriggerInvelTime)
            {
                return;
            }

            this.HurtIds.Clear();
            this.SkillTriggerLastTime = serverTime;

            Unit unit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, this.TheUnitFrom.Position,
                new CreateMonsterInfo());
            unit.AddComponent<RoleBullet5Componnet>().OnBaseBulletInit(this, this.TheUnitFrom.Id);
            Vector3 target = this.GetBulletTargetPoint(this.SkillInfo.TargetAngle);
            unit.BulletMoveToAsync(target).Coroutine();
            this.SkillExcuteNum--;

            this.UnitTargetPos = this.TheUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(this.TheUnitFrom.Position, target);
            if (this.isChonFeng == 1)
            {
                this.PushUnit(this.TheUnitFrom);
            }
        }

        public void PushUnit(Unit unit)
        {
            unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.BePulled);
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float oldSpeed = numericComponent.GetAsFloat(NumericType.Now_Speed);
            float oldspeedAdd = numericComponent.GetAsFloat(NumericType.Extra_Buff_Speed_Add);
            double addPro = (double)numericComponent.GetAsInt(NumericType.Now_JumpDisAdd) / 10;
            float newSpeed = (float)(this.SkillConf.SkillMoveSpeed * (1 + addPro));
            float newspeedAdd = newSpeed - oldSpeed;

            if (newSpeed > oldSpeed && newspeedAdd > oldspeedAdd)
            {
                this.SpeedAddValue = newspeedAdd - oldspeedAdd;
                numericComponent.Set(NumericType.Extra_Buff_Speed_Add, newspeedAdd);
            }
            else
            {
                this.SpeedAddValue = 0f;
            }

            unit.GetComponent<StateComponent>().SetRigidityEndTime(0);
            unit.FindPathMoveToAsync(this.UnitTargetPos,
                null,
                false).Coroutine();
        }

        public void ReSetPush(Unit unit)
        {
            unit.GetComponent<StateComponent>().SetRigidityEndTime(0);
            unit.FindPathMoveToAsync(this.UnitTargetPos,
                null,
                false).Coroutine();
        }

        public void ReSetUnit(Unit unit)
        {
            unit.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.BePulled);
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float curspeedAdd = numericComponent.GetAsFloat(NumericType.Extra_Buff_Speed_Add) - this.SpeedAddValue;
            numericComponent.Set(NumericType.Extra_Buff_Speed_Add, Mathf.Max(0, curspeedAdd));
        }

        public Vector3 GetBulletTargetPoint(int angle)
        {
            Vector3 sourcePoint = this.TheUnitFrom.Position;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            Vector3 TargetPoint = sourcePoint + rotation * Vector3.forward * SkillConf.SkillLiveTime * (float)SkillConf.SkillMoveSpeed * 0.001f;
            return TargetPoint;
        }
    }
}