using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetUpStarItemComponent : Entity, IAwake
    {
        public GameObject Lab_SuccessAdd;
        public GameObject Lab_PetLv;
        public GameObject Lab_PetName;
        public GameObject Img_StarList;
        public GameObject Img_PetHeroIon;
        public GameObject Img_PeteroQuality;
        public GameObject Obj_Lab_SuccessAdd;

        public RolePetInfo RolePetInfo;
    }


    public class UIPetUpStarItemComponentAwakeSystem : AwakeSystem<UIPetUpStarItemComponent>
    {
        public override void Awake(UIPetUpStarItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_SuccessAdd = rc.Get<GameObject>("Lab_SuccessAdd");
            self.Lab_PetLv = rc.Get<GameObject>("Lab_PetLv");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Img_StarList = rc.Get<GameObject>("Img_StarList");
            self.Img_PetHeroIon = rc.Get<GameObject>("Img_PetHeroIon");
            self.Img_PeteroQuality = rc.Get<GameObject>("Img_PeteroQuality");
            self.Obj_Lab_SuccessAdd = rc.Get<GameObject>("Lab_SuccessAdd");
        }
    }

    public static class UIPetUpStarItemComponentSystem
    {

        public static void OnUpdateUI(this UIPetUpStarItemComponent self, RolePetInfo rolePetInfo)
        {
            self.GetParent<UI>().GameObject.SetActive(rolePetInfo!=null);
            self.RolePetInfo = rolePetInfo;

            if (rolePetInfo == null)
            {
                return;
            }

            for (int i = 0; i < self.Img_StarList.transform.childCount; i++)
            {
                self.Img_StarList.transform.GetChild(i).gameObject.SetActive(rolePetInfo.Star > i);
            }

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            self.Img_PetHeroIon.GetComponent<Image>().sprite = sp;

            self.Lab_PetName.GetComponent<Text>().text = rolePetInfo.PetName;
            self.Lab_PetLv.GetComponent<Text>().text = rolePetInfo.PetLv.ToString();

            string showProStr = "";
            switch (rolePetInfo.Star) {
                case 0:
                    showProStr = "25%";
                    break;
                case 1:
                    showProStr = "25%";
                    break;
                case 2:
                    showProStr = "20%";
                    break;
                case 3:
                    showProStr = "15%";
                    break;
                case 4:
                    showProStr = "10%";
                    break;
                case 5:
                    showProStr = "0%";
                    break;
            }
            self.Obj_Lab_SuccessAdd.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("成功附加率") + showProStr;

        }
    }
}
