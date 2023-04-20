using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UISkillDragComponent : Entity, IAwake<int, GameObject>
    {
        public int SkillIndex;
        public GameObject Img_EventTrigger;
        public GameObject GameObject;

        public Action<int> BeginDrag_TriggerHandler;
        public Action<PointerEventData> Drag_TriggerHandler;
        public Action<PointerEventData> EndDrag_TriggerHandler;
        public Action<PointerEventData> OnCancel_TriggerHandler;
    }

    public class UISkillDragComponentAwake : AwakeSystem<UISkillDragComponent, int, GameObject>
    {
        public override void Awake(UISkillDragComponent self, int a, GameObject b)
        {
            self.SkillIndex = a;
            self.GameObject = b;
            self.Img_EventTrigger = b.transform.Find("Img_EventTrigger").gameObject;
            self.Img_EventTrigger.SetActive(false);

            ButtonHelp.AddEventTriggers(self.Img_EventTrigger, (PointerEventData pdata) => { self.BeginDrag_Trigger(pdata); }, EventTriggerType.BeginDrag);
            ButtonHelp.AddEventTriggers(self.Img_EventTrigger, (PointerEventData pdata) => { self.Drag_Trigger(pdata); }, EventTriggerType.Drag);
            ButtonHelp.AddEventTriggers(self.Img_EventTrigger, (PointerEventData pdata) => { self.EndDrag_Trigger(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.Img_EventTrigger, (PointerEventData pdata) => { self.OnCancel_Trigger(pdata); }, EventTriggerType.Cancel);
        }
    }

    public static class UISkillDragComponentSystem
    {
        public static void BeginDrag_Trigger(this UISkillDragComponent self, PointerEventData eventData)
        {
            self.BeginDrag_TriggerHandler?.Invoke(self.SkillIndex);
        }

        public static void Drag_Trigger(this UISkillDragComponent self, PointerEventData eventData)
        {
            self.Drag_TriggerHandler?.Invoke(eventData);
        }

        public static void EndDrag_Trigger(this UISkillDragComponent self, PointerEventData eventData)
        {
            self.EndDrag_TriggerHandler?.Invoke(eventData);
        }

        public static void OnCancel_Trigger(this UISkillDragComponent self, PointerEventData eventData)
        {
            self.OnCancel_TriggerHandler?.Invoke(eventData);
        }

    }
}
