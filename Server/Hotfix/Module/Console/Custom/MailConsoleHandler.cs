using System;
using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ConsoleHandler(ConsoleMode.Mail)]
    public class MailConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.Mail:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have mail zone userid items title");
                    break;
                default:
                    int errorCode = await  ConsoleHelper.MailConsoleHandler(content);
                    Log.Console($"errorCode:  {errorCode}");
                    break;
            }
            
            await ETTask.CompletedTask;
        }
    }
}
