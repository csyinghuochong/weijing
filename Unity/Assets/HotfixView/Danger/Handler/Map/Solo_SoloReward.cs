using ET;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ET
{
    [Event]
    public class UISoloQuit : AEventClass<EventType.UISoloQuit>
    {
        protected override void Run(object cls)
        {
            //获取事件对应传参
            EventType.UISoloQuit args = cls as EventType.UISoloQuit;

            //移除对应界面
            UIHelper.Remove(args.ZoneScene, UIType.UISolo);
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

                ui.GetComponent<UISoloRewardComponent>().OnInit(args.m2C_SoloDungeon.SoloResult, args.m2C_SoloDungeon.RewardItem);
            }
        }
    }
}