using System.Collections.Generic;
namespace ET
{
    public partial class FuntionConfigCategory
    {

        public override void AfterEndInit()
        {
            foreach (FuntionConfig activityConfig in this.GetAll().Values)
            {
               
            }
        }
    }
}
