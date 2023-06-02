using ET;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetCangKuDefendComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject GameObject;
        public GameObject Text_Name;
        public GameObject RawImage;
        public GameObject ButtonQuHui;
        public GameObject ButtonOpen;

        public RolePetInfo RolePetInfo;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

        public Action PetCangKuAction;
    }

    public class UIPetCangKuDefendComponentAwake : AwakeSystem<UIPetCangKuDefendComponent, GameObject>
    {
        public override void Awake(UIPetCangKuDefendComponent self, GameObject go)
        {
            self.GameObject = go;   
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();

            self.Text_Name = rc.Get<GameObject>("Text_Name");

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.RawImage.SetActive(true);
            self.ButtonQuHui = rc.Get<GameObject>("ButtonQuHui");
            ButtonHelp.AddListenerEx(self.ButtonQuHui, () => { self.OnButtonQuHui().Coroutine(); });

            self.ButtonOpen = rc.Get<GameObject>("ButtonOpen");

            self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
        }
    }

    public class UIPetCangKuDefendComponentDestroy : DestroySystem<UIPetCangKuDefendComponent>
    {
        public override void Destroy(UIPetCangKuDefendComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
        }
    }

    public static class UIPetCangKuDefendComponentSystem
    {

        public static async ETTask OnButtonQuHui(this UIPetCangKuDefendComponent self)
        {
            if (self.RolePetInfo == null)
            {
                return;
            }
            C2M_PetPutCangKu c2M_PetPutCangKu = new C2M_PetPutCangKu() { PetInfoId = self.RolePetInfo.Id, PetStatus = 0 };
            M2C_PetPutCangKu m2C_PetPutCangKu = (M2C_PetPutCangKu)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_PetPutCangKu);
            self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.RolePetInfo.Id).PetStatus = 0;
            self.PetCangKuAction?.Invoke();
        }

        public static void SetAction(this UIPetCangKuDefendComponent self, Action action)
        {
            self.PetCangKuAction = action;  
        }

        public static void OnUpdateUI(this UIPetCangKuDefendComponent self, int jiayuan, int index)
        {
            self.RolePetInfo = null;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(jiayuan);
            int petNum = jiaYuanConfig.PetNum;

            if (petNum < index)
            {
                int openlv = PetHelper.GetCanKuOpenLv(index);
                self.Text_Name.GetComponent<Text>().text = $"{JiaYuanConfigCategory.Instance.Get(openlv).Lv}¼¶¿ªÆô";
                self.ButtonOpen.SetActive(true);
                self.ButtonQuHui.SetActive(false);
                return;
            }

            self.Text_Name.GetComponent<Text>().text = string.Empty;
            self.ButtonOpen.SetActive(false);
            self.ButtonQuHui.SetActive(true);

            int cangkuindex = 0;
            RolePetInfo rolePetInfo = null;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < petComponent.RolePetInfos.Count; i++)
            {
                if (petComponent.RolePetInfos[i].PetStatus == 3)
                {
                    cangkuindex++;
                }
                if (cangkuindex == index)
                {
                    rolePetInfo = petComponent.RolePetInfos[i];
                    break;
                }
            }
            if (rolePetInfo != null)
            {
                self.Text_Name.GetComponent<Text>().text = rolePetInfo.PetName;
            }
            if (rolePetInfo != null)
            {
                PetConfig petConfig = PetConfigCategory.Instance.Get( rolePetInfo.ConfigId);
                GameObject gameObject = self.UIModelShowComponent.GameObject;
                self.UIModelShowComponent.ShowModel("Pet/" + petConfig.PetModel).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(index * 1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
            self.RolePetInfo = rolePetInfo;
        }
    }
}