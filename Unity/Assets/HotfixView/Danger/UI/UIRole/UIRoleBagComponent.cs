using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleBagComponent : Entity, IAwake
    {
        public Transform BuildingList;
        public GameObject Btn_ZhengLi;
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
        public UIPageButtonComponent UIPageComponent;
    }

    [ObjectSystem]
    public class UIRoleBagComponentAwakeSystem : AwakeSystem<UIRoleBagComponent>
    {
        public override void Awake(UIRoleBagComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList").transform;
            self.ItemUIlist.Clear();

            self.Btn_ZhengLi = rc.Get<GameObject>("Btn_ZhengLi");
            self.Btn_ZhengLi.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ZhengLi(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>( "BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent  = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler( (int page)=>{
                self.OnClickPageButton(page);
            } );
            self.UIPageComponent = uIPageViewComponent;
            self.InitBagUIList().Coroutine();
        }
    }

    public static class UIRoleBagComponentSystem
    {
        public static void OnUpdateUI(this UIRoleBagComponent self)
        {
            self.UIPageComponent.OnSelectIndex(0);
        }

        public static void OnBtn_ZhengLi(this UIRoleBagComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendSortByLoc(ItemLocType.ItemLocBag).Coroutine();
        }

        //点击回调
        public static void OnClickPageButton(this UIRoleBagComponent self, int page)
        {
            if (self.ItemUIlist.Count < ComHelp.BagMaxCell)
            {
                return;
            }
            self.UpdateBagUI(page);
        }

        public static async ETTask  InitBagUIList(this UIRoleBagComponent self)
        {
            //Log.Debug("page:   " + page);
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(0);
            int opencell = bagComponent.GetTotalSpace();
            int maxCount = ComHelp.BagMaxCell;
            for (int i = 0; i < maxCount; i++)
            {
                if (i % 10 == 30)
                {
                    await TimerComponent.Instance.WaitAsync(500);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                go.transform.SetParent(self.BuildingList);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = Vector3.one;

                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(go);
                uIItemComponent.SetClickHandler((BagInfo bInfo) => { self.OnClickHandler(bInfo); });
                BagInfo bagInfo = i < bagInfos.Count ? bagInfos[i] : null;
                uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.Bag);
                uIItemComponent.UpdateLock(i < opencell);
                self.ItemUIlist.Add(uIItemComponent);
            }
        }

        public static void OnClickHandler(this UIRoleBagComponent self, BagInfo bagInfo)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].SetSelected(bagInfo);
            }
        }

        public static void OnBuyBagCell(this UIRoleBagComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int opencell = bagComponent.GetTotalSpace();
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].UpdateLock(i < opencell);
            }
        }

        //属性背包
        public static void UpdateBagUI(this UIRoleBagComponent self, int page)
        {
            if (page == -1)
            {
                page = self.UIPageComponent.GetCurrentIndex();
            }
            int itemTypeEnum = ItemTypeEnum.ALL;
            switch (page)
            {
                case 0:
                    itemTypeEnum = ItemTypeEnum.ALL;
                    break;
                case 1:
                    itemTypeEnum = ItemTypeEnum.Equipment;
                    break;
                case 2:
                    itemTypeEnum = ItemTypeEnum.Material;
                    break;
                case 3:
                    itemTypeEnum = ItemTypeEnum.Consume;
                    break;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetItemsByType(itemTypeEnum);
            int opencell = bagComponent.GetTotalSpace();
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                BagInfo bagInfo = i < bagInfos.Count ?  bagInfos[i] : null;
                self.ItemUIlist[i].UpdateItem(bagInfo, ItemOperateEnum.Bag);
                self.ItemUIlist[i].UpdateLock(i < opencell);
            }
        }

    }
}
