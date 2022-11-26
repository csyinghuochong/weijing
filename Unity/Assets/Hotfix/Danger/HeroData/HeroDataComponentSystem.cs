using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class HeroDataComponentAwakeSystem : AwakeSystem<HeroDataComponent>
    {
        public override void Awake(HeroDataComponent self)
        {
            self.AttackingId = 0;
            self.BeAttackId = 0;
        }
    }

    /// <summary>
    /// 英雄数据组件，负责管理英雄数据
    /// </summary>
    public static class HeroDataComponentSystem
    {
#if SERVER
        public static void CheckNumeric(this HeroDataComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            //重置所有属性
            long max = (int)NumericType.Max;
            foreach (int key in numericComponent.NumericDic.Keys)
            {
                //这个范围内的属性为特殊属性不进行重置
                if (key < max)
                {
                    continue;
                }
                numericComponent.NumericDic[key] = 0;
            }

            if (numericComponent.GetAsInt(NumericType.Ling_DiLv) == 0)
            {
                numericComponent.Set(NumericType.Ling_DiLv, 1, false);
            }
            if (numericComponent.GetAsInt(NumericType.CangKuNumber) == 0)
            {
                numericComponent.Set(NumericType.CangKuNumber, 1, false);
            }

            long yuekeEndTime = numericComponent.GetAsLong(NumericType.YueKaEndTime) - TimeHelper.ServerNow();
            if (yuekeEndTime > 0)
            {
                int leftDay = Mathf.CeilToInt(yuekeEndTime * 1f / ( 24 * 60 * 60 * 1000 ));
                leftDay = Mathf.Min(7, leftDay);
                numericComponent.Set(NumericType.YueKaEndTime, 0);
                numericComponent.Set(NumericType.YueKaRemainTimes, leftDay);
            }
            if (numericComponent.GetAsFloat(NumericType.ChouKaTenTime) == 0)
            {
                numericComponent.Set(NumericType.ChouKaTenTime, TimeHelper.ServerNow());
            }
            if (numericComponent.GetAsFloat(NumericType.ChouKaOneTime) == 0)
            {
                numericComponent.Set(NumericType.ChouKaOneTime, TimeHelper.ServerNow());
            }
        }

        public static void OnLogin(this HeroDataComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
           
            self.CheckNumeric();

            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, false);
            //numericComponent.Set((int)NumericType.Now_MaxHp, numericComponent.GetAsLong((int)NumericType.Now_MaxHp), false);
            numericComponent.Set((int)NumericType.Now_Hp, numericComponent.GetAsLong((int)NumericType.Now_MaxHp), false);

            numericComponent.Set((int)NumericType.Now_Dead , 0, false);
            numericComponent.Set((int)NumericType.Now_Damage, 0, false);
            numericComponent.Set((int)NumericType.Now_Stall, 0, false);
            numericComponent.Set((int)NumericType.Now_Weapon, unit.GetComponent<BagComponent>().GetWuqiItemId(), false);
        }

        /// <summary>
        /// 重置。隔天登录或者零点刷新
        /// </summary>
        /// <param name="self"></param>
        /// <param name="notice"></param>
        public static void OnZeroClockUpdate(this HeroDataComponent self, bool notice = false)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            numericComponent.ApplyValue(NumericType.HongBao, 0, notice);
            numericComponent.ApplyValue(NumericType.Now_XiLian, 0, notice);
            numericComponent.ApplyValue(NumericType.PetChouKa, 0, notice);
            numericComponent.ApplyValue(NumericType.YueKaAward, 0, notice);
            numericComponent.ApplyValue(NumericType.XiuLian_ExpNumber, 0, notice);
            numericComponent.ApplyValue(NumericType.XiuLian_CoinNumber, 0, notice);
            numericComponent.ApplyValue(NumericType.XiuLian_ExpTime, 0, notice);
            numericComponent.ApplyValue(NumericType.XiuLian_CoinTime, 0, notice);
            numericComponent.ApplyValue(NumericType.TiLiKillNumber, 0, notice);
            numericComponent.ApplyValue(NumericType.ChouKa, 0, notice);
            numericComponent.ApplyValue(NumericType.ExpToGoldTimes, 0, notice);
            numericComponent.ApplyValue(NumericType.RechargeSign, 0, notice);
            numericComponent.ApplyValue(NumericType.TaskLoopGiveId, 0, notice);
            numericComponent.ApplyValue(NumericType.TeamDungeonTimes, 0, notice);
        }

        /// <summary>
        /// 返回主城
        /// </summary>
        /// <param name="self"></param>
        public static void OnReturn(this HeroDataComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.NumericDic[NumericType.Now_Dead] = 0;
            numericComponent.NumericDic[NumericType.Now_Damage] = 0;
            numericComponent.NumericDic[NumericType.Now_Shield_HP] = 0;
            numericComponent.NumericDic[NumericType.Now_Shield_MaxHP] = 0;
            numericComponent.NumericDic[NumericType.Now_Shield_DamgeCostPro] = 0;
            if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Dead) <= 0)
            {
                long max_hp = self.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
                unit.GetComponent<NumericComponent>().NumericDic[NumericType.Now_Hp] = max_hp;
            }
        }

        public static void OnResetPoint(this HeroDataComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            numericComponent.ApplyValue(NumericType.PointLiLiang, 0);
            numericComponent.ApplyValue(NumericType.PointZhiLi, 0);
            numericComponent.ApplyValue(NumericType.PointTiZhi, 0);
            numericComponent.ApplyValue(NumericType.PointNaiLi, 0);
            numericComponent.ApplyValue(NumericType.PointMinJie,0);
            numericComponent.ApplyValue(NumericType.PointRemain, (userInfoComponent.UserInfo.Lv - 1) * 5);
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
        }

        /// <summary>
        /// 0 不复活 1等待复活
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int OnWaitRevive(this HeroDataComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.Type != UnitType.Monster)
            {
                return 0;
            }

            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unit.ConfigId);
            int resurrection = (int)monsterConfig.ReviveTime;
            if (resurrection == 0)
            {
                return 0;
            }
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            if (monsterConfig.MonsterType != (int)MonsterTypeEnum.Boss)
            {
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                {
                    unit.DomainScene().GetComponent<LocalDungeonComponent>().OnAddRefreshList(unit, resurrection * 1000);
                }
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene && mapComponent.SceneId != 2000001)
                {
                    unit.DomainScene().GetComponent<YeWaiRefreshComponent>().OnAddRefreshList(unit, resurrection * 1000);
                }
                return 0;
            }
            else
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.ReviveTime, TimeHelper.ServerNow() + resurrection * 1000);
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                {
                    LocalDungeonComponent localDungeon = unit.DomainScene().GetComponent<LocalDungeonComponent>();
                    localDungeon.MainUnit.GetComponent<UserInfoComponent>().OnAddRevive(unit.ConfigId, TimeHelper.ServerNow() + resurrection * 1000);
                    unit.RemoveComponent<ReviveTimeComponent>();
                    unit.AddComponent<ReviveTimeComponent, long>(TimeHelper.ServerNow() + resurrection * 1000);
                    FirstWinHelper.SendFirstWinInfo(localDungeon.MainUnit, unit, localDungeon.FubenDifficulty);
                }
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.YeWaiScene)
                {
                    unit.RemoveComponent<ReviveTimeComponent>();
                    unit.AddComponent<ReviveTimeComponent, long>(TimeHelper.ServerNow() + resurrection * 1000);
                }
                return 1;
            }
        }

        public static void OnDead(this HeroDataComponent self, EventType.NumericChangeEvent args)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.GetComponent<MoveComponent>() != null)
            {
                unit.Stop(-1);
            }
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent == null)
            {
                Log.Debug($"unitInfoComponent == null  {unit.Type } {unit.IsDisposed}");
                return;
            }
            for (int i = unitInfoComponent.ZhaohuanIds.Count - 1; i >= 0; i--)
            {
                Unit zhaohuan = unit.DomainScene().GetComponent<UnitComponent>().Get(unitInfoComponent.ZhaohuanIds[i]);
                if (zhaohuan == null)
                {
                    continue;
                }
                zhaohuan.GetComponent<NumericComponent>().ApplyChange(args.Attack, NumericType.Now_Hp, -1000000, args.SkillId);
            }
            unitInfoComponent.ZhaohuanIds.Clear();
            int waitRevive =  self.OnWaitRevive();
            unit.GetComponent<AIComponent>()?.Stop();
            unit.GetComponent<SkillPassiveComponent>()?.Stop();
            unit.GetComponent<SkillManagerComponent>()?.OnFinish();
            unit.GetComponent<BuffManagerComponent>()?.OnDead();
            if (unit.Type == UnitType.Player)
            {
                RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetFightPet();
                if (rolePetInfo != null)
                {
                    unit.DomainScene().GetComponent<UnitComponent>().Remove(rolePetInfo.Id);
                    unit.GetComponent<PetComponent>().OnPetDead(rolePetInfo.Id);
                }
            }
            if (unit.Type == UnitType.Pet)
            {
                int sceneTypeEnum = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
                if (sceneTypeEnum != (int)SceneTypeEnum.PetTianTi
                    && sceneTypeEnum != (int)SceneTypeEnum.PetDungeon)
                {
                    long manster = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
                    Unit unit_manster = unit.GetParent<UnitComponent>().Get(manster);
                    //修改宠物出战状态
                    unit_manster.GetComponent<PetComponent>().OnPetDead(unit.Id);
                }
            }
          
            Game.EventSystem.Publish(new EventType.KillEvent()
            {
                WaitRevive = waitRevive,
                UnitAttack = args.Attack,
                UnitDefend = unit,
            });
        }

        public static void OnRevive(this HeroDataComponent self, bool bornPostion = false)
        {
            Unit unit = self.GetParent<Unit>();

            long max_hp = self.Parent.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
            if (unit.Type == UnitType.Monster)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unit.ConfigId);
                if (monsterConfig.AI > 0)
                {
                    unit.RemoveComponent<AIComponent>();
                    AIComponent aIComponent = unit.AddComponent<AIComponent, int>(monsterConfig.AI);
                    aIComponent.InitMonster(monsterConfig.Id);
                }
            }
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Dead, 0);
            unit.GetComponent<NumericComponent>().NumericDic[NumericType.Now_Hp] = 0;
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.Now_Hp, max_hp, 0);
            unit.GetComponent<SkillPassiveComponent>()?.Activeted();
            unit.Position = unit.GetBornPostion();
        }

        public static void InitTempFollower(this HeroDataComponent self, Unit matster, int monster)
        {
            Unit nowUnit = self.GetParent<Unit>();
            NumericComponent numericComponent = nowUnit.GetComponent<NumericComponent>();
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monster);

            //判定是否为成长怪物
            if (monsterConfig.MonsterSonType == 1)
            {
                int nowUserLv = nowUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                for (int i = 0; i < monsterConfig.Parameter.Length; i++)
                {
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterConfig.Parameter[i]);
                    if (nowUserLv >= monsterCof.Lv)
                    {
                        //指定等级对应属性
                        monsterConfig = monsterCof;
                    }
                }
            }

            NumericComponent numericComponentMaster = matster.GetComponent<NumericComponent>();
            //numericComponent.Set((int)NumericType.Base_MaxHp_Base, (int)(monsterConfig.Hp * hpCoefficient), false);
            //numericComponent.Set((int)NumericType.Base_MinAct_Base, (int)(monsterConfig.Act * ackCoefficient), false);
            //numericComponent.Set((int)NumericType.Base_MaxAct_Base, (int)(monsterConfig.Act * ackCoefficient), false);
            //numericComponent.Set((int)NumericType.Base_MinDef_Base, monsterConfig.Def, false);
            //numericComponent.Set((int)NumericType.Base_MaxDef_Base, monsterConfig.Def, false);
            //numericComponent.Set((int)NumericType.Base_MinAdf_Base, monsterConfig.Adf, false);
            //numericComponent.Set((int)NumericType.Base_MaxAdf_Base, monsterConfig.Adf, false);
            numericComponent.Set((int)NumericType.Base_MaxHp_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MaxHp_Base) * 0.5f), false);
            numericComponent.Set((int)NumericType.Base_MinAct_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MinAct_Base) * 0.5f), false);
            numericComponent.Set((int)NumericType.Base_MaxAct_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MaxAct_Base) * 0.5f), false);
            numericComponent.Set((int)NumericType.Base_MinDef_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MinDef_Base) * 0.5f), false);
            numericComponent.Set((int)NumericType.Base_MaxDef_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MaxDef_Base) * 0.5f), false);
            numericComponent.Set((int)NumericType.Base_MinAdf_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MinAdf_Base) * 0.5f), false);
            numericComponent.Set((int)NumericType.Base_MaxAdf_Base, (int)(numericComponentMaster.GetAsInt(NumericType.Base_MaxAdf_Base) * 0.5f), false);

            numericComponent.Set((int)NumericType.Base_Speed_Base, monsterConfig.MoveSpeed, false);
            numericComponent.Set((int)NumericType.Base_Cri_Base, monsterConfig.Cri, false);
            numericComponent.Set((int)NumericType.Base_Res_Base, monsterConfig.Res, false);
            numericComponent.Set((int)NumericType.Base_Hit_Base, monsterConfig.Hit, false);
            numericComponent.Set((int)NumericType.Base_Dodge_Base, monsterConfig.Dodge, false);
            numericComponent.Set((int)NumericType.Base_ActDamgeSubPro_Base, monsterConfig.DefAdd, false);
            numericComponent.Set((int)NumericType.Base_MageDamgeSubPro_Base, monsterConfig.AdfAdd, false);
            numericComponent.Set((int)NumericType.Base_DamgeSubPro_Base, monsterConfig.DamgeAdd, false);

            //设置当前血量
            numericComponent.NumericDic[(int)NumericType.Now_Hp] = numericComponent.NumericDic[(int)NumericType.Now_MaxHp];
        }

        public static void InitPet(this HeroDataComponent self, RolePetInfo rolePetInfo, bool notice)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            for (int i = 0; i < rolePetInfo.Ks.Count; i++)
            {
                numericComponent.Set(rolePetInfo.Ks[i], rolePetInfo.Vs[i], notice);
            }
        }

        /// <summary>
        /// 角色属性模块初始化
        /// </summary>
        public static void InitMonsterInfo_Summon2(this HeroDataComponent self, MonsterConfig monsterConfig, CreateMonsterInfo createMonsterInfo)
        {
            Unit nowUnit = self.GetParent<Unit>();
            NumericComponent numericComponent = nowUnit.GetComponent<NumericComponent>();

            Unit masterUnit = nowUnit.GetParent<UnitComponent>().Get(createMonsterInfo.MasterID);

            //召唤ID；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值
            string[] summonInfo = createMonsterInfo.AttributeParams.Split(';');
            int useMasterModel = int.Parse(summonInfo[1]);
            numericComponent.Set((int)NumericType.UseMasterModel, useMasterModel, false);

            string[] attributeList_1 = summonInfo[4].Split(',');
            string[] attributeList_2 = summonInfo[5].Split(',');

            numericComponent.Set((int)NumericType.Now_Lv, masterUnit.GetComponent<UserInfoComponent>().UserInfo.Lv , false);
            numericComponent.Set((int)NumericType.Base_MaxHp_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxHp) * float.Parse(attributeList_1[0])), false);
            numericComponent.Set((int)NumericType.Base_MinAct_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MinAct) * float.Parse(attributeList_1[1])), false);
            numericComponent.Set((int)NumericType.Base_MaxAct_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxAct) * float.Parse(attributeList_1[1])), false);
            numericComponent.Set((int)NumericType.Base_Mage_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Mage) * float.Parse(attributeList_1[2])), false);
            numericComponent.Set((int)NumericType.Base_MinDef_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxAct) * float.Parse(attributeList_1[3])), false);
            numericComponent.Set((int)NumericType.Base_MaxDef_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxAct) * float.Parse(attributeList_1[3])), false);
            numericComponent.Set((int)NumericType.Base_MinAdf_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxAct) * float.Parse(attributeList_1[4])), false);
            numericComponent.Set((int)NumericType.Base_MaxAdf_Base, (int)((float)masterUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MaxAct) * float.Parse(attributeList_1[4])), false);
            numericComponent.Set((int)NumericType.Base_Speed_Base, monsterConfig.MoveSpeed, false);
            numericComponent.Set((int)NumericType.Base_Cri_Base, monsterConfig.Cri, false);
            numericComponent.Set((int)NumericType.Base_Res_Base, monsterConfig.Res, false);
            numericComponent.Set((int)NumericType.Base_Hit_Base, monsterConfig.Hit, false);
            numericComponent.Set((int)NumericType.Base_Dodge_Base, monsterConfig.Dodge, false);
            numericComponent.Set((int)NumericType.Base_ActDamgeSubPro_Base, monsterConfig.DefAdd, false);
            numericComponent.Set((int)NumericType.Base_MageDamgeSubPro_Base, monsterConfig.AdfAdd, false);
            numericComponent.Set((int)NumericType.Base_DamgeSubPro_Base, monsterConfig.DamgeAdd, false);
            //设置当前血量
            numericComponent.Set((int)NumericType.Now_Hp, numericComponent.GetAsInt(NumericType.Now_MaxHp));
            //Log.Debug("初始化当前怪物血量:" + numericComponent.GetAsLong(NumericType.Now_Hp));

        }

        /// <summary>
        /// 角色属性模块初始化
        /// </summary>
        public static void InitMonsterInfo(this HeroDataComponent self, MonsterConfig monsterConfig, CreateMonsterInfo createMonsterInfo)
        {
            Unit nowUnit = self.GetParent<Unit>();
            NumericComponent numericComponent = nowUnit.GetComponent<NumericComponent>();

            float hpCoefficient = 1f;
            float ackCoefficient = 1f;
            //根据副本难度刷新属性
            //进入 挑战关卡 怪物血量增加 1.5 伤害增加 1.2 低于关卡 血量增加2 伤害增加 1.5
            int sceneType = nowUnit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            int fubenDifficulty = FubenDifficulty.None;
            switch (sceneType)
            {
                case SceneTypeEnum.CellDungeon:
                    fubenDifficulty = nowUnit.DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
                    break;
                case SceneTypeEnum.LocalDungeon:
                    fubenDifficulty = nowUnit.DomainScene().GetComponent<LocalDungeonComponent>().FubenDifficulty;
                    break;
                default:
                    break;
            }
            if (monsterConfig.MonsterType == MonsterTypeEnum.Boss)
            {
                switch (fubenDifficulty)
                {
                    case FubenDifficulty.TiaoZhan:
                        hpCoefficient = 1.5f;
                        ackCoefficient = 1.2f;
                        break;
                    case FubenDifficulty.DiYu:
                        hpCoefficient = 2f;
                        ackCoefficient = 1.5f;
                        break;
                }
            }

            //判定是否为成长怪物
            if (monsterConfig.MonsterSonType == 1)
            {
                int nowUserLv = nowUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                for (int i = 0; i < monsterConfig.Parameter.Length; i++)
                {
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterConfig.Parameter[i]);
                    if (nowUserLv >= monsterCof.Lv)
                    {
                        //指定等级对应属性
                        monsterConfig = monsterCof;
                    }
                }
            }

            //判定是否为成长怪物
            if (monsterConfig.MonsterSonType == 2)
            {
                MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(nowUnit.ConfigId);
                int nowUserLv = monsterCof.Lv;
                //nowUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                int playerLv = createMonsterInfo.PlayerLevel;
                string attribute = createMonsterInfo.AttributeParams;   //2;2
                float hpPro = float.Parse(attribute.Split(";")[0]);
                float otherPro = float.Parse(attribute.Split(";")[1]);
                ExpConfig expCof = ExpConfigCategory.Instance.Get(nowUserLv);
                monsterConfig.Hp = (int)(expCof.BaseHp * hpPro);
                monsterConfig.Act = (int)(expCof.BaseAct * otherPro);
                monsterConfig.Def = (int)(expCof.BaseDef * otherPro);
                monsterConfig.Adf = (int)(expCof.BaseAdf * otherPro);
                monsterConfig.Lv = playerLv;
            }

            numericComponent.Set((int)NumericType.Base_MaxHp_Base, (int)(monsterConfig.Hp * hpCoefficient), false);
            numericComponent.Set((int)NumericType.Base_MinAct_Base, (int)(monsterConfig.Act * ackCoefficient), false);
            numericComponent.Set((int)NumericType.Base_MaxAct_Base, (int)(monsterConfig.Act * ackCoefficient), false);
            numericComponent.Set((int)NumericType.Base_MinDef_Base, monsterConfig.Def, false);
            numericComponent.Set((int)NumericType.Base_MaxDef_Base, monsterConfig.Def, false);
            numericComponent.Set((int)NumericType.Base_MinAdf_Base, monsterConfig.Adf, false);
            numericComponent.Set((int)NumericType.Base_MaxAdf_Base, monsterConfig.Adf, false);
            numericComponent.Set((int)NumericType.Base_Speed_Base, monsterConfig.MoveSpeed, false);
            numericComponent.Set((int)NumericType.Base_Cri_Base, monsterConfig.Cri, false);
            numericComponent.Set((int)NumericType.Base_Res_Base, monsterConfig.Res, false);
            numericComponent.Set((int)NumericType.Base_Hit_Base, monsterConfig.Hit, false);
            numericComponent.Set((int)NumericType.Base_Dodge_Base, monsterConfig.Dodge, false);
            numericComponent.Set((int)NumericType.Base_ActDamgeSubPro_Base, monsterConfig.DefAdd, false);
            numericComponent.Set((int)NumericType.Base_MageDamgeSubPro_Base, monsterConfig.AdfAdd, false);
            numericComponent.Set((int)NumericType.Base_DamgeSubPro_Base, monsterConfig.DamgeAdd, false);

            //设置当前血量
            numericComponent.Set((int)NumericType.Now_Hp,  numericComponent.GetAsInt(NumericType.Now_MaxHp));
            //Log.Debug("初始化当前怪物血量:" + numericComponent.GetAsLong(NumericType.Now_Hp));
        }
