using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIHorseNotice)]
    public class UIHorseNoticeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIHorseNotice);
            var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIHorseNotice, gameObject);

            ui.AddComponent<UIHorseNoticeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIHorseNotice);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
