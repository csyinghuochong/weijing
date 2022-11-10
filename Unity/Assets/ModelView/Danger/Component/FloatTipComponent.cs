using UnityEngine;

namespace ET
{
    public class FloatTipComponent : Entity, IAwake<GameObject, string>
    {
        public const int moveSpeed = 120;
        public GameObject GameObject;
        public GameObject tipText;
        public GameObject tipNode;
        public float passTime;
    }
}
