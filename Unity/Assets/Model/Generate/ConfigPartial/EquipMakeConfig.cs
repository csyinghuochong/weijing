using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class EquipMakeConfigCategory
    {
       
        public override void AfterEndInit()
        {

            foreach (EquipMakeConfig functionConfig in this.GetAll().Values)
            {
                
            }
        }

        public int GetMakeId(int itemid)
        {
            foreach (EquipMakeConfig functionConfig in this.GetAll().Values)
            {
                if (functionConfig.MakeItemID == itemid)
                {
                    return functionConfig.Id;
                }
            }
            return 0;
        }
    }
}
