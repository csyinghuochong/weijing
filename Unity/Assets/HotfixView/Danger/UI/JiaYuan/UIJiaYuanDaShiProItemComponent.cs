using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanDaShiProItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_Progess;
        public GameObject Text_Name;

        public GameObject GameObject;
        public GameObject ImageToLock;
    }

    public class UIJiaYuanDaShiProItemComponentAwake : AwakeSystem<UIJiaYuanDaShiProItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanDaShiProItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ImageToLock = rc.Get<GameObject>("ImageToLock");
            self.Text_Progess = rc.Get<GameObject>("Text_Progess");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
        }
    }

    public static class UIJiaYuanDaShiProItemComponentSystem
    {

        public static void OnUpdateUI(this UIJiaYuanDaShiProItemComponent self, KeyValuePair keyValuePair, string promax)
        {
            string[] proinfo = promax.Split(',');

            string atrname = ItemViewHelp.GetAttributeName(int.Parse(proinfo[0]));
            self.Text_Name.GetComponent<Text>().text = atrname;
            string curvalue = keyValuePair != null ? keyValuePair.Value : "0";
            self.Text_Progess.GetComponent<Text>().text = $"{curvalue}/{proinfo[1]}";

            self.ImageToLock.SetActive(false);
        }
    }

}
