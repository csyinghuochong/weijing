using System.Collections.Generic;
using System.Linq;

namespace ET
{
#if SERVER
    [ConsoleHandler(ConsoleMode.Level)]

    public class LevelConsoleHandler : IConsoleHandler
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
                    //level 1
                    await ConsoleHelper.LevelConsoleHandler(content);
                    break;
            }

            await ETTask.CompletedTask;

        }
    }
#endif
}
