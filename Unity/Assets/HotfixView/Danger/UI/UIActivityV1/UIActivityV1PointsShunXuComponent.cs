using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1PointsShunXuComponent : Entity, IAwake
    {
        public GameObject Text_CurWeek;
        public GameObject UIActivityV1PointsListNode;
        public GameObject UIActivityV1PointsShunXuItem;
        public GameObject ConsumeNumText;
    }

    public class UIActivityV1PointsShunXuComponentAwake : AwakeSystem<UIActivityV1PointsShunXuComponent>
    {
        public override void Awake(UIActivityV1PointsShunXuComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIActivityV1PointsListNode = rc.Get<GameObject>("UIActivityV1PointsListNode");
            self.UIActivityV1PointsShunXuItem = rc.Get<GameObject>("UIActivityV1PointsShunXuItem");
            self.ConsumeNumText = rc.Get<GameObject>("ConsumeNumText");
            self.Text_CurWeek = rc.Get<GameObject>("Text_CurWeek");

            self.UIActivityV1PointsShunXuItem.SetActive(false);
            self.Text_CurWeek.GetComponent<Text>().text = UICommonHelper.GetCurrentWeekRange();

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.GetInfo().Coroutine();
        }
    }

    public static class UIActivityV1PointsShunXuComponentSystem
    {
        public static void OnUpdateUI(this UIActivityV1PointsShunXuComponent self)
        {
            self.OnRecvHandler();
        }


        public static async ETTask GetInfo(this UIActivityV1PointsShunXuComponent self)
        {
            C2M_ActivityInfoRequest request = new C2M_ActivityInfoRequest();
            M2C_ActivityInfoResponse response =
                    (M2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info = response.ActivityV1Info;

            self.InitInfo();
        }

        public static void InitInfo(this UIActivityV1PointsShunXuComponent self)
        {
            foreach (int key in ActivityConfigHelper.PointsShunXuRewardList.Keys)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1PointsShunXuItem);
                UIActivityV1PointsShunXuItemComponent component = self.AddChild<UIActivityV1PointsShunXuItemComponent, GameObject>(go);
                component.OnUpdateData(key, self.OnRecvHandler);
                UICommonHelper.SetParent(go, self.UIActivityV1PointsListNode);
                go.SetActive(true);
            }

            self.OnRecvHandler();
        }

        public static void OnRecvHandler(this UIActivityV1PointsShunXuComponent self)
        {
            int points = (int)(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.V1TotalPoints);

            self.ConsumeNumText.GetComponent<Text>().text =
                   string.Format(GameSettingLanguge.LoadLocalization("{0}积分"), points);
        }
    }
}