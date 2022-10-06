using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIChouKa)]
    public class UIChouKaEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKa);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIChouKa, gameObject);
            ui.AddComponent<UIChouKaComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIChouKa);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
