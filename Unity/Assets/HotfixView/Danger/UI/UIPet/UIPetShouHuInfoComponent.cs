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
        public GameObject ImageSelect;
        public GameObject ImageActive;

        public GameObject RawImage;
        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

        public int Index;
        public Action<int> SelectHandler;
    }

    public class UIPetShouHuInfoComponentAwake : AwakeSystem<UIPetShouHuInfoComponent, GameObject>
    {
        public override void Awake(UIPetShouHuInfoComponent self, GameObject go)
        {

            self.ImageIcon  = go.transform.Find("ImageIcon").GetComponent<Image>();
            self.RawImage    = go.transform.Find("RawImage").gameObject;
            self.Text_Name  = go.transform.Find("Text_Name").GetComponent<Text>();
            self.Text_Attri = go.transform.Find("Text_Attri").GetComponent<Text>();
            self.ImageSelect = go.transform.Find("ImageSelect").gameObject;
            self.ImageSelect.SetActive(false);

            self.ImageActive = go.transform.Find("ImageActive").gameObject;
            self.ImageActive.SetActive(false);

            GameObject ImageButton = go.transform.Find("ImageButton").gameObject;
            ImageButton.GetComponent<Button>().onClick.AddListener(self.OnClickButton); 

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

        public static void OnClickButton(this UIPetShouHuInfoComponent self)
        {
            self.SelectHandler(self.Index);
        }

        public static void SetSelectHandler(this UIPetShouHuInfoComponent self, int index,  Action<int> action)
        {
            self.Index = index;
            self.SelectHandler = action;
        }

        public static void OnUpdateUI(this UIPetShouHuInfoComponent self, int index)
        {
            self.Index = index;
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

            int fightNum = 0;
            for (int i = 0; i<4; i++) {
                RolePetInfo rolePetInfoNow = petComponent.GetPetInfoByID(petComponent.PetShouHuList[i]);
                if (rolePetInfoNow != null)
                {
                    fightNum = fightNum + rolePetInfoNow.PetPingFen;
                }
            }

            switch (index) {
                case 0:
                    self.Text_Attri.GetComponent<Text>().text = "暴击率附加" + (ComHelp.GetPetShouHuPro(rolePetInfo.PetPingFen, fightNum) * 100).ToString("F2") + "%";
                    break;

                case 1:
                    self.Text_Attri.GetComponent<Text>().text = "抗暴率附加" + (ComHelp.GetPetShouHuPro(rolePetInfo.PetPingFen, fightNum) * 100).ToString("F2") + "%";
                    break;

                case 2:
                    self.Text_Attri.GetComponent<Text>().text = "命中率附加" + (ComHelp.GetPetShouHuPro(rolePetInfo.PetPingFen, fightNum) * 100).ToString("F2") + "%";
                    break;

                case 3:
                    self.Text_Attri.GetComponent<Text>().text = "闪避率附加" + (ComHelp.GetPetShouHuPro(rolePetInfo.PetPingFen, fightNum) * 100).ToString("F2") + "%";
                    break;
            }
        }
    }

}