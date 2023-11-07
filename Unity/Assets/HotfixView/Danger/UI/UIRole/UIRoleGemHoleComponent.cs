using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleGemHoleComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Image_SelectImg;
        public GameObject Lab_HoleName;
        public GameObject ImageHoleName;
        public GameObject Btn_Select;

        public int Index;
        public Action<int> ClickHandler;
        public UIItemComponent UIGemItem;
        public List<string> AssetPath = new List<string>();
    }


    public class UIRoleGemHoleComponentAwakeSystem : AwakeSystem<UIRoleGemHoleComponent, GameObject>
    {
        public override void Awake(UIRoleGemHoleComponent self, GameObject go)
        {
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();

            self.Image_SelectImg = rc.Get<GameObject>("Image_SelectImg");
            self.Lab_HoleName = rc.Get<GameObject>("Lab_HoleName");
            self.ImageHoleName = rc.Get<GameObject>("ImageHoleName");
            self.ImageHoleName.SetActive(false);

            self.Btn_Select = rc.Get<GameObject>("Btn_Select");
            self.Btn_Select.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Select(); });

            GameObject gemItem = rc.Get<GameObject>("UIGemItem");
            self.UIGemItem = self.AddChild<UIItemComponent, GameObject>(gemItem);
            self.UIGemItem.Image_ItemButton.SetActive(false);
            self.UIGemItem.GameObject.SetActive(false);
        }
    }
    public class UIRoleGemHoleComponentDestroy: DestroySystem<UIRoleGemHoleComponent>
    {
        public override void Destroy(UIRoleGemHoleComponent self)
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
    public static class UIRoleGemHoleComponentSystem
    {

        public static void OnBtn_Select(this UIRoleGemHoleComponent self)
        {
            if (self.Index == -1)
            {
                return;
            }
            if (self.UIGemItem.GameObject.activeSelf)
            {
                self.UIGemItem.OnClickUIItem();
            }
            self.ClickHandler(self.Index);
        }

        public static void SetSelected(this UIRoleGemHoleComponent self, bool selected)
        { 
            self.Image_SelectImg.SetActive(selected);
        }

        public static void SetClickHandler(this UIRoleGemHoleComponent self, Action<int> clickHander)
        { 
            self.ClickHandler = clickHander;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="holeId">孔位ID</param>
        /// <param name="gemId">宝石ID</param>
        public static void OnUpdateUI(this UIRoleGemHoleComponent self, int holeId, int gemId, int index)
        {
            self.Index = index;
            self.Image_SelectImg.SetActive(false);
            if (holeId == 0)
            {
                self.Lab_HoleName.SetActive(false);
                self.ImageHoleName.SetActive(false);
                self.UIGemItem.GameObject.SetActive(false);
                return;
            }
            if (holeId != 0)
            {
                string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, $"Img_hole_{holeId}");
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }
                self.ImageHoleName.GetComponent<Image>().sprite = sp;
                self.ImageHoleName.SetActive(true);
            }
            if (gemId == 0)
            {
                self.Lab_HoleName.SetActive(true);
                //self.ImageHoleName.SetActive(true);
                self.UIGemItem.GameObject.SetActive(false);
                self.Lab_HoleName.GetComponent<Text>().text = ItemViewHelp.GemHoleName[holeId];
                string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, $"Img_hole_{holeId}");
                Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                if (!self.AssetPath.Contains(path))
                {
                    self.AssetPath.Add(path);
                }
                self.ImageHoleName.GetComponent<Image>().sprite = sp;
                self.ImageHoleName.SetActive(true);
                return;
            }
            self.ImageHoleName.SetActive(true);
            string path1 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.OtherIcon, $"Img_hole_{holeId}");
            Sprite sp1 = ResourcesComponent.Instance.LoadAsset<Sprite>(path1);
            if (!self.AssetPath.Contains(path1))
            {
                self.AssetPath.Add(path1);
            }
            self.ImageHoleName.GetComponent<Image>().sprite = sp1;
            self.Lab_HoleName.SetActive(false);
            self.UIGemItem.GameObject.SetActive(true);
            BagInfo bagInfo = new BagInfo() { ItemID = gemId, ItemNum = 1 };
            self.UIGemItem.UpdateItem(bagInfo, ItemOperateEnum.XiangQianGem);
        }
    }

}
