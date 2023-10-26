using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace ET
{
    public class UIUnionListComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject UnionListNode;
        public GameObject UIUnionListItem;
        public List<UnionListItem> UnionList = null;
    }


    public class UIUnionListComponentAwakeSystem : AwakeSystem<UIUnionListComponent, GameObject>
    {
        public override void Awake(UIUnionListComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.UnionListNode = rc.Get<GameObject>("UnionListNode");
            self.UIUnionListItem = rc.Get<GameObject>("UIUnionListItem");
            self.UIUnionListItem.SetActive(false);
        }
    }

    public static class UIUnionListComponentSystem
    {

        public static async ETTask OnUpdateUI(this UIUnionListComponent self)
        {
            if (self.UnionList == null)
            {
                long instanceid = self.InstanceId;
                C2U_UnionListRequest c2M_ItemHuiShouRequest = new C2U_UnionListRequest() { };
                U2C_UnionListResponse r2c_roleEquip = (U2C_UnionListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                if (instanceid != self.InstanceId)
                {
                    return;
                }
                if (r2c_roleEquip.Error != ErrorCode.ERR_Success)
                {
                    return;
                }
                self.UnionList = r2c_roleEquip.UnionList;
            }
            self.UnionList.Sort(delegate( UnionListItem a, UnionListItem b )
            {
                int unionlevela = a.UnionLevel;
                int unionlevelb = b.UnionLevel;
                int numbera = a.PlayerNumber;
                int numberb = b.PlayerNumber;

                if (numbera == numberb)
                {
                    return unionlevelb - unionlevela;
                }
                else
                { 
                    return numberb - numbera;   
                }
            });

            List<Entity> childs = self.Children.Values.ToList();
            for (int i = 0; i < self.UnionList.Count; i++)
            {
                if (i < childs.Count)
                {
                    (childs[i] as UIUnionListItemComponent).OnUpdateUI(self.UnionList[i]);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIUnionListItem);
                    go.SetActive(true);
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
