using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ConsoleHandler(ConsoleMode.StopServer)]
    public class StopServerConsoleHandler : IConsoleHandler
    {

        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.StopServer:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must zone");
                    Log.Warning($"C must zone");
                    break;
                default:
                    await ConsoleHelper.StopServerConsoleHandler(content);
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
