using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIUnionMystery_AComponent: Entity, IAwake
    {
        public GameObject cellContainer1;
        public GameObject closeButton;
        public GameObject RawImage;

        public UserInfoComponent UserInfoComponent;
        public UIModelShowComponent uIModelShowComponent;
        public List<UIUnionMysteryItem_AComponent> SellList = new List<UIUnionMysteryItem_AComponent>();
    }

    public class UIUnionMystery_AComponentAwakeSystem: AwakeSystem<UIUnionMystery_AComponent>
    {
        public override void Awake(UIUnionMystery_AComponent self)
        {
            self.Awake();
        }
    }

    public static class UIUnionMystery_AComponentSystem
    {
        public static void Awake(this UIUnionMystery_AComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.UserInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();

            self.InitModelShowView().Coroutine();
            self.RequestMystery().Coroutine();
        }

        public static async ETTask InitModelShowView(this UIUnionMystery_AComponent self)
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

        public static async ETTask UpdateMysteryItem(this UIUnionMystery_AComponent self, List<MysteryItemInfo> mysteryItemInfos)
        {
            string path_1 = ABPathHelper.GetUGUIPath("Main/Mystery/UIMysteryItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path_1);

            int number = 0;
            for (int i = 0; i < mysteryItemInfos.Count; i++)
            {
                UIUnionMysteryItem_AComponent ui_1 = null;
                if (number < self.SellList.Count)
                {
                    ui_1 = self.SellList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(storeItem, self.cellContainer1);

                    ui_1 = self.AddChild<UIUnionMysteryItem_AComponent, GameObject>(storeItem);
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

        public static async ETTask RequestMystery(this UIUnionMystery_AComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long unionId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
            C2U_UnionMysteryListRequest request = new C2U_UnionMysteryListRequest() { UnionId = unionId };
            U2C_UnionMysteryListResponse response =
                    await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request) as U2C_UnionMysteryListResponse;
            self.UpdateMysteryItem(response.MysteryItemInfos).Coroutine();
        }
    }
}