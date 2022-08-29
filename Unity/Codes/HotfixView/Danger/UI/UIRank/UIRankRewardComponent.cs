using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ET
{

    public class UIRankRewardComponent : Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject RewardListNode;
        public Action ClickOnClose;
    }

    [ObjectSystem]
    public class UIRankRewardComponentAwakeSystem : AwakeSystem<UIRankRewardComponent>
    {
        public override void Awake(UIRankRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIRankRewardComponentSytstem
    {
        public static void OnCloseButton(this UIRankRewardComponent self)
        {
            self.ClickOnClose?.Invoke();
            UIHelper.Remove( self.ZoneScene(), UIType.UIRankReward).Coroutine();
        }

        public static async ETTask OnInitUI(this UIRankRewardComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Rank/UIRankRewardItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            List<RankRewardConfig> rankRewardConfigs = RankRewardConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < rankRewardConfigs.Count; i++ )
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.RewardListNode);
                self.AddChild<UIRankRewardItemComponent, GameObject>(go, true).OnUpdateUI(rankRewardConfigs[i]);
            }
        }
    }
}
