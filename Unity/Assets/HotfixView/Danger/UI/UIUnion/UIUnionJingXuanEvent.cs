using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UIUnionJingXuan)]
    public class UIUnionJingXuanEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionJingXuan);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionJingXuan, gameObject);
            ui.AddComponent<UIUnionJingXuanComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionJingXuan);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}