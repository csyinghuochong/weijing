using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class ErrorHelp:Singleton<ErrorHelp>
    {

        public Dictionary<int,string> ErrorHintList = new Dictionary<int, string>();

        //单例的初始化
        protected override void InternalInit()
        {
            base.InternalInit();
            
            ErrorHintList.Add(ErrorCore.ERR_NetWorkError, "网络错误!");
            ErrorHintList.Add(ErrorCore.ERR_AccountAlreadyRegister, "账号已注册!");
            ErrorHintList.Add(ErrorCore.ERR_AccountInBlackListError, "账号异常!");
            ErrorHintList.Add(ErrorCore.ERR_LoginInfoIsNull, "未找到账号数据,请确认账号是否已经注册");
            ErrorHintList.Add(ErrorCore.ERR_AccountOrPasswordError, "密码错误,请检查重新输入");
            ErrorHintList.Add(ErrorCore.ERR_OtherAccountLogin, "账号异地登录");
            ErrorHintList.Add(ErrorCore.ERR_RequestRepeatedly, "请求重复");
            ErrorHintList.Add(ErrorCore.ERR_StopServer, "停服维护");
            ErrorHintList.Add(ErrorCore.ERR_BingPhoneError_1, "改手机号已经注册过账号");
            ErrorHintList.Add(ErrorCore.ERR_BingPhoneError_2, "手机号只能绑定一个账号");
            ErrorHintList.Add(ErrorCore.ERR_VersionNoMatch, "版本不一致，请更新客户端");
            
            //ErrorHintList.Add(ErrorCore.ERR_AccountOrPasswordError, "账号未注册!");
            ErrorHintList.Add(ErrorCore.ERR_GoldNotEnoughError, "金币不足!");
            ErrorHintList.Add(ErrorCore.ERR_DiamondNotEnoughError, "钻石不足!");
            ErrorHintList.Add(ErrorCore.ERR_HouBiNotEnough, "货币不足!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD1, "技能冷却中...");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD2, "技能公共冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD3, "主动技能冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD4, "被动技能冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD5, "技能冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD6, "公共技能冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotUseSkill_1, "当前状态无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotUseSkill_Rigidity, "僵直状态无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotUseSkill_NetWait, "消息未返回无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotUseSkill_Dizziness, "眩晕状态无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotUseSkill_JiTui, "击退状态无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotUseSkill_Silence, "沉默状态无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_SkillMoveTime, "当前为技能释放状态!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotSkillDead, "死亡状态无法释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillError, "释放技能出错!");
            ErrorHintList.Add(ErrorCore.ERR_NoUseItemSkill, "该场景不能使用药剂道具技能!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_1, "当前状态无法移动!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_Dead, "死亡状态无法移动!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_Rigidity, "僵直状态无法移动!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_NetWait, "消息未返回无法移动!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_Dizziness, "眩晕状态无法移动!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_JiTui, "击退状态无法移动!");
            ErrorHintList.Add(ErrorCore.ERR_CanNotMove_Shackle, "禁锢状态无法移动!");

            ErrorHintList.Add(ErrorCore.ERR_UnSafeSqlString, "非法字符串!");
            ErrorHintList.Add(ErrorCore.ERR_EquipLvLimit, "角色等级不足!");
            ErrorHintList.Add(ErrorCore.ERR_BagIsFull, "背包已满!");
            ErrorHintList.Add(ErrorCore.ERR_ItemNotEnoughError, "道具不足!");
            ErrorHintList.Add(ErrorCore.ERR_ItemDropProtect, "掉落保护中!");
            ErrorHintList.Add(ErrorCore.ERR_ItemBelongOther, "该道具归属其他玩家!");
            ErrorHintList.Add(ErrorCore.ERR_NoPayValueError, "赞助额度不足!");
            ErrorHintList.Add(ErrorCore.ERR_ItemNoUseTime, "道具今天不能再使用!");
            ErrorHintList.Add(ErrorCore.ERR_EquipAppraisal_Item,"鉴定失败!所需鉴定道具不足...");
            ErrorHintList.Add(ErrorCore.ERR_Occ_Hint_1, "转职失败!请先将角色等级提升至18级");
            ErrorHintList.Add(ErrorCore.ERR_Occ_Hint_2, "请不要重复进行转职噢");
            ErrorHintList.Add(ErrorCore.ERR_NotRealName, "请先实名认证");
            ErrorHintList.Add(ErrorCore.ERR_RealNameFail, "实名认证失败!");
            ErrorHintList.Add(ErrorCore.ERR_WordChat, "世界频道发消息 1分钟1次");
            ErrorHintList.Add(ErrorCore.ERR_InMakeCD, "制作冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_MakeTypeError, "制作类型不符!");
            ErrorHintList.Add(ErrorCore.ERR_ZhuaBuFail, "抓捕失败!");

            ErrorHintList.Add(ErrorCore.ERR_CreateRoleName, "角色名非法!");
            ErrorHintList.Add(ErrorCore.ERR_RoleNameRepeat, "角色名重复!");
            ErrorHintList.Add(ErrorCore.ERR_ShuLianDuNotEnough, "当前制造需求熟练度不足!");
            ErrorHintList.Add(ErrorCore.ERR_EquipType, "装备穿戴类型不符!");
            ErrorHintList.Add(ErrorCore.ERR_GemNoError, "宝石一旦镶嵌无法卸载!");
            ErrorHintList.Add(ErrorCore.ERR_GemShiShiNumFull, "史诗宝石最多可镶嵌4个!");

            ErrorHintList.Add(ErrorCore.ERR_TeamIsFull, "队伍已满");
            ErrorHintList.Add(ErrorCore.ERR_LevelIsNot, "等级不足");
            ErrorHintList.Add(ErrorCore.ERR_IsHaveTeam, "已经有组队了");
            ErrorHintList.Add(ErrorCore.ERR_TimesIsNot, "次数不足");
            ErrorHintList.Add(ErrorCore.ERR_IsNotLeader, "队长才能创建副本");
            ErrorHintList.Add(ErrorCore.ERR_PlayerIsNot, "人数不足");
            ErrorHintList.Add(ErrorCore.ERR_TeamerLevelIsNot, "队员等级不足");
            ErrorHintList.Add(ErrorCore.Err_OnLineTimeNot, "在线时间不足");

            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip1, "您目前为未成年人账号，已被纳入防沉迷系统。根据国家新闻出版署《关于进一步严格管理切实防止未成年人沉迷网络游戏的通知》，仅每周五、周六、周日和法定节假日每日20时至21时提供1小时网络游戏服务。您今日游戏剩余时间{0}分钟。");
            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip2, "您目前为未成年人账号，已被纳入防沉迷系统。根据国家新闻出版署《关于防止未成年人沉迷网络游戏的通知》，您已超出支付上限，无法继续充值。");
            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip3, "您目前为未成年人账号，已被纳入防沉迷系统。根据国家新闻出版署《关于防止未成年人沉迷网络游戏的通知》，本游戏不为未满8周岁的用户提供游戏充值服务。");
            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip4, "您目前为未成年人账号，已被纳入防沉迷系统。根据国家新闻出版署《关于防止未成年人沉迷网络游戏的通知》，游戏中8周岁以上未满16周岁的用户，单次充值金额不得超过50元人民币，每月充值金额不得超过200元人民币。");
            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip5, "您目前为未成年人账号，已被纳入防沉迷系统。根据国家新闻出版署《关于防止未成年人沉迷网络游戏的通知》，游戏中16周岁以上未满18周岁的用户，单次充值金额不得超过100元人民币，每月充值金额不得超过400元人民币。");
            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip6, "您目前为未成年人账号，已被纳入防沉迷系统。根据适龄提示，此时段本游戏将无法为不满12周岁未成年人用户提供任何形式的游戏服务。");
            ErrorHintList.Add(ErrorCore.ERR_FangChengMi_Tip7, "您目前为未成年人账号，已被纳入防沉迷系统。根据国家新闻出版署《关于进一步严格管理切实防止未成年人沉迷网络游戏的通知》，仅每周五、周六、周日和法定节假日每日20时至21时提供1小时网络游戏服务。");

            ErrorHintList.Add(ErrorCore.ERR_TaskCommited, "当前任务奖励已领取");
            ErrorHintList.Add(ErrorCore.ERR_NotFindLevel, "未找到对应关卡");
            ErrorHintList.Add(ErrorCore.ERR_TiLiNoEnough, "体力不足");
            ErrorHintList.Add(ErrorCore.ERR_LevelNotOpen, "请先通关前置关卡");
            ErrorHintList.Add(ErrorCore.ERR_ExpNoEnough, "经验不足");
            ErrorHintList.Add(ErrorCore.ERR_LevelNoEnough, "等级不足");
            ErrorHintList.Add(ErrorCore.ERR_LevelNormalNoPass, "普通关卡未通关");
            ErrorHintList.Add(ErrorCore.ERR_LevelChallengeNoPass, "挑战关卡未通关");
            ErrorHintList.Add(ErrorCore.ERR_NotFindNpc, "任务点不在此地图，请根据指示前往其他地图。");
            ErrorHintList.Add(ErrorCore.ERR_TaskCanNotGet, "未达到领取条件");
            
            ErrorHintList.Add(ErrorCore.ERR_Pet_Hint_1, "宠物星级出错");
            ErrorHintList.Add(ErrorCore.ERR_Pet_UpStar, "宠物星级失败");
            ErrorHintList.Add(ErrorCore.ERR_Pet_UpStage, "宠物进化失败");
            ErrorHintList.Add(ErrorCore.ERR_Pet_AddSkillSame, "具有相同技能,无法使用此道具");
            ErrorHintList.Add(ErrorCore.ERR_Pet_NoUseItem, "此道具无法应用于宠物身上");
            ErrorHintList.Add(ErrorCore.ERR_PetIsFull, "当前携带的宠物数量已达上限");
            
            ErrorHintList.Add(ErrorCore.ERR_ItemOnlyUseMiJing, "该道具只能在宝藏之地使用");
            ErrorHintList.Add(ErrorCore.ERR_ItemOnlyUseOcc, "该道具只有{0}可以使用");

            ErrorHintList.Add(ErrorCore.ERR_Union_Same_Name, "已经存在同名的家族");

            ErrorHintList.Add(ErrorCore.ERR_RoleYueKaRepeat, "周卡重复开启");
            ErrorHintList.Add(ErrorCore.ERR_AlreadyFinish, "活动已经结束");
            ErrorHintList.Add(ErrorCore.ERR_MysteryItem_Max, "此道具每日购买次数已达上限");

            ErrorHintList.Add(ErrorCore.ERR_ShangJinNumFull, "今日领取赏金次数已满");

            ErrorHintList.Add(ErrorCore.ERR_BattleJoined, "已经参与过战场活动");

            ErrorHintList.Add(ErrorCore.Err_PaiMaiPriceLow, "拍卖行出售价格过低");

            ErrorHintList.Add(ErrorCore.ERR_HoreseNotFight,"请到主城坐骑训练师选择自己的骑乘坐骑吧");
            ErrorHintList.Add(ErrorCore.ERR_HoreseNotActive, "坐骑未出战");
            
            ErrorHintList.Add(ErrorCore.ERR_VitalityNotEnoughError, "活力不足");
            ErrorHintList.Add(ErrorCore.Err_TeamDungeonXieZhu, "帮助副本只能创建比自己等级低10级以上的副本");

            ErrorHintList.Add(ErrorCore.ERR_AlreadyReceived, "已经领取过奖励");

            ErrorHintList.Add(ErrorCore.ERR_TitleNoActived, "称号未激活");

            ErrorHintList.Add(ErrorCore.ERR_AlreadyPlant, "改土地已经种植了");
            ErrorHintList.Add(ErrorCore.ERR_JiaYuanLevel, "家园等级不足");
            ErrorHintList.Add(ErrorCore.ERR_PeopleNumber, "家园人口已达上限");
            
        }

        public string GetHint(int code)
        {
            if (code == 0)
            {
                return "";
            }
            string hintStr = code.ToString();
            ErrorHintList.TryGetValue(code, out hintStr);
            return hintStr;
        }

        public void ErrorHint(int code) 
        {
            if (code == 0)
            {
                return;
            }
            string hintStr = code.ToString();
            ErrorHintList.TryGetValue(code, out hintStr);
            if (string.IsNullOrEmpty(hintStr))
            {
                FloatTipManager.Instance.ShowFloatTipDi(code.ToString());
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTipDi(hintStr);
            }
        }

    }
}
