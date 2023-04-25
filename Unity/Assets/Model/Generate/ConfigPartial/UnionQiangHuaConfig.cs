using System.Collections.Generic;

namespace ET
{
    public partial class UnionQiangHuaConfigCategory
    {
        public Dictionary<int, List<UnionQiangHuaConfig>> UnionQiangHuaList = new Dictionary<int, List<UnionQiangHuaConfig>>();

        public override void AfterEndInit()
        {
            int position = 0;

            foreach (UnionQiangHuaConfig shoujiConfig in this.GetAll().Values)
            {
                if (!UnionQiangHuaList.ContainsKey(position))
                {
                    UnionQiangHuaList.Add( position, new List<UnionQiangHuaConfig>() );
                }
                UnionQiangHuaList[position].Add(shoujiConfig);
                if (shoujiConfig.NextID == 0)
                {
                    position++;
                }
            }
        }
    }
}
