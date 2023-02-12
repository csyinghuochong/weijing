using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UIShouJiSelectComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
        public GameObject BuildingList;
        public GameObject ButtonTunShi;

        public List<UIItemComponent> UIItems = new List<UIItemComponent> ();
        public ShoujiComponent ShoujiComponent;
        public int ShouJIId;
    }

    [ObjectSystem]
    public class UIShouJiSelectEventComponentAwake : AwakeSystem<UIShouJiSelectComponent>
    {
        public override void Awake(UIShouJiSelectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonTunShi = rc.Get<GameObject>("ButtonTunShi");
            ButtonHelp.AddListenerEx(self.ButtonTunShi, () =>{
                self.OnButtonTunShi().Coroutine();
            });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIShouJiSelect);
            });

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.ShoujiComponent = self.ZoneScene().GetComponent<ShoujiComponent>();
        }
    }

    public static class UIShouJiSelectEventSystem
    {
        public static void OnInitUI(this UIShouJiSelectComponent self, int shouiId)
        {
            self.ShouJIId = shouiId;
            ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(shouiId);
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> allInfos = (bagComponent.GetBagList());

            for (int i = 0; i < allInfos.Count; i++)
            {
                if (allInfos[i].ItemID != shouJiItemConfig.ItemID)
                {
                    continue;
                }

                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList);
                go.transform.localScale = Vector3.one;

                UIItemComponent uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                uI_1.SetEventTrigger(false);
                uI_1.SetClickHandler(self.OnSelectItem);
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.None);
                uI_1.Label_ItemName.SetActive(true);
                uI_1.Image_XuanZhong.SetActive(false);
                self.UIItems.Add(uI_1);
            }
        }

        public static async ETTask OnButtonTunShi(this UIShouJiSelectComponent self)
        {
            KeyValuePairInt keyValuePairInt = self.ShoujiComponent.GetTreasureInfo(self.ShouJIId);
            
            ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(self.ShouJIId);
            long number = keyValuePairInt != null ? keyValuePairInt.Value : 0;
            List<long> selects = self.GetSelectItems();

            if (selects.Count == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择道具！");
                return;
            }
            if (number + selects.Count > shouJiItemConfig.AcitveNum)
            {
                FloatTipManager.Instance.ShowFloatTip("吞噬数量超出！");
                return;
            }

            C2M_ShouJiTreasureRequest  request = new C2M_ShouJiTreasureRequest() { ItemIds = selects, ShouJiId = self.ShouJIId };
            M2C_ShouJiTreasureResponse response = (M2C_ShouJiTreasureResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
          
            if (response.Error == ErrorCore.ERR_Success)
            {
                self.ShoujiComponent.OnShouJiTreasure(self.ShouJIId, response.ActiveNum);
            }

            UI uI = UIHelper.GetUI(self.ZoneScene(), UIType.UIShouJi);
            uI.GetComponent<UIShouJiComponent>().OnShouJiTreasure();
            UIHelper.Remove(self.ZoneScene(), UIType.UIShouJiSelect);

            FloatTipManager.Instance.ShowFloatTip("吞噬道具完成。");
        }

        public static List<long> GetSelectItems(this UIShouJiSelectComponent self)
        { 
            List<long> ids =  new List<long>();
            for (int i = 0; i < self.UIItems.Count; i++)
            {
                if (self.UIItems[i].Image_XuanZhong.activeSelf)
                {
                    ids.Add(self.UIItems[i].Baginfo.BagInfoID);
                }
            }
            return ids;
        }

        public static void OnSelectItem(this UIShouJiSelectComponent self, BagInfo bagInfo)
        {
            for (int i = 0; i < self.UIItems.Count; i++)
            {
                if (self.UIItems[i].Baginfo.BagInfoID == bagInfo.BagInfoID)
                {
                    bool selected = self.UIItems[i].Image_XuanZhong.activeSelf;
                    self.UIItems[i].Image_XuanZhong.SetActive(!selected);
                }
            }
        }
    }
}