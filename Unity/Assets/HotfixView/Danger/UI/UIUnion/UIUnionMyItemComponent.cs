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

        public UnionPlayerInfo CurPlayerInfo;
        public UnionInfo UnionInfo;
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

        public static UnionPlayerInfo GetPlayerInfo(this UIUnionMyItemComponent self, long selfId)
        {
            for (int i = 0; i < self.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (self.UnionInfo.UnionPlayerList[i].UserID == selfId)
                {
                    return self.UnionInfo.UnionPlayerList[i];
                }
            }
            return null;
        }

        public static async ETTask OnOpenMenu(this UIUnionMyItemComponent self)
        {
            List<int> vs = new List<int>() { MenuOperation.Watch };

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            UnionPlayerInfo mainPlayerInfo =  self.GetPlayerInfo(userInfoComponent.UserInfo.UserId);
            if (mainPlayerInfo == null)
            {
                return;
            }

            int aiderNumber = 0;
            int elderNumber = 0;
            for (int i = 0;  i < self.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (self.UnionInfo.UnionPlayerList[i].Position == 2)    //副族长
                {
                    aiderNumber++;
                }
                if (self.UnionInfo.UnionPlayerList[i].Position == 3)    //长老
                {
                    elderNumber++;
                }
            }

            if (mainPlayerInfo.UserID != self.CurPlayerInfo.UserID)
            {
                vs.Add(MenuOperation.AddFriend);

                if (mainPlayerInfo.UserID == self.UnionInfo.LeaderId)
                {
                    if (mainPlayerInfo.UserID != self.CurPlayerInfo.UserID)
                    {
                        vs.Add(MenuOperation.KickUnion);
                        vs.Add(MenuOperation.TransUnion);
                    }
                }

                if (mainPlayerInfo.Position == 1)       //族长可以任命副族长和长老
                {
                    if (aiderNumber < 1 && (self.CurPlayerInfo.Position == 0 || self.CurPlayerInfo.Position > 2)
                        && self.CurPlayerInfo.Position!=2)
                    {
                        vs.Add(MenuOperation.UnionAider);
                    }
                }
                if (mainPlayerInfo.Position == 1 || mainPlayerInfo.Position == 2)       //副族长可以任命长老
                {
                    if (elderNumber < 2 && (self.CurPlayerInfo.Position == 0 || self.CurPlayerInfo.Position > mainPlayerInfo.Position)
                        && self.CurPlayerInfo.Position != 3)
                    {
                        vs.Add(MenuOperation.UnionElde);
                    }
                }
            }
           
            UI uI = await UIHelper.Create(self.DomainScene(), UIType.UIWatchMenu);
            uI.GetComponent<UIWatchMenuComponent>().OnUpdateUI_2(vs, self.CurPlayerInfo.UserID);
        } 

        public static void OnUpdateUI(this UIUnionMyItemComponent self, UnionInfo unionInfo, UnionPlayerInfo unionPlayerInfo)
        {
            self.UnionInfo = unionInfo;
            self.CurPlayerInfo = unionPlayerInfo;
            self.Text_Name.GetComponent<Text>().text = unionPlayerInfo.PlayerName;
            self.Text_Level.GetComponent<Text>().text = unionPlayerInfo.PlayerLevel.ToString();
            self.Text_Position.GetComponent<Text>().text = UnionHelper.UnionPosition[unionPlayerInfo.Position];
        }
    }
}
