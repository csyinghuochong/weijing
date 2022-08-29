using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UIUnionApplyList)]
    public class UIUnionApplyListEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionApplyList);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIUnionApplyList, gameObject);
            ui.AddComponent<UIUnionApplyListComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIUnionApplyList);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
