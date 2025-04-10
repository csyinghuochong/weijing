using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ConsoleHandler(ConsoleMode.ReloadDll)]
    public class ReloadDllConsoleHandler: IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ReloadDll:
                    break;
                default:
                    contex.Parent.RemoveComponent<ModeContex>();
                    await ConsoleHelper.ReloadDllConsoleHandler(content);
                    break;
            }
            
            await ETTask.CompletedTask;
        }
    }
}