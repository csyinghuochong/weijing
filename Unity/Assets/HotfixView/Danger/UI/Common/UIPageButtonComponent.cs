using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPageButtonComponent : Entity, IAwake
    {
        public int LastIndex;
        public int CurrentIndex;
        public List<Transform> ButtonList = new List<Transform>();
        public Action<int> ClickHandler;
        public Func<int, bool> CheckHandler;
        public bool ClickEnabled = true;
    }


    public class UIPageButtonComponentAwakeSystem : AwakeSystem<UIPageButtonComponent>
    {
        public override void Awake(UIPageButtonComponent self)
        {
            self.LastIndex = -1;
            self.CurrentIndex = -1;
            self.ClickEnabled = true;
            self.ClickHandler = null;
            self.CheckHandler = null;
            self.ButtonList.Clear();
            Transform tt = self.GetParent<UI>().GameObject.transform;

            int childCount = tt.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = tt.transform.GetChild(i);
                if (transform.Find("Button") == null) {
                    continue;
                }
                self.ButtonList.Add(transform);

                transform.Find("Button").GetComponent<Button>().onClick.AddListener(() =>
                {
                    self.OnClickButton(transform);
                });
            }
        }
    }

    public static class UIPageButtonComponentSystem
    {
        public static void OnClickButton(this UIPageButtonComponent self, Transform transform )
        {
            if (!self.ClickEnabled)
                return;

            int index = self.ButtonList.IndexOf(transform);
            if (self.CheckHandler != null && !self.CheckHandler(index))
                return;

            self.OnSelectIndex(index);
        }

        public static void SetButtonActive(this UIPageButtonComponent self, int index, bool active)
        {
            self.ButtonList[index].gameObject.SetActive(active);
        }

        public static void SetButtonReddot(this UIPageButtonComponent self, int index, bool active)
        {
            self.ButtonList[index].Find("Reddot").gameObject.SetActive(active);
        }

        public static void OnSelectIndex(this UIPageButtonComponent self, int index)
        {
            if (index == self.CurrentIndex)
                return;

            for (int i = 0; i < self.ButtonList.Count; i++)
            {
                self.ButtonList[i].Find("XuanZhong").gameObject.SetActive(index == i);
                self.ButtonList[i].Find("WeiXuanZhong").gameObject.SetActive(index != i);
            }
            self.LastIndex = self.CurrentIndex;
            self.CurrentIndex = index;
            self.ClickHandler(index);
        }

        public static int GetCurrentIndex(this UIPageButtonComponent self)
        {
            return self.CurrentIndex;
        }

        public static void SetClickHandler(this UIPageButtonComponent self, Action<int> handler)
        {
            self.ClickHandler = handler;
        }
    }

}
