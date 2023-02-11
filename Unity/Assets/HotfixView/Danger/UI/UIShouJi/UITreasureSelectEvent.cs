using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UITreasureSelect)]
    public class UITreasureSelectEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITreasureSelect);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UITreasureSelect, gameObject);
            ui.AddComponent<UITreasureSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UITreasureSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
