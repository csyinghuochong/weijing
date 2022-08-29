using System;
using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISelectServer)]
    public class UIServerListEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectServer);
            await ETTask.CompletedTask;
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISelectServer, gameObject);
            ui.AddComponent<UISelectServerComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISelectServer);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}