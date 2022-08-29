using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEggListComponent : Entity, IAwake
    {
        public GameObject TextTip;
        public GameObject ItemNodeList;
        public GameObject PetNodeList;

        public GameObject IconItemDrag;
        public List<UIPetEggListItemComponent> PetList = new List<UIPetEggListItemComponent> ();
    }

    public class UIPetEggListComponentAwakeSystem : AwakeSystem<UIPetEggListComponent>
    {
        public override void Awake(UIPetEggListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextTip = rc.Get<GameObject>("TextTip");
            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.PetNodeList = rc.Get<GameObject>("PetNodeList");
            self.IconItemDrag = rc.Get<GameObject>("IconItemDarg");
            self.IconItemDrag.SetActive(false);

            self.PetList.Clear();
            for (int i = 0; i < self.PetNodeList.transform.childCount; i++)
            {
                GameObject go = self.PetNodeList.transform.GetChild(i).gameObject;
                UIPetEggListItemComponent uIPetEggListItem = self.AddChild<UIPetEggListItemComponent, GameObject>(go);
                self.PetList.Add(uIPetEggListItem);

                uIPetEggListItem.BeginDragHandler = (int binfo, PointerEventData pdata) => { self.PetEggBeginDrag(binfo, pdata); };
                uIPetEggListItem.DragingHandler = (int binfo, PointerEventData pdata) => { self.PetEggDraging(binfo, pdata); };
                uIPetEggListItem.EndDragHandler = (int binfo, PointerEventData pdata) => { self.PetEggEndDrag(binfo, pdata); };
            }
            self.UpdateEggItemUI().Coroutine();
            self.UpdatePetEggUI();
        }
    }

    public static class UIPetEggListComponentSystem
    {

        public static void OnUpdateUI(this UIPetEggListComponent self)
        {
            self.UpdatePetEggUI();
        }

        public static async ETTask UpdateEggItemUI(this UIPetEggListComponent self)
        {
            UICommonHelper.DestoryChild(self.ItemNodeList);

            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Role/UIItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<BagInfo> bagInfos = self.ZoneScene().GetComponent<BagComponent>().GetBagList();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemSubType == 102 && itemConfig.ItemType==1)
                {
                    //continue;

                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.ItemNodeList);

                    UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(skillItem);
                    uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.SkillSet);
                    uIItemComponent.SetEventTrigger(true);
                    uIItemComponent.BeginDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    uIItemComponent.DragingHandler = (BagInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    uIItemComponent.EndDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    //uIItemComponent.Image_ItemButton.name = $"RolePetEggUIItem_{bagInfos[i].BagInfoID}";
                }
            }
        }

        public static  void UpdatePetEggUI(this UIPetEggListComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < self.PetList.Count; i++)
            {
                self.PetList[i].OnUpdateUI( petComponent.RolePetEggs[i], i);
            }
        }

        public static void BeginDrag(this UIPetEggListComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IconItemDrag.SetActive(true);
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(binfo.ItemID);
            GameObject icon = self.IconItemDrag.transform.Find("ImageIcon").gameObject;
            Sprite sp =  ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            icon.GetComponent<Image>().sprite = sp;
            UICommonHelper.SetParent(self.IconItemDrag, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);
        }

        public static void Draging(this UIPetEggListComponent self, BagInfo binfo, PointerEventData pdata)
        {
            Vector2 localPoint;
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.IconItemDrag.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static async ETTask RequestHatch(this UIPetEggListComponent self, int index, BagInfo bagInfo)
        {
            RolePetEgg oldEgg = self.PetList[index].RolePetEgg;
            if (oldEgg != null && oldEgg.ItemId > 0)
            {
                return;
            }
            C2M_RolePetEggPut c2M_RolePetEggHatch = new C2M_RolePetEggPut()
            {
                Index = index,
                BagInfoId = bagInfo.BagInfoID,
            };
            M2C_RolePetEggPut m2C_RolePetChouKaResponse = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetEggHatch) as M2C_RolePetEggPut;
            if (m2C_RolePetChouKaResponse.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            petComponent.RolePetEggs[index] = m2C_RolePetChouKaResponse.RolePetEgg;

            self.UpdateEggItemUI().Coroutine();
            self.UpdatePetEggUI();
        }

        public static void EndDrag(this UIPetEggListComponent self, BagInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("UIPetEggListItem"))
                {
                    continue;
                }
                int index = int.Parse(name.Substring(name.Length - 1, 1));
                self.RequestHatch(index, binfo).Coroutine();
                break;
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GetParent<UI>().GameObject);
            self.IconItemDrag.SetActive(false);
        }

        public static void PetEggBeginDrag(this UIPetEggListComponent self, int binfo, PointerEventData pdata)
        {
            self.IconItemDrag.SetActive(true);
            self.IconItemDrag.transform.localScale = Vector3.one * 2f;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(petComponent.RolePetEggs[binfo].ItemId);
            GameObject icon = self.IconItemDrag.transform.Find("ImageIcon").gameObject;
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            icon.GetComponent<Image>().sprite = sp;
            UICommonHelper.SetParent(self.IconItemDrag, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);
        }

        public static void PetEggDraging(this UIPetEggListComponent self, int binfo, PointerEventData pdata)
        {
            Vector2 localPoint;
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);

            self.IconItemDrag.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
        }

        public static async ETTask RequestXieXia(this UIPetEggListComponent self, int binfo)
        {
            C2M_RolePetEggPutOut request = new C2M_RolePetEggPutOut() { Index = binfo };
            M2C_RolePetEggPutOut respose = (M2C_RolePetEggPutOut)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            petComponent.RolePetEggs[binfo] = respose.RolePetEgg;
            self.UpdateEggItemUI().Coroutine();
            self.UpdatePetEggUI();
        }

        public static void PetEggEndDrag(this UIPetEggListComponent self, int binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.IconItemDrag.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("RolePetEggUIItem"))
                {
                    continue;
                }
                //long bagInfoId = long.Parse(name.Split('_')[1]);
                self.RequestXieXia(binfo).Coroutine();
                break;
            }
            UICommonHelper.SetParent(self.IconItemDrag, self.GetParent<UI>().GameObject);
            self.IconItemDrag.SetActive(false);
        }
    }
}
