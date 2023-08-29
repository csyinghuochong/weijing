using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIDemonMain)]
    public class UIDemonMainEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDemonMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIDemonMain, gameObject);
            ui.AddComponent<UIDemonMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDemonMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}