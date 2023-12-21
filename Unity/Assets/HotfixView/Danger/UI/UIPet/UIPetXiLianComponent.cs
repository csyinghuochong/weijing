using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetXiLianComponent : Entity, IAwake,IDestroy
    {
        public GameObject Text_ItemName;
        public GameObject Img_ItemIcon;
        public GameObject Img_ItemQuality;
        public GameObject UIPetInfo1;
        public GameObject Btn_XiLian;
        public GameObject PetSkillNode;

        public List<UIItemComponent> CostUIList;
        public UIPetInfoShowComponent UIPetInfoShowComponent;
        public BagInfo CostItemInfo;
        public RolePetInfo RolePetInfo;
        public List<string> AssetPath = new List<string>();
    }


    public class UIPetXiLianComponentAwakeSystem : AwakeSystem<UIPetXiLianComponent>
    {
        public override void Awake(UIPetXiLianComponent self)
        {
            self.CostUIList = new List<UIItemComponent>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ItemName = rc.Get<GameObject>("Text_ItemName");
            self.Img_ItemIcon = rc.Get<GameObject>("Img_ItemIcon");
            self.Img_ItemQuality = rc.Get<GameObject>("Img_ItemQuality");
            self.UIPetInfo1 = rc.Get<GameObject>("UIPetInfo1");
         
            self.Btn_XiLian = rc.Get<GameObject>("Btn_XiLian");
            self.Btn_XiLian.GetComponent<Button>().onClick.AddListener(() => { self.OnClickXiLian().Coroutine(); });

            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.UIPetInfoShowComponent = null;
            self.OnInitUI();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
        }
    }
    public class UIPetXiLianComponentDestroy: DestroySystem<UIPetXiLianComponent>
    {
        public override void Destroy(UIPetXiLianComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }
    public static class UIPetXiLianComponentSystem
    {

        public static  void OnInitUI(this UIPetXiLianComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetInfoShow");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            self.UIPetInfoShowComponent = self.AddChild<UIPetInfoShowComponent, GameObject>(UnityEngine.Object.Instantiate(bundleGameObject));
            self.UIPetInfoShowComponent.Weizhi = 0;
            self.UIPetInfoShowComponent.BagOperationType = PetOperationType.XiLian;
            UICommonHelper.SetParent(self.UIPetInfoShowComponent.GameObject, self.UIPetInfo1);
            self.UIPetInfoShowComponent.OnInitData(self.RolePetInfo);
        }

        public static async ETTask OnClickXiLian(this UIPetXiLianComponent self)
        {
            if (self.RolePetInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择宠物！");
                return;
            }
            if (self.CostItemInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择道具！");
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.CostItemInfo.ItemID);

            if (itemConfig.ItemSubType == 136)
            {
                UI ui1 = await UIHelper.Create(self.ZoneScene(), UIType.UIPetXiLianLockSkill);
                ui1.GetComponent<UIPetXiLianLockSkillComponent>().UpdateSkillList(self.RolePetInfo, self.CostItemInfo).Coroutine();
                return;
            }

            if ((itemConfig.ItemSubType == 108 || itemConfig.ItemSubType == 109) && self.RolePetInfo.PetLv >= userInfo.Lv + 5)
            {
                FloatTipManager.Instance.ShowFloatTip("宠物等级不能高于玩家5级！");
                return;
            }

            PetConfig petConfig = PetConfigCategory.Instance.Get(self.RolePetInfo.ConfigId);
            if (itemConfig.ItemSubType == 119 && self.RolePetInfo.ZiZhi_ChengZhang >= petConfig.ZiZhi_ChengZhang_Max) //成长
            {
                FloatTipManager.Instance.ShowFloatTip("宠物成长已经达到上限！");
                return;
            }

            
            if (/*itemConfig.ItemSubType == 105 || */itemConfig.ItemSubType == 134)
            {
                if (PetHelper.IsBianYI(self.RolePetInfo))
                {
                    FloatTipManager.Instance.ShowFloatTip("变异的宠物不能使用此道具！");
                    return;
                }
            }

            //if (itemConfig.ItemSubType == 133)
            //{
            //    if (!PetHelper.IsBianYI(self.RolePetInfo))
            //    {
            //        FloatTipManager.Instance.ShowFloatTip("只有变异宠物能使用此道具！");
            //        return;
            //    }
            //}

            long oldSkin = self.RolePetInfo.SkinId;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            await petComponent.RequestXiLian(self.CostItemInfo.BagInfoID, self.RolePetInfo.Id);
            if (self.IsDisposed)
            {
                return;
            }
            if (oldSkin == self.RolePetInfo.SkinId)
            {
                return;
            }
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIPetChouKaGet);
            if (self.IsDisposed)
            {
                return;
            }
            List<KeyValuePair> oldPetSkin = petComponent.GetPetSkinCopy();
            ui.GetComponent<UIPetChouKaGetComponent>().OnInitUI(petComponent.GetPetInfoByID(self.RolePetInfo.Id), oldPetSkin, null);
        }

        public static void OnXiLianUpdate(this UIPetXiLianComponent self)
        { 
            self.RolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.RolePetInfo.Id);
            self.UIPetInfoShowComponent.OnInitData(self.RolePetInfo);
            self.UpdateConsume().Coroutine();
        }

        public static void OnXiLianSelect(this UIPetXiLianComponent self, RolePetInfo rolePetInfo)
        {
            self.RolePetInfo = rolePetInfo;
            self.UIPetInfoShowComponent.OnInitData(rolePetInfo);

            self.UpdateConsume().Coroutine();
        }

        public static void OnSelectItem(this UIPetXiLianComponent self, BagInfo bagInfo)
        {
            self.CostItemInfo = bagInfo;
            if (bagInfo == null)
            {
                return;
            }

            self.Img_ItemIcon.SetActive(true);
            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Img_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.Img_ItemQuality.GetComponent<Image>().sprite = sp2;
            self.Text_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
        }

        public static void OnUpdateUI(this UIPetXiLianComponent self)
        {
            self.RolePetInfo = null;
            self.CostItemInfo = null;
            self.Img_ItemIcon.SetActive(false);
            self.Text_ItemName.GetComponent<Text>().text = "";
            self.UpdateConsume().Coroutine();
            self.UIPetInfoShowComponent?.OnInitData(self.RolePetInfo);
        }

        public static async ETTask UpdateConsume(this UIPetXiLianComponent self)
        {
            List<BagInfo> bagList = self.ZoneScene().GetComponent<BagComponent>().GetBagList();
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            int number = 0;
            for (int i = 0; i < bagList.Count; i++)
            {
                int itemID = bagList[i].ItemID;
                ItemConfig conf = ItemConfigCategory.Instance.Get(itemID);
                int itemType = conf.ItemType;
                int itemSubType = conf.ItemSubType;

                if (itemSubType != 105 && itemSubType != 108 && itemSubType != 109
                    && itemSubType != 117 && itemSubType != 118 && itemSubType != 119
                    && itemSubType != 122 && itemSubType != 133 && itemSubType != 134
                    && itemSubType != 136)
                {
                    continue;
                }
                UIItemComponent ui_item = null;
                if (number < self.CostUIList.Count)
                {
                    ui_item = self.CostUIList[number];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillNode);

                    ui_item = self.AddChild<UIItemComponent, GameObject>(bagSpace);
                    ui_item.SetClickHandler((BagInfo bagInfo) => { self.OnSelectItem(bagInfo); });
                    self.CostUIList.Add(ui_item);
                }
                number++;

                ui_item.HideItemName();
                ui_item.UpdateItem(bagList[i], ItemOperateEnum.PetXiLian);
                ui_item.Label_ItemNum.SetActive(true);
            }

            for (int i = number; i < self.CostUIList.Count; i++)
            {
                self.CostUIList[i].GameObject.SetActive(false);
            }
            if (number == 0)
            {
                self.OnSelectItem(null);
            }
        }
    }

}
