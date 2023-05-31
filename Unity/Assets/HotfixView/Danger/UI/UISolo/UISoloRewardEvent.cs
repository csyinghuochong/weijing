using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    /*
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

            ui.AddComponent<UISoloComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
            var path = ABPathHelper.GetUGUIPath(UIType.UISoloReward);
            ResourcesComponent.Instance.UnLoadAsset(path);
        }
    }
    */
    [Event]
    public class UISoloRewardEvent : AEventClass<EventType.UISoloRewardCreate>
    {
        protected override async void Run(object cls)
        {
            //获取事件对应传参
            EventType.UISoloRewardCreate args = cls as EventType.UISoloRewardCreate;

            /*
                var path = ABPathHelper.GetUGUIPath(UIType.UISoloReward);
                //await ETTask.CompletedTask;
                var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
                //UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UISoloReward, gameObject);
                
                //UIComponent.Instance.AddChild
            */

            //UIHelper.GetUI(args.ZoneScene, UIType.UIPetMain).GetComponent<UIPetMainComponent>().OnFubenResult(args.m2C_FubenSettlement);

            UI uisoloReward = UIHelper.GetUI(args.ZoneScene, UIType.UISoloReward);
            if (uisoloReward == null)
            {
                UI ui = await UIHelper.Create(args.ZoneScene, UIType.UISoloReward);
                ui.AddComponent<UISoloRewardComponent>();
            }


                //return ui;
            }
    }
}
