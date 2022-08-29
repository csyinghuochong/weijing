using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UICommonReward)]
    public class UICommonRewardEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICommonReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UICommonReward, gameObject);
            ui.AddComponent<UICommonRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICommonReward);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }

    }
}
