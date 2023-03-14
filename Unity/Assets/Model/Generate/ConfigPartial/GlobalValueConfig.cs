using System;
using System.Collections.Generic;


namespace ET
{
    public partial class GlobalValueConfigCategory
    {
        public int BagMaxCapacity = 0;
        public Dictionary<int, int> ZhuaPuItem = new Dictionary<int, int>();

        public override void AfterEndInit()
        {
            BagMaxCapacity = this.Get(3).Value2;

            string[] zhuabuItems = this.Get(82).Value.Split('@');
            for (int i = 0; i < zhuabuItems.Length; i++)
            {
                string[] zhubuids = zhuabuItems[i].Split(';');
                ZhuaPuItem.Add(int.Parse(zhubuids[0]), int.Parse(zhubuids[1]));
            }
        }
    }
}
