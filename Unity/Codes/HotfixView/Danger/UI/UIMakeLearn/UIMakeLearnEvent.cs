using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIMakeLearn)]
    public class UIMakeLearnEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMakeLearn);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIMakeLearn, gameObject);
            ui.AddComponent<UIMakeLearnComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIMakeLearn);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }

}
