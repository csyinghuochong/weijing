using UnityEngine;


namespace ET
{
    [UIEvent(UIType.UICountryHuoDongJieShao)]
    public class UICountryHuoDongJieShaoEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICountryHuoDongJieShao);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UICountryHuoDongJieShao, gameObject);
            ui.AddComponent<UICountryHuoDongJieShaoComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UICountryHuoDongJieShao);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }

}

