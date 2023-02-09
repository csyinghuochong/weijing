using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleZodiacComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonColse;
        public GameObject ZodiacList;
        public GameObject BtnItemTypeSet;

        public List<UIEquipSetItemComponent> EquipList = new List<UIEquipSetItemComponent>();
        public UIPageButtonComponent UIPageButtonComponent;

        public List<BagInfo> EquipInfoList = new List<BagInfo>();
        public ItemOperateEnum ItemOperateEnum;
        public int Occ;
    }

    [ObjectSystem]
    public class UIRoleZodiacComponentAwake : AwakeSystem<UIRoleZodiacComponent>
    {
        public override void Awake(UIRoleZodiacComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.EquipList.Clear();
            GameObject ZodiacList = rc.Get<GameObject>("ZodiacList");
            for (int i = 0; i < 12; i++)
            {
                GameObject go = ZodiacList.transform.Find("Equip_" + i).gameObject;
                UIEquipSetItemComponent uiitem = self.AddChild<UIEquipSetItemComponent, GameObject>(go);
                self.EquipList.Add(uiitem);
            }

            self.ZodiacList = rc.Get<GameObject>("ZodiacList");
            self.BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");

            self.ButtonColse = rc.Get<GameObject>("ButtonColse");
            self.ButtonColse.GetComponent<Button>().onClick.AddListener(() => 
            { 
                UIHelper.Remove(self.ZoneScene(), UIType.UIRoleZodiac);
                UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
                ui.GetComponent<UIRoleComponent>().OnCloseRoleZodiac();
            });

            //单选组件
            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent pageButton = uiPage.AddComponent<UIPageButtonComponent>();
            self.UIPageButtonComponent = pageButton;
            pageButton.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
        }
    }

    [ObjectSystem]
    public class UIRoleZodiacComponentDestroy : DestroySystem<UIRoleZodiacComponent>
    {
        public override void Destroy(UIRoleZodiacComponent self)
        {
            
        }
    }

    public static class UIRoleZodiacComponentSystem
    {

        public static void ResetEquipShow(this UIRoleZodiacComponent self)
        {
            for (int i = 0; i < self.EquipList.Count; i++)
            {
                self.EquipList[i].InitUI(1101);
            }
        }



        public static void OnInitUI(this UIRoleZodiacComponent self, List<BagInfo> equiplist, int occ, ItemOperateEnum itemOperateEnum)
        {
            self.EquipInfoList = equiplist;
            self.ItemOperateEnum = itemOperateEnum;
            self.Occ = occ;

            self.UIPageButtonComponent.OnSelectIndex(0);
        }

        public static void UpdateBagUI(this UIRoleZodiacComponent self, List<BagInfo> equiplist, int occ, ItemOperateEnum itemOperateEnum)
        {
            self.EquipInfoList = equiplist;
            self.ItemOperateEnum = itemOperateEnum;
            self.Occ = occ;

            self.OnClickPageButton(self.UIPageButtonComponent.CurrentIndex);
        }

        public static void OnClickPageButton(this UIRoleZodiacComponent self, int page)
        {

            self.ResetEquipShow();

            List<BagInfo> equiplist = self.EquipInfoList;
            for (int i = 0; i < equiplist.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equiplist[i].ItemID);
                if (itemConfig.EquipType != 101)
                {
                    continue;
                }

                int subType = itemConfig.ItemSubType / 100;
                if (page == 0 && subType != 11)
                {
                    continue;
                }
                if (page == 1 && subType != 12)
                {
                    continue;
                }
                if (page == 2 && subType != 13)
                {
                    continue;
                }

                self.EquipList[itemConfig.ItemSubType % 100 - 1].UpdateData(equiplist[i], self.Occ, self.ItemOperateEnum, equiplist);
            }
        }
    }
}