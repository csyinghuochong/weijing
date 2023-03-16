using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class SkillHandlerSystem
    {

        public static void BaseOnInit(this SkillHandler self, SkillInfo skillcmd, Unit theUnitFrom)
        {
            self.SkillInfo = skillcmd;
            self.HurtIds.Clear();
            self.LastHurtTimes.Clear();
            self.SkillConf = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            self.TheUnitFrom = theUnitFrom;
            SkillSetComponent skillSetComponent = theUnitFrom.GetComponent<SkillSetComponent>();
            self.TianfuProAdd = skillSetComponent!=null ? skillSetComponent.GetSkillPropertyAdd(skillcmd.WeaponSkillID):null;

            self.SkillTriggerInvelTime = 0;
            self.IsExcuteHurt = false;
            self.SkillState = SkillState.Running;
            self.SkillBeginTime = TimeHelper.ServerNow();
            self.SkillExcuteHurtTime = self.SkillBeginTime + (long)(1000 * self.SkillConf.SkillDelayTime);
            self.SkillEndTime = self.SkillBeginTime + self.SkillConf.SkillLiveTime + (long)(1000* self.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime));
            self.TargetPosition = new Vector3(skillcmd.PosX, skillcmd.PosY, skillcmd.PosZ); //获取起始坐标
            self.ICheckShape = null;
            self.ICheckShape = new List<Shape>();
            self.ICheckShape.Add( self.CreateCheckShape(self.SkillInfo.TargetAngle) );
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
            if (self.TianfuProAdd == null)
                return value;
            self.TianfuProAdd.TryGetValue(key, out value);
            return value;
        }

        //初始化
        public static void InitSelfBuff(this SkillHandler self)
        {
            //触发初始化BUFF
            if (self.SkillConf == null)
            {
                Log.Error($"self.SkillConf == null {self.SkillInfo.WeaponSkillID}");
            }
            if (self.TheUnitFrom.IsDisposed)
            {
                Log.Debug($"self.TheUnitFrom.IsDisposed {self.TheUnitFrom.Id}");
                return;
            }

            if (self.SkillConf.InitBuffID!= null &&self.SkillConf.InitBuffID[0] != 0)
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
            long serverNow = TimeHelper.ServerNow();

            //根据技能效果延迟触发伤害
            if (serverNow < self.SkillExcuteHurtTime)
            {
                return;
            }
            //只触发一次，需要多次触发的重写
            if (!self.IsExcuteHurt)
            {
                self.IsExcuteHurt = true;
                if (self.SkillConf.SkillTargetType == (int)SkillTargetType.TargetOnly)
                {
                    Unit targetUnit = self.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().Get(self.SkillInfo.TargetID);
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
                    self.ExcuteSkillAction();
                }
            }

            //根据技能存在时间设置其结束状态
            if (serverNow > self.SkillEndTime)
            {
                self.SetSkillState(SkillState.Finished);
            }
        }

        //触发战斗伤害(0:范围内,不对自己造成伤害 1:只对自己造成影响)
        public static void ExcuteSkillAction(this SkillHandler self)
        {
            if (self.TheUnitFrom.IsDisposed)
            {
                Log.Debug($"self.TheUnitFrom.IsDisposed {self.TheUnitFrom.Id}");
                return;
            }
            List<Unit> entities = self.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = entities.Count - 1; i >= 0; i--)
            {
                Unit uu = entities[i];
                if (self.HurtIds.Contains(uu.Id))
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
        }

        public static void OnCollisionUnit(this SkillHandler self, Unit uu)
        {
            //鞭炮打年兽 鞭炮道具10030002 技能76001001年兽 72009001
            if (self.SkillConf.Id == 76001001 && uu.ConfigId != 72009001)
            {
                return;
            }
            if (self.SkillConf.Id != 76001001 && uu.ConfigId == 72009001)
            {
                return;
            }

            //触发伤害
            bool ishit = self.TriggeSkillHurt(uu);

            //触发Buff
            if (ishit)
            {
                self.TriggerSkillBuff(uu);
            }
        }

        //目标附加Buff
        public static void TriggerSkillBuff(this SkillHandler self, Unit uu)
        {
            //触发Buff
            if (self.SkillConf.BuffID[0] != 0)
            {
                for (int y = 0; y < self.SkillConf.BuffID.Length; y++)
                {
                    self.SkillBuff(self.SkillConf.BuffID[y], uu);
                }
            }

            SkillSetComponent skillSetComponent = self.TheUnitFrom.GetComponent<SkillSetComponent>();
            List<int> buffInitAdd = skillSetComponent != null ? skillSetComponent.GetBuffIdAdd(self.SkillConf.Id) : null;
            if (buffInitAdd != null && buffInitAdd.Count > 0)
            {
                for (int k = 0; k < buffInitAdd.Count; k++)
                {
                    self.SkillBuff(buffInitAdd[k], uu);
                }
            }
        }

        public static void SetSkillState(this SkillHandler self, SkillState state)
        {
            self.SkillState = state;
        }

        public static bool CheckShape(this SkillHandler self, Vector3 t_positon)
        {
            for (int i = 0; i < self.ICheckShape.Count; i++)
            {
                if (self.ICheckShape[i].Contains(t_positon))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool  TriggeSkillHurt(this SkillHandler self,  Unit uu)
        {
            bool canAttack = self.TheUnitFrom.IsCanAttackUnit(uu);
            if (!canAttack)
            {
                return true;
            }
            //技能伤害为0不执行
            if (self.SkillConf.ActDamge == 0 && self.SkillConf.DamgeValue == 0) 
            {
                return true;
            }
            bool clearnTemporary = false;
            if (self.SkillParValueHpUpAct!=null)
            {
                foreach (SkillParValue_HpUpAct now in self.SkillParValueHpUpAct)
                {
                    float defendUnitHpPro = (float)uu.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp) / (float)uu.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp);
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

            bool ishit =  Function_Fight.GetInstance().Fight(self.TheUnitFrom, uu, self);
            if (clearnTemporary)
            {
                self.ActTargetTemporaryAddPro = 0;      //清空
            }
            return ishit;
        }

        public static Shape CreateCheckShape(this SkillHandler self, int targetAngle)
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
                    (ishape as Rectangle).s_forward = (Quaternion.Euler(0, targetAngle, 0) * Vector3.forward).normalized;
                    (ishape as Rectangle).x_range = (float)(self.SkillConf.DamgeRange[0] ) * 0.5f;
                    (ishape as Rectangle).z_range = (float)(self.SkillConf.DamgeRange[1]  +addRange);
                    break;
                case 3:
                    ishape = new Fan();
                    (ishape as Fan).s_position = self.TargetPosition;
                    (ishape as Fan).s_rotation = Quaternion.Euler(0, targetAngle, 0);
                    (ishape as Fan).skill_distance = (float)(self.SkillConf.DamgeRange[0]) + addRange;
                    (ishape as Fan).skill_angle = (float)(self.SkillConf.DamgeRange[1]);
                    break;
            }
            return ishape;
        }

        //目前只有冲锋技能用到。 
        public static void UpdateCheckPoint(this SkillHandler self, Vector3 vector3)
        {
            if (self.ICheckShape == null || self.ICheckShape.Count == 0)
            {
                Log.Debug($"self.ICheckShape == null: {self.SkillConf.SkillName}");
                return;
            }

            switch (self.SkillConf.DamgeRangeType)
            {
                case 0:
                case 1:
                    (self.ICheckShape[0] as Circle).s_position = vector3;
                    break;
                case 2:
                    (self.ICheckShape[0] as Rectangle).s_position = vector3;
                    break;
                case 3:
                    (self.ICheckShape[0] as Fan).s_position = vector3;
                    break;
            }
        }

        public static SkillState GetSkillState(this SkillHandler self)
        {
            return self.SkillState;
        }

        public static void Clear(this SkillHandler self)
        {
            self.ICheckShape.Clear();
            self.SkillInfo = null;
        }

        //1：自身
        //2：队友
        //3：己方【同阵营】
        //4: 敌方
        //5：全部
        public static void SkillBuff(this SkillHandler self, int buffID, Unit uu)
        {
            if (uu == null || uu.IsDisposed)
            {
                return;
            }
            if (!SkillBuffConfigCategory.Instance.Contain(buffID))
            {
                Log.Error($"config==null： buffid{buffID}");
                return;
            }
            SkillBuffConfig skillBuffConfig = SkillBuffConfigCategory.Instance.Get(buffID);
            bool teshui = uu.Type == UnitType.JingLing && skillBuffConfig.TargetType == 1;
            if (!uu.IsCanBeAttack() && !teshui)
            {
                return;
            }

            bool canBuff = false;
            switch (skillBuffConfig.TargetType)
            {
                //对自己释放
                case 1:
                    canBuff = uu.Id == self.TheUnitFrom.Id;
                    if (uu.Type == UnitType.JingLing)
                    {
                        long masterid = uu.GetMasterId();
                        uu = uu.GetParent<UnitComponent>().Get(masterid);
                        if (uu == null || uu.IsDisposed)
                        {
                            return;
                        }
                    }
                    break;
                case 2:
                    PetComponent petComponent = self.TheUnitFrom.GetComponent<PetComponent>();  
                    canBuff = self.TheUnitFrom.IsSameTeam(uu) || self.TheUnitFrom.IsMasterOrPet(uu, petComponent);
                    break;
                case 3:
                    canBuff = self.TheUnitFrom.GetBattleCamp() == uu.GetBattleCamp();
                    break;
                //敌方
                case 4:
                    canBuff = self.TheUnitFrom.GetBattleCamp() != uu.GetBattleCamp();
                    break;
                //全部
                case 5:
                    canBuff = true;
                    break;
            }

            if (!canBuff)
            {
                return;
            }
            
            BuffData buffData = new BuffData();
            buffData.SkillConfig = self.SkillConf;
            buffData.BuffConfig = skillBuffConfig;
            uu.GetComponent<BuffManagerComponent>().BuffFactory(buffData, self.TheUnitFrom, self);
            //Log.Info("结束释放buff" + buffID);
        }
    }
}
