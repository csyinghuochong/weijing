using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionDonationRecordComponent : Entity, IAwake
    {
        public GameObject BuildingList;
        public GameObject UIUnionDonationRecordItem;
        public GameObject ButtonClose;
    }

    public class UIUnionDonationRecordComponentAwake : AwakeSystem<UIUnionDonationRecordComponent>
    {
        public override void Awake(UIUnionDonationRecordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.UIUnionDonationRecordItem = rc.Get<GameObject>("UIUnionDonationRecordItem");
            self.UIUnionDonationRecordItem.SetActive(false);

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
            long instanceId = self.InstanceId;
            C2U_UnionRecordRequest request = new C2U_UnionRecordRequest() { UnionId = unionid };
            U2C_UnionRecordResponse response = (U2C_UnionRecordResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            for (int i = 0; i < response.DonationRecords.Count; i++)
            {
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                GameObject gameObject = GameObject.Instantiate(self.UIUnionDonationRecordItem);
                gameObject.SetActive(true);
                UICommonHelper.SetParent(gameObject, self.BuildingList);
                UIUnionDonationRecordItemComponent recodeItemComponent = self.AddChild<UIUnionDonationRecordItemComponent, GameObject>(gameObject);
                recodeItemComponent.OnInitUI(response.DonationRecords[i]);
            }
        }
    }
}
