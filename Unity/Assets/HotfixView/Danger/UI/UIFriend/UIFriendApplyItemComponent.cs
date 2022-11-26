using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFriendApplyItemComponent : Entity, IAwake
    {
        public GameObject PlayerOcc;
        public GameObject PlayerOnLine;
        public GameObject HeadIcon;
        public GameObject ButtonRefuse;
        public GameObject ButtonAgree;
        public GameObject ButtonWatch;
        public GameObject PlayerLevel;
        public GameObject PlayerName;

        public FriendInfo FriendInfo;
    }

    [ObjectSystem]
    public class UIFriendApplyItemComponentAwakeSystem : AwakeSystem<UIFriendApplyItemComponent>
    {
        public override void Awake(UIFriendApplyItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonRefuse = rc.Get<GameObject>("ButtonRefuse");
            ButtonHelp.AddListenerEx(self.ButtonRefuse, () => { self.OnFriendApplyReply(2); });

            self.ButtonAgree = rc.Get<GameObject>("ButtonAgree");
            ButtonHelp.AddListenerEx(self.ButtonAgree, () => { self.OnFriendApplyReply(1); });

            self.ButtonWatch = rc.Get<GameObject>("ButtonWatch");
            ButtonHelp.AddListenerEx(self.ButtonWatch, () => { self.OnButtonWatch().Coroutine(); });

            self.PlayerOcc = rc.Get<GameObject>("PlayerOcc");
            self.PlayerOnLine = rc.Get<GameObject>("PlayerOnLine");
            self.PlayerLevel = rc.Get<GameObject>("PlayerLevel");
            self.PlayerName = rc.Get<GameObject>("PlayerName");
            self.HeadIcon = rc.Get<GameObject>("HeadIcon");
        }
    }

    public static class UIFriendApplyItemComponentSystem
    {
        public static async ETTask OnButtonWatch(this UIFriendApplyItemComponent self)
        {
            C2F_WatchPlayerRequest c2M_SkillSet = new C2F_WatchPlayerRequest() { UserId = self.FriendInfo.UserId };
            F2C_WatchPlayerResponse m2C_SkillSet = (F2C_WatchPlayerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
            if (m2C_SkillSet.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatch);
            uI.GetComponent<UIWatchComponent>().OnUpdateUI(m2C_SkillSet);
        }

        public static void OnFriendApplyReply(this UIFriendApplyItemComponent self, int code)
        {
            FriendComponent friendComponent = self.ZoneScene().GetComponent<FriendComponent>();
            friendComponent.FriendApplyReply(self.FriendInfo, code).Coroutine();
        }

        public static void OnUpdateUI(this UIFriendApplyItemComponent self, FriendInfo friendInfo)
        {
            self.FriendInfo = friendInfo;
            self.PlayerOnLine.GetComponent<Text>().text = friendInfo.OnLineTime == 1 ? "状态:在线" : "状态:离线";

            if (friendInfo.OnLineTime != 1) {
                self.PlayerOnLine.GetComponent<Text>().color = new Color(0.62f,0.62f,0.62f);
            }

            self.PlayerLevel.GetComponent<Text>().text = $"等级:{friendInfo.PlayerLevel}";
            self.PlayerName.GetComponent<Text>().text = friendInfo.PlayerName;
            self.PlayerOcc.GetComponent<Text>().text = OccupationConfigCategory.Instance.Get(friendInfo.Occ).OccupationName;
            UICommonHelper.ShowOccIcon(self.HeadIcon, friendInfo.Occ);
        }
    }
}
