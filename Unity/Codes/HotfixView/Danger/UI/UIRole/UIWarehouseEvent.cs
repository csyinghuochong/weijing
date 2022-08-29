using UnityEngine;


namespace ET
{

    [UIEvent(UIType.UIWarehouse)]
    public class UIWarehouseEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWarehouse);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UIWarehouse, gameObject);

            ui.AddComponent<UIWarehouseComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UIWarehouse);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

}
