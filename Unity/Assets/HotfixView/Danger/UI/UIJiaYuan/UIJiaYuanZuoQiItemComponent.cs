using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanZuoQiItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
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
    public class UIJiaYuanZuoQiItemComponentAwake : AwakeSystem<UIJiaYuanZuoQiItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanZuoQiItemComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.Text_Attribute_1 = rc.Get<GameObject>("Text_Attribute_1").GetComponent<Text>();
            self.TextName = rc.Get<GameObject>("TextName").GetComponent<Text>();
            self.RawImage = rc.Get<GameObject>("RawImage");

            self.LabProDes = rc.Get<GameObject>("LabProDes");
            self.Lab_LaiYuan = rc.Get<GameObject>("Lab_LaiYuan");
            self.LabDes = rc.Get<GameObject>("LabDes");

        }
    }

    [ObjectSystem]
    public class UIJiaYuanZuoQiItemComponentDestroy : DestroySystem<UIJiaYuanZuoQiItemComponent>
    {
        public override void Destroy(UIJiaYuanZuoQiItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIJiaYuanZuoQiItemComponentSystem
    {
        public static void OnInitUI(this UIJiaYuanZuoQiItemComponent self, ZuoQiShowConfig zuoQiConfig)
        {
            self.ZuoQiConfig    = zuoQiConfig;
            self.TextName.text  = zuoQiConfig.Name;
            self.RenderTexture  = null;
            self.RenderTexture  = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
            self.UIModelShowComponent.ShowModel("ZuoQi/" + zuoQiConfig.ModelID).Coroutine();
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 112f, 300f);
            gameObject.transform.localPosition = new Vector2(zuoQiConfig.Id % 10 * 1000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f,-45f,0f);

            //显示属性和来源
            self.LabProDes.GetComponent<Text>().text = self.ZuoQiConfig.Des;
            self.Lab_LaiYuan.GetComponent<Text>().text = self.ZuoQiConfig.GetDes;
            //获取技能Buff
            SkillBuffConfig buffCof = SkillBuffConfigCategory.Instance.Get(self.ZuoQiConfig.MoveBuffID);
            self.LabDes.GetComponent<Text>().text = buffCof.BuffDescribe;

        }
    }
}
