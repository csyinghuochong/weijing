using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChouKaRewardItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject UICommonItem;
        public GameObject TextZuanshi;
        public GameObject Btn_Reward;
        public GameObject TextNeedTimes;
        public TakeCardRewardConfig TakeCardRewardConfig;
    }

    [ObjectSystem]
    public class UIChouKaRewardItemComponentAwakeSystem : AwakeSystem<UIChouKaRewardItemComponent, GameObject>
    {
        public override void Awake(UIChouKaRewardItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.TextZuanshi = rc.Get<GameObject>("TextZuanshi");

            self.Btn_Reward = rc.Get<GameObject>("Btn_Reward");
            ButtonHelp.AddListenerEx(self.Btn_Reward, () => { self.OnBtn_Reward().Coroutine();  });

            self.TextNeedTimes = rc.Get<GameObject>("TextNeedTimes");
        }
    }

    public static class UIChouKaRewardItemComponentSystem
    {

        public static async ETTask OnBtn_Reward(this UIChouKaRewardItemComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            bool received = userInfoComponent.UserInfo.ChouKaRewardIds.Contains(self.TakeCardRewardConfig.Id);
            if (received)
            {
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ChouKa) < self.TakeCardRewardConfig.RoseLvLimit)
            {
                FloatTipManager.Instance.ShowFloatTip("条件未达到！");
                return;
            }

            C2M_ChouKaRewardRequest request = new C2M_ChouKaRewardRequest() { RewardId = self.TakeCardRewardConfig.Id };
            M2C_ChouKaRewardResponse response = (M2C_ChouKaRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error == ErrorCore.ERR_Success)
            {
                userInfoComponent.UserInfo.ChouKaRewardIds.Add(self.TakeCardRewardConfig.Id);
            }
            self.UpdateButton();
        }

        public static void UpdateButton(this UIChouKaRewardItemComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            bool received = userInfoComponent.UserInfo.ChouKaRewardIds.Contains(self.TakeCardRewardConfig.Id);
            self.Btn_Reward.SetActive(!received);
        }

        public static void OnUpdateUI(this UIChouKaRewardItemComponent self, TakeCardRewardConfig takeCardRewardConfig)
        {
            self.TakeCardRewardConfig = takeCardRewardConfig;
            UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>( self.UICommonItem );
            string[] iteminfo = takeCardRewardConfig.RewardItems.Split(';');
            uIItemComponent.UpdateItem(new BagInfo() 
            {
                ItemID = int.Parse(iteminfo[0]),
                ItemNum = int.Parse(iteminfo[1]),
            }, ItemOperateEnum.None);

            self.TextZuanshi.GetComponent<Text>().text = $"{takeCardRewardConfig.RewardDiamond[0]}-{takeCardRewardConfig.RewardDiamond[1]}";
            self.TextNeedTimes.GetComponent<Text>().text = $"抽卡次数达到{takeCardRewardConfig.RoseLvLimit}次";

            self.UpdateButton();
        }
    }
}
