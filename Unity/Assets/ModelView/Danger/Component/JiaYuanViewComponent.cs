using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class JiaYuanViewComponent : Entity, IAwake, IDestroy
    {
        public List<JianYuanPlanUIComponent> jianYuanPlanUIs = new List<JianYuanPlanUIComponent>();
    }
}
