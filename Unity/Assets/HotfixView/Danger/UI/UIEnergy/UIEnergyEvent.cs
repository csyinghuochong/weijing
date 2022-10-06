using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIEnergy)]
    public class UIEnergyEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEnergy);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIEnergy, gameObject);
            ui.AddComponent<UIEnergyComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIEnergy);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
