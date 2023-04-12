using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIShouJiTreasureComponent : Entity, IAwake
    {
        public GameObject TypeListNode;
        public GameObject ItemListNode;

        public List<UIShouJiTreasureItemComponent> TreasureItemList = new List<UIShouJiTreasureItemComponent>();
        public List<UIShouJiTreasureTypeComponent> TreasureTypeList = new List<UIShouJiTreasureTypeComponent>();
    }


    public class UIShouJiTreasureComponentAwake : AwakeSystem<UIShouJiTreasureComponent>
    {
        public override  void Awake(UIShouJiTreasureComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TypeListNode = rc.Get<GameObject>("TypeListNode");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.TreasureTypeList.Clear();
            self.OnInitTypeList();
        }
    }

    public static class UIShouJiTreasureComponentSystem
    {

        public static void OnInitTypeList(this UIShouJiTreasureComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiTreasureType");
            GameObject bundleObj =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            Dictionary<int, List<int>> keyValuePairs = ShouJiItemConfigCategory.Instance.TreasureList;
            foreach(var item in keyValuePairs.Keys)
            {
                GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(taskTypeItem, self.TypeListNode);

                UIShouJiTreasureTypeComponent uIItemComponent = self.AddChild<UIShouJiTreasureTypeComponent, GameObject>(taskTypeItem);
                uIItemComponent.OnInitData(item);
                uIItemComponent.SetClickHandler((int typeid) => { self.OnClickType(typeid); });

                self.TreasureTypeList.Add(uIItemComponent);
            }

            self.TreasureTypeList[0].OnClick();
        }

        public static void OnClickType(this UIShouJiTreasureComponent self, int chapter)
        {
            for (int i = 0; i < self.TreasureTypeList.Count; i++)
            { 
                self.TreasureTypeList[i].OnSelected(chapter);   
            }

            self.OnUpdateTreasureItemList(chapter);
        }

        public static void OnShouJiTreasure(this UIShouJiTreasureComponent self)
        {
            int chapterId = 0;
            for (int i = 0; i < self.TreasureTypeList.Count; i++)
            {
                if (self.TreasureTypeList[i].Ima_SelectStatus.activeSelf)
                {
                    chapterId = self.TreasureTypeList[i].Chapter;
                }
            }
            self.OnUpdateTreasureItemList(chapterId);
        }

        public static void OnUpdateTreasureItemList(this UIShouJiTreasureComponent self, int chapter)
        {
            string path = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiTreasureItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<int> shouList = ShouJiItemConfigCategory.Instance.TreasureList[chapter];
            for (int i = 0; i < shouList.Count; i++)
            {
                UIShouJiTreasureItemComponent uIShouJiTreasureItem = null;
                if (i < self.TreasureItemList.Count)
                {
                    uIShouJiTreasureItem = self.TreasureItemList[i];
                    uIShouJiTreasureItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.ItemListNode);
                    uIShouJiTreasureItem = self.AddChild<UIShouJiTreasureItemComponent, GameObject>(taskTypeItem);
                    self.TreasureItemList.Add(uIShouJiTreasureItem);
                }

                uIShouJiTreasureItem.OnInitUI(shouList[i]);
            }

            for (int i = shouList.Count; i < self.TreasureItemList.Count; i++)
            {
                self.TreasureItemList[i].GameObject.SetActive(false);
            }
        }

    }
}