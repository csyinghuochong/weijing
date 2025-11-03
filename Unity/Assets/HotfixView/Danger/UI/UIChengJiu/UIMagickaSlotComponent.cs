using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIMagickaSlotComponent : Entity, IAwake, IDestroy
    {
        public GameObject RewardListNode;
        public GameObject UIMagickaSlotItem;

        public GameObject ItemListNode;
        public GameObject UICommonCostItem;

        public List<UIMagickaSlotItemComponent> UIMagickaSlotItemList = new List<UIMagickaSlotItemComponent>();

        public List<UICommonCostItemComponent> UICommonCostItemList = new List<UICommonCostItemComponent>();

        public int Position;
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

            self.OnInitUI();
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

        public static void OnClickLockHandler(this UIMagickaSlotComponent self, int position)
        {
            Log.ILog.Debug("OnClickLockHandler " + position);
            self.Position = position;

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