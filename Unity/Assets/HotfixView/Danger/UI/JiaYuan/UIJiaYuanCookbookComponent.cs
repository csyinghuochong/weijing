using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UIJiaYuanCookbookComponent : Entity, IAwake
    {
        public GameObject ScorllListNode;

        public List<UIJiaYuanCookbookItemComponent> CookBookList = new List<UIJiaYuanCookbookItemComponent>();
    }

    public class UIJiaYuanCookbookComponentAwake : AwakeSystem<UIJiaYuanCookbookComponent>
    {
        public override void Awake(UIJiaYuanCookbookComponent self)
        {
            self.CookBookList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ScorllListNode = rc.Get<GameObject>("ScorllListNode");

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;  
        }
    }

    public static class UIJiaYuanCookbookComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanCookbookComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanCookbookItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();

            List<int> foodlist = ItemConfigCategory.Instance.FoodList;
            for (int i = 0; i < foodlist.Count; i++)
            {
                UIJiaYuanCookbookItemComponent uI_1 = null;
                if (i < self.CookBookList.Count)
                {
                    uI_1 = self.CookBookList[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ScorllListNode);
                    uI_1 = self.AddChild<UIJiaYuanCookbookItemComponent, GameObject>(go);
                    self.CookBookList.Add(uI_1);
                }
                uI_1.OnUpdateUI(foodlist[i], jiaYuanComponent.LearnMakeIds_3.Contains(foodlist[i]));
            }
        }
    }
}
