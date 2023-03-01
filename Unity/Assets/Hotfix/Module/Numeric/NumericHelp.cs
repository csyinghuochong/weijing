using System.Collections.Generic;

namespace ET
{

    public static class NumericHelp
    {

        //需要广播的数值类型
        public static List<int> BroadcastType = new List<int>
        {
            NumericType.Now_Hp,
            NumericType.Now_Dead,
            NumericType.ReviveTime,
            NumericType.Now_Speed,
            NumericType.Now_Shield_HP,
            NumericType.Now_Stall,
            NumericType.Now_Weapon,
            NumericType.Now_Damage,
            NumericType.Now_MaxHp,
            NumericType.PetSkin,
            NumericType.UnionLeader,
            NumericType.BossInCombat,
            NumericType.Born_X,
            NumericType.Born_Y,
            NumericType.Born_Z,
            NumericType.Now_AI,
            NumericType.TeamId,
            NumericType.HorseFightID,
            NumericType.HorseRide,
            NumericType.TitleID,
            NumericType.BossBelongID,
        };

        //1 整数  2 浮点数
        public static Dictionary<int, int> NumericValueType = new Dictionary<int, int>
        {
            { (int)NumericType.Base_MaxHp_Base, 1 },
            /*
            { (int)NumericType.Now_Cri, 2 },
            { (int)NumericType.Base_Cri_Base, 2 },
            { (int)NumericType.Base_Cri_Add, 2 },
            { (int)NumericType.Extra_Buff_Cri_Mul, 2 },
            { (int)NumericType.Base_Hit_Base, 2 },
            { (int)NumericType.Base_Hit_Add, 2 },
            { (int)NumericType.Extra_Buff_Hit_Mul, 2 },
            { (int)NumericType.Base_Dodge_Base, 2 },
            { (int)NumericType.Base_Dodge_Add, 2 },
            { (int)NumericType.Extra_Buff_Dodge_Mul, 2 },
            { (int)NumericType.Base_Res_Base, 2 },
            { (int)NumericType.Base_Res_Add, 2 },
            { (int)NumericType.Extra_Buff_Res_Mul, 2 },
            { (int)NumericType.Base_ActDamgeAddPro_Base, 2 },
            { (int)NumericType.Base_ActDamgeAddPro_Add, 2 },
            { (int)NumericType.Extra_Buff_ActDamgeAddPro_Mul, 2 },
            { (int)NumericType.Base_MageDamgeAddPro_Base, 2 },
            { (int)NumericType.Base_MageDamgeAddPro_Add, 2 },
            { (int)NumericType.Extra_Buff_MageDamgeAddPro_Mul, 2 },
            { (int)NumericType.Base_ActDamgeSubPro_Base, 2 },
            { (int)NumericType.Base_ActDamgeSubPro_Add, 2 },
            { (int)NumericType.Extra_Buff_ActDamgeSubPro_Mul, 2 },
            { (int)NumericType.Base_ActDamgeSubPro_Base, 2 },
            { (int)NumericType.Base_ActDamgeSubPro_Add, 2 },
            { (int)NumericType.Extra_Buff_ActDamgeSubPro_Mul, 2 },
            { (int)NumericType.Base_DamgeAddPro_Base, 2 },
            { (int)NumericType.Base_DamgeAddPro_Add, 2 },
            { (int)NumericType.Extra_Buff_DamgeAddPro_Mul, 2 },
            { (int)NumericType.Base_DamgeSubPro_Base, 2 },
            { (int)NumericType.Base_DamgeSubPro_Add, 2 },
            { (int)NumericType.Extra_Buff_DamgeSubPro_Mul, 2 },
            { (int)NumericType.Base_ZhongJiPro_Base, 2 },
            { (int)NumericType.Base_ZhongJiPro_Add, 2 },
            { (int)NumericType.Extra_Buff_ZhongJiPro_Mul, 2 },
            { (int)NumericType.Base_HuShiActPro_Base, 2 },
            { (int)NumericType.Base_HuShiActPro_Add, 2 },
            { (int)NumericType.Extra_Buff_HuShiActPro_Mul, 2 },
            { (int)NumericType.Base_HuShiMagePro_Base, 2 },
            { (int)NumericType.Base_HuShiMagePro_Add, 2 },
            { (int)NumericType.Extra_Buff_HuShiMagePro_Mul, 2 },
            { (int)NumericType.Base_XiXuePro_Base, 2 },
            { (int)NumericType.Base_XiXuePro_Add, 2 },
            { (int)NumericType.Extra_Buff_XiXuePro_Mul, 2 },
            */
        };

