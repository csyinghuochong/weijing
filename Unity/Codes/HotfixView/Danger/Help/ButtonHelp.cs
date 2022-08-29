using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public static class ButtonHelp
    {
        
        private static long LastCleanTime = 0L;
        private static readonly long ClickValidInterval = 500L;
        private static Dictionary<UnityAction, long> timedics = new Dictionary<UnityAction, long>();

        public static bool IsClickValid(UnityAction call)
        {
            long currentTime = TimeHelper.ClientNow();
            if (currentTime - LastCleanTime > 50000L)
            {
                timedics.Clear();
            }
            LastCleanTime = currentTime;
            long LastClickTime = 0;
            timedics.TryGetValue(call, out LastClickTime);
            if (currentTime - LastClickTime < ClickValidInterval)
                return false;

            if (timedics.ContainsKey(call))
                timedics[call] = currentTime;
            else
                timedics.Add(call, currentTime);
            return true;
        }

        private static void SafeClick(UnityAction call)
        {
            if (IsClickValid(call) == false)
                return;

            call?.Invoke();
        }

        public static void AddListenerEx(GameObject Button, UnityAction call)
        {
            Button.ButtonClickedEvent buttonClickedEvent = Button.GetComponent<Button>().onClick;
            buttonClickedEvent.RemoveAllListeners();
            buttonClickedEvent.AddListener(() => SafeClick(call));
        }

        public static void AddEventTriggers(GameObject button, Action<PointerEventData> action, EventTriggerType etype)
        {
            EventTrigger trigger = button.GetComponent<EventTrigger>();
            if (trigger == null)
            {
                return;
            }

            UnityAction<BaseEventData> callback = new UnityAction<BaseEventData>(delegate (BaseEventData eventdata) {
                PointerEventData data = eventdata as PointerEventData;
                action(data);
            });
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = etype;
            entry.callback.AddListener(callback);
            trigger.triggers.Add(entry);
        }

        public static bool isClick = false;
        public static void AddListenerAsync(this Button button, Func<ETTask> action)
        {
            button.onClick.RemoveAllListeners();

            async ETTask clickAcionAsync()
            { 
                isClick = true;
                await action();
                isClick = false;
            }

            button.onClick.AddListener(() =>
            {
                if (isClick)
                {
                    return;
                }
                clickAcionAsync().Coroutine();
            });
        }
    }
}
