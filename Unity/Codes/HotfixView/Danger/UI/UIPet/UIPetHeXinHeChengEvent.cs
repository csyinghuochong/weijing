using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIPetHeXinHeCheng)]
    public class UIPetHeXinHeChengEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinHeCheng);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIPetHeXinHeCheng, gameObject);
            ui.AddComponent<UIPetHeXinHeChengComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIPetHeXinHeCheng);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
