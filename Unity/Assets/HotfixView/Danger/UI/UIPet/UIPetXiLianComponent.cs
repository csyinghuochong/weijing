using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetXiLianComponent : Entity, IAwake
    {
        public GameObject Text_ItemName;
        public GameObject Img_ItemIcon;
        public GameObject Img_ItemQuality;
        public GameObject UIPetInfo1;
        public GameObject Btn_XiLian;
        public GameObject PetSkillNode;

        public List<UI> CostUIList;
        public UIPetInfoShowComponent UIPetInfoShowComponent;
        public BagInfo CostItemInfo;
        public RolePetInfo RolePetInfo;
    }

    [ObjectSystem]
    public class UIPetXiLianComponentAwakeSystem : AwakeSystem<UIPetXiLianComponent>
    {
        public override void Awake(UIPetXiLianComponent self)
        {
            self.CostUIList = new List<UI>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ItemName = rc.Get<GameObject>("Text_ItemName");
            self.Img_ItemIcon = rc.Get<GameObject>("Img_ItemIcon");
            self.Img_ItemQuality = rc.Get<GameObject>("Img_ItemQuality");
            self.UIPetInfo1 = rc.Get<GameObject>("UIPetInfo1");
         
            self.Btn_XiLian = rc.Get<GameObject>("Btn_XiLian");
            self.Btn_XiLian.GetComponent<Button>().onClick.AddListener(() => { self.OnClickXiLian(); });

            self.PetSkillNode = rc.Get<GameObject>("PetSkillNode");
            self.UIPetInfoShowComponent = null;
            self.OnInitUI();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
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

        public static void OnClickXiLian(this UIPetXiLianComponent self)
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
            self.ZoneScene().GetComponent<PetComponent>().RequestXiLian(self.CostItemInfo.BagInfoID, self.RolePetInfo.Id).Coroutine();
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
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            self.Img_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            self.Img_ItemQuality.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
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
                    && itemSubType != 122)
                {
                    continue;
                }
                UI ui_item = null;
                if (number < self.CostUIList.Count)
                {
                    ui_item = self.CostUIList[number];
                    ui_item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.PetSkillNode);

                    ui_item = self.AddChild<UI, string, GameObject>("UIItem_" + i.ToString(), bagSpace);
                    UIItemComponent uIItemComponent = ui_item.AddComponent<UIItemComponent>();
                    uIItemComponent.SetClickHandler((BagInfo bagInfo) => { self.OnSelectItem(bagInfo); });
                    self.CostUIList.Add(ui_item);
                }
                number++;

                ui_item.GetComponent<UIItemComponent>().HideItemName();
                ui_item.GetComponent<UIItemComponent>().UpdateItem(bagList[i], ItemOperateEnum.PetXiLian);
                ui_item.GetComponent<UIItemComponent>().Label_ItemNum.SetActive(true);
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
