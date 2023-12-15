using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

namespace ET
{
    public class UIUnionApplyListComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject UnionListNode;
        public GameObject UIUnionApplyListItem;
        public List<UnionPlayerInfo> ApplyPlayerInfos = new List<UnionPlayerInfo>();
        public Action ActionFunc;
    }


    public class UIUnionApplyListComponentAwakeSystem : AwakeSystem<UIUnionApplyListComponent>
    {
        public override void Awake(UIUnionApplyListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.ImageButton(); });

            self.UnionListNode = rc.Get<GameObject>("UnionListNode");
            self.UIUnionApplyListItem = rc.Get<GameObject>("UIUnionApplyListItem");
            self.UIUnionApplyListItem.SetActive(false);

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIUnionApplyListComponentSystem
    {
        public static void ImageButton(this UIUnionApplyListComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UIUnionApplyList);
            self.ActionFunc();
        }

        public static void OnUnionApplyReply(this UIUnionApplyListComponent self, long userId)
        {
            for (int i = self.ApplyPlayerInfos.Count - 1; i>=0; i--)
            {
                if (self.ApplyPlayerInfos[i].UserID == userId)
                {
                    self.ApplyPlayerInfos.RemoveAt(i);
                }
            }
            self.UpdatePlayerList();
        }

        public static void  UpdatePlayerList(this UIUnionApplyListComponent self)
        {
            List<Entity> childs = self.Children.Values.ToList();
            for (int i = 0; i < self.ApplyPlayerInfos.Count; i++)
            {
                if (i < childs.Count)
                {
                    (childs[i] as UIUnionApplyListItemComponent).OnUpdateUI(self.ApplyPlayerInfos[i]);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIUnionApplyListItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.UnionListNode);
                    self.AddChild<UIUnionApplyListItemComponent, GameObject>(go).OnUpdateUI(self.ApplyPlayerInfos[i]);
                }
            }
            for (int i = self.ApplyPlayerInfos.Count; i < childs.Count; i++)
            {
                (childs[i] as UIUnionApplyListItemComponent).GameObject.SetActive(false);
            }
        }

        public static async ETTask OnUpdateUI(this UIUnionApplyListComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0));
            C2U_UnionApplyListRequest c2M_ItemHuiShouRequest = new C2U_UnionApplyListRequest()
            {
                UnionId = unionId
            };

            long instanceid = self.InstanceId;
            U2C_UnionApplyListResponse r2c_roleEquip = (U2C_UnionApplyListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
            if (r2c_roleEquip.Error != ErrorCode.ERR_Success || instanceid != self.InstanceId)
            {
                return;
            }
            
            self.ApplyPlayerInfos = r2c_roleEquip.UnionPlayerList;
            self.UpdatePlayerList();
        }
    }
}