using System;

namespace ET
{
    [ActorMessageHandler]
    public class G2A_ReloadHandler : AMActorRpcHandler<Scene, G2A_Reload, A2G_Reload>
    {
        protected override async ETTask Run(Scene session, G2A_Reload request, A2G_Reload response, Action reply)
        {
            Log.Console("C2M_Reload_b: " + session.Name);
            Log.Warning("C2M_Reload_b: " + session.Name);
            Log.Warning("C2M_Reload_b: 测试热重载！");
            OpcodeHelper.OneTotalNumber = 20000;
            OpcodeHelper.OneTotalLength = 20000000;

            Log.Warning("C2M_Reload_Remove: " + ConfigLoader.RemovePlayer);
            Log.Warning("C2M_Reload_NoRecovery: " + MongoHelper.NoRecovery);

            DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
#if SERVER
            MessageHelper.LogStatus = dateTime.Hour >= 21 && dateTime.Hour <= 23;
            OpcodeHelper.ShowMessage = dateTime.Hour >= 21 && dateTime.Hour <= 23;
            Log.Warning("C2M_Reload_LogStatus: " + MessageHelper.LogStatus);
#endif
            switch (request.LoadType)
            {
                case 0://全部
                    //Game.EventSystem.Add(typeof(Game).Assembly);
                    Game.EventSystem.Add(DllHelper.GetHotfixAssembly());
                    Game.EventSystem.Load();

                    ConfigComponent.Instance.LoadAsync().Coroutine();
                    break;
                case 1: //代码
                    Game.EventSystem.Add(DllHelper.GetHotfixAssembly());
                    Game.EventSystem.Load();
                    break;
                case 2: //配置表
                    if (string.IsNullOrEmpty(request.LoadValue))
                    {
                        ConfigComponent.Instance.LoadAsync().Coroutine();
                    }
                    else
                    {
                        string configName = request.LoadValue;
                        string category = $"{configName}Category";
                        Type type = Game.EventSystem.GetType($"ET.{category}");
                        if (type == null)
                        {
                            Log.Warning($"reload config but not find {category}");
                            return;
                        }
                        ConfigComponent.Instance.LoadOneConfig(type);
                        Log.Warning($"reload config {configName} finish!");
                    }
                    break;
                case 3:
#if SERVER
                    if (string.IsNullOrEmpty(request.LoadValue))
                    {
                        Game.Scene.GetComponent<RecastPathComponent>().OnLoad();
                    }
                    else
                    {
                        Game.Scene.GetComponent<RecastPathComponent>().OnLoadSingle(int.Parse(request.LoadValue));
                    }
#endif
                    break;
            }

            Log.Warning("EventSystem.Instance.ToString: 1");
            Log.Warning("EventSystem:   " + EventSystem.Instance.ToString());
            Log.Warning("TimerComponent:" + TimerComponent.Instance.ToString());
            Log.Warning("ObjectPool:    " + ObjectPool.Instance.ToString());
            Log.Warning("MonoPool:      " + MonoPool.Instance.ToString());
            Log.Warning("EventSystem.Instance.ToString: 2");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
