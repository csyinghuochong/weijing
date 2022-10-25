using System;
using UnityEngine;

namespace ET
{

    public class UIBattleMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextVS_1;
        public GameObject TextVS_2;
    }

    [ObjectSystem]
    public class UIBattleMainComponentAwakeSystem : AwakeSystem<UIBattleMainComponent>
    {
        public override void Awake(UIBattleMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextVS_1 = rc.Get<GameObject>("TextVS_1");
            self.TextVS_2 = rc.Get<GameObject>("TextVS_2");
        }
    }

    public static class UIBattleMainComponentSystem
    {
        public static void OnUpdateUI(this UIBattleMainComponent self)
        { 
            
        }
    }
}