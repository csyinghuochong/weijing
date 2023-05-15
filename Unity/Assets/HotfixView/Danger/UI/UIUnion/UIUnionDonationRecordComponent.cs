using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionDonationRecordComponent : Entity, IAwake
    {
        public GameObject BuildingList;
        public GameObject ButtonClose;
    }

    public class UIUnionDonationRecordComponentAwake : AwakeSystem<UIUnionDonationRecordComponent>
    {
        public override void Awake(UIUnionDonationRecordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIUnionDonationRecord); });

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIUnionDonationRecordComponentSystem
    {
        public static async ETTask OnInitUI(this UIUnionDonationRecordComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long unionid = numericComponent.GetAsLong(NumericType.UnionId_0);
            C2U_UnionRecordRequest request = new C2U_UnionRecordRequest() { UnionId = unionid };
            U2C_UnionRecordResponse response = (U2C_UnionRecordResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Union/UIUnionDonationRecordItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            for (int i = 0; i < response.DonationRecords.Count; i++)
            {
                GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(gameObject, self.BuildingList);
                UIUnionDonationRecordItemComponent recodeItemComponent = self.AddChild<UIUnionDonationRecordItemComponent, GameObject>(gameObject);
                recodeItemComponent.OnInitUI(response.DonationRecords[i]);
            }
        }
    }
}
