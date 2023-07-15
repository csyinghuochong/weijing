using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UIPetTuJianComponent : Entity,IAwake
    {
        /// <summary>
        /// 宠物皮肤节点
        /// </summary>
        public GameObject PetSkinNode;
        
        /// <summary>
        /// 神宠列表
        /// </summary>
        public GameObject GodPetList;
        
        /// <summary>
        /// 普通宠物列表
        /// </summary>
        public GameObject CommonPetList;
        
        public GameObject BuildingList;

        public GameObject PetSkillNode;

        public GameObject Text_PetName;

        public GameObject RawImage;
        public UI PetModelShowComponent;

        public GameObject[] PetZiZhiItemList = new GameObject[6];
        public List<UIPetTuJianItemComponent> uIPetTuJianItems = new List<UIPetTuJianItemComponent>();
        public List<UICommonSkillItemComponent> PetSkillUIList = new List<UICommonSkillItemComponent>();
        public List<UIPetSkinIconComponent> UIPetSkinIconComponents = new List<UIPetSkinIconComponent>();
    }


    public class UIPetTuJianComponentAwake : AwakeSystem<UIPetTuJianComponent>
    {
        public override void Awake(UIPetTuJianComponent self)
        {
            self.uIPetTuJianItems.Clear();
            self.PetSkillUIList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PetSkinNode = rc.Get<GameObject>("PetSkinNode");
            self.GodPetList = rc.Get<GameObject>("GodPetList");
            self.CommonPetList = rc.Get<GameObject>("CommonPetList");
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

            int commonPetNum = 0;
            int godPetNum = 0;
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
                    if (petConfigs[i].PetType == 0) // 普通宠物
                    {
                        // 动态调整列表高度
                        commonPetNum++;
                        int row = commonPetNum / 4;
                        row += commonPetNum % 4 > 0? 1 : 0;
                        self.CommonPetList.GetComponent<RectTransform>().sizeDelta = new Vector2(713f, 150f + row * 160f);

                        UICommonHelper.SetParent(go, self.CommonPetList.GetComponent<ReferenceCollector>().Get<GameObject>("ItemNode"));
                    }
                    else
                    {
                        // 动态调整列表高度
                        godPetNum++;
                        int row = godPetNum / 4;
                        row += godPetNum % 4 > 0? 1 : 0;
                        self.GodPetList.GetComponent<RectTransform>().sizeDelta = new Vector2(713f, 150f + row * 160f);
                        
                        UICommonHelper.SetParent(go, self.GodPetList.GetComponent<ReferenceCollector>().Get<GameObject>("ItemNode"));
                    }

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
            self.UpdatePetSkinList(petid);

            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
            self.PetModelShowComponent.GetComponent<UIModelShowComponent>().ShowOtherModel("Pet/" + petConfig.PetModel.ToString(), true).Coroutine();

            //显示名称
            self.Text_PetName.GetComponent<Text>().text = petConfig.PetName;
        }

        public static void UpdatePetZizhi(this UIPetTuJianComponent self, int petid)
        {
          
            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
         
            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Hp_Max, 3000);
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Act_Max, 1500);
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Def_Max, 1500);
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_Adf_Max, 1500);
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", petConfig.ZiZhi_MageAct_Max, 1500);
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text = string.Format("{0}/{1}", (float)petConfig.ZiZhi_ChengZhang_Max, 1.25f);

            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Hp_Max / 3000f, 0f, 1f);
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Act_Max / 1500f, 0f, 1f);
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Def_Max / 1500f, 0f, 1f);
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_Adf_Max / 1500f, 0f, 1f);
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_MageAct_Max / 1500f, 0f, 1f);
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount = Mathf.Clamp((float)petConfig.ZiZhi_ChengZhang_Max / 1.25f, 0f, 1f);
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

        /// <summary>
        /// 更新宠物皮肤列表
        /// </summary>
        /// <param name="self"></param>
        /// <param name="petid"></param>
        public static void UpdatePetSkinList(this UIPetTuJianComponent self, int petid)
        {
            var objPath = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkinIcon");
            var objBundle = ResourcesComponent.Instance.LoadAsset<GameObject>(objPath);

            // 当前宠物的配置信息
            PetConfig petConfig = PetConfigCategory.Instance.Get(petid);
            // 需要显示的数量
            int skins = 0;

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            // 显示已经激活的皮肤

            // 拥有的皮肤数量
            for (int i = 0; i < petConfig.Skin.Length; i++)
            {
                if (petComponent.HavePetSkin(petConfig.Id, petConfig.Skin[i]))
                {
                    skins++;
                }
            }

            for (int i = 0; i < skins; i++)
            {
                UIPetSkinIconComponent uiPetSkinIconComponent = null;
                if (i < self.UIPetSkinIconComponents.Count)
                {
                    // 重复利用
                    uiPetSkinIconComponent = self.UIPetSkinIconComponents[i];
                    uiPetSkinIconComponent.GameObject.SetActive(true);
                }
                else
                {
                     GameObject uiPetSkin = GameObject.Instantiate(objBundle);
                     UICommonHelper.SetParent(uiPetSkin, self.PetSkinNode);
                     uiPetSkinIconComponent = self.AddChild<UIPetSkinIconComponent, GameObject>(uiPetSkin);
                     // 无点击功能
                     uiPetSkinIconComponent.SetClickHandler(null);
                     self.UIPetSkinIconComponents.Add(uiPetSkinIconComponent);
                }
                // 刷新图标
                uiPetSkinIconComponent.OnUpdateUI(petConfig.Skin[i], true);
            }

            // 隐藏不用的
            for (int i = skins; i < self.UIPetSkinIconComponents.Count; i++)
            {
                self.UIPetSkinIconComponents[i].GameObject.SetActive(false);
            }
            
        }
    }
}
