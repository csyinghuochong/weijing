using UnityEngine;

namespace ET
{
    public class FloatTipComponent : Entity, IAwake,IDestroy
    {
        public FloatTipType FloatTipType;
        public GameObject GameObject;
        public GameObject tipText;
        public GameObject tipNode;
        public string AssetEffect;
        public float passTime;
    }
}
