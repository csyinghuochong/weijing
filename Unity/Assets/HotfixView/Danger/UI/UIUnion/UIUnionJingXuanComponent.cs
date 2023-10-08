using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{

    public class UIUnionJingXuanComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject ItemNodeList;
        public GameObject JingXuanItem;

        public List<UIUnionJingXuanItemComponent> JingXuanItemList = new List<UIUnionJingXuanItemComponent> ();

        public UnionInfo UnionInfo;
    }

    public class UIUnionJingXuanComponentAwake : AwakeSystem<UIUnionJingXuanComponent>
    {
        public override void Awake(UIUnionJingXuanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.JingXuanItemList.Clear();
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIUnionJingXuan );  });

            self.JingXuanItem = rc.Get<GameObject>("JingXuanItem");
            self.JingXuanItem.SetActive(false);

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
        }
    }

    public static class UIUnionJingXuanComponentSystem
    {

        public static UnionPlayerInfo GetUnionPlayerInfo(this UIUnionJingXuanComponent self, long playerid)
        {
            for (int i = 0; i < self.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (self.UnionInfo.UnionPlayerList[i].UserID == playerid)
                {
                    return self.UnionInfo.UnionPlayerList[i];
                }
            }
            return null;
        }

        public static  void  OnUpdateUI(this UIUnionJingXuanComponent self, UnionInfo  unionInfo)
        {
            self.UnionInfo = unionInfo;

            int number = 0;
            for (int i = 0; i < unionInfo.JingXuanList.Count; i++)
            {
                UnionPlayerInfo unionPlayerInfo = self.GetUnionPlayerInfo(unionInfo.JingXuanList[i]);
                if (unionPlayerInfo == null)
                {
                    continue;
                }

                UIUnionJingXuanItemComponent ui_1 = null;
                if (number < self.JingXuanItemList.Count)
                {
                    ui_1 = self.JingXuanItemList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(self.JingXuanItem);
                    UICommonHelper.SetParent(storeItem, self.ItemNodeList);
                    storeItem.SetActive(true);
                    ui_1 = self.AddChild<UIUnionJingXuanItemComponent, GameObject>(storeItem);
                    self.JingXuanItemList.Add(ui_1);
                }
                ui_1.OnUpdateUI(i, unionPlayerInfo);
                number++;
            }
        }
    }
}