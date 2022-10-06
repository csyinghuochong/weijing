using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiShopTypeComponent : Entity, IAwake
    {

        public GameObject ImageButton;
        public GameObject UIPointTaskDate;
        public GameObject TaskTypeName;

        public List<UI> UITaskTypeItemList;
        public Action<int, int> ClickTypeItemHandler;
        public Action<int> ClickTypeHandler;

        public int TypeId;
        public bool bSelected = false;
    }

    [ObjectSystem]
    public class UIPaiMaiShopTypeComponentAwakeSystem : AwakeSystem<UIPaiMaiShopTypeComponent>
    {

        public override void Awake(UIPaiMaiShopTypeComponent self)
        {
            self.UITaskTypeItemList = new List<UI>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIPointTaskDate = rc.Get<GameObject>("UIPointTaskDate");
            self.TaskTypeName = rc.Get<GameObject>("TaskTypeName");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickTypeButton(); });

            self.bSelected = false;
        }
    }

    public static class UIPaiMaiShopTypeComponentSystem
    {
        public static async ETTask SetSelected(this UIPaiMaiShopTypeComponent self, int typeid)
        {
            if (self.TypeId != typeid )
            {
                self.bSelected = false;
            }
            if (self.TypeId == typeid && self.bSelected)
            {
                self.bSelected = false;
            }
            if (self.TypeId == typeid && !self.bSelected)
            {
                self.bSelected = true;
            }

            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GameObject.SetActive(false);
            }
            if (!self.bSelected)
            {
                self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(500f, 80f);
                self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(false);
                self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(true);
                return;
            }

            List<int> ids = PaiMaiHelper.Instance.GetChaptersByType((PaiMaiTypeEnum)self.TypeId);
            string path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiShopTypeItem");
            await ETTask.CompletedTask;
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                                  
            for (int i = 0; i < ids.Count; i++)
            {
                UI ui_1 = null;
                if (i < self.UITaskTypeItemList.Count)
                {
                    ui_1 = self.UITaskTypeItemList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.UIPointTaskDate);
                    taskTypeItem.transform.localPosition = new Vector3(0f, i * -80f, 0f);

                    ui_1 = self.AddChild<UI, string, GameObject>( "taskTypeItem_" + i.ToString(), taskTypeItem);
                    UIPaiMaiShopTypeItemComponent uIItemComponent = ui_1.AddComponent<UIPaiMaiShopTypeItemComponent>();
                    uIItemComponent.SetClickSubTypeHandler((int chapterid) => { self.OnClickTaskTypeItem(chapterid); });
                    self.UITaskTypeItemList.Add(ui_1);
                }
                ui_1.GetComponent<UIPaiMaiShopTypeItemComponent>().OnUpdateData(self.TypeId, ids[i]);
            }

            self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(500f, 80f + 80f * ids.Count);
            self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(false);
            self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(true);
            if (ids.Count > 0)
            {
                self.UITaskTypeItemList[0].GetComponent<UIPaiMaiShopTypeItemComponent>().OnClickButtoin();
            }
        }

        public static void OnUpdateData(this UIPaiMaiShopTypeComponent self, int typeId)
        {
            self.TypeId = typeId;

            self.TaskTypeName.GetComponent<Text>().text = PaiMaiHelper.Instance.PaiMaiTypeText[typeId];
        }

        public static void SetClickTypeHandler(this UIPaiMaiShopTypeComponent self, Action<int> action)
        {
            self.ClickTypeHandler = action;
        }

        public static void SetClickTypeItemHandler(this UIPaiMaiShopTypeComponent self, Action<int, int> action)
        {
            self.ClickTypeItemHandler = action;
        }


        public static void OnClickTypeButton(this UIPaiMaiShopTypeComponent self)
        {
            self.ClickTypeHandler(self.TypeId);
        }

        public static void OnClickTaskTypeItem(this UIPaiMaiShopTypeComponent self, int chapterid)
        {
            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GetComponent<UIPaiMaiShopTypeItemComponent>().SetSelected(chapterid);
            }

            self.ClickTypeItemHandler(self.TypeId, chapterid);
        }
    }
}
