using System.Collections.Generic;

namespace ET
{
    public struct FloatTipType
    {
        public int type; //0 没底  1有底
        public string tip;
    }

    public class FloatTipManager : Entity, IAwake, IDestroy
    {
        public static FloatTipManager Instance;
        public List<FloatTipComponent> FloatTipList = new List<FloatTipComponent>();
        public List<FloatTipType> WaitFloatTip = new List<FloatTipType>();
        public float IntervalTime = 0.5f;
        public float PassTime = 0.5f;
        public long Timer;
    }
}
