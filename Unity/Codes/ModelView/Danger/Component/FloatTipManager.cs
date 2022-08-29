using System.Collections.Generic;

namespace ET
{
    public class FloatTipType
    {
        public int type; //0 没底  1有底
        public string tip;
    }

    public class FloatTipManager : Entity, IAwake, IDestroy
    {
        public static FloatTipManager Instance;
        public List<UI> floatTipList;
        public List<FloatTipType> WaitFloatTip;
        public float IntervalTime = 0.5f;
        public float PassTime = 0.5f;
        public long Timer;
    }
}