        //攻击部分
        public static Dictionary<int,float> ZhanLi_Act = new Dictionary<int, float>()
        {
            { (int)NumericType.Now_MaxAct, 1 },
            { (int)NumericType.Now_Mage, 0.5f },
            { (int)NumericType.Now_ZhongJi, 1 },
            { (int)NumericType.Now_ZhenShi, 1 },    //真实伤害
            { (int)NumericType.Now_HuShiDef, 1 },
            { (int)NumericType.Now_HuShiAdf, 1 },
            
        };

        //攻击部分
        public static Dictionary<int, float> ZhanLi_ActPro = new Dictionary<int, float>()
        {
            { (int)NumericType.Now_Cri, 1 },
            { (int)NumericType.Now_Hit, 1 },
            { (int)NumericType.Now_ActDamgeAddPro, 1 },
            { (int)NumericType.Now_MageDamgeAddPro, 1 },
            { (int)NumericType.Now_DamgeAddPro, 1 },
            { (int)NumericType.Now_ZhongJiPro, 1 },
            { (int)NumericType.Now_HuShiActPro, 1 },
            { (int)NumericType.Now_HuShiMagePro, 1 },
            { (int)NumericType.Now_XiXuePro, 1 },

            { (int)NumericType.Now_ActBossPro, 0.5f },
            { (int)NumericType.Now_MageBossPro, 0.5f },

            { (int)NumericType.Now_Damge_Beast_Pro, 0.3f },
            { (int)NumericType.Now_Damge_Hum_Pro, 0.3f },
            { (int)NumericType.Now_Damge_Demon_Pro, 0.3f },


            { (int)NumericType.Now_SkillCDTimeCostPro, 0.5f },
            { (int)NumericType.Now_MiaoSha_Pro, 0.3f },
            { (int)NumericType.Now_SkillNoCDPro, 0.5f },
            { (int)NumericType.Now_SkillMoreDamgePro, 0.3f },

            { (int)NumericType.Now_ZhuanZhuPro, 0.3f },
            { (int)NumericType.Now_ActSpeedPro, 1f },

            { (int)NumericType.Now_DaoActAddPro, 0.25f },
            { (int)NumericType.Now_JianActAddPro, 0.25f },
            { (int)NumericType.Now_FaZhangActAddPro, 0.25f },
            { (int)NumericType.Now_ShuActAddPro, 0.25f },

        };

        //防御部分
        public static Dictionary<int, float> ZhanLi_Def = new Dictionary<int, float>()
        {
            { (int)NumericType.Now_MaxDef, 1 },
            { (int)NumericType.Now_MaxAdf, 1 },
            { (int)NumericType.Now_GeDang, 1 },

        };

