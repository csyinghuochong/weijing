using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuRewardItemComponent : Entity, IAwake
    {
        public GameObject XuanZhong;
        public GameObject ChengJiuNum;
        public GameObject ChengJiuIcon;
        public GameObject DiButton;

        public Action<int> ClickHandler;
        public int ChengJiuRewardId;
    }

    [ObjectSystem]
    public class UIChengJiuRewardItemComponentAwakeSystem : AwakeSystem<UIChengJiuRewardItemComponent>
    {

        public override void Awake(UIChengJiuRewardItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.XuanZhong = rc.Get<GameObject>("XuanZhong");
            self.XuanZhong.SetActive(false);

            self.ChengJiuNum = rc.Get<GameObject>("ChengJiuNum");
            self.ChengJiuIcon = rc.Get<GameObject>("ChengJiuIcon");
            self.DiButton = rc.Get<GameObject>("DiButton");
            self.DiButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClick_DiButton(); });
        }
    }

    public static class UIChengJiuRewardItemComponentSystem
    {
        public static void OnClick_DiButton(this UIChengJiuRewardItemComponent self)
        {
            self.ClickHandler(self.ChengJiuRewardId);
        }

        public static void SetSelected(this UIChengJiuRewardItemComponent self, int rewardId)
        {
            self.XuanZhong.SetActive(rewardId == self.ChengJiuRewardId);
        }

        public static void SetClickHanlder(this UIChengJiuRewardItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnInitData(this UIChengJiuRewardItemComponent self, ChengJiuRewardConfig chengJiuRewardConfig)
        {
            self.ChengJiuRewardId = chengJiuRewardConfig.Id;

            self.ChengJiuNum.GetComponent<Text>().text = chengJiuRewardConfig.NeedPoint.ToString();

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ChengJiuIcon, chengJiuRewardConfig.Icon.ToString());
            self.ChengJiuIcon.GetComponent<Image>().sprite = sp;
        }

    }
}
