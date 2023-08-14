using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITowerOfSealJump)]
    public class UITowerOfSealJumpEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSealJump);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerOfSealJump, gameObject);
            ui.AddComponent<UITowerOfSealJumpComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerOfSealJump);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}