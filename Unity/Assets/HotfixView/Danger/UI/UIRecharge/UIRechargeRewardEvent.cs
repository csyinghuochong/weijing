using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIRechargeReward)]
    public class UIRechargeRewardEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRechargeReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIRechargeReward, gameObject);
            ui.AddComponent<UIRechargeRewardComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIRechargeReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
