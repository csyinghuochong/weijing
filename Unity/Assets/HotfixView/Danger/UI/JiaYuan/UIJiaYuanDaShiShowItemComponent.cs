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

        public static void OnUpdateUI(this UIJiaYuanDaShiShowItemComponent self, int index, long dashiTime)
        {
            KeyValuePair keyValuePair_0 = ConfigHelper.JiaYuanDaShiPro[index * 3 + 0];
            KeyValuePair keyValuePair_1 = ConfigHelper.JiaYuanDaShiPro[index * 3 + 1];
            KeyValuePair keyValuePair_2 = ConfigHelper.JiaYuanDaShiPro[index * 3 + 2];

        
            int need_time_0 = int.Parse(keyValuePair_0.Value2.Split('@')[0]);
            int need_time_1 = int.Parse(keyValuePair_1.Value2.Split('@')[0]);
            int need_time_2 = int.Parse(keyValuePair_2.Value2.Split('@')[0]);
            string[] attriinfo_0 = keyValuePair_0.Value2.Split('@')[1].Split(',');
            string[] attriinfo_1 = keyValuePair_1.Value2.Split('@')[1].Split(',');
            string[] attriinfo_2 = keyValuePair_2.Value2.Split('@')[1].Split(',');

            string attriname_0 = ItemViewHelp.GetAttributeName(int.Parse(attriinfo_0[0]));
            string attriname_1 = ItemViewHelp.GetAttributeName(int.Parse(attriinfo_1[0]));
            string attriname_2 = ItemViewHelp.GetAttributeName(int.Parse(attriinfo_2[0]));

            self.Item_0.transform.Find("Text_Name").GetComponent<Text>().text = keyValuePair_0.Value;
            self.Item_1.transform.Find("Text_Name").GetComponent<Text>().text = keyValuePair_1.Value;
            self.Item_2.transform.Find("Text_Name").GetComponent<Text>().text = keyValuePair_2.Value;

            self.Item_0.transform.Find("Text_Attri").GetComponent<Text>().text = $"{attriname_0} +{attriinfo_0[1]}";
            self.Item_1.transform.Find("Text_Attri").GetComponent<Text>().text = $"{attriname_1} +{attriinfo_1[1]}";
            self.Item_2.transform.Find("Text_Attri").GetComponent<Text>().text = $"{attriname_2} +{attriinfo_2[1]}";

            self.Item_0.transform.Find("Text_Tip").GetComponent<Text>().text = $"品尝{need_time_0}次开启";
            self.Item_1.transform.Find("Text_Tip").GetComponent<Text>().text = $"品尝{need_time_1}次开启";
            self.Item_2.transform.Find("Text_Tip").GetComponent<Text>().text = $"品尝{need_time_2}次开启";

            UICommonHelper.SetImageGray(self.Item_0.transform.Find("ImageIcon").gameObject, dashiTime < need_time_0);
            UICommonHelper.SetImageGray(self.Item_1.transform.Find("ImageIcon").gameObject, dashiTime < need_time_1);
            UICommonHelper.SetImageGray(self.Item_2.transform.Find("ImageIcon").gameObject, dashiTime < need_time_2);
        }
    }
}
