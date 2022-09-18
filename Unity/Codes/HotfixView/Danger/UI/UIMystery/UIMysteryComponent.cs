using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMysteryComponent : Entity, IAwake, IDestroy
    {
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UI> SellList = new List<UI>();
    }


    [ObjectSystem]
    public class UIMysteryComponentAwakeSystem : AwakeSystem<UIMysteryComponent>
    {

        public override void Awake(UIMysteryComponent self)
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

    [ObjectSystem]
    public class UIMysteryComponentDestroySystem : DestroySystem<UIMysteryComponent>
    {
        public override void Destroy(UIMysteryComponent self)
        {
            for (int i = 0; i < self.SellList.Count; i++)
            {
                self.SellList[i].Dispose();
            }
            self.SellList = null;
        }
    }

    public static class UIMysteryComponentSystem
    {
        public static async ETTask InitModelShowView(this UIMysteryComponent self)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow1");
            await ETTask.CompletedTask;
            GameObject bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            UI ui = self.AddChild<UI, string, GameObject>( "UIModelShow", gameObject);
            self.uIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            //配置摄像机位置[0,115,257]
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 115, 257f);
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(UIHelper.CurrentNpc);
            self.uIModelShowComponent.ShowOtherModel("Npc/" + npcConfig.Asset.ToString()).Coroutine();
        }

        public static void OnCloseStore(this UIMysteryComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIMystery);
        }

        public static async ETTask UpdateMysteryItem(this UIMysteryComponent self, List<MysteryItemInfo> mysteryItemInfos)
        {
            string path_1 = ABPathHelper.GetUGUIPath("Main/Mystery/UIMysteryItem");
            await ETTask.CompletedTask;
            GameObject bundleObj =ResourcesComponent.Instance.LoadAsset<GameObject>(path_1);

            for (int i = 0; i < mysteryItemInfos.Count; i++)
            {
                UI ui_1 = null;
                if (i < self.SellList.Count)
                {
                    ui_1 = self.SellList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {

                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UI, string, GameObject>( "storeItem_" + i, storeItem);
                    UIMysteryItemComponent uIItemComponent = ui_1.AddComponent<UIMysteryItemComponent>();
                    self.SellList.Add(ui_1);
                }
                ui_1.GetComponent<UIMysteryItemComponent>().OnUpdateUI(mysteryItemInfos[i], UIHelper.CurrentNpc);
            }

            for (int i = mysteryItemInfos.Count; i < self.SellList.Count; i++)
            {
                self.SellList[i].GameObject.SetActive(false);
            }
        }

        public static async ETTask RequestMystery(this UIMysteryComponent self)
        {
            if (UIHelper.CurrentNpc == ComHelp.ShenMiNpcId)
            {
                C2A_MysteryListRequest c2A_MysteryListRequest = new C2A_MysteryListRequest() { UserId = self.UserInfoComponent.UserInfo.UserId };
                A2C_MysteryListResponse r2c_roleEquip = (A2C_MysteryListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2A_MysteryListRequest);
                self.UpdateMysteryItem(r2c_roleEquip.MysteryItemInfos).Coroutine();
            }
            else
            {
                Actor_FubenMoNengRequest c2M_MoNengListRequest = new Actor_FubenMoNengRequest();
                Actor_FubenMoNengResponse m2C_MoNengListResponse = (Actor_FubenMoNengResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_MoNengListRequest);
                self.UpdateMysteryItem(m2C_MoNengListResponse.MysteryItemInfos).Coroutine();
            }
        }

    }
}
