using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMainChatComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject UIMainChatItem;
        public GameObject ChatUIListNode;
        public ScrollRect ScrollRect;

        public List<UI> ChatUIList = new List<UI>();
        public List<ChatInfo> ChatInfoList = new List<ChatInfo>();
    }


    [ObjectSystem]
    public class UIMainChatComponentAwakeSystem : AwakeSystem<UIMainChatComponent>
    {
        public override void Awake(UIMainChatComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ChatUIListNode = rc.Get<GameObject>("ChatUIListNode");
            self.UIMainChatItem = rc.Get<GameObject>("UIMainChatItem");
            self.UIMainChatItem.SetActive(false);
            self.ChatUIList.Clear();
            self.ChatInfoList.Clear();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnOpenChat(); });
            self.ScrollRect = rc.Get<GameObject>("ScrollView").GetComponent<ScrollRect>();

        }

    }

    public static class UIMainChatComponentSystem
    {
        public static void OnOpenChat(this UIMainChatComponent self)
        {
            UIHelper.Create(self.DomainScene(), UIType.UIChat).Coroutine();
        }

        public static void OnRecvChat(this UIMainChatComponent self, ChatInfo chatInfo)
        {
            if (self.ChatInfoList.Count >= 10)
            {
                self.ChatInfoList.RemoveAt(0);
            }
            self.ChatInfoList.Add(chatInfo);

            for (int i = 0; i < self.ChatInfoList.Count; i++)
            {
                UI ui_2 = null;
                if (i < self.ChatUIList.Count)
                {
                    ui_2 = self.ChatUIList[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(self.UIMainChatItem);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.ChatUIListNode);
                    ui_2 = self.AddChild<UI, string, GameObject>("chatItem_" + i.ToString(), itemSpace);
                    ui_2.AddComponent<UIMainChatItemComponent>().SetClickHandler(() => { self.OnOpenChat();  } );
                    self.ChatUIList.Add(ui_2);
                }

                ui_2.GetComponent<UIMainChatItemComponent>().OnUpdateUI(self.ChatInfoList[i]);
            }
            for (int i = self.ChatInfoList.Count; i < self.ChatUIList.Count; i++)
            {
                self.ChatUIList[i].GameObject.SetActive(false);
            }
            self.ImageButton.SetActive(self.ChatInfoList.Count < 4);

            self.UpdatePosition().Coroutine();
        }

        public static async ETTask UpdatePosition(this UIMainChatComponent self)
        {
            long instanceid = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(10);
            if (self.InstanceId != instanceid)
                return;
            self.ScrollRect.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
        }
    }
}
