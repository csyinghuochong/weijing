using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UITrialDungeon)]
    public class UITrialDungeonEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITrialDungeon);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITrialDungeon, gameObject);
            ui.AddComponent<UITrialDungeonComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITrialDungeon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
