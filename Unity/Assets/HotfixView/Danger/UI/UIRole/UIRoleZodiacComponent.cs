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
        public GameObject LinkShowSet;

        public List<UIEquipSetItemComponent> EquipList = new List<UIEquipSetItemComponent>();
        public UIPageButtonComponent UIPageButtonComponent;

        public List<BagInfo> EquipInfoList = new List<BagInfo>();
        public ItemOperateEnum ItemOperateEnum;
        public int Occ;
        public List<string> AssetPath = new List<string>();
    }

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
            self.LinkShowSet = rc.Get<GameObject>("LinkShowSet");

            self.ButtonColse = rc.Get<GameObject>("ButtonColse");
            self.ButtonColse.GetComponent<Button>().onClick.AddListener(() => 
            { 
                UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIRole);
                ui.GetComponent<UIRoleComponent>().OnCloseRoleZodiac();
                UIHelper.Remove(self.ZoneScene(), UIType.UIRoleZodiac);
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


    public class UIRoleZodiacComponentDestroy : DestroySystem<UIRoleZodiacComponent>
    {
        public override void Destroy(UIRoleZodiacComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
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

            for (int i = 0; i < self.EquipList.Count; i++) {

                //改变底框
                if (page == 0)
                {
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, "ItemQuality_2");
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    self.EquipList[i].GameObject.transform.Find("Img_EquipBack").GetComponent<Image>().sprite = sp;
                }

                if (page == 1)
                {
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, "ItemQuality_3");
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    self.EquipList[i].GameObject.transform.Find("Img_EquipBack").GetComponent<Image>().sprite = sp;
                }

                if (page == 2)
                {
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, "ItemQuality_4");
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    self.EquipList[i].GameObject.transform.Find("Img_EquipBack").GetComponent<Image>().sprite = sp;
                }

                if (page == 3)
                {
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, "ItemQuality_5");
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    self.EquipList[i].GameObject.transform.Find("Img_EquipBack").GetComponent<Image>().sprite = sp;
                }

                self.EquipList[i].GameObject.transform.Find("Lab_JiHuo").gameObject.SetActive(false);
            }

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
                if (page == 3 && subType != 14)
                {
                    continue;
                }

                self.EquipList[itemConfig.ItemSubType % 100 - 1].UpdateData(equiplist[i], self.Occ, self.ItemOperateEnum, equiplist);

                //判断是否激活
                self.EquipList[itemConfig.ItemSubType % 100 - 1].GameObject.transform.Find("Lab_JiHuo").gameObject.SetActive(ItemHelper.IfShengXiaoActive(equiplist[i].ItemID, equiplist)==false);

            }

            //线条显示
            for (int i = 0; i < self.LinkShowSet.transform.childCount; i++)
            {

                GameObject obj = self.LinkShowSet.transform.GetChild(i).gameObject;
                obj.SetActive(false);
                string linkName = obj.name;
                string resName = "Link_2";

                if (page == 1) {
                    linkName = linkName.Replace("160001", "160002");
                    resName = "Link_3";
                }

                if (page == 2)
                {
                    linkName = linkName.Replace("160001", "160003");
                    resName = "Link_4";
                }

                if (ItemHelper.IfShengXiaoActiveLine(linkName, equiplist))
                {
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, resName);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    obj.GetComponent<Image>().sprite = sp;
                    obj.SetActive(true);
                }
            
            }
        }
    }
}