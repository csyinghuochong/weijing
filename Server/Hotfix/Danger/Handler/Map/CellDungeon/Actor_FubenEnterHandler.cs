using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_FubenEnterHandler : AMActorLocationRpcHandler<Unit, Actor_EnterFubenRequest, Actor_EnterFubenResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_EnterFubenRequest request, Actor_EnterFubenResponse response, Action reply)
        {
			CellDungeonInfo curCell = null;
			CellDungeonComponent fubenComponent = null;
			unit.GetComponent<MoveComponent>().Stop();
			unit.GetComponent<UserInfoComponent>().UpdateRoleData(  UserDataType.PiLao, "-1");
			FubenHelp.EnterCellFuben();

			//首次进入
			if (request.RepeatEnter == 0)
			{
				//动态创建副本
				long fubenid = IdGenerater.Instance.GenerateId();
				long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
				Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Fuben" + fubenid.ToString(), SceneType.Fuben);
				fubenComponent = fubnescene.AddComponent<CellDungeonComponent>();
				fubenComponent.MainUnit = unit;
				fubenComponent.FubenDifficulty = request.Difficulty;
				fubenComponent.InitFubenCell(request.ChapterId);
				curCell = fubenComponent.CurrentFubenCell;
				MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
				mapComponent.SetMapInfo((int)SceneTypeEnum.CellDungeon, request.ChapterId, curCell.sonid);
				mapComponent.NavMeshId = ChapterSonConfigCategory.Instance.Get(curCell.sonid).MapID.ToString();

				TransferHelper.BeforeTransfer(unit);
				await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.CellDungeon, request.ChapterId, curCell.sonid);
			}
			else
			{
				fubenComponent = unit.DomainScene().GetComponent<CellDungeonComponent>();
				fubenComponent.MainUnit = unit;
				CellDungeonComponentSystem.RemoveAllNoSelf(unit);
				fubenComponent.InitFubenCell(request.ChapterId);
				curCell = fubenComponent.CurrentFubenCell;
				ChapterSonConfig chapterSon = ChapterSonConfigCategory.Instance.Get(curCell.sonid);
				MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
				mapComponent.SetSubLevel(curCell.sonid);
				mapComponent.NavMeshId = ChapterSonConfigCategory.Instance.Get(curCell.sonid).MapID.ToString();

				unit.Position = new Vector3(chapterSon.BornPosLeft[0] * 0.01f, chapterSon.BornPosLeft[1] * 0.01f, chapterSon.BornPosLeft[2] * 0.01f);
				unit.Rotation = Quaternion.identity;
				fubenComponent.GenerateFubenScene( false);
				RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
				if (fightId != null)
				{
					UnitFactory.CreatePet(unit, fightId);
				}
				//UnitHelper.BroadcastCreateUnit(unit.DomainScene(), unit);
			}

			fubenComponent.HurtValue = 0;
			fubenComponent.EnterTime = TimeHelper.ServerNow();

			fubenComponent.SonFubenInfo.SonSceneId = curCell.sonid;
			fubenComponent.SonFubenInfo.CurrentCell = fubenComponent.FubenInfo.StartCell;
			fubenComponent.SonFubenInfo.PassableFlag = fubenComponent.GetPassableFlag();
			response.FubenInfo = fubenComponent.FubenInfo;
			response.SonFubenInfo = fubenComponent.SonFubenInfo;

			reply();
			await ETTask.CompletedTask;
        }
    }
}
