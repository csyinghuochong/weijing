using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIJiaYuan)]
    public class UIJiaYuanEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuan);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIJiaYuan, gameObject);

            ui.AddComponent<UIJiaYuanComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIJiaYuan);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
