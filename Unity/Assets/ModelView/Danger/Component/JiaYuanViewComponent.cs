using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public class JiaYuanViewComponent : Entity, IAwake, IDestroy
    {

        public long Timer;

        public GameObject SelectEffect;

        public Dictionary<int, JiaYuanPlanUIComponent> JianYuanPlanUIs = new Dictionary<int, JiaYuanPlanUIComponent>();
    }
}
