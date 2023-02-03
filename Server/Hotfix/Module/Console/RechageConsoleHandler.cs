using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ConsoleHandler(ConsoleMode.Rechage)]
    public class RechageConsoleHandler : IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.Rechage:
                    contex.Parent.RemoveComponent<ModeContex>();
                    Log.Console($"C must have mail zone userid items title");
                    break;
                default:
                    //recharge 区服(0所有区服  1指定区服)  玩家ID(0所有玩家)  充值数量
                    //recharge  1 11111 6
                    string[] mailInfo = content.Split(" ");
                    if (mailInfo[0] != "mail" && mailInfo.Length < 4)
                    {
                        return;
                    }

#if SERVER
                    Log.Info($"充值：邮件发送完成{long.Parse(mailInfo[2])}");
                    RechargeHelp.OnPaySucessToGate(int.Parse(mailInfo[1]), long.Parse(mailInfo[2]), int.Parse(mailInfo[3]), "补偿").Coroutine();
#endif
                    Log.Info("邮件发送完成！");
                    break;
            }

            await ETTask.CompletedTask;
        }
    }
}
