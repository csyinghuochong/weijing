using System;

namespace ET
{
    public class G2A_ExitGameHandler : AMActorRpcHandler<Scene, G2A_ExitGame, A2G_ExitGame>
    {

        /// <summary>
        /// KickPlayer
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <param name="reply"></param>
        /// <returns></returns>
        protected override async ETTask Run(Scene scene, G2A_ExitGame request, A2G_ExitGame response, Action reply)
        {
            //if (MongoHelper.KeepSession)
            //{
            //    return;
            //}
            //scene.GetComponent<TokenComponent>().Remove(request.AccountId);
            //Log.Console($"G2A_ExitGame: {request.AccountId}");
            scene.GetComponent<AccountSessionsComponent>().Remove(request.AccountId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
