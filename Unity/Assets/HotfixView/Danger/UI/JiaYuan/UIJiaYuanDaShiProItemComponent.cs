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
        public GameObject ImageTo_1Value;
        public GameObject ImageProIcon;

        public Dictionary<int, string> jiayuanDaShi = new Dictionary<int, string>();

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
            self.ImageTo_1Value = rc.Get<GameObject>("ImageTo_1Value");
            self.ImageProIcon = rc.Get<GameObject>("ImageProIcon");

            //血
            self.jiayuanDaShi.Add(100203, "PetPro_1");
            self.jiayuanDaShi.Add(105503, "PetPro_1");
            
            //攻击
            self.jiayuanDaShi.Add(100403, "PetPro_2");
            self.jiayuanDaShi.Add(119303, "PetPro_2");
            self.jiayuanDaShi.Add(119103, "PetPro_2");
            self.jiayuanDaShi.Add(105103, "PetPro_2");
            self.jiayuanDaShi.Add(105203, "PetPro_2");
            self.jiayuanDaShi.Add(119503, "PetPro_2");
            self.jiayuanDaShi.Add(110203, "PetPro_2");
            self.jiayuanDaShi.Add(120603, "PetPro_2");

            //魔法
            self.jiayuanDaShi.Add(105303,"PetPro_3");
            self.jiayuanDaShi.Add(120703, "PetPro_3");

            //物防
            self.jiayuanDaShi.Add(100603,"PetPro_4");
            self.jiayuanDaShi.Add(119403, "PetPro_4");
            self.jiayuanDaShi.Add(119203, "PetPro_4");
            self.jiayuanDaShi.Add(105403, "PetPro_4");

            //魔防
            self.jiayuanDaShi.Add(100803,"PetPro_5");
            self.jiayuanDaShi.Add(110103, "PetPro_5");
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
            self.ImageTo_1Value.GetComponent<Image>().fillAmount = float.Parse(curvalue)/ float.Parse(proinfo[1]);

            self.ImageToLock.SetActive(false);

            //显示图标
            self.ImageProIcon.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PropertyIcon, self.jiayuanDaShi[int.Parse(proinfo[0])]);
        }
    }

}
