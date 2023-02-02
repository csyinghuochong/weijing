using System;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_FubenEnterSonHandler : AMActorLocationRpcHandler<Unit, Actor_EnterSonFubenRequest, Actor_EnterSonFubenResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_EnterSonFubenRequest request, Actor_EnterSonFubenResponse response, Action reply)
        {
            unit.GetComponent<MoveComponent>().Stop();
            unit.GetComponent<SkillManagerComponent>().OnDispose();
            CellDungeonComponent fubenComponent = unit.DomainScene().GetComponent<CellDungeonComponent>();
            CellDungeonInfo fubenCellInfoCurt = fubenComponent.GetByCellIndex(request.CurrentCell);
            fubenCellInfoCurt.pass = true;
            CellDungeonInfo fubenCellInfoNext = fubenComponent.GetNextSonCell(request.CurrentCell, request.DirectionType);
            fubenComponent.CurrentFubenCell = fubenCellInfoNext;
            if (!fubenCellInfoNext.pass)
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.PiLao, "-1");
            }

            SonFubenInfo enterFubenInfo = new SonFubenInfo();
            enterFubenInfo.SonSceneId = fubenCellInfoNext.sonid;
            enterFubenInfo.PassableFlag = fubenComponent.GetPassableFlag();
            enterFubenInfo.CurrentCell = fubenComponent.GetCellIndex(fubenCellInfoNext.row, fubenCellInfoNext.line);
            response.SonFubenInfo = enterFubenInfo;

            int sonid = fubenCellInfoNext.sonid;
            unit.DomainScene().GetComponent<MapComponent>().SetSubLevel(sonid);
            unit.DomainScene().GetComponent<MapComponent>().NavMeshId = ChapterSonConfigCategory.Instance.Get(sonid).MapID.ToString();

            unit.GetComponent<PathfindingComponent>().Update(ChapterSonConfigCategory.Instance.Get(sonid).MapID.ToString());
            Game.Scene.GetComponent<RecastPathComponent>().Update(ChapterSonConfigCategory.Instance.Get(sonid).MapID);

            ChapterSonConfig chapterSon = ChapterSonConfigCategory.Instance.Get(sonid);

            //更新unit出生点坐标
            int[] borpos;
            if (request.DirectionType == 1)
                borpos = chapterSon.BornPosDwon;
            else if (request.DirectionType == 2)
                borpos = chapterSon.BornPosRight;
            else if (request.DirectionType == 3)
                borpos = chapterSon.BornPosUp;
            else
                borpos = chapterSon.BornPosLeft;

            unit.Position = new Vector3(borpos[0] * 0.01f, borpos[1] * 0.01f, borpos[2] * 0.01f);
            unit.Rotation = Quaternion.identity;

            CellDungeonComponentSystem.RemoveAllNoSelf(unit);

            RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
            if (fightId != null)
            {
                UnitFactory.CreatePet(unit, fightId);
            }

            //创建副本内的各种Unit
            fubenComponent.GenerateFubenScene( fubenCellInfoNext.pass);

            //自己通知给周围人
            //UnitHelper.BroadcastCreateUnit(unit.DomainScene(), unit);

            reply();
            await ETTask.CompletedTask;
        }

    }
}
