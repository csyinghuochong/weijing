using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public partial class ActivityConfigCategory
    {
        public Dictionary<string, int> PulicSerialList = new Dictionary<string, int>();

        public override void AfterEndInit()
        {
            foreach (ActivityConfig functionConfig in this.GetAll().Values)
            {
                if (functionConfig.ActivityType == 34)
                {
                    PulicSerialList.Add(functionConfig.Par_2, functionConfig.Id);
                }
            }
        }

        public int GetPulicSerial(string serial)
        { 
            int activityid = 0;
            PulicSerialList.TryGetValue(serial, out activityid);
            return activityid;
        }

    }
}
