using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIChengJiuTypeComponent : Entity, IAwake
    {

        public GameObject UIPointTaskDate;
        public GameObject TaskTypeName;
        public GameObject ImageButton;
        public GameObject Checkmark;

        public List<UI> UITaskTypeItemList;
        public Action<int, int> ClickTaskSubTypeHandler;

        public int ChengJiuTypeId;
        public bool Selected;
    }

    [ObjectSystem]
    public class UIChengJiuTypeComponentAwakeSystem : AwakeSystem<UIChengJiuTypeComponent>
    {

        public override void Awake(UIChengJiuTypeComponent self)
        {
            self.Selected = false;
            self.UITaskTypeItemList = new List<UI>();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIPointTaskDate = rc.Get<GameObject>("UIPointTaskDate");
            self.Checkmark = rc.Get<GameObject>("Checkmark");
            self.TaskTypeName = rc.Get<GameObject>("TaskTypeName");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(( ) => { self.OnClickTypeButton(); });
        }
    }

    public static class UIChengJiuTypeComponentSystem
    {

        public static async ETTask OnToggleValueChanged(this UIChengJiuTypeComponent self, bool value)
        {
            self.Selected = value;
            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GameObject.SetActive(false);
            }
            if (!value)
            {
                self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(680f, 80f);
                self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(false);
                self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(true);
                return;
            }

            List<int> ids = self.ZoneScene().GetComponent<ChengJiuComponent>().GetChaptersByType( self.ChengJiuTypeId);
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuTypeItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

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
                    taskTypeItem.transform.localPosition = new Vector3(0f, i * -176f, 0f);

                    ui_1 = self.AddChild<UI, string, GameObject>("taskTypeItem_" + i.ToString(), taskTypeItem);
                    UIChengJiuTypeItemComponent uIItemComponent = ui_1.AddComponent<UIChengJiuTypeItemComponent>();
                    uIItemComponent.SetClickSubTypeHandler((int chapterid) => { self.OnClickTaskTypeItem(chapterid); });
                    self.UITaskTypeItemList.Add(ui_1);
                }
                ui_1.GetComponent<UIChengJiuTypeItemComponent>().OnUpdateData(self.ChengJiuTypeId, ids[i]);
            }

            self.GetParent<UI>().GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(680f, 80f + 176 * ids.Count);
            self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(false);
            self.GetParent<UI>().GameObject.transform.parent.gameObject.SetActive(true);
            if (ids.Count > 0)
            {
                self.UITaskTypeItemList[0].GetComponent<UIChengJiuTypeItemComponent>().OnClickButtoin();
            }
        }

        public static void OnUpdateData(this UIChengJiuTypeComponent self,  int typeId)
        {
            self.ChengJiuTypeId = typeId;

            self.TaskTypeName.GetComponent<Text>().text = ChengJiuHelper.Instance.ChengJiuTypeText[typeId];
        }

        public static void SetClickSubTypeHandler(this UIChengJiuTypeComponent self, Action<int, int> action)
        {
            self.ClickTaskSubTypeHandler = action;
        }

        public static void OnClickTypeButton(this UIChengJiuTypeComponent self)
        {
            self.OnToggleValueChanged(!self.Selected).Coroutine();
        }

        public static void UnSelectedAll(this UIChengJiuTypeComponent self)
        {
            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GetComponent<UIChengJiuTypeItemComponent>().SetSelected(-1);
            }
        }

        public static void OnClickTaskTypeItem(this UIChengJiuTypeComponent self, int chapterid)
        {
            for (int i = 0; i < self.UITaskTypeItemList.Count; i++)
            {
                self.UITaskTypeItemList[i].GetComponent<UIChengJiuTypeItemComponent>().SetSelected(chapterid);
            }

            self.ClickTaskSubTypeHandler(self.ChengJiuTypeId, chapterid);
        }

    }

}

