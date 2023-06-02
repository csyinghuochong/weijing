using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetCangKu)]
    public class UIPetCangKuEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetCangKu);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetCangKu, gameObject);
            ui.AddComponent<UIPetCangKuComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetCangKu);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}