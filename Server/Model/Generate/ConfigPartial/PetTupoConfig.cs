using System.Collections.Generic;

namespace ET
{
    public partial class PetTupoConfigCategory
    {
        public Dictionary<int, List<PetTupoConfig>> PetTupoList = new Dictionary<int, List<PetTupoConfig>>();

        public override void AfterEndInit()
        {
            PetTupoList.Clear();
            foreach (PetTupoConfig config in this.GetAll().Values)
            {
                int position = config.Id / 100 - 201;
                if (!PetTupoList.ContainsKey(position))
                {
                    PetTupoList.Add(position, new List<PetTupoConfig>());
                }
                PetTupoList[position].Add(config);
            }

            foreach (List<PetTupoConfig> list in PetTupoList.Values)
            {
                list.Sort((a, b) => a.QiangHuaLv.CompareTo(b.QiangHuaLv));
            }
        }

        public int GetMaxId(int position)
        {
            return PetTupoList[position][PetTupoList[position].Count - 1].Id;
        }
    }
}
