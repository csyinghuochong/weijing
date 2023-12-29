using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRoleXiLianExplain)]
    public class UIXiLianExplainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLianExplain);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleXiLianExplain, gameObject);
            ui.AddComponent<UIRoleXiLianExplainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLianExplain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}