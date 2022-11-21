using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.TowerOpenTimer)]
    public class TowerOpenTimer : ATimer<UITowerOpenComponent>
    {
        public override void Run(UITowerOpenComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UITowerOpenComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextTip;
        public GameObject Lab_ChapterName;
        public GameObject PostionSet;
        public GameObject ObjImageDi;
        public long Timer;
        public float PassTime;

        public M2C_FubenSettlement M2C_FubenSettlement;
    }

    [ObjectSystem]
    public class TowerOpenComponentDestroy : DestroySystem<UITowerOpenComponent>
    {
        public override void Destroy(UITowerOpenComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UITowerOpenComponentAwake : AwakeSystem<UITowerOpenComponent>
    {
        public override void Awake(UITowerOpenComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            self.Lab_ChapterName = gameObject.Get<GameObject>("Lab_ChapterName");
            self.PostionSet = gameObject.Get<GameObject>("PostionSet");
            self.ObjImageDi = gameObject.Get<GameObject>("ImageDi");
            self.TextTip = gameObject.Get<GameObject>("TextTip");
            self.PassTime = 0f;
            self.M2C_FubenSettlement = null;
        }
    }

    public static class UITowerOpenComponentSystem
    {
        public static void OnTimer(this UITowerOpenComponent self)
        {
            self.PassTime += Time.deltaTime;
            if (self.PassTime < 2f)
            {
                float colorValue = 0.3f - 0.3f * self.PassTime / 2f;
                self.ObjImageDi.GetComponent<Image>().color = new Color(0, 0, 0, colorValue);
                self.Lab_ChapterName.GetComponent<Text>().color = new Color(1, 1, 1, 1 - self.PassTime / 2f);
                self.PostionSet.SetActive(false);
            }
            else
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }



        public static async ETTask OnFubenResult(this UITowerOpenComponent self, M2C_FubenSettlement message)
        {
            self.M2C_FubenSettlement = message;
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UITowerFightReward);
            ui.GetComponent<UITowerFightRewardComponent>().OnUpdateUI(message);
        }

        public static void OnUpdateUI(this UITowerOpenComponent self, int towerId)
        {
            self.PassTime = 0;
            self.PostionSet.SetActive(true);
            self.ObjImageDi.GetComponent<Image>().color = new Color(0, 0, 0, 1);
            self.Lab_ChapterName.GetComponent<Text>().color = new Color(1, 1, 1, 1);
            self.Lab_ChapterName.GetComponent<Text>().text = TowerConfigCategory.Instance.Get(towerId).Name;
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.TowerOpenTimer, self);

            self.TextTip.GetComponent<Text>().text = "挑战之地：" + TowerConfigCategory.Instance.Get(towerId).CengNum + "/" + "30";
        }
    }
}
