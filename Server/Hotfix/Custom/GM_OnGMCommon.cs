using System;
using System.Collections.Generic;


namespace ET
{
    public class GM_OnGMCommon : AEvent<EventType.GMCommonRequest>
    {
        protected override async void Run(EventType.GMCommonRequest request)
        {
            await ETTask.CompletedTask;
            string[] infoList = request.Context.Split(" ");

            if (infoList[0] == ConsoleMode.ChaXun)
            {
                await ConsoleHelper.ChaXunConsoleHandler(request.Context);
            }
            if (infoList[0] == ConsoleMode.Combat)
            {
                await ConsoleHelper.CombatConsoleHandler(request.Context);
            }
            if (infoList[0] == ConsoleMode.KickOut)
            {
                ConsoleHelper.KickOutConsoleHandler(request.Context);
            }
            if (infoList[0] == ConsoleMode.Level)
            {
                ConsoleHelper.LevelConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == ConsoleMode.Mail)
            {
                ConsoleHelper.MailConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "mail2")
            {
                ConsoleHelper.Mail2ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == ConsoleMode.Rechage)
            {
#if SERVER
                string[] mailInfo = request.Context.Split(" ");
                if (mailInfo[0] != "rechage" && mailInfo.Length < 4)
                {
                    return;
                }
                RechargeHelp.OnPaySucessToGate(int.Parse(mailInfo[1]), long.Parse(mailInfo[2]), int.Parse(mailInfo[3]), "补偿", 0).Coroutine();
#endif
            }
            if (infoList[0] == ConsoleMode.ReloadDll)
            {
                ConsoleHelper.ReloadDllConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == ConsoleMode.ServerRank)
            {
                ConsoleHelper.ServerRankConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == ConsoleMode.StopServer)
            {
                ConsoleHelper.StopServerConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gold" || infoList[0] == "diamond")
            {
                ConsoleHelper.GoldConsoleHandler(request.Context, infoList[0]).Coroutine();
            }
            if (infoList[0] == "shenshou" )
            {
                ConsoleHelper.ShenshouConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "black")
            {
                ConsoleHelper.BlackConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "black2")
            {
                ConsoleHelper.Black2_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "paimai")
            {
                ConsoleHelper.PaiMaiConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "paimai2")
            {
                ConsoleHelper.PaiMai2_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi")
            {
                ConsoleHelper.GongZuoShi1_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi2")
            {
                ConsoleHelper.GongZuoShi2_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi3")
            {
                ConsoleHelper.GongZuoshi3_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi4")
            {
                ConsoleHelper.GongZuoshi4_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi5")
            {
                ConsoleHelper.GongZuoshi5_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi6")
            {
                ConsoleHelper.GongZuoshi6_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi7")
            {
                ConsoleHelper.GongZuoshi7_ConsoleHandler(request.Context).Coroutine();  //身份证 封号
            }
            if (infoList[0] == "gongzuoshi8")
            {
                ConsoleHelper.GongZuoshi8_ConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "gongzuoshi9")
            {
                ConsoleHelper.GongZuoshi9_ConsoleHandler(request.Context).Coroutine();   //ip 封号
            }
            if (infoList[0] == ConsoleMode.RechargeChaXun)
            {
                ConsoleHelper.RechargeChaXunConsoleHandler(request.Context).Coroutine();        
            }
            if (infoList[0] == "jinyan")
            {
                ConsoleHelper.JinYanConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "clearchat")
            {
                ConsoleHelper.ClearChatConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "attribute")
            {
                ConsoleHelper.AttributeConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "archive")
            {
                ConsoleHelper.ArchiveConsoleHandler(request.Context).Coroutine();
            }
            if (infoList[0] == "savedb")
            {
                //ArchiveHelper.ExecuteBatchFileOld().Coroutine();
                if (ComHelp.IsInnerNet())
                {
                    return;
                }
                ArchiveHelper.ExecuteBatchFileNew().Coroutine();    
            }
        }
    }
}
