using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanBagComponent : Entity, IAwake
    {
        public GameObject BuildingList;
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
    }

    [ObjectSystem]
    public class UIJiaYuanBagComponentAwake : AwakeSystem<UIJiaYuanBagComponent>
    {
        public override void Awake(UIJiaYuanBagComponent self)
        {
            ReferenceCollector rc  = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIJiaYuanBagComponentSystem
    {
        public static async ETTask OnInitUI(this UIJiaYuanBagComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
         
            for (int i = 0; i < GlobalValueConfigCategory.Instance.BagMaxCapacity; i++)
            {
                if (i % 10 == 30)
                {
                    await TimerComponent.Instance.WaitAsync(500);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList);

                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                uIItemComponent.SetClickHandler((BagInfo bInfo) => { self.OnClickHandler(bInfo); });
                uIItemComponent.UpdateItem(null, ItemOperateEnum.Bag);
                self.ItemUIlist.Add(uIItemComponent);
            }

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIJiaYuanBagComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(2);

            int number = 0;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType != 2)
                {
                    continue;
                }
                if (itemConfig.ItemSubType != 101)
                {
                    continue;
                }

                UIItemComponent uIItemComponent = self.ItemUIlist[number];
                BagInfo bagInfo = i < bagInfos.Count ? bagInfos[i] : null;
                uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.Bag);
            }
        }

        public static void OnClickHandler(this UIJiaYuanBagComponent self, BagInfo bagInfo)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].SetSelected(bagInfo);
            }
        }
    }
}
