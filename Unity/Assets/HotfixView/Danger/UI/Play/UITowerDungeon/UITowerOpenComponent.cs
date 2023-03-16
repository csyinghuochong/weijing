using System;
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

            self.RequestBegin();
        }
    }

    public static class UITowerOpenComponentSystem
    {
        public static void RequestBegin(this UITowerOpenComponent self)
        {
            C2M_TowerFightBeginRequest request = new C2M_TowerFightBeginRequest();
            self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request).Coroutine();
        }

        public static void OnTimer(this UITowerOpenComponent self)
        {
            self.PassTime += Time.deltaTime;
            if (self.PassTime < 2f)
            {
                float colorValue = 0.3f - 0.3f * self.PassTime / 2f;
                self.ObjImageDi.GetComponent<Image>().color = new Color(0, 0, 0, colorValue);
                self.Lab_ChapterName.GetComponent<Text>().color = new Color(1, 1, 1, 1 - self.PassTime / 2f);
            }
            else
            {
                self.PostionSet.SetActive(false);
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void RequestTowerQuit(this UITowerOpenComponent self)
        {
            PopupTipHelp.OpenPopupTip(self.DomainScene(), "", GameSettingLanguge.LoadLocalization("战斗未结束，是否领取奖励？"),
                () =>
                {
                    C2M_TowerExitRequest request = new C2M_TowerExitRequest();
                    self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request).Coroutine();
                },
                null).Coroutine();
        }

        public static async ETTask OnFubenResult(this UITowerOpenComponent self, M2C_FubenSettlement message)
        {
            long instanceId = self.InstanceId;
            self.M2C_FubenSettlement = message;
            TimerComponent.Instance.Remove(ref self.Timer);
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UITowerFightReward);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            ui.GetComponent<UITowerFightRewardComponent>()?.OnUpdateUI(message);
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

            int numMax = 30;

            //难度传进来  if(towerId)
            if(self.ZoneScene().GetComponent<MapComponent>().FubenDifficulty == 1)
            {
                numMax = 30;
            }
            if (self.ZoneScene().GetComponent<MapComponent>().FubenDifficulty == 2)
            {
                numMax = 40;
            }
            if (self.ZoneScene().GetComponent<MapComponent>().FubenDifficulty == 3)
            {
                numMax = 50;
            }
            self.TextTip.GetComponent<Text>().text = "挑战之地：" + TowerConfigCategory.Instance.Get(towerId).CengNum + "/" + numMax;
        }
    }
}
