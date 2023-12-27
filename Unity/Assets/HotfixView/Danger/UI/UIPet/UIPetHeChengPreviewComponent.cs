using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetHeChengPreviewComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
        public GameObject[] PetZiZhiItemList = new GameObject[6];
        public GameObject PetItemA;
        public GameObject PetItemB;
        public GameObject PetASkillListNode;
        public GameObject PetBSkillListNode;
        public GameObject PetSkillListNode;
    }

    public class UIPetHeChengPreviewComponentAwakeSystem: AwakeSystem<UIPetHeChengPreviewComponent>
    {
        public override void Awake(UIPetHeChengPreviewComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.PetZiZhiItemList[0] = rc.Get<GameObject>("PetZiZhiItem1");
            self.PetZiZhiItemList[1] = rc.Get<GameObject>("PetZiZhiItem2");
            self.PetZiZhiItemList[2] = rc.Get<GameObject>("PetZiZhiItem3");
            self.PetZiZhiItemList[3] = rc.Get<GameObject>("PetZiZhiItem4");
            self.PetZiZhiItemList[4] = rc.Get<GameObject>("PetZiZhiItem5");
            self.PetZiZhiItemList[5] = rc.Get<GameObject>("PetZiZhiItem6");
            self.PetItemA = rc.Get<GameObject>("PetItemA");
            self.PetItemB = rc.Get<GameObject>("PetItemB");
            self.PetASkillListNode = rc.Get<GameObject>("PetASkillListNode");
            self.PetBSkillListNode = rc.Get<GameObject>("PetBSkillListNode");
            self.PetSkillListNode = rc.Get<GameObject>("PetSkillListNode");

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetHeChengPreview); });
        }
    }

    public static class UIPetHeChengPreviewComponentSystem
    {
        public static void UpdateInfo(this UIPetHeChengPreviewComponent self, RolePetInfo rolePetA, RolePetInfo rolePetB)
        {
            RolePetInfo newRolePetInfo = PetHelper.GetPetHeChengPreview(rolePetA, rolePetB);
            PetConfig petConfig = PetConfigCategory.Instance.Get(newRolePetInfo.ConfigId);
            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{newRolePetInfo.ZiZhi_Hp}/{petConfig.ZiZhi_Hp_Max}";
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{newRolePetInfo.ZiZhi_Act}/{petConfig.ZiZhi_Act_Max}";
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{newRolePetInfo.ZiZhi_Def}/{petConfig.ZiZhi_Def_Max}";
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{newRolePetInfo.ZiZhi_Adf}/{petConfig.ZiZhi_Adf_Max}";
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{newRolePetInfo.ZiZhi_MageAct}/{petConfig.ZiZhi_MageAct_Max}";
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{UICommonHelper.ShowFloatValue(newRolePetInfo.ZiZhi_ChengZhang)}/{UICommonHelper.ShowFloatValue((float)petConfig.ZiZhi_ChengZhang_Max)}";

            Sprite sprite16 = ResourcesComponent.Instance.LoadAsset<Sprite>("Assets/Bundles/Icon/OtherIcon/Pro_16.png");
            Sprite sprite17 = ResourcesComponent.Instance.LoadAsset<Sprite>("Assets/Bundles/Icon/OtherIcon/Pro_17.png");

            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    newRolePetInfo.ZiZhi_Hp >= petConfig.ZiZhi_Hp_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)newRolePetInfo.ZiZhi_Hp / (float)petConfig.ZiZhi_Hp_Max, 0f, 1f);

            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    newRolePetInfo.ZiZhi_Act >= petConfig.ZiZhi_Act_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)newRolePetInfo.ZiZhi_Act / (float)petConfig.ZiZhi_Act_Max, 0f, 1f);

            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    newRolePetInfo.ZiZhi_Def >= petConfig.ZiZhi_Def_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)newRolePetInfo.ZiZhi_Def / (float)petConfig.ZiZhi_Def_Max, 0f, 1f);

            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    newRolePetInfo.ZiZhi_Adf >= petConfig.ZiZhi_Adf_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)newRolePetInfo.ZiZhi_Adf / (float)petConfig.ZiZhi_Adf_Max, 0f, 1f);

            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    newRolePetInfo.ZiZhi_MageAct >= petConfig.ZiZhi_MageAct_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)newRolePetInfo.ZiZhi_MageAct / (float)petConfig.ZiZhi_MageAct_Max, 0f, 1f);

            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    newRolePetInfo.ZiZhi_ChengZhang >= petConfig.ZiZhi_ChengZhang_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)newRolePetInfo.ZiZhi_ChengZhang / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f);

            UIRolePetBagItemComponent itemAComponent = self.AddChild<UIRolePetBagItemComponent, GameObject>(self.PetItemA);
            itemAComponent.OnInitUI(rolePetA);
            UIRolePetBagItemComponent itemBComponent = self.AddChild<UIRolePetBagItemComponent, GameObject>(self.PetItemB);
            itemBComponent.OnInitUI(rolePetB);
        }
    }
}