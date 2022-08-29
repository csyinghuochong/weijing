using System;
using UnityEngine;

namespace ET
{

    [UIEvent(UIType.UISkillTips)]
    public class UISkillTipsEvent : AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISkillTips);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>( UIType.UISkillTips, gameObject);
            ui.AddComponent<UISkillTipsComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISkillTips);
            ResourcesComponent.Instance.UnLoadAsset(path);

        }

    }
}
