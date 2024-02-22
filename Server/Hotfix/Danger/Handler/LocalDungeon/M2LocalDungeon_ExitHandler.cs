using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2LocalDungeon_ExitHandler : AMActorRpcHandler<Scene, M2LocalDungeon_ExitRequest, LocalDungeon2M_ExitResponse>
    {

        private async ETTask CloseBattleFubenScene(Scene fubenscene, M2LocalDungeon_ExitRequest request)
        {
            Console.WriteLine($"M2LocalDungeon_Exit:  {fubenscene.Name}  {request.Camp1Player.Count}  {request.Camp2Player.Count}   {fubenscene.DomainZone()} ");
            fubenscene.GetComponent<BattleDungeonComponent>().OnBattleOver(request.Camp1Player, request.Camp2Player);
            await fubenscene.GetComponent<BattleDungeonComponent>().KickOutPlayer();
            await TimerComponent.Instance.WaitAsync(60000 + RandomHelper.RandomNumber(0, 1000));
            TransferHelper.NoticeFubenCenter(fubenscene, 2).Coroutine();
            fubenscene.Dispose();
        }

        protected override async ETTask Run(Scene scene, M2LocalDungeon_ExitRequest request, LocalDungeon2M_ExitResponse response, Action reply)
        {
            switch (request.SceneType)
            {
                case SceneTypeEnum.Battle:
                    Scene fubenscene = Game.Scene.Get(request.FubenId);
                    CloseBattleFubenScene(fubenscene, request).Coroutine();
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
