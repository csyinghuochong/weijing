using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIRoleXiLianTransferComponent : Entity, IAwake
    {
        public GameObject ButtonTransfer;
        public GameObject UICommonCostItem;
        public GameObject UICommonItem_2;
        public GameObject UICommonItem_1;
        public GameObject ItemListNode;

        public UIItemComponent UIItem_1;
        public UIItemComponent UIItem_2;
        public UICommonCostItemComponent UICommonCostItem_1;
    }

    [ObjectSystem]
    public class UIRoleXiLianTransferComponentAwakeSystem : AwakeSystem<UIRoleXiLianTransferComponent>
    {
        public override void Awake(UIRoleXiLianTransferComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonTransfer = rc.Get<GameObject>("ButtonTransfer");
            self.UICommonCostItem = rc.Get<GameObject>("UICommonCostItem");
            self.UICommonItem_2 = rc.Get<GameObject>("UICommonItem_2");
            self.UICommonItem_1 = rc.Get<GameObject>("UICommonItem_1");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
        }
    }
}