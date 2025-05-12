using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetEquipMakeChapterComponent: Entity, IAwake<GameObject>
    {
        public GameObject ItemNode;
        public GameObject Text_Name;
        public GameObject GameObject;
        public Action<int> ActionClick;

        public List<UIMakeItemComponent> MakeListUI = new List<UIMakeItemComponent>();
    }
    
    public class UIPetEquipMakeChapterComponentAwake : AwakeSystem<UIPetEquipMakeChapterComponent, GameObject>
    {
        public override void Awake(UIPetEquipMakeChapterComponent self, GameObject a)
        {
            self.GameObject = a;
            self.MakeListUI.Clear();

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.ItemNode = rc.Get<GameObject>("ItemNode");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
        }
    }

    public static class UIPetEquipMakeChapterComponentSystem
    {
        public static void OnInitUI(this UIPetEquipMakeChapterComponent self, string chaptet, List<int> makeList)
        {
            int row = (makeList.Count / 5);
            row += (makeList.Count % 5 > 0 ? 1 : 0);
            self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(800f, 100f + row * 170f);

            var path = ABPathHelper.GetUGUIPath("Main/Make/UIMakeItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < makeList.Count; i++)
            {
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.ItemNode);
                UIMakeItemComponent ui_2 = self.AddChild<UIMakeItemComponent, GameObject>(itemSpace);
                ui_2.SetClickAction((int itemid) => { self.OnClickMakeItem(itemid); });
                ui_2.OnUpdateUI(makeList[i]);
                self.MakeListUI.Add(ui_2);
            }

            self.Text_Name.GetComponent<Text>().text = chaptet;
        }

        public static void SelectFirst(this UIPetEquipMakeChapterComponent self)
        {
            self.OnClickMakeItem(self.MakeListUI[0].MakeID);
        }

        public static void SetClickAction(this UIPetEquipMakeChapterComponent self, Action<int> action)
        {
            self.ActionClick = action;
        }

        public static void OnClickMakeItem(this UIPetEquipMakeChapterComponent self, int makeid)
        {
            self.OnSelectMakeItem(makeid);
            self.ActionClick(makeid);
        }

        public static void OnSelectMakeItem(this UIPetEquipMakeChapterComponent self, int makeid)
        {
            //设置选中框
            for (int k = 0; k < self.MakeListUI.Count; k++)
            {
                self.MakeListUI[k].Image_Select.SetActive(makeid == self.MakeListUI[k].MakeID);
            }
        }
    }
}