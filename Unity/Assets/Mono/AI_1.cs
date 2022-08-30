using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//此脚本用于怪物本身的智能
public class AI_1 : MonoBehaviour {
	
	//定义AI的属性
    public string AI_ID_Only;                       //世界生成的AI的唯一ID序号
    public long AI_ID;                              //世界生成的AI的ID序号
	public bool AI_Selected_Status;                 //是否被选中
    public string AI_Status;                        //AI状态                      0：巡逻  1：发现目标（但不追击）2：追击 3：攻击 4：返回（攻击目标太远） 5：死亡 6：释放技能 7：跟随主角模式 8:眩晕
    public GameObject AI_Target;                    //当前怪物目前注视的目标
    public GameObject Obj_AIModel;                  //AI模型
    public SkinnedMeshRenderer ModelMesh;           //AI材质
    private float hitMeshTime;                      //受击播放材质时间
    private bool hitMeshStatus;                     //受击播放材质状态
    public bool IfRosePet;                          //当前AI是否为玩家的召唤的宠物
    public GameObject MonsterCreateObj;             //怪物召唤的父级
    public bool AIStopMoveStatus;                   //怪物移动状态
    public bool AIStopLookTargetStatus;             //AI停止看目标状态
    public bool IfDeathDestoryModel;                //怪物死亡时是否立即销毁尸体

    //AI巡逻
    private bool ai_PatrolStatus;                   //AI是否在巡逻
    private bool ai_FindNextPatrol;                 //AI是否寻找下一个巡逻点
    private float ai_WalkSpeed;                     //AI走路速度（用于巡逻）
    private float ai_PatrolRange;                   //AI巡逻范围
    private float ai_PatrolRestTime;                //AI巡逻到达指定地点休息时间
    private float ai_PatrolGuardTime;               //AI巡逻保护时间
    private float ai_actRunRange;                   //怪物攻击范围
    public Vector3 ai_StarPosition;                //AI出生坐标点
    //public UnityEngine.AI.NavMeshAgent ai_NavMesh;                //AI自动寻路控制器
    private Vector3 targetPosition;                 //目标的坐标点
    private Vector3 walkPosition;                   //巡逻移动的目标点
    public float ai_chaseRange;                    //AI追击范围
    //private float ai_PartolTime;                  //AI两次寻路间隔时间;
	
	
	//AI属性声明
	private string AI_Name;
	private int  AI_Hp_Max;                         //AI血量上限
    public float AI_MoveSpeed;                     //怪物移动速度
    private bool AI_IfWalk;                         //怪物是否来回走
    private bool ai_IfReturn;                       //开启后表示怪事是在超出自身距离后返回
    private bool ai_IfChase;                        //当前ai是否处于追击状态
    private float ai_ActDistance;                   //当前ai攻击距离
    private float actSpeed;                         //攻击速度
    private float actSpped_Sum;                     //攻击速度统计值（累加值,用来判定当前时间是否满足下次攻击）
    private bool NextActStatus;                     //下一次攻击状态,如果为true表示可以立即进行下一次攻击
    private bool ActStatus;                         //攻击状态
    public float monsterRebirthTime;               //怪物复活时间（单位/秒）
    public float monsterReirthTimeSum;             //怪物复活时间累计值 
    public float monsterOffLineTime;
    private bool ai_IfDeath;                        //怪物是否死亡
    private bool ai_IfDeathTimeStatus;              //怪物是为死亡复活状态
    public float monsterDestoryTime;               //怪物销毁模型时间
    //private float ai_DeathTimeSum;                //怪物死亡复活时间累计
    private string[] skillID;                        //怪物自身的技能
    private string[] passiveSkillType;               //技能触发类型
    private string[] passiveSkillPro;                //技能触发类型参数
    private string[] passiveSkillTriggerOnce;        //技能是否只触发一次参数
    private string[] passiveSkillTriggerTime;        //技能触发时间类型
    private string[] ifSkillTrigger;                //技能是否触发,当次字段的数组为1是,对应的技能将不能再次释放
    private string[] passiveSkillTriggerTimeCD;     //技能CD
    private string[] passiveSkillTriggerTimeCDSum;  //技能CD计时
    private bool triggerSkillStatus;                //怪物触发技能状态
    private string triggerSkillID;                  //怪物触发技能ID
    //private bool actStatus;                         //每次攻击打开此状态判定是否释放技能
    private float passiveSkillTriggerTimeSum;        //在Updata里每隔多少时间监测一次是否触发被动

    public bool AI_UpdateProStatus;


	//当前AI变量
	public float AI_Distance;                       //AI距离角色的距离
	private bool AI_Hp_Status;                      //如果当前AI显示血条，则为True
    private bool AI_MonsterDeathUIStatus;           //怪物死亡复活状态
    private bool AI_MonsterDeathStatus;             //怪物死亡复活状态
	public GameObject Selected_Effect;              //选中特效
	public Transform Selected_Effect_Position;      //选中特效坐标点
	private bool Selected_Effect_Status;            //特效是否已经开启
	private GameObject effect;                      //当前实例化的光圈特效
	public Transform Ai_HpShowPosition;             //当前显示血条的坐标点
    private Transform ai_DeathTimePosition;         //怪物复活UI坐标点
	public GameObject UI_GameObject;                //UI的GameObject
    private GameObject UI_Hp;                       //AI血条的UI位置
    private GameObject monsterDeathTimeObj;         //AI死亡复活时间显示UI
	//private AI_Property ai_property;                //AI当前属性
	private bool MaxHp_Status;                      //是否取到最大生命值


	public bool HitStatus;                          //是否受到伤害
	public int HitDamge;                            //受到的伤害值
	public GameObject HitObject;                    //伤害飘字的显示UI
    public bool HitCriStatus;                       //是否受到暴击伤害
	private int LastHp;                             //上一次的生命值,飘字用的
    public bool IfHitEffect;                        //是否播放受伤特效
    public GameObject HitEffect;                    //受击特效
    public GameObject HitEffectt_Position;          //受击特效播放点
    public GameObject BoneSet;                      //骨骼绑点
    //private AI_Status ai_status;                    //AI状态脚本
    //private Rose_Status rose_status;
    //private Game_PositionVar game_positionVar;
    private GameObject obj_Rose;                    //主角的Obj
    private bool SkillStatus;
    //public bool petMoveStatus;                    //宠物跟随主角移动状态
    public float StopMoveTime;
    public float StopMoveTimeSum;
    public float AIStopLookTargetTime;
    public float AIStopLookTargetTimeSum;

    //public float AIStop

    public bool XuanYunStatus;                      //眩晕状态
    public float XuanYunTime;                       //眩晕时间
    public float xuanYunTimeSum;                    //眩晕时间累计
    private bool XuanYunFlyTextStatus;              //眩晕飘字状态
    //private Animator animator;

    //为了无限刷怪的BUG,修正掉落
    public bool dropStatus;
    private float dropNum;
    private float dropNumSum;

}
