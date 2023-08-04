using System.Collections.Generic;

namespace ET
{
    public partial class FashionConfigCategory
    {

        public Dictionary<int, Dictionary<int, List<int>>> OccFashionList = new Dictionary<int, Dictionary<int, List<int>>>();

        public override void AfterEndInit()
        {
            foreach (FashionConfig fashionConfig in this.GetAll().Values)
            {

                if (!OccFashionList.ContainsKey(fashionConfig.Occ))
                {
                    OccFashionList.Add( fashionConfig.Occ, new Dictionary<int, List<int>>() { }  );
                }

                if (!OccFashionList[fashionConfig.Occ].ContainsKey(fashionConfig.SubType))
                {
                    OccFashionList[fashionConfig.Occ].Add(fashionConfig.SubType, new List<int>());
                }

                OccFashionList[fashionConfig.Occ][fashionConfig.SubType].Add(  fashionConfig.Id );
            }
        }

        public List<int> GetOccFashionList(int occ, int subType)
        {
            if (!OccFashionList.ContainsKey(occ))
            {
                return null;
            }

            if (!OccFashionList[occ].ContainsKey(subType))
            {
                return null;
            }

            return OccFashionList[occ][subType];
        }
    }
}