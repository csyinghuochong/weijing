using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIAppraisalSelect)]
    public class UIAppraisalSelectEvent : AUIEvent
    {

        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIAppraisalSelect);
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UIAppraisalSelect, gameObject);

            ui.AddComponent<UIAppraisalSelectComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIAppraisalSelect);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}
