using System;

namespace ET
{
    public class G2A_ExitGameHandler : AMActorRpcHandler<Scene, G2A_ExitGame, A2G_ExitGame>
    {

        protected override async ETTask Run(Scene scene, G2A_ExitGame request, A2G_ExitGame response, Action reply)
        {
            scene.GetComponent<TokenComponent>().Remove(request.AccountId);
            scene.GetComponent<AccountSessionsComponent>().Remove(request.AccountId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
