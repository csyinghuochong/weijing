using UnityEngine;

namespace ET
{
    [UIEvent(UIType.UISettingSkill)]
    public class UISettingSkillEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISettingSkill);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISettingSkill, gameObject);
            ui.AddComponent<UISettingSkillComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISettingSkill);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
}