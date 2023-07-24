using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITowerOfSealMain)]
    public class UITowerOfSealMainEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSealMain);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerOfSealMain, gameObject);
            ui.AddComponent<UITowerOfSealMainComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSealMain);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}