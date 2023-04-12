using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIShouJiTreasureItemComponent:Entity, IAwake<GameObject>
    {
        public GameObject TextNumber;
        public GameObject TextAttribute;
        public GameObject ButtonActive;
        public GameObject ImageActived;
        public GameObject UICommonItem;
        public GameObject GameObject;

        public int ShoujiId;
        public UIItemComponent UIItemComponent;
        public ShoujiComponent ShoujiComponent;
    }


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
            self.TextNumber = rc.Get<GameObject>("TextNumber");

            self.UIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            self.ButtonActive.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonActive().Coroutine(); });

            self.ShoujiComponent = self.ZoneScene().GetComponent<ShoujiComponent>();
        }
    }

    public static class UIShouJiTreasureItemComponentSystem
    {

        public static async ETTask OnButtonActive(this UIShouJiTreasureItemComponent self)
        {
            UI uI = await UIHelper.Create(self.ZoneScene(), UIType.UIShouJiSelect);
            uI.GetComponent<UIShouJiSelectComponent>().OnInitUI(self.ShoujiId);
        }

        public static void OnInitUI(this UIShouJiTreasureItemComponent self, int shouijId)
        {
            self.ShoujiId = shouijId;
            ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(shouijId);
            self.UIItemComponent.UpdateItem(new BagInfo() { ItemID = shouJiItemConfig.ItemID }, ItemOperateEnum.None);
            self.UIItemComponent.Label_ItemNum.SetActive(false);

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
                    attributeStr = attributeStr + $"{ItemViewHelp.GetAttributeName(numericType)} {svalue}% ";
                }
                else
                {
                    attributeStr = attributeStr +  $"提升{ItemViewHelp.GetAttributeName(numericType)}{int.Parse(attributeInfo[1])}点";
                }
                if (i < attributeInfoList.Length - 1)
                {
                    attributeStr += "\n";
                }
            }
            self.TextAttribute.GetComponent<Text>().text = attributeStr;

            KeyValuePairInt keyValuePairInt = self.ShoujiComponent.GetTreasureInfo(shouijId);
            int haveNumber = keyValuePairInt!=null ? (int)keyValuePairInt.Value : 0;
            self.TextNumber.GetComponent<Text>().text = $"激活:{haveNumber}/{shouJiItemConfig.AcitveNum}";

            bool actived = haveNumber >= shouJiItemConfig.AcitveNum;

            self.ButtonActive.SetActive(!actived);
            self.ImageActived.SetActive(actived);  
        }

    }
}
