using UnityEngine;
using UnityEngine.UI;


namespace ET
{

    public class UIPetSelectItemComponent : Entity, IAwake
    {
        public PetOperationType OperationType; //1合成 2洗练

        public GameObject Image_Protect;
        public GameObject Img_Start;
        public GameObject ImageDiButton;
        public GameObject Img_CanZhan;
        public GameObject Lab_PetLv;
        public GameObject Lab_PetName;
        public GameObject Img_PetHeroIon;
        public GameObject Img_PeteroQuality;
        public GameObject ImageXuanzhong;
        public GameObject Lab_StartLv;

        public RolePetInfo RolePetInfo;
    }


    public class UIPetHeChengSelectItemComponentAwakeSystem : AwakeSystem<UIPetSelectItemComponent>
    {
        public override void Awake(UIPetSelectItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
           
            self.Lab_PetLv = rc.Get<GameObject>("Lab_PetLv");
            self.Lab_PetName = rc.Get<GameObject>("Lab_PetName");
            self.Img_PetHeroIon = rc.Get<GameObject>("Img_PetHeroIon");
            self.Img_PeteroQuality = rc.Get<GameObject>("Img_PeteroQuality");
            self.Img_Start = rc.Get<GameObject>("Img_Start");
            self.Lab_StartLv = rc.Get<GameObject>("Lab_StartLv");
            self.Image_Protect = rc.Get<GameObject>("Image_Protect");

            self.ImageDiButton = rc.Get<GameObject>("ImageDiButton");
            self.ImageDiButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickPetItem(); });
        }
    }

    public static class UIPetHeChengSelectItemComponentSystem
    {

        public static void OnInitData(this UIPetSelectItemComponent self, RolePetInfo rolePetInfo)
        {
            self.RolePetInfo = rolePetInfo;

            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            self.Img_PetHeroIon.GetComponent<Image>().sprite = sp;
            self.Lab_PetName.GetComponent<Text>().text = rolePetInfo.PetName;
            self.Lab_PetLv.GetComponent<Text>().text = rolePetInfo.PetLv.ToString() + GameSettingLanguge.LoadLocalization("级");
            self.Image_Protect.SetActive(rolePetInfo.IsProtect);
            //self.Img_Start.SetActive(!GlobalHelp.IsBanHaoMode);
            //self.Lab_StartLv.SetActive(!GlobalHelp.IsBanHaoMode);
            //self.Lab_StartLv.GetComponent<Text>().text = "x" + rolePetInfo.Star;
            //self.Lab_PetName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(petConfig.PetQuality);
        }

        public static void OnClickPetItem(this UIPetSelectItemComponent self)
        {
            if (self.RolePetInfo.IsProtect)
            {
                FloatTipManager.Instance.ShowFloatTip("锁定宠物不能操作！");
                return;
            }

            HintHelp.GetInstance().DataUpdate(DataType.PetItemSelect, self.OperationType.ToString() + "@" + self.RolePetInfo.Id.ToString());
            UIHelper.Remove(self.DomainScene(), UIType.UIPetSelect);
        }
    }

}
