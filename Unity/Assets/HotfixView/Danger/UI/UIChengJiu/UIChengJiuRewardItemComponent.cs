using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuRewardItemComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Received;
        public GameObject XuanZhong;
        public GameObject ChengJiuNum;
        public GameObject ChengJiuIcon;
        public GameObject DiButton;

        public Action<int> ClickHandler;
        public int ChengJiuRewardId;
        public GameObject GameObject;
        public List<string> AssetPath = new List<string>();
    }


    public class UIChengJiuRewardItemComponentAwakeSystem : AwakeSystem<UIChengJiuRewardItemComponent, GameObject>
    {

        public override void Awake(UIChengJiuRewardItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.XuanZhong = rc.Get<GameObject>("XuanZhong");
            self.XuanZhong.SetActive(false);

            self.ChengJiuNum = rc.Get<GameObject>("ChengJiuNum");
            self.ChengJiuIcon = rc.Get<GameObject>("ChengJiuIcon");
            self.DiButton = rc.Get<GameObject>("DiButton");
            self.Received = rc.Get<GameObject>("Received");
            self.DiButton.GetComponent<Button>().onClick.AddListener(() => { self.OnClick_DiButton(); });
        }
    }
    public class UIChengJiuRewardItemComponentDestroy : DestroySystem<UIChengJiuRewardItemComponent>
    {
        public override void Destroy(UIChengJiuRewardItemComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
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

        public static void OnInitData(this UIChengJiuRewardItemComponent self, ChengJiuRewardConfig chengJiuRewardConfig, bool received)
        {

            self.ChengJiuRewardId = chengJiuRewardConfig.Id;

            self.ChengJiuNum.GetComponent<Text>().text = chengJiuRewardConfig.NeedPoint.ToString();
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ChengJiuIcon, chengJiuRewardConfig.Icon.ToString());
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.ChengJiuIcon.GetComponent<Image>().sprite = sp;

            self.Received.SetActive(received);
        }

    }
}
