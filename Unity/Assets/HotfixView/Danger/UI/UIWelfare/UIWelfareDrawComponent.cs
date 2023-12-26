using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareDrawComponent: Entity, IAwake
    {
        public GameObject DrawList;
        public GameObject DrawBtn;

        public List<GameObject> Draws = new List<GameObject>();
        public List<GameObject> OutLines = new List<GameObject>();
    }

    public class UIWelfareDrawComponentAwakeSystem: AwakeSystem<UIWelfareDrawComponent>
    {
        public override void Awake(UIWelfareDrawComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.DrawList = rc.Get<GameObject>("DrawList");
            self.DrawBtn = rc.Get<GameObject>("DrawBtn");

            self.DrawBtn.GetComponent<Button>().onClick.AddListener(() => { self.StartDraw().Coroutine(); });

            self.Init();
        }
    }

    public static class UIWelfareDrawComponentSystem
    {
        public static void Init(this UIWelfareDrawComponent self)
        {
            self.Draws.Clear();
            self.OutLines.Clear();

            GameObject outLine6 = null;
            for (int i = 0; i < self.DrawList.transform.childCount; i++)
            {
                GameObject go = self.DrawList.transform.GetChild(i).gameObject;
                GameObject RewardListNode = go.GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode");
                self.Draws.Add(go);
                List<RewardItem> rewardItems = null;
                if (i == 6)
                {
                    UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                    int weaponId = ComHelp.GetWelfareWeapon(userInfoComponent.UserInfo.Occ, userInfoComponent.UserInfo.OccTwo);
                    string reward = $"{weaponId};1";
                    rewardItems = ItemHelper.GetRewardItems(reward);
                }
                else
                {
                    rewardItems = ItemHelper.GetRewardItems(ConfigHelper.WelfareDrawList[i].Value);
                }

                UICommonHelper.ShowItemList(rewardItems, RewardListNode, self, 0.8f, true, true);

                GameObject outline = go.GetComponent<ReferenceCollector>().Get<GameObject>("SelectImg");
                // 第6和7互换一下位置
                if (i == 5)
                {
                    outLine6 = outline;
                }
                else
                {
                    self.OutLines.Add(outline);
                }

                outline.SetActive(false);
            }

            self.OutLines.Add(outLine6);

            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            int drawReward = numericComponent.GetAsInt(NumericType.DrawReward);
            if (drawReward == 1)
            {
                int index = numericComponent.GetAsInt(NumericType.DrawIndex) - 1;
                self.DrawBtn.GetComponent<Button>().interactable = true;
                self.Draws[index].GetComponent<ReferenceCollector>().Get<GameObject>("ReceivedImg").SetActive(true);
                GameObject rewardList = self.Draws[index].GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode");
                for (int j = 0; j < rewardList.transform.childCount; j++)
                {
                    GameObject uiItem = rewardList.transform.GetChild(j).gameObject;

                    UICommonHelper.SetImageGray(uiItem.GetComponent<ReferenceCollector>().Get<GameObject>("Image_ItemIcon"), true);
                    UICommonHelper.SetImageGray(uiItem.GetComponent<ReferenceCollector>().Get<GameObject>("Image_ItemQuality"), true);
                    uiItem.GetComponent<ReferenceCollector>().Get<GameObject>("Label_ItemName").SetActive(false);
                }
                self.Draws[index].GetComponent<ReferenceCollector>().Get<GameObject>("Text")?.SetActive(false);
            }
        }

        public static async ETTask StartDraw(this UIWelfareDrawComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            int drawReward = numericComponent.GetAsInt(NumericType.DrawReward);
            if (drawReward == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("已经参与过抽奖！");
                return;
            }

            long haveHuoyue = self.ZoneScene().GetComponent<TaskComponent>().GetHuoYueDu();
            if (haveHuoyue < 60)
            {
                FloatTipManager.Instance.ShowFloatTip("活跃度不足！");
                return;
            }

            self.DrawBtn.GetComponent<Button>().interactable = true;

            int drawIndex = numericComponent.GetAsInt(NumericType.DrawIndex);
            if (drawIndex > 0)
            {
                self.StartRotation(drawIndex - 1).Coroutine();
            }
            else
            {
                C2M_WelfareDrawRequest request2 = new C2M_WelfareDrawRequest();
                M2C_WelfareDrawResponse response2 =
                        (M2C_WelfareDrawResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request2);

                if (response2.Error != ErrorCode.ERR_Success)
                {
                    return;
                }
                self.ZoneScene().GetComponent<ReddotComponent>().UpdateReddont(ReddotType.WelfareDraw);
                drawIndex = numericComponent.GetAsInt(NumericType.DrawIndex);
                self.StartRotation(drawIndex - 1).Coroutine();
            }
        }

        public static async ETTask StartRotation(this UIWelfareDrawComponent self, int index)
        {
            self.DrawBtn.GetComponent<Button>().interactable = false;
            int ran = RandomHelper.RandomNumber(20, 30);
            int i = 0;
            while (!self.IsDisposed)
            {
                if (i % 7 == 0)
                {
                    self.OutLines[6].SetActive(false);
                }
                else
                {
                    self.OutLines[i % 7 - 1].SetActive(false);
                }

                self.OutLines[i % 7].SetActive(true);

                if (i > ran)
                {
                    if (index < 5 && i % 7 == index)
                    {
                        // 抽奖有一个转圈的效果，转圈结束后获取道具
                        C2M_WelfareDrawRewardRequest reques3 = new C2M_WelfareDrawRewardRequest();
                        M2C_WelfareDrawRewardResponse response13 =
                                (M2C_WelfareDrawRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
                        break;
                    }

                    if (index == 5 && i % 7 == 6)
                    {
                        // 抽奖有一个转圈的效果，转圈结束后获取道具
                        C2M_WelfareDrawRewardRequest reques3 = new C2M_WelfareDrawRewardRequest();
                        M2C_WelfareDrawRewardResponse response13 =
                                (M2C_WelfareDrawRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
                        break;
                    }

                    if (index == 6 && i % 7 == 5)
                    {
                        // 抽奖有一个转圈的效果，转圈结束后获取道具
                        C2M_WelfareDrawRewardRequest reques3 = new C2M_WelfareDrawRewardRequest();
                        M2C_WelfareDrawRewardResponse response13 =
                                (M2C_WelfareDrawRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
                        break;
                    }
                }

                i++;
                await TimerComponent.Instance.WaitAsync(250);
                if (self.IsDisposed)
                {
                    return;
                }
            }

            self.DrawBtn.GetComponent<Button>().interactable = true;
            self.Draws[index].GetComponent<ReferenceCollector>().Get<GameObject>("ReceivedImg").SetActive(true);
            GameObject rewardList = self.Draws[index].GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode");
            for (int j = 0; j < rewardList.transform.childCount; j++)
            {
                GameObject uiItem = rewardList.transform.GetChild(j).gameObject;

                UICommonHelper.SetImageGray(uiItem.GetComponent<ReferenceCollector>().Get<GameObject>("Image_ItemIcon"), true);
                UICommonHelper.SetImageGray(uiItem.GetComponent<ReferenceCollector>().Get<GameObject>("Image_ItemQuality"), true);
                uiItem.GetComponent<ReferenceCollector>().Get<GameObject>("Label_ItemName").SetActive(false);
            }
            self.Draws[index].GetComponent<ReferenceCollector>().Get<GameObject>("Text")?.SetActive(false);
        }
    }
}