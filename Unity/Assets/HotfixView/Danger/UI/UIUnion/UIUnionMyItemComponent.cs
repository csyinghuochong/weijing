using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionMyItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_Name;
        public GameObject Text_Level;
        public GameObject Text_Position;
        public GameObject ImageButton;
        public GameObject GameObject;

        public UnionPlayerInfo UnionPlayerInfo;
        public long LeaderId;
        public bool OnLine;
    }



    public class UIUnionMyItemComponentAwakeSystem : AwakeSystem<UIUnionMyItemComponent, GameObject>
    {
        public override void Awake(UIUnionMyItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_Level = rc.Get<GameObject>("Text_Level");
            self.Text_Position = rc.Get<GameObject>("Text_Position");
            
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            ButtonHelp.AddListenerEx(self.ImageButton, () => { self.OnOpenMenu().Coroutine(); });
        }
    }

    public static class UIUnionMyItemComponentSystem
    {

        public static async ETTask OnOpenMenu(this UIUnionMyItemComponent self)
        { 
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            long selfUserId = userInfoComponent.UserInfo.UserId;
            List<int> vs = new List<int>();
            vs.Add(MenuOperation.Watch);
            if (selfUserId != self.UnionPlayerInfo.UserID)
            {
                vs.Add(MenuOperation.AddFriend);
            }
            if (selfUserId == self.LeaderId && selfUserId != self.UnionPlayerInfo.UserID)
            {
                vs.Add(MenuOperation.KickUnion);
            }
            
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatchMenu);
            uI.GetComponent<UIWatchMenuComponent>().OnUpdateUI_2(vs, self.UnionPlayerInfo.UserID);
        } 

        public static void OnUpdateUI(this UIUnionMyItemComponent self, UnionPlayerInfo unionPlayerInfo, long leaderId, bool online)
        {
            self.UnionPlayerInfo = unionPlayerInfo;
            self.LeaderId = leaderId; 
            self.Text_Name.GetComponent<Text>().text = unionPlayerInfo.PlayerName;
            self.Text_Level.GetComponent<Text>().text = unionPlayerInfo.PlayerLevel.ToString();
            self.Text_Position.GetComponent<Text>().text = leaderId  == unionPlayerInfo .UserID? "族长" : "族员";
        }
    }
}
