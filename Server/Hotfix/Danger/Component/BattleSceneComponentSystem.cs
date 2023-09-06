using System;

namespace ET
{


    [ObjectSystem]
    public class BattleSceneComponentAwakeSystem : AwakeSystem<BattleSceneComponent>
    {
        public override void Awake(BattleSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public class BattleSceneComponentDestroySystem : DestroySystem<BattleSceneComponent>
    {
        public override void Destroy(BattleSceneComponent self)
        {
            self.BattleInfos.Clear();
        }
    }

    public static class BattleSceneComponentSystem
    {
       
        public static void OnZeroClockUpdate(this BattleSceneComponent self)
        {
            LogHelper.LogWarning("Battle:  OnZeroClockUpdate", true);
            Log.Console("Battle:  OnZeroClockUpdate");
        }

        public static void  OnBattleOpen(this BattleSceneComponent self)
        {
            self.BattleOpen = true;
            Log.Console("Battle:  OnBattleOpen");
            LogHelper.LogWarning($"OnBattleOpen : {self.DomainZone()}", true);
            if (DBHelper.GetOpenServerDay(self.DomainZone()) > 0)
            {
                long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.BattleOpen });
            }
        }

        public static async ETTask OnBattleOver(this BattleSceneComponent self)
        {
            self.BattleOpen = false;
            Log.Console("Battle:  OnBattleOver");
            LogHelper.LogDebug($"OnBattleOver : {self.DomainZone()}");
            long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
            MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.BattleOver });

            await TimerComponent.Instance.WaitAsync(self.DomainZone());
            for (int i = 0; i < self.BattleInfos.Count;i++)
            {
                Scene scene = Game.Scene.Get(self.BattleInfos[i].FubenId);
                await scene.GetComponent<BattleDungeonComponent>().OnBattleOver(self.BattleInfos[i]);
                await TimerComponent.Instance.WaitAsync(60000 + RandomHelper.RandomNumber(0, 1000));
                TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
            }
            self.BattleInfos.Clear();
        }

        public static (long ,int) GetBattleInstanceId(this BattleSceneComponent self, long unitid, int sceneId)
        {
            if (!self.BattleOpen)
            {
                return (0, 0);
            }

            int camp = 0;
            BattleInfo battleInfo = null;
            for (int i = 0; i < self.BattleInfos.Count; i++)
            {
                battleInfo = self.BattleInfos[i];
                if (battleInfo.SceneId != sceneId)
                {
                    continue;
                }
                if (battleInfo.Camp1Player.Contains(unitid))
                {
                    return (battleInfo.FubenInstanceId, 1);
                }
                if (battleInfo.Camp2Player.Contains(unitid))
                {
                    return (battleInfo.FubenInstanceId, 2);
                }

                if (battleInfo.PlayerNumber < ComHelp.GetPlayerLimit(sceneId))
                {
                    battleInfo.PlayerNumber++;
                    camp = battleInfo.PlayerNumber % 2 + 1;
                    if (camp == 1)
                    {
                        battleInfo.Camp1Player.Add(unitid);
                    }
                    else
                    {
                        battleInfo.Camp2Player.Add(unitid);
                    }
                    return (battleInfo.FubenInstanceId, camp);
                }
            }
            
            //动态创建副本
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, self.DomainZone(), "Battle" + fubenid.ToString(), SceneType.Fuben);
            fubnescene.AddComponent<BattleDungeonComponent>().SendReward = false;
            fubnescene.GetComponent<BattleDungeonComponent>().BattleOpenTime = TimeHelper.ServerNow();
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Battle, sceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(sceneId).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            fubnescene.AddComponent<YeWaiRefreshComponent>().SceneId = sceneId;
            FubenHelp.CreateNpc(fubnescene, sceneId);
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonster);
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(sceneId).CreateMonsterPosi);
            battleInfo = self.AddChild<BattleInfo>();
            battleInfo.FubenId = fubenid;
            battleInfo.PlayerNumber = 0;
            battleInfo.FubenInstanceId = fubenInstanceId;
            battleInfo.SceneId = sceneId;

            battleInfo.PlayerNumber++;
            camp = battleInfo.PlayerNumber % 2 + 1;
            if (camp == 1)
            {
                battleInfo.Camp1Player.Add(unitid);
            }
            else
            {
                battleInfo.Camp2Player.Add(unitid);
            }

            self.BattleInfos.Add(battleInfo);
            return (battleInfo.FubenInstanceId, camp);
        }
    }
}
