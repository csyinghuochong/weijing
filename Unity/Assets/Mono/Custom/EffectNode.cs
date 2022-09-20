using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public enum eUpdateMode
{
    NONE,
    BOTH,
    POSITION,
    ROTATION,
    LINK
}
public enum eNodeType
{
    StartNode,
    MainNode,
    EndNode,
    SpecialNode,
    Yujing
}
namespace Assets.Scripts.Com.Game.Mono
{
    public class EffectNode : MonoBehaviour
    {
        public eUpdateMode updateMode;
        public eNodeType node;
       
        public bool activateByAnimationEvent = true;
        public float activateTime;
        public float duration = 5;

        public bool isBullet = false;
        public float flyHeight;
        public float flySpeed;
        public int flyMode;
    }
}