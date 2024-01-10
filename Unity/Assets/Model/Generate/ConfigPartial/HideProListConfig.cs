using System.Collections.Generic;

namespace ET

{
    public partial class HideProListConfigCategory
    {

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, int> PetSkillToHideProId = new Dictionary<int, int>();


        public override void AfterEndInit()
        {
            int petinitSkill = HideProHelper.PetIntSkillId;
            while (petinitSkill != 0)
            {
                HideProListConfig hideProListConfig = HideProListConfigCategory.Instance.Get(petinitSkill);
                PetSkillToHideProId.Add(hideProListConfig.PropertyType, hideProListConfig.Id);
                petinitSkill = hideProListConfig.NtxtID;
            }
        }
    }
}
