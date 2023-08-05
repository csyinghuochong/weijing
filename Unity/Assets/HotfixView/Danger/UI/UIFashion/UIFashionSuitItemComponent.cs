using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIFashionSuitItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Text_222;
        public GameObject GameObject;
        public GameObject RawImage;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

    }

    public class UIFashionSuitItemComponentAwake : AwakeSystem<UIFashionSuitItemComponent, GameObject>
    {
        public override void Awake(UIFashionSuitItemComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.RawImage.gameObject.SetActive(true);

            self.Text_222 = rc.Get<GameObject>("Text_222");

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
        }
    }


    public class UIFashionSuitItemComponentDestroy : DestroySystem<UIFashionSuitItemComponent>
    {
        public override void Destroy(UIFashionSuitItemComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);
        }
    }

    public static class UIFashionSuitItemComponentSytstem
    {
        public static void OnUpdateUI(this UIFashionSuitItemComponent self, int fashionid)
        {
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            FashionConfig fashionConfig = FashionConfigCategory.Instance.Get(fashionid);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            //int status = 0;  //0 未激活  1没穿戴 2 已穿戴
            if (bagComponent.FashionActiveIds.Contains(fashionid))
            {
                //status = bagComponent.FashionEquipList.Contains(fashionid) ? 2 : 1;
                self.Text_222.GetComponent<Text>().text = "已拥有";
                UICommonHelper.SetRawImageGray( self.RawImage, false );
            }
            else
            {
                self.Text_222.GetComponent<Text>().text = "未拥有";
                UICommonHelper.SetRawImageGray(self.RawImage, true);
            }

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