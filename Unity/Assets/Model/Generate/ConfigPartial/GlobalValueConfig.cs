using System;
using System.Collections.Generic;


namespace ET
{
    public partial class GlobalValueConfigCategory
    {
        public int BagInitCapacity = 0;
        //public int BagMaxCapacity = 0;

        public int HourseInitCapacity = 0;
        public int HourseMaxCapacity = 0;

        public int AccountBagMax = 0;
        public int GemStoreInitCapacity = 0;
        public int GemStoreMaxCapacity = 0;

        public Dictionary<int, int> ZhuaPuItem = new Dictionary<int, int>();

        public override void AfterEndInit()
        {
            BagInitCapacity = this.Get(3).Value2;
            //BagMaxCapacity = this.Get(84).Value2 + BagInitCapacity + 10;
            HourseInitCapacity = this.Get(4).Value2;
            HourseMaxCapacity = this.Get(85).Value2 + HourseInitCapacity + 10;
            AccountBagMax = this.Get(115).Value2;
            GemStoreInitCapacity = this.Get(118).Value2; 
            GemStoreMaxCapacity = this.Get(118).Value2; 

            string[] zhuabuItems = this.Get(82).Value.Split('@');
            for (int i = 0; i < zhuabuItems.Length; i++)
            {
                string[] zhubuids = zhuabuItems[i].Split(';');
                ZhuaPuItem.Add(int.Parse(zhubuids[0]), int.Parse(zhubuids[1]));
            }
        }
    }
}
