using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIRoleXiLianNumReward)]
    public class UIRoleXiLianNumRewardEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLianNumReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRoleXiLianNumReward, gameObject);
            ui.AddComponent<UIRoleXiLianNumRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRoleXiLianNumReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}