using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIRandomTowerResult)]
    public class UIRandomTowerResultEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRandomTowerResult);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRandomTowerResult, gameObject);

            ui.AddComponent<UIRandomTowerResultComponent>();
            return ui;
        }


        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRandomTowerResult);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
