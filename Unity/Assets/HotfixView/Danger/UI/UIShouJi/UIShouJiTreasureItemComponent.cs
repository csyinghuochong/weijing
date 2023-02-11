using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIShouJiTreasureItemComponent:Entity, IAwake<GameObject>
    {
        public GameObject TextAttribute;
        public GameObject ButtonActive;
        public GameObject ImageActived;
        public GameObject UICommonItem;
        public GameObject GameObject;

        public int ShoujiId;
        public UIItemComponent UIItemComponent;
    }

    [ObjectSystem]
    public class UIShouJiTreasureItemComponentAwake : AwakeSystem<UIShouJiTreasureItemComponent, GameObject>
    {
        public override  void Awake(UIShouJiTreasureItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextAttribute = rc.Get<GameObject>("TextAttribute");
            self.ButtonActive = rc.Get<GameObject>("ButtonActive");
            self.ImageActived = rc.Get<GameObject>("ImageActived");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");

            self.UIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            self.ButtonActive.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonActive().Coroutine(); });
        }
    }

    public static class UIShouJiTreasureItemComponentSystem
    {

        public static async ETTask OnButtonActive(this UIShouJiTreasureItemComponent self)
        {
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UITreasureSelect);
            uI.GetComponent<UITreasureSelectComponent>().OnInitUI(self.ShoujiId);
        }

        public static void OnInitUI(this UIShouJiTreasureItemComponent self, int shouijId)
        {
            self.ShoujiId = shouijId;
            ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(shouijId);
            self.UIItemComponent.UpdateItem(new BagInfo() { ItemID = shouJiItemConfig.ItemID });

            string attributeStr = string.Empty;

            string[] attributeInfoList = shouJiItemConfig.AddPropreListStr.Split('@');
            for (int i = 0; i < attributeInfoList.Length; i++)
            { 
                string[] attributeInfo = attributeInfoList[i].Split(',');
                int numericType = int.Parse(attributeInfo[0]);

                if (NumericHelp.GetNumericValueType(numericType) == 2)
                {
                    float fvalue = float.Parse(attributeInfo[1]);
                    string svalue = fvalue.ToString("0.#####");
                    attributeStr = attributeStr + $"{UIItemHelp.GetAttributeName(numericType)} {svalue}% ";
                }
                else
                {
                    attributeStr = attributeStr +  $"{UIItemHelp.GetAttributeName(numericType)} {int.Parse(attributeInfo[1])}";
                }
                if (i < attributeInfoList.Length - 1)
                {
                    attributeStr += "\n";
                }
            }
            self.TextAttribute.GetComponent<Text>().text = attributeStr;
        }


    }
}
