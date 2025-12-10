using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1PointsComponent : Entity, IAwake
    {
        public GameObject Text_CurWeek;
        public GameObject UIActivityV1PointsListNode;
        public GameObject UIActivityV1PointsItem;
        public GameObject ConsumeNumText;
    }

    public class UIActivityV1PointsComponentAwake : AwakeSystem<UIActivityV1PointsComponent>
    {
        public override void Awake(UIActivityV1PointsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIActivityV1PointsListNode = rc.Get<GameObject>("UIActivityV1PointsListNode");
            self.UIActivityV1PointsItem = rc.Get<GameObject>("UIActivityV1PointsItem");
            self.ConsumeNumText = rc.Get<GameObject>("ConsumeNumText");
            self.Text_CurWeek = rc.Get<GameObject>("Text_CurWeek");

            self.UIActivityV1PointsItem.SetActive(false);
            self.Text_CurWeek.GetComponent<Text>().text = UICommonHelper.GetCurrentWeekRange();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.GetInfo().Coroutine();
        }
    }

    public static class UIActivityV1PointsComponentSystem
    {
        public static void OnUpdateUI(this UIActivityV1PointsComponent self)
        {
            self.OnRecvHandler();
        }


        public static async ETTask GetInfo(this UIActivityV1PointsComponent self)
        {
            C2M_ActivityInfoRequest request = new C2M_ActivityInfoRequest();
            M2C_ActivityInfoResponse response =
                    (M2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            self.InitInfo();
        }

        public static void InitInfo(this UIActivityV1PointsComponent self)
        {
            foreach (int key in ActivityConfigHelper.PointsRewardList.Keys)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1PointsItem);
                UIActivityV1PointsItemComponent component = self.AddChild<UIActivityV1PointsItemComponent, GameObject>(go);
                component.OnUpdateData(key, self.OnRecvHandler);
                UICommonHelper.SetParent(go, self.UIActivityV1PointsListNode);
                go.SetActive(true);
            }

            self.OnRecvHandler();
        }

        public static void OnRecvHandler(this UIActivityV1PointsComponent self)
        {
            int points = (int)(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.V1TotalPoints);

            self.ConsumeNumText.GetComponent<Text>().text =
                   string.Format(GameSettingLanguge.LoadLocalization("{0}积分"), points);
        }
    }
}