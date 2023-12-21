using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRolePetBagComponent: Entity, IAwake
    {
        public Text TextNumber;
        public GameObject TakeOutBagBtn;
        public GameObject FenjieBtn;
        public GameObject PetSkillListNode;
        public GameObject PetListNode;
        public GameObject UIRolePetBagItem;
        public GameObject Btn_Close;
        public GameObject[] PetZiZhiItemList = new GameObject[6];

        public RolePetInfo RolePetInfo;
        public List<UICommonSkillItemComponent> UICommonSkillItemComponents = new List<UICommonSkillItemComponent>();
        public List<UIRolePetBagItemComponent> UIRolePetBagItemComponents = new List<UIRolePetBagItemComponent>();
    }

    public class UIRolePetBagComponentAwake: AwakeSystem<UIRolePetBagComponent>
    {
        public override void Awake(UIRolePetBagComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TakeOutBagBtn = rc.Get<GameObject>("TakeOutBagBtn");
            self.FenjieBtn = rc.Get<GameObject>("FenjieBtn");
            self.PetSkillListNode = rc.Get<GameObject>("PetSkillListNode");
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.UIRolePetBagItem = rc.Get<GameObject>("UIRolePetBagItem");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.PetZiZhiItemList[0] = rc.Get<GameObject>("PetZiZhiItem1");
            self.PetZiZhiItemList[1] = rc.Get<GameObject>("PetZiZhiItem2");
            self.PetZiZhiItemList[2] = rc.Get<GameObject>("PetZiZhiItem3");
            self.PetZiZhiItemList[3] = rc.Get<GameObject>("PetZiZhiItem4");
            self.PetZiZhiItemList[4] = rc.Get<GameObject>("PetZiZhiItem5");
            self.PetZiZhiItemList[5] = rc.Get<GameObject>("PetZiZhiItem6");

            self.TextNumber = rc.Get<GameObject>("TextNumber").GetComponent<Text>();
            self.UIRolePetBagItem.SetActive(false);
            foreach (GameObject go in self.PetZiZhiItemList)
            {
                go.SetActive(false);
            }

            self.TakeOutBagBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnTakeOutBagBtn().Coroutine(); });
            self.FenjieBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnFenjieBtn().Coroutine(); });
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.OnUpdatePetList();
        }
    }

    public static class UIRolePetBagComponentSystem
    {
        public static async ETTask OnTakeOutBagBtn(this UIRolePetBagComponent self)
        {
            if (self.RolePetInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("未选中宠物");
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int maxNum = PetHelper.GetPetMaxNumber(unit, userInfo.Lv);
            if (PetHelper.GetBagPetNum(self.ZoneScene().GetComponent<PetComponent>().RolePetInfos) >= maxNum)
            {
                FloatTipManager.Instance.ShowFloatTip("已达到宠物最大数量");
                return;
            }

            C2M_PetTakeOutBag request = new C2M_PetTakeOutBag() { PetInfoId = self.RolePetInfo.Id };
            M2C_PetTakeOutBag response = (M2C_PetTakeOutBag)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.OnUpdatePetList();
        }

        public static async ETTask OnFenjieBtn(this UIRolePetBagComponent self)
        {
            if (self.RolePetInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("未选中宠物");
                return;
            }

            C2M_RolePetFenjie request = new C2M_RolePetFenjie() { PetInfoId = self.RolePetInfo.Id };
            M2C_RolePetFenjie response = (M2C_RolePetFenjie)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.OnUpdatePetList();
        }

        public static void OnBtn_Close(this UIRolePetBagComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIRolePetBag);
        }

        public static void OnUpdatePetList(this UIRolePetBagComponent self)
        {
            self.RolePetInfo = null;

            List<RolePetInfo> rolePetInfos = self.ZoneScene().GetComponent<PetComponent>().RolePetBag;

            int num = 0;
            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                UIRolePetBagItemComponent itemComponent = null;

                if (i < self.UIRolePetBagItemComponents.Count)
                {
                    itemComponent = self.UIRolePetBagItemComponents[i];
                    itemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UIRolePetBagItem);
                    itemComponent = self.AddChild<UIRolePetBagItemComponent, GameObject>(go);
                    self.UIRolePetBagItemComponents.Add(itemComponent);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    go.SetActive(true);
                }

                itemComponent.OnInitUI(rolePetInfos[i]);
                itemComponent.SetClickHandler((petId) => { self.OnClickPetHandler(petId); });
                num++;
            }

            for (int i = num; i < self.UIRolePetBagItemComponents.Count; i++)
            {
                self.UIRolePetBagItemComponents[i].GameObject.SetActive(false);
            }

            if (num > 0)
            {
                foreach (GameObject go in self.PetZiZhiItemList)
                {
                    go.SetActive(true);
                }

                self.UIRolePetBagItemComponents[0].OnImage_ItemButton();
            }


            self.TextNumber.text = $"宠物数量： {rolePetInfos.Count}/40";
        }

        public static void OnClickPetHandler(this UIRolePetBagComponent self, RolePetInfo rolePetInfo)
        {
            self.RolePetInfo = rolePetInfo;

            for (int i = 0; i < self.UIRolePetBagItemComponents.Count; i++)
            {
                self.UIRolePetBagItemComponents[i].SetSelected(rolePetInfo.Id);
            }

            self.UpdatePetZizhi(rolePetInfo);
            self.UpdateSkillList(rolePetInfo);
        }

        public static void UpdatePetZizhi(this UIRolePetBagComponent self, RolePetInfo rolePetInfo)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            self.PetZiZhiItemList[0].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfo.ZiZhi_Hp}/{petConfig.ZiZhi_Hp_Max}";
            self.PetZiZhiItemList[1].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfo.ZiZhi_Act}/{petConfig.ZiZhi_Act_Max}";
            self.PetZiZhiItemList[2].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfo.ZiZhi_Def}/{petConfig.ZiZhi_Def_Max}";
            self.PetZiZhiItemList[3].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfo.ZiZhi_Adf}/{petConfig.ZiZhi_Adf_Max}";
            self.PetZiZhiItemList[4].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{UICommonHelper.ShowFloatValue(rolePetInfo.ZiZhi_ChengZhang)}/{UICommonHelper.ShowFloatValue((float)petConfig.ZiZhi_ChengZhang_Max)}";
            self.PetZiZhiItemList[5].transform.Find("Text_ZiZhiValue").GetComponent<Text>().text =
                    $"{rolePetInfo.ZiZhi_MageAct}/{petConfig.ZiZhi_MageAct_Max}";

            Sprite sprite16 = ResourcesComponent.Instance.LoadAsset<Sprite>("Assets/Bundles/Icon/OtherIcon/Pro_16.png");
            Sprite sprite17 = ResourcesComponent.Instance.LoadAsset<Sprite>("Assets/Bundles/Icon/OtherIcon/Pro_17.png");

            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    rolePetInfo.ZiZhi_Hp >= petConfig.ZiZhi_Hp_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[0].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfo.ZiZhi_Hp / (float)petConfig.ZiZhi_Hp_Max, 0f, 1f);

            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    rolePetInfo.ZiZhi_Act >= petConfig.ZiZhi_Act_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[1].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfo.ZiZhi_Act / (float)petConfig.ZiZhi_Act_Max, 0f, 1f);

            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    rolePetInfo.ZiZhi_Def >= petConfig.ZiZhi_Def_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[2].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfo.ZiZhi_Def / (float)petConfig.ZiZhi_Def_Max, 0f, 1f);

            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    rolePetInfo.ZiZhi_Adf >= petConfig.ZiZhi_Adf_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[3].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfo.ZiZhi_Adf / (float)petConfig.ZiZhi_Adf_Max, 0f, 1f);

            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    rolePetInfo.ZiZhi_ChengZhang >= petConfig.ZiZhi_ChengZhang_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[4].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfo.ZiZhi_ChengZhang / (float)petConfig.ZiZhi_ChengZhang_Max, 0f, 1f);

            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().sprite =
                    rolePetInfo.ZiZhi_MageAct >= petConfig.ZiZhi_MageAct_Max? sprite16 : sprite17;
            self.PetZiZhiItemList[5].transform.Find("ImageExpValue").GetComponent<Image>().fillAmount =
                    Mathf.Clamp((float)rolePetInfo.ZiZhi_MageAct / (float)petConfig.ZiZhi_MageAct_Max, 0f, 1f);
        }

        public static void UpdateSkillList(this UIRolePetBagComponent self, RolePetInfo rolePetInfo)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            List<int> zhuanzhuids = new List<int>();
            string[] zhuanzhuskills = petConfig.ZhuanZhuSkillID.Split(';');
            for (int i = 0; i < zhuanzhuskills.Length; i++)
            {
                if (zhuanzhuskills[i].Length > 1)
                {
                    zhuanzhuids.Add(int.Parse(zhuanzhuskills[i]));
                }
            }

            List<int> skills = new List<int>();
            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                if (zhuanzhuids.Contains(rolePetInfo.PetSkill[i]))
                {
                    skills.Insert(0, rolePetInfo.PetSkill[i]);
                }
                else
                {
                    skills.Add(rolePetInfo.PetSkill[i]);
                }
            }

            for (int i = 0; i < skills.Count; i++)
            {
                UICommonSkillItemComponent ui_item = null;
                if (i < self.UICommonSkillItemComponents.Count)
                {
                    ui_item = self.UICommonSkillItemComponents[i];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillListNode);
                    ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(bagSpace);
                    self.UICommonSkillItemComponents.Add(ui_item);
                }

                ui_item.OnUpdateUI(skills[i], ABAtlasTypes.PetSkillIcon,rolePetInfo.LockSkill.Contains(skills[i]));
            }

            for (int i = skills.Count; i < self.UICommonSkillItemComponents.Count; i++)
            {
                self.UICommonSkillItemComponents[i].GameObject.SetActive(false);
            }
        }
    }
}