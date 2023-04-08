using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{ 
    public class UIJiaYuanDaShiShowItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Item_0;
        public GameObject Item_1;
        public GameObject Item_2;
    }

    public class UIJiaYuanDaShiShowItemComponentA : AwakeSystem<UIJiaYuanDaShiShowItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanDaShiShowItemComponent self, GameObject a)
        {
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Item_0 = rc.Get<GameObject>("Item_0");
            self.Item_1 = rc.Get<GameObject>("Item_1");
            self.Item_2 = rc.Get<GameObject>("Item_2");
        }
    }

    public static class UIJiaYuanDaShiShowItemComponentSystem
    {

        public static void OnUpdateUI(this UIJiaYuanDaShiShowItemComponent self, KeyValuePair keyValuePair, long dashiTime)
        {
            string attriname = ItemViewHelp.GetAttributeName(keyValuePair.KeyId);

            string[] attrilist = keyValuePair.Value2.Split('@');
            string[] attriinfo_0 = attrilist[0].Split(';');
            string[] attriinfo_1 = attrilist[1].Split(';');
            string[] attriinfo_2 = attrilist[2].Split(';');

            self.Item_0.transform.Find("Text_Name").GetComponent<Text>().text = keyValuePair.Value;
            self.Item_1.transform.Find("Text_Name").GetComponent<Text>().text = keyValuePair.Value;
            self.Item_2.transform.Find("Text_Name").GetComponent<Text>().text = keyValuePair.Value;

            self.Item_0.transform.Find("Text_Attri").GetComponent<Text>().text = $"{attriname} +{attriinfo_0[0]}";
            self.Item_1.transform.Find("Text_Attri").GetComponent<Text>().text = $"{attriname} +{attriinfo_1[0]}";
            self.Item_2.transform.Find("Text_Attri").GetComponent<Text>().text = $"{attriname} +{attriinfo_2[0]}";

            self.Item_0.transform.Find("Text_Tip").GetComponent<Text>().text = $"品尝{attriinfo_0[1]}次开启";
            self.Item_1.transform.Find("Text_Tip").GetComponent<Text>().text = $"品尝{attriinfo_1[1]}次开启";
            self.Item_2.transform.Find("Text_Tip").GetComponent<Text>().text = $"品尝{attriinfo_2[1]}次开启";

            UICommonHelper.SetImageGray(self.Item_0.transform.Find("ImageIcon").gameObject, dashiTime < int.Parse(attriinfo_0[1]));
            UICommonHelper.SetImageGray(self.Item_1.transform.Find("ImageIcon").gameObject, dashiTime < int.Parse(attriinfo_1[1]));
            UICommonHelper.SetImageGray(self.Item_2.transform.Find("ImageIcon").gameObject, dashiTime < int.Parse(attriinfo_2[1]));
        }
    }
}
