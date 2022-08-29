using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIOccTwo)]
    public class UIOccTwoEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIOccTwo);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIOccTwo, gameObject);

            ui.AddComponent<UIOccTwoComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIOccTwo);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
