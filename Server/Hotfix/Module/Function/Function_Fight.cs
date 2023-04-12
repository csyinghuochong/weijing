using System;
using System.Collections.Generic;

namespace ET
{
    //[MessageHandler(AppType.Gate)]
    public class Function_Fight
    {
        private static readonly object obj = new object();
        //实例化自身
        private static Function_Fight _instance;
        public static Function_Fight GetInstance()
        {
            lock (obj)
            {
                if (_instance == null)
                {
                    _instance = new Function_Fight();
                }
            }
            return _instance;
        }

        /// <summary>
        /// 执行战斗
        /// </summary>
        /// <param name="attackUnit"></param>
        /// <param name="defendUnit"></param>
        public bool Fight(Unit attackUnit, Unit defendUnit, SkillHandler skillHandler)
        {
            bool playerPKStatus = false;
            if (attackUnit.Type == UnitType.Player && defendUnit.Type == UnitType.Player)
            {
                playerPKStatus = true;
            }

            SkillConfig skillconfig = skillHandler.SkillConf;
            //已死亡
            if (defendUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                return false;
            }
            //无敌buff，不受伤害
            if (defendUnit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.WuDi) && playerPKStatus == false)
            {
                return false;
            }

            if (attackUnit.GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.MiaoSha))
            {
                long hp = defendUnit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp)+1;
                defendUnit.GetComponent<NumericComponent>().ApplyChange(attackUnit, NumericType.Now_Hp, hp * -1, skillconfig.Id);
                return true;
            }

            int DamgeType = 0;      //伤害类型
            defendUnit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.BeHurt_3, attackUnit.Id);

            //获取攻击方属性
            NumericComponent numericComponentAttack = attackUnit.GetComponent<NumericComponent>();
            long attack_Hp = numericComponentAttack.GetAsLong(NumericType.Now_Hp);
            long attack_MaxHp = numericComponentAttack.GetAsLong(NumericType.Now_MaxHp);
            long attack_MinAct = numericComponentAttack.GetAsLong(NumericType.Now_MinAct);
            long attack_MaxAct = numericComponentAttack.GetAsLong(NumericType.Now_MaxAct);
            long attack_MageAct = numericComponentAttack.GetAsLong(NumericType.Now_Mage);
            long attack_MinDef = numericComponentAttack.GetAsLong(NumericType.Now_MinDef);
            long attack_MaxDef = numericComponentAttack.GetAsLong(NumericType.Now_MaxDef);

            float attackPet_hit = 0;
            float attackPet_cri = 0;

            //当前幸运
            int nowluck = numericComponentAttack.GetAsInt(NumericType.Now_Luck);
            float luckPro = 0;
            switch (nowluck)
            {
                case 0:
                    luckPro = 0.01f;
                    break;
                case 1:
                    luckPro = 0.02f;
                    break;
                case 2:
                    luckPro = 0.04f;
                    break;
                case 3:
                    luckPro = 0.08f;
                    break;
                case 4:
                    luckPro = 0.12f;
                    break;
                case 5:
                    luckPro = 0.2f;
                    break;
                case 6:
                    luckPro = 0.3f;
                    break;
                case 7:
                    luckPro = 0.4f;
                    break;
                case 8:
                    luckPro = 0.5f;
                    break;
                case 9:
                    luckPro = 1f;
                    break;

                default :
                    luckPro = 1f;
                    break;
            }

            if (RandomHelper.RandFloat01() <= luckPro)
            {
                attack_MinAct = attack_MaxAct;
            }

            //最低攻击之换算
            long minActAttack = (long)((attack_MaxAct * 0.5f) + attack_MaxAct * ((float)attack_MinAct / (float)attack_MaxAct) / 2);
            if (minActAttack > attack_MaxAct)
            {
                minActAttack = attack_MaxAct;
            }

            //获取攻击值
            long attack_Act = (long)RandomHelper.RandomNumberFloat(minActAttack, attack_MaxAct);
            if (attackUnit.Type == UnitType.Player)
            {
                //攻击强度和法术强度
                switch (attackUnit.GetComponent<UserInfoComponent>().UserInfo.Occ)
                {
                    //战士
                    case 1:
                        attack_Act += numericComponentAttack.GetAsLong(NumericType.Now_ActQiangDuAdd);
                        break;
                    //法师
                    case 2:
                        attack_Act += numericComponentAttack.GetAsLong(NumericType.Now_MageQiangDuAdd);
                        break;
                }
            }
            //long attack_def = (long)RandomHelper.RandomNumberFloat(attack_MinDef, attack_MaxDef);

            //获取受击方属性
            NumericComponent numericComponentDefend = defendUnit.GetComponent<NumericComponent>();
            //long defend_Hp = numericComponentDefend.GetAsLong(NumericType.Now_Hp);
            //long defend_MaxHp = numericComponentDefend.GetAsLong(NumericType.Now_MaxHp);
            long defend_MinAct = numericComponentDefend.GetAsLong(NumericType.Now_MinAct);
            long defend_MaxAct = numericComponentDefend.GetAsLong(NumericType.Now_MaxAct);
            long defend_MinDef = numericComponentDefend.GetAsLong(NumericType.Now_MinDef);
            long defend_MaxDef = numericComponentDefend.GetAsLong(NumericType.Now_MaxDef);
            long defend_MinAdf = numericComponentDefend.GetAsLong(NumericType.Now_MinAdf);
            long defend_MaxAdf = numericComponentDefend.GetAsLong(NumericType.Now_MaxAdf);

            //忽视防御
            defend_MinDef = (long)((float)defend_MinDef * (1.0f - numericComponentAttack.GetAsFloat(NumericType.Now_HuShiActPro)) - numericComponentAttack.GetAsLong(NumericType.Now_HuShiDef));
            defend_MaxDef = (long)((float)defend_MaxDef * (1.0f - numericComponentAttack.GetAsFloat(NumericType.Now_HuShiActPro)) - numericComponentAttack.GetAsLong(NumericType.Now_HuShiDef));
            defend_MinAdf = (long)((float)defend_MinAdf * (1.0f - numericComponentAttack.GetAsFloat(NumericType.Now_HuShiMagePro)) - numericComponentAttack.GetAsLong(NumericType.Now_HuShiAdf));
            defend_MaxAdf = (long)((float)defend_MaxAdf * (1.0f - numericComponentAttack.GetAsFloat(NumericType.Now_HuShiMagePro)) - numericComponentAttack.GetAsLong(NumericType.Now_HuShiAdf));

            //限制
            defend_MinDef = defend_MinDef < 0 ? 0 : defend_MinDef;
            defend_MaxDef = defend_MaxDef < 0 ? 0 : defend_MaxDef;
            defend_MinAdf = defend_MinAdf < 0 ? 0 : defend_MinAdf;
            defend_MaxAdf = defend_MaxAdf < 0 ? 0 : defend_MaxAdf;

            long defend_Act = (long)RandomHelper.RandomNumberFloat(defend_MinAct, defend_MaxAct);
            long defend_def = (long)RandomHelper.RandomNumberFloat(defend_MinDef, defend_MaxDef);
            long defend_adf = (long)RandomHelper.RandomNumberFloat(defend_MinAdf, defend_MaxAdf);

            float defendPet_dodge = 0;

            bool ifMonsterBoss_Act = false;
            bool ifMonsterBoss_Def = false;
            bool petfuben = false;

            //计算是否闪避
            int defendUnitLv = 0;
            defendUnit.GetComponent<SkillManagerComponent>().InterruptSing(0,false);
            switch (defendUnit.Type) 
            {
                //怪物
                case UnitType.Monster:
                    int sceneType = defendUnit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
                    petfuben = sceneType == SceneTypeEnum.PetDungeon;

                    defendUnit.GetComponent<AIComponent>()?.BeAttacking(attackUnit);
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(defendUnit.ConfigId);
                    defendUnitLv = monsterCof.Lv;
                    if (monsterCof.MonsterType == (int)MonsterTypeEnum.Boss)
                    {
                        ifMonsterBoss_Act = true;
                    }
                    break;
                //宠物
                case UnitType.Pet:
                    defendUnit.GetComponent<AIComponent>()?.BeAttacking(attackUnit);
                    PetConfig petCof = PetConfigCategory.Instance.Get(defendUnit.ConfigId);
                    defendUnitLv = petCof.PetLv;
                    defend_def += numericComponentAttack.GetAsLong(NumericType.Now_PetAllDef);
                    defend_adf += numericComponentAttack.GetAsLong(NumericType.Now_PetAllAdf);
                    defendPet_dodge += numericComponentAttack.GetAsFloat(NumericType.Now_PetAllDodge);
                    break;
                //玩家
                case UnitType.Player:
                    defendUnitLv = defendUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                    defendUnit.GetComponent<AttackRecordComponent>().BeAttackId = attackUnit.Id;
                    break;
            }

            int attackUnitLv = 0;
            switch (attackUnit.Type)
            {
                //怪物
                case UnitType.Monster:
                    MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(attackUnit.ConfigId);
                    attackUnitLv = monsterCof.Lv;
                    if (monsterCof.MonsterType == (int)MonsterTypeEnum.Boss)
                        ifMonsterBoss_Def = true;
                    break;
                //宠物
                case UnitType.Pet:
                    PetConfig petCof = PetConfigCategory.Instance.Get(attackUnit.ConfigId);
                    attackUnitLv = petCof.PetLv;

                    //增加宠物属性
                    attack_MaxAct += numericComponentAttack.GetAsLong(NumericType.Now_PetAllAct);
                    attack_MageAct += numericComponentAttack.GetAsLong(NumericType.Now_PetAllMageAct);
                    attackPet_hit += numericComponentAttack.GetAsFloat(NumericType.Now_PetAllHit);
                    attackPet_cri += numericComponentAttack.GetAsFloat(NumericType.Now_PetAllCri);
                    break;
                //玩家
                case UnitType.Player:
                    attackUnitLv = attackUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                    attackUnit.GetComponent<AttackRecordComponent>().AttackingId = defendUnit.Id;
                    break;
            }

            //float addHitPro = numericComponentAttack.GetAsFloat(NumericType.Now_Hit) + LvProChange(numericComponentAttack.GetAsLong(NumericType.Now_Hit), defendUnitLv);
            //float addDodgePro = numericComponentDefend.GetAsFloat(NumericType.Now_Dodge) + LvProChange(numericComponentDefend.GetAsLong(NumericType.Now_Dodge), attackUnitLv);
            float addHitPro = numericComponentAttack.GetAsFloat(NumericType.Now_Hit);
            float addDodgePro = numericComponentDefend.GetAsFloat(NumericType.Now_Dodge);

            float addHitLvPro = LvProChange(numericComponentAttack.GetAsLong(NumericType.Now_HitLv), defendUnitLv);
            float addDodgeLvPro = LvProChange(numericComponentAttack.GetAsLong(NumericType.Now_DodgeLv), attackUnitLv);

            addHitPro += addHitLvPro;
            addDodgePro += addDodgeLvPro;

            //等级差命中
            float HitLvPro = (attackUnitLv - defendUnitLv) * 0.03f;
            if (HitLvPro <= 0) {
                HitLvPro = 0;
            }
            if (HitLvPro >= 0.1f) {
                HitLvPro = 0.1f;
            }

            //等级差闪避
            float DodgeLvPro = (attackUnitLv - defendUnitLv) * 0.03f;
            if (DodgeLvPro <= 0)
            {
                DodgeLvPro = 0;
            }
            if (DodgeLvPro >= 0.1f)
            {
                DodgeLvPro = 0.1f;
            }

            float initHitPro = 0.9f;
            float HitPro = initHitPro + HitLvPro + addHitPro + attackPet_hit - (addDodgePro + DodgeLvPro + defendPet_dodge);

            //pk命中
            if (playerPKStatus) {
                HitPro -= numericComponentDefend.GetAsFloat(NumericType.Now_PlayerHitSubPro);
            }

            //最低命中
            if (HitPro <= 0.75f) {
                HitPro = 0.75f;
            }

            //闪避概率..
            bool ifHit = true;
            if (RandomHelper.RandFloat() >= HitPro)
            {
                ifHit = false;
            }

            //技能闪避
            if (skillconfig.SkillActType == 1)
            {
                if (RandomHelper.RandFloat() <= numericComponentAttack.GetAsFloat(NumericType.Now_SkillDodgePro))
                {
                    ifHit = true;
                }
            }

            //物理闪避
            if (skillconfig.DamgeType == 1)
            {
                if (RandomHelper.RandFloat() <= numericComponentAttack.GetAsFloat(NumericType.Now_ActDodgePro))
                {
                    ifHit = true;
                }
            }

            //魔法闪避
            if (skillconfig.DamgeType == 2)
            {
                if (RandomHelper.RandFloat() <= numericComponentAttack.GetAsFloat(NumericType.Now_MageDodgePro))
                {
                    ifHit = true;
                }
            }

            if (ifHit)
            {
                //判定是否触发重击
                long actValue = attack_Act;
                long defValue = defend_def;
                long adfValue = defend_adf;
                float zhongJiPro = numericComponentAttack.GetAsFloat(NumericType.Now_ZhongJiPro);
                if (RandomHelper.RandFloat() <= zhongJiPro) {
                    defValue = 0;
                    actValue += numericComponentAttack.GetAsLong(NumericType.Now_ZhongJi);
                }

                //判定是否无视防御
                float wushiPro = numericComponentAttack.GetAsFloat(NumericType.Now_WuShiFangYuPro);
                if (RandomHelper.RandFloat() <= wushiPro)
                {
                    defValue = 0;
                    adfValue = 0;
                }

                long nowdef = defValue;

                //伤害类型 物理/魔法
                if (skillconfig.DamgeType == 2) {
                    nowdef = adfValue;
                }

                //技能加成
                if (skillconfig.SkillActType == 1) {
                    actValue += attack_MageAct;
                }

                //宠物远程攻击用魔法
                if (attackUnit.Type == UnitType.Pet && skillconfig.SkillActType == 1) {
                    actValue = attack_MageAct;
                }

                //计算战斗公式
                long damge = (actValue - nowdef);

                //查看对应武器
                float weaponAddAct = 0;
                switch(UnitHelper.GetWeaponType(attackUnit))
                {
                    //刀
                    case 1:
                        weaponAddAct = numericComponentAttack.GetAsFloat(NumericType.Now_DaoActAddPro);
                        break;
                    //剑
                    case 2:
                        weaponAddAct = numericComponentAttack.GetAsFloat(NumericType.Now_JianActAddPro);
                        break;
                    //法杖
                    case 3:
                        weaponAddAct = numericComponentAttack.GetAsFloat(NumericType.Now_FaZhangActAddPro);
                        break;
                    //魔法书
                    case 4:
                        weaponAddAct = numericComponentAttack.GetAsFloat(NumericType.Now_ShuActAddPro);
                        break;
                }

                if (weaponAddAct >= 1f) {
                    weaponAddAct = 1f;
                }

                //武器伤害加成
                if (weaponAddAct > 0)
                {
                    damge = (long)((float)damge * (1f + weaponAddAct));
                }

                //怪物打宠物降低 （如果有需要 后期需要加入判定是不是当前怪物的普通攻击来判断躲避技能）
                if (attackUnit.Type == UnitType.Monster && defendUnit.Type == UnitType.Pet && petfuben == false)
                {
                    //普攻受到40%伤害
                    if (skillconfig.SkillActType == 0)
                    {
                        damge = (int)((float)damge * 0.4f);
                    }

                    //技能受到10%伤害
                    if (skillconfig.SkillActType == 1)
                    {
                        damge = (int)((float)damge * 0.1f);
                    }
                }

                //怪物打玩家
                if (attackUnit.Type == UnitType.Monster && defendUnit.Type == UnitType.Player)
                {
                    //战士降低受到怪物普攻20%的伤害
                    if (defendUnit.GetComponent<UserInfoComponent>().UserInfo.Occ == 1) {

                        if (skillconfig.SkillActType == 0)
                        {
                            damge = (int)((float)damge * 0.7f);
                        }

                        //技能受到10%伤害
                        /*
                        if (skillconfig.SkillActType == 1)
                        {
                            damge = (int)((float)damge * 0.1f);
                        }
                        */
                    }

                }

                //技能倍伤
                if (skillconfig.SkillActType == 1)
                {
                    nowdef = adfValue;
                }

                //魔法伤害无法被抵消是固定伤害,技能附带加成
                double skillProAdd = 0;
                if (skillconfig.SkillActType == 1)
                {
                    if (RandomHelper.RandFloat() <= numericComponentAttack.GetAsFloat(NumericType.Now_SkillMoreDamgePro))
                    {
                        skillProAdd = 0.5f;
                    }
                }

                //获取技能相关系数
                damge = (long)(damge * ( skillconfig.ActDamge  + skillHandler.ActTargetTemporaryAddPro + skillHandler.ActTargetAddPro + skillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageCoefficient) + skillProAdd)) + skillconfig.DamgeValue;

                float damgePro = 1;
                //伤害加成
                damge = (long)((float)damge * (1 + numericComponentAttack.GetAsFloat(NumericType.Now_DamgeAddPro) - numericComponentDefend.GetAsFloat(NumericType.Now_DamgeSubPro)));

                //物理伤害
                if (skillconfig.DamgeType == 1) 
                {

                    damgePro = damgePro + numericComponentAttack.GetAsFloat(NumericType.Now_ActDamgeAddPro) - numericComponentDefend.GetAsFloat(NumericType.Now_ActDamgeSubPro);

                    if (ifMonsterBoss_Act)
                    {
                        damgePro += numericComponentAttack.GetAsFloat(NumericType.Now_ActBossPro);
                    }

                    if (ifMonsterBoss_Def) 
                    {
                        damgePro -= numericComponentAttack.GetAsFloat(NumericType.Now_ActBossSubPro);
                    }
 
                }

                //技能伤害
                if (skillconfig.DamgeType == 1)
                {

                    damgePro = damgePro + numericComponentAttack.GetAsFloat(NumericType.Now_MageDamgeAddPro) - numericComponentDefend.GetAsFloat(NumericType.Now_MageDamgeSubPro);

                    if (ifMonsterBoss_Act)
                    {
                        damgePro += numericComponentAttack.GetAsFloat(NumericType.Now_MageBossPro);
                    }

                    if (ifMonsterBoss_Def)
                    {
                        damgePro -= numericComponentAttack.GetAsFloat(NumericType.Now_MageBossSubPro);
                    }
                }

                //是否触发斩杀
                float defHpPro = (float)numericComponentDefend.GetAsInt(NumericType.Now_Hp)/ (float)numericComponentDefend.GetAsInt(NumericType.Now_MaxHp);
                if (defHpPro<=0.3f) {
                    damgePro += numericComponentAttack.GetAsFloat(NumericType.Now_ZhanShaPro);
                }
                

                //普攻加成
                if (skillconfig.SkillActType == 0)
                {
                    //普攻属性加成
                    damgePro += numericComponentAttack.GetAsFloat(NumericType.Now_PuGongAddPro);

                    //血量降低转换普攻伤害
                    float hpDamgePro = numericComponentAttack.GetAsFloat(NumericType.Now_HpToDamgeAddPro);
                    if (hpDamgePro > 0)
                    {
                        float acthpPro = (float)numericComponentAttack.GetAsInt(NumericType.Now_Hp) / (float)numericComponentAttack.GetAsInt(NumericType.Now_MaxHp);
                        if (acthpPro < 1 && acthpPro > 0)
                        {
                            if (acthpPro >= 0.6f)
                            {
                                //大于0.5
                                damgePro += (1f - acthpPro) / 4 * hpDamgePro;
                            }
                            else if (acthpPro >= 0.3f)
                            {
                                damgePro += (1f - acthpPro) / 2f * hpDamgePro;
                            }
                            else
                            {
                                damgePro += (1f - acthpPro) / 1.5f * hpDamgePro;
                            }
                        }
                    }
                }

                //抗性
                switch (skillconfig.DamgeElementType) {
                    //光     神圣抗性
                    case 1:
                        damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_Resistance_Shine_Pro);
                        break;
                    //暗     暗影抗性
                    case 2:
                        damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_Resistance_Shadow_Pro);
                        break;
                    //火     火焰抗性
                    case 3:
                        damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_ResistIcece_Ice_Pro);
                        break;
                    //水     冰霜抗性
                    case 4:
                        damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_ResistFirece_Fire_Pro);
                        break;
                    //电     闪电抗性
                    case 5:
                        damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_ResistThunderce_Thunder_Pro);
                        break;
                }

                //种族抗性
                if (ifMonsterBoss_Act) {
                    switch (MonsterConfigCategory.Instance.Get(defendUnit.ConfigId).MonsterRace) {
                        //通用
                        case 0:
                            break;
                        //野兽
                        case 1:
                            damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_Resistance_Beast_Pro);
                            break;
                        //人类
                        case 2:
                            damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_Resistance_Hum_Pro);
                            break;
                        //恶魔
                        case 3:
                            damgePro = damgePro - numericComponentDefend.GetAsFloat(NumericType.Now_Resistance_Demon_Pro);
                            break;
                    }
                }

                //种族伤害
                if (ifMonsterBoss_Def) {
                    switch (MonsterConfigCategory.Instance.Get(attackUnit.ConfigId).MonsterRace)
                    {
                        //通用
                        case 0:
                            break;
                        //野兽
                        case 1:
                            damgePro = damgePro + numericComponentAttack.GetAsFloat(NumericType.Now_Damge_Beast_Pro);
                            break;
                        //人类
                        case 2:
                            damgePro = damgePro + numericComponentAttack.GetAsFloat(NumericType.Now_Damge_Hum_Pro);
                            break;
                        //恶魔
                        case 3:
                            damgePro = damgePro + numericComponentAttack.GetAsFloat(NumericType.Now_Damge_Demon_Pro);
                            break;
                    }
                }

                //pk相关
                if (playerPKStatus) {
                    //玩家之间PK伤害降低80%
                    damgePro -= 0.3f;
                    damgePro -= numericComponentDefend.GetAsFloat(NumericType.Now_PlayerAllDamgeSubPro);
                    //普通攻击降低
                    if (skillconfig.SkillActType == 0)
                    {
                        damgePro -= numericComponentDefend.GetAsFloat(NumericType.Now_PlayerActDamgeSubPro);
                    }
                    //技能伤害降低
                    if (skillconfig.SkillActType == 1)
                    {
                        damgePro -= numericComponentDefend.GetAsFloat(NumericType.Now_PlayerSkillDamgeSubPro);
                    }
                }

                damgePro = damgePro < 0 ? 0 : damgePro;
                damge = (int)(damge * damgePro);

                //格挡值抵消
                damge = damge - numericComponentDefend.GetAsLong(NumericType.Now_GeDang);

                if (damge < 1)
                {
                    damge = 1;
                }

                //真实伤害
                damge += numericComponentAttack.GetAsLong(NumericType.Now_ZhenShi);

                damge += (long)skillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageValue);

                //二次限定
                if (damge < 1)
                {
                    damge = 1;
                }

                //存储是为万为单位的
                //damge = (damge / 10000 * 10000);
                if (damge > 0)
                {
                    //等级换算最终属性
                    //float addCriPro = numericComponentAttack.GetAsFloat(NumericType.Now_Cri) + LvProChange(numericComponentAttack.GetAsLong(NumericType.Now_CriLv), defendUnitLv);
                    //float addResPro = numericComponentDefend.GetAsFloat(NumericType.Now_Res) + LvProChange(numericComponentDefend.GetAsLong(NumericType.Now_Res), attackUnitLv);
                    float addCriPro = numericComponentAttack.GetAsFloat(NumericType.Now_Cri);
                    float addResPro = numericComponentDefend.GetAsFloat(NumericType.Now_Res);

                    float addCriLvPro = LvProChange(numericComponentAttack.GetAsLong(NumericType.Now_CriLv), defendUnitLv);
                    float addResLvPro = LvProChange(numericComponentAttack.GetAsLong(NumericType.Now_ResLv), attackUnitLv);

                    addCriPro += addCriLvPro;
                    addResPro += addResLvPro;

                    float CriPro = addCriPro + attackPet_cri - addResPro ;

                    //pk命中
                    if (playerPKStatus)
                    {
                        CriPro -= numericComponentDefend.GetAsFloat(NumericType.Now_PlayerCriSubPro);
                    }


                    if (CriPro <= 0f)
                    {
                        CriPro = 0;
                    }

                    //暴击概率..
                    if (RandomHelper.RandFloat() <= CriPro)
                    {
                        DamgeType = 1;
                        damge = (long)((float)damge * 1.75f);
                        //Log.Debug("暴击了!");

                        //闪避触发被动技能
                        attackUnit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.Critical_4, defendUnit.Id);
                    }


                    //是否触发秒杀
                    if (defHpPro <= 0.2f)
                    {
                        float miaoshaPro = numericComponentAttack.GetAsFloat(NumericType.Now_MiaoSha_Pro);
                        if (RandomHelper.RandFloat01() < miaoshaPro)
                        {
                            damge += numericComponentDefend.GetAsInt(NumericType.Now_Hp);
                        }
                    }

                    int shield_Hp = numericComponentDefend.GetAsInt(NumericType.Now_Shield_HP);
                        float shield_pro = numericComponentDefend.GetAsFloat(NumericType.Now_Shield_DamgeCostPro);
                    if (shield_Hp > 0)
                    {
                        int dunDamge = (int)((float)damge * shield_pro);
                        damge -= dunDamge;
                        damge = Math.Max(0, damge);
                        numericComponentDefend.ApplyChange(attackUnit, NumericType.Now_Shield_HP, -1 * dunDamge, skillconfig.Id, true, DamgeType);
                    }
                    //吸血处理(普通攻击触发吸血)
                    if (skillconfig.SkillActType == 0)
                    {
                        float hushi = numericComponentAttack.GetAsFloat(NumericType.Now_XiXuePro);
                        if (hushi > 0f)
                        {
                            int addHp = (int)((float)damge * hushi);
                            numericComponentAttack.ApplyChange(attackUnit, NumericType.Now_Hp, addHp, 0);
                        }
                    }

                    damge *= -1;
                }
                if (defendUnit.IsDisposed)
                {
                    return false;
                }
                if (defendUnit.Type == UnitType.Monster && ifMonsterBoss_Act)
                {
                    defendUnit.GetComponent<AttackRecordComponent>().BeAttacking(attackUnit, damge);
                }

                //即将死亡
                if (defendUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp) + damge <= 0)
                {
                    //判定是否复活
                    if (RandomHelper.RandFloat01() < defendUnit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_FuHuoPro))
                    {
                        //复活存在30%的血量
                        numericComponentDefend.ApplyChange(null, NumericType.Now_Hp, (int)(numericComponentAttack.GetAsInt(NumericType.Now_MaxHp) * 0.3f), 0);
                    }
                    else if(RandomHelper.RandFloat01() < defendUnit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_ShenYouPro) )
                    {
                        //神佑存在100%的血量
                        numericComponentDefend.ApplyChange(null, NumericType.Now_Hp, (int)(numericComponentAttack.GetAsInt(NumericType.Now_MaxHp) * 1f), 0);
                    }
                    else
                    {
                        //死亡
                        defendUnit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.WillDead_6, attackUnit.Id);
                    }
                }
                //普通攻击反弹伤害
                if (defendUnit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_ActReboundDamgePro) > 0 && skillconfig.DamgeType == 1) {
                    int fantanValue = (int)((float)damge * defendUnit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_ActReboundDamgePro));
                    attackUnit.GetComponent<NumericComponent>().ApplyChange(attackUnit, NumericType.Now_Hp, fantanValue, skillconfig.Id, true, DamgeType);
                }
                if (attackUnit.IsDisposed ==false)
                {
                    //设置目标当前
                    defendUnit.GetComponent<NumericComponent>().ApplyChange(attackUnit, NumericType.Now_Hp, damge, skillconfig.Id, true, DamgeType);

                    //攻击方反弹即将死亡
                    if (attackUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Hp) <= 0)
                    {
                        //死亡
                        attackUnit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.WillDead_6, attackUnit.Id);
                    }
                }
            }
            else
            {
                //设置伤害为0,用于伤害飘字
                defendUnit.GetComponent<NumericComponent>().ApplyChange(attackUnit, NumericType.Now_Hp, 0, skillconfig.Id, true, DamgeType);

                //闪避触发被动技能
                defendUnit.GetComponent<SkillPassiveComponent>().OnTrigegerPassiveSkill(SkillPassiveTypeEnum.ShanBi_5, attackUnit.Id);
            }
            return ifHit;
        }

        //暴击等级等属性转换成实际暴击率的方法
        public static float LvProChange(long value, int lv) {
            float proValue = (float)value / (float)(7500 + lv * 250);
            if (proValue < 0) {
                proValue = 0;
            }
            if (proValue > 0.75f) {
                proValue = 0.75f;
            }
            return proValue;
        }

        //字典是引用,进来的值会发生改变
        public static void AddUpdateProDicList(int typeID, long typeValue, Dictionary<int, long> dic)
        {
            //缓存属性
            if (dic.ContainsKey(typeID))
            {
                dic[typeID] += typeValue;
            }
            else
            {
                dic[typeID] = typeValue;
            }

        }

        //是否是一级属性
        public static bool ifNumTypeOnePro(int numericType)
        {

            if (numericType < (int)NumericType.Max)
            {
                numericType = numericType * 100;
            }
            int nowValue = (int)numericType / 100;
            if (nowValue == NumericType.Now_Power || nowValue == NumericType.Now_Agility || nowValue == NumericType.Now_Intellect || nowValue == NumericType.Now_Stamina || nowValue == NumericType.Now_Constitution)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //字典是引用,进来的值会发生改变
        public static int GetOnePro(int typeID, Dictionary<int, long> dic)
        {

            if (ifNumTypeOnePro(typeID))
            {
                //缓存属性
                int baseType = typeID * 100 +1;
                int mulType = typeID * 100 + 2;
                int addType = typeID * 100 + 3;
                long baseValue = 0;
                float mulValue = 0;
                long addValue = 0;
                if (dic.ContainsKey(baseType))
                {
                    baseValue = dic[baseType];
                }
                if (dic.ContainsKey(mulType))
                {
                    mulValue = (float)dic[mulType]/ 10000f;
                }
                if (dic.ContainsKey(addType))
                {
                    addValue = dic[addType];
                }

                return (int)(baseValue * (1 + mulValue) + addValue);

            }

            return 0;
        }

        /// <summary>
        /// 更新基础的属性
        /// </summary>
        /// <param name="unit"></param>
        public int UnitUpdateProperty_Base(Unit unit, bool notice, bool rank)
        {
            //基础职业属性
            UserInfoComponent UnitInfoComponent = unit.GetComponent<UserInfoComponent>();
            UserInfo userInfo = UnitInfoComponent.UserInfo;
            int roleLv = userInfo.Lv;

            //初始化属性
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ResetProperty();

            //缓存列表
            Dictionary<int, long> UpdateProDicList = new Dictionary<int, long>();

            //属性点
            int PointLiLiang = numericComponent.GetAsInt(NumericType.PointLiLiang);
            int PointZhiLi = numericComponent.GetAsInt(NumericType.PointZhiLi);
            int PointTiZhi = numericComponent.GetAsInt(NumericType.PointTiZhi);
            int PointNaiLi = numericComponent.GetAsInt(NumericType.PointNaiLi);
            int PointMinJie = numericComponent.GetAsInt(NumericType.PointMinJie);

            //每升一级属性+1所以这里有加成
            PointLiLiang += roleLv * 2;
            PointZhiLi += roleLv * 2;
            PointTiZhi += roleLv * 2;
            PointNaiLi += roleLv * 2;
            PointMinJie += roleLv * 2;

            OccupationConfig mOccupationConfig = OccupationConfigCategory.Instance.Get(1);

            long occBaseHp = mOccupationConfig.BaseHp + roleLv * mOccupationConfig.LvUpHp + PointTiZhi * 90 ;
            long occBaseMinAct = mOccupationConfig.BaseMinAct + roleLv * mOccupationConfig.LvUpMinAct + PointLiLiang * 4 + PointMinJie * 6;
            long occBaseMaxAct = mOccupationConfig.BaseMaxAct + roleLv * mOccupationConfig.LvUpMaxAct + PointLiLiang * 4 + PointMinJie * 6;
            long occBaseMinMage = mOccupationConfig.LvUpMinMagAct + roleLv * mOccupationConfig.LvUpMinMagAct + PointZhiLi * 8;
            long occBaseMaxMage = mOccupationConfig.LvUpMaxMagAct + roleLv * mOccupationConfig.LvUpMaxMagAct + PointZhiLi * 8;
            long occBaseMinDef = mOccupationConfig.BaseMinDef + roleLv * mOccupationConfig.LvUpMinDef + PointNaiLi * 6 + (int)((float)PointLiLiang * 4f);
            long occBaseMaxDef = mOccupationConfig.BaseMaxDef + roleLv * mOccupationConfig.LvUpMaxAdf + PointNaiLi * 6 + (int)((float)PointLiLiang * 4f);
            long occBaseMinAdf = mOccupationConfig.BaseMinAdf + roleLv * mOccupationConfig.LvUpMinAdf + PointNaiLi * 6 + (int)((float)PointZhiLi * 4f);
            long occBaseMaxAdf = mOccupationConfig.BaseMaxAdf + roleLv * mOccupationConfig.LvUpMaxAdf + PointNaiLi * 6 + (int)((float)PointZhiLi * 4f);

            double occBaseMoveSpeed = mOccupationConfig.BaseMoveSpeed;
            double occBaseCri = mOccupationConfig.BaseCri;
            double occBaseHit = mOccupationConfig.BaseHit;
            double occBaseDodge = mOccupationConfig.BaseDodge;
            double occBaseDefSub = mOccupationConfig.BaseDefAdd;
            double occBaseAdfSub = mOccupationConfig.BaseAdfAdd;
            double occBaseDamgeSubAdd = mOccupationConfig.DamgeAdd;

            //装备属性
            List<int> equipIDList = new List<int>();
            List<int> equipSuitIDList = new List<int>();
            List<BagInfo> equipList = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip);
            for (int i = equipList.Count - 1; i >= 0; i--)
            {
                BagInfo userBagInfo = equipList[i];
                if (!ItemConfigCategory.Instance.Contain(userBagInfo.ItemID))
                {
                    equipList.RemoveAt(i);
                    continue;
                }

                //存储装备ID
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(userBagInfo.ItemID);

                //生肖装备没激活直接跳出来
                if (itemCof.EquipType == 101 && ItemHelper.IfShengXiaoActive(itemCof.Id, equipList) == false) {
                    continue;
                }

                bool ifAddHidePro = true;
                int occTwoValue = unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo;
                if (occTwoValue != 0)
                {
                    if (itemCof.EquipType == 11 || itemCof.EquipType == 12 || itemCof.EquipType == 13 && equipList[i].Loc == (int)ItemLocType.ItemLocEquip)
                    {
                        int selfMastery = OccupationTwoConfigCategory.Instance.Get(occTwoValue).ArmorMastery;
                        if (selfMastery != itemCof.EquipType)
                        {
                            //护甲不匹配不添加专精数据
                            ifAddHidePro = false;
                        }
                    }
                }

                if (ifAddHidePro)
                {
                    //存储装备精炼数值
                    if (userBagInfo.HideProLists != null)
                    {
                        for (int y = 0; y < userBagInfo.HideProLists.Count; y++)
                        {
                            HideProList hidePro = userBagInfo.HideProLists[y];
                            AddUpdateProDicList(hidePro.HideID, hidePro.HideValue, UpdateProDicList);
                        }
                    }
                }

                //存储洗炼数值
                if (userBagInfo.XiLianHideProLists != null)
                {
                    for (int y = 0; y < userBagInfo.XiLianHideProLists.Count; y++)
                    {
                        HideProList hidePro = userBagInfo.XiLianHideProLists[y];
                        AddUpdateProDicList(hidePro.HideID, hidePro.HideValue, UpdateProDicList);
                    }
                }

                //存储洗炼数值
                if (userBagInfo.XiLianHideTeShuProLists != null)
                {
                    for (int y = 0; y < userBagInfo.XiLianHideTeShuProLists.Count; y++)
                    {

                        HideProList hidePro = userBagInfo.XiLianHideTeShuProLists[y];
                        HideProListConfig hideproCof = HideProListConfigCategory.Instance.Get(hidePro.HideID);
                        AddUpdateProDicList(hideproCof.PropertyType, hidePro.HideValue, UpdateProDicList);
                    }
                }

                //存储附魔属性
                if (userBagInfo.FumoProLists != null)
                {
                    for (int y = 0; y < userBagInfo.FumoProLists.Count; y++)
                    {
                        HideProList hidePro = userBagInfo.FumoProLists[y];
                        AddUpdateProDicList(hidePro.HideID, hidePro.HideValue, UpdateProDicList);
                    }
                }

                //存储装备ID
                equipIDList.Add(itemCof.ItemEquipID);

                //存储装备套装
                EquipConfig equipCnf = EquipConfigCategory.Instance.Get(itemCof.ItemEquipID);
                if (equipCnf.EquipSuitID != 0)
                {
                    if (equipSuitIDList.Contains(equipCnf.EquipSuitID) == false)
                    {
                        equipSuitIDList.Add(equipCnf.EquipSuitID);
                    }
                }
            }

            long BaseHp_EquipSuit = 0;
            long BaseMinAct_EquipSuit = 0;
            long BaseMaxAct_EquipSuit = 0;
            long BaseMinMage_EquipSuit = 0;
            long BaseMaxMage_EquipSuit = 0;
            long BaseMinDef_EquipSuit = 0;
            long BaseMaxDef_EquipSuit = 0;
            long BaseMinAdf_EquipSuit = 0;
            long BaseMaxAdf_EquipSuit = 0;

            double BaseMoveSpeed_EquipSuit = 0;
            double BaseCri_EquipSuit = 0;
            double BaseHit_EquipSuit = 0;
            double BaseDodge_EquipSuit = 0;

            //double BaseDefSub_EquipSuit = 0;
            //double BaseAdfSub_EquipSuit = 0;
            double BaseDamgeAdd_EquipSuit = 0;
            double BaseDamgeSub_EquipSuit = 0;

            //装备套装属性
            for (int i = 0; i < equipSuitIDList.Count; i++)
            {

                EquipSuitConfig equipSuitCof = EquipSuitConfigCategory.Instance.Get(equipSuitIDList[i]);
                string[] needEquipList = equipSuitCof.NeedEquipID.Split(';');
                int num = 0;
                for (int y = 0; y < needEquipList.Length; y++)
                {
                    int needEquipID = int.Parse(needEquipList[y]);
                    if (equipIDList.Contains(needEquipID))
                    {
                        num = num + 1;
                    }
                }

                string[] equipSuitProList = equipSuitCof.SuitPropertyID.Split(';');

                for (int y = 0; y < equipSuitProList.Length; y++)
                {

                    int NeedNum = int.Parse(equipSuitProList[y].Split(',')[0]);
                    int NeedID = int.Parse(equipSuitProList[y].Split(',')[1]);
                    if (num >= NeedNum)
                    {
                        //激活对应套装属性
                        EquipSuitPropertyConfig equipSuitProCof = EquipSuitPropertyConfigCategory.Instance.Get(NeedID);
                        BaseHp_EquipSuit += equipSuitProCof.Equip_Hp;
                        BaseMinAct_EquipSuit += equipSuitProCof.Equip_MinAct;
                        BaseMaxAct_EquipSuit += equipSuitProCof.Equip_MaxAct;
                        BaseMinMage_EquipSuit += equipSuitProCof.Equip_MinMagAct;
                        BaseMaxMage_EquipSuit += equipSuitProCof.Equip_MaxMagAct;
                        BaseMinDef_EquipSuit += equipSuitProCof.Equip_MinDef;
                        BaseMaxDef_EquipSuit += equipSuitProCof.Equip_MaxDef;
                        BaseMinAdf_EquipSuit += equipSuitProCof.Equip_MinAdf;
                        BaseMaxAdf_EquipSuit += equipSuitProCof.Equip_MaxAdf;
                        BaseMoveSpeed_EquipSuit += equipSuitProCof.Equip_Speed;
                        BaseCri_EquipSuit += equipSuitProCof.Equip_Cri;
                        BaseHit_EquipSuit += equipSuitProCof.Equip_Hit;
                        BaseDodge_EquipSuit += equipSuitProCof.Equip_Dodge;
                        BaseDamgeAdd_EquipSuit += equipSuitProCof.Equip_DamgeAdd;
                        BaseDamgeSub_EquipSuit += equipSuitProCof.Equip_DamgeSub;
                        //BaseDamgeSubAdd_EquipSuit += equipSuitProCof.Equip_Hp;

                        if (equipSuitProCof.AddPropreListStr != "0")
                        {
                            string[] AddPropreList = equipSuitProCof.AddPropreListStr.Split(';');
                            for (int z = 0; z < AddPropreList.Length; z++)
                            {
                                int addProType = int.Parse(AddPropreList[z].Split(',')[0]);
                                int type = NumericHelp.GetNumericValueType(addProType);
                                int addProValue = 0;
                                if (type == 1)
                                {
                                    addProValue = int.Parse(AddPropreList[z].Split(',')[1]);
                                }
                                else {
                                    addProValue = (int)(float.Parse(AddPropreList[z].Split(',')[1]) * 10000);
                                }
                                
                                AddUpdateProDicList(addProType, addProValue, UpdateProDicList);
                            }
                        }
                    }
                }
            }

            //隐藏技能战力
            int skillFightValue = 0;
            
            int equipHpSum = 0;
            int equipMinActSum = 0;
            int equipMaxActSum = 0;
            int equipMinMageSum = 0;
            int equipMaxMageSum = 0;
            int equipMinDefSum = 0;
            int equipMaxDefSum = 0;
            int equipMinAdfSum = 0;
            int equipMaxAdfSum = 0;

            //史诗宝石数量
            int equipShiShiGemNum = 0;

            for (int i = 0; i < equipList.Count; i++)
            {
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(equipList[i].ItemID);

                //生肖装备没激活直接跳出来
                if (itemCof.EquipType == 101 && ItemHelper.IfShengXiaoActive(itemCof.Id, equipList) == false)
                {
                    continue;
                }

                EquipConfig mEquipCon = EquipConfigCategory.Instance.Get(itemCof.ItemEquipID);

                //职业专精
                float occMastery = 0f;
                if (userInfo.OccTwo != 0)
                {
                    //if (OccupationTwoConfigCategory.Instance.Get(userInfo.OccTwo).ArmorMastery == ItemConfigCategory.Instance.Get(equipIDList[i]).EquipType)
                    //{
                    //    //occMastery = 0.2f;
                    //    occMastery = 0f;
                    //}
                }

                //极品属性
                float addPro = 0;

                if (equipList[i].HideSkillLists.Contains(68000104)) {
                    addPro = 0.2f;
                }

                //虚弱属性
                if (equipList[i].HideSkillLists.Contains(68000107))
                {
                    addPro = -0.1f;
                }

                //胜算属性
                if (equipList[i].HideSkillLists.Contains(68000105))
                {
                    mEquipCon.Equip_MinAct = mEquipCon.Equip_MaxAct;
                }

                for (int z = 0; z < equipList[i].HideSkillLists.Count; z++) 
                {
                    /*
                    if (!HideProListConfigCategory.Instance.Contain(equipList[i].HideSkillLists[z]))
                    {
                        Log.Warning($"HideProListConfig==null:  {equipList[i].HideSkillLists[z]}");
                        continue;
                    }
                    HideProListConfig hideProListCof = HideProListConfigCategory.Instance.Get(equipList[i].HideSkillLists[z]);
                    skillFightValue += hideProListCof.AddFightValue;
                    */

                    Dictionary<int, HideProListConfig> hideCof = new Dictionary<int, HideProListConfig>();
                    hideCof = HideProListConfigCategory.Instance.GetAll();

                    foreach (HideProListConfig hideProConfig in hideCof.Values) {
                        if (hideProConfig.PropertyType == equipList[i].HideSkillLists[z]) {
                            skillFightValue += hideProConfig.AddFightValue;
                        }
                    }
                }

                //强化登录（List长度13， 13个位置）
                int qianghuaLv = unit.GetComponent<BagComponent>().GetQiangHuaLevel(itemCof.ItemSubType);

                EquipQiangHuaConfig equipQiangHuaConfig = QiangHuaHelper.GetQiangHuaConfig(itemCof.ItemSubType, qianghuaLv);
                if (equipQiangHuaConfig != null)
                {
                    addPro += float.Parse(equipQiangHuaConfig.EquipPropreAdd);
                    //addPro += float.Parse(EquipQiangHuaConfigCategory.Instance.Get(QiangHuaHelper.GetQiangHuaId(itemCof.ItemSubType, qianghuaLv[itemCof.ItemSubType])).EquipPropreAdd);
                }
               
                //存储基础属性
                equipHpSum = (int)(equipHpSum + mEquipCon.Equip_Hp * (1 + occMastery + addPro));
                equipMinActSum = (int)(equipMinActSum + mEquipCon.Equip_MinAct * (1 + occMastery + addPro));
                equipMaxActSum = (int)(equipMaxActSum + mEquipCon.Equip_MaxAct * (1 + occMastery + addPro));
                equipMinMageSum = (int)(equipMinMageSum + mEquipCon.Equip_MinMagAct * (1 + occMastery + addPro));
                equipMaxMageSum = (int)(equipMaxMageSum + mEquipCon.Equip_MaxMagAct * (1 + occMastery + addPro));
                equipMinDefSum = (int)(equipMinDefSum + mEquipCon.Equip_MinDef * (1 + occMastery + addPro));
                equipMaxDefSum = (int)(equipMaxDefSum + mEquipCon.Equip_MaxDef * (1 + occMastery + addPro));
                equipMinAdfSum = (int)(equipMinAdfSum + mEquipCon.Equip_MinAdf * (1 + occMastery + addPro));
                equipMaxAdfSum = (int)(equipMaxAdfSum + mEquipCon.Equip_MaxAdf * (1 + occMastery + addPro));

                /*
                equipHpSum = (int)(equipHpSum + mEquipCon.Equip_Hp * (1 + occMastery + addPro) + BaseHp_EquipSuit);
                equipMinActSum = (int)(equipMinActSum + mEquipCon.Equip_MinAct * (1 + occMastery + addPro) + BaseMinAct_EquipSuit);
                equipMaxActSum = (int)(equipMaxActSum + mEquipCon.Equip_MaxAct * (1 + occMastery + addPro) + BaseMaxAct_EquipSuit);
                equipMinMageSum = (int)(equipMinMageSum + mEquipCon.Equip_MinMagAct * (1 + occMastery + addPro) + BaseMinMage_EquipSuit);
                equipMaxMageSum = (int)(equipMaxMageSum + mEquipCon.Equip_MaxMagAct * (1 + occMastery + addPro) + BaseMaxMage_EquipSuit);
                equipMinDefSum = (int)(equipMinDefSum + mEquipCon.Equip_MinDef * (1 + occMastery + addPro) + BaseMinDef_EquipSuit);
                equipMaxDefSum = (int)(equipMaxDefSum + mEquipCon.Equip_MaxDef * (1 + occMastery + addPro) + BaseMaxDef_EquipSuit);
                equipMinAdfSum = (int)(equipMinAdfSum + mEquipCon.Equip_MinAdf * (1 + occMastery + addPro) + BaseMinAdf_EquipSuit);
                equipMaxAdfSum = (int)(equipMaxAdfSum + mEquipCon.Equip_MaxAdf * (1 + occMastery + addPro) + BaseMaxAdf_EquipSuit);
                */

                //存储特殊属性
                for (int y = 0; y < mEquipCon.AddPropreListType.Length; y++)
                {
                    if (mEquipCon.AddPropreListType[y] != 0 && mEquipCon.AddPropreListValue.Length > y)
                    {
                        //记录属性
                        AddUpdateProDicList(mEquipCon.AddPropreListType[y], (long)mEquipCon.AddPropreListValue[y], UpdateProDicList);
                    }
                }

                //获取宝石属性
                if (string.IsNullOrEmpty(equipList[i].GemIDNew))
                {
                    equipList[i].GemIDNew = "0_0_0_0";
                    //Log.Debug($"GemIDNew==null  unit.Id: {unit.Id} BagInfoID:{equipList[i].BagInfoID}");
                }
                string[] gemList = equipList[i].GemIDNew.Split('_');

                for (int z = 0; z < gemList.Length; z++) {

                    int gemID = int.Parse(gemList[z]);
                    if (gemID == 0)
                    {
                        continue;
                    }

                    //史诗宝石数量最多4个
                    ItemConfig itemGemCof = ItemConfigCategory.Instance.Get(gemID);
                    if (itemGemCof.ItemSubType == 110) {
                        equipShiShiGemNum += 1;
                    }

                    if (equipShiShiGemNum > 4 && itemGemCof.ItemSubType == 110) {
                        continue;
                    }

                    // "100403;10@100203;60
                    ItemConfig gemitemCof = ItemConfigCategory.Instance.Get(gemID);
                    string[] attributeList = gemitemCof.ItemUsePar.Split('@');
                    for (int a = 0;  a < attributeList.Length; a++)
                    {
                        //100203;113
                        string attributeItem = attributeList[a];
                        string[] attributeInfo = attributeItem.Split(';');
                        int gemPro = 0;
                        try
                        {
                            gemPro = int.Parse(attributeInfo[0]);
                        }
                        catch (Exception ex)
                        {
                            Log.Debug("attri: " + ex.ToString());
                            continue;
                        }

                        long gemValue = long.Parse(attributeInfo[1]);

                        //浮点数处理
                        if (NumericHelp.GetNumericValueType(gemPro) == 2)
                        {
                            //gemValue = gemValue * 10000;
                        }

                        //宝石专精
                        if (equipList[i].HideSkillLists.Contains(68000108))
                        {
                            gemValue = (long)((float)gemValue * 1.2f);
                        }

                        AddUpdateProDicList(gemPro, gemValue, UpdateProDicList);
                    }
                }
            }

            /*
            //宝石属性
            List<HideProList> gemProList = unit.GetComponent<BagComponent>().GetGemProLists();
            for (int i = 0; i < gemProList.Count; i++)
            {
                AddUpdateProDicList(gemProList[i].HideID, gemProList[i].HideValue, UpdateProDicList);
            }
            */

            //天赋属性
            List<HideProList> tianfuProList = unit.GetComponent<SkillSetComponent>().GetTianfuRoleProLists();
            for (int i = 0; i < tianfuProList.Count; i++)
            {
                AddUpdateProDicList(tianfuProList[i].HideID, tianfuProList[i].HideValue, UpdateProDicList);
            }

            //生命护盾
            List<HideProList> lifeShieldList = unit.GetComponent<SkillSetComponent>().GetShieldProLists();
            for (int i = 0; i < lifeShieldList.Count; i++)
            {
                AddUpdateProDicList(lifeShieldList[i].HideID, lifeShieldList[i].HideValue, UpdateProDicList);
            }

            //称号属性
            List<HideProList> titlePros = unit.GetComponent<TitleComponent>().GetTitlePro();
            for (int i = 0; i < titlePros.Count; i++)
            {
                AddUpdateProDicList(titlePros[i].HideID, titlePros[i].HideValue, UpdateProDicList);
            }

            //家园属性
            List<HideProList> jiayuanPros = unit.GetComponent<JiaYuanComponent>().GetJianYuanPro();
            for (int i = 0; i < jiayuanPros.Count; i++)
            {
                AddUpdateProDicList(jiayuanPros[i].HideID, jiayuanPros[i].HideValue, UpdateProDicList);
            }

            //技能属性
            List<HideProList> skillProList = unit.GetComponent<SkillSetComponent>().GetSkillRoleProLists();
            for (int i = 0; i < skillProList.Count; i++)
            {
                //Log.Info("隐藏:" + skillProList[i].HideID + "skillProList[i].HideValue = " + skillProList[i].HideValue);
                AddUpdateProDicList(skillProList[i].HideID, skillProList[i].HideValue, UpdateProDicList);
            }

            //坐骑属性
            List<HideProList> zuoqiPros = unit.GetComponent<UserInfoComponent>().GetZuoQiPro();
            for (int i = 0; i < zuoqiPros.Count; i++)
            {
                AddUpdateProDicList(zuoqiPros[i].HideID, zuoqiPros[i].HideValue, UpdateProDicList);
            }

            //收集属性
            List<HideProList> shoujiProList = unit.GetComponent<ShoujiComponent>().GetProList();
            for (int i = 0; i < shoujiProList.Count; i++)
            {
                AddUpdateProDicList(shoujiProList[i].HideID, shoujiProList[i].HideValue, UpdateProDicList);
            }

            //精灵属性
            List<HideProList> jinglingProList = unit.GetComponent<ChengJiuComponent>().GetJingLingProLists();
            for (int i = 0; i < jinglingProList.Count; i++)
            {
                AddUpdateProDicList(jinglingProList[i].HideID, jinglingProList[i].HideValue, UpdateProDicList);
            }

            //宠物皮肤属性
            for (int p = 0; p < unit.GetComponent<PetComponent>().PetSkinList.Count; p++)
            {
                string[] strList = unit.GetComponent<PetComponent>().PetSkinList[p].Value.Split('_');

                for (int y = 0; y < strList.Length; y++) {

                    if (strList[y] != "" && strList[y] != null&& strList[y] != "0")
                    {
                        PetSkinConfig petSkinCof = PetSkinConfigCategory.Instance.Get(int.Parse(strList[y]));
                        if (petSkinCof.PripertySet != "" && petSkinCof.PripertySet != "0" && petSkinCof.PripertySet != null) {
                            string[] AddPropreList = petSkinCof.PripertySet.Split(';');

                            for (int z = 0; z < AddPropreList.Length; z++)
                            {
                                int addProType = int.Parse(AddPropreList[z].Split(',')[0]);
                                int type = NumericHelp.GetNumericValueType(addProType);
                                int addProValue = 0;
                                if (type == 1)
                                {
                                    addProValue = int.Parse(AddPropreList[z].Split(',')[1]);
                                }
                                else
                                {
                                    addProValue = (int)(float.Parse(AddPropreList[z].Split(',')[1]) * 10000);
                                }

                                AddUpdateProDicList(addProType, addProValue, UpdateProDicList);
                            }
                        }
                    }
                }
            }

            //汇总属性
            long BaseHp = occBaseHp + equipHpSum + BaseHp_EquipSuit;
            long BaseMinAct = occBaseMinAct + equipMinActSum + BaseMinAct_EquipSuit;
            long BaseMaxAct = occBaseMaxAct + equipMaxActSum+ BaseMaxAct_EquipSuit;
            long BaseMinMage = occBaseMinMage + equipMinMageSum + BaseMinMage_EquipSuit;
            long BaseMaxMage = occBaseMaxMage + equipMaxMageSum + BaseMaxMage_EquipSuit;
            long BaseMinDef = occBaseMinDef + equipMinDefSum + BaseMinDef_EquipSuit;
            long BaseMaxDef = occBaseMaxDef + equipMaxDefSum + BaseMaxDef_EquipSuit;
            long BaseMinAdf = occBaseMinAdf + equipMinAdfSum + BaseMinAdf_EquipSuit;
            long BaseMaxAdf = occBaseMaxAdf + equipMaxAdfSum + BaseMaxAdf_EquipSuit;
            double BaseMoveSpeed = occBaseMoveSpeed;
            double BaseCri = occBaseCri + BaseCri_EquipSuit;
            double BaseHit = occBaseHit + BaseHit_EquipSuit;
            double BaseDodge = occBaseDodge + BaseDodge_EquipSuit;
            double BaseDefSub = occBaseDefSub;
            double BaseAdfSub = occBaseAdfSub;
            double BaseDamgeAdd = BaseDamgeAdd_EquipSuit;
            double BaseDamgeSub = occBaseDamgeSubAdd + BaseDamgeSub_EquipSuit;

            //更新基础属性
            AddUpdateProDicList((int)NumericType.Base_MaxHp_Base, BaseHp, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MinAct_Base, BaseMinAct, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MaxAct_Base, BaseMaxAct, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_Mage_Base, BaseMaxMage, UpdateProDicList);
            //AddUpdateProDicList((int)NumericType.Base_MaxMage_Base, BaseMaxMage, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MinDef_Base, BaseMinDef, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MaxDef_Base, BaseMaxDef, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MinAdf_Base, BaseMinAdf, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MaxAdf_Base, BaseMaxAdf, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_Speed_Base, (int)(BaseMoveSpeed * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_Cri_Base, (int)(BaseCri * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_Hit_Base, (int)(BaseHit * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_Dodge_Base, (int)(BaseDodge * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_ActDamgeSubPro_Base, (int)(BaseDefSub * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_MageDamgeSubPro_Base, (int)(BaseAdfSub * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_DamgeAddPro_Base, (int)(BaseDamgeAdd * 10000), UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_DamgeSubPro_Base, (int)(BaseDamgeSub * 10000), UpdateProDicList);


            //缓存一级属性
            long Power_value = GetOnePro(NumericType.Now_Power, UpdateProDicList);
            long Agility_value = GetOnePro(NumericType.Now_Agility, UpdateProDicList);
            long Intellect_value = GetOnePro(NumericType.Now_Intellect, UpdateProDicList);
            long Stamina_value = GetOnePro(NumericType.Now_Stamina, UpdateProDicList);
            long Constitution_value = GetOnePro(NumericType.Now_Constitution, UpdateProDicList);
            
            /*
            //力量换算
            if (Power_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxAct_Base, Power_value * 3, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MaxDef_Base, Power_value * 3, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_HitLv_Base, Power_value * 3, UpdateProDicList);
            }

            //敏捷换算
            if (Agility_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxAct_Base, Agility_value * 6, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_CriLv_Base, Agility_value * 5, UpdateProDicList);
            }

            //智力换算
            if (Intellect_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_Mage_Base, Intellect_value * 10, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MaxAdf_Base, Intellect_value * 3, UpdateProDicList);
            }

            //耐力换算
            if (Stamina_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxDef_Base, Stamina_value * 3, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MaxAdf_Base, Stamina_value * 3, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_DodgeLv_Base, Stamina_value * 5, UpdateProDicList);
            }

            //体质换算
            if (Constitution_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxHp_Base, Constitution_value * 100, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_ResLv_Base, Constitution_value * 5, UpdateProDicList);
            }

            //缓存等级BUFF属性
            //AddUpdateProDicList((int)NumericType.Now_CriLv, numericComponent.GetAsLong(NumericType.Extra_Buff_CriLv_Add), UpdateProDicList);
            //AddUpdateProDicList((int)NumericType.Base_MaxHp_Base, Constitution_value * 80, UpdateProDicList);

            //二次计算暴击等属性
            long criLv = numericComponent.GetAsLong(NumericType.Now_CriLv);
            long hitLv = numericComponent.GetAsLong(NumericType.Now_HitLv);
            long dodgeLv = numericComponent.GetAsLong(NumericType.Now_DodgeLv);
            long resLv = numericComponent.GetAsLong(NumericType.Now_ResLv);
            long skillAddLv = 0;

            //属性点加成
            //int aaa = numericComponent.GetAsInt(NumericType.Now_Power);
            criLv = criLv + (PointLiLiang + Power_value) * 5;
            resLv = resLv + (PointTiZhi + Constitution_value) * 5;
            dodgeLv = dodgeLv + (PointNaiLi + Stamina_value) * 5;
            hitLv = hitLv + (PointMinJie + Agility_value) * 5;
            skillAddLv = skillAddLv + (PointZhiLi + Intellect_value) * 5;

            AddUpdateProDicList((int)NumericType.Base_CriLv_Add, criLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_HitLv_Add, hitLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_DodgeLv_Add, dodgeLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_ResLv_Add, resLv, UpdateProDicList);

            //智力加魔法穿透
            float adddChuanTou = LvProChange(skillAddLv, roleLv);
            AddUpdateProDicList((int)NumericType.Base_HuShiMagePro_Add, (int)(adddChuanTou * 10000), UpdateProDicList);
            */
            
            //--------------------新版属性加点------------------------
            
            //力量换算
            if (Power_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxAct_Base, Power_value * 2, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MaxDef_Base, Power_value * 2, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MinAct_Base, Power_value * 1, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MinDef_Base, Power_value * 1, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_HitLv_Base, Power_value * 3, UpdateProDicList);
            }

            //敏捷换算
            if (Agility_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxAct_Base, Agility_value * 4, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MinAct_Base, Agility_value * 2, UpdateProDicList);

                //额外战力附加(因为冷却CD附加的战力少)
                AddUpdateProDicList((int)NumericType.Base_FightValue_Base, Agility_value * 2, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_CriLv_Base, Agility_value * 5, UpdateProDicList);
            }

            //智力换算
            if (Intellect_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_Mage_Base, Intellect_value * 6, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MaxAdf_Base, Intellect_value * 1, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MinAdf_Base, Intellect_value * 1, UpdateProDicList);
            }

            //耐力换算
            if (Stamina_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxDef_Base, Stamina_value * 3, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MaxAdf_Base, Stamina_value * 3, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MinDef_Base, Stamina_value * 2, UpdateProDicList);
                AddUpdateProDicList((int)NumericType.Base_MinAdf_Base, Stamina_value * 2, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_DodgeLv_Base, Stamina_value * 5, UpdateProDicList);
            }

            //体质换算
            if (Constitution_value > 0)
            {
                AddUpdateProDicList((int)NumericType.Base_MaxHp_Base, Constitution_value * 50, UpdateProDicList);
                //AddUpdateProDicList((int)NumericType.Base_ResLv_Base, Constitution_value * 5, UpdateProDicList);
            }

            //攻击加物理穿透
            int wuliChuanTouLv = (PointLiLiang + (int)Power_value) * 5;
            float adddWuLiChuanTou = LvProChange(wuliChuanTouLv, roleLv);
            AddUpdateProDicList((int)NumericType.Base_HuShiActPro_Add, (int)(adddWuLiChuanTou * 10000), UpdateProDicList);

            //智力加魔法穿透
            int mageChuanTouLv = (PointZhiLi + (int)Intellect_value) * 5;
            float adddMageChuanTou = LvProChange(mageChuanTouLv, roleLv);
            AddUpdateProDicList((int)NumericType.Base_HuShiMagePro_Add, (int)(adddMageChuanTou * 10000), UpdateProDicList);

            //敏捷冷却时间
            int cdTimeLv = (PointMinJie + (int)Agility_value) * 2;
            float addMinJie = LvProChange(cdTimeLv, roleLv);
            AddUpdateProDicList((int)NumericType.Base_SkillCDTimeCostPro_Add, (int)(addMinJie * 10000), UpdateProDicList);

            //耐力
            int huixueLv = (PointNaiLi + (int)Stamina_value);
            AddUpdateProDicList((int)NumericType.Base_HuiXue_Add, huixueLv, UpdateProDicList);

            //体力
            int damgeProCostLv = (PointTiZhi + (int)Constitution_value);
            float damgeProCost = LvProChange(damgeProCostLv, roleLv);
            AddUpdateProDicList((int)NumericType.Base_DamgeSubPro_Add, (int)(damgeProCost * 10000), UpdateProDicList);


            //属性点加成
            //二次计算暴击等属性
            long criLv = numericComponent.GetAsLong(NumericType.Now_CriLv);
            long hitLv = numericComponent.GetAsLong(NumericType.Now_HitLv);
            long dodgeLv = numericComponent.GetAsLong(NumericType.Now_DodgeLv);
            long resLv = numericComponent.GetAsLong(NumericType.Now_ResLv);
            long zhongjiLv = numericComponent.GetAsLong(NumericType.Now_ZhongJiLv);

            AddUpdateProDicList((int)NumericType.Base_CriLv_Add, criLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_HitLv_Add, hitLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_DodgeLv_Add, dodgeLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_ResLv_Add, resLv, UpdateProDicList);
            AddUpdateProDicList((int)NumericType.Base_ZhongJiPro_Add, zhongjiLv, UpdateProDicList);

            //更新属性
            foreach (int key in UpdateProDicList.Keys)
            {
                long setValue = numericComponent.GetAsLong(key) + UpdateProDicList[key];
                //Log.Info("key = " + key + ":" + setValue);
                numericComponent.Set(key, setValue, notice);
            }

            /*
            UpdateProDicList.Clear();


            //更新属性
            foreach (int key in UpdateProDicList.Keys)
            {
                long setValue = numericComponent.GetAsLong(key) + UpdateProDicList[key];
                //Log.Info("key = " + key + ":" + setValue);
                numericComponent.Set(key, setValue, notice);
            }
            */


            //战力计算
            long ShiLi_Act  = 0;
            float ShiLi_ActPro = 0f;
            long ShiLi_Def = 0;
            float ShiLi_DefPro = 0f;
            long ShiLi_Hp = 0;
            float ShiLi_HpPro = 0f;
            //long proLvAdd = criLv + hitLv + dodgeLv + resLv + skillAddLv;
            long proLvAdd = 0;

            //攻击部分
            foreach (var Item in NumericHelp.ZhanLi_Act) {
                ShiLi_Act += (int)((float)numericComponent.ReturnGetFightNumLong(Item.Key) * Item.Value);
            }

            //隐藏技能算在攻击部分
            ShiLi_Act += skillFightValue;

            foreach (var Item in NumericHelp.ZhanLi_ActPro)
            {
                ShiLi_ActPro += ((float)numericComponent.ReturnGetFightNumfloat(Item.Key) * Item.Value);
            }

            //幸运副本附加
            int luck = numericComponent.GetAsInt(NumericType.Now_Luck);
            switch (luck)
            {
                case 0:
                    ShiLi_ActPro += 0.01f;
                    break;
                case 1:
                    ShiLi_ActPro += 0.02f;
                    break;
                case 2:
                    ShiLi_ActPro += 0.04f;
                    break;
                case 3:
                    ShiLi_ActPro += 0.08f;
                    break;
                case 4:
                    ShiLi_ActPro += 0.12f;
                    break;
                case 5:
                    ShiLi_ActPro += 0.2f;
                    break;
                case 6:
                    ShiLi_ActPro += 0.3f;
                    break;
                case 7:
                    ShiLi_ActPro += 0.4f;
                    break;
                case 8:
                    ShiLi_ActPro += 0.5f;
                    break;
                case 9:
                    ShiLi_ActPro += 0.9f;
                    break;

                default:
                    ShiLi_ActPro += 1f;
                    break;
            }

            //防御部分
            foreach (var Item in NumericHelp.ZhanLi_Def)
            {
                ShiLi_Def += (int)((float)numericComponent.ReturnGetFightNumLong(Item.Key) * Item.Value);
            }

            foreach (var Item in NumericHelp.ZhanLi_DefPro)
            {
                ShiLi_DefPro += ((float)numericComponent.ReturnGetFightNumfloat(Item.Key) * Item.Value);
            }

            //血量部分
            foreach (var Item in NumericHelp.ZhanLi_Hp)
            {
                ShiLi_Hp += (int)((float)numericComponent.ReturnGetFightNumLong(Item.Key) * Item.Value);
            }

            foreach (var Item in NumericHelp.ZhanLi_HpPro)
            {
                ShiLi_HpPro += ((float)numericComponent.ReturnGetFightNumfloat(Item.Key) * Item.Value);
            }

            //其他战力附加
            int addZhanLi = numericComponent.GetAsInt(NumericType.Now_FightValue);

            int zhanliValue =(int)(ShiLi_Act * (1 + ShiLi_ActPro) + ShiLi_Def * (1 + ShiLi_DefPro) + (ShiLi_Hp * 0.1f) * (1 + ShiLi_HpPro)) + roleLv * 25 + (int)proLvAdd + addZhanLi;

            //更新战力
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Combat, zhanliValue.ToString(), notice);
            
            if (rank)
            {
                unit.GetComponent<UserInfoComponent>().UpdateRankInfo().Coroutine();
            }
            return zhanliValue;
            //暴击等级等属性二次换算,因为不能写在前面,要不升级会降战力
            //缓存列表
            /*
            Dictionary<int, long> ProLvDicList = new Dictionary<int, long>();

            //float criProAdd = LvProChange(criLv, roleLv);
            //float hitProAdd = LvProChange(hitLv, roleLv);
            //float dogeProAdd = LvProChange(dodgeLv, roleLv);
            //float resProAdd = LvProChange(resLv, roleLv);

            float skillDamgeProAdd = LvProChange(skillAddLv, roleLv);

            
            long cripro = numericComponent.GetAsLong(NumericType.Now_Cri);

            AddUpdateProDicList((int)NumericType.Now_Cri, (int)(criProAdd * 10000), ProLvDicList);
            AddUpdateProDicList((int)NumericType.Now_Hit, (int)(hitProAdd * 10000), ProLvDicList);
            AddUpdateProDicList((int)NumericType.Now_Dodge, (int)(dogeProAdd * 10000), ProLvDicList);
            AddUpdateProDicList((int)NumericType.Now_Res, (int)(resProAdd * 10000), ProLvDicList);
            
            AddUpdateProDicList((int)NumericType.Now_MageDamgeAddPro, (int)(skillDamgeProAdd * 10000), ProLvDicList);

            //更新属性
            foreach (int key in ProLvDicList.Keys)
            {
                long setValue = numericComponent.GetAsLong(key) + ProLvDicList[key];
                //Log.Info("numericComponent.GetAsLong(key) = " + numericComponent.GetAsLong(key) + ":ProLvDicList[key] = " + ProLvDicList[key] + ";setValue = " + setValue);
                numericComponent.Set(key, ProLvDicList[key], notice);
            }
            */
        }
    }


}
