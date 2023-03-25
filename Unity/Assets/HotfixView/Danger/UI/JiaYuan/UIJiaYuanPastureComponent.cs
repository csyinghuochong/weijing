using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPastureComponent : Entity, IAwake, IDestroy
    {
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UIJiaYuanPastureItemComponent> SellList = new List<UIJiaYuanPastureItemComponent>();
    }

    [ObjectSystem]
    public class UIJiaYuanPastureComponentAwake : AwakeSystem<UIJiaYuanPastureComponent>
    {

        public override void Awake(UIJiaYuanPastureComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.closeButton = rc.Get<GameObject>("closeButton");
            self.closeButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseStore(); });

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.InitModelShowView().Coroutine();
            self.RequestMystery().Coroutine();
        }
    }

    public static class UIJiaYuanPastureComponentSystem
    {
        public static async ETTask InitModelShowView(this UIJiaYuanPastureComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>("UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(UIHelper.CurrentNpcId);
            self.uIModelShowComponent.ShowOtherModel("Npc/" + npcConfig.Asset.ToString()).Coroutine();
        }

        public static void OnCloseStore(this UIJiaYuanPastureComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIJiaYuanPasture);
        }

        public static async ETTask UpdateMysteryItem(this UIJiaYuanPastureComponent self, List<MysteryItemInfo> mysteryItemInfos)
        {
            string path_1 = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPastureItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path_1);

            int number = 0;
            for (int i = 0; i < mysteryItemInfos.Count; i++)
            {
                UIJiaYuanPastureItemComponent ui_1 = null;
                if (number < self.SellList.Count)
                {
                    ui_1 = self.SellList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UIJiaYuanPastureItemComponent, GameObject>(storeItem);
                    self.SellList.Add(ui_1);
                }
                ui_1.OnUpdateUI(mysteryItemInfos[i]);
                number++;
            }

            for (int i = number; i < self.SellList.Count; i++)
            {
                self.SellList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask RequestMystery(this UIJiaYuanPastureComponent self)
        {
            C2M_JiaYuanPastureListRequest c2A_MysteryListRequest = new C2M_JiaYuanPastureListRequest() { };
            M2C_JiaYuanPastureListResponse r2c_roleEquip = (M2C_JiaYuanPastureListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2A_MysteryListRequest);
            self.UpdateMysteryItem(r2c_roleEquip.MysteryItemInfos).Coroutine();
        }

    }
}
