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
        public GameObject SelectEffect;

        public Dictionary<int, GameObject> JianYuanPlanUIs = new Dictionary<int, GameObject>();
    }
}
