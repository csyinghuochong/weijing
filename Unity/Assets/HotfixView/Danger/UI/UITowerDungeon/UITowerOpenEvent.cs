using UnityEngine;
namespace ET
{

    [UIEvent(UIType.UITowerOpen)]
    public class UITowerOpenEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOpen);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerOpen, gameObject);
            ui.AddComponent<UITowerOpenComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOpen);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
