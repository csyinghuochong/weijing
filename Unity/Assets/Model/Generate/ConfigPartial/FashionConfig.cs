using System.Collections.Generic;

namespace ET
{
    public partial class FashionConfigCategory
    {

        public List<int> EmptyList = new List<int>();   

        public Dictionary<int, Dictionary<int, List<int>>> OccFashionList = new Dictionary<int, Dictionary<int, List<int>>>();

        public override void AfterEndInit()
        {
            foreach (FashionConfig fashionConfig in this.GetAll().Values)
            {
                if (fashionConfig.Occ == null)
                {
                    continue;
                }

                for (int i = 0; i < fashionConfig.Occ.Length; i++)
                {
                    int occ = fashionConfig.Occ[i];


                    if (!OccFashionList.ContainsKey(occ))
                    {
                        OccFashionList.Add(occ, new Dictionary<int, List<int>>() { });
                    }

                    if (!OccFashionList[occ].ContainsKey(fashionConfig.SubType))
                    {
                        OccFashionList[occ].Add(fashionConfig.SubType, new List<int>());
                    }

                    OccFashionList[occ][fashionConfig.SubType].Add(fashionConfig.Id);
                }
            }
        }

        public List<int> GetOccFashionList(int occ, int subType)
        {
            if (!OccFashionList.ContainsKey(occ))
            {
                return this.EmptyList;
            }

            if (!OccFashionList[occ].ContainsKey(subType))
            {
                return this.EmptyList;
            }

            return OccFashionList[occ][subType];
        }
    }
}