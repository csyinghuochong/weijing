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


        /// <summary>
        /// 根据消耗的道具列表获取可以制作的id
        /// </summary>
        /// <param name="itemIdList"></param>
        /// <returns></returns>
        public int GetCanMakeId(List<int> itemIdList)
        {
            List<int> canMakeid = new List<int>();

            foreach (EquipMakeConfig equipMakeConfig in this.GetAll().Values)
            {
                if (equipMakeConfig.ProficiencyType == 8)
                {
                    string[] needitems = equipMakeConfig.NeedItems.Split('@');

                    //赋值
                    List<int> itemIdListNew = new List<int>();
                    for (int i = 0; i < itemIdList.Count; i++) {
                        itemIdListNew.Add(itemIdList[i]);
                    }
                    int needNum = 0;

                    for (int i = 0; i < needitems.Length; i++)
                    {

                        int itemid = int.Parse(needitems[i].Split(';')[0]);
                        if (itemIdListNew.Contains(itemid))
                        {
                            itemIdListNew.Remove(itemid);
                            needNum += 1;
                        }
                        else {
                            continue;
                        }
                    }

                    if (needNum == needitems.Length)
                    {
                        canMakeid.Add(equipMakeConfig.Id);
                    }
                }
            }
            if (canMakeid.Count == 0)
            {
                return 0;
            }
            return canMakeid[RandomHelper.RandomNumber(0, canMakeid.Count)];
        }
    }
}
