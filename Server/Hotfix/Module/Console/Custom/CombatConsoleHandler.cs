using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ConsoleHandler(ConsoleMode.Combat)]
    public class CombatConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.Combat:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have zone id");
                    Log.Warning($"C must have zone id");
                    break;
                default:
                    await ConsoleHelper.CombatConsoleHandler(content);
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
