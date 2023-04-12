using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UILingDiRewardLevelComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject Text_Contion;
        public GameObject ItemNode;
    }


    public class UILingDiRewardLevelComponentAwakeSystem : AwakeSystem<UILingDiRewardLevelComponent, GameObject>
    {
        public override void Awake(UILingDiRewardLevelComponent self, GameObject go)
        {
            self.GameObject = go;

            self.Text_Contion = go.Get<GameObject>("Text_Contion");
            self.ItemNode = go.Get<GameObject>("ItemNode");
        }
    }

    public static class UILingDiRewardLevelComponentSystem
    {

        public static async ETTask OnInitUI(this UILingDiRewardLevelComponent self, List<LingDiRewardConfig> lingDiRewardConfigs)
        {
            await ETTask.CompletedTask;
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int lingdiLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiLv);
            var path = ABPathHelper.GetUGUIPath("Main/LingDi/UILingDiRewardItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            int itemNum = lingDiRewardConfigs.Count;
            GridLayoutGroup gridLayoutGroup = self.ItemNode.GetComponent<GridLayoutGroup>();
            int row = (itemNum / gridLayoutGroup.constraintCount);
            row += (itemNum % gridLayoutGroup.constraintCount > 0 ? 1 : 0);
            self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1600f, 100f + row * 250f);
            self.Text_Contion.GetComponent<Text>().text = $"领地达到({lingdiLv}/{lingDiRewardConfigs[0].CountryLvlimit})可激活兑换";

            for (int i = 0; i < lingDiRewardConfigs.Count; i++)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.ItemNode);
                LingDiRewardConfig shouJiItemConfig = lingDiRewardConfigs[i];
                self.AddChild<UILingDiRewardItemComponent, GameObject>(go).OnUpdateUI(shouJiItemConfig, lingdiLv);
            }
        }

    }
}