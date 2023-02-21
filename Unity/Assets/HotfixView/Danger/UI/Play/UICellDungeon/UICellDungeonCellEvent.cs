using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UICellDungeonCell)]
    public class UICellDungeonCellEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonCell);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UICellDungeonCell, gameObject);
            ui.AddComponent<UICellDungeonCellComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICellDungeonCell);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }
    }
}
