using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{

    public struct TypeButtonItem
    {
        public int SubTypeId;
        public string ItemName;
    }

    public class TypeButtonInfo
    {
        public int TypeId; 
        public string TypeName;

        public List<TypeButtonItem> typeButtonItems = new List<TypeButtonItem>();
    }

    public class UITypeViewComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public string TypeButtonItemAsset;
        public string TypeButtonAsset;

        public Action<int, int> ClickTypeItemHandler;
        public List<TypeButtonInfo> TypeButtonInfos = new List<TypeButtonInfo>();
        public List<UITypeButtonComponent> TypeButtonComponents = new List<UITypeButtonComponent>();
    }


    public class UITypeViewComponentAwakeSystem : AwakeSystem<UITypeViewComponent, GameObject>
    {
        public override void Awake(UITypeViewComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            self.TypeButtonComponents.Clear();
        }
    }

    public static class UITypeViewComponentSystem
    {

        public static async ETTask OnInitUI(this UITypeViewComponent self)
        {
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(self.TypeButtonAsset);
            for (int i = 0; i < self.TypeButtonInfos.Count; i++)
            {
                GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(taskTypeItem, self.GameObject);

                UITypeButtonComponent uIItemComponent = self.AddChild<UITypeButtonComponent, GameObject>(taskTypeItem);
                uIItemComponent.TypeItemAsset = self.TypeButtonItemAsset;
                uIItemComponent.OnUpdateData(self.TypeButtonInfos[i]);
                uIItemComponent.SetClickTypeHandler((int typeid) => { self.OnClickType(typeid); });
                uIItemComponent.SetClickTypeItemHandler((int typeid, int chapterId) => { self.OnClickTypeItem(typeid, chapterId); });

                self.TypeButtonComponents.Add(uIItemComponent);
            }
            self.TypeButtonComponents[0].OnClickTypeButton();
        }

        public static void OnClickType(this UITypeViewComponent self, int typeid)
        {
            for (int i = 0; i < self.TypeButtonComponents.Count; i++)
            {
                self.TypeButtonComponents[i].SetSelected(typeid);
            }
        }

        public static void OnClickTypeItem(this UITypeViewComponent self, int typeid, int chapterId)
        {
            self.ClickTypeItemHandler(typeid, chapterId);
        }
    }

    public  class UITypeButtonComponent : Entity, IAwake<GameObject>
    {
        public string TypeItemAsset;
        public TypeButtonInfo TypeButtonInfo;
        public GameObject ImageButton;
        public GameObject UIPointTaskDate;
        public GameObject TaskTypeName;
        public GameObject GameObject;

        public List<UITypeButtonItemComponent> TypeItemUIList = new List<UITypeButtonItemComponent>();
        public Action<int, int> ClickTypeItemHandler;
        public Action<int> ClickTypeHandler;

        public float Height = 500f;
        public float Spacing = 80f;
        public bool bSelected = false;
        public int TypeId;
    }


    public class UITypeButtonComponentAwakeSystem : AwakeSystem<UITypeButtonComponent, GameObject>
    {

        public override void Awake(UITypeButtonComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.GameObject = gameObject;
            self.UIPointTaskDate = rc.Get<GameObject>("UIPointTaskDate");
            self.TaskTypeName = rc.Get<GameObject>("TaskTypeName");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClickTypeButton(); });

            self.TypeItemUIList.Clear();
            self.bSelected = false;
        }
    }

    public static class UITypeButtonComponentSystem
    {
        public static async void SetSelected(this UITypeButtonComponent self, int typeid)
        {
            if (self.TypeId != typeid)
            {
                self.bSelected = false;
            }
            if (self.TypeId == typeid)
            {
                self.bSelected = !self.bSelected;
            }

            for (int i = 0; i < self.TypeItemUIList.Count; i++)
            {
                self.TypeItemUIList[i].GameObject.SetActive(false);
            }
            if (!self.bSelected)
            {
                self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Height, self.Spacing);
                self.GameObject.transform.parent.gameObject.SetActive(false);
                self.GameObject.transform.parent.gameObject.SetActive(true);
                self.ImageButton.transform.localScale = Vector3.one;
                return;
            }
            self.ImageButton.transform.localScale = new Vector3(1f, -1f, 1f);
            long instanceid = self.InstanceId;
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(self.TypeItemAsset);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<TypeButtonItem> TypeButtonItems = self.TypeButtonInfo.typeButtonItems;
            for (int i = 0; i < TypeButtonItems.Count; i++)
            {
                UITypeButtonItemComponent ui_1 = null;
                if (i < self.TypeItemUIList.Count)
                {
                    ui_1 = self.TypeItemUIList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject taskTypeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(taskTypeItem, self.UIPointTaskDate);
                    taskTypeItem.transform.localPosition = new Vector3(0f, i * self.Spacing * -1, 0f);

                    ui_1 = self.AddChild<UITypeButtonItemComponent, GameObject>(taskTypeItem);
                    ui_1.SetClickSubTypeHandler((int chapterid) => { self.OnClickTaskTypeItem(chapterid); });
                    self.TypeItemUIList.Add(ui_1);
                }
                ui_1.OnUpdateData(TypeButtonItems[i]);
            }

            self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(self.Height, self.Spacing + self.Spacing * TypeButtonItems.Count);
            self.GameObject.transform.parent.gameObject.SetActive(false);
            self.GameObject.transform.parent.gameObject.SetActive(true);
            if (TypeButtonItems.Count > 0)
            {
                self.TypeItemUIList[0].OnClickButtoin();
            }
        }

        public static void OnUpdateData(this UITypeButtonComponent self, TypeButtonInfo typeinfo)
        {
            self.TypeId = typeinfo.TypeId;
            self.TypeButtonInfo = typeinfo;

            self.TaskTypeName.GetComponent<Text>().text = typeinfo.TypeName;
        }

        public static void SetClickTypeHandler(this UITypeButtonComponent self, Action<int> action)
        {
            self.ClickTypeHandler = action;
        }

        public static void SetClickTypeItemHandler(this UITypeButtonComponent self, Action<int, int> action)
        {
            self.ClickTypeItemHandler = action;
        }


        public static void OnClickTypeButton(this UITypeButtonComponent self)
        {
            self.ClickTypeHandler(self.TypeId);
        }

        public static void OnClickTaskTypeItem(this UITypeButtonComponent self, int chapterid)
        {
            for (int i = 0; i < self.TypeItemUIList.Count; i++)
            {
                self.TypeItemUIList[i].SetSelected(chapterid);
            }

            self.ClickTypeItemHandler(self.TypeId, chapterid);
        }
    }


    public class UITypeButtonItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Lab_TaskName;
        public GameObject Ima_SelectStatus;
        public GameObject Ima_Di;
        public GameObject GameObject;

        public Action<int> ClickHandler;
        public int SubTypeId;

    }



    public class UITypeItemComponentAwakeSystem : AwakeSystem<UITypeButtonItemComponent, GameObject>
    {

        public override void Awake(UITypeButtonItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Lab_TaskName = rc.Get<GameObject>("Lab_TaskName");
            self.Ima_Di = rc.Get<GameObject>("Ima_Di");
            self.Ima_SelectStatus = rc.Get<GameObject>("Ima_SelectStatus");
            self.Ima_Di.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtoin(); });
        }
    }

    public static class UITypeItemComponentSystem
    {

        public static void SetSelected(this UITypeButtonItemComponent self, int subTypeid)
        {
            self.Ima_SelectStatus.SetActive(subTypeid == self.SubTypeId);
        }

        public static void SetClickSubTypeHandler(this UITypeButtonItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnUpdateData(this UITypeButtonItemComponent self, TypeButtonItem typeItem)
        {
            self.SubTypeId = typeItem.SubTypeId;
            self.Lab_TaskName.GetComponent<Text>().text = typeItem.ItemName;
        }

        public static void OnClickButtoin(this UITypeButtonItemComponent self)
        {
            self.ClickHandler(self.SubTypeId);
        }
    }

}
