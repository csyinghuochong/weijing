using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1ConsumeComponent: Entity, IAwake
    {
        public GameObject UIActivityV1ConsumeListNode;
        public GameObject UIActivityV1ConsumeItem;
        public GameObject ConsumeNumText;
    }

    public class UIActivityV1ConsumeComponentAwake: AwakeSystem<UIActivityV1ConsumeComponent>
    {
        public override void Awake(UIActivityV1ConsumeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIActivityV1ConsumeListNode = rc.Get<GameObject>("UIActivityV1ConsumeListNode");
            self.UIActivityV1ConsumeItem = rc.Get<GameObject>("UIActivityV1ConsumeItem");
            self.ConsumeNumText = rc.Get<GameObject>("ConsumeNumText");

            self.UIActivityV1ConsumeItem.SetActive(false);

            self.GetInfo().Coroutine();
        }
    }

    public static class UIActivityV1ConsumeComponentSystem
    {
        public static async ETTask GetInfo(this UIActivityV1ConsumeComponent self)
        {
            C2M_ActivityInfoRequest request = new C2M_ActivityInfoRequest();
            M2C_ActivityInfoResponse response =
                    (M2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            self.InitInfo();
        }

        public static void InitInfo(this UIActivityV1ConsumeComponent self)
        {
            foreach (int key in ActivityConfigHelper.ConsumeDiamondReward.Keys)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1ConsumeItem);
                UIActivityV1ConsumeItemComponent component = self.AddChild<UIActivityV1ConsumeItemComponent, GameObject>(go);
                component.OnUpdateData(key);
                UICommonHelper.SetParent(go, self.UIActivityV1ConsumeListNode);
                go.SetActive(true);
            }

            self.ConsumeNumText.GetComponent<Text>().text =
                    $"{UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>().GetAsLong(NumericType.V1DayCostDiamond)}钻石";
        }
    }
}