using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AI_NPC : MonoBehaviour {

    public string NpcID;
    private Vector2 vec3_NpcName;
    public GameObject NpcNamePosition;
    private GameObject Obj_NpcName;
    private bool npcNameUpdateStatus;
    public GameObject SelectEffect;             //玩家选中这个NPC播放特效
    public GameObject SelectEffectPosition;     //玩家选中特效播放的点
    public bool IfSeclectNpc;                   //玩家是否选中这个Npc
    public bool IfSeclectNpcEffect;             //玩家选中这个Npc实例化的特效，保证只执行一次
    private GameObject selectEffect;            //实例化的选中特效
    public ArrayList CompleteTaskID;            //完成任务的ID
    public bool CompleteTaskStatus;             //完成任务只执行一次
    public bool waritUpdataTask;               //待更新状态
    private float taskUpdataTime;               //30码内每隔几秒自动是否有任务完成,修复30码内，杀怪任务或其他任务完成后不更新（不得已的办法）
    private float taskUpdataTimeSum;
    private bool npcHeadSpeakStatus;            //NPC头上说话状态

    private string[] npcStoryValue;             //NPC身上绑定的故事ID
}
