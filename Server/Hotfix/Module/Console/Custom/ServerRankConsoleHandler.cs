using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

#if SERVER
    [ConsoleHandler(ConsoleMode.ServerRank)]
    public class ServerRankConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ServerRank:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have serverRank zone username");
                    break;

                default:
                    //chaxun 1 ""
                    await  ConsoleHelper.ServerRankConsoleHandler(content);
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
#endif
}
