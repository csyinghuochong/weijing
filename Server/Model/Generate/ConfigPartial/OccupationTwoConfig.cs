using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class OccupationTwoConfigCategory
    {

        public override void AfterEndInit()
        {

            // 得到所有技能的基础技能
            foreach (OccupationTwoConfig occtwoConfig in this.GetAll().Values)
            {
                
            }
        }

    }
}
