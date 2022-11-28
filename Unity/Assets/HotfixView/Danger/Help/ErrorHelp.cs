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
            ErrorHintList.Add(ErrorCore.ERR_AccountInBlackListError, "账号异常,禁止登录!");
            ErrorHintList.Add(ErrorCore.ERR_LoginInfoIsNull, "未找到账号数据,请确认账号是否已经注册");
            ErrorHintList.Add(ErrorCore.ERR_AccountOrPasswordError, "密码错误,请检查重新输入");
            ErrorHintList.Add(ErrorCore.ERR_OtherAccountLogin, "账号异地登录");
            ErrorHintList.Add(ErrorCore.ERR_RequestRepeatedly, "请求重复");
            ErrorHintList.Add(ErrorCore.ERR_StopServer, "停服维护");

            //ErrorHintList.Add(ErrorCore.ERR_AccountOrPasswordError, "账号未注册!");
            ErrorHintList.Add(ErrorCore.ERR_GoldNotEnoughError, "金币不足!");
            ErrorHintList.Add(ErrorCore.ERR_DiamondNotEnoughError, "钻石不足!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD1, "技能列表为空!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD2, "技能冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillInCD3, "当前状态不是释放技能!");
            ErrorHintList.Add(ErrorCore.ERR_UseSkillError, "释放技能出错!");
            ErrorHintList.Add(ErrorCore.ERR_NoUseItemSkill, "该场景不能使用药剂道具技能!");
            ErrorHintList.Add(ErrorCore.ERR_UnSafeSqlString, "非法字符串!");
            ErrorHintList.Add(ErrorCore.ERR_EquipLvLimit, "装备等级不足!");
            ErrorHintList.Add(ErrorCore.ERR_BagIsFull, "背包已满!");
            ErrorHintList.Add(ErrorCore.ERR_ItemNotEnoughError, "道具不足!");
            ErrorHintList.Add(ErrorCore.ERR_ItemDropProtect, "掉落保护中!");
            ErrorHintList.Add(ErrorCore.ERR_EquipAppraisal_Item,"鉴定失败!所需鉴定道具不足...");
            ErrorHintList.Add(ErrorCore.ERR_Occ_Hint_1, "转职失败!请先将角色等级提升至18级");
            ErrorHintList.Add(ErrorCore.ERR_Occ_Hint_2, "请不要重复进行转职噢");
            ErrorHintList.Add(ErrorCore.ERR_NotRealName, "请先实名认证");
            ErrorHintList.Add(ErrorCore.ERR_WordChat, "世界频道发消息 1分钟1次");
            ErrorHintList.Add(ErrorCore.ERR_InMakeCD, "制作冷却中!");
            ErrorHintList.Add(ErrorCore.ERR_MakeTypeError, "制作类型不符!");

            ErrorHintList.Add(ErrorCore.ERR_CreateRoleName, "角色名非法!");
            ErrorHintList.Add(ErrorCore.ERR_RoleNameRepeat, "角色名重复!");

            ErrorHintList.Add(ErrorCore.ERR_TeamIsFull, "队伍已满");
            ErrorHintList.Add(ErrorCore.ERR_LevelIsNot, "等级不足");
            ErrorHintList.Add(ErrorCore.ERR_IsHaveTeam, "已经有组队了");
            ErrorHintList.Add(ErrorCore.ERR_TimesIsNot, "次数不足");
            ErrorHintList.Add(ErrorCore.ERR_IsNotLeader, "队长才能创建副本");
            ErrorHintList.Add(ErrorCore.ERR_PlayerIsNot, "人数不足");
            ErrorHintList.Add(ErrorCore.ERR_TeamerLevelIsNot, "队员等级不足");

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
            ErrorHintList.Add(ErrorCore.ERR_LevelNoEnough, "等级不足");
            ErrorHintList.Add(ErrorCore.ERR_LevelNormalNoPass, "普通关卡未通关");
            ErrorHintList.Add(ErrorCore.ERR_LevelChallengeNoPass, "挑战关卡未通关");
            ErrorHintList.Add(ErrorCore.ERR_NotFindNpc, "任务点不在此地图，请根据指示前往其他地图。");
            ErrorHintList.Add(ErrorCore.ERR_CanNotGet, "未达到领取条件");
            
            ErrorHintList.Add(ErrorCore.ERR_Pet_Hint_1, "宠物星级出错");
            ErrorHintList.Add(ErrorCore.ERR_Pet_UpStar, "宠物星级失败");
            ErrorHintList.Add(ErrorCore.ERR_Pet_AddSkillSame, "具有相同技能,无法使用此道具");
            ErrorHintList.Add(ErrorCore.ERR_ItemOnlyUseMiJing, "该道具只能在宝藏之地使用");
            ErrorHintList.Add(ErrorCore.ERR_ItemOnlyUseOcc, "该道具只有{0}可以使用");

            ErrorHintList.Add(ErrorCore.ERR_Union_Same_Name, "已经存在同名的家族");

            ErrorHintList.Add(ErrorCore.ERR_RoleYueKaRepeat, "月卡重复开启");
            ErrorHintList.Add(ErrorCore.ERR_AlreadyFinish, "活动已经结束");
            ErrorHintList.Add(ErrorCore.ERR_MysteryItem_Max, "改道具每日购买次数已达上限");

            ErrorHintList.Add(ErrorCore.ERR_ShangJinNumFull, "今日领取赏金次数已满");

            ErrorHintList.Add(ErrorCore.ERR_BattleJoined, "已经参与过战场活动");
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
