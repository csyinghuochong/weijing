using System;
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

        public int Index;
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
            ButtonHelp.AddListenerEx(self.ButtonOpen, () => { self.OnButtonOpen(); });

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

        public static  void OnButtonOpen(this UIPetCangKuDefendComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            if (petComponent.PetCangKuOpen.Contains(self.Index - 1))
            {
                FloatTipManager.Instance.ShowFloatTip("已开启！");
                return;
            }
            int jiayuanlv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(jiayuanlv);
            int petNum = jiaYuanConfig.PetNum;
            if (petNum <= petComponent.PetCangKuOpen.Count)
            {
                FloatTipManager.Instance.ShowFloatTip("家园等级不足！");
                return;
            }


            string costitem = ConfigHelper.PetOpenCangKu[ self.Index - 1 ];
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem(costitem))
            {
                FloatTipManager.Instance.ShowFloatTip("金币不足！");
                return;
            }
            string costdesc = UICommonHelper.GetNeedItemDesc(costitem);
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "宠物仓库", $"是否花费{costdesc}开启宠物仓库?", () =>
            {
                self.RequestOpenCangKu().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestOpenCangKu(this UIPetCangKuDefendComponent self)
        {
            C2M_PetOpenCangKu request = new C2M_PetOpenCangKu() { OpenIndex = self.Index  };
            M2C_PetOpenCangKu reponse = (M2C_PetOpenCangKu)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (reponse.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            if (self.IsDisposed)
            {
                return;
            }
            self.ZoneScene().GetComponent<PetComponent>().PetCangKuOpen.Add(self.Index - 1);
            self.Text_Name.GetComponent<Text>().text =  string.Empty;
            self.ButtonQuHui.SetActive(false);
            self.ButtonOpen.SetActive(false);
            self.PetCangKuAction?.Invoke();
        }

        public static async ETTask OnButtonQuHui(this UIPetCangKuDefendComponent self)
        {
            if (self.RolePetInfo == null)
            {
                return;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            int maxNum = ComHelp.GetPetMaxNumber(unit, userInfo.Lv);
            if (PetHelper.GetBagPetNum(self.ZoneScene().GetComponent<PetComponent>().RolePetInfos) >= maxNum)
            {
                FloatTipManager.Instance.ShowFloatTip("宠物格子不足！");
                return;
            }

            C2M_PetPutCangKu c2M_PetPutCangKu = new C2M_PetPutCangKu() { PetInfoId = self.RolePetInfo.Id, PetStatus = 0 };
            M2C_PetPutCangKu m2C_PetPutCangKu = (M2C_PetPutCangKu)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_PetPutCangKu);
            if (m2C_PetPutCangKu.Error != 0)
            {
                return;
            }
            self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.RolePetInfo.Id).PetStatus = 0;
            self.PetCangKuAction?.Invoke();
        }

        public static void SetAction(this UIPetCangKuDefendComponent self, Action action)
        {
            self.PetCangKuAction = action;  
        }

        public static void OnUpdateUI(this UIPetCangKuDefendComponent self, int jiayuan, int index, int openindex)
        {
            self.Index = index;
            self.RolePetInfo = null;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(jiayuan);
            int petNum = jiaYuanConfig.PetNum;

            if (petNum < index || !petComponent.PetCangKuOpen.Contains(index - 1))
            {
                int openlv = PetHelper.GetCangKuOpenLv(index);
                self.Text_Name.GetComponent<Text>().text = $"{JiaYuanConfigCategory.Instance.Get(openlv).Lv}级开启";
                self.ButtonOpen.SetActive(true);
                self.ButtonQuHui.SetActive(false);
                return;
            }

            int cangkuindex = 0;
            RolePetInfo rolePetInfo = null;
            for (int i = 0; i < petComponent.RolePetInfos.Count; i++)
            {
                if (petComponent.RolePetInfos[i].PetStatus == 3)
                {
                    cangkuindex++;
                }
                if (cangkuindex == openindex)
                {
                    rolePetInfo = petComponent.RolePetInfos[i];
                    break;
                }
            }
            if (rolePetInfo != null)
            {
                self.RawImage.SetActive(true);
                self.Text_Name.GetComponent<Text>().text = rolePetInfo.PetName;

                PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
                GameObject gameObject = self.UIModelShowComponent.GameObject;
                self.UIModelShowComponent.ShowModel("Pet/" + petConfig.PetModel).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
                gameObject.transform.localPosition = new Vector2(index * 1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
            else
            {
                self.RawImage.SetActive(false);
            }

            self.Text_Name.GetComponent<Text>().text = rolePetInfo != null ? rolePetInfo.PetName : string.Empty;
            self.ButtonQuHui.SetActive(rolePetInfo != null);
            self.ButtonOpen.SetActive(!petComponent.PetCangKuOpen.Contains(index - 1));

            self.RolePetInfo = rolePetInfo;
        }
    }
}