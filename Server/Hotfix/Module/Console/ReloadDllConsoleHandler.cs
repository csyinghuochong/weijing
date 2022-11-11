using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ConsoleHandler(ConsoleMode.ReloadDll)]
    public class ReloadDllConsoleHandler: IConsoleHandler
    {
        public async ETTask Run(ModeContex contex, string content)
        {
            switch (content)
            {
                case ConsoleMode.ReloadDll:
                    contex.Parent.RemoveComponent<ModeContex>();

                    //Game.EventSystem.Add(DllHelper.GetHotfixAssembly());
                    //Game.EventSystem.Load();

                    List<StartProcessConfig> listprogress = StartProcessConfigCategory.Instance.GetAll().Values.ToList();
                    Log.Debug("C2M_Reload_a: listprogress " + listprogress.Count);
                    for (int i = 0; i < listprogress.Count; i++)
                    {
                        List<StartSceneConfig> processScenes = StartSceneConfigCategory.Instance.GetByProcess(listprogress[i].Id);
                        if (processScenes.Count == 0)  //listprogress[i].Id == 203 203机器人
                        {
                            continue;
                        }

                        StartSceneConfig startSceneConfig = processScenes[0];
                        Log.Debug("C2M_Reload_a: processScenes " + startSceneConfig);
                        long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(startSceneConfig.Zone, startSceneConfig.Name).InstanceId;
                        A2M_Reload createUnit = (A2M_Reload)await ActorMessageSenderComponent.Instance.Call(
                            mapInstanceId, new M2A_Reload() { LoadType = 0, LoadValue = "0" });
                    }
                    break;
            }
            
            await ETTask.CompletedTask;
        }
    }
}