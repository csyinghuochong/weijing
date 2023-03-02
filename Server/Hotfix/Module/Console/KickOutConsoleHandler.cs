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
                    //chaxun 1 ""
                    string[] chaxunInfo = content.Split(" ");
                    if (chaxunInfo[0] != "chaxun")
                    {
                        return;
                    }

                    int zone = int.Parse(chaxunInfo[1]);
                    int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
                    long unitid = int.Parse(chaxunInfo[2]);

                    DisconnectHelper.KickPlayer(pyzone, unitid).Coroutine();
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
#endif
}
