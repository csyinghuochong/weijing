using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIRoleGemComponent : Entity, IAwake
    {
        public Transform BuildingList;
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();
        public List<UIRoleGemHoleComponent> GemHoleList= new List<UIRoleGemHoleComponent>();

        public UI UIPageComponent;

        public UIItemComponent UIEquipItem;

        public BagInfo XiangQianItem;

        public int XiangQianIndex;
    }

    [ObjectSystem]
    public class UIRoleGemComponentAwakeSystem : AwakeSystem<UIRoleGemComponent>
    {
        public override void Awake(UIRoleGemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList").transform;
            self.ItemUIlist.Clear();
            self.GemHoleList.Clear();
            self.InitBagCell().Coroutine();
            GameObject equipItem = rc.Get<GameObject>("UIEquipItem");
            self.UIEquipItem = self.AddChild<UIItemComponent, GameObject>(equipItem);
            self.UIEquipItem.GameObject.SetActive(false);
            for (int i = 0; i < 4; i++)
            {
                GameObject gemItem = rc.Get<GameObject>($"UIRoleGemHole_{i}");
                self.GemHoleList.Add(self.AddChild<UIRoleGemHoleComponent, GameObject>(gemItem));
            }
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            uIPageViewComponent.OnSelectIndex(0);
            self.UIPageComponent = uiPage;

            self.XiangQianIndex = -1;
            self.XiangQianItem = null;
        }
    }

    public static class UIRoleGemComponentSystem
    {

        public static void ResetHole(this UIRoleGemComponent self)
        {
            for (int i = 0; i < self.GemHoleList.Count; i++)
            {
                self.GemHoleList[i].OnUpdateUI(0, 0, -1);
            }
        }

        public static void OnUpdateUI(this UIRoleGemComponent self)
        {
            self.XiangQianItem = null;
            self.XiangQianIndex = -1;
            self.ResetHole();
            self.UpdateBagUI();
            self.UIEquipItem.GameObject.SetActive(false);
        }

        //点击回调
        public static void OnClickPageButton(this UIRoleGemComponent self, int page)
        {
            //Log.Debug("page:   " + page);
            self.UpdateBagUI(page);
        }

        public static void OnClickHandler(this UIRoleGemComponent self, BagInfo bagInfo)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].SetSelected(bagInfo);
            }
        }

        public static void OnClickXiangQianItem(this UIRoleGemComponent self, BagInfo info)
        {
            self.XiangQianItem = info;
            if (info == null)
            {
                self.ResetHole();
                return;
            }
            self.UIEquipItem.GameObject.SetActive(true);
            self.UIEquipItem.UpdateItem(info, ItemOperateEnum.None);

            info.GemHole = string.IsNullOrEmpty(info.GemHole) ? "" : info.GemHole;
            info.GemIDNew = string.IsNullOrEmpty(info.GemIDNew) ? "" : info.GemIDNew;
            string[] gemHoles = info.GemHole.Split('_');
            string[] gemIds = info.GemIDNew.Split('_');

            for (int i = 0; i < 4; i++)
            {
                int gemHoleId = (gemHoles.Length > i && gemHoles[i]!="") ? int.Parse(gemHoles[i]) : 0;
                int gemId = (gemIds.Length > i && gemIds[i] != "") ? int.Parse(gemIds[i]) : 0;

                self.GemHoleList[i].OnUpdateUI(gemHoleId, gemId, i);
                self.GemHoleList[i].SetClickHandler(self.OnSetHoleIndex);
            }
        }

        public static void OnSetHoleIndex(this UIRoleGemComponent self,int index)
        { 
            self.XiangQianIndex = index;
            for (int i = 0; i < self.GemHoleList.Count; i++)
            {
                self.GemHoleList[i].SetSelected( i == index );
            }
        }

        //创建背包
        public static async ETTask InitBagCell(this UIRoleGemComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByType(0);
            int maxCount = GlobalValueConfigCategory.Instance.BagMaxCapacity;
            for (int i = 0; i < maxCount; i++)
            {
                if (i % 10 == 0)
                {
                    await TimerComponent.Instance.WaitAsync(1);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }
                GameObject go = GameObject.Instantiate(bundleGameObject);
                go.transform.SetParent(self.BuildingList);
                go.transform.localPosition = Vector3.zero;
                go.transform.localScale = Vector3.one;

                UIItemComponent uiitem = self.AddChild<UIItemComponent, GameObject>( go);
                uiitem.SetClickHandler((BagInfo bagInfo) => { self.OnClickHandler(bagInfo); });
                self.ItemUIlist.Add(uiitem);
                if (i < bagInfos.Count)
                {
                    uiitem.UpdateItem(bagInfos[i], ItemOperateEnum.XiangQianBag);
                }
            }
        }

        //属性背包
        public static void UpdateBagUI(this UIRoleGemComponent self, int itemType = -1)
        {
            if (self.ItemUIlist.Count == 0)
            {
                return;
            }
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].UpdateItem(null, ItemOperateEnum.XiangQianBag);
            }

            if (itemType == -1)
            {
                itemType = self.UIPageComponent.GetComponent<UIPageButtonComponent>().GetCurrentIndex();
            }
            int itemTypeEnum = ItemTypeEnum.ALL;
            switch (itemType)
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

            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetItemsByType(itemTypeEnum);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (i >= self.ItemUIlist.Count)
                    break;
                self.ItemUIlist[i].UpdateItem(bagInfos[i], ItemOperateEnum.XiangQianBag);
            }

            if (self.XiangQianItem != null)
            {
                BagInfo bagInfo = self.ZoneScene().GetComponent<BagComponent>().GetBagInfo(self.XiangQianItem.BagInfoID);
                self.OnClickXiangQianItem(bagInfo);
            }
        }

    }
}
