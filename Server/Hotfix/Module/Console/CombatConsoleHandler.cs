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
                    break;
                default:
                    string[] ss = content.Split(" ");
                    string zoneid = ss[1];
#if SERVER
                    List<int> zoneList = ServerMessageHelper.GetAllZone();
                    for (int i = 0; i < zoneList.Count; i++)
                    {
                        long rankServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Rank").InstanceId;
                        await ServerMessageHelper.SendServerMessage(rankServerId, NoticeType.RankRefresh, String.Empty);
                        await TimerComponent.Instance.WaitAsync(10000);
                    }
#endif
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
