using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIPetQuickFight)]
    public class UIPetQuickFightEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetQuickFight);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetQuickFight, gameObject);
            ui.AddComponent<UIPetQuickFightComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetQuickFight);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}