#else

        public static void OnDead(this HeroDataComponent self, EventType.NumericChangeEvent args)
        {
            Unit unit = self.GetParent<Unit>();
            unit.GetComponent<SkillManagerComponent>()?.OnDispose();
            unit.GetComponent<BuffManagerComponent>()?.OnDispose();
            int sceneTypeEnum = args.Parent.ZoneScene().GetComponent<MapComponent>().SceneTypeEnum;
            if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                args.Parent.ZoneScene().GetComponent<CellDungeonComponent>().CheckChuansongOpen();
            }
            if (sceneTypeEnum == (int)SceneTypeEnum.LocalDungeon 
                && unit.Type == UnitType.Monster && unit.GetMonsterType() == (int)MonsterTypeEnum.Boss)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unit.ConfigId);
                self.ZoneScene().GetComponent<UserInfoComponent>().OnAddRevive(unit.ConfigId,TimeHelper.ServerNow() + (long)monsterConfig.ReviveTime * 1000);
            }
        }
#endif
        /// <summary>
        /// 更新当前角色身上的buff信息, 更新基础属性
        /// </summary>
        public static void BuffPropertyUpdate_Long(this HeroDataComponent self, int numericType ,long NumericTypeValue) {

            Unit nowUnit = self.GetParent<Unit>();
            NumericComponent numericComponent = nowUnit.GetComponent<NumericComponent>();
            long newvalue = numericComponent.GetAsLong(numericType) + NumericTypeValue;
            numericComponent.Set(numericType, newvalue);
        }

        public static void BuffPropertyUpdate_Float(this HeroDataComponent self, int numericType, float NumericTypeValue)
        {
            Unit nowUnit = self.GetParent<Unit>();
            NumericComponent numericComponent = nowUnit.GetComponent<NumericComponent>();
            float newvalue = numericComponent.GetAsFloat(numericType) + NumericTypeValue;
            numericComponent.Set(numericType, newvalue);
        }
    }
}