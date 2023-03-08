using System;
using System.Collections.Generic;


namespace ET
{
    public partial class GlobalValueConfigCategory
    {
        public int BagMaxCapacity = 0;

        public override void AfterEndInit()
        {
            BagMaxCapacity = this.Get(3).Value2;
        }
    }
}
