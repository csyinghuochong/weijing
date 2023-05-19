using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class EquipMakeConfigCategory
    {

        /// <summary>
        //   一级id - > 二级id
        /// </summary>
        public Dictionary<int, KeyValuePairInt> GetHeChengList = new Dictionary<int, KeyValuePairInt>();


        public override void AfterEndInit()
        {

            foreach (EquipMakeConfig firstWinConfig in this.GetAll().Values)
            {
                if (string.IsNullOrEmpty(firstWinConfig.NeedItems))
                {
                    continue;
                }

                string[] itemlist = firstWinConfig.NeedItems.Split('@');
                if (itemlist.Length != 1)
                {
                    continue;
                }

                string[] iteminfo = itemlist[0].Split(';');
                int itemid = int.Parse(iteminfo[0]);
                int itemnum = int.Parse(iteminfo[1]);
                if (!GetHeChengList.ContainsKey(itemid))
                {
                    KeyValuePairInt keyValuePair = new KeyValuePairInt() { KeyId = firstWinConfig.Id, Value = itemnum };
                    GetHeChengList.Add(itemid, keyValuePair);
                }
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
