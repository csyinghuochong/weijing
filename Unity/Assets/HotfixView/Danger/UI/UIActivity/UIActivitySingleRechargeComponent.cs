using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivitySingleRechargeComponent: Entity, IAwake, IDestroy
    {
        public GameObject Text_Tip;
        public GameObject UIActivitySingleRechargeItemListNode;
        public GameObject UIActivitySingleRechargeItem;
    }

    public class UIActivitySingleRechargeComponentAwake: AwakeSystem<UIActivitySingleRechargeComponent>
    {
        public override void Awake(UIActivitySingleRechargeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
            self.UIActivitySingleRechargeItemListNode = rc.Get<GameObject>("UIActivitySingleRechargeItemListNode");
            self.UIActivitySingleRechargeItem = rc.Get<GameObject>("UIActivitySingleRechargeItem");

            self.UIActivitySingleRechargeItem.SetActive(false);

          
            self.GetInfo();
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIActivitySingleRechargeComponentDestroySystem : DestroySystem<UIActivitySingleRechargeComponent>
    {
        public override void Destroy(UIActivitySingleRechargeComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIActivitySingleRechargeComponentSystem
    {
        public static void OnLanguageUpdate(this UIActivitySingleRechargeComponent self)
        {
            self.Text_Tip.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 32 : 26;
        }

        public static  void GetInfo(this UIActivitySingleRechargeComponent self)
        {
            self.InitInfo();
        }

        public static void InitInfo(this UIActivitySingleRechargeComponent self)
        {
            if (GlobalHelp.GetPlatform() == 7 || GameSettingLanguge.Language == 1)
            {
                foreach (int key in ConfigHelper.SingleRechargeReward_EN.Keys)
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UIActivitySingleRechargeItem);
                    UIActivitySingleRechargeItemComponent component = self.AddChild<UIActivitySingleRechargeItemComponent, GameObject>(go);
                    component.OnUpdateData(key);
                    UICommonHelper.SetParent(go, self.UIActivitySingleRechargeItemListNode);
                    go.SetActive(true);
                }
            }
            else
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
}