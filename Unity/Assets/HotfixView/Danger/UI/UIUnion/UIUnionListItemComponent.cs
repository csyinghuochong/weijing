using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionListItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject ButtonApply;
        public GameObject Text_Request;
        public GameObject Text_Number;
        public GameObject Text_Name;
        public GameObject GameObject;

        public UnionListItem UnionListItem;
    }

    [ObjectSystem]
    public class UIUnionListItemComponentAwakeSystem : AwakeSystem<UIUnionListItemComponent, GameObject>
    {
        public override void Awake(UIUnionListItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.ButtonApply = rc.Get<GameObject>("ButtonApply");
            ButtonHelp.AddListenerEx( self.ButtonApply, () => { self.OnButtonApply().Coroutine(); } );

            self.Text_Request = rc.Get<GameObject>("Text_Request");
            self.Text_Number = rc.Get<GameObject>("Text_Number");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
        }
    }

    public static class UIUnionListItemComponentSystem
    {
        public static async ETTask OnButtonApply(this UIUnionListItemComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.UnionId != 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请先退出公会");
                return;
            }
            C2U_UnionApplyRequest c2M_ItemHuiShouRequest = new C2U_UnionApplyRequest()
            {
                UnionId = self.UnionListItem.UnionId,
                UserId = userInfoComponent.UserInfo.UserId
            };
            U2C_UnionApplyResponse r2c_roleEquip = (U2C_UnionApplyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
        }

        public static void OnUpdateUI(this UIUnionListItemComponent self, UnionListItem unionListItem)
        {
            self.UnionListItem = unionListItem;

            self.Text_Request.GetComponent<Text>().text = $"等级达到{GlobalValueConfigCategory.Instance.Get(21).Value}级";
            self.Text_Number.GetComponent<Text>().text = $"人数 {unionListItem.PlayerNumber}/50";
            self.Text_Name.GetComponent<Text>().text = unionListItem.UnionName;
        }
    }
}
