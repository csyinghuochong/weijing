using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIChengJiuJingLingItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject RawImage;
        public GameObject Text_value;
        public GameObject ButtonActivite;
        public GameObject ButtonShouHui;
        public GameObject ObjGetText;
        public GameObject UseSet;
        public GameObject ChengHaoName;
        public GameObject GameObject;
        public GameObject JingLingDes;
        public int JingLingId;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;
    }


    public class UIChengJiuJingLingItemComponentAwake : AwakeSystem<UIChengJiuJingLingItemComponent, GameObject>
    {
        public override void Awake(UIChengJiuJingLingItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Text_value = rc.Get<GameObject>("Text_value");

            self.ButtonActivite = rc.Get<GameObject>("ButtonActivite");
            ButtonHelp.AddListenerEx(self.ButtonActivite, () => { self.OnButtonActivite().Coroutine();  });

            self.ButtonShouHui = rc.Get<GameObject>("ButtonShouHui");
            ButtonHelp.AddListenerEx(self.ButtonShouHui, () => { self.OnButtonActivite().Coroutine(); });

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.ObjGetText = rc.Get<GameObject>("ObjGetText");
            self.UseSet = rc.Get<GameObject>("UseSet");
            self.ChengHaoName = rc.Get<GameObject>("ChengHaoName");
            self.JingLingDes = rc.Get<GameObject>("JingLingDes");
        }
    }


    public class UIChengJiuJingLingItemComponentDestroy : DestroySystem<UIChengJiuJingLingItemComponent>
    {
        public override void Destroy(UIChengJiuJingLingItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
        }
    }

    public static class UIChengJiuJingLingItemComponentSystem
    {

        public static async ETTask OnButtonActivite(this UIChengJiuJingLingItemComponent self)
        {
            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            if (!chengJiuComponent.JingLingList.Contains(self.JingLingId))
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("请先激活此精灵！"));
                return;
            }

            C2M_JingLingUseRequest request = new C2M_JingLingUseRequest() { JingLingId = self.JingLingId, OperateType = 1 };
            M2C_JingLingUseResponse response = (M2C_JingLingUseResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != 0 || self.IsDisposed)
            {
                return;
            }

            chengJiuComponent.JingLingId =  ( response.JingLingId );
            bool current = chengJiuComponent.JingLingId == self.JingLingId;
            self.ButtonShouHui.SetActive(current);
            self.ButtonActivite.SetActive(!current);

            EventType.DataUpdate.Instance.DataType = DataType.JingLingButton;
            EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);
        }

        public static void OnInitUI(this UIChengJiuJingLingItemComponent self, int jid, bool active)
        {
            if (GameSettingLanguge.Language == 1)
            {
                ReferenceCollector rc = self.GameObject.GetComponent<ReferenceCollector>();

                rc.Get<GameObject>("Image_Model").GetComponent<RectTransform>().localPosition = new Vector2(19.6f, 71f);
                rc.Get<GameObject>("ButtonActivite").GetComponent<RectTransform>().localPosition = new Vector2(1f, -409f);
                rc.Get<GameObject>("ButtonShouHui").GetComponent<RectTransform>().localPosition = new Vector2(1f, -409f);
                rc.Get<GameObject>("UseSet").GetComponent<RectTransform>().localPosition = new Vector2(0f, 228f);
                rc.Get<GameObject>("Text_value_Head").GetComponent<RectTransform>().localPosition = new Vector2(23f, -55f);
                rc.Get<GameObject>("Text_value").GetComponent<RectTransform>().localPosition = new Vector2(23f, -195f);
                rc.Get<GameObject>("Text_TabJingLing").GetComponent<RectTransform>().localPosition = new Vector2(23f, 34f);
                rc.Get<GameObject>("JingLingDes").GetComponent<RectTransform>().localPosition = new Vector2(23f, -12f);
                rc.Get<GameObject>("ObjGetText").GetComponent<RectTransform>().localPosition = new Vector2(2.9f, -324f);
            }
            
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(jid);
            self.JingLingId = jid;
            self.RenderTexture = null;
            self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;
            self.ChengHaoName.GetComponent<Text>().text = jingLingConfig.GetName();

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
            self.UIModelShowComponent.ShowModel("JingLing/" + jingLingConfig.Assets).Coroutine();
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 40f, 200f);
            gameObject.transform.localPosition = new Vector2(jingLingConfig.Id % 10 * 1000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);

            self.Text_value.GetComponent<Text>().text = jingLingConfig.GetDes();
            self.ObjGetText.GetComponent<Text>().text = jingLingConfig.GetGetDes();
            self.JingLingDes.GetComponent<Text>().text = jingLingConfig.GetProDes();
            UICommonHelper.SetRawImageGray(self.RawImage, !active);

            ChengJiuComponent chengJiuComponent = self.ZoneScene().GetComponent<ChengJiuComponent>();
            bool current = chengJiuComponent.JingLingId == jid;
            self.ButtonShouHui.SetActive(current);
            self.ButtonActivite.SetActive(!current);
        }

        public static void OnUpdateUI(this UIChengJiuJingLingItemComponent self)
        { 
            
        }
    }
}
