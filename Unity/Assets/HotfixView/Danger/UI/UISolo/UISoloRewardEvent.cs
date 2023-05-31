using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    
    [UIEvent(UIType.UISoloReward)]
    public class UISoloRewardEvent : AUIEvent
    {
        
        public override async ETTask<UI> OnCreate(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISoloReward);
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISoloReward, gameObject);
            ui.AddComponent<UISoloRewardComponent>();

            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISoloReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }

    [Event]
    public class Solo_SoloReward : AEventClass<EventType.UISoloReward>
    {
        protected override async void Run(object cls)
        {
            //获取事件对应传参
            EventType.UISoloReward args = cls as EventType.UISoloReward;

            UI uisoloReward = UIHelper.GetUI(args.ZoneScene, UIType.UISoloReward);
            if (uisoloReward == null)
            {
                UI ui = await UIHelper.Create(args.ZoneScene, UIType.UISoloReward);

                ui.GetComponent<UISoloRewardComponent>().OnInit(args.m2C_SoloDungeon.SoloResult,args.m2C_SoloDungeon.RewardItem);
            }
        }
    }
}
