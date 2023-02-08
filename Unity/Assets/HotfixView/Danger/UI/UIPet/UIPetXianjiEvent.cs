using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetXianji)]
    public class UIPetXianjiEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetXianji);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetXianji, gameObject);
            ui.AddComponent<UIPetXianjiComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetXianji);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
