
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class SkillHandlerSystem
    {

        public static void BaseOnInit(this SkillHandler self, SkillInfo skillcmd, Unit theUnitFrom)
        {
            self.SkillCmd = skillcmd;
            self.HurtIds.Clear();
            self.LastHurtTimes.Clear();
            self.SkillConf = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            self.TheUnitFrom = theUnitFrom;
            SkillSetComponent skillSetComponent = theUnitFrom.GetComponent<SkillSetComponent>();
            self.tianfuProAdd = skillSetComponent!=null ? skillSetComponent.GetSkillPropertyAdd(skillcmd.WeaponSkillID):null;

            self.PassTime = 0;
            self.OldSpeed = 0f;
            self.SkillTriggerInvelTime = 0;
            self.IsTriggerHurt = false;
            self.SkillState = SkillState.Running;
            self.BeginTime = TimeHelper.ServerNow();
            self.DelayHurtTime = (long)(1000 * self.SkillConf.SkillDelayTime);
            self.SkillLiveTime = self.SkillConf.SkillLiveTime + (long)(self.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime));
            self.TargetPosition = new Vector3(skillcmd.PosX, skillcmd.PosY, skillcmd.PosZ); //获取起始坐标
            self.ICheckShape = self.CreateCheckShape();
            self.NowPosition = self.TargetPosition;              //获取技能起始的坐标点

            //获取通用脚本参数
            if (ComHelp.IfNull(self.SkillConf.ComObjParameter) == false)
            {
                string[] skillParList = self.SkillConf.GameObjectParameter.Split('@');
                for (int i = 0; i < skillParList.Length; i++)
                {
                    string[] parList = self.SkillConf.GameObjectParameter.Split(';');
                    switch (parList[0])
                    {
                        //目标血量低伤害类型
                        case "1":
                            SkillParValue_HpUpAct hpUpAct = new SkillParValue_HpUpAct();
                            hpUpAct.type = 1;
                            hpUpAct.hpNeedPro = float.Parse(parList[1]);
                            hpUpAct.actAddPro = float.Parse(parList[2]);
                            self.SkillParValueHpUpAct.Add(hpUpAct);
                            break;
                        //目标血量低伤害类型
                        case "2":
                            hpUpAct = new SkillParValue_HpUpAct();
                            hpUpAct.type = 2;
                            hpUpAct.hpNeedPro = float.Parse(parList[1]);
                            hpUpAct.actAddPro = float.Parse(parList[2]);
                            self.SkillParValueHpUpAct.Add(hpUpAct);
                            break;
                        //自身血量低攻击提升
                        case "3":
                            float defendUnitHpPro = (float)theUnitFrom.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp) / (float)theUnitFrom.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
                            if (defendUnitHpPro <= float.Parse(parList[1]))
                                self.ActTargetAddPro= float.Parse(parList[2]);
                            break;
                    }
                }
            }
        }

        public static float GetTianfuProAdd(this SkillHandler self, int key)
        {
            float value = 0f;
            if (self.tianfuProAdd == null)
                return value;
            self.tianfuProAdd.TryGetValue(key, out value);
            return value;
        }

        //初始化
        public static void BaseOnExecute(this SkillHandler self)
        {
            //触发初始化BUFF
            if (self.SkillConf.InitBuffID[0] != 0)
            {
                for (int y = 0; y < self.SkillConf.InitBuffID.Length; y++)
                {
                    self.SkillBuff(self.SkillConf.InitBuffID[y], self.TheUnitFrom);
                }
            }
            SkillSetComponent skillSetComponent = self.TheUnitFrom.GetComponent<SkillSetComponent>();
            List<int> buffInitAdd = skillSetComponent!=null ? skillSetComponent.GetBuffInitIdAdd(self.SkillConf.Id):null;
            if (buffInitAdd != null)
            {
                for (int i = 0; i < buffInitAdd.Count; i++)
                {
                    self.SkillBuff(buffInitAdd[i], self.TheUnitFrom);
                }
            }
        }

        //每帧检测
        public static void BaseOnUpdate(this SkillHandler self)
        {
            self.PassTime = TimeHelper.ServerNow() - self.BeginTime;

            //根据技能效果延迟触发伤害
            if (self.PassTime < self.DelayHurtTime)
            {
                return;
            }
            //只触发一次，需要多次触发的重写
            if (!self.IsTriggerHurt)
            {
                self.IsTriggerHurt = true;
                if (self.SkillConf.SkillTargetType == (int)SkillTargetType.TargetOnly)
                {
                    Unit targetUnit = self.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().Get(self.SkillCmd.TargetID);
                    if (targetUnit != null)
                    {
                        self.OnCollisionUnit(targetUnit);
                    }
                }
                else if (self.SkillConf.SkillTargetType == (int)SkillTargetType.SelfOnly)
                {
                    self.OnCollisionUnit(self.TheUnitFrom);
                }   
                else
                {
                    self.TriggerSkillHurt();
                }
            }

            //根据技能存在时间设置其结束状态
            if (self.PassTime > self.SkillLiveTime)
            {
                self.SetSkillState(SkillState.Finished);
            }
        }

        //触发战斗伤害(0:范围内,不对自己造成伤害 1:只对自己造成影响)
        public static void TriggerSkillHurt(this SkillHandler self, int type = 0)
        {
            //Log.ILog.Info("触发技能Skillbuff...");
            switch (type)
            {
                //范围内对目标造成伤害
                case 0:
                    List<Unit> entities = self.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().GetAll();
                    for (int i = entities.Count - 1; i >= 0; i--)
                    {
                        Unit uu = entities[i];
                        //不对自己造成伤害和同一个目标不造成2次伤害
                        //if (uu.Id == self.TheUnitFrom.Id || self.HurtIds.Contains(uu.Id))
                        //{
                        //    //如果是自己可能添加对应Buff
                        //    if (uu.Id == self.TheUnitFrom.Id && self.HurtIds.Contains(uu.Id) == false) 
                        //    {
                        //        //Log.ILog.Info("触发技能Skillbuff2222..." + self.SkillConf.BuffID[0]);
                        //        OnAddSkillBuff(self, uu);
                        //        self.HurtIds.Add(uu.Id);
                        //    }
                        //    continue;
                        //}
                        if (self.HurtIds.Contains(uu.Id))
                        {
                            continue;
                        }
                        if (uu.Id == self.TheUnitFrom.Id&& self.CheckShape(uu.Position))
                        {
                            OnAddSkillBuff(self, uu);
                            self.HurtIds.Add(uu.Id);
                        }

                        //目标不为空
                        if (!uu.GetComponent<UnitInfoComponent>().IsCanBeAttackByUnit(self.TheUnitFrom) )
                        {
                            continue;
                        }
 
                        //检测目标是否在技能范围
                        if (!self.CheckShape(uu.Position))
                        {
                            continue;
                        }

                        self.HurtIds.Add(uu.Id);
                        self.OnCollisionUnit(uu);
                    }
                    break;
                //范围内的己方单位含自己
                case 1:
                    break;
            }
        }

        public static void OnCollisionUnit(this SkillHandler self, Unit uu)
        {
            //触发Buff
            OnAddSkillBuff(self,uu);

            SkillSetComponent skillSetComponent = self.TheUnitFrom.GetComponent<SkillSetComponent>();
            List<int> buffInitAdd = skillSetComponent != null ? skillSetComponent.GetBuffIdAdd(self.SkillConf.Id) : null;
            if (buffInitAdd != null && buffInitAdd.Count > 0)
            {
                for (int k = 0; k < buffInitAdd.Count; k++)
                {
                    self.SkillBuff(buffInitAdd[k], uu);
                }
            }

            //触发伤害
            if (self.SkillConf.DamgeValue > 0 || self.SkillConf.ActDamge > 0)
            {
                self.SkillActTarget(self.TheUnitFrom, uu);
            }
        }

        //目标附加Buff
        public static void OnAddSkillBuff(this SkillHandler self, Unit uu) {

            //触发Buff
            if (self.SkillConf.BuffID[0] != 0)
            {
                for (int y = 0; y < self.SkillConf.BuffID.Length; y++)
                {
                    self.SkillBuff(self.SkillConf.BuffID[y], uu);
                }
            }

        }

        public static void SetSkillState(this SkillHandler self, SkillState state)
        {
            self.SkillState = state;
        }

        public static bool CheckShape(this SkillHandler self, Vector3 t_positon)
        {
            return self.ICheckShape.Contains(t_positon);
        }

        public static void SkillActTarget(this SkillHandler self, Unit attactUnit, Unit defendUnit)
        {

            //技能伤害为0不执行
            if (self.SkillConf.ActDamge == 0 && self.SkillConf.DamgeValue == 0) {
                return;
            }

            bool clearnTemporary = false;
            if (self.SkillParValueHpUpAct!=null) {
                foreach (SkillParValue_HpUpAct now in self.SkillParValueHpUpAct) {
                    float defendUnitHpPro = (float)defendUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp) / (float)defendUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
                    //血量低于
                    if (now.type == 1) {
                        if (defendUnitHpPro <= now.hpNeedPro) 
                        {
                            self.ActTargetTemporaryAddPro = now.actAddPro;
                            clearnTemporary = true;
                        }
                    }

                    //血量高于
                    if (now.type == 2)
                    {
                        if (defendUnitHpPro <= now.hpNeedPro)
                        {
                            self.ActTargetTemporaryAddPro = now.actAddPro;
                            clearnTemporary = true;
                        }
                    }
                }
            }

            Function_Fight.GetInstance().Fight(attactUnit, defendUnit, self);

            if (clearnTemporary) {
                self.ActTargetTemporaryAddPro = 0;      //清空
            }

        }

        public static Shape CreateCheckShape(this SkillHandler self)
        {
            Shape ishape = null;
            float addRange = self.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageRange);

            switch (self.SkillConf.DamgeRangeType)
            {
                case 0:
                    ishape = new Circle();
                    (ishape as Circle).s_position = self.TargetPosition;
                    (ishape as Circle).range = (float)(self.SkillConf.DamgeRange[0]) + addRange;
                    break;
                case 1:
                    ishape = new Circle();
                    (ishape as Circle).s_position = self.TargetPosition;
                    (ishape as Circle).range = (float)(self.SkillConf.DamgeRange[0]) + addRange;
                    break;
                case 2:
                    ishape = new Rectangle();
                    (ishape as Rectangle).s_position = self.TargetPosition;
                    (ishape as Rectangle).s_forward = (Quaternion.Euler(0, self.SkillCmd.TargetAngle, 0) * Vector3.forward).normalized;
                    (ishape as Rectangle).x_range = (float)(self.SkillConf.DamgeRange[0] ) * 0.5f;
                    (ishape as Rectangle).z_range = (float)(self.SkillConf.DamgeRange[1]  +addRange);
                    break;
                case 3:
                    ishape = new Fan();
                    (ishape as Fan).s_position = self.TargetPosition;
                    (ishape as Fan).s_rotation = Quaternion.Euler(0, self.SkillCmd.TargetAngle, 0);
                    (ishape as Fan).skill_distance = (float)(self.SkillConf.DamgeRange[0]) + addRange;
                    (ishape as Fan).skill_angle = (float)(self.SkillConf.DamgeRange[1]);
                    break;
            }
            return ishape;
        }

        //目前只有冲锋技能用到。 
        public static void UpdateCheckPoint(this SkillHandler self)
        {
            switch (self.SkillConf.DamgeRangeType)
            {
                case 0:
                case 1:
                    (self.ICheckShape as Circle).s_position = self.TheUnitFrom.Position;
                    break;
                case 2:
                    (self.ICheckShape as Rectangle).s_position = self.TheUnitFrom.Position;
                    break;
                case 3:
                    (self.ICheckShape as Fan).s_position = self.TheUnitFrom.Position;
                    break;
            }
        }

        public static SkillState GetSkillState(this SkillHandler self)
        {
            return self.SkillState;
        }

        //1：自身
        //2：队友
        //3：己方
        //4: 敌方
        //5：全部
        public static void SkillBuff(this SkillHandler self, int buffID, Unit uu)
        {
            if (uu == null)
                return;
            SkillBuffConfig skillBuffConfig = SkillBuffConfigCategory.Instance.Get(buffID);
            bool canBuff = false;
            switch (skillBuffConfig.TargetType)
            {
                //对自己释放
                case 1:
                    canBuff = uu.Id == self.TheUnitFrom.Id;
                    break;
                case 2:
                //队友
                case 3:
                    canBuff = self.TheUnitFrom.GetComponent<UnitInfoComponent>().RoleCamp == uu.GetComponent<UnitInfoComponent>().RoleCamp;
                    break;
                //敌方
                case 4:
                    canBuff = self.TheUnitFrom.GetComponent<UnitInfoComponent>().RoleCamp != uu.GetComponent<UnitInfoComponent>().RoleCamp;
                    break;
                //全部
                case 5:
                    canBuff = true;
                    break;
            }

            if (!canBuff)
                return;
            
            BuffData buffData = new BuffData();
            buffData.BuffClassScript = skillBuffConfig.BuffScript;
            buffData.SkillConfig = self.SkillConf;
            buffData.BuffConfig = skillBuffConfig;
            uu.GetComponent<BuffManagerComponent>().BuffFactory(buffData, self.TheUnitFrom, self);
            //Log.Info("结束释放buff" + buffID);
        }
    }
}
