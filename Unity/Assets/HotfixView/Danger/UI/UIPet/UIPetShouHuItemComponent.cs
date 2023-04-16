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
        public RolePetInfo RolePetInfo;
        public Action<long> ButtonShouHuHandler;
    }

    public class UIPetShouHuItemComponentAwake : AwakeSystem<UIPetShouHuItemComponent, GameObject>
    {
        public override void Awake(UIPetShouHuItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc= gameObject.GetComponent<ReferenceCollector>();

            self.ButtonShouHu = rc.Get<GameObject>("ButtonShouHu");
            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.Node_2 = rc.Get<GameObject>("Node_2");
            self.Lab_ShouHu = rc.Get<GameObject>("Lab_ShouHu");
            self.Lab_PinFen = rc.Get<GameObject>("Lab_PinFen");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Img_ShouHuIcon = rc.Get<GameObject>("Img_ShouHuIcon");
            self.Img_PetHeroIon = rc.Get<GameObject>("Img_PetHeroIon");

            ButtonHelp.AddListenerEx( self.ButtonShouHu, () => { self.ButtonShouHuHandler(self.RolePetInfo.Id);  });
        }
    }

    public static class UIPetShouHuItemComponentSystem
    {

        public static void SetButtonShouHuHandler(this UIPetShouHuItemComponent self, Action<long> action)
        {
            self.ButtonShouHuHandler = action;
        }

        public static void OnInitUI(this UIPetShouHuItemComponent self, RolePetInfo rolePetInfo)
        {
            List<long> shouhulist = self.ZoneScene().GetComponent<PetComponent>().PetShouHuList;
            self.RolePetInfo = rolePetInfo;

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            self.Img_PetHeroIon.GetComponent<Image>().sprite = sp;

            self.Lab_PetName.GetComponent<Text>().text = rolePetInfo.PetName;

            self.Node_1.SetActive(shouhulist.Contains(rolePetInfo.Id));
            self.Node_2.SetActive(!shouhulist.Contains(rolePetInfo.Id));

            self.Lab_ShouHu.GetComponent<Text>().text = ConfigHelper.PetShouHuAttri[rolePetInfo.ShouHuPos].Value;
            self.Img_ShouHuIcon.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"ShouHu_{rolePetInfo.ShouHuPos}");
        }

    }
}
