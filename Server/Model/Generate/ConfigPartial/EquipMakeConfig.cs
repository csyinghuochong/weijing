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
            itemIdList.Sort();
            List<int> canMakeid = new List<int>();

            foreach (EquipMakeConfig equipMakeConfig in this.GetAll().Values)
            {
                if (equipMakeConfig.ProficiencyType != 8)
                {
                    continue;
                }

                List<int> needIdlist = new List<int>();
                string[] needitems = equipMakeConfig.NeedItems.Split('@');

                for (int i = 0; i < needitems.Length; i++)
                {
                    string[] iteminfo = needitems[i].Split(';');
                    if (iteminfo.Length != 2)
                    {
                        continue;
                    }

                    int itemid = int.Parse(iteminfo[0]);
                    needIdlist.Add(itemid);
                }
                needIdlist.Sort();

                bool isRight = needIdlist.All(p => itemIdList.Any(r => r.Equals(p))) && needIdlist.Count == itemIdList.Count;
                if (isRight)
                {
                    canMakeid.Add(equipMakeConfig.Id);
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
