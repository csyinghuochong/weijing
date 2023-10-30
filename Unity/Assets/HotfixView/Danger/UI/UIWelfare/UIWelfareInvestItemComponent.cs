using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareInvestItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject DayText;
        public GameObject InvestText;
        public GameObject UIItem;
        public GameObject InvestBtn;
        public GameObject InvestedImg;
        public UIItemComponent UIItemComponent;
        public int day;
    }

    public class UIWelfareInvestItemComponentAwakeSystem: AwakeSystem<UIWelfareInvestItemComponent, GameObject>
    {
        public override void Awake(UIWelfareInvestItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.DayText = rc.Get<GameObject>("DayText");
            self.InvestText = rc.Get<GameObject>("InvestText");
            self.UIItem = rc.Get<GameObject>("UIItem");
            self.InvestBtn = rc.Get<GameObject>("InvestBtn");
            self.InvestedImg = rc.Get<GameObject>("InvestedImg");
            
            //UI ui_2 = self.AddChild<UI, string, GameObject>("UICommonItem", self.UIItem);
            self.UIItemComponent = self.AddComponent<UIItemComponent, GameObject>(self.UIItem);

            self.InvestBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnInvestBtn().Coroutine(); });
        }
    }

    public static class UIWelfareInvestItemComponentSystem
    {
        public static void OnUpdateData(this UIWelfareInvestItemComponent self, int day)
        {
            self.day = day;

            self.DayText.GetComponent<Text>().text = $"第{day + 1}天";

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(ConfigHelper.WelfareInvestLiBao);
            
            self.UIItemComponent.UpdateItem(new BagInfo() { ItemID = itemConfig.Id, ItemNum = 1 }, ItemOperateEnum.None);

            self.InvestText.GetComponent<Text>().text = $"投资{ConfigHelper.WelfareInvestList[day]}金币  回馈:";

            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.WelfareInvestList.Contains(day))
            {
                self.InvestBtn.SetActive(false);
                self.InvestedImg.SetActive(true);
            }
            else
            {
                self.InvestBtn.SetActive(true);
                self.InvestedImg.SetActive(false);
            }
        }

        public static async ETTask OnInvestBtn(this UIWelfareInvestItemComponent self)
        {
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.WelfareInvestList.Contains(self.day))
            {
                FloatTipManager.Instance.ShowFloatTip("已经进行了投资!");
                return;
            }

            if (self.ZoneScene().GetComponent<UserInfoComponent>().GetCrateDay() - 1 < self.day)
            {
                FloatTipManager.Instance.ShowFloatTip("今天还不能进行该项投资!");
                return;
            }

            C2M_WelfareInvestRequest reuqest4 = new C2M_WelfareInvestRequest() { Index = self.day };
            M2C_WelfareInvestResponse response4 =
                    (M2C_WelfareInvestResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reuqest4);
            // 没有更新UserInfo.WelfareInvestList，所以要手动变化一下
            if (response4.Error == ErrorCode.ERR_Success)
            {
                self.InvestBtn.SetActive(false);
                self.InvestedImg.SetActive(true);
                // 刷新
                self.GetParent<UIWelfareInvestComponent>().UpdateInfo();
            }
        }
    }
}