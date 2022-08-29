using System.Collections.Generic;


namespace ET
{
    public partial class GlobalValueConfigCategory
    {
        public int JianDingFuQulity = 0;

        public override void AfterEndInit()
        {
            JianDingFuQulity = this.Get(44).Value2;
        }
    }
}
