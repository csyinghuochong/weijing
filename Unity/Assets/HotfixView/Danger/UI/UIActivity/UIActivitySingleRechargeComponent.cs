using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivitySingleRechargeComponent: Entity, IAwake
    {
        public GameObject UIActivitySingleRechargeItemListNode;
        public GameObject UIActivitySingleRechargeItem;
    }

    public class UIActivitySingleRechargeComponentAwake: AwakeSystem<UIActivitySingleRechargeComponent>
    {
        public override void Awake(UIActivitySingleRechargeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIActivitySingleRechargeItemListNode = rc.Get<GameObject>("UIActivitySingleRechargeItemListNode");
            self.UIActivitySingleRechargeItem = rc.Get<GameObject>("UIActivitySingleRechargeItem");

            self.UIActivitySingleRechargeItem.SetActive(false);

          
            self.GetInfo();
        }
    }

    public static class UIActivitySingleRechargeComponentSystem
    {

        public static  void GetInfo(this UIActivitySingleRechargeComponent self)
        {
            self.InitInfo();
        }

        public static void InitInfo(this UIActivitySingleRechargeComponent self)
        {
            foreach (int key in ConfigHelper.SingleRechargeReward.Keys)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivitySingleRechargeItem);
                UIActivitySingleRechargeItemComponent component = self.AddChild<UIActivitySingleRechargeItemComponent, GameObject>(go);
                component.OnUpdateData(key);
                UICommonHelper.SetParent(go, self.UIActivitySingleRechargeItemListNode);
                go.SetActive(true);
            }
        }
    }
}