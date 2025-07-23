using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{
    public class UISoloComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonMatch;
        public GameObject Text_Result;
        public GameObject Text_Match;
        public GameObject Text_IntegraList;
        public GameObject SoloResultListNode;

        public bool PipeiStatus;        //匹配状态
        public List<Vector2> UIOldPositionList = new List<Vector2>();
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
            self.SoloResultListNode = rc.Get<GameObject>("SoloResultListNode");

            self.StoreUIdData();
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
            
            //初始化
            self.Init();
        }
    }
    
    public class UISoloComponentDestroy : DestroySystem<UISoloComponent>
    {
        public override void Destroy(UISoloComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public static class UISoloComponentSystem
    {
        public static void StoreUIdData(this UISoloComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextTip_1").GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextTip_2").GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextTip_3").GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextTip_4").GetComponent<RectTransform>().localPosition);
            self.UIOldPositionList.Add(rc.Get<GameObject>("TextTip_5").GetComponent<RectTransform>().localPosition);
        }

        public static void OnLanguageUpdate(this UISoloComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            rc.Get<GameObject>("TextTip_1").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[0] : new Vector2(517f, 166f);
            rc.Get<GameObject>("TextTip_2").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[1] : new Vector2(517f, 76f);
            rc.Get<GameObject>("TextTip_3").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[2] : new Vector2(517f, -9f);
            rc.Get<GameObject>("TextTip_4").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[3] : new Vector2(517f, -95f);
            rc.Get<GameObject>("TextTip_5").GetComponent<RectTransform>().localPosition = GameSettingLanguge.Language == 0? self.UIOldPositionList[4] : new Vector2(517f, -180f);

            rc.Get<GameObject>("TextTip_1").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            rc.Get<GameObject>("TextTip_2").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            rc.Get<GameObject>("TextTip_3").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            rc.Get<GameObject>("TextTip_4").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
            rc.Get<GameObject>("TextTip_5").GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;

            rc.Get<GameObject>("Image_Ranking").GetComponent<RectTransform>().sizeDelta = GameSettingLanguge.Language == 0? new Vector2(300f, 60f) : new Vector2(500f,60f);
            
            self.ButtonMatch.GetComponentInChildren<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 32;
        }

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
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("已经匹配，请耐心等候..."));
                return;
            }

            //点击按钮给服务器发送匹配消息
            int errorCode = await NetHelper.RequestSoloMatch(self.ZoneScene());
            if (errorCode == 0) {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("开始匹配，请耐心等候..."));
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
                self.Text_Result.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("{0}胜{1}败"), response.WinTime, response.FailTime);
                self.Text_IntegraList.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("积分:{0}"), response.MathTime);
            }

            //显示列表
            
            string path = ABPathHelper.GetUGUIPath("Solo/UISoloResultShow");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            //long selfId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            //int myRank = -1;
            for (int i = 0; i < response.SoloPlayerResultInfoList.Count; i++) {
                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, self.SoloResultListNode);
                UI ui_1 = self.AddChild<UI, string, GameObject>("rewardItem_" + i, skillItem);
                UISoloResultShowComponent uisolocom = ui_1.AddComponent<UISoloResultShowComponent>();
                uisolocom.OnInit(response.SoloPlayerResultInfoList[i], i + 1);
            }
        }


        public static async ETTask ShowPiPeiTime(this UISoloComponent self)
        {
            if (self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime == 0) {
                self.Text_Match.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization("点击下方开始匹配对手");
                return;
            }

            long startTime = self.ZoneScene().GetComponent<BattleMessageComponent>().SoloPiPeiStartTime;

            //获取匹配时间
            DateTime startDateTime = TimeInfo.Instance.ToDateTime(startTime);

            while (!self.IsDisposed)
            {

                DateTime nowDateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ClientNow());

                TimeSpan timeCha = nowDateTime - startDateTime;

          
                self.Text_Match.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("匹配时间:{0}分{1}秒"), timeCha.Minutes, timeCha.Seconds);

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
