using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public class UIJiaYuanPetWalkItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_TotalExp;
        public GameObject Button_Stop;

        public GameObject[] ImageMood_List = new GameObject[5];

        public GameObject Text_Level;
        public GameObject Text_Name;
        public GameObject ImagePetIcon;
    }

    public class UIJiaYuanPetWalkItemComponentA : AwakeSystem<UIJiaYuanPetWalkItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPetWalkItemComponent self, GameObject a)
        {
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_TotalExp = rc.Get<GameObject>("Text_TotalExp");
            self.Button_Stop = rc.Get<GameObject>("Button_Stop");

            for (int i = 0; i < 5; i++)
            { 
                self.ImageMood_List[i] = rc.Get<GameObject>($"ImageMood_{i}");
            }

            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.ImagePetIcon = rc.Get<GameObject>("ImagePetIcon");
        }
    }

    public static class UIJiaYuanPetWalkItemComponentSystem
    { 
        
    }
}
