using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class DungeonSectionConfigCategory
    {

        /// <summary>
        /// 神秘副本
        /// </summary>
        public List<int> MysteryDungeonList = new List<int>() {  };

        /// <summary>
        /// 神秘副本权重
        /// </summary>
        public Dictionary<int, List<int>> MysteryWeights = new Dictionary<int, List<int>>();
        public Dictionary<int, List<int>> MysteryDungeon = new Dictionary<int, List<int>>();

        public Dictionary<int, int> DungeonToChapter = new Dictionary<int, int>();

        public override void AfterEndInit()
        {

            foreach (DungeonSectionConfig functionConfig in this.GetAll().Values)
            {
                for (int i = 0; i < functionConfig.RandomArea.Length; i++)
                {
                    DungeonToChapter.Add(functionConfig.RandomArea[i], functionConfig.Id);
                }


                MysteryWeights.Add(functionConfig.Id, new List<int>());
                MysteryDungeon.Add(functionConfig.Id, new List<int>());
                string[] shenminds = functionConfig.ShenMiEnterID.Split('@');
                for (int i = 0; i < shenminds.Length; i++)
                {
                    string[] shenminfuben = shenminds[i].Split(';');
                    MysteryWeights[functionConfig.Id].Add(int.Parse(shenminfuben[0]) );
                    MysteryDungeon[functionConfig.Id].Add(int.Parse(shenminfuben[1]));

                    MysteryDungeonList.Add(int.Parse(shenminfuben[1]));
                }
            }
        }

        public int GetMysteryDungeon(int chapterId)
        {
            List<int> weights = MysteryWeights[chapterId];
            int index = RandomHelper.RandomByWeight(weights);

            return MysteryDungeon[chapterId][index];
        }
    }
}
