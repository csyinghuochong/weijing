using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIFenXiang)]
    public class UIFenXiangEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIFenXiang);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIFenXiang, gameObject);
            ui.AddComponent<UIFenXiangComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIFenXiang);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }

    }
}
