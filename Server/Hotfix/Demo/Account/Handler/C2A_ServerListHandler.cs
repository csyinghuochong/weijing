using System;
using System.Collections.Generic;

namespace ET
{
    //游戏服务器处理
    [MessageHandler]
    public class C2A_ServerListHandler : AMRpcHandler<C2A_ServerList, A2C_ServerList>
    {
        protected override async ETTask Run(Session session, C2A_ServerList request, A2C_ServerList response, Action reply)
        {
            try
            {
                if (session.GetComponent<SessionLockingComponent>() != null)
                {
                    response.Error = ErrorCode.ERR_RequestRepeatedly;
                    reply();
                    session.Disconnect().Coroutine();
                    return;
                }

                using (session.AddComponent<SessionLockingComponent>())
                {
                    using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.GetServerList, 0))
                    {
                        long serverTime = TimeHelper.ServerNow();
                        List<ServerItem> serverItems = ServerHelper.GetServerList();

                        //Console.WriteLine($"C2A_ServerList: ServerItems {ServerHelper.GetServerList().Count}");

                        response.ServerItems.Clear();
                        for (int i = 0; i < serverItems.Count; i++)
                        {
                            //128服只有主播账号才显示。。
                            if ( ComHelp.IsZhuBoZone(serverItems[i].ServerId) && !GMHelp.ZhuBoURBossAccount.Contains(request.Account))
                            {
                                continue;
                            }

                            if (serverItems[i].Show != 0 && serverItems[i].ServerOpenTime <= serverTime)
                            {
                                response.ServerItems.Add(serverItems[i]);
                            }
                        }
                        response.Message = session.DomainScene().GetComponent<AccountCenterComponent>().TianQiValue.ToString();
                        string[] stringxxx = LogHelper.GetNoticeNew().Split('@');

                        long timeNow = TimeHelper.ServerNow();
                        long timeColse = 0;
                        if (stringxxx.Length == 2)
                        {
                            response.NoticeVersion = stringxxx[0];
                            response.NoticeText = stringxxx[1];
                        }
                        if (stringxxx.Length == 3)
                        {
                            response.NoticeVersion = stringxxx[0];
                            timeColse = long.Parse(stringxxx[1]);
                            response.NoticeText = stringxxx[2];
                        }
                        
                        string[] stringxxx_EN = LogHelper.GetNoticeNew_EN().Split('@');
                        if (stringxxx_EN.Length == 2)
                        {
                            response.NoticeVersion_EN = stringxxx_EN[0];
                            response.NoticeText_EN = stringxxx_EN[1];
                        }
                        if (stringxxx_EN.Length == 3)
                        {
                            response.NoticeVersion_EN = stringxxx_EN[0];
                            timeColse = long.Parse(stringxxx_EN[1]);
                            response.NoticeText_EN = stringxxx_EN[2];
                        }

                        if (timeColse > 0 && timeNow > timeColse + TimeHelper.OneDay * 3)
                        {
                            response.NoticeText = string.Empty;
                            response.NoticeText_EN = string.Empty;
                        }


                        int accountcenter = StartSceneConfigCategory.Instance.AccountCenterConfig.OuterPort;
                        string outeIp = StartMachineConfigCategory.Instance.Get(1).OuterIP;
                        response.AccountCenterIp = $"{outeIp}:{accountcenter}";

                        if (StartSceneConfigCategory.Instance.Gates.ContainsKey(5))
                        {
                            StartSceneConfig realmStartSceneConfig = RealmGateAddressHelper.GetRealm(5);
                            string real = realmStartSceneConfig.OuterIPPort.ToString();

                            StartSceneConfig gateconfig = RealmGateAddressHelper.GetGate(5, 1);
                            string gate = gateconfig.OuterIPPort.ToString();
                            response.RealAndGate = real + "_" + gate;
                        }

                        response.SmsVerifyType = 0; //0 mob  1 aliyun
                        reply();
                        await ETTask.CompletedTask;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}
