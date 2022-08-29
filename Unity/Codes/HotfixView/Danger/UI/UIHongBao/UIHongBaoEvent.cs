using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIHongBao)]
    public class UIHongBaoEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIHongBao);
            var bundleGameObject =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIHongBao, gameObject);

            ui.AddComponent<UIHongBaoComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIHongBao);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
