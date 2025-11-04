using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIMagickaSlotComponent : Entity, IAwake, IDestroy
    {

        public GameObject EquipSlot;
        public GameObject OpenSlot;

        public GameObject Btn_OpenSlot;

        public GameObject RewardListNode;
        public GameObject UIMagickaSlotItem;

        public GameObject ItemListNode;
        public GameObject UICommonCostItem;

        public List<UIMagickaSlotItemComponent> UIMagickaSlotItemList = new List<UIMagickaSlotItemComponent>();

        public List<UICommonCostItemComponent> UICommonCostItemList = new List<UICommonCostItemComponent>();

        public UIPageButtonComponent UIPageButton;

        public int Position = -1;
    }

    public class UIMagickaSlotComponentDestroy : DestroySystem<UIMagickaSlotComponent>
    {
        public override void Destroy(UIMagickaSlotComponent self)
        {
            
        }
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

            self.EquipSlot = rc.Get<GameObject>("EquipSlot");
            self.OpenSlot = rc.Get<GameObject>("OpenSlot");
            self.EquipSlot.SetActive(false);
            self.OpenSlot.SetActive(false);

            self.Btn_OpenSlot = rc.Get<GameObject>("Btn_OpenSlot");
            ButtonHelp.AddListenerEx(self.Btn_OpenSlot, () => { self.OnBtn_OpenSlot().Coroutine();  });

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;

            self.OnInitUI();
            self.OnUpdateUI();
            self.OnClickLockHandler(0);
            self.OnClickPageButton(0);
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
                uIMagickaSlotItem.InitData( i, self.OnClickLockHandler);
                self.UIMagickaSlotItemList.Add(uIMagickaSlotItem);
            }
        }

        public static void OnClickPageButton(this UIMagickaSlotComponent self, int page)
        {
            Log.ILog.Debug($"UIMagickaSlotComponent : {page}");
            self.EquipSlot.SetActive(page == 0);
            self.OpenSlot.SetActive(page == 1);
        }

        public static void OnUpdateUI(this UIMagickaSlotComponent self)
        {
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            for (int i = 0; i < self.UIMagickaSlotItemList.Count; i++)
            { 
                int curid = chengJiuComponent.GetCurrentMagickaSlotIdByPosition(i);
                self.UIMagickaSlotItemList[i].Image_Lock.SetActive( curid == 0 );
            }
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

            self.OnUpdateUI();
        }

        public static void OnClickLockHandler(this UIMagickaSlotComponent self, int position)
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
            if (curid == nexid)
            {
                Log.ILog.Debug("最高等级！！");
            }
            else
            {
                self.ShowCostItems(nexid);
            }
        }

        public static void ShowCostItems(this UIMagickaSlotComponent self, int nextd)
        {
            MagickaSlotConfig magickaSlotConfig = MagickaSlotConfigCategory.Instance.Get(nextd);

            int shownumber = 0;
            string[] costItem = magickaSlotConfig.OpenCostItem.Split("@");
            for (int i = 0; i < costItem.Length; i++)
            {
                string[] iteminfo = costItem[i].Split(";");
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
        }
    }
}