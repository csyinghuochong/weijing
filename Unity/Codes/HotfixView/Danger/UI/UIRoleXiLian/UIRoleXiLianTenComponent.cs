using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRoleXiLianTenComponent : Entity, IAwake
    {
        public GameObject ImageButtonClose;
        public GameObject UIRoleXiLianTenItem;
        public GameObject ItemListNode;
    }

    [ObjectSystem]
    public class UIRoleXiLianTenComponentAwakeSystem : AwakeSystem<UIRoleXiLianTenComponent>
    {
        public override void Awake(UIRoleXiLianTenComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButtonClose = rc.Get<GameObject>("ImageButtonClose");
            self.ImageButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIRoleXiLianTen );  });

            self.UIRoleXiLianTenItem = rc.Get<GameObject>("UIRoleXiLianTenItem");
            self.UIRoleXiLianTenItem.SetActive(false);
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
        }
    }

    public static class UIRoleXiLianTenComponentSystem
    {
        public static void OnInitUI(this UIRoleXiLianTenComponent self, BagInfo bagInfo, List<ItemXiLianResult> itemXiLians)
        {
            for (int i = 0; i < itemXiLians.Count; i++)
            {
                BagInfo bagInfoTemp = ComHelp.DeepCopy(bagInfo);
                bagInfoTemp.XiLianHideTeShuProLists = itemXiLians[i].XiLianHideTeShuProLists;
                bagInfoTemp.XiLianHideProLists = itemXiLians[i].XiLianHideProLists;
                bagInfoTemp.HideSkillLists = itemXiLians[i].HideSkillLists;

                GameObject itemGo = GameObject.Instantiate(self.UIRoleXiLianTenItem);
                UICommonHelper.SetParent(itemGo, self.ItemListNode);
                itemGo.SetActive(true);
                self.AddChild<UIRoleXiLianTenItemComponent, GameObject>(itemGo).OnInitUI(bagInfoTemp, itemXiLians[i]);
            }
        }
    }
}
