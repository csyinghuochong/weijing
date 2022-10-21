using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIStoreComponent : Entity, IAwake
    {
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;

        public UIModelShowComponent uIModelShowComponent;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }

    [ObjectSystem]
    public class UIStoreComponentAwakeSystem : AwakeSystem<UIStoreComponent>
    {

        public override void Awake(UIStoreComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStore(); });

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.RawImage = rc.Get<GameObject>("RawImage");

            self.InitModelShowView().Coroutine();
            self.InitData(UIHelper.CurrentNpcId);
        }
    }

    public static class UIStoreComponentSystem
    {
        public static async ETTask InitModelShowView(this UIStoreComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            await ETTask.CompletedTask;
            GameObject bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100, 257f);
            gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 50;
        }


        public static void OnCloseStore(this UIStoreComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIStore);
        }

        public static  void InitData(this UIStoreComponent self, int npcid)
        {
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcid);
            int shopSellid = npcConfig.ShopValue;

            string path_1 = ABPathHelper.GetUGUIPath("Main/Store/UIStoreItem");
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path_1);
            int playLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;

            while (shopSellid != 0)
            {
                StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(shopSellid);
                shopSellid = storeSellConfig.NextID;
                if (playLv < storeSellConfig.ShowRoleLvMin || playLv > storeSellConfig.ShowRoleLvMax)
                {
                    continue;
                }

                GameObject storeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(storeItem, self.cellContainer1);

                UIStoreItemComponent uIItemComponent = self.AddChild<UIStoreItemComponent, GameObject>(storeItem);
                uIItemComponent.OnUpdateData(storeSellConfig);
                self.SellList.Add(uIItemComponent);
            }

            self.uIModelShowComponent.ShowOtherModel("Npc/" + npcConfig.Asset.ToString()).Coroutine();
        }

    }

}