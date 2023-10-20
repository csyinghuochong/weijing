using UnityEngine;


namespace ET
{
    [UIEvent(UIType.UIPetInfo)]
    public class UIPetInfoEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetInfo);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetInfo, gameObject);
            ui.AddComponent<UIPetInfoComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetInfo);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
