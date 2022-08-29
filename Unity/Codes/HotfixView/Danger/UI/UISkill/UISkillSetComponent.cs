using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UISkillSetComponent : Entity, IAwake
    {
        public GameObject SkillIconItem;
        public GameObject SkillIPositionSet;

        public GameObject SkillListNode;
        public GameObject ItemListNode;

        public List<UI> SkillUIList = new List<UI>();
        public List<UI> ItemUIList = new List<UI>();
        public List<GameObject> SkillSetIconList = new List<GameObject>();
        public GameObject SkillIconItemCopy;
        public Vector2 localPoint;
    }

    [ObjectSystem]
    public class UISkillSetComponentAwakeSystem : AwakeSystem<UISkillSetComponent>
    {
        public override void Awake(UISkillSetComponent self)
        {
            self.SkillUIList.Clear();
            self.ItemUIList.Clear();
            self.SkillSetIconList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SkillIconItem = rc.Get<GameObject>("SkillIconItem");
            self.SkillIconItem.SetActive(false);
            self.SkillIPositionSet = rc.Get<GameObject>("SkillIPositionSet");
            self.SkillListNode = rc.Get<GameObject>("SkillListNode");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.GetParent<UI>().OnUpdateUI = () => { self.UpdateSkillListUI().Coroutine(); };

            self.InitSkillSetIcons();
            self.OnSkillSetting();
            self.UpdateItemSkillUI().Coroutine();
        }
    }


    public static class UUISkillSetComponentSystem
    {

        public static void InitSkillSetIcons(this UISkillSetComponent self)
        {
            int childCount = self.SkillIPositionSet.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject go = GameObject.Instantiate(self.SkillIconItem);
                go.SetActive(false);
                UICommonHelper.SetParent(go, self.SkillIPositionSet.transform.GetChild(i).gameObject);
                self.SkillSetIconList.Add(go);
                //self.SkillIPositionSet.transform.GetChild(i).gameObject.GetComponent<Image>().enabled = false;
            }
        }

        public static void OnSkillSetting(this UISkillSetComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < self.SkillSetIconList.Count; i++)
            {
                GameObject itemgo = self.SkillSetIconList[i];
                GameObject addImage = itemgo.transform.parent.GetChild(0).gameObject;
                SkillPro skillPro = skillSetComponent.GetByPosition(i + 1);

                if (skillPro == null)
                {
                    addImage.GetComponent<Image>().CrossFadeAlpha(1, 0, false);
                    itemgo.SetActive(false);
                    continue;
                }
                addImage.GetComponent<Image>().CrossFadeAlpha(0, 0, false);
                itemgo.SetActive(true);
                if (skillPro.SkillSetType == (int)SkillSetEnum.Skill)
                {
                    BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkillID(skillPro.SkillID, bagComponent.GetEquipType()));
                    Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
                    itemgo.transform.Find("Img_Mask/Img_SkillIcon").GetComponent<Image>().sprite = sp;
                }
                if (skillPro.SkillSetType == (int)SkillSetEnum.Item)
                {
                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(skillPro.SkillID);
                    Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
                    itemgo.transform.Find("Img_Mask/Img_SkillIcon").GetComponent<Image>().sprite = sp;
                }
            }
        }

        public static async ETTask UpdateSkillListUI(this UISkillSetComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Skill/UISkillSetItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            List<SkillPro> skillPros = self.ZoneScene().GetComponent<SkillSetComponent>().SkillList;

            int learnNumber = 0;
            for (int i = 0; i < skillPros.Count; i++)
            {
                UI uI = null;
                if (skillPros[i].SkillSetType == (int)SkillSetEnum.Item)
                {
                    continue;
                }
                //没激活的不显示
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPros[i].SkillID);
                if (skillConfig.SkillLv == 0 || skillConfig.IsShow == 1)
                {
                    continue;
                }
                if (skillConfig.SkillType == (int)SkillTypeEnum.PassiveSkill
                    || skillConfig.SkillType == (int)SkillTypeEnum.PassiveAddProSkill)
                {
                    continue;
                }

                if (learnNumber < self.SkillUIList.Count)
                {
                    uI = self.SkillUIList[learnNumber];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.SkillListNode);
                    uI = self.AddChild<UI, string, GameObject>("skill_Item_" + i, skillItem);
                    uI.AddComponent<UISkillSetItemComponent>();
                    self.SkillUIList.Add(uI);
                }
                learnNumber++;
                uI.GetComponent<UISkillSetItemComponent>().OnUpdateUI(skillPros[i]);
            }
            for (int i = learnNumber; i < self.SkillUIList.Count; i++ )
            {
                self.SkillUIList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask UpdateItemSkillUI(this UISkillSetComponent self)
        {
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
                int itemID = bagInfos[i].ItemID;
                ItemConfig itemconf = ItemConfigCategory.Instance.Get(itemID);
             
                if (itemconf.ItemSubType == 101 && itemconf.ItemUsePar != "0" && itemconf.ItemUsePar != "")
                {
                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.ItemListNode);

                    UI ui_1 = self.AddChild<UI, string, GameObject>( "skillItem_" + i.ToString(), skillItem);
                    UIItemComponent uIItemComponent = ui_1.AddComponent<UIItemComponent>();
                    uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.SkillSet);
                    uIItemComponent.SetEventTrigger(true);
                    uIItemComponent.BeginDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.BeginDrag(binfo, pdata); };
                    uIItemComponent.DragingHandler = (BagInfo binfo, PointerEventData pdata) => { self.Draging(binfo, pdata); };
                    uIItemComponent.EndDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.EndDrag(binfo, pdata); };
                    self.ItemUIList.Add(ui_1);
                }
            }
        }

        public static void BeginDrag(this UISkillSetComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.SkillIconItemCopy = GameObject.Instantiate(self.SkillIconItem);
            self.SkillIconItemCopy.SetActive(true);
            UICommonHelper.SetParent(self.SkillIconItemCopy, UIEventComponent.Instance.UILayers[(int)UILayer.Low].gameObject);

            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(binfo.ItemID);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            self.SkillIconItemCopy.transform.Find("Img_Mask/Img_SkillIcon").GetComponent<Image>().sprite = sp;
        }

        public static void Draging(this UISkillSetComponent self, BagInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.SkillIconItemCopy.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out self.localPoint);

            self.SkillIconItemCopy.transform.localPosition = new Vector3(self.localPoint.x, self.localPoint.y, 0f);
        }

        public static void EndDrag(this UISkillSetComponent self, BagInfo binfo, PointerEventData pdata)
        {
            RectTransform canvas = self.SkillIconItemCopy.transform.parent.GetComponent<RectTransform>();
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pdata, results);

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < results.Count; i++)
            {
                string name = results[i].gameObject.name;
                if (!name.Contains("Danger_Skill_Icon_"))
                {
                    continue;
                }
                int index = int.Parse(name.Remove(0, 18));
                if (index < 9)
                {
                    continue;
                }
                skillSetComponent.SetSkillIdByPosition(binfo.ItemID, (int)SkillSetEnum.Item, index).Coroutine();
                break;
            }

            if (self.SkillIconItemCopy != null)
            {
                GameObject.Destroy(self.SkillIconItemCopy);
                self.SkillIconItemCopy = null;
            }
        }

        public static void UpdateSkillSetUI(this UISkillSetComponent self)
        {

        }
    }


}
