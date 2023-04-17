using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetShouHuInfoComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public Image ImageIcon;
        public Text Text_Name;
        public Text Text_Attri;

        public GameObject RawImage;
        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;
    }

    public class UIPetShouHuInfoComponentAwake : AwakeSystem<UIPetShouHuInfoComponent, GameObject>
    {
        public override void Awake(UIPetShouHuInfoComponent self, GameObject go)
        {

            self.ImageIcon  = go.transform.Find("ImageIcon").GetComponent<Image>();
            self.RawImage    = go.transform.Find("RawImage").gameObject;
            self.Text_Name  = go.transform.Find("Text_Name").GetComponent<Text>();
            self.Text_Attri = go.transform.Find("Text_Attri").GetComponent<Text>();

            self.RenderTexture = null;
            self.RenderTexture = new RenderTexture(512, 512, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
        }
    }

    public class UIPetShouHuInfoComponentDestroy : DestroySystem<UIPetShouHuInfoComponent>
    {
        public override void Destroy(UIPetShouHuInfoComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
        }
    }

    public static class UIPetShouHuInfoComponentSystem
    {
        public static void OnUpdateUI(this UIPetShouHuInfoComponent self, int index)
        {
            self.Text_Name.text = ConfigHelper.PetShouHuAttri[index].Value;
            self.ImageIcon.sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.OtherIcon, $"ShouHu_{index}");

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfoByID(petComponent.PetShouHuList[index]);
            if (rolePetInfo == null)
            {
                self.RawImage.SetActive(false);
                return;
            }

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            self.RawImage.SetActive(true);
            GameObject  gameObject = self.UIModelShowComponent.GameObject;
            self.UIModelShowComponent.ShowModel("Pet/" + petConfig.PetModel).Coroutine();
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
            gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
            gameObject.transform.localPosition = new Vector2(index * 1000 + 10000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
        }
    }

}