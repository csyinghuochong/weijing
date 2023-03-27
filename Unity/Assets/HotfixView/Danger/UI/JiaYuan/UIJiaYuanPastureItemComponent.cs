using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPastureItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Text_RenKou;
        public GameObject Text_Name;
        public GameObject Text_value2;
        public GameObject Text_value;
        public GameObject ButtonBuy;
        public GameObject RawImage;

        public GameObject GameObject;
        public MysteryItemInfo MysteryItemInfo;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;
    }

    [ObjectSystem]
    public class UIJiaYuanPastureItemComponentAwake : AwakeSystem<UIJiaYuanPastureItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPastureItemComponent self, GameObject a)
        {
            self.GameObject = a;
            self.RenderTexture = null;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_RenKou = rc.Get<GameObject>("Text_RenKou");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_value2 = rc.Get<GameObject>("Text_value2");
            self.Text_value = rc.Get<GameObject>("Text_value");
            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            self.RawImage = rc.Get<GameObject>("RawImage");

            ButtonHelp.AddListenerEx(self.ButtonBuy, () => { self.OnButtonBuy().Coroutine(); });
        }
    }

    [ObjectSystem]
    public class UIJiaYuanPastureItemComponentDestroy : DestroySystem<UIJiaYuanPastureItemComponent>
    {
        public override void Destroy(UIJiaYuanPastureItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIJiaYuanPastureItemComponentSystem
    {

        public static void OnInitUI(this UIJiaYuanPastureItemComponent self, JiaYuanPastureConfig zuoQiConfig, int index)
        {
            if (self.RenderTexture == null)
            {
                self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture.Create();
                self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

                var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
                GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
                self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
                self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
                self.UIModelShowComponent.ShowModel("Pasture/" + zuoQiConfig.Assets).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(index * 1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
        }

        public static void OnUpdateUI(this UIJiaYuanPastureItemComponent self, MysteryItemInfo mysteryItemInfo, int index)
        {
            JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(mysteryItemInfo.MysteryId);

            self.OnInitUI(jiaYuanPastureConfig, index);
            self.MysteryItemInfo = mysteryItemInfo;

            self.Text_RenKou.GetComponent<Text>().text = $"人口：{jiaYuanPastureConfig.PeopleNum}";
            self.Text_Name.GetComponent<Text>().text = jiaYuanPastureConfig.Name;
            self.Text_value2.GetComponent<Text>().text = jiaYuanPastureConfig.BuyGold.ToString();

            int hour = jiaYuanPastureConfig.UpTime[3] / 3600;
            self.Text_value.GetComponent<Text>().text = $"{hour}小时";
        }

        public static async ETTask OnButtonBuy(this UIJiaYuanPastureItemComponent self)
        {
            int leftSpace = self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace();
            if (leftSpace < 1)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }

            JiaYuanPastureConfig mysteryConfig = JiaYuanPastureConfigCategory.Instance.Get(self.MysteryItemInfo.MysteryId);
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem($"13;{mysteryConfig.BuyGold}"))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_HouBiNotEnough);
                return;
            }

            MysteryItemInfo mysteryItemInfo = new MysteryItemInfo() { MysteryId = self.MysteryItemInfo.MysteryId };
            C2M_JiaYuanPastureBuyRequest c2M_MysteryBuyRequest = new C2M_JiaYuanPastureBuyRequest() { MysteryItemInfo = mysteryItemInfo };
            M2C_JiaYuanPastureBuyResponse r2c_roleEquip = (M2C_JiaYuanPastureBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_MysteryBuyRequest);

            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIJiaYuanPasture);
            uI.GetComponent<UIJiaYuanPastureComponent>().RequestMystery().Coroutine();
        }

    }
}
