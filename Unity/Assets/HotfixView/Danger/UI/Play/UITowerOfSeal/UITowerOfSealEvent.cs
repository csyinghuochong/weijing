using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITowerOfSeal)]
    public class UITowerOfSealEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSeal);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerOfSeal, gameObject);
            ui.AddComponent<UITowerOfSealComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSeal);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}