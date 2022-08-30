using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBuChangComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject RoleListNode;
        public GameObject RoleItem;
    }

    [ObjectSystem]
    public class UIBuChangComponentAwakeSystem : AwakeSystem<UIBuChangComponent>
    {
        public override void Awake(UIBuChangComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIBuChang ).Coroutine(); });

            self.RoleListNode = rc.Get<GameObject>("RoleListNode");
            self.RoleItem = rc.Get<GameObject>("RoleItem");
        }
    }

    public static class UIBuChangComponentSystem
    {

        public static void OnInitUI(this UIBuChangComponent self)
        { 
            


        }

    }
}
