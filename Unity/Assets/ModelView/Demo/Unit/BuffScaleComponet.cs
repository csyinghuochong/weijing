using UnityEngine;

namespace ET
{
    public class BuffScaleComponet : Entity, IAwake, IDestroy
    {

        public Transform Transform;

        public float ToScaleValue;

        public float InitScaleValue;

        public long ButtTime;

        public long PassTime;

        public long BeginTime;

        public long Timer;
    }
}