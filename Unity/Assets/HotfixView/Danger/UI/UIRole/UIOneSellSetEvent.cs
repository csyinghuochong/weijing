using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIOneSellSet)]
    public class UIOneSellSetEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIOneSellSet);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIOneSellSet, gameObject);

            ui.AddComponent<UIOneSellSetComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIOneSellSet);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}