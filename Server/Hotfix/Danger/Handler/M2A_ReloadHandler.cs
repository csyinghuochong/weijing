using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_ReloadHandler : AMActorRpcHandler<Scene, M2A_Reload, A2M_Reload>
    {
        protected override async ETTask Run(Scene session, M2A_Reload request, A2M_Reload response, Action reply)
        {
            Log.Info("C2M_Reload_b: " + session.Name);

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
                            Log.Console($"reload config but not find {category}");
                            return;
                        }
                        ConfigComponent.Instance.LoadOneConfig(type);
                        Log.Console($"reload config {configName} finish!");
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

            Log.Info(" EventSystem.Instance.ToString: 1");
            Log.Info(EventSystem.Instance.ToString());
            Log.Info(TimerComponent.Instance.ToString());
            Log.Info(ObjectPool.Instance.ToString());
            Log.Info(" EventSystem.Instance.ToString: 2");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
