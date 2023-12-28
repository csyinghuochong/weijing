using System.Collections.Generic;
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
            RolePetInfo rolePetInfoMin = new RolePetInfo();
            RolePetInfo rolePetInfoMax = new RolePetInfo();
            (rolePetInfoMin, rolePetInfoMax) = PetHelper.GetPetHeChengZiZhiPreview(rolePetA, rolePetB);

            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfoMin.ZiZhi_Hp}-{rolePetInfoMax.ZiZhi_Hp}";
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfoMin.ZiZhi_Act}-{rolePetInfoMax.ZiZhi_Act}";
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfoMin.ZiZhi_Def}-{rolePetInfoMax.ZiZhi_Def}";
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfoMin.ZiZhi_Adf}-{rolePetInfoMax.ZiZhi_Adf}";
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfoMin.ZiZhi_MageAct}-{rolePetInfoMax.ZiZhi_MageAct}";
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{UICommonHelper.ShowFloatValue(rolePetInfoMin.ZiZhi_ChengZhang)}-{UICommonHelper.ShowFloatValue(rolePetInfoMax.ZiZhi_ChengZhang)}";

            self.PetZiZhiItemList[0].transform.Find("ImageExpMinValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMin.ZiZhi_Hp / 3000, 0f, 1f);
            self.PetZiZhiItemList[0].transform.Find("ImageExpMaxValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMax.ZiZhi_Hp / 3000, 0f, 1f);

            self.PetZiZhiItemList[1].transform.Find("ImageExpMinValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMin.ZiZhi_Act / 1500, 0f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpMaxValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMax.ZiZhi_Act / 1500, 0f, 1f);

            self.PetZiZhiItemList[2].transform.Find("ImageExpMinValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMin.ZiZhi_Def / 1500, 0f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpMaxValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMax.ZiZhi_Def / 1500, 0f, 1f);

            self.PetZiZhiItemList[3].transform.Find("ImageExpMinValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMin.ZiZhi_Adf / 1500, 0f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpMaxValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMax.ZiZhi_Adf / 1500, 0f, 1f);

            self.PetZiZhiItemList[4].transform.Find("ImageExpMinValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMin.ZiZhi_MageAct / 1500, 0f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpMaxValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMax.ZiZhi_MageAct / 1500, 0f, 1f);

            self.PetZiZhiItemList[5].transform.Find("ImageExpMinValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMin.ZiZhi_ChengZhang / 1.25f, 0f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpMaxValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfoMax.ZiZhi_ChengZhang / 1.25f, 0f, 1f);

            // 宠物A
            UIRolePetBagItemComponent itemAComponent = self.AddChild<UIRolePetBagItemComponent, GameObject>(self.PetItemA);
            itemAComponent.OnInitUI(rolePetA);
            List<int> petAbaseSkillId = new List<int>();
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetA.ConfigId);
            string[] baseASkillID = petConfig.BaseSkillID.Split(';');
            for (int i = 0; i < baseASkillID.Length; i++)
            {
                petAbaseSkillId.Add(int.Parse(baseASkillID[i]));
            }

            self.UpdateSkill(self.PetASkillListNode, petAbaseSkillId);

            // 宠物B
            UIRolePetBagItemComponent itemBComponent = self.AddChild<UIRolePetBagItemComponent, GameObject>(self.PetItemB);
            itemBComponent.OnInitUI(rolePetB);
            List<int> petBbaseSkillId = new List<int>();
            petConfig = PetConfigCategory.Instance.Get(rolePetB.ConfigId);
            string[] baseBSkillID = petConfig.BaseSkillID.Split(';');
            for (int i = 0; i < baseBSkillID.Length; i++)
            {
                petBbaseSkillId.Add(int.Parse(baseBSkillID[i]));
            }

            self.UpdateSkill(self.PetBSkillListNode, petBbaseSkillId);

            // 概率消失技能
            List<int> allSkillId = new List<int>(rolePetA.PetSkill);
            allSkillId.AddRange(rolePetB.PetSkill);
            allSkillId.RemoveAll(item => petAbaseSkillId.Contains(item));
            allSkillId.RemoveAll(item => petBbaseSkillId.Contains(item));
            self.UpdateSkill(self.PetSkillListNode, allSkillId);
        }

        public static void UpdateSkill(this UIPetHeChengPreviewComponent self, GameObject root, List<int> skillId)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < skillId.Count; i++)
            {
                UICommonSkillItemComponent ui_item = null;
                GameObject go = UnityEngine.Object.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, root);
                ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(go);
                ui_item.OnUpdateUI(skillId[i], ABAtlasTypes.PetSkillIcon);
            }
        }
    }
}