using System.Collections.Generic;

namespace ET
{
    public partial class FuntionConfigCategory
    {
        public Dictionary<int, List<int>> OpenTimeList = new Dictionary<int, List<int>>();  

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
                    int openTime_1 = int.Parse(openTimes[i].Split(';')[0]);
                    int openTime_2 = int.Parse(openTimes[i].Split(';')[1]);
                    int closeTime_1 = int.Parse(openTimes[i+1].Split(';')[0]);
                    int closeTime_2 = int.Parse(openTimes[i+1].Split(';')[1]);
                    openTime.Add(openTime_1);
                    openTime.Add(openTime_2);
                    openTime.Add(closeTime_1);
                    openTime.Add(closeTime_2);
                    OpenTimeList.Add(functionConfig.Id, openTime);
                }
            }
        }
    }
}
