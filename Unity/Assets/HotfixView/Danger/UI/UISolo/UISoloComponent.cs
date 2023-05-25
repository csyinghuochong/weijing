using UnityEngine;
using System;
using UnityEngine.UI;

namespace ET
{
    public class UISoloComponent : Entity, IAwake
    {
        public GameObject ButtonMatch;
        public GameObject Text_Result;
        public GameObject Text_Match;

        public bool PipeiStatus;        //匹配状态
    }

    public class UISoloComponentAwake : AwakeSystem<UISoloComponent>
    {
        public override void Awake(UISoloComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonMatch = rc.Get<GameObject>("ButtonMatch");
            ButtonHelp.AddListenerEx(self.ButtonMatch, () => { self.OnButtonMatch().Coroutine();  });

            self.Text_Result = rc.Get<GameObject>("Text_Result");
            self.Text_Match = rc.Get<GameObject>("Text_Match");


            //初始化
            self.Init();
        }
    }

    public static class UISoloComponentSystem
    {

        //初始化
        public static void Init(this UISoloComponent self) {
            self.ShowZhanJi();
        }

        public static async ETTask OnButtonMatch(this UISoloComponent self)
        {
            //此处只是在界面中申请,重新打开界面允许重新匹配
            if (self.PipeiStatus)
            {
                FloatTipManager.Instance.ShowFloatTip("已经匹配，请耐心等候...");
                return;
            }

            //点击按钮给服务器发送匹配消息
            int errorCode = await NetHelper.RequestSoloMatch(self.ZoneScene());
            if (errorCode == 0) {
                FloatTipManager.Instance.ShowFloatTip("开始匹配，请耐心等候...");
                self.PipeiStatus = true;
            }


            //点击匹配设置时间
            self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime = TimeHelper.ServerNow();

            //显示匹配时间
            self.ShowPiPeiTime().Coroutine();

        }

        //显示当前战绩
        public static void ShowZhanJi(this UISoloComponent self) {

            self.Text_Result.GetComponent<Text>().text = $"{0}胜{0}败";


        }


        public static async ETTask ShowPiPeiTime(this UISoloComponent self)
        {
            long startTime = self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime = TimeHelper.ServerNow();
            //获取匹配时间
            DateTime startDateTime = TimeInfo.Instance.ToDateTime(startTime);

            while (!self.IsDisposed)
            {

                DateTime nowDateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ClientNow());

                TimeSpan timeCha = nowDateTime - startDateTime;

          
                self.Text_Match.GetComponent<Text>().text = $"匹配时间:{timeCha.Minutes}分{timeCha.Seconds}秒";

                //1秒刷新一次
                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }
    }
}
