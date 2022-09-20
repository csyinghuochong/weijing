using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRoleXiLianTen)]
    public class UIRoleXiLianTenEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLianTen);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleXiLianTen, gameObject);
            ui.AddComponent<UIRoleXiLianTenComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLianTen);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }
}
