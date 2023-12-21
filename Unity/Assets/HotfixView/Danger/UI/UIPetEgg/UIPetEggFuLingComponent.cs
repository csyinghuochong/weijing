using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggFuLingComponent: Entity, IAwake
    {
        public GameObject Btn_Close;
        public GameObject ItemListNode;
        public GameObject FuLingBtn;

        public BagInfo BagInfo;
        public long EggId;
        public List<UIItemComponent> ItemList = new List<UIItemComponent>();
    }

    public class UIPetEggFuLingComponentAwakeSystem: AwakeSystem<UIPetEggFuLingComponent>
    {
        public override void Awake(UIPetEggFuLingComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.FuLingBtn = rc.Get<GameObject>("FuLingBtn");

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
            self.FuLingBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnFuLingBtn().Coroutine(); });
        }
    }

    public static class UIPetEggFuLingComponentSystem
    {
        public static void OnBtn_Close(this UIPetEggFuLingComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIPetEggFuLing);
        }

        public static async ETTask OnFuLingBtn(this UIPetEggFuLingComponent self)
        {
            if (self.EggId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择宠物蛋！");
                return;
            }

            int errorCode = await self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, self.EggId.ToString());

            if (errorCode != ErrorCode.ERR_Success)
            {
                return;
            }

            UIHelper.Remove(self.ZoneScene(), UIType.UIPetEggFuLing);
        }

        public static async ETTask UpdateItemList(this UIPetEggFuLingComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            List<BagInfo> bagInfos = bagComponent.GetItemsByLoc(ItemLocType.ItemLocBag);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (bagInfos[i].FuLing == 0 && itemConfig.ItemType == ItemTypeEnum.Consume && itemConfig.ItemSubType == 102)
                {
                    UIItemComponent uI = null;
                    if (number < self.ItemList.Count)
                    {
                        uI = self.ItemList[number];
                        uI.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject go = UnityEngine.Object.Instantiate(bundleGameObject);
                        UICommonHelper.SetParent(go, self.ItemListNode);
                        uI = self.AddChild<UIItemComponent, GameObject>(go);
                        uI.SetClickHandler((bagInfo) => { self.OnSelect(bagInfo); });
                        self.ItemList.Add(uI);
                    }

                    number++;
                    uI.UpdateItem(bagInfos[i], ItemOperateEnum.None);
                }
            }

            for (int i = number; i < self.ItemList.Count; i++)
            {
                self.ItemList[i].UpdateItem(null, ItemOperateEnum.None);
                self.ItemList[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelect(this UIPetEggFuLingComponent self, BagInfo bagInfo)
        {
            self.EggId = bagInfo.BagInfoID;
            for (int i = 0; i < self.ItemList.Count; i++)
            {
                self.ItemList[i].SetSelected(bagInfo);
            }
        }
    }
}