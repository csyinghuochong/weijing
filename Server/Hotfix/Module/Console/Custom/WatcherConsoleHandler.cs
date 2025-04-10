using System.Collections.Generic;
using System.Linq;

namespace ET
{

#if SERVER

    [ConsoleHandler(ConsoleMode.Watcher)]
    public class WatcherConsoleHandler : IConsoleHandler
    {

        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.Watcher:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must zone");
                    break;
                default:
                    string[] ss = content.Split(" ");
                    if (ss.Length < 2)
                    {
                        Log.Console($"C must zone");
                        return;
                    }

                    Game.Scene.GetComponent<WatcherComponent>().Stop();
                    break;
            }
            await ETTask.CompletedTask;
        }
    }

#endif
}
