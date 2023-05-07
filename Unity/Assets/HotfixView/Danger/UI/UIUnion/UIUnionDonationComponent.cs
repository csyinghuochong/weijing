using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionDonationComponent : Entity, IAwake
    {
        public GameObject Text_Tip_4;
        public GameObject Text_Tip_3;
        public GameObject Button_Donation;
        public GameObject Button_Race;
    }

    public class UIUnionDonationComponentAwake : AwakeSystem<UIUnionDonationComponent>
    {
        public override void Awake(UIUnionDonationComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip_4 = rc.Get<GameObject>("Text_Tip_4");
            self.Text_Tip_3 = rc.Get<GameObject>("Text_Tip_3");

            self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            ButtonHelp.AddListenerEx(self.Button_Donation, () => { self.OnButton_Donation().Coroutine(); });

            self.Button_Race = rc.Get<GameObject>("Button_Race");
            ButtonHelp.AddListenerEx(self.Button_Donation, () => { self.OnButton_Race(); });
            self.Button_Race.SetActive( FunctionHelp.IsInUnionRaceTime() );

            self.OnUpdateUI();
        }
    }

    public static class UIUnionDonationComponentSystem
    {

        public static void OnUpdateUI(this UIUnionDonationComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.Text_Tip_4.GetComponent<Text>().text = $"捐献次数： {unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber)}/10次";
        }

        public static void OnButton_Race(this UIUnionDonationComponent self)
        {
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.UnionRace, 2000008).Coroutine();
        }

        public static async ETTask OnButton_Donation(this UIUnionDonationComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionDonationNumber)>= 10)
            {
                FloatTipManager.Instance.ShowFloatTip("捐献次数已达上限！");
                return;
            }

            C2M_UnionDonationRequest  request = new C2M_UnionDonationRequest() { };
            M2C_UnionDonationResponse response = (M2C_UnionDonationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.OnUpdateUI();
        }
    }
}
