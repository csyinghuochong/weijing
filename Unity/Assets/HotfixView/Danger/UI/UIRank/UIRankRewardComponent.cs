using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIRankRewardComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_Tip;
        public GameObject CloseButton;
        public GameObject RewardListNode;
        public Action ClickOnClose;
    }


    public class UIRankRewardComponentAwakeSystem : AwakeSystem<UIRankRewardComponent>
    {
        public override void Awake(UIRankRewardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseButton(); });

            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
            self.OnInitUI(1);
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIRankRewardComponentDestroySystem : DestroySystem<UIRankRewardComponent>
    {
        public override void Destroy(UIRankRewardComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UIRankRewardComponentSytstem
    {
        public static void OnLanguageUpdate(this UIRankRewardComponent self)
        {
            self.Text_Tip.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 28;
        }

        public static void OnCloseButton(this UIRankRewardComponent self)
        {
            self.ClickOnClose?.Invoke();
        }

        public static  void OnInitUI(this UIRankRewardComponent self, int rankType)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Rank/UIRankRewardItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
         
            List<RankRewardConfig> rankRewardConfigs = RankHelper.GetTypeRankRewards(1);
            for (int i = 0; i < rankRewardConfigs.Count; i++ )
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.RewardListNode);
                self.AddChild<UIRankRewardItemComponent, GameObject>(go, true).OnUpdateUI(rankRewardConfigs[i]);
            }
        }
    }
}
