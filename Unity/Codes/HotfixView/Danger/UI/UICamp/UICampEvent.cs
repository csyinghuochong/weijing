using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICamp)]
    public class UICampEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICamp);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UICamp, gameObject);
            ui.AddComponent<UICampComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICamp);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
