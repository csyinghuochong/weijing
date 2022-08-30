using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestMove : MonoBehaviour
{

    private Vector3 m_targetpos;
    private Transform followTarget ;
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        CameraControl cc =  camera.AddComponent<CameraControl>();
        cc.followTarget = this.transform;
        followTarget = this.transform;
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        animator = gameObject.GetComponentInChildren<Animator>();

        Debug.Log("followTarget = " + followTarget);

    }


    private void GetKeyboardMoveMent()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //this.mLastMousePosition = Input.mousePosition;

            //生成一条从摄像机发出的射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //用来存储射线打中物体的信息
            RaycastHit hit;
            //发射射线
            bool result = Physics.Raycast(ray, out hit);
            //如果为true说明打中物体了
            if (result)
            {
                //获取射线打中的物体
                //hit.collider;
                //获取射线打中的坐标（这是一个世界坐标）
                //hit.point;

                //获取打中的目标
                m_targetpos = hit.point;

                navMeshAgent.speed = moveSpeed;

                bool bbb = navMeshAgent.isOnNavMesh;
                navMeshAgent.isStopped = false;
                navMeshAgent.SetDestination(hit.point);
                //animator.SetFloat(AnimatorConstant.MoveIdleBlend, 1);
                //走
                animator.Play("Run");
            }
            else
            {

                navMeshAgent.isStopped = true;
                //m_targetpos = Vector3.zero;
                //animator.SetFloat(AnimatorConstant.MoveIdleBlend, 0);

                //停
                animator.Play("Idle");
            }
        }
    }

    void LateUpdate()
    {
        GetKeyboardMoveMent();
    }

    // Update is called once per frame
    void Update()
    {
        //if (m_targetpos == Vector3.zero)
        //    return;


        //移动
        ///followTarget.Translate(Vector3.forward * 5 * Time.deltaTime);
        //检测到终点的距离
        if (followTarget != null)
        {
            if (Vector3.Distance(followTarget.position, m_targetpos) < 0.2f)
            {
                //到达终点
                navMeshAgent.isStopped = true;
                //animator.SetFloat(AnimatorConstant.MoveIdleBlend, 0);
                animator.Play("Idle");
            }
            else
            {
                //将角色转向到指定的方向
                followTarget.rotation = Quaternion.Lerp(followTarget.rotation, Quaternion.LookRotation(m_targetpos - new Vector3(followTarget.position.x, followTarget.position.y, followTarget.position.z)), Time.deltaTime * 20f);
            }
        }
    }
}


class AnimatorConstant
{
    public const string StandbyId = "StandbyId";
    public const string ButtonDown = "ButtonDown";
    public const string ButtonId = "ButtonId";
    public const string ButtonIdIndex = "ButtonIdIndex";
    public const string MoveIdleBlend = "MoveIdleBlend";
    public const string NormalizedTime = "NormalizedTime";
    public const string HasBuff = "HasBuff";
    public const string WeienW = "WeienW";
    public const string MoveDirection = "MoveDirection";
    public static readonly int SkillTag = Animator.StringToHash("skill");
    public static readonly int AttackTag = Animator.StringToHash("attack");
    public static readonly int RushTag = Animator.StringToHash("rush");
    public static readonly int FlyTag = Animator.StringToHash("fly");
    public static readonly int RushSkillTag = Animator.StringToHash("rush_skill");
    public static readonly int NormalTag = Animator.StringToHash("normal");
    public static readonly int AimTag = Animator.StringToHash("aim");
    public static readonly int CGEndTag = Animator.StringToHash("cg_end");
    public static readonly int TractionTag = Animator.StringToHash("traction");

    public const string RushSucceed = "RushSucceed";
    public const string Traction = "Traction";
    public const string TractionSucceed = "TractionSucceed";
    public const string LoopEnd = "LoopEnd";

    //events

    public const string ActionStart = "START";
    public const string ActionEnd = "END";
    public const string OnBorn = "BORN";

}