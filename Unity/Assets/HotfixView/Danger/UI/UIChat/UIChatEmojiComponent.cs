using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIChatEmojiComponent: Entity, IAwake
    {
        public GameObject ButtonList;
        public Action<string> ClickHander;
    }

    public class UIChatEmojiComponentAwakeSystem: AwakeSystem<UIChatEmojiComponent>
    {
        public override void Awake(UIChatEmojiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonList = rc.Get<GameObject>("buttonList");

            for (int i = 0; i < self.ButtonList.transform.childCount; i++)
            {
                GameObject emoji = self.ButtonList.transform.GetChild(i).gameObject;
                emoji.GetComponent<Button>().onClick.AddListener(() => { self.OnPointDown(emoji.name); });
            }
        }
    }

    public static class UIChatEmojiComponentSystem
    {
        public static void SetClickHandler(this UIChatEmojiComponent self, Action<string> action)
        {
            self.ClickHander = action;
        }

        public static void OnPointDown(this UIChatEmojiComponent self, string name)
        {
            self.GetParent<UI>().GameObject.SetActive(false);
            self.ClickHander(name);
        }
    }
}