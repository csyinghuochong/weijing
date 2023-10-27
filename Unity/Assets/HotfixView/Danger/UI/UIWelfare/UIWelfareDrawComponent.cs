using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWelfareDrawComponent: Entity, IAwake
    {
        public GameObject DrawList;
        public GameObject DrawItem;
        public GameObject DrawBtn;

        public List<GameObject> Draws = new List<GameObject>();

        // 从左上角开始顺时针
        public List<Vector3> Positions = new List<Vector3>()
        {
            new Vector3(-360, 220, 0),
            new Vector3(0, 220, 0),
            new Vector3(360, 220, 0),
            new Vector3(360, 0, 0),
            new Vector3(360, -220, 0),
            new Vector3(0, -220, 0),
            new Vector3(-360, -220, 0),
            new Vector3(-360, 0, 0)
        };
    }

    public class UIWelfareDrawComponentAwakeSystem: AwakeSystem<UIWelfareDrawComponent>
    {
        public override void Awake(UIWelfareDrawComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.DrawList = rc.Get<GameObject>("DrawList");
            self.DrawItem = rc.Get<GameObject>("DrawItem");
            self.DrawBtn = rc.Get<GameObject>("DrawBtn");

            self.DrawItem.SetActive(false);

            self.DrawBtn.GetComponent<Button>().onClick.AddListener(() => { self.StartDraw().Coroutine(); });
        }
    }

    public static class UIWelfareDrawComponentSystem
    {
        public static async ETTask StartDraw(this UIWelfareDrawComponent self)
        {
            UICommonHelper.DestoryChild(self.DrawList);
            self.Draws.Clear();
            self.DrawBtn.GetComponent<Button>().interactable = true;

            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            // 开始抽奖，生成奖励格子。如果 NumericType.WelfareDraw > 0则不需要发送此协议，客户端直接做展示即可。将格子转到NumericType.WelfareDraw - 1即可
            for (int i = 0; i < self.Positions.Count; i++)
            {
                GameObject go = GameObject.Instantiate(self.DrawItem);
                go.SetActive(true);
                UICommonHelper.SetParent(go, self.DrawList);
                go.GetComponent<RectTransform>().localPosition = self.Positions[i];
                self.Draws.Add(go);
                UICommonHelper.ShowItemList(ConfigHelper.WelfareDrawList[i].Value,
                    go.GetComponent<ReferenceCollector>().Get<GameObject>("RewardListNode"), self, 0.8f);
            }

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
                if (i % 8 == 0)
                {
                    self.Draws[7].GetComponent<Image>().color = Color.white;
                }
                else
                {
                    self.Draws[i % 8 - 1].GetComponent<Image>().color = Color.white;
                }

                self.Draws[i % 8].GetComponent<Image>().color = Color.red;

                if (i > ran && i % 8 == index)
                {
                    // 抽奖有一个转圈的效果，转圈结束后获取道具
                    C2M_WelfareDrawRewardRequest reques3 = new C2M_WelfareDrawRewardRequest();
                    M2C_WelfareDrawRewardResponse response13 =
                            (M2C_WelfareDrawRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(reques3);
                    break;
                }

                i++;
                await TimerComponent.Instance.WaitAsync(250);
                if (self.IsDisposed)
                {
                    break;
                }
            }

            self.DrawBtn.GetComponent<Button>().interactable = true;
        }
    }
}