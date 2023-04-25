using System.Collections.Generic;

namespace ET
{
    public partial class FuntionConfigCategory
    {
     
        public override void AfterEndInit()
        {
            foreach (FuntionConfig functionConfig in this.GetAll().Values)
            {
                if (string.IsNullOrEmpty(functionConfig.OpenTime)
                    || functionConfig.OpenTime == "0")
                {
                    continue;
                }
                List<int> openTime = new List<int>();
                string[] openTimes = functionConfig.OpenTime.Split('@');

                for (int i = 0; i < openTimes.Length; i+=2)
                {
                   
                }
            }
        }
    }
}
