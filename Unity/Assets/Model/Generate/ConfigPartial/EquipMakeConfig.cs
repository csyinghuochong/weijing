using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class EquipMakeConfigCategory
    {
        public Dictionary<int, int> ItemMakeList = new Dictionary<int, int>();

        public override void AfterEndInit()
        {
            Log.Debug($" {this.GetAll().Values.Count }");

            foreach (EquipMakeConfig functionConfig in this.GetAll().Values)
            {
                ItemMakeList.Add(functionConfig.MakeItemID, functionConfig.Id);

                Log.Debug($"{functionConfig.MakeItemID}   {ItemMakeList.Count }");
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
