using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIBattleRecruit)]
    public class UIBattletRecruitEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBattleRecruit);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIBattleRecruit, gameObject);
            ui.AddComponent<UIBattleRecruitComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBattleRecruit);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}