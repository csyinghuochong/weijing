using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPastureItem_AComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Text_Tip11;
        public GameObject Text_Tip12;
        public GameObject Text_Tip;
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

    public class UIJiaYuanPastureItem_AComponentAwake: AwakeSystem<UIJiaYuanPastureItem_AComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPastureItem_AComponent self, GameObject a)
        {
            self.GameObject = a;
            self.RenderTexture = null;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_Tip11 = rc.Get<GameObject>("Text_Tip11");
            self.Text_Tip12 = rc.Get<GameObject>("Text_Tip12");
            self.Text_Tip = rc.Get<GameObject>("Text_Tip");
            self.Text_RenKou = rc.Get<GameObject>("Text_RenKou");
            self.Text_Name = rc.Get<GameObject>("Text_Name");
            self.Text_value2 = rc.Get<GameObject>("Text_value2");
            self.Text_value = rc.Get<GameObject>("Text_value");
            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            self.RawImage = rc.Get<GameObject>("RawImage");

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);

            ButtonHelp.AddListenerEx(self.ButtonBuy, () => { self.OnButtonBuy().Coroutine(); });
        }
    }

    public class UIJiaYuanPastureItem_AComponentDestroy: DestroySystem<UIJiaYuanPastureItem_AComponent>
    {
        public override void Destroy(UIJiaYuanPastureItem_AComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIJiaYuanPastureItem_AComponentSystem
    {
        public static void OnInitUI(this UIJiaYuanPastureItem_AComponent self, JiaYuanPastureConfig zuoQiConfig, int index)
        {
            if (self.RenderTexture != null)
            {
                self.RenderTexture.Release();
                GameObject.Destroy(self.RenderTexture);
                self.RenderTexture = null;
            }

            if (self.RenderTexture == null)
            {
                self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture.Create();
                self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

                GameObject gameObject = self.UIModelShowComponent.GameObject;
                self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
                self.UIModelShowComponent.ShowModel("Pasture/" + zuoQiConfig.Assets).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(index * 1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
        }

        public static void OnUpdateUI(this UIJiaYuanPastureItem_AComponent self, MysteryItemInfo mysteryItemInfo, int index)
        {
            JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(mysteryItemInfo.MysteryId);
            self.OnInitUI(jiaYuanPastureConfig, index);
            self.MysteryItemInfo = mysteryItemInfo;

            // 判断家园等级是否足够
            int jiayuanid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(jiayuanid);
            if (jiaYuanPastureConfig.BuyJiaYuanLv <= jiayuanCof.Lv)
            {
                self.Text_RenKou.GetComponent<Text>().text = $"人口：{jiaYuanPastureConfig.PeopleNum}";
                self.Text_Name.GetComponent<Text>().text = jiaYuanPastureConfig.Name;
                self.Text_value2.GetComponent<Text>().text = ((int)(jiaYuanPastureConfig.BuyGold * 1.5f)).ToString();

                int hour = jiaYuanPastureConfig.UpTime[3] / 3600;
                self.Text_value.GetComponent<Text>().text = $"{hour}小时";
            }
            else
            {
                self.Text_Name.GetComponent<Text>().text = jiaYuanPastureConfig.Name;

                Material mat = ResourcesComponent.Instance.LoadAsset<Material>(ABPathHelper.GetMaterialPath("UI_Hui"));
                self.RawImage.GetComponent<RawImage>().material = mat;
                self.Text_RenKou.SetActive(false);
                self.Text_Tip11.SetActive(false);
                self.Text_Tip12.SetActive(false);
                self.Text_value2.SetActive(false);
                self.Text_value.SetActive(false);
                self.Text_Tip.SetActive(true);
                self.Text_Tip.GetComponent<Text>().text = $"家园{jiaYuanPastureConfig.BuyJiaYuanLv}级开启";
            }
        }

        public static async ETTask OnButtonBuy(this UIJiaYuanPastureItem_AComponent self)
        {
            JiaYuanPastureConfig myJiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(self.MysteryItemInfo.MysteryId);

            // 判断家园等级是否足够
            int jiayuanid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(jiayuanid);
            if (myJiaYuanPastureConfig.BuyJiaYuanLv > jiayuanCof.Lv)
            {
                FloatTipManager.Instance.ShowFloatTip($"家园{myJiaYuanPastureConfig.BuyJiaYuanLv}级开启");
                return;
            }

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

            C2M_JiaYuanPastureBuyRequest c2M_MysteryBuyRequest = new C2M_JiaYuanPastureBuyRequest()
            {
                MysteryId = self.MysteryItemInfo.MysteryId, ProductId = self.MysteryItemInfo.ProductId,
            };
            M2C_JiaYuanPastureBuyResponse r2c_roleEquip =
                    (M2C_JiaYuanPastureBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_MysteryBuyRequest);

            if (r2c_roleEquip.Error != ErrorCore.ERR_Success)
            {
                return;
            }

            self.ZoneScene().GetComponent<JiaYuanComponent>().JiaYuanPastureList_7 = r2c_roleEquip.JiaYuanPastureList;

            UI jiayuanmain = UIHelper.GetUI(self.DomainScene(), UIType.UIJiaYuanMain);
            jiayuanmain.GetComponent<UIJiaYuanMainComponent>().OnUpdatePlanNumber();
            FloatTipManager.Instance.ShowFloatTip($"购买{mysteryConfig.Name}成功");
        }
    }
}