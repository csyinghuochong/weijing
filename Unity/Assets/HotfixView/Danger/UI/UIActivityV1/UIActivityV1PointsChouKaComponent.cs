using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1PointsChouKaComponent : Entity, IAwake
    {
        public Text TextTip;
        public Button OpenBtn;
        public GameObject RewardItemListNode;
        public GameObject UICommonItem;
        public UIItemComponent UICostCommonItem;
        public List<UIItemComponent> UIItemList = new List<UIItemComponent>();

    }

    public class UIActivityV1PointsChouKaComponentAwake : AwakeSystem<UIActivityV1PointsChouKaComponent>
    {
        public override void Awake(UIActivityV1PointsChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            GameObject  iCostCommonItem = rc.Get<GameObject>("UICostCommonItem");
            UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(iCostCommonItem);
            uIItemComponent.UpdateItem(new BagInfo() { ItemID = 37, ItemNum = 200 }, ItemOperateEnum.None);
            self.UICostCommonItem = uIItemComponent;
            self.UICostCommonItem.Label_ItemNum.GetComponent<Text>().text = "X200";

            self.TextTip = rc.Get<GameObject>("TextTip").GetComponent<Text>();
            self.OpenBtn = rc.Get<GameObject>("OpenBtn").GetComponent<Button>();
            ButtonHelp.AddListenerEx(self.OpenBtn.gameObject, () => { self.OnButton_TimerChouKa().Coroutine(); });

            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.ShowRewardList();
            self.ShowLeftPoints();
            self.OnUpdateUI();
        }
    }

    public static class UIActivityV1PointsChouKaComponentSystem
    {


        public static void ShowRewardList(this UIActivityV1PointsChouKaComponent self)
        {
            foreach(var choukaitem in ActivityConfigHelper.PointsChouKaList)
            {
                string itemvalue = choukaitem.ItemInfo;
                string[] iteminfo = itemvalue.Split(';');
                int ItemID = int.Parse(iteminfo[0]);
                int ItemNum = int.Parse(iteminfo[1]);

                GameObject itemSpace = GameObject.Instantiate(self.UICommonItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.RewardItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = ItemID, ItemNum = ItemNum }, ItemOperateEnum.None);
                uIItemComponent.Label_ItemName.SetActive(true);
                uIItemComponent.Label_ItemNum.SetActive(true);
                uIItemComponent.Image_Binding.SetActive(true);
                itemSpace.transform.Find("Image_Recvived").gameObject.SetActive(false);
                itemSpace.transform.localScale = Vector3.one * 1f;

                self.UIItemList.Add(uIItemComponent);
            }
        }

        public static void OnUpdateUI(this UIActivityV1PointsChouKaComponent self)
        {
            self.ShowLeftPoints();
        }

        public static void ShowLeftPoints(this UIActivityV1PointsChouKaComponent self)
        {
            int points = (int)self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.V1TotalPoints;

            self.TextTip.GetComponent<Text>().text = points.ToString();
                 //string.Format(GameSettingLanguge.LoadLocalization("{0}"), points);
        }

        public static async ETTask OnButton_TimerChouKa(this UIActivityV1PointsChouKaComponent self)
        {
            if (self.ZoneScene().GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_BagIsFull);
                return;
            }

          
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.V1TotalPoints < 200f)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_PointNotEnough);
                return;
            }

            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            int drawIndex = numericComponent.GetAsInt(NumericType.V1PointsChouKaIndex);
            if (drawIndex <= 0)
            {
                C2M_ActivityRewardRequest request = new C2M_ActivityRewardRequest()
                {
                    ActivityType = ActivityConfigHelper.ActivityV1_PointsChouKa,
                };
                M2C_ActivityRewardResponse response =
                        (M2C_ActivityRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

                if (response.Error != ErrorCode.ERR_Success || self.IsDisposed)
                {
                    return;
                }

                drawIndex = numericComponent.GetAsInt(NumericType.V1PointsChouKaIndex);
            }
            if (drawIndex <= 0)
            {
                return;
            }

            self.StartRotation(drawIndex - 1).Coroutine();


            await ETTask.CompletedTask;
        }

        public static async ETTask StartRotation(this UIActivityV1PointsChouKaComponent self, int index)
        {
            self.OpenBtn.interactable = false;
            int ran = RandomHelper.RandomNumber(16, 24);
            int i = 0;


            while (!self.IsDisposed)
            {
                int curindex = i % self.UIItemList.Count;

                for (int item = 0; item < self.UIItemList.Count; item++)
                {
                    self.UIItemList[item].Image_XuanZhong.SetActive(curindex == item);
                }

                if (i > ran && curindex == index)
                {
                    C2M_PointChouKaRewardRequest reques3 = new C2M_PointChouKaRewardRequest();
                    M2C_PointChouKaRewardResponse response13 =
                            (M2C_PointChouKaRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
                    break;
                }

                i++;
                await TimerComponent.Instance.WaitAsync(250);
                if (self.IsDisposed)
                {
                    return;
                }
            }

            self.OpenBtn.interactable = true;
            self.ShowLeftPoints();
        }

    }
}