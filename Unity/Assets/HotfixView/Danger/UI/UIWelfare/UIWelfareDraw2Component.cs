using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareDraw2Component: Entity, IAwake
    {
        public GameObject NumText;
        public GameObject DrawList;
        public GameObject DrawBtn;

        public List<GameObject> Draws = new List<GameObject>();
        public List<GameObject> OutLines = new List<GameObject>();
    }

    public class UIWelfareDraw2ComponentAwakeSystem: AwakeSystem<UIWelfareDraw2Component>
    {
        public override void Awake(UIWelfareDraw2Component self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.NumText = rc.Get<GameObject>("NumText");
            self.DrawList = rc.Get<GameObject>("DrawList");
            self.DrawBtn = rc.Get<GameObject>("DrawBtn");

            self.DrawBtn.GetComponent<Button>().onClick.AddListener(() => { self.StartDraw().Coroutine(); });

            self.Init();
        }
    }

    public static class UIWelfareDraw2ComponentSystem
    {
        public static void Init(this UIWelfareDraw2Component self)
        {
            self.Draws.Clear();
            self.OutLines.Clear();

            List<BagInfo> bagInfos = new List<BagInfo>();
            foreach (List<BagInfo> infos in self.ZoneScene().GetComponent<BagComponent>().AllItemList)
            {
                bagInfos.AddRange(infos);
            }

            List<string> rewardItems = ActivityHelper.GetWelfareChouKaReward(bagInfos);
            for (int i = 0; i < self.DrawList.transform.childCount; i++)
            {
                GameObject go = self.DrawList.transform.GetChild(i).gameObject;
                GameObject RewardListNode = go.GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode");
                self.Draws.Add(go);

                UICommonHelper.DestoryChild(RewardListNode);
                UICommonHelper.ShowItemList(rewardItems[i], RewardListNode, self, 0.8f);

                go.GetComponent<ReferenceCollector>().Get<GameObject>("ReceivedImg").SetActive(false);
                GameObject outline = go.GetComponent<ReferenceCollector>().Get<GameObject>("SelectImg");

                self.OutLines.Add(outline);

                outline.SetActive(false);
            }

            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            self.NumText.GetComponent<Text>().text = (numericComponent.GetAsLong(NumericType.RechargeNumber) / 50 -
                numericComponent.GetAsLong(NumericType.WelfareChouKaNumber)).ToString();
        }

        public static async ETTask StartDraw(this UIWelfareDraw2Component self)
        {
            self.Init();

            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            self.DrawBtn.GetComponent<Button>().interactable = true;

            int drawIndex = numericComponent.GetAsInt(NumericType.DrawIndex2);

            if (drawIndex > 0)
            {
                // 有奖励未领取，直接开始
                self.StartRotation(drawIndex - 1).Coroutine();
            }
            else
            {
                if (numericComponent.GetAsLong(NumericType.RechargeNumber) / 50 - numericComponent.GetAsLong(NumericType.WelfareChouKaNumber) <= 0)
                {
                    FloatTipManager.Instance.ShowFloatTip("次数不足");
                    return;
                }

                C2M_WelfareDraw2Request request2 = new C2M_WelfareDraw2Request();
                M2C_WelfareDraw2Response response2 =
                        (M2C_WelfareDraw2Response)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request2);

                if (response2.Error != ErrorCode.ERR_Success)
                {
                    return;
                }

                self.ZoneScene().GetComponent<ReddotComponent>().UpdateReddont(ReddotType.WelfareDraw);
                drawIndex = numericComponent.GetAsInt(NumericType.DrawIndex2);
                self.StartRotation(drawIndex - 1).Coroutine();
            }

            self.NumText.GetComponent<Text>().text = (numericComponent.GetAsLong(NumericType.RechargeNumber) / 50 -
                numericComponent.GetAsLong(NumericType.WelfareChouKaNumber)).ToString();
        }

        public static async ETTask StartRotation(this UIWelfareDraw2Component self, int index)
        {
            self.DrawBtn.GetComponent<Button>().interactable = false;
            int ran = RandomHelper.RandomNumber(20, 30);
            int i = 0;
            while (!self.IsDisposed)
            {
                if (i % 8 == 0)
                {
                    self.OutLines[7].SetActive(false);
                }
                else
                {
                    self.OutLines[i % 8 - 1].SetActive(false);
                }

                self.OutLines[i % 8].SetActive(true);

                if (i > ran)
                {
                    if (i % 8 == index)
                    {
                        // 抽奖有一个转圈的效果，转圈结束后获取道具
                        C2M_WelfareDraw2RewardRequest reques3 = new C2M_WelfareDraw2RewardRequest();
                        M2C_WelfareDraw2RewardResponse response13 =
                                (M2C_WelfareDraw2RewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
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