using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITowerOfSealCost)]
    public class UITowerOfSealCostEvent: AUIEvent
    {
        
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSealCost);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerOfSealCost, gameObject);
            ui.AddComponent<UITowerOfSealCostComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSealCost);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}