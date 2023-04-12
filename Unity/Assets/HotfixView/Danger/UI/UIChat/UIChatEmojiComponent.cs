

using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
     
    public class UIChatEmojiComponent : Entity, IAwake
    {

        public GameObject ButtonList;
        public Action<string> ClickHander;

    }



    public class UIChatEmojiComponentAwakeSystem : AwakeSystem<UIChatEmojiComponent>
    {
        public override void Awake(UIChatEmojiComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonList = rc.Get<GameObject>("buttonList");

            for (int i = 0; i < self.ButtonList.transform.childCount; i++)
            {
                ButtonHelp.AddEventTriggers(self.ButtonList.transform.GetChild(i).gameObject, (PointerEventData pdata) => { self.OnPointDown(pdata); }, EventTriggerType.PointerDown);
            }
        }

    }

    public static class UIChatEmojiComponentSystem
    {

        public static void SetClickHandler(this UIChatEmojiComponent self, Action<string> action)
        {
            self.ClickHander = action;
        }

        public static void OnPointDown(this UIChatEmojiComponent self, PointerEventData eventData)
        {
 
            self.GetParent<UI>().GameObject.SetActive(false);
            self.ClickHander(eventData.pointerCurrentRaycast.gameObject.name);
        }


    }

}
