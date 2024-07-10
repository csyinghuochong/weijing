using ProtoBuf.Meta;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPropertyHintComponent: Entity, IAwake
    {
        public GameObject PositionNode;
        public GameObject PropertyNameText;
        public GameObject PropertyDesText;
        public GameObject ThresholdText;
    }

    public class UIPropertyHintComponentAwakeSystem: AwakeSystem<UIPropertyHintComponent>
    {
        public override void Awake(UIPropertyHintComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PositionNode = rc.Get<GameObject>("PositionNode");
            self.PropertyNameText = rc.Get<GameObject>("PropertyNameText");
            self.PropertyDesText = rc.Get<GameObject>("PropertyDesText");
            self.ThresholdText = rc.Get<GameObject>("ThresholdText");
        }
    }

    public static class UIPropertyHintComponentSystem
    {
        public static void OnUpdateData(this UIPropertyHintComponent self, Vector3 vector3, string name, int numtype )
        {
            self.PositionNode.transform.localPosition = vector3 + new Vector3(100, 0f, 0f);
            self.PropertyNameText.GetComponent<Text>().text = name;
            self.PropertyDesText.GetComponent<Text>().text = ItemViewHelp.PropertyHint[numtype];
            if (ItemViewHelp.AttributeToName.ContainsKey(numtype))
            {
                self.ThresholdText.GetComponent<Text>().text = ItemViewHelp.AttributeToName[numtype].Threshold;
            }
            else
            {
                self.ThresholdText.GetComponent<Text>().text = string.Empty;
            }
            
        }
    }
}