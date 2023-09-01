using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDemonMainComponent : Entity, IAwake, IDestroy
    {
    }


    public class UIDemonMainComponentAwake : AwakeSystem<UIDemonMainComponent>
    {
        public override void Awake(UIDemonMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

          
        }
    }

    public static class UIDemonMainComponentSystem
    {

        public static void ShowCancelButton(this UIDemonMainComponent self, bool show)
        { 
            
        }
    }
}