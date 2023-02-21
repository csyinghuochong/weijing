using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIBattle)]
    public class UIBattleEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBattle);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIBattle, gameObject);
            ui.AddComponent<UIBattleComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBattle);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
