using UnityEngine;

namespace ET
{
    public class FloatTipComponent : Entity, IAwake<string>
    {
        public const int moveSpeed = 120;
        public GameObject tipText;
        public GameObject tipNode;
        public float passTime;
    }
}
