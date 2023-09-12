using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIFashionShowItemComponent : Entity, IAwake<GameObject>, IDestroy
    {

        public GameObject ImageDi;
        public GameObject GameObject;

        public GameObject Text_222;
        public GameObject Text_111;

        public GameObject Btn_Active;
        public GameObject RawImage;

        public RenderTexture RenderTexture;
        public UIItemComponent UIItemComponent;
        public UIModelDynamicComponent UIModelShowComponent;

        public Action<int> PreviewHandler;
        public Action FashionWearHandler;

        public int FashionId;
        public int Status;
    }

    public class UIFashionShowItemComponentAwake : AwakeSystem<UIFashionShowItemComponent, GameObject>
    {
        public override void Awake(UIFashionShowItemComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");
            ButtonHelp.AddListenerEx(self.ImageDi, () => { self.OnImageDi(); });

            self.Text_222 = rc.Get<GameObject>("Text_222");
            self.Text_111 = rc.Get<GameObject>("Text_111");
            self.Btn_Active = rc.Get<GameObject>("Btn_Active");
            ButtonHelp.AddListenerEx(  self.Btn_Active, () => { self.OnBtn_Active().Coroutine();  } );

            self.RawImage = rc.Get<GameObject>("RawImage");
            self.RawImage.gameObject.SetActive(true);

            GameObject UIItem = rc.Get<GameObject>("UIItem");
            self.UIItemComponent = self.AddChild<UIItemComponent, GameObject>(UIItem);

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

        public static void OnImageDi(this UIFashionShowItemComponent self)
        {
            self.PreviewHandler( self.FashionId );
        }

        public static async ETTask OnBtn_Active(this UIFashionShowItemComponent self)
        {
            long instanceid = self.InstanceId;
            switch (self.Status)
            {
                case 0:
                    FashionConfig fashionConfig = FashionConfigCategory.Instance.Get(self.FashionId);
                    BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
                    if (!bagComponent.CheckNeedItem(fashionConfig.ActiveCost))
                    {
                        FloatTipManager.Instance.ShowFloatTip("道具不足");
                        return;
                    }

                    C2M_FashionActiveRequest request = new C2M_FashionActiveRequest() {  FashionId = self.FashionId };
                    M2C_FashionActiveResponse response = (M2C_FashionActiveResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
                    if (instanceid != self.InstanceId)
                    {
                        return;
                    }
                   
                    if (response.Error == ErrorCode.ERR_Success && !bagComponent.FashionActiveIds.Contains(self.FashionId))
                    {
                        bagComponent.FashionActiveIds.Add( self.FashionId );
                    }
                    break;
                case 1:
                case 2:
                    C2M_FashionWearRequest request1 = new C2M_FashionWearRequest() { FashionId = self.FashionId, OperatateType = self.Status };
                    M2C_FashionWearResponse response1 = (M2C_FashionWearResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request1);
                    if (instanceid != self.InstanceId)
                    {
                        return;
                    }

                    self.FashionWearHandler.Invoke();
                    break;
            }

            self.OnUpdateUI(self.FashionId);
        }

        public static void OnUpdateUI(this UIFashionShowItemComponent self, int fashionid)
        {
            self.FashionId = fashionid; 
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            int status = 0;  //0 未激活  1没穿戴 2 已穿戴
            if (bagComponent.FashionActiveIds.Contains(fashionid))
            {
                status = bagComponent.FashionEquipList.Contains(fashionid) ? 2 : 1;
            }
            self.Status = status;

            switch (self.Status)
            {
                case 0:
                    self.Btn_Active.transform.Find("Text").GetComponent<Text>().text = "激活";
                    break;
                case 1:
                    self.Btn_Active.transform.Find("Text").GetComponent<Text>().text = "穿戴";
                    break;
                case 2:
                    self.Btn_Active.transform.Find("Text").GetComponent<Text>().text = "卸下";
                    break;
            }
            FashionConfig fashionConfig = FashionConfigCategory.Instance.Get( fashionid );

            string[] costitem = fashionConfig.ActiveCost.Split(';');
            self.Text_111.GetComponent<Text>().text = fashionConfig.Name;
            self.Text_222.GetComponent<Text>().text = $"X{int.Parse(costitem[1])}";
            int havenumber = (int)bagComponent.GetItemNumber(int.Parse(costitem[0]));
            self.UIItemComponent.UpdateItem( new BagInfo() { ItemID = int.Parse(costitem[0]), ItemNum = havenumber } , ItemOperateEnum.None);
            self.UIItemComponent.Label_ItemName.SetActive(true);
            self.UIItemComponent.Label_ItemNum.SetActive(false);
            //UICommonHelper.SetImageGray(self.UIItemComponent.Image_ItemIcon, havenumber < int.Parse(costitem[1]));
            //UICommonHelper.SetImageGray(self.UIItemComponent.Image_ItemQuality, havenumber < int.Parse(costitem[1]));

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
                self.UIModelShowComponent.ShowModel($"Parts/Fashion/" + FashionConfigCategory.Instance.GetModelList(fashionid)[0]).Coroutine();
                gameObject.transform.Find("Camera").localPosition = new Vector3((float)fashionConfig.Camera[0], (float)fashionConfig.Camera[1], (float)fashionConfig.Camera[2]);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = (float)fashionConfig.Camera[3];
                gameObject.transform.localPosition = new Vector2((fashionid % 10) * 1000 + 1000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }
        }
    }
}