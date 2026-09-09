using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetFenJieTipComponent : Entity, IAwake, IDestroy
    {
        public GameObject Image_Close;
        public GameObject Btn_Close;
        public GameObject Btn_FangSheng;
        public GameObject ItemRewadList_1;
        public GameObject ItemRewadList_2;
        public GameObject ItemRewadList_3;
        public GameObject ItemRewadList_4;
        public GameObject UIPetFenJieTipItem;
        public GameObject PetListNode;
        public GameObject UICommonItem;

        public PetComponent PetComponent;
        public RolePetInfo LastSelectItem;
        public string UICommonItemPath;

        public List<UIPetFenJieTipItemComponent> PetUIList = new List<UIPetFenJieTipItemComponent>();
        public List<UIItemComponent> RewardItemList_1 = new List<UIItemComponent>();
        public List<UIItemComponent> RewardItemList_2 = new List<UIItemComponent>();
        public List<UIItemComponent> RewardItemList_3 = new List<UIItemComponent>();
        public List<UIItemComponent> RewardItemList_4 = new List<UIItemComponent>();
    }

    public class UIPetFenJieTipComponentAwakeSystem : AwakeSystem<UIPetFenJieTipComponent>
    {
        public override void Awake(UIPetFenJieTipComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Image_Close = rc.Get<GameObject>("Image_Close");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_FangSheng = rc.Get<GameObject>("Btn_FangSheng");
            self.ItemRewadList_1 = rc.Get<GameObject>("ItemRewadList_1");
            self.ItemRewadList_2 = rc.Get<GameObject>("ItemRewadList_2");
            self.ItemRewadList_3 = rc.Get<GameObject>("ItemRewadList_3");
            self.ItemRewadList_4 = rc.Get<GameObject>("ItemRewadList_4");
            self.UIPetFenJieTipItem = rc.Get<GameObject>("UIPetFenJieTipItem");
            self.UIPetFenJieTipItem.SetActive(false);
            self.PetListNode = rc.Get<GameObject>("PetListNode");

            ButtonHelp.AddListenerEx(self.Image_Close, () => { self.OnBtn_Close(); });
            ButtonHelp.AddListenerEx(self.Btn_Close, () => { self.OnBtn_Close(); });
            ButtonHelp.AddListenerEx(self.Btn_FangSheng, () => { self.OnBtn_FangSheng(); });

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.UICommonItemPath = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            self.UICommonItem = ResourcesComponent.Instance.LoadAsset<GameObject>(self.UICommonItemPath);

            DataUpdateComponent.Instance.AddListener(DataType.PetFenJieUpdate, self);

            self.OnInitUI();
        }
    }

    public class UIPetFenJieTipComponentDestroy : DestroySystem<UIPetFenJieTipComponent>
    {
        public override void Destroy(UIPetFenJieTipComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.PetFenJieUpdate, self);

            if (!string.IsNullOrEmpty(self.UICommonItemPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.UICommonItemPath);
            }

            self.UICommonItemPath = null;
            self.UICommonItem = null;
            self.PetUIList = null;
            self.RewardItemList_1 = null;
            self.RewardItemList_2 = null;
            self.RewardItemList_3 = null;
            self.RewardItemList_4 = null;
        }
    }

    public static class UIPetFenJieTipComponentSystem
    {
        public static void OnInitUI(this UIPetFenJieTipComponent self)
        {
            self.ShowRewardList(self.ItemRewadList_1, PetHelper.GetPetFenJieItemsByPingFen(0), self.RewardItemList_1);
            self.ShowRewardList(self.ItemRewadList_2, PetHelper.GetPetFenJieItemsByPingFen(5000), self.RewardItemList_2);
            self.ShowRewardList(self.ItemRewadList_3, PetHelper.GetPetFenJieItemsByPingFen(8500), self.RewardItemList_3);
            self.ShowRewardList(self.ItemRewadList_4, PetHelper.GetPetFenJieItemsByPingFen(10000), self.RewardItemList_4);
            self.OnInitPetList();
        }

        public static void OnPetFenJieUpdate(this UIPetFenJieTipComponent self)
        {
            self.OnInitPetList();
        }

        public static void OnInitPetList(this UIPetFenJieTipComponent self)
        {
            List<RolePetInfo> list = self.PetComponent.RolePetInfos;
            long selectId = self.GetDefaultSelectPetId();

            for (int i = 0; i < list.Count; i++)
            {
                UIPetFenJieTipItemComponent item;
                if (i < self.PetUIList.Count)
                {
                    item = self.PetUIList[i];
                    item.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIPetFenJieTipItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    item = self.AddChild<UIPetFenJieTipItemComponent, GameObject>(go);
                    item.SetClickHandler(self.OnClickPetItem);
                    self.PetUIList.Add(item);
                }

                item.OnInitData(list[i]);
            }

            for (int i = list.Count; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].GameObject.SetActive(false);
                self.PetUIList[i].RolePetInfo = null;
            }

            if (list.Count == 0)
            {
                self.LastSelectItem = null;
                self.UpdateRewardGray();
                return;
            }

            RolePetInfo selectPet = self.PetComponent.GetPetInfoByID(selectId);
            if (selectPet == null)
            {
                selectPet = list[0];
            }

            self.OnClickPetItem(selectPet.Id);
        }

        public static long GetDefaultSelectPetId(this UIPetFenJieTipComponent self)
        {
            if (self.LastSelectItem != null && self.PetComponent.GetPetInfoByID(self.LastSelectItem.Id) != null)
            {
                return self.LastSelectItem.Id;
            }

            UI uiPet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            if (uiPet == null)
            {
                return 0;
            }

            UIPetComponent uiPetComponent = uiPet.GetComponent<UIPetComponent>();
            if (uiPetComponent?.UIPageView?.UISubViewList == null)
            {
                return 0;
            }

            int page = (int)PetPageEnum.PetList;
            if (page < 0 || page >= uiPetComponent.UIPageView.UISubViewList.Length)
            {
                return 0;
            }

            UI petListUI = uiPetComponent.UIPageView.UISubViewList[page];
            UIPetListComponent petList = petListUI?.GetComponent<UIPetListComponent>();
            if (petList?.LastSelectItem == null)
            {
                return 0;
            }

            return petList.LastSelectItem.Id;
        }

        public static void OnClickPetItem(this UIPetFenJieTipComponent self, long petId)
        {
            self.LastSelectItem = self.PetComponent.GetPetInfoByID(petId);
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnSelectUI(self.LastSelectItem);
            }
            self.UpdateRewardGray();
        }

        public static void ShowRewardList(this UIPetFenJieTipComponent self, GameObject parent, int dropId, List<UIItemComponent> cache)
        {
            if (parent == null || self.UICommonItem == null)
            {
                return;
            }

            List<RewardItem> rewardItems = new List<RewardItem>();
            if (dropId != 0 && DropConfigCategory.Instance.Contain(dropId))
            {
                rewardItems = DropHelper.DropIDToShowItem(dropId);
            }

            int num = 0;
            for (int i = 0; i < rewardItems.Count; i++)
            {
                if (!ItemConfigCategory.Instance.Contain(rewardItems[i].ItemID))
                {
                    continue;
                }

                UIItemComponent itemComponent;
                if (num < cache.Count)
                {
                    itemComponent = cache[num];
                    itemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UICommonItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, parent);
                    go.transform.localScale = Vector3.one;
                    itemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                    itemComponent.HideItemName();
                    cache.Add(itemComponent);
                }

                itemComponent.UpdateItem(new BagInfo() { ItemID = rewardItems[i].ItemID, ItemNum = rewardItems[i].ItemNum }, ItemOperateEnum.None);
                itemComponent.Label_ItemNum.SetActive(false);
                num++;
            }

            for (int i = num; i < cache.Count; i++)
            {
                cache[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateRewardGray(this UIPetFenJieTipComponent self)
        {
            int dang = 0;
            if (self.LastSelectItem != null)
            {
                dang = PetHelper.GetPetFenJieDang(PetHelper.PetPingJia(self.LastSelectItem));
            }

            self.SetRewardListGray(self.RewardItemList_1, dang != 1);
            self.SetRewardListGray(self.RewardItemList_2, dang != 2);
            self.SetRewardListGray(self.RewardItemList_3, dang != 3);
            self.SetRewardListGray(self.RewardItemList_4, dang != 4);
        }

        public static void SetRewardListGray(this UIPetFenJieTipComponent self, List<UIItemComponent> cache, bool gray)
        {
            if (cache == null)
            {
                return;
            }

            for (int i = 0; i < cache.Count; i++)
            {
                UIItemComponent item = cache[i];
                if (item == null || item.GameObject == null || !item.GameObject.activeSelf)
                {
                    continue;
                }

                if (item.Image_ItemIcon != null)
                {
                    UICommonHelper.SetImageGray(item.Image_ItemIcon, gray);
                }

                if (item.Image_ItemQuality != null)
                {
                    UICommonHelper.SetImageGray(item.Image_ItemQuality, gray);
                }
            }
        }

        public static void OnBtn_Close(this UIPetFenJieTipComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetFenJieTip);
        }

        public static void OnBtn_FangSheng(this UIPetFenJieTipComponent self)
        {
            if (self.LastSelectItem == null)
            {
                return;
            }

            if (self.LastSelectItem.IsProtect)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("宠物已锁定！"));
                return;
            }

            if (self.LastSelectItem.PetStatus == 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("出战宠物不能分解！"));
                return;
            }

            if (self.LastSelectItem.PetStatus == 2)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请先停止家园散步！"));
                return;
            }

            if (self.LastSelectItem.PetStatus == 3)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请先从仓库取出！"));
                return;
            }

            if (self.PetComponent.TeamPetList.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("当前宠物存在于宠物天梯上阵中,不能分解！"));
                return;
            }

            if (self.PetComponent.PetFormations.Contains(self.LastSelectItem.Id))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("当前宠物存在于宠物副本上阵中,不能分解！"));
                return;
            }

            if (PetHelper.IsShenShou(self.LastSelectItem.ConfigId))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("神兽不能放生"));
                return;
            }

            if (PetHelper.HavePetHeXin(self.LastSelectItem))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请先卸下宠物之核！"));
                return;
            }

            if (PetHelper.HavePetEquip(self.LastSelectItem))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("当前宠物身上有对应的宠物装备，请先将宠物装备卸下在执行此操作！"));
                return;
            }

            PopupTipHelp.OpenPopupTip(self.DomainScene(), "", GameSettingLanguge.LoadLocalization("确定放生当前宠物么？\n放生宠物可以获得一定数量的宠物之核和宠物之尘哦！"),
                () => { self.PetComponent.RequestFenJie(self.LastSelectItem.Id).Coroutine(); },
                null).Coroutine();
        }
    }
}
