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
        public GameObject Text_IntegraList;

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
            self.Text_IntegraList = rc.Get<GameObject>("Text_IntegraList");


            //初始化
            self.Init();
        }
    }

    public static class UISoloComponentSystem
    {

        //初始化
        public static void Init(this UISoloComponent self) {

            self.ShowZhanJi().Coroutine();
            //显示匹配时间
            self.ShowPiPeiTime().Coroutine();
        }

        public static async ETTask OnButtonMatch(this UISoloComponent self)
        {
            //此处只是在界面中申请,重新打开界面允许重新匹配
            if (self.PipeiStatus && self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime>0)
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
        public static async ETTask ShowZhanJi(this UISoloComponent self) {

            //请求战绩
            C2S_SoloMyInfoRequest request = new C2S_SoloMyInfoRequest() { };
            S2C_SoloMyInfoResponse response = (S2C_SoloMyInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error == ErrorCode.ERR_Success) {
                self.Text_Result.GetComponent<Text>().text = $"{response.WinTime}胜{response.FailTime}败";
                self.Text_IntegraList.GetComponent<Text>().text = $"积分:{response.MathTime}";
            }

            //显示列表
            /*
            string path = ABPathHelper.GetUGUIPath("Solo/UISoloResultShow");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            long selfId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            int myRank = -1;
            for (int i = 0; i < r2C_Response.RankList.Count; i++)
            {
                if (i % 5 == 0)
                {
                    await TimerComponent.Instance.WaitAsync(1);
                }
                if (instanceid != self.InstanceId)
                {
                    return;
                }

                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, self.RankListNode);
                UI ui_1 = self.AddChild<UI, string, GameObject>("rewardItem_" + i, skillItem);
                UIRankShowItemComponent uIItemComponent = ui_1.AddComponent<UIRankShowItemComponent>();
                uIItemComponent.OnInitData(i + 1, r2C_Response.RankList[i]);
             */



        }


        public static async ETTask ShowPiPeiTime(this UISoloComponent self)
        {
            if (self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime == 0) {
                self.Text_Match.GetComponent<Text>().text = $"点击下方开始匹配对手";
                return;
            }

            long startTime = self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime;

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
