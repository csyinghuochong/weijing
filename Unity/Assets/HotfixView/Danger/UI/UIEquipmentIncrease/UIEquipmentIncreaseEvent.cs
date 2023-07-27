using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIEquipmentIncrease)]
    public class UIEquipmentIncreaseEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEquipmentIncrease);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIEquipmentIncrease, gameObject);
            ui.AddComponent<UIEquipmentIncreaseComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEquipmentIncrease);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}