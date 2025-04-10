using System.Collections.Generic;

namespace ET
{

#if SERVER
    [ConsoleHandler(ConsoleMode.ChaXun)]
    public class ChaXunConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ChaXun:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have chaxun zone username");
                    break;
                default:
                    await ConsoleHelper.ChaXunConsoleHandler(content);
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
#endif
}
