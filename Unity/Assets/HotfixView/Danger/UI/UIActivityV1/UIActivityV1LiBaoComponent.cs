using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1LiBaoComponent: Entity, IAwake
    {
        public GameObject UIActivityV1LiBaoItemListNode;
        public GameObject UIActivityV1LiBaoItem;
    }

    public class UIActivityV1LiBaoComponentAwake: AwakeSystem<UIActivityV1LiBaoComponent>
    {
        public override void Awake(UIActivityV1LiBaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIActivityV1LiBaoItemListNode = rc.Get<GameObject>("UIActivityV1LiBaoItemListNode");
            self.UIActivityV1LiBaoItem = rc.Get<GameObject>("UIActivityV1LiBaoItem");

            self.UIActivityV1LiBaoItem.SetActive(false);

            self.UpdateInfo();
        }
    }

    public static class UIActivityV1LiBaoComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1LiBaoComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;

            foreach (int i in activityV1Info.LiBaoAllIds)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1LiBaoItem);
                UIActivityV1LiBaoItemComponent component = self.AddChild<UIActivityV1LiBaoItemComponent, GameObject>(go);
                component.OnUpdateData(i);
                UICommonHelper.SetParent(go, self.UIActivityV1LiBaoItemListNode);
                go.SetActive(true);
            }
        }
    }
}