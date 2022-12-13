using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIMiJingMainComponent : Entity, IAwake, IDestroy
    {

        public List<UIMainTeamItemComponent> TeamUIList = new List<UIMainTeamItemComponent>();
    }

    [ObjectSystem]
    public class UIMiJingMainComponentAwakeSystem : AwakeSystem<UIMiJingMainComponent>
    {
        public override void Awake(UIMiJingMainComponent self)
        {
            self.TeamUIList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject DamageListNode = rc.Get<GameObject>("DamageListNode");
            for (int i = 0; i < DamageListNode.transform.childCount; i++)
            { 
                GameObject gameObject = DamageListNode.transform.GetChild(i).gameObject;
                self.TeamUIList.Add( self.AddChild<UIMainTeamItemComponent, GameObject>(gameObject) );
                self.TeamUIList[i].GameObject.SetActive(false);
            }
        }
    }

    public static class UIMiJingMainComponentSystem
    {
        public static void OnUpdateDamage(this UIMiJingMainComponent self, M2C_SyncMiJingDamage message)
        { 
            
        }
    }
}
