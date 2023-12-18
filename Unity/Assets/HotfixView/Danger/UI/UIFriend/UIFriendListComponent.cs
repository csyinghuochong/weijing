using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIFriendListComponent : Entity, IAwake, IDestroy
    {
        public GameObject ChatView;
        public GameObject FriendNodeList;
        public GameObject UIFriendListItem;
        public GameObject Obj_Lab_ChatPlayName;
        public FriendComponent FriendComponent;
        public GameObject ButtonCloseChat;

        public List<UIFriendListItemComponent> FriendUIList = new List<UIFriendListItemComponent>();
        public UIFriendChatComponent UIFriendChatComponent;
    }


    public class UIFriendListComponentAwakeSystem : AwakeSystem<UIFriendListComponent>
    {
        public override void Awake(UIFriendListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.FriendUIList.Clear();
            self.FriendNodeList = rc.Get<GameObject>("FriendNodeList");
            self.UIFriendListItem = rc.Get<GameObject>("UIFriendListItem");
            self.UIFriendListItem.SetActive(false);
            self.FriendComponent = self.ZoneScene().GetComponent<FriendComponent>();

            self.ButtonCloseChat = rc.Get<GameObject>("ButtonCloseChat");
            self.ButtonCloseChat.GetComponent<Button>().onClick.AddListener(() => { self.CloseChat(); });

            self.ChatView = rc.Get<GameObject>("ChatView");
            UI friendChat = self.AddChild<UI, string, GameObject>("FriendChatComponent", self.ChatView);
            self.UIFriendChatComponent = friendChat.AddComponent<UIFriendChatComponent>();
            self.ChatView.SetActive(false);

            self.Obj_Lab_ChatPlayName = rc.Get<GameObject>("Lab_ChatPlayName");
            self.OnUpdateFriendList().Coroutine();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            DataUpdateComponent.Instance.AddListener(DataType.FriendChat, self);
        }
    }


    public class UIFriendListComponentDestroySystem : DestroySystem<UIFriendListComponent>
    {
        public override void Destroy(UIFriendListComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.FriendChat, self);
        }
    }

    public static class UIFriendListComponentSystem
    {
        public static void OnUpdateUI(this UIFriendListComponent self)
        {
            self.ChatView.SetActive(false);
        }

        public static void OnFriendChat(this UIFriendListComponent self)
        {
            if (!self.ChatView.activeSelf)
                return;

            self.UIFriendChatComponent.OnFriendChat();
        }
        public static void CloseChat(this UIFriendListComponent self)
        {
            self.ChatView.SetActive(false);
        }

        public static async void ClickChatHandler(this UIFriendListComponent self, FriendInfo friendInfo)
        {
            self.ChatView.SetActive(true);
  
            self.UIFriendChatComponent.OnUpdateUI(friendInfo);
            self.Obj_Lab_ChatPlayName.GetComponent<Text>().text = "与" + friendInfo.PlayerName + "私聊中...";

            FriendComponent friendComponent = self.ZoneScene().GetComponent<FriendComponent>();
            if (friendComponent.FriendChatId.Contains(friendInfo.UserId))
            {
                friendComponent.FriendChatId.Remove(friendInfo.UserId);
            }
            
            if (friendComponent.FriendChatId.Count == 0)
            {
                ReddotComponent redPointComponent = self.ZoneScene().GetComponent<ReddotComponent>();
                redPointComponent.RemoveReddont(ReddotType.FriendChat);
            }

            C2F_FriendChatRead c2F_FriendChatRead = new C2F_FriendChatRead() { UserID = UnitHelper.GetMyUnitId(self.ZoneScene()), FriendID = friendInfo.UserId };
            F2C_FriendChatRead f2C_FriendChat = (F2C_FriendChatRead)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2F_FriendChatRead);
        }

        public static void OnDeleteHandler(this UIFriendListComponent self)
        {
            self.OnUpdateFriendList().Coroutine();
        }

        public static async ETTask OnUpdateFriendList(this UIFriendListComponent self)
        {
            await ETTask.CompletedTask;
            self.FriendNodeList.GetComponent<RectTransform>().sizeDelta = new Vector2(0, self.FriendComponent.FriendList.Count * 210 + 20);
            for (int i = 0; i < self.FriendComponent.FriendList.Count; i++)
            {
                UIFriendListItemComponent uI_1 = null;
                if (i < self.FriendUIList.Count)
                {
                    uI_1 = self.FriendUIList[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIFriendListItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.FriendNodeList);
                    uI_1 = self.AddChild<UIFriendListItemComponent, GameObject>( go);
                    uI_1.SetChatHandler((FriendInfo friendInfo) => { self.ClickChatHandler(friendInfo); });
                    uI_1.SetDeleteHandler(self.OnDeleteHandler);
                    self.FriendUIList.Add(uI_1);
                }
                uI_1.OnUpdateUI(self.FriendComponent.FriendList[i], self.FriendComponent.FriendChatId.Contains(self.FriendComponent.FriendList[i].UserId));
            }
            for (int i = self.FriendComponent.FriendList.Count; i < self.FriendUIList.Count; i++)
            {
                self.FriendUIList[i].GameObject.SetActive(false);
            }
        }
    }

}
