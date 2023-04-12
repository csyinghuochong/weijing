using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace ET
{
    public class UIUnionListComponent : Entity, IAwake
    {
        public GameObject UnionListNode;
        public List<UnionListItem> UnionList = null;
    }


    public class UIUnionListComponentAwakeSystem : AwakeSystem<UIUnionListComponent>
    {
        public override void Awake(UIUnionListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UnionListNode = rc.Get<GameObject>("UnionListNode");

            self.GetParent<UI>().OnUpdateUI =() =>{ self.OnUpdateUI().Coroutine();   };
        }
    }

    public static class UIUnionListComponentSystem
    {

        public static async ETTask OnUpdateUI(this UIUnionListComponent self)
        {
            if (self.UnionList == null)
            {
                C2U_UnionListRequest c2M_ItemHuiShouRequest = new C2U_UnionListRequest() { };
                U2C_UnionListResponse r2c_roleEquip = (U2C_UnionListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
                {
                    return;
                }
                self.UnionList = r2c_roleEquip.UnionList;
            }

            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Union/UIUnionListItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<Entity> childs = self.Children.Values.ToList();
            for (int i = 0; i < self.UnionList.Count; i++)
            {
                if (i < childs.Count)
                {
                    (childs[i] as UIUnionListItemComponent).OnUpdateUI(self.UnionList[i]);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.UnionListNode);
                    self.AddChild<UIUnionListItemComponent, GameObject>(go).OnUpdateUI(self.UnionList[i]);
                }
            }
            for (int i = self.UnionList.Count; i < childs.Count; i++)
            {
                (childs[i] as UIUnionListItemComponent).GameObject.SetActive(false);
            }
        }

        public static void ResetUI(this UIUnionListComponent self)
        {
            self.UnionList = null;
        }

    }
}
