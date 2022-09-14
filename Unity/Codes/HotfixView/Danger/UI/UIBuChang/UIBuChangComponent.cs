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
            self.RoleItem.SetActive(false);

            self.OnInitUI();
        }
    }

    public static class UIBuChangComponentSystem
    {

        public static void OnInitUI(this UIBuChangComponent self)
        {
            AccountInfoComponent accountInfo = self.ZoneScene().GetComponent<AccountInfoComponent>();
            for (int i = 0; i < accountInfo.PlayerInfo.DeleteUserList.Count; i++)
            {
                GameObject goitem = GameObject.Instantiate(self.RoleItem);
                goitem.SetActive(true);
                UICommonHelper.SetParent(goitem, self.RoleListNode );
                self.AddChild<UIBuChangItemComponent, GameObject>(goitem).OnInitUI(accountInfo.PlayerInfo.DeleteUserList[i]);
            }
        }

    }
}
