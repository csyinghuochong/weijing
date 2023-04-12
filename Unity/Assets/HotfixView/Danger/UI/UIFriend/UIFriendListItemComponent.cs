using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{


    public class UIFriendListItemComponent : Entity, IAwake
    {
        public GameObject OccName;
        public GameObject HeadIcon;
        public GameObject ButtonChat;
        public GameObject ButtonWatch;
        public GameObject OnLineTime;
        public GameObject PlayerLevel;
        public GameObject PlayerName;

        public FriendInfo FriendInfo;
        public Action<FriendInfo> ClickHandler;
    }


    public class UIFriendListItemComponentAwakeSystem : AwakeSystem<UIFriendListItemComponent>
    {
        public override void Awake(UIFriendListItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.OccName = rc.Get<GameObject>("OccName");
            self.ButtonChat = rc.Get<GameObject>("ButtonChat");
            ButtonHelp.AddListenerEx( self.ButtonChat, ()=> { self.ClickHandler( self.FriendInfo );  } );

            self.ButtonWatch = rc.Get<GameObject>("ButtonWatch");
            ButtonHelp.AddListenerEx(self.ButtonWatch, () => { self.OnButtonWatch().Coroutine(); });

            self.OnLineTime = rc.Get<GameObject>("OnLineTime");
            self.PlayerLevel = rc.Get<GameObject>("PlayerLevel");
            self.PlayerName = rc.Get<GameObject>("PlayerName");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
        }
    }


    public static class UIFriendListItemComponentSystem
    {

        public static void SetClickHandler(this UIFriendListItemComponent self, Action<FriendInfo> action)
        {
            self.ClickHandler = action;
        }

        public static async ETTask OnButtonWatch(this UIFriendListItemComponent self)
        {
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.FriendInfo.UserId };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatch);
            uI.GetComponent<UIWatchComponent>().OnUpdateUI(m2C_SkillSet);
        }

        public static void OnUpdateUI(this UIFriendListItemComponent self, FriendInfo friendInfo)
        {
            self.FriendInfo = friendInfo;

            self.OnLineTime.GetComponent<Text>().text = friendInfo.OnLineTime ==  1 ? "状态:在线" : "状态:离线";
            self.PlayerLevel.GetComponent<Text>().text = $"等级: {friendInfo.PlayerLevel}级";
            self.PlayerName.GetComponent<Text>().text = friendInfo.PlayerName;
            self.OccName.GetComponent<Text>().text = "职业:" + OccupationConfigCategory.Instance.Get(friendInfo.Occ).OccupationName;
            UICommonHelper.ShowOccIcon(self.HeadIcon, friendInfo.Occ);
        }
    }

}
