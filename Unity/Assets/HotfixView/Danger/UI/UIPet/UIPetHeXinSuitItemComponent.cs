using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeXinSuitItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject NameText;
        public GameObject RequirementText;
        public GameObject PropertyTextListNode;
        public GameObject PropertyText;
    }

    public class UIPetHeXinSuitItemComponentAwakeSystem: AwakeSystem<UIPetHeXinSuitItemComponent, GameObject>
    {
        public override void Awake(UIPetHeXinSuitItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.NameText = rc.Get<GameObject>("NameText");
            self.RequirementText = rc.Get<GameObject>("RequirementText");
            self.PropertyTextListNode = rc.Get<GameObject>("PropertyTextListNode");
            self.PropertyText = rc.Get<GameObject>("PropertyText");

            self.PropertyText.SetActive(false);
        }
    }

    public static class UIPetHeXinSuitItemComponentSystem
    {
        public static void UpdateInfo(this UIPetHeXinSuitItemComponent self, int key)
        {
            switch (key)
            {
                case 5:
                    self.NameText.GetComponent<Text>().text = "初级核心";
                    self.RequirementText.GetComponent<Text>().text = "穿戴3个5级以上的宠物之核";
                    break;
                case 8:
                    self.NameText.GetComponent<Text>().text = "中级核心";
                    self.RequirementText.GetComponent<Text>().text = "穿戴3个8级以上的宠物之核";
                    break;
                case 10:
                    self.NameText.GetComponent<Text>().text = "高级核心";
                    self.RequirementText.GetComponent<Text>().text = "穿戴3个10级以上的宠物之核";
                    break;
            }

            string[] proStr = ConfigHelper.PetSuitProperty[key].Split(';');
            for (int i = 0; i < proStr.Length; i++)
            {
                string str = String.Empty;
                string[] pro = proStr[i].Split(',');
                string proName = ItemViewHelp.GetAttributeName(int.Parse(pro[0]));
                int showType = NumericHelp.GetNumericValueType(int.Parse(pro[0]));

                if (showType == 2)
                {
                    float value = int.Parse(pro[1]) / 100f;
                    str = proName + "+" + value.ToString("0.##") + "%";
                }
                else
                {
                    str = proName + "+" + int.Parse(pro[1]);
                }

                GameObject go = UnityEngine.Object.Instantiate(self.PropertyText);
                go.GetComponent<Text>().text = str;
                go.SetActive(true);
                UICommonHelper.SetParent(go, self.PropertyTextListNode);
            }
        }
    }
}