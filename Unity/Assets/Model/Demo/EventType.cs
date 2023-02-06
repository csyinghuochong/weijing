using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    namespace EventType
    {

        public struct AppStart
        {
        }

        public class SceneChangeStart : DisposeObject
        {
            public static readonly SceneChangeStart Instance = new SceneChangeStart();
            public Scene ZoneScene;
            public int LastSceneType;
            public int SceneType;
            public int ChapterId;
        }

        public class SceneChangeFinish : DisposeObject
        {
            public static readonly SceneChangeFinish Instance = new SceneChangeFinish();
            public Scene ZoneScene;
            public Scene CurrentScene;

            public override void Dispose()
            {
                this.ZoneScene = null;
                this.CurrentScene = null;
            }
        }

        public class ChangePosition : DisposeObject
        {
            public static readonly ChangePosition Instance = new ChangePosition();
            public Unit Unit;
            public WrapVector3 OldPos = new WrapVector3();

            // 因为是重复利用的，所以用完PublishClass会调用Dispose
            public override void Dispose()
            {
            }
        }

        public class ChangeRotation : DisposeObject
        {
            public static readonly ChangeRotation Instance = new ChangeRotation();
            public Unit Unit;

            // 因为是重复利用的，所以用完PublishClass会调用Dispose
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class PingChange : DisposeObject
        {
            public static readonly PingChange Instance = new PingChange();
            public Scene ZoneScene;
            public long Ping;
        }

        public class AfterCreateZoneScene : DisposeObject
        {
            public static readonly AfterCreateZoneScene Instance = new AfterCreateZoneScene();
            public Scene ZoneScene;
        }

        public class AfterCreateCurrentScene : DisposeObject
        {
            public static readonly AfterCreateCurrentScene Instance = new AfterCreateCurrentScene();
            public Scene CurrentScene;
        }

        public class AppStartInitFinish : DisposeObject
        {
            public static readonly AppStartInitFinish Instance = new AppStartInitFinish();
            public Scene ZoneScene;
        }

        public class LoginFinish : DisposeObject
        {
            public static readonly LoginFinish Instance = new LoginFinish();
            public Scene ZoneScene;
        }

        public class LoadingFinish : DisposeObject
        {
            public static readonly LoadingFinish Instance = new LoadingFinish();
            public Scene Scene;
        }

        public class EnterMapFinish : DisposeObject
        {
            public static readonly EnterMapFinish Instance = new EnterMapFinish();
            public Scene ZoneScene;
        }

        public class BeginRelink : DisposeObject
        {
            public static readonly BeginRelink Instance = new BeginRelink();
            public Scene ZoneScene;
        }

        public class RelinkSucess : DisposeObject
        {
            public static readonly RelinkSucess Instance = new RelinkSucess();
            public Scene ZoneScene;
            public int ErrorCode;
        }

        public class ReturnLogin : DisposeObject
        {
            public static readonly ReturnLogin Instance = new ReturnLogin();
            public Scene ZoneScene;
            public int ErrorCode;
        }

        public class LoginError : DisposeObject
        {
            public static readonly LoginError Instance = new LoginError();
            public int ErrorCore;
            public long AccountId;
            public Scene ZoneScene;
            public string Value;
        }

        public class EnterQueue : DisposeObject
        {
            public static readonly LoginError Instance = new LoginError();
            public int ErrorCore;
            public long AccountId;
            public Scene ZoneScene;
            public string Value;
        }

        public class QueueEnterGame : DisposeObject
        {
            public static readonly QueueEnterGame Instance = new QueueEnterGame();
            public Scene ZoneScene;
            public string Token;
        }

        public class RoleDataBroadcase : DisposeObject
        {
            public static readonly RoleDataBroadcase Instance = new RoleDataBroadcase();
            public UserDataType UserDataType;
            public string UserDataValue;
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class BeforeEnterSonFuben : DisposeObject
        {
            public static readonly BeforeEnterSonFuben Instance = new BeforeEnterSonFuben();
            public Scene ZoneScene;
        }

        //副本
        public class AfterEnterFuben : DisposeObject
        {
            public static readonly AfterEnterFuben Instance = new AfterEnterFuben();
            public Scene ZoneScene;
            public bool EnterSonScene;
            public int DirectionType;
        }

        public class UnitDead : DisposeObject
        {
            public static readonly UnitDead Instance = new UnitDead();
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class UnitRevive : DisposeObject
        {
            public static readonly UnitRevive Instance = new UnitRevive();
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        /// <summary>
        /// 数据更新
        /// </summary>
        public class DataUpdate : DisposeObject
        {
            public static readonly DataUpdate Instance = new DataUpdate();
            public int DataType;
            public string DataParams;
        }

        public class BattleInfo : DisposeObject
        {
            public static readonly BattleInfo Instance = new BattleInfo();
            public M2C_BattleInfoResult m2C_Battle;
            public Scene ZoneScene;
        }

        public class RolePetAdd : DisposeObject
        {
            public static readonly RolePetAdd Instance = new RolePetAdd();
            public List<KeyValuePair> OldPetSkin;
            public RolePetInfo RolePetInfo;
            public Scene ZoneScene;
        }


        public class TeamDungeonQuit : DisposeObject
        {
            public static readonly TeamDungeonQuit Instance = new TeamDungeonQuit();
            public M2C_TeamDungeonQuitMessage m2C_Battle;
            public Scene ZoneScene;
        }

        /// <summary>
        /// 通用提示
        /// </summary>
        public class CommonHint : DisposeObject
        {
            public static readonly CommonHint Instance = new CommonHint();
            public string HintText;
        }

        /// <summary>
        /// 错误码通用提示
        /// </summary>
        public class CommonHintError : DisposeObject
        {
            public static readonly CommonHintError Instance = new CommonHintError();
            public int errorValue;
        }

        /// <summary>
        /// 好友申请
        /// </summary>
        public class ReddotChange : DisposeObject
        {
            public static readonly ReddotChange Instance = new ReddotChange();
            public Scene ZoneScene;
            public int ReddotType;
            public int Number;
        }

        /// <summary>
        /// 收到组队邀请
        /// </summary>
        public class RecvTeamInvite : DisposeObject
        {
            public static readonly RecvTeamInvite Instance = new RecvTeamInvite();
            public M2C_TeamInviteResult m2C_TeamInviteResult;
            public Scene ZoneScene;
        }

        /// <summary>
        /// 收到进入组队的申请
        /// </summary>
        public class RecvTeamApply : DisposeObject
        {
            public static readonly RecvTeamApply Instance = new RecvTeamApply();
            public M2C_TeamDungeonApplyResult m2C_TeamDungeonApplyResult;
            public Scene ZoneScene;
        }

        public class RecvTeamDungeonOpen : DisposeObject
        {
            public static readonly RecvTeamDungeonOpen Instance = new RecvTeamDungeonOpen();
            public Scene ZoneScene;
        }

        public class RecvTeamUpdate : DisposeObject
        {
            public static readonly RecvTeamUpdate Instance = new RecvTeamUpdate();
            public Scene ZoneScene;
        }

        public class ChuanSongOpen : DisposeObject
        {
            public static readonly ChuanSongOpen Instance = new ChuanSongOpen();
            public Scene ZoneScene;
        }

        //点击物品
        public class ShowItemTips : DisposeObject
        {
            public static readonly ShowItemTips Instance = new ShowItemTips();
            public Scene ZoneScene;
            public BagInfo bagInfo;
            public ItemOperateEnum itemOperateEnum;
            public Vector3 inputPoint;
            public List<BagInfo> EquipList = new List<BagInfo>();
            public int Occ;
        }

        //副本结算
        public class FubenSettlement : DisposeObject
        {
            public static readonly FubenSettlement Instance = new FubenSettlement();
            public M2C_FubenSettlement m2C_FubenSettlement;
            public Scene Scene;
        }

        //组队副本结算
        public class TeamDungeonSettlement : DisposeObject
        {
            public static readonly TeamDungeonSettlement Instance = new TeamDungeonSettlement();
            public M2C_TeamDungeonSettlement m2C_FubenSettlement;
            public Scene ZoneScene;
        }

        //组队副本宝箱奖励
        public class TeamDungeonBoxReward : DisposeObject
        {
            public static readonly TeamDungeonBoxReward Instance = new TeamDungeonBoxReward();
            public M2C_TeamDungeonBoxRewardResult m2C_FubenSettlement;
            public Scene Scene;
        }

        public class AfterUnitCreate : DisposeObject
        {
            public static readonly AfterUnitCreate Instance = new AfterUnitCreate();

            public Unit Unit;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class ShowGuide : DisposeObject
        {
            public static readonly ShowGuide Instance = new ShowGuide();
            public Scene ZoneScene;
            public int GuideId;
            public int GroupId;
        }

        public class BeforeMove : DisposeObject
        {
            public static readonly BeforeMove Instance = new BeforeMove();
            public Scene ZoneScene;
        }

        public class BeforeSkill : DisposeObject
        {
            public static readonly BeforeSkill Instance = new BeforeSkill();
            public Scene ZoneScene;
        }

        public class MoveStart : DisposeObject
        {
            public static readonly MoveStart Instance = new MoveStart();
            public Unit Unit;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //更新血量
        public class UnitHpUpdate : DisposeObject
        {
            public static readonly UnitHpUpdate Instance = new UnitHpUpdate();
            public Unit Unit;
            public int SkillID;
            public int DamgeType;
            public float ChangeHpValue;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        /// <summary>
        /// Unit(NumberType)数据更新
        /// </summary>
        public class UnitNumericUpdate : DisposeObject
        {
            public static readonly UnitNumericUpdate Instance = new UnitNumericUpdate();
            public Unit Unit;
            public long OldValue;
            public int NumericType;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //技能预警
        public class SkillYuJing : DisposeObject
        {
            public static readonly SkillYuJing Instance = new SkillYuJing();

            public SkillConfig SkillConfig;
            public SkillInfo SkillInfo;
            public Unit Unit;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //技能音效
        public class SkillSound : DisposeObject
        {
            public static readonly SkillSound Instance = new SkillSound();
            public string Asset;
        }

        public class MoveStop : DisposeObject
        {
            public static readonly MoveStop Instance = new MoveStop();
            public Unit Unit;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //技能特效
        public class SkillEffect : DisposeObject
        {
            public static readonly SkillEffect Instance = new SkillEffect();
            public EffectData EffectData;
            public Unit Unit;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class SkillEffectMove : DisposeObject
        {
            public static readonly SkillEffectMove Instance = new SkillEffectMove();
            public long EffectInstanceId = 0;
            public Vector3 Postion;
            public float Angle;
            public Unit Unit;
            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class SkillEffectFinish : DisposeObject
        {
            public static readonly SkillEffectFinish Instance = new SkillEffectFinish();
            public long EffectInstanceId = 0;
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        public class TeamPickNotice : DisposeObject
        {
            public static readonly TeamPickNotice Instance = new TeamPickNotice();
            public M2C_TeamPickMessage m2C_TeamPickMessage;
            public Scene ZoneScene;
        }

        public class SkillChainLight : DisposeObject
        {
            public static readonly SkillChainLight Instance = new SkillChainLight();

            public M2C_ChainLightning M2C_ChainLightning;

            public Scene ZoneScene;
        }

        public class SyncMiJingDamage : DisposeObject
        {
            public static readonly SyncMiJingDamage Instance = new SyncMiJingDamage();

            public M2C_SyncMiJingDamage M2C_SyncMiJingDamage;

            public Scene ZoneScene;
        }

        public class SkillEffectReset : DisposeObject
        {
            public static readonly SkillEffectReset Instance = new SkillEffectReset();
            public long EffectInstanceId = 0;
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //npc對話
        public class TaskNpcDialog : DisposeObject
        {
            public static readonly TaskNpcDialog Instance = new TaskNpcDialog();
            public TaskPro TaskPro;
            public Scene zoneScene;
            public int ErrorCode;
        }

        public class StateChange : DisposeObject
        {
            public static readonly StateChange Instance = new StateChange();

            public M2C_UnitStateUpdate m2C_UnitStateUpdate;
            public Unit Unit;
        }

        //动画
        public class PlayAnimator : DisposeObject
        {
            public static readonly PlayAnimator Instance = new PlayAnimator();

            public string Animator;
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //状态机
        public class FsmChange : DisposeObject
        {
            public static readonly FsmChange Instance = new FsmChange();

            public int FsmHandlerType;
            public int FsmValue;
            public Unit Unit;

            public override void Dispose()
            {
                this.Unit = null;
            }
        }

        //吟唱
        public class SingingUpdate : DisposeObject
        {
            public static readonly SingingUpdate Instance = new SingingUpdate();

            public Scene ZoneScene;
            public long PassTime;
            public long TotalTime;
            public int Type;
        }

        //挖宝
        public class DigForTreasure : DisposeObject
        {
            public static readonly DigForTreasure Instance = new DigForTreasure();
            public Scene ZoneScene;
            public BagInfo BagInfo;
        }
    }
}