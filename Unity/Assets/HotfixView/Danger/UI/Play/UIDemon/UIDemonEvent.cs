using UnityEngine;

namespace ET
{
    public class UIDemonEvent
    {
        [UIEvent(UIType.UIDemon)]
        public class UIDemonMainEvent : AUIEvent
        {
            public override async ETTask<UI> OnCreate(UIComponent uiComponent)
            {
                var path = ABPathHelper.GetUGUIPath(UIType.UIDemon);
                var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
                UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIDemon, gameObject);
                ui.AddComponent<UIDemonComponent>();
                return ui;
            }

            public override void OnRemove(UIComponent uiComponent)
            {
                var path = ABPathHelper.GetUGUIPath(UIType.UIDemon);
                ResourcesComponent.Instance.UnLoadAsset(path);
            }
        }
    }
}