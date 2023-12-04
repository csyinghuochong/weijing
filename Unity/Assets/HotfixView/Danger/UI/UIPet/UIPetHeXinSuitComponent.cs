using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeXinSuitComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
        public GameObject UIPetHeXinSuitItemListNode;
        public GameObject UIPetHeXinSuitItem;
    }

    public class UIPetHeXinSuitComponentAwakeSystem: AwakeSystem<UIPetHeXinSuitComponent>
    {
        public override void Awake(UIPetHeXinSuitComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.UIPetHeXinSuitItemListNode = rc.Get<GameObject>("UIPetHeXinSuitItemListNode");
            self.UIPetHeXinSuitItem = rc.Get<GameObject>("UIPetHeXinSuitItem");

            self.UIPetHeXinSuitItem.SetActive(false);

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetHeXinSuit); });

            self.UpdateInfo();
        }
    }

    public static class UIPetHeXinSuitComponentSystem
    {
        public static void UpdateInfo(this UIPetHeXinSuitComponent self)
        {
            foreach (KeyValuePair<int, string> valuePair in ConfigHelper.PetSuitProperty)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIPetHeXinSuitItem);
                UIPetHeXinSuitItemComponent uiPetHeXinSuitItemComponent = self.AddChild<UIPetHeXinSuitItemComponent, GameObject>(go);
                uiPetHeXinSuitItemComponent.UpdateInfo(valuePair.Key);
                go.SetActive(true);
                UICommonHelper.SetParent(go, self.UIPetHeXinSuitItemListNode);
            }
        }
    }
}