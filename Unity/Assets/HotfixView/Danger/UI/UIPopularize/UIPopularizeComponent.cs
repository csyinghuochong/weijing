using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPopularizeComponent : Entity, IAwake
    {
        public GameObject Text_Reward_2;
        public GameObject Text_Reward_1;
        public GameObject Text_Button_Copy;
        public GameObject Text_My_Code;
        public GameObject BuildingList;
        public GameObject InputField_Code;
        public GameObject ButtonGet;
        public GameObject ButtonOk;

        public bool BePopularize;

        public List<UIPopularizeItemComponent> PopularizeList = new List<UIPopularizeItemComponent> ();
    }

    public class UIPopularizeComponentAwake : AwakeSystem<UIPopularizeComponent>
    {
        public override void Awake(UIPopularizeComponent self)
        {
            self.PopularizeList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Button_Copy = rc.Get<GameObject>("Text_Button_Copy");
            ButtonHelp.AddListenerEx(self.Text_Button_Copy, self.OnText_Button_Copy);

            self.Text_My_Code = rc.Get<GameObject>("Text_My_Code");
            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.InputField_Code = rc.Get<GameObject>("InputField_Code");

            self.Text_Reward_2 = rc.Get<GameObject>("Text_Reward_2");
            self.Text_Reward_1 = rc.Get<GameObject>("Text_Reward_1");

            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet().Coroutine();  });

            self.ButtonOk = rc.Get<GameObject>("ButtonOk");
            ButtonHelp.AddListenerEx(self.ButtonOk, () => { self.OnButtonOk().Coroutine(); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine(); };
        }
    }

    public static class UIPopularizeComponentSystem
    {

        public static void OnText_Button_Copy(this UIPopularizeComponent self)
        {
            UnityEngine.GUIUtility.systemCopyBuffer = self.Text_My_Code.GetComponent<Text>().text;
        }

        public static async ETTask OnButtonGet(this UIPopularizeComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            C2Popularize_RewardRequest request = new C2Popularize_RewardRequest() { ActorId = userInfoComponent.UserInfo.UserId };
            Popularize2C_RewardResponse response = (Popularize2C_RewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }

            self.ButtonGet.SetActive(false);
        }

        public static async ETTask OnButtonOk(this UIPopularizeComponent self)
        {
            if (self.BePopularize)
            {
                FloatTipManager.Instance.ShowFloatTip("已经作为被推广人");
                return;
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Lv >= 15)
            {
                FloatTipManager.Instance.ShowFloatTip("大于15级不能作为推广人");
                return;
            }

            string inputtext = self.InputField_Code.GetComponent<InputField>().text;
            if (string.IsNullOrEmpty(inputtext))
            {
                return;
            }

            long playerid = 0;
            try
            {
                playerid = long.Parse(inputtext);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return;
            }
            C2Popularize_PlayerRequest request = new C2Popularize_PlayerRequest() { ActorId = userInfoComponent.UserInfo.UserId, PopularizeId = playerid };
            Popularize2C_PlayerResponse response = (Popularize2C_PlayerResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }
            if (response.Error == ErrorCore.ERR_Success)
            {
                self.BePopularize = true;
                self.InputField_Code.GetComponent<InputField>().text = playerid.ToString();
            }
        }

        public static async ETTask OnUpdateUI(this UIPopularizeComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            C2Popularize_ListRequest  request = new C2Popularize_ListRequest() { ActorId= userInfoComponent.UserInfo.UserId };
            Popularize2C_ListResponse response = (Popularize2C_ListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }

            self.BePopularize = response.BePopularizeId > 0;
            self.InputField_Code.GetComponent<InputField>().text = response.BePopularizeId.ToString();
            self.Text_My_Code.GetComponent<Text>().text = $"{response.PopularizeCode}";
            List<RewardItem> rewardlist =  PopularizeHelper.GetRewardList(response.MyPopularizeList);
            int goldReward = 0;
            int diamondReward = 0;
            for (int i = 0; i < rewardlist.Count; i++)
            {
                if (rewardlist[i].ItemID == (int)UserDataType.Gold)
                {
                    goldReward += rewardlist[i].ItemNum;
                    continue;
                }
                if (rewardlist[i].ItemID == (int)UserDataType.Diamond)
                {
                    diamondReward += rewardlist[i].ItemNum;
                    continue;
                }
            }

            self.Text_Reward_1.GetComponent<Text>().text = $"金币： {goldReward}";
            self.Text_Reward_2.GetComponent<Text>().text = $"钻石： {diamondReward}";
            self.ButtonGet.SetActive(rewardlist.Count > 0);

            var path = ABPathHelper.GetUGUIPath("Main/FenXiang/UIPopularizeItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < response.MyPopularizeList.Count; i++)
            {
                UIPopularizeItemComponent uiitem = null;
                if (i < self.PopularizeList.Count)
                {
                    uiitem = self.PopularizeList[i];
                    uiitem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList);
                    uiitem = self.AddChild<UIPopularizeItemComponent, GameObject>(go);
                    self.PopularizeList.Add(uiitem);
                }
                uiitem.OnUpdateUI(response.MyPopularizeList[i]);
            }

            for (int i = response.MyPopularizeList.Count; i < self.PopularizeList.Count; i++)
            {
                self.PopularizeList[i].GameObject.SetActive(false);
            }
        }
    }
}
