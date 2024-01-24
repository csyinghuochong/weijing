using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    /// <summary>
    /// 释放一个范围法阵，法阵每秒造成伤害，在法阵中有怪物或英雄宠物死亡立即再死亡位置召唤1个召唤物（怪物死亡位置），并且法阵每秒也会一个召唤物（法阵中心位置）
    /// </summary>
    public class Skill_Com_Summon_5: SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            string invelTime = SkillConf.GameObjectParameter.Split(';')[0];
            if (string.IsNullOrEmpty(invelTime))
            {
                this.SkillTriggerInvelTime = 1000;
                Log.Console($"SkillConf.GameObjectParameter:  {SkillConf.Id}  {SkillConf.GameObjectParameter}");
            }
            else
            {
                try
                {
                    this.SkillTriggerInvelTime = (long)(float.Parse(invelTime) * 1000);
                }
                catch (Exception ex)
                {
                    Log.Debug(ex.ToString());
                    Log.Console($"SkillConf.GameObjectParameter:  {SkillConf.Id}  {SkillConf.GameObjectParameter}");
                }
            }
        }

        // 退出
        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.IsExcuteHurt = false;
            if (this.SkillConf.SkillTargetType == SkillTargetType.SelfFollow)
            {
                this.UpdateCheckPoint(this.TheUnitFrom.Position);
            }

            long curTime = TimeHelper.ServerNow();
            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                long unitId = this.HurtIds[i];
                Unit unit = this.TheUnitFrom.Domain.GetComponent<UnitComponent>().Get(unitId);
                if (unit == null || unit.IsDisposed)
                {
                    this.HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                    continue;
                }

                if (!this.CheckShape(unit.Position))
                {
                    this.HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                    continue;
                }

                if (!this.LastHurtTimes.ContainsKey(unitId))
                {
                    continue;
                }

                if (curTime - this.LastHurtTimes[unitId] >= this.SkillTriggerInvelTime)
                {
                    this.HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                }
            }

            this.BaseOnUpdate();
            this.CheckChiXuHurt();

            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                long unitId = this.HurtIds[i];
                if (!this.LastHurtTimes.ContainsKey(unitId))
                {
                    this.LastHurtTimes.Add(unitId, TimeHelper.ServerNow());
                }
            }

            // 召唤
            if (curTime - this.SkillTriggerLastTime < this.SkillTriggerInvelTime)
            {
                return;
            }

            this.SkillTriggerLastTime = curTime;

            Unit theUnitFrom = this.TheUnitFrom;
            UnitInfoComponent unitInfoComponent = theUnitFrom.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.GetZhaoHuanNumber() >= 100)
            {
                return;
            }

            // '1;90000102;1;1;1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0;5
            // 时间间隔；召唤ID,召唤ID(随机从中召唤一个)；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值;数量上限
            string gameObjectParameter = this.SkillConf.GameObjectParameter;
            string[] summonParListold = gameObjectParameter.Split(';');
            string[] summonParList = new string[summonParListold.Length - 1];
            Array.Copy(summonParListold, 1, summonParList, 0, summonParList.Length);

            int monsterId = 0;
            float range = 0f;
            int number = 0;
            int maxNum = 0;
            List<int> monsterIds = new List<int>();
            try
            {
                foreach (string id in summonParList[0].Split(','))
                {
                    monsterIds.Add(int.Parse(id));
                }

                range = float.Parse(summonParList[2]);
                number = int.Parse(summonParList[3]);
                maxNum = int.Parse(summonParList[6]);
            }
            catch (Exception ex)
            {
                Log.Error("Skill_Com_Summon_5:Error:  ", this.SkillConf.Id);
                Log.Error(ex.ToString());
                return;
            }

            List<Unit> haved = new List<Unit>();
            List<Unit> all = theUnitFrom.GetParent<UnitComponent>().GetAll();
            foreach (Unit unit in all)
            {
                if (unit.Type == UnitType.Monster && monsterIds.Contains(unit.ConfigId) && unit.MasterId == theUnitFrom.Id)
                {
                    haved.Add(unit);
                }
            }

            if (haved.Count + number > maxNum)
            {
                int de = haved.Count + number - maxNum;
                while (de > 0 && haved.Count > 0)
                {
                    Unit uu = haved[0];
                    haved.Remove(uu);
                    uu.GetComponent<HeroDataComponent>().OnDead(null);
                    unitInfoComponent.ZhaohuanIds.Remove(uu.Id);
                    --de;
                }
            }

            if (number > 100)
            {
                Log.Error($"Skill_Com_Summon_5: {this.SkillConf.Id}");
                return;
            }

            for (int y = 0; y < number; y++)
            {
                //随机坐标
                float ran_x = RandomHelper.RandomNumberFloat(-1 * range, range);
                float ran_z = RandomHelper.RandomNumberFloat(-1 * range, range);
                Vector3 initPosi = new Vector3(this.TargetPosition.x + ran_x, this.TargetPosition.y, this.TargetPosition.z + ran_z);

                if (this.SkillConf.SkillZhishiType == 1)
                {
                    initPosi = this.TargetPosition;
                }

                monsterId = monsterIds[RandomHelper.RandomNumber(0, monsterIds.Count)];
                Unit unitMonster = UnitFactory.CreateMonster(theUnitFrom.DomainScene(), monsterId, initPosi,
                    new CreateMonsterInfo()
                    {
                        Camp = theUnitFrom.GetBattleCamp(),
                        MasterID = theUnitFrom.Id,
                        AttributeParams = summonParList[1] + ";" + summonParList[4] + ";" + summonParList[5]
                    });
                unitInfoComponent.ZhaohuanIds.Add(unitMonster.Id);
            }
        }

        private void RemoveHurtTime(long unitId)
        {
            if (!this.LastHurtTimes.ContainsKey(unitId))
                return;
            this.LastHurtTimes.Remove(unitId);
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}