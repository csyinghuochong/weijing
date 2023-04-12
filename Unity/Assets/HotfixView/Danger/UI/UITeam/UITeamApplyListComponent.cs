using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamApplyListComponent : Entity, IAwake
    {
        public GameObject Img_Button;
        public GameObject ApplyListNode;

        public List<UI> ApplyUIList = new List<UI>();
    }


    public class UITeamApplyListComponentAwakeSystem : AwakeSystem<UITeamApplyListComponent>
    {
        public override void Awake(UITeamApplyListComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Img_Button = rc.Get<GameObject>("Img_Button");
            ButtonHelp.AddListenerEx(self.Img_Button, self.OnImg_Button);

            self.ApplyListNode = rc.Get<GameObject>("ApplyListNode");

            self.ApplyUIList.Clear();
            self.OnUpdateUI();
        }
    }

    public static class UITeamApplyListComponentSystem
    {
        public static void OnImg_Button(this UITeamApplyListComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UITeamApplyList);
        }

        public static void  OnUpdateUI(this UITeamApplyListComponent self)
        {
            List<TeamPlayerInfo> teamPlayerInfos = self.ZoneScene().GetComponent<TeamComponent>().ApplyList;

            var path = ABPathHelper.GetUGUIPath("Main/Team/UITeamApplyItem");
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < teamPlayerInfos.Count; i++)
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
                    UICommonHelper.SetParent(go, self.ApplyListNode);

                    uI_1 = self.AddChild<UI, string, GameObject>("UIItem_" + i, go);
                    UITeamApplyItemComponent uIItemComponent = uI_1.AddComponent<UITeamApplyItemComponent>();
                    self.ApplyUIList.Add(uI_1);
                }
                uI_1.GetComponent<UITeamApplyItemComponent>().OnUpdateUI(teamPlayerInfos[i]);
            }
            for (int i = teamPlayerInfos.Count; i < self.ApplyUIList.Count; i++)
            {
                self.ApplyUIList[i].GameObject.SetActive(false);
            }
        }
    }
}
