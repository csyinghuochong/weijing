using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIZuoQiShowItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject StarList;
        public GameObject ButtonFight;
        public Text TextName;
        public GameObject GameObject;
        public Text Text_Attribute_1;
        public GameObject RawImage;
        public ZuoQiShowConfig ZuoQiConfig;
        public GameObject LabProDes;
        public GameObject Lab_LaiYuan;
        public GameObject LabDes;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;
    }

    [ObjectSystem]
    public class UIZuoQiShowItemComponentAwake : AwakeSystem<UIZuoQiShowItemComponent, GameObject>
    {
        public override void Awake(UIZuoQiShowItemComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.Text_Attribute_1 = rc.Get<GameObject>("Text_Attribute_1").GetComponent<Text>();
            self.TextName = rc.Get<GameObject>("TextName").GetComponent<Text>();
            self.RawImage = rc.Get<GameObject>("RawImage");

            self.LabProDes = rc.Get<GameObject>("LabProDes");
            self.Lab_LaiYuan = rc.Get<GameObject>("Lab_LaiYuan");
            self.LabDes = rc.Get<GameObject>("LabDes");

            self.StarList = rc.Get<GameObject>("StarList");
            self.ButtonFight = rc.Get<GameObject>("ButtonFight");
            ButtonHelp.AddListenerEx(self.ButtonFight, () => { self.OnButtonFight().Coroutine(); });
        }
    }
    [ObjectSystem]
    public class UIZuoQiShowItemComponentDestroy : DestroySystem<UIZuoQiShowItemComponent>
    {
        public override void Destroy(UIZuoQiShowItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIZuoQiShowItemComponentSystem
    {

        public static async ETTask OnButtonFight(this UIZuoQiShowItemComponent self)
        {
            if (!self.IsHaveZuoQi(self.ZuoQiConfig.Id))
            {
                FloatTipManager.Instance.ShowFloatTip("请先激活当前坐骑！");
                return;
            }

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Lv < 25) {
                FloatTipManager.Instance.ShowFloatTip("等级达到25级才可以骑乘坐骑喔！");
                return;
            }

            C2M_HorseFightRequest  request = new C2M_HorseFightRequest() { HorseId = self.ZuoQiConfig.Id };
            M2C_HorseFightResponse response = await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_HorseFightResponse;

            if (response.Error == ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("激活坐骑成功,清在主界面点击骑乘按钮即可喔！");
            }

        }

        public static bool IsHaveZuoQi(this UIZuoQiShowItemComponent self, int zuoqiId)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            return userInfo.HorseIds.Contains(zuoqiId);
        }

        public static void OnInitUI(this UIZuoQiShowItemComponent self, ZuoQiShowConfig zuoQiConfig)
        {
            self.ZuoQiConfig = zuoQiConfig;
            self.TextName.text = zuoQiConfig.Name;
            self.RenderTexture = null;
            self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
            self.UIModelShowComponent.ShowModel("ZuoQi/" + zuoQiConfig.ModelID).Coroutine();
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 112f, 450f);
            gameObject.transform.localPosition = new Vector2(zuoQiConfig.Id % 10 * 1000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);


            //显示属性和来源
            self.LabProDes.GetComponent<Text>().text = self.ZuoQiConfig.Des;
            self.Lab_LaiYuan.GetComponent<Text>().text = self.ZuoQiConfig.GetDes;
            //获取技能Buff
            SkillBuffConfig buffCof = SkillBuffConfigCategory.Instance.Get(self.ZuoQiConfig.MoveBuffID);
            self.LabDes.GetComponent<Text>().text = buffCof.BuffDescribe;

            UICommonHelper.SetRawImageGray(self.RawImage.gameObject, !self.IsHaveZuoQi(zuoQiConfig.Id));

            self.ButtonFight.SetActive(self.IsHaveZuoQi(zuoQiConfig.Id));
            self.Lab_LaiYuan.SetActive(!self.IsHaveZuoQi(zuoQiConfig.Id));
            int quility = zuoQiConfig.Quality;
            for (int i = 0; i < self.StarList.transform.childCount; i++)
            {
                self.StarList.transform.GetChild(i).gameObject.SetActive(quility > i);
            }
        }
    }
}