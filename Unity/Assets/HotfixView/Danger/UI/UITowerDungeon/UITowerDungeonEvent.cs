using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITowerDungeon)]
    public class UITowerDungeonEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerDungeon);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITowerDungeon, gameObject);
            ui.AddComponent<UITowerDungeonComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITowerDungeon);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