        //防御部分
        public static Dictionary<int, float> ZhanLi_DefPro = new Dictionary<int, float>()
        {
            { (int)NumericType.Now_Dodge, 1 },
            { (int)NumericType.Now_Res, 1 },
            { (int)NumericType.Now_ActDamgeSubPro, 1 },
            { (int)NumericType.Now_MageDamgeSubPro, 1 },
            { (int)NumericType.Now_DamgeSubPro, 1 },

            { (int)NumericType.Now_ActBossSubPro, 0.5f },
            { (int)NumericType.Now_MageBossSubPro, 0.5f },

            { (int)NumericType.Now_Resistance_Shine_Pro, 0.25f },
            { (int)NumericType.Now_Resistance_Shadow_Pro, 0.25f },
            { (int)NumericType.Now_ResistIcece_Ice_Pro, 0.25f },
            { (int)NumericType.Now_ResistFirece_Fire_Pro, 0.25f },
            { (int)NumericType.Now_ResistThunderce_Thunder_Pro, 0.25f },

            { (int)NumericType.Now_Resistance_Beast_Pro, 0.3f },
            { (int)NumericType.Now_Resistance_Hum_Pro, 0.3f },
            { (int)NumericType.Now_Resistance_Demon_Pro, 0.3f },

            { (int)NumericType.Now_MageReboundDamgePro, 0.3f },
            { (int)NumericType.Now_ActReboundDamgePro, 0.3f },

            { (int)NumericType.Now_PlayerActDamgeSubPro, 0.25f },
            { (int)NumericType.Now_PlayerSkillDamgeSubPro, 0.25f },
            { (int)NumericType.Now_PlayerAllDamgeSubPro, 0.5f },
            { (int)NumericType.Now_PlayerCriSubPro, 0.3f },
            { (int)NumericType.Now_PlayerHitSubPro, 0.3f },

            { (int)NumericType.Now_WuShiFangYuPro, 0.5f },
            { (int)NumericType.Now_SkillDodgePro, 0.5f },
            { (int)NumericType.Now_MageDodgePro, 0.5f },
            { (int)NumericType.Now_FuHuoPro, 0.5f },
            { (int)NumericType.Now_ActDodgePro, 0.5f },

        };

        //血量部分
        public static Dictionary<int, float> ZhanLi_Hp = new Dictionary<int, float>()
        {
            { (int)NumericType.Now_MaxHp, 0.8f },       //原来0.75 到0.8看升了多少
            { (int)NumericType.Now_HuiXue, 5 },
        };

        //血量部分
        public static Dictionary<int, float> ZhanLi_HpPro = new Dictionary<int, float>()
        {

        };


        /// <summary>
        /// 1 标识整数  2表示浮点数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetNumericValueType(int key)
        {
            if (key == 1009)
            {
                return 2;
            }
            if (key == 3001)
            {
                return 1;
            }

            //增加
            if (key >= 200001 && key < 300000) {
                return 2;
            }
            
            if (key >= 2001 && key < 3000 || key >= 200001 && key < 300000)
            //if (key >= 1001 && key < 3000)
            {
                return 2;
            }
            else
            {
                if (key >= 100000 && key < 200000)
                {
                    string str = key.ToString().Substring(key.ToString().Length - 1, 1);
                    if (str == "2")
                    {
                        return 2;
                    }
                    else {
                        return 1;
                    }
                }

                //最后排除
                int value = 1;
                NumericValueType.TryGetValue(key, out value);
                if (value == 0)
                    return 1;
                return value;

                //return 0;
            } 
        }

        //传入值和类型返回对应值
        public static int NumericValueSaveType(int key, float value) {

            if (GetNumericValueType(key) == 2)
            {
                return (int)(value * 10000);
            }
            else {
                return (int)(value);
            }

        }

        public static bool IsYueKaStates(this Unit self)
        { 
            return self.GetComponent<NumericComponent>().GetAsInt(NumericType.YueKaRemainTimes) > 0;
        }

        public static void UpdateYueKaTimes(this Unit self)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.YueKaRemainTimes, 7);
        }

        public static int GetTeamDungeonTimes(this Unit self)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            return numericComponent.GetAsInt(NumericType.TeamDungeonTimes);
        }

        public static int GetTeamDungeonXieZhu(this Unit self)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            return numericComponent.GetAsInt(NumericType.TeamDungeonXieZhu);
        }

        public static int GetMaxPiLao(this Unit self)
        {
            return int.Parse(GlobalValueConfigCategory.Instance.Get(self.IsYueKaStates() ? 26 : 10).Value);
        }

        public static int GetMaxHuoLi(this Unit self)
        {
            return GlobalValueConfigCategory.Instance.Get(72).Value2;
        }

        public static long GetAttributeValue(RolePetInfo rolePetInfo, int numericType)
        {
            for (int i = 0; i < rolePetInfo.Ks.Count; i++)
            {
                if (rolePetInfo.Ks[i] == numericType)
                {
                    return rolePetInfo.Vs[i];
                }
            }
            //从其他字段寻找
            //if (numericType == )
            return 0;
        }

        //传入子值返回母值
        public static int ReturnNumParValue(int sonValue) {

            return (int)(sonValue / 100);

        }
    }
}
