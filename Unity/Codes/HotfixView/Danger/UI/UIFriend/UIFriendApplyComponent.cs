using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIFriendApplyComponent : Entity, IAwake
    {
        public GameObject ApplyNodeList;
        public List<UI> ApplyUIList = new List<UI>();
        public FriendComponent FriendComponent;
    }

    [ObjectSystem]
    public class UIFriendApplyComponentAwakeSystem : AwakeSystem<UIFriendApplyComponent>
    {
        public override void Awake(UIFriendApplyComponent self)
        {
            self.ApplyUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.FriendComponent = self.ZoneScene().GetComponent<FriendComponent>();

            self.ApplyNodeList = rc.Get<GameObject>("ApplyNodeList");
            self.OnUpdateApplyList().Coroutine();
        }
    }


    public static class UIFriendApplyComponentSystem
    {
        public static async ETTask OnUpdateApplyList(this UIFriendApplyComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Friend/UIFriendApplyItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < self.FriendComponent.ApplyList.Count; i++)
            {
                UI uI_1 = null;
                if (i < self.ApplyUIList.Count)
                {
                    uI_1 = self.ApplyUIList[i];
                    uI_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ApplyNodeList);
                    uI_1 = self.AddChild<UI, string, GameObject>("UIItem_" + i, go);
                    UIFriendApplyItemComponent uIItemComponent = uI_1.AddComponent<UIFriendApplyItemComponent>();
                    self.ApplyUIList.Add(uI_1);
                }
                uI_1.GetComponent<UIFriendApplyItemComponent>().OnUpdateUI(self.FriendComponent.ApplyList[i]);
            }
            for (int i = self.FriendComponent.ApplyList.Count; i < self.ApplyUIList.Count; i++)
            {
                self.ApplyUIList[i].GameObject.SetActive(false);
            }
        }

    }
}
