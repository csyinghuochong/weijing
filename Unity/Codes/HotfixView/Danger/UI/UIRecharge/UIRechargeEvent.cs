using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIRecharge)]
    public class UIRechargeEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRecharge);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIRecharge, gameObject);
            ui.AddComponent<UIRechargeComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRecharge);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
