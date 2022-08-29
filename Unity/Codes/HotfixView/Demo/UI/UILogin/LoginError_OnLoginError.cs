using UnityEngine;

namespace ET
{

    [Event]
    public class LoginError_OnLoginError : AEventClass<EventType.LoginError>
    {
        protected override void Run(object cls)
        {
            RunAsync(cls as EventType.LoginError).Coroutine();
        }

        private async ETTask RunAsync(EventType.LoginError args)
        {
            if (args.ErrorCore == ErrorCore.ERR_FangChengMi_Tip1)
            {
                Log.ILog.Info("args.Value = " + args.Value);
                string content = ErrorHelp.Instance.ErrorHintList[args.ErrorCore];
                content = content.Replace("{0}", args.Value);
                PopupTipHelp.OpenPopupTip_3(args.ZoneScene, "防沉迷提示",
                    content,
                    () => { }
                    ).Coroutine();
            }
            else if (args.ErrorCore == ErrorCore.ERR_FangChengMi_Tip6)
            {
                string content = ErrorHelp.Instance.ErrorHintList[args.ErrorCore];
                PopupTipHelp.OpenPopupTip_3(args.ZoneScene, "防沉迷提示",
                    content,
                    () => { }
                    ).Coroutine();
            }
            else if (args.ErrorCore == ErrorCore.ERR_FangChengMi_Tip7)
            {
                string content = ErrorHelp.Instance.ErrorHintList[args.ErrorCore];
                PopupTipHelp.OpenPopupTip_3(args.ZoneScene, "防沉迷提示",
                    content,
                    () => { }
                    ).Coroutine();
            }
            else if (args.ErrorCore == ErrorCore.ERR_EnterQueue)
            {
                UI ui = await UIHelper.Create(args.ZoneScene, UIType.UIQueue);
                ui.GetComponent<UIQueueComponent>().ShowQueueNumber(args.Value);
            }
            else if (args.ErrorCore == ErrorCore.ERR_NotRealName)
            {
                UI ui = await UIHelper.Create(args.ZoneScene, UIType.UIRealName);
                ui.GetComponent<UIRealNameComponent>().AccountId = args.AccountId;
            }
        }
    }
}
