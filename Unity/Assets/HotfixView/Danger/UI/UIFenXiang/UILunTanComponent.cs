using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UILunTanComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_Tip;
        public GameObject Text_Tip_TapTap;
        public GameObject ButtonGet;
        public GameObject ButtonTapTap;
        public GameObject TapTapShare;

        public int ShareType;
    }

    public class UILunTanComponentAwake : AwakeSystem<UILunTanComponent>
    {
        public override void Awake(UILunTanComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
            self.Text_Tip_TapTap = rc.Get<GameObject>("Text_Tip_TapTap");
            
            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet(); });


            self.ButtonTapTap = rc.Get<GameObject>("ButtonTapTap");
            self.TapTapShare = rc.Get<GameObject>("TapTapShare");
            ButtonHelp.AddListenerEx(self.ButtonTapTap, self.OnButton_Taptap);
            self.TapTapShare.SetActive(GlobalHelp.GetBigVersion() >= 20 && GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));

            GameObject.Find("Global").GetComponent<Init>().OnShareHandler = (int pType, bool value) => { self.OnShareHandler(pType, value).Coroutine(); };
            
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
        }
    }

    public class UILunTanComponentDestroySystem : DestroySystem<UILunTanComponent>
    {
        public override void Destroy(UILunTanComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }
    
    public static class UILunTanComponentSystem
    {
        public static void OnLanguageUpdate(this UILunTanComponent self)
        {
            self.Text_Tip.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 30;
            self.Text_Tip_TapTap.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 30;
        }

        public static async ETTask OnShareHandler(this UILunTanComponent self, int pType, bool share)
        {
            //1 4微信  2 5QQ     8 taptap
            int sType = self.ShareType;
            if (sType != 1 && sType != 2 && sType != 8)
            {
                return;
            }
            Log.ILog.Debug($"分享回调：  {pType} {share}");
            if (sType == 8 && !share)
            {
                Log.ILog.Debug($"分享回调TapTap：  {pType} {share}");
                FloatTipManager.Instance.ShowFloatTipDi("TapTap未安装或该版本不支持分享！");
                return;
            }


            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            if (taskComponent.GetHuoYueDu() < 30)
            {
                FloatTipManager.Instance.ShowFloatTip("活跃度低于30没有奖励！");
                return;
            }

            long instanceid = self.InstanceId;
            C2M_ShareSucessRequest c2M_ShareSucessRequest = new C2M_ShareSucessRequest() { ShareType = sType };
            await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_ShareSucessRequest);
            if (instanceid != self.InstanceId)
            {
                return;
            }
        }

        public static void OnButton_Taptap(this UILunTanComponent self)
        {
            if (UnitHelper.IsShared(self.ZoneScene(), 8))
            {
                Log.Debug("已经领取过taptap奖励");
            }

            self.ShareType = 8;
            EventType.TapTapShare.Instance.ZoneScene = self.ZoneScene();
            EventType.TapTapShare.Instance.Content = $"{ConfigHelper.TapTapShareTitle}&{ConfigHelper.TapTapShareContent}";
            Game.EventSystem.PublishClass(EventType.TapTapShare.Instance);
        }

        
        public static void OnButtonGet(this UILunTanComponent self)
        {
            Application.OpenURL("https://l.tapdb.net/jYTd08hD?channel=rep-rep_6t3lta8ujdb_h5url65");
        }
    }
}
