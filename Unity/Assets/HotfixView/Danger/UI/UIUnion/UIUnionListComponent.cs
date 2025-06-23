using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionListComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject Text_Tip5;
        public GameObject Text_Tip4;
        public GameObject Text_Tip3;
        public GameObject Text_Tip2;
        public GameObject Text_Tip1;
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
            self.Text_Tip5 = rc.Get<GameObject>("Text_Tip5");
            self.Text_Tip4 = rc.Get<GameObject>("Text_Tip4");
            self.Text_Tip3 = rc.Get<GameObject>("Text_Tip3");
            self.Text_Tip2 = rc.Get<GameObject>("Text_Tip2");
            self.Text_Tip1 = rc.Get<GameObject>("Text_Tip1");
            self.UnionListNode = rc.Get<GameObject>("UnionListNode");
            self.UIUnionListItem = rc.Get<GameObject>("UIUnionListItem");
            self.UIUnionListItem.SetActive(false);
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }
    
    public class UIUnionListComponentDestroySystem : DestroySystem<UIUnionListComponent>
    {
        public override void Destroy(UIUnionListComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UIUnionListComponentSystem
    {
        public static void OnLanguageUpdate(this UIUnionListComponent self)
        {
            self.Text_Tip5.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_Tip4.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_Tip3.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_Tip2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            self.Text_Tip1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 40 : 32;
            
            self.Text_Tip2.GetComponent<Text>().text = GameSettingLanguge.Language == 0? "等级" : "Level";
        }

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
