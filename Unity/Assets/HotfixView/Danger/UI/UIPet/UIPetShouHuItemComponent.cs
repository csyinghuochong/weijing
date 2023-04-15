using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetShouHuItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Node_1;
        public GameObject Node_2;
        public GameObject ButtonShouHu;
        public GameObject Lab_ShouHu;
        public GameObject Lab_PinFen;
        public GameObject Lab_PetName;
        public GameObject Img_ShouHuIcon;
        public GameObject Img_PetHeroIon;

        public GameObject GameObject;
    }

    public class UIPetShouHuItemComponentAwake : AwakeSystem<UIPetShouHuItemComponent, GameObject>
    {
        public override void Awake(UIPetShouHuItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc= gameObject.GetComponent<ReferenceCollector>();

            self.ButtonShouHu = rc.Get<GameObject>("ButtonShouHu");
            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.Node_2 = rc.Get<GameObject>("Node_2");
            self.Lab_ShouHu = rc.Get<GameObject>("Lab_ShouHu");
            self.Lab_PinFen = rc.Get<GameObject>("Lab_PinFen");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Img_ShouHuIcon = rc.Get<GameObject>("Img_ShouHuIcon");
            self.Img_PetHeroIon = rc.Get<GameObject>("Img_PetHeroIon");
        }
    }

    public static class UIPetShouHuItemComponentSystem
    {
        public static void OnInitUI(this UIPetShouHuItemComponent self, RolePetInfo rolePetInfo)
        {
            self.Lab_PetName.GetComponent<Text>().text = rolePetInfo.PetName;

            self.Node_1.SetActive(rolePetInfo.ShouHuSet == 1);
            self.Node_2.SetActive(rolePetInfo.ShouHuSet == 1);
        }
    }
}
