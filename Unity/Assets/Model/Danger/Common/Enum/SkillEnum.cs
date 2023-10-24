using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public enum BuffState
    {
        /// <summary>
        /// 等待执行
        /// </summary>
        Waiting,
        /// <summary>
        /// 正在执行
        /// </summary>
        Running,
        /// <summary>
        /// Buff使命完成
        /// </summary>
        Finished,
    }

    //0：无视
    //1：普攻触发概率
    //2：血量低于多少百分比触发
    //3: 受到伤害触发概率
    //4: 暴击时触发效果
    //5：闪避时触发效果
    //6：即将死亡时触发
    //7：释放技能时触发
    //8：更换武器触发
    //9：近战普攻触发 攻击距离参数 SkillRangeSize<=4
    //10: 远程普攻触发 攻击距离参数 SkillRangeSize> 4
    //11：触发天赋效果
    //12: 自己或队友进入地图时触发
    //13: 触发眩晕效果时触发
    //14：站立不动触发


    public static class SkillPassiveTypeEnum
    {
        public const int None = 0;
        public const int AckGaiLv_1 = 1;
        public const int XueLiang_2 = 2;
        public const int BeHurt_3 = 3;
        public const int Critical_4 = 4;
        public const int ShanBi_5 = 5;
        public const int WillDead_6 = 6;
        public const int SkillGaiLv_7 = 7;
        public const int WandBuff_8 = 8;
        public const int AckDistance_9 = 9;
        public const int AckDistance_10 = 10;
        public const int TianFu_11 = 11;
        public const int TeamerEnter_12 = 12;
        public const int Dizziness_13 = 13;
        public const int IdleStill_14 = 14;
        public const int EquipIndex_15 = 15;
    }

    //1：主动技能
    //2：被动技能 （被动技能不能被拖拽）
    //3:  装备附加提升原始技能
    //4:  宠物技能
    //5:  被动附加属性技能ID
    //6: 武器总技能ID（根据不同武器分配不同的技能ID）
    public enum SkillTypeEnum
    { 
        None,
        ActiveSkill = 1,
        PassiveSkill = 2,
        PassiveAddProSkill = 5, //被动附加属性技能
        PassiveAddProSkillNoFight = 8, //被动附加属性技能
    }

    //0  自身中心点
    //1  指定目标位置
    //2  定点位置
    //3  自身中心点随机
    //4  目标中心点随机
    //5  定点位置随机
    //6  跟随目标随机
    //7  指定目标
    //8  指定自己
    //9  跟随自己
    //10 多个目标

    public static class SkillTargetType
    {
        public const int SelfPosition = 0;
        public const int TargetPositon = 1;
        public const int FixedPosition = 2;
        public const int SelfRandom = 3;
        public const int TargetRandom = 4;
        public const int PositionRandom = 5;
        public const int TargetFollow = 6;
        public const int TargetOnly = 7;
        public const int SelfOnly = 8;
        public const int SelfFollow = 9;
        public const int MulTarget = 10;
    }

    //0：
    //1：表示需要释放前需要选中释放范围
    //2: 直线释放.弹道
    //3: 60°
    //4: 120°
    public static class SkillZhishiType
    {
        public const int None = 0;
        public const int Position = 1;
        public const int Line = 2;
        public const int Angle60 = 3;
        public const int Angle120 = 4;

        public const int CommonAttack = 101;
        public const int TargetOnly = 102;
    }

    public static class SkillSetEnum
    {
        public const int None = 0;
        public const int Skill = 1;
        public const int Item = 2;
    }

    public static class SkillSourceEnum
    {
        public const int Skill = 0;
        public const int Equip = 1;
        public const int TianFu = 2;
        public const int Sprite = 3;
        public const int Suit = 4;
        public const int Book = 5;
        public const int Buff = 6; 
    }

    //1.增加范围
    //2.技能伤害来源的攻击值系数,为1时表示造成100%攻击力的伤害
    //3.技能附加固定伤害值
    //4.减少冷却CD
    //5.技能持续时间
    //6.技能附加额外buff
    public enum SkillAttributeEnum
    {
        AddDamageRange = 1,
        AddDamageCoefficient = 2,
        AddDamageValue = 3,
        ReduceSkillCD = 4,
        AddSkillLiveTime = 5,
        AddSkillBuffID = 6,
    }

    //BuffPropertyAdd
    public enum BuffAttributeEnum
    {
        AddParameterValue = 1,
        AddBuffTime = 2,
    }

    public class TianFuProEnum
    {
        public const string SkillIdAdd = "SkillIdAdd";
        public const string SkillPropertyAdd = "SkillPropertyAdd";
        public const string BuffIdAdd = "BuffIdAdd";
        public const string BuffInitIdAdd = "BuffInitIdAdd";
        public const string RolePropertyAdd = "RolePropertyAdd";
        public const string ReplaceSkillId = "ReplaceSkillId";
        public const string BuffPropertyAdd = "BuffPropertyAdd";
        public const string SkillSingingCancel = "SkillSingingCancel";
    }

    public class SkillCDItem
    {
        public int SkillID;
        public long CDEndTime;
        public long CDPassive;
    }

    /// <summary>
    /// Buff逻辑类型
    /// </summary>
    public static class EffectTypeEnum
    {
        public const int SkillEffect = 1;              //技能特效
        public const int BuffEffect = 2;
    }

    public struct EffectData
    {
        //必填项
        public int EffectTypeEnum;

        //相关配置表
        public int SkillId;
        public int EffectId;

        public Vector3 EffectPosition;
        public float EffectAngle;

        public int TargetAngle;
        public long TargetID;

        public long InstanceId;

        public long EffectBeginTime;
    }

    public struct BuffData
    {
        //buff角度
        public int TargetAngle;

        public long BuffEndTime;

        public string Spellcaster;

        public int UnitType;
        public int UnitConfigId;
        public int SkillId;
        public int BuffId;

        public Vector3 TargetPostion;
    }

    public enum SkillState
    {
        /// <summary>
        /// 等待执行
        /// </summary>
        Waiting,
        /// <summary>
        /// 正在执行
        /// </summary>
        Running,
        /// <summary>
        /// 使命完成
        /// </summary>
        Finished,
    }
}
