using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIBuChang)]
    public class UIBuChangEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBuChang);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIBuChang, gameObject);

            ui.AddComponent<UIBuChangComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIBuChang);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
