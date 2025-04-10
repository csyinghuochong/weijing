using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

#if SERVER
    [ConsoleHandler(ConsoleMode.KickOut)]
    public class KickOutConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.KickOut:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have chaxun zone unitid");
                    break;
                default:
                    ConsoleHelper.KickOutConsoleHandler(content);
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
#endif
}
