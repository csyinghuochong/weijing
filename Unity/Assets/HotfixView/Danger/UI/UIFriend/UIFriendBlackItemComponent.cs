using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFriendBlackItemComponent : Entity,IAwake<GameObject>
    {
        public GameObject ButtonRemove;
        public GameObject GameObject;

        public GameObject OccName;
        public GameObject HeadIcon;
        public GameObject ButtonWatch;
        public GameObject OnLineTime;
        public GameObject PlayerLevel;
        public GameObject PlayerName;

        public FriendInfo FriendInfo;
    }

    [ObjectSystem]
    public class UIFriendBlackItemComponentAwakeSystem : AwakeSystem<UIFriendBlackItemComponent, GameObject>
    {
        public override void Awake(UIFriendBlackItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ButtonRemove = rc.Get<GameObject>("ButtonRemove");
            ButtonHelp.AddListenerEx(self.ButtonRemove, () => { self.OnButtonRemove().Coroutine(); });
            self.OccName = rc.Get<GameObject>("OccName");
         
            self.ButtonWatch = rc.Get<GameObject>("ButtonWatch");
            ButtonHelp.AddListenerEx(self.ButtonWatch, () => { self.OnButtonWatch().Coroutine(); });
            self.OnLineTime = rc.Get<GameObject>("OnLineTime");
            self.PlayerLevel = rc.Get<GameObject>("PlayerLevel");
            self.PlayerName = rc.Get<GameObject>("PlayerName");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
        }
    }

    public static class UIFriendBlackItemComponentSystem
    {
        public static async ETTask OnButtonWatch(this UIFriendBlackItemComponent self)
        {
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.FriendInfo.UserId };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);

            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatch);
            uI.GetComponent<UIWatchComponent>().OnUpdateUI(m2C_SkillSet);
        }

        public static async ETTask OnButtonRemove(this UIFriendBlackItemComponent self)
        {
            await NetHelper.RequestRemoveBlack(self.ZoneScene(), self.FriendInfo.UserId);
            await NetHelper.RequestFriendInfo(self.ZoneScene());
            UI uifriend = UIHelper.GetUI(self.ZoneScene(), UIType.UIFriend);
            uifriend.GetComponent<UIFriendComponent>().OnRemoveBlack();
        }

        public static void OnUpdateUI(this UIFriendBlackItemComponent self, FriendInfo friendInfo)
        {
            self.FriendInfo = friendInfo;

            self.OnLineTime.GetComponent<Text>().text = friendInfo.OnLineTime == 1 ? "状态:在线" : "状态:离线";
            self.PlayerLevel.GetComponent<Text>().text = $"等级: {friendInfo.PlayerLevel}级";
            self.PlayerName.GetComponent<Text>().text = friendInfo.PlayerName;
            self.OccName.GetComponent<Text>().text = "职业:" + OccupationConfigCategory.Instance.Get(friendInfo.Occ).OccupationName;
            UICommonHelper.ShowOccIcon(self.HeadIcon, friendInfo.Occ);
        }
    }
}
