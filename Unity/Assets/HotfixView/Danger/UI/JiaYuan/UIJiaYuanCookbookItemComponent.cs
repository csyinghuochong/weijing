using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UIJiaYuanCookbookItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject MakeItem;
        public GameObject MakeItemList;
        public GameObject GameObject;
        public UIItemComponent UICommonItem;

        public List<UIItemComponent> NeedItemList = new List<UIItemComponent>();
    }

    public class UIJiaYuanCookbookItemComponentAwake : AwakeSystem<UIJiaYuanCookbookItemComponent,GameObject>
    {
        public override void Awake(UIJiaYuanCookbookItemComponent self, GameObject gameObject)
        {
            self.NeedItemList.Clear();
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.MakeItem = rc.Get<GameObject>("MakeItem");
            self.MakeItem.SetActive(false);
            self.MakeItemList = rc.Get<GameObject>("MakeItemList");

            GameObject uICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent,GameObject>(uICommonItem);
        }
    }

    public static class UIJiaYuanCookbookItemComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanCookbookItemComponent self, int itmeid, bool active)
        {
            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = itmeid, ItemNum = 1 }, ItemOperateEnum.None);

            int makeid = EquipMakeConfigCategory.Instance.GetMakeId(itmeid);
            if (makeid == 0)
            {
                Log.Debug($"itmeid {itmeid}");
            }
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeid);
            string[] iteminfos = equipMakeConfig.NeedItems.Split('@');

            for (int i = 0; i < iteminfos.Length; i++)
            {
                UIItemComponent uIItemComponent = null;
                int needitmeid = int.Parse(iteminfos[i].Split(';')[0]);
                if (i < self.NeedItemList.Count)
                {
                    uIItemComponent = self.NeedItemList[i];
                    uIItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.MakeItem);
                    UICommonHelper.SetParent(go, self.MakeItemList);
                    go.SetActive(true);
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                    self.NeedItemList.Add(uIItemComponent);
                }
                BagInfo bagInfo = active ? new BagInfo() {ItemID = needitmeid } : null;    
                uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.None);
                uIItemComponent.Image_ItemIcon.SetActive(true);
            }
        }
    }
}
