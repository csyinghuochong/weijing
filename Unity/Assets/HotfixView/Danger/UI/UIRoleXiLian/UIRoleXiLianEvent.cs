using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRoleXiLian)]
    public class UIRoleXiLianEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLian);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleXiLian, gameObject);
            ui.AddComponent<UIRoleXiLianComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLian);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }

    }
}
