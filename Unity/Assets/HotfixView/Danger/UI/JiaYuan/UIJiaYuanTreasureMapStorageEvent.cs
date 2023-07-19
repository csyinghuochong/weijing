using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIJiaYuanTreasureMapStorage)]
    public class UIJiaYuanTreasureMapStorageEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanTreasureMapStorage);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuanTreasureMapStorage, gameObject);
            ui.AddComponent<UIJiaYuanTreasureMapStorageComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuanTreasureMapStorage);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}