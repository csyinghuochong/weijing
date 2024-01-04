using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionBloodStoneComponent: Entity, IAwake, IDestroy
    {
        public GameObject IconLImg;
        public GameObject NameLText;
        public GameObject IconRImg;
        public GameObject NameRText;
        public GameObject PropertyText;
        public GameObject UICommonItem;
        public GameObject CostItemListNode;
        public GameObject UpBtn;

        public List<UIItemComponent> UIItemComponentList = new List<UIItemComponent>();
        public List<string> AssetPath = new List<string>();
    }

    public class UIUnionBloodStoneComponentAwake: AwakeSystem<UIUnionBloodStoneComponent>
    {
        public override void Awake(UIUnionBloodStoneComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.IconLImg = rc.Get<GameObject>("IconLImg");
            self.NameLText = rc.Get<GameObject>("NameLText");
            self.IconRImg = rc.Get<GameObject>("IconRImg");
            self.NameRText = rc.Get<GameObject>("NameRText");
            self.PropertyText = rc.Get<GameObject>("PropertyText");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.CostItemListNode = rc.Get<GameObject>("CostItemListNode");
            self.UpBtn = rc.Get<GameObject>("UpBtn");

            self.UICommonItem.SetActive(false);

            self.UpBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnUpBtn().Coroutine(); });
            self.UpdateInfo();
        }
    }

    public class UIUnionBloodStoneComponentDestroy: DestroySystem<UIUnionBloodStoneComponent>
    {
        public override void Destroy(UIUnionBloodStoneComponent self)
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

    public static class UIUnionBloodStoneComponentSystem
    {
        public static void UpdateInfo(this UIUnionBloodStoneComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            PublicQiangHuaConfig publicQiangHuaConfig = PublicQiangHuaConfigCategory.Instance.Get(numericComponent.GetAsInt(NumericType.Bloodstone));

            string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, publicQiangHuaConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }

            UICommonHelper.SetImageGray(self.IconLImg, publicQiangHuaConfig.QiangHuaLv == 0);
            UICommonHelper.SetImageGray(self.IconRImg, publicQiangHuaConfig.QiangHuaLv == 0);

            self.IconLImg.GetComponent<Image>().sprite = sp;
            self.IconRImg.GetComponent<Image>().sprite = sp;

            self.NameLText.GetComponent<Text>().text = publicQiangHuaConfig.EquipSpaceName;
            self.NameRText.GetComponent<Text>().text = publicQiangHuaConfig.EquipSpaceName;
            if (publicQiangHuaConfig.QiangHuaLv != 0)
            {
                self.PropertyText.GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(publicQiangHuaConfig.EquipPropreAdd);
            }
            else
            {
                self.PropertyText.GetComponent<Text>().text = "下一级:\n" +
                        ItemViewHelp.GetAttributeDesc(PublicQiangHuaConfigCategory.Instance.Get(publicQiangHuaConfig.NextID).EquipPropreAdd);
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            string[] items1 = new[] { $"1;{publicQiangHuaConfig.CostGold}" };
            string[] items2 = publicQiangHuaConfig.CostItem.Split('@');
            string[] items = items1.Concat(items2).ToArray();
            int num = 0;
            foreach (string item in items)
            {
                string[] str = item.Split(';');
                int itemConfigId = int.Parse(str[0]);
                int itemNum = int.Parse(str[1]);
                long havedNum = bagComponent.GetItemNumber(itemConfigId);
                if (num >= self.UIItemComponentList.Count)
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UICommonItem);
                    UIItemComponent uiItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                    UICommonHelper.SetParent(go, self.CostItemListNode);
                    go.SetActive(true);
                    self.UIItemComponentList.Add(uiItemComponent);
                }

                UIItemComponent itemComponent = self.UIItemComponentList[num];
                itemComponent.GameObject.SetActive(true);
                itemComponent.UpdateItem(new BagInfo() { ItemID = itemConfigId }, ItemOperateEnum.None);
                itemComponent.Label_ItemNum.GetComponent<Text>().text =
                        itemConfigId == 1? $"{itemNum / 10000f:0.#}万/{havedNum / 10000f:0.#}万" : $"{itemNum}/{havedNum}";
                itemComponent.Label_ItemNum.GetComponent<Text>().color =
                        havedNum >= itemNum? new Color(0, 1, 0) : new Color(245f / 255f, 43f / 255f, 96f / 255f);
                num++;
            }

            for (int i = num; i < self.UIItemComponentList.Count; i++)
            {
                self.UIItemComponentList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask OnUpBtn(this UIUnionBloodStoneComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            PublicQiangHuaConfig publicQiangHuaConfig = PublicQiangHuaConfigCategory.Instance.Get(numericComponent.GetAsInt(NumericType.Bloodstone));

            if (publicQiangHuaConfig.NextID == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("已经达到最高级");
                return;
            }

            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv < publicQiangHuaConfig.UpLvLimit)
            {
                FloatTipManager.Instance.ShowFloatTip($"玩家等级不足，{publicQiangHuaConfig.UpLvLimit}开启");
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (!bagComponent.CheckNeedItem("1;" + publicQiangHuaConfig.CostGold + "@" + publicQiangHuaConfig.CostItem))
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }

            C2M_BloodstoneQiangHuaRequest request = new C2M_BloodstoneQiangHuaRequest();
            M2C_BloodstoneQiangHuaResponse response =
                    (M2C_BloodstoneQiangHuaResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            if (response.Level == publicQiangHuaConfig.Id)
            {
                FloatTipManager.Instance.ShowFloatTip("升级失败");
            }

            self.UpdateInfo();
        }
    }
}