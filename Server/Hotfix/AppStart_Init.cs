using AlibabaCloud.SDK.Sample;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MsgCryptTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ET
{
    public class AppStart_Init: AEvent<EventType.AppStart>
    {
        protected override void Run(EventType.AppStart args)
        {
            RunAsync(args).Coroutine();
        }

        private async ETTask TestHttp()
        {
            await TimerComponent.Instance.WaitAsync(10 * 1000);
            //string taphost = ComHelp.IsInnerNet() ? "127.0.0.1" : "39.96.194.143";
            //int tapport = ComHelp.IsInnerNet() ? ComHelp.TapHttpIneer : ComHelp.TapHttpOuter;
            //string url = $"http://{taphost}:{tapport}/wjtiktokPhoneNumberLogin";
            //Dictionary<string, string> data = new Dictionary<string, string>();
            //data.Add("app_id", "554726");
            //data.Add("auth_code", "auth_code");
            //HttpHelper.OnWebRequestPostBody(url, null,  data).Coroutine();

            //游戏服务器生成对应角色的验证码
            //发送验证码到公众号，推送到游戏服务器，游戏服务器验证验证码 并返回消息。

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("grant_type", "client_credential");
            keyValuePairs.Add("appid", ConfigData.sAppID);
            keyValuePairs.Add("secret", ConfigData.sAppSecret);
            string requestBody =  await  WXSample.OnGetAccessToken("https://api.weixin.qq.com/cgi-bin/token", keyValuePairs);

            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);

            keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("access_token", obj["access_token"].ToString());
            await WXSample.OnGetAccessToken("https://api.weixin.qq.com/cgi-bin/get_api_domain_ip", keyValuePairs);

            keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("access_token", obj["access_token"].ToString());
            await WXSample.OnGetAccessToken("https://api.weixin.qq.com/cgi-bin/getcallbackip", keyValuePairs);


            WXSample.Main();
        }

        private async ETTask RunAsync(EventType.AppStart args)
        {
            Game.Scene.AddComponent<ConfigComponent>();
            Game.Scene.AddComponent<TimerComponent>();

            TimeInfo.Instance.TimeZone = 8;
            await ConfigComponent.Instance.LoadAsync();

            StartProcessConfig processConfig = StartProcessConfigCategory.Instance.Get(Game.Options.Process);
            

            Game.Scene.AddComponent<OpcodeTypeComponent>();
            Game.Scene.AddComponent<MessageDispatcherComponent>();
            Game.Scene.AddComponent<SessionStreamDispatcher>();
            Game.Scene.AddComponent<CoroutineLockComponent>();
            // 发送普通actor消息
            Game.Scene.AddComponent<ActorMessageSenderComponent>();
            // 发送location actor消息
            Game.Scene.AddComponent<ActorLocationSenderComponent>();
            // 访问location server的组件
            Game.Scene.AddComponent<LocationProxyComponent>();
            Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
            // 数值订阅组件
            Game.Scene.AddComponent<NumericWatcherComponent>();
            
            Game.Scene.AddComponent<NetThreadComponent>();
            
            Game.Scene.AddComponent<NavmeshComponent, Func<string, byte[]>>(RecastFileReader.Read);

            ConfigData.OldNavMesh =  !Game.Options.StartConfig.Contains("Google");
            Game.Scene.AddComponent<RecastPathComponent>();

            //添加db数据库的链接
            //"mongodb://127.0.0.1:27017/", "ET"
            Game.Scene.AddComponent<DBComponent>();
            Game.Scene.AddComponent<AIDispatcherComponent>();
            Game.Scene.AddComponent<SkillDispatcherComponent>();
            Game.Scene.AddComponent<BuffDispatcherComponent>();
            Game.Scene.AddComponent<ShouJiChapterInfoComponent>();

            long unitid = DBHelper.DebugUnitId;
            // int n = (int)((unitid / 99) % 4);
            Log.Console($"unit.zone1107: {UnitIdStruct.GetUnitZone(unitid)}");
            Console.WriteLine($"unit.zone1107: {UnitIdStruct.GetUnitZone(unitid)}");
            Console.WriteLine($"Game.Options.StartConfig:  {Game.Options.StartConfig}");
            ServerHelper.InitServerList(Game.Options.StartConfig);
            Console.WriteLine($"ServerItems.Count:  {ServerHelper.GetServerList().Count}");

            switch (Game.Options.AppType)
            {
                case AppType.Server:
                {
                        if (!string.IsNullOrEmpty(Game.Options.Parameters))
                        {
                            DyncCSHelper.Test_2(Game.Options.Parameters);
                        }
                        Game.Scene.AddComponent<NetInnerComponent, IPEndPoint, int>(processConfig.InnerIPPort, SessionStreamDispatcherType.SessionStreamDispatcherServerInner);

                        var processScenes = StartSceneConfigCategory.Instance.GetByProcess(Game.Options.Process);
                        foreach (StartSceneConfig startConfig in processScenes)
                        {
                            SceneFactory.Create(Game.Scene, startConfig.Id, startConfig.InstanceId, startConfig.Zone, startConfig.Name,
                               startConfig.Type, startConfig);
                        }

                        //TestHttp().Coroutine();
                        break;
                }
                case AppType.MergeZone:
                    //Parameters=31_30   31区合并到30区
                    string[] zones =  Game.Options.Parameters.Split('_');
                    int oldzone = int.Parse(zones[0]);
                    int newzone = int.Parse(zones[1]);
                    //await  MergeZoneHelper.MergeZone(oldzone, newzone);
                    Game.EventSystem.Publish(new EventType.MergeZone(){  oldzone = oldzone, newzone = newzone });
                    break;
                case AppType.UpdateDB:
                    List<int> mergezones = ServerMessageHelper.GetAllZone();
                    for (int i = 0; i < mergezones.Count; i++)
                    {
                        var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                        Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
                    }

                    for (int zone = 0; zone < mergezones.Count; zone++)
                    {
                       
                        try
                        {
                            int[] number_list = new int[4];
                            int pyzone = StartZoneConfigCategory.Instance.Get(mergezones[zone]).PhysicZone;

                            List<SkillSetComponent> skillsetComponentList = await Game.Scene.GetComponent<DBComponent>().Query<SkillSetComponent>(pyzone, d => d.Id > 0);

                            Console.WriteLine($"UpdateDB1  :{pyzone}  {skillsetComponentList.Count}");


                            for (int userinfo = 0; userinfo < skillsetComponentList.Count; userinfo++)
                            {
                                SkillSetComponent skillSetComponent = skillsetComponentList[userinfo];

                                List<int> equiptianfuids = new List<int>();
                                List<BagComponent> bagComponentList = await Game.Scene.GetComponent<DBComponent>().Query<BagComponent>(pyzone, d => d.Id == skillSetComponent.Id);
                                if (bagComponentList.Count > 0)
                                {
                                    equiptianfuids.AddRange(bagComponentList[0].GetEquipTianFuIds());
                                    equiptianfuids.AddRange(skillSetComponent.TianFuAddition);
                                }

                                //0没有天赋技能  1技能找不到天赋id 2自身丢失天赋 3成功找到天赋
                                int errorcode = skillSetComponent.CheckSkillToTalent(equiptianfuids);
                                number_list[errorcode]++;
                                if (errorcode == 2 ||  errorcode == 3)
                                {
                                    await Game.Scene.GetComponent<DBComponent>().Save(pyzone, skillSetComponent);
                                }
                            }

                            Console.WriteLine($"UpdateDB2  :{mergezones[zone]}  {number_list[0]}  {number_list[1]}  {number_list[2]}   {number_list[3]}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());       
                        }
                    }

                    Console.WriteLine($"UpdateDB  :End");
                    break;
                case AppType.DeleteZone:
                    int delezone = int.Parse(Game.Options.Parameters);
                    await DeleteZoneHelper.DeletionZone(delezone);
                    Log.Warning("DeleteZone完成！");
                    break;
                case AppType.Watcher:
                {
                    StartMachineConfig startMachineConfig = WatcherHelper.GetThisMachineConfig();
                    WatcherComponent watcherComponent = Game.Scene.AddComponent<WatcherComponent>();
                    watcherComponent.Start(Game.Options.CreateScenes);
                    Game.Scene.AddComponent<NetInnerComponent, IPEndPoint, int>(NetworkHelper.ToIPEndPoint($"{startMachineConfig.InnerIP}:{startMachineConfig.WatcherPort}"), SessionStreamDispatcherType.SessionStreamDispatcherServerInner);
                    break;
                }
                case AppType.GameTool:
                    break;
            }

            if (Game.Options.Console == 1)
            {
                Game.Scene.AddComponent<ConsoleComponent>();
            }
        }
    }
}