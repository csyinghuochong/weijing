using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UIFriendListItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject OccName;
        public GameObject HeadIcon;
        public GameObject ButtonChat;
        public GameObject ButtonWatch;
        public GameObject OnLineTime;
        public GameObject PlayerLevel;
        public GameObject PlayerName;
        public GameObject ButtonDelete;

        public FriendInfo FriendInfo;
        public Action<FriendInfo> ClickHandler;
        public Action DeleteHandler;

        public GameObject GameObject;
    }


    public class UIFriendListItemComponentAwakeSystem : AwakeSystem<UIFriendListItemComponent, GameObject>
    {
        public override void Awake(UIFriendListItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.OccName = rc.Get<GameObject>("OccName");
            self.ButtonChat = rc.Get<GameObject>("ButtonChat");
            ButtonHelp.AddListenerEx( self.ButtonChat,  self.OnButtonChat);

            self.ButtonWatch = rc.Get<GameObject>("ButtonWatch");
            ButtonHelp.AddListenerEx(self.ButtonWatch, () => { self.OnButtonWatch().Coroutine(); });

            self.ButtonDelete = rc.Get<GameObject>("ButtonDelete");
            ButtonHelp.AddListenerEx(self.ButtonDelete, () => { self.OnButtonDelete().Coroutine(); });

            self.OnLineTime = rc.Get<GameObject>("OnLineTime");
            self.PlayerLevel = rc.Get<GameObject>("PlayerLevel");
            self.PlayerName = rc.Get<GameObject>("PlayerName");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
            self.ButtonChat.transform.Find("Reddot").gameObject.SetActive(false);
        }
    }


    public static class UIFriendListItemComponentSystem
    {

        public static void SetChatHandler(this UIFriendListItemComponent self, Action<FriendInfo> action)
        {
            self.ClickHandler = action;
        }

        public static void SetDeleteHandler(this UIFriendListItemComponent self, Action action)
        {
            self.DeleteHandler = action;
        }

        public static void OnButtonChat(this UIFriendListItemComponent self)
        {
            self.ClickHandler(self.FriendInfo);
            self.SetButtonChat(false);
        }

        public static void SetButtonChat(this UIFriendListItemComponent self, bool value)
        {
            self.ButtonChat.transform.Find("Reddot").gameObject.SetActive(value);
        }

        public static async ETTask OnButtonDelete(this UIFriendListItemComponent self)
        {
            C2F_FriendDeleteRequest request = new C2F_FriendDeleteRequest() { 
                UserID = UnitHelper.GetMyUnitId( self.DomainScene() ),
                FriendID = self.FriendInfo.UserId ,
            };
            F2C_FriendDeleteResponse response = (F2C_FriendDeleteResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<FriendComponent>().OnFriendDelelte(self.FriendInfo.UserId);
            self.DeleteHandler?.Invoke();
        }

        public static async ETTask OnButtonWatch(this UIFriendListItemComponent self)
        {
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.FriendInfo.UserId };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatch);
            uI.GetComponent<UIWatchComponent>().OnUpdateUI(m2C_SkillSet);
        }

        public static void OnUpdateUI(this UIFriendListItemComponent self, FriendInfo friendInfo, bool showred)
        {
            self.FriendInfo = friendInfo;
            self.SetButtonChat(showred);
            self.OnLineTime.GetComponent<Text>().text = friendInfo.OnLineTime ==  1 ? "状态:在线" : "状态:离线";
            self.PlayerLevel.GetComponent<Text>().text = $"等级: {friendInfo.PlayerLevel}级";
            self.PlayerName.GetComponent<Text>().text = friendInfo.PlayerName;
            self.OccName.GetComponent<Text>().text = "职业:" + OccupationConfigCategory.Instance.Get(friendInfo.Occ).OccupationName;
            UICommonHelper.ShowOccIcon(self.HeadIcon, friendInfo.Occ);
        }
    }

}
