using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UIMagickaSlotComponent : Entity, IAwake, IDestroy
    {

        public GameObject Btn_OneKey;
        public GameObject ImageLockNode;
        public UIItemComponent UICommonItem;

        public GameObject SlotProItem;
        public GameObject ImageExpValue;
        public GameObject Text_ZiZhiValue;
        public GameObject Text_ZiZhiName;
        public GameObject Text_SkillDesc;

        /// <summary>
        /// 注入列表
        /// </summary>
        public GameObject BuildingList_2;
        public GameObject ScrollView_2;
        public GameObject Btn_ZhuRu;
        public List<UIItemComponent> ZhuRuItemUIlist = new List<UIItemComponent>();
        public List<long> HuiShouIdlist = new List<long>();

        /// <summary>
        /// 装备列表
        /// </summary>
        public GameObject ScrollView_1;
        public GameObject BuildingList_1;
        public GameObject Btn_Equip;
        public List<UIItemComponent> EquiItemUIlist = new List<UIItemComponent>();
        public long EquipInfoId;

        public GameObject NodeOpen;
        public GameObject NodeZhuRu;

        public GameObject EquipSlot;
        public GameObject OpenSlot;

        public Text Text_NeedTotalLevel;
        public GameObject Btn_OpenSlot;

        public GameObject RewardListNode;
        public GameObject UIMagickaSlotItem;

        public GameObject ItemListNode;
        public GameObject UICommonCostItem;

        public List<UIMagickaSlotItemComponent> UIMagickaSlotItemList = new List<UIMagickaSlotItemComponent>();

        public List<UICommonCostItemComponent> UICommonCostItemList = new List<UICommonCostItemComponent>();

        public UIPageButtonComponent UIPageButton;

        public BagComponent BagComponent;

        public int Position = -1;

        public bool IsDrag;
        public long ClickTime;

        public bool IsHoldDown;
    }

    public class UIMagickaSlotComponentAwake : AwakeSystem<UIMagickaSlotComponent>
    {
        public override void Awake(UIMagickaSlotComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.UIMagickaSlotItem = rc.Get<GameObject>("UIMagickaSlotItem");
            self.UIMagickaSlotItem.SetActive(false);

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.UICommonCostItem = rc.Get<GameObject>("UICommonCostItem");
            self.UICommonCostItem.SetActive(false);

            self.SlotProItem = rc.Get<GameObject>("SlotProItem");
            self.ImageExpValue = rc.Get<GameObject>("ImageExpValue");
            self.Text_ZiZhiValue = rc.Get<GameObject>("Text_ZiZhiValue");
            self.Text_ZiZhiName = rc.Get<GameObject>("Text_ZiZhiName");
            self.Text_SkillDesc = rc.Get<GameObject>("Text_SkillDesc");

            self.EquipSlot = rc.Get<GameObject>("EquipSlot");
            self.OpenSlot = rc.Get<GameObject>("OpenSlot");
            self.EquipSlot.SetActive(false);
            self.OpenSlot.SetActive(false);

            self.NodeOpen = rc.Get<GameObject>("NodeOpen");
            self.NodeZhuRu = rc.Get<GameObject>("NodeZhuRu");
            self.NodeOpen.SetActive(false);
            self.NodeZhuRu.SetActive(false);

            self.ScrollView_2 = rc.Get<GameObject>("ScrollView_2");
            self.BuildingList_2 = rc.Get<GameObject>("BuildingList_2");
            self.Btn_ZhuRu = rc.Get<GameObject>("Btn_ZhuRu");
            ButtonHelp.AddListenerEx(self.Btn_ZhuRu, () => { self.OnBtn_ZhuRu().Coroutine(); });

            self.Btn_OneKey = rc.Get<GameObject>("Btn_OneKey");
            ButtonHelp.AddListenerEx(self.Btn_OneKey, self.OnBtn_OneKey);


            self.ScrollView_1 = rc.Get<GameObject>("ScrollView_1");
            self.BuildingList_1 = rc.Get<GameObject>("BuildingList_1");
            self.Btn_Equip = rc.Get<GameObject>("Btn_Equip");
            ButtonHelp.AddListenerEx(self.Btn_Equip, () => { self.OnBtn_Equip().Coroutine(); });

            self.Btn_OpenSlot = rc.Get<GameObject>("Btn_OpenSlot");
            ButtonHelp.AddListenerEx(self.Btn_OpenSlot, () => { self.OnBtn_OpenSlot().Coroutine();  });

            self.Text_NeedTotalLevel = rc.Get<GameObject>("Text_NeedTotalLevel").GetComponent<Text>();

            GameObject uiitem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(uiitem);

            self.ImageLockNode = rc.Get<GameObject>("ImageLockNode");
            self.ImageLockNode.SetActive(false);

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.OnInitUI();
            self.OnUpdateSlotUI();
            //self.OnClickSlotHandler(0, -1);

            DataUpdateComponent.Instance.AddListener(DataType.HuiShouSelect, self);
            DataUpdateComponent.Instance.AddListener(DataType.EquipWear, self);
        }
    }

    public class UIMagickaSlotComponentDestroy : DestroySystem<UIMagickaSlotComponent>
    {
        public override void Destroy(UIMagickaSlotComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.HuiShouSelect, self);
            DataUpdateComponent.Instance.RemoveListener(DataType.EquipWear, self);
        }
    }

    public static class UIMagickaSlotComponentSystem
    {
        public static void OnInitUI(this UIMagickaSlotComponent self)
        {
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            int number = chengJiuComponent.GetMaxMagickaSlotIdPosition();

            for (int i = 0; i < number; i++)
            {
                GameObject skillItem = GameObject.Instantiate(self.UIMagickaSlotItem);
                skillItem.SetActive(true);
                UICommonHelper.SetParent(skillItem, self.RewardListNode);
                UIMagickaSlotItemComponent uIMagickaSlotItem =  self.AddChild<UIMagickaSlotItemComponent, GameObject>(skillItem);
                uIMagickaSlotItem.InitData( i, self.OnClickSlotHandler);
                self.UIMagickaSlotItemList.Add(uIMagickaSlotItem);
            }
            self.UIMagickaSlotItemList[0].OnClickImage_Lock();
        }

        public static void OnClickPageButton(this UIMagickaSlotComponent self, int page)
        {
            Log.ILog.Debug($"UIMagickaSlotComponent : {page}");
            self.EquipSlot.SetActive(page == 0);
            self.OpenSlot.SetActive(page == 1);

            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            int curid = chengJiuComponent.GetCurrentMagickaSlotIdByPosition(self.Position);

            switch (page)
            {
                case 0:
                    self.UpdateEquipList();
                    break;
                case 1:
                    self.NodeOpen.SetActive(true);
                    string btntext = curid == 0 ? "开启位置" : "升级";
                    btntext = GameSettingLanguge.LoadLocalization(btntext);
                    self.Btn_OpenSlot.transform.Find("Text").GetComponent<Text>().text = btntext;
                    //self.NodeOpen.SetActive(curid == 0);
                    //self.NodeZhuRu.SetActive(curid != 0);
                    //self.UpdateZhuruList();
                    break;
                default:
                    break;
            }
        }

        public static void OnEquipWear(this UIMagickaSlotComponent self)
        {
            self.OnUpdateSlotUI();
            self.OnClickSlotHandler(self.Position, 0);
        }

        public static void UpdateEquipList(this UIMagickaSlotComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> allInfos = new List<BagInfo>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Equipment));
            int number = 0;
            for (int i = 0; i < allInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(allInfos[i].ItemID );
                if (itemConfig.EquipType!= 401)
                {
                    continue;
                }


                int subtype = itemConfig.ItemSubType - 4001; //0 1 2
                int curtype = self.Position / 3;
                if (curtype != subtype && curtype!=2)
                {
                    continue;
                }

                UIItemComponent uI_1 = null;
                if (number < self.EquiItemUIlist.Count)
                {
                    uI_1 = self.EquiItemUIlist[number];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList_1);
                    go.transform.localScale = Vector3.one;
                    uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                    uI_1.ClickItemHandler = (BagInfo baginfo) => { self.OnClickPaiMaiItem(baginfo.BagInfoID); };
                    self.EquiItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.None);
                uI_1.HideItemName();
                number++;
            }

            for (int i = number; i < self.EquiItemUIlist.Count; i++)
            {
                self.EquiItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static void UpdateZhuruList(this UIMagickaSlotComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<BagInfo> allInfos = new List<BagInfo>();
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            //allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Consume));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Material));
            allInfos.AddRange(bagComponent.GetItemsByType(ItemTypeEnum.Equipment));

            int number = 0;
            for (int i = 0; i < allInfos.Count; i++)
            {
                if (!ConfigHelper.MagicAddShieldExp.ContainsKey(allInfos[i].ItemID))
                {
                    continue;
                }

                UIItemComponent uI_1 = null;
                if (number < self.ZhuRuItemUIlist.Count)
                {
                    uI_1 = self.ZhuRuItemUIlist[number];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList_2);
                    go.transform.localScale = Vector3.one;
                    uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                    uI_1.SetEventTrigger(true);
                    uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                    uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };
                    uI_1.BeginDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnBeginDrag(binfo, pdata); };
                    uI_1.DragingHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnDraging(binfo, pdata); };
                    uI_1.EndDragHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnEndDrag(binfo, pdata); };
                    self.ZhuRuItemUIlist.Add(uI_1);
                }
                uI_1.UpdateItem(allInfos[i], ItemOperateEnum.HuishouBag);
                uI_1.HideItemName();
                number++;
            }

            for (int i = number; i < self.ZhuRuItemUIlist.Count; i++)
            {
                self.ZhuRuItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static void OnBeginDrag(this UIMagickaSlotComponent self, BagInfo bagInfo, PointerEventData pdata)
        {
            self.ScrollView_2.GetComponent<ScrollRect>().OnBeginDrag(pdata);
            self.IsDrag = true;
        }
        public static void OnDraging(this UIMagickaSlotComponent self, BagInfo bagInfo, PointerEventData pdata)
        {
            self.ScrollView_2.GetComponent<ScrollRect>().OnDrag(pdata);
            self.IsDrag = true;
        }
        public static void OnEndDrag(this UIMagickaSlotComponent self, BagInfo bagInfo, PointerEventData pdata)
        {
            self.ScrollView_2.GetComponent<ScrollRect>().OnEndDrag(pdata);
            self.IsDrag = false;
        }
        public static async ETTask OnPointerDown(this UIMagickaSlotComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            self.ClickTime = TimeHelper.ClientNow();
            await TimerComponent.Instance.WaitAsync(500);
            if (!self.IsHoldDown || self.IsDrag)
                return;
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = binfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void OnPointerUp(this UIMagickaSlotComponent self, BagInfo binfo, PointerEventData pdata)
        {
            if (TimeHelper.ClientNow() - self.ClickTime < 200)
            {
                HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{binfo.BagInfoID}");
            }
            self.IsHoldDown = false;
        }

        public static void OnHuiShouSelect(this UIMagickaSlotComponent self, string dataparams)
        {
            self.UpdateHuiShouInfo(dataparams);
            self.UpdateBagSelected();
        }

        public static void UpdateHuiShouInfo(this UIMagickaSlotComponent self, string dataparams)
        {
            string[] huishouInfo = dataparams.Split('_');
            BagInfo bagInfo = self.BagComponent.GetBagInfo(long.Parse(huishouInfo[1]));
            if (bagInfo == null)
            {
                return;
            }

            //1新增  2移除 
            if (!self.HuiShouIdlist.Contains(bagInfo.BagInfoID))
            {
                self.HuiShouIdlist.Add(bagInfo.BagInfoID);
            }
            else
            {
                self.HuiShouIdlist.Remove(bagInfo.BagInfoID);
            }
        }

        public static void UpdateBagSelected(this UIMagickaSlotComponent self)
        {
            for (int i = 0; i < self.ZhuRuItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.ZhuRuItemUIlist[i];
                BagInfo bagInfo = uIItemComponent.Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }
                bool have = self.HuiShouIdlist.Contains( bagInfo.BagInfoID);
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static void OnClickPaiMaiItem(this UIMagickaSlotComponent self, long paimaiId)
        {
            self.EquipInfoId = paimaiId;
            for (int i = 0; i < self.EquiItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.EquiItemUIlist[i];
                BagInfo bagInfo = uIItemComponent.Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }
                bool have = self.EquipInfoId == bagInfo.BagInfoID;
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static void OnUpdateSlotUI(this UIMagickaSlotComponent self)
        {
            for (int i = 0; i < self.UIMagickaSlotItemList.Count; i++)
            {
                self.UIMagickaSlotItemList[i].OnUpdateUI();
            }
        }

        public static void OnBtn_OneKey(this UIMagickaSlotComponent self)
        {
            self.HuiShouIdlist.Clear();

            for (int i = 0; i < self.ZhuRuItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.ZhuRuItemUIlist[i];
                BagInfo bagInfo = uIItemComponent.Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }
                self.HuiShouIdlist.Add(bagInfo.BagInfoID);
            }

            self.UpdateBagSelected();
        }

        public static async ETTask OnBtn_ZhuRu(this UIMagickaSlotComponent self)
        {
            int error = await  self.ZoneScene().GetComponent<ChengJiuComponent>().RequestMagicZhuru(self.Position, self.HuiShouIdlist);
            if (error != ErrorCode.ERR_Success || self.IsDisposed)
            {
                return;
            }
            self.OnClickSlotHandler(self.Position, 1);
            await ETTask.CompletedTask;
        }

        public static async ETTask OnBtn_Equip(this UIMagickaSlotComponent self)
        {
            if (self.EquipInfoId == 0)
            {
                return;
            }
            if (self.Position < 0)
            {
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo = bagComponent.GetBagInfo(self.EquipInfoId);
            if (bagInfo == null)
            {
                return;
            }

            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            MagickaSlotInfo magickaSlotInfo = chengJiuComponent.GetCurrentMagickaSlotByPosition(self.Position);
            int curid = magickaSlotInfo != null ? magickaSlotInfo.SlotId : 0;
            if (curid <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip(ErrorHelp.Instance.GetHint(ErrorCode.ERR_MagicNotOpen));
                return;
            }
            Log.ILog.Debug($"OnBtn_Equip:  {self.EquipInfoId}");
            await bagComponent.SendWearMagicEquip(3, bagInfo, self.Position);
        }

        public static async ETTask OnBtn_OpenSlot(this UIMagickaSlotComponent self)
        {
            if (self.Position < 0)
            {
                return;
            }

            long instanceid = self.InstanceId;
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            int errorcode = await chengJiuComponent.RequestOpenMagicka(self.Position);
            if (instanceid != self.InstanceId || errorcode != ErrorCode.ERR_Success)
            {
                return;
            }

            self.OnUpdateSlotUI();
            self.OnClickSlotHandler(self.Position, 1);
        }

        public static void OnClickSlotHandler(this UIMagickaSlotComponent self, int position, int pagetype)
        {
            Log.ILog.Debug("OnClickLockHandler " + position);
            self.Position = position;

            for (int i = 0; i < self.UIMagickaSlotItemList.Count; i++)
            {
                self.UIMagickaSlotItemList[i].SetSelected(position == i);
            }

            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            int curid = chengJiuComponent.GetCurrentMagickaSlotIdByPosition(position);
            int nexid = chengJiuComponent.GetNextMagickaSlotIdByPosition(position);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo =  bagComponent.GetMagicEquipBySubType( ItemLocType.ItemLocEquip, self.Position );

            if (curid == nexid)
            {
                Log.ILog.Debug("最高等级！！");
            }
            else
            {
                self.ShowCostItems(nexid);
            }
            self.ShowSlotPros();

            //pagetype==-1初始
            //pagetype==-2切换
            //0装备
            //1开启升级

            int newpage = 0;
            if (pagetype == 0 || pagetype == 1)
            {
                newpage = pagetype;
            }
            else if (pagetype == -1)
            {
                newpage = curid > 0 ? 0 : 1;
            }
            else 
            {
                newpage = curid > 0 ? self.UIPageButton.CurrentIndex : 1;

                if (curid > 0 && bagInfo == null)
                {
                    newpage = 0;
                }
                if (newpage < 0)
                {
                    newpage = 0;
                }
            }

            if (!self.UIPageButton.OnSelectIndex(newpage))
            {
                self.OnClickPageButton(newpage);
            }
        }

        public static void ShowSlotPros(this UIMagickaSlotComponent self)
        {
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            MagickaSlotInfo magickaSlotInfo = chengJiuComponent.GetCurrentMagickaSlotByPosition(self.Position);
            int curid = magickaSlotInfo != null ? magickaSlotInfo.SlotId : 0;
           
            long curex = magickaSlotInfo != null ? magickaSlotInfo.Exp : 0;
            int nexid = chengJiuComponent.GetNextMagickaSlotIdByPosition(self.Position);
            MagickaSlotConfig magickaSlotConfig = MagickaSlotConfigCategory.Instance.Get(nexid);

            self.SlotProItem.SetActive(true);
            if (magickaSlotConfig.NeedExp <= 0)
            {
                self.ImageExpValue.GetComponent<Image>().fillAmount = 0f;
            }
            else
            {
                self.ImageExpValue.GetComponent<Image>().fillAmount = curex * 1f / magickaSlotConfig.NeedExp;
            }
            self.Text_ZiZhiValue.GetComponent<Text>().text = $"{curex}/{magickaSlotConfig.NeedExp}";
            self.Text_ZiZhiName.GetComponent<Text>().text = magickaSlotConfig.GetDes();

            BagInfo bagInfo = self.ZoneScene().GetComponent<BagComponent>().GetMagicEquipBySubType(ItemLocType.ItemLocEquip, self.Position);
            if (bagInfo != null)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                self.Text_SkillDesc.GetComponent<Text>().text = itemConfig.GetItemDes();
                self.UICommonItem.UpdateItem(bagInfo, ItemOperateEnum.None);
                self.UICommonItem.Image_ItemIcon.SetActive(true);
            }
            else
            {
                self.Text_SkillDesc.GetComponent<Text>().text = string.Empty;
                self.UICommonItem.Image_ItemIcon.SetActive(false);
            }
            self.ImageLockNode.SetActive(curid== 0);
            self.UICommonItem.Image_Binding.SetActive(false);
            Text text = self.UICommonItem.Label_ItemName.GetComponent<Text>();
            text.text = magickaSlotConfig.GetName();
            text.fontSize = 40;
            text.color = Color.white;
        }

        public static void ShowCostItems(this UIMagickaSlotComponent self, int nextd)
        {
            MagickaSlotConfig magickaSlotConfig = MagickaSlotConfigCategory.Instance.Get(nextd);

            int shownumber = 0;
            string[] costItem = magickaSlotConfig.OpenCostItem.Split('@');
            for (int i = 0; i < costItem.Length; i++)
            {
                string[] iteminfo = costItem[i].Split(';');
                if (iteminfo.Length != 2)
                {
                    continue;
                }

                if (shownumber >= self.UICommonCostItemList.Count)
                {
                    GameObject commonCostItem2 = GameObject.Instantiate( self.UICommonCostItem );
                    UICommonCostItemComponent uICommonCostItem = self.AddChild<UICommonCostItemComponent, GameObject>(commonCostItem2);
                    self.UICommonCostItemList.Add(uICommonCostItem);
                    UICommonHelper.SetParent(commonCostItem2, self.ItemListNode);
                }

                self.UICommonCostItemList[shownumber].GameObject.SetActive(true);
                self.UICommonCostItemList[shownumber].UpdateItem(int.Parse(iteminfo[0]), int.Parse(iteminfo[1]));
                shownumber++;
            }

            for (int i =shownumber; i < self.UICommonCostItemList.Count; i++)
            {
                self.UICommonCostItemList[i].GameObject.SetActive(false);
            }

            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            int totallevel = chengJiuComponent.GetCurrentMagickaTotalLevel();
            string str1 = GameSettingLanguge.LoadLocalization("总等级达到");
            string str2 = GameSettingLanguge.LoadLocalization("级");
            if (totallevel < magickaSlotConfig.NeedTotalLevel)
            {
                self.Text_NeedTotalLevel.text = $"<color=#B6FF39>{str1}<color=#FF0000>{totallevel}/{magickaSlotConfig.NeedTotalLevel}</color>{str2}</color>";
            }
            else
            {
                self.Text_NeedTotalLevel.text = $"<color=#B6FF39>{str1}{totallevel}/{magickaSlotConfig.NeedTotalLevel}{str2}</color>";
            }
            
        }
    }
}