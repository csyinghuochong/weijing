using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIFashionShowItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;

        public GameObject Text_222;
        public GameObject Text_111;

        public GameObject Btn_Active;
        public GameObject RawImage;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

        public int Status;
    }

    public class UIFashionShowItemComponentAwake : AwakeSystem<UIFashionShowItemComponent, GameObject>
    {
        public override void Awake(UIFashionShowItemComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_222 = rc.Get<GameObject>("Text_222");
            self.Text_111 = rc.Get<GameObject>("Text_111");
            self.Btn_Active = rc.Get<GameObject>("Btn_Active");

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.RawImage.gameObject.SetActive(true);

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
        }
    }

    public class UIFashionShowItemComponentDestroy : DestroySystem<UIFashionShowItemComponent>
    {
        public override void Destroy(UIFashionShowItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIFashionShowItemComponentSystem
    {

        public static void OnUpdateUI(this UIFashionShowItemComponent self, int fashionid)
        {
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            int status = 0;


            FashionConfig fashionConfig = FashionConfigCategory.Instance.Get( fashionid );

            self.Text_111.GetComponent<Text>().text = fashionConfig.Name;

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
                self.UIModelShowComponent.ShowModel($"Parts/{occ}/" + fashionConfig.Model).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 20f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 45;
                gameObject.transform.localPosition = new Vector2((fashionid % 10) * 1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
        }
    }
}