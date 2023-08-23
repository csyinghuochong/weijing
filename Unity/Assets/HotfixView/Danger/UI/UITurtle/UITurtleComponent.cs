using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITurtleComponent: Entity, IAwake, IDestroy
    {
        public Text TimeText;
        public GameObject RewardsListNode;
        public GameObject Image1;
        public GameObject WinNumText1;
        public GameObject SupportNumText1;
        public GameObject Btn1;
        public GameObject BtnText1;
        public GameObject Image2;
        public GameObject WinNumText2;
        public GameObject SupportNumText2;
        public GameObject Btn2;
        public GameObject BtnText2;
        public GameObject Image3;
        public GameObject WinNumText3;
        public GameObject SupportNumText3;
        public GameObject Btn3;
        public GameObject BtnText3;

        public int SupportId;
        public long EndTime;

        public RenderTexture RenderTexture1;
        public UIModelDynamicComponent UIModelShowComponent1;
        public RenderTexture RenderTexture2;
        public UIModelDynamicComponent UIModelShowComponent2;
        public RenderTexture RenderTexture3;
        public UIModelDynamicComponent UIModelShowComponent3;
    }

    public class UITurtleComponentAwakeSystem: AwakeSystem<UITurtleComponent>
    {
        public override void Awake(UITurtleComponent self)
        {
            self.Awake();
        }
    }

    public class UITurtleComponentDestroySystem: DestroySystem<UITurtleComponent>
    {
        public override void Destroy(UITurtleComponent self)
        {
            self.Destroy();
        }
    }

    public static class UITurtleComponentSystem
    {
        public static void Awake(this UITurtleComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TimeText = rc.Get<GameObject>("TimeText").GetComponent<Text>();
            self.RewardsListNode = rc.Get<GameObject>("RewardsListNode");
            self.Image1 = rc.Get<GameObject>("Image1");
            self.WinNumText1 = rc.Get<GameObject>("WinNumText1");
            self.SupportNumText1 = rc.Get<GameObject>("SupportNumText1");
            self.Btn1 = rc.Get<GameObject>("Btn1");
            self.BtnText1 = rc.Get<GameObject>("BtnText1");
            self.Image2 = rc.Get<GameObject>("Image2");
            self.WinNumText2 = rc.Get<GameObject>("WinNumText2");
            self.SupportNumText2 = rc.Get<GameObject>("SupportNumText2");
            self.Btn2 = rc.Get<GameObject>("Btn2");
            self.BtnText2 = rc.Get<GameObject>("BtnText2");
            self.Image3 = rc.Get<GameObject>("Image3");
            self.WinNumText3 = rc.Get<GameObject>("WinNumText3");
            self.SupportNumText3 = rc.Get<GameObject>("SupportNumText3");
            self.Btn3 = rc.Get<GameObject>("Btn3");
            self.BtnText3 = rc.Get<GameObject>("BtnText3");

            self.Btn1.GetComponent<Button>().onClick.AddListener(() => self.OnTurtleBtn(20099011).Coroutine());
            self.Btn2.GetComponent<Button>().onClick.AddListener(() => self.OnTurtleBtn(20099012).Coroutine());
            self.Btn3.GetComponent<Button>().onClick.AddListener(() => self.OnTurtleBtn(20099013).Coroutine());

            self.EndTime = FunctionHelp.GetCloseTime(1057);

            self.InitModel();
            self.InitInfo().Coroutine();
            self.ShowTime().Coroutine();
            self.ShowRewards();
        }

        public static void Destroy(this UITurtleComponent self)
        {
            self.UIModelShowComponent1.ReleaseRenderTexture();
            self.RenderTexture1.Release();
            GameObject.Destroy(self.RenderTexture1);
            self.RenderTexture1 = null;

            self.UIModelShowComponent2.ReleaseRenderTexture();
            self.RenderTexture2.Release();
            GameObject.Destroy(self.RenderTexture2);
            self.RenderTexture2 = null;

            self.UIModelShowComponent3.ReleaseRenderTexture();
            self.RenderTexture3.Release();
            GameObject.Destroy(self.RenderTexture3);
            self.RenderTexture3 = null;
        }

        public static void InitModel(this UITurtleComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            // 小龟1号
            GameObject obj1 = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent1 = self.AddChild<UIModelDynamicComponent, GameObject>(obj1);
            if (self.RenderTexture1 != null)
            {
                self.RenderTexture1.Release();
                GameObject.Destroy(self.RenderTexture1);
                self.RenderTexture1 = null;
            }

            if (self.RenderTexture1 == null)
            {
                self.RenderTexture1 = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture1.Create();
                self.Image1.GetComponent<RawImage>().texture = self.RenderTexture1;

                GameObject gameObject = self.UIModelShowComponent1.GameObject;
                self.UIModelShowComponent1.OnInitUI(self.Image1, self.RenderTexture1);
                self.UIModelShowComponent1.ShowModel("NPC/" + NpcConfigCategory.Instance.Get(20099008).Asset).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }

            // 小龟2号
            GameObject obj2 = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent2 = self.AddChild<UIModelDynamicComponent, GameObject>(obj2);
            if (self.RenderTexture2 != null)
            {
                self.RenderTexture1.Release();
                GameObject.Destroy(self.RenderTexture2);
                self.RenderTexture2 = null;
            }

            if (self.RenderTexture2 == null)
            {
                self.RenderTexture2 = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture2.Create();
                self.Image2.GetComponent<RawImage>().texture = self.RenderTexture2;

                GameObject gameObject = self.UIModelShowComponent2.GameObject;
                self.UIModelShowComponent2.OnInitUI(self.Image2, self.RenderTexture2);
                self.UIModelShowComponent2.ShowModel("NPC/" + NpcConfigCategory.Instance.Get(20099009).Asset).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }

            // 小龟3号
            GameObject obj3 = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent3 = self.AddChild<UIModelDynamicComponent, GameObject>(obj3);
            if (self.RenderTexture3 != null)
            {
                self.RenderTexture3.Release();
                GameObject.Destroy(self.RenderTexture3);
                self.RenderTexture3 = null;
            }

            if (self.RenderTexture3 == null)
            {
                self.RenderTexture3 = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture3.Create();
                self.Image3.GetComponent<RawImage>().texture = self.RenderTexture3;

                GameObject gameObject = self.UIModelShowComponent3.GameObject;
                self.UIModelShowComponent3.OnInitUI(self.Image3, self.RenderTexture3);
                self.UIModelShowComponent3.ShowModel("NPC/" + NpcConfigCategory.Instance.Get(20099010).Asset).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
        }

        public static async ETTask OnTurtleBtn(this UITurtleComponent self, int supportId)
        {
            if (self.SupportId != 0 || !(supportId == 20099011 || supportId == 20099012 || supportId == 20099013))
            {
                FloatTipManager.Instance.ShowFloatTip("已有支持的小龟!");
                return;
            }

            PopupTipHelp.OpenPopupTip(self.ZoneScene(), $"小龟大赛", $"是否消耗{GlobalValueConfigCategory.Instance.Get(98).Value}金币支持该小龟?", async () =>
            {
                C2M_TurtleSupportRequest request = new C2M_TurtleSupportRequest() { SupportId = supportId };
                M2C_TurtleSupportResponse response =
                        await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_TurtleSupportResponse;
                if (response.Error != ErrorCode.ERR_Success)
                {
                    return;
                }

                if (supportId == 20099011)
                {
                    self.BtnText1.GetComponent<Text>().text = "竞猜小龟";
                }
                else if (supportId == 20099012)
                {
                    self.BtnText2.GetComponent<Text>().text = "竞猜小龟";
                }
                else if (supportId == 20099013)
                {
                    self.BtnText3.GetComponent<Text>().text = "竞猜小龟";
                }

                self.SupportId = supportId;
                await self.InitInfo();
            }).Coroutine();

            await ETTask.CompletedTask;
        }

        public static void ShowRewards(this UITurtleComponent self)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(97);
            UICommonHelper.ShowItemList(globalValueConfig.Value, self.RewardsListNode, self, 0.9f);
        }

        public static async ETTask InitInfo(this UITurtleComponent self)
        {
            C2M_TurtleRecordRequest request = new C2M_TurtleRecordRequest();
            M2C_TurtleRecordResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_TurtleRecordResponse;
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.SupportId = response.SupportId;

            self.WinNumText1.GetComponent<Text>().text = $"获胜次数:{response.WinTimes[0]}";
            self.WinNumText2.GetComponent<Text>().text = $"获胜次数:{response.WinTimes[1]}";
            self.WinNumText3.GetComponent<Text>().text = $"获胜次数:{response.WinTimes[2]}";

            self.SupportNumText1.GetComponent<Text>().text = $"本次支持数:{response.SupportTimes[0]}";
            self.SupportNumText2.GetComponent<Text>().text = $"本次支持数:{response.SupportTimes[1]}";
            self.SupportNumText3.GetComponent<Text>().text = $"本次支持数:{response.SupportTimes[2]}";

            if (response.SupportId == 20099011)
            {
                self.BtnText1.GetComponent<Text>().text = "竞猜小龟";
            }
            else if (response.SupportId == 20099012)
            {
                self.BtnText2.GetComponent<Text>().text = "竞猜小龟";
            }
            else if (response.SupportId == 20099013)
            {
                self.BtnText3.GetComponent<Text>().text = "竞猜小龟";
            }

            await ETTask.CompletedTask;
        }

        public static async ETTask ShowTime(this UITurtleComponent self)
        {
            while (!self.IsDisposed)
            {
                DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
                long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
                long endTime = self.EndTime - curTime;
                if (endTime > 0)
                {
                    self.TimeText.text = $"活动开启倒计时 {endTime / 60}分{endTime % 60}秒";
                }
                else
                {
                    self.TimeText.text = "活动开始!!!";
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }
    }
}