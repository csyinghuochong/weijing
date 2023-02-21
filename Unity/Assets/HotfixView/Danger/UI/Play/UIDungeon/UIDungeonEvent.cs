using System;
using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIDungeon)]
    public class UIDungeonEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDungeon);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIDungeon, gameObject);

            ui.AddComponent<UIDungeonComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIDungeon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
