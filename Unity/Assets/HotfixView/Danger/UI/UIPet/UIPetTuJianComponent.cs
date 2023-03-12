using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UIPetTuJianComponent : Entity,IAwake
    {
        public GameObject BuildingList;

        public GameObject PetSkillNode;

        public GameObject Text_PetName;

        public GameObject RawImage;
        public UI PetModelShowComponent;

        public GameObject[] PetZiZhiItemList = new GameObject[6];
        public List<UIPetTuJianItemComponent> uIPetTuJianItems = new List<UIPetTuJianItemComponent>();
        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
    }

    [ObjectSystem]
    public class UIPetTuJianComponentAwake : AwakeSystem<UIPetTuJianComponent>
    {
        public override void Awake(UIPetTuJianComponent self)
        {
            self.uIPetTuJianItems.Clear();
            self.PetSkillUIList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.Text_PetName = rc.Get<GameObject>("Text_PetName");
            self.RawImage = rc.Get<GameObject>("RawImage");

            self.PetZiZhiItemList[0] = rc.Get<GameObject>("PetZiZhiItem1");
            self.PetZiZhiItemList[1] = rc.Get<GameObject>("PetZiZhiItem2");
            self.PetZiZhiItemList[2] = rc.Get<GameObject>("PetZiZhiItem3");
            self.PetZiZhiItemList[3] = rc.Get<GameObject>("PetZiZhiItem4");
            self.PetZiZhiItemList[4] = rc.Get<GameObject>("PetZiZhiItem5");
            self.PetZiZhiItemList[5] = rc.Get<GameObject>("PetZiZhiItem6");

            self.InitModelShowView_1();

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIPetTuJianComponentSystem
    {
        public static  void InitModelShowView_1(this UIPetTuJianComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
        
            GameObject gameObject_1 = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject_1, self.RawImage);
            gameObject_1.transform.localPosition = new Vector3(0 * 1000, 0, 0);
            self.PetModelShowComponent = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject_1);
            self.PetModelShowComponent.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);
            //配置摄像机位置[0,115,257]
            gameObject_1.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
        }

        public static void OnUpdateUI(this UIPetTuJianComponent self)
        {
            self.OnUpdatePetList();
        }

        public static void OnUpdatePetList(this UIPetTuJianComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetTuJianItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<PetConfig> petConfigs = PetConfigCategory.Instance.GetAll().Values.ToList();

            for (int i = 0; i < petConfigs.Count; i++)
            {
                UIPetTuJianItemComponent uIPetTuJianItem = null;
                if (i < self.uIPetTuJianItems.Count)
                {
                    uIPetTuJianItem = self.uIPetTuJianItems[i];
                    uIPetTuJianItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList);
                    uIPetTuJianItem = self.AddChild<UIPetTuJianItemComponent, GameObject>(go);
                    uIPetTuJianItem.OnInitUI(petConfigs[i].Id);
                    uIPetTuJianItem.SetClickHandler((int petId) => { self.OnClickPetHandler(petId); });
                    self.uIPetTuJianItems.Add(uIPetTuJianItem);
                }
            }
            for (int i = petConfigs.Count; i < self.uIPetTuJianItems.Count; i++)
            {
                self.uIPetTuJianItems[i].GameObject.SetActive(false);
            }

            self.uIPetTuJianItems[0].OnImage_ItemButton();
        }

        public static void OnClickPetHandler(this UIPetTuJianComponent self, int petid)
        {
            for (int i = 0; i < self.uIPetTuJianItems.Count; i++)
            {
                self.uIPetTuJianItems[i].SetSelected(petid);
            }

            self.UpdatePetZizhi(petid);
            self.UpdateSkillList(petid);

            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
            self.PetModelShowComponent.GetComponent<UIModelShowComponent>().ShowOtherModel("Pet/" + petConfig.PetModel.ToString(), true).Coroutine();
        }

        public static void UpdatePetZizhi(this UIPetTuJianComponent self, int petid)
        {
          
            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
         
            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Hp_Max, petConfig.ZiZhi_Hp_Max);
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Act_Max, petConfig.ZiZhi_Act_Max);
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Def_Max, petConfig.ZiZhi_Def_Max);
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Adf_Max, petConfig.ZiZhi_Adf_Max);
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", (float)petConfig.ZiZhi_ChengZhang_Max, (float)petConfig.ZiZhi_ChengZhang_Max);
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_MageAct_Max, petConfig.ZiZhi_MageAct_Max);
            
            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Hp_Max / (float)petConfig.ZiZhi_Hp_Max, 0f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Hp_Max / (float)petConfig.ZiZhi_Hp_Max, 0f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Def_Max / (float)petConfig.ZiZhi_Def_Max, 0f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Adf_Max / (float)petConfig.ZiZhi_Adf_Max, 0f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_ChengZhang_Max / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_MageAct_Max / (float)petConfig.ZiZhi_MageAct_Max, 0f, 1f);
        }


        public static void UpdateSkillList(this UIPetTuJianComponent self, int petid)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
            List<int> skills = new List<int>();
            //if (petConfig.ActSkillID != 0)
            //{
            //    skills.Add(petConfig.ActSkillID);
            //}

            string[] baseskill = petConfig.BaseSkillID.Split(';');  
            for (int i = 0; i < baseskill.Length; i++)
            {
                if (ComHelp.IfNull(baseskill[i]))
                {
                    continue;
                }
                int baseskillid = int.Parse(baseskill[i]);
                if (!skills.Contains(baseskillid))
                {
                    skills.Add(baseskillid);
                }
            }

            string[] zhuanzhuskills = petConfig.RandomSkillID.Split(';');
            for (int i = 0; i < zhuanzhuskills.Length; i++)
            {
                if (ComHelp.IfNull(zhuanzhuskills[i]))
                {
                    continue;
                }
                int zhuanzhuskill = int.Parse(zhuanzhuskills[i]);
                if (!skills.Contains(zhuanzhuskill))
                {
                    skills.Add(zhuanzhuskill);
                }
            }

            for (int i = 0; i < skills.Count; i++)
            {
                UICommonSkillItemComponent ui_item = null;
                if (i < self.PetSkillUIList.Count)
                {
                    ui_item = self.PetSkillUIList[i];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillNode);
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(bagSpace);
                    self.PetSkillUIList.Add(ui_item);
                }
                ui_item.OnUpdateUI(skills[i], ABAtlasTypes.PetSkillIcon);
            }

            for (int i = skills.Count; i < self.PetSkillUIList.Count; i++)
            {
                self.PetSkillUIList[i].GameObject.SetActive(false);
            }
        }

    }
}
