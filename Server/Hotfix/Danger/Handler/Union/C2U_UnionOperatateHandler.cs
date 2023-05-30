using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionOperatateHandler : AMActorRpcHandler<Scene, C2U_UnionOperatateRequest, U2C_UnionOperatateResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionOperatateRequest request, U2C_UnionOperatateResponse response, Action reply)
        {
            UnionSceneComponent unionSceneComponent = scene.GetComponent<UnionSceneComponent>();
            DBUnionInfo dBUnionInfo = await unionSceneComponent.GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCore.ERR_Union_Not_Exist;
                reply();
                return;
            }

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.UnionOperate, request.UnionId))
            {
                //1改名  2改宣言 3任职 
                switch (request.Operatate)
                {
                    case 1:
                        dBUnionInfo.UnionInfo.UnionName = request.Value;
                        break;
                    case 2:
                        dBUnionInfo.UnionInfo.UnionPurpose = request.Value;
                        break;
                    case 3:
                        if (request.UnitId != dBUnionInfo.UnionInfo.LeaderId)
                        {
                            response.Error = ErrorCore.ERR_IsNotLeader;
                            reply();
                            return;
                        }
                        string[] operatevalue = request.Value.Split('_');
                        if (operatevalue.Length != 2)
                        {
                            response.Error = ErrorCore.ERR_ModifyData;
                            reply();
                            return;
                        }
                        long operateid  = long.Parse(operatevalue[0]);
                        int position    = int.Parse(operatevalue[1]);

                        UnionPlayerInfo unionPlayerInfo_1 = unionSceneComponent.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, request.UnitId);
                        if (unionPlayerInfo_1 == null)
                        {
                            response.Error = ErrorCore.ERR_Union_NoPlayer;
                            reply();
                            return;
                        }
                        ///1族长 2副族长  ///3长老
                        if (unionPlayerInfo_1.Position == 0 || unionPlayerInfo_1.Position >= position)
                        {
                            response.Error = ErrorCore.ERR_Union_NoLimits;
                            reply();
                            return;
                        }

                        UnionPlayerInfo unionPlayerInfo_2 = unionSceneComponent.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, operateid);
                        if (unionPlayerInfo_2 == null)
                        {
                            response.Error = ErrorCore.ERR_Union_NoPlayer;
                            reply();
                            return;
                        }
                        if (unionPlayerInfo_2.Position != 0 && unionPlayerInfo_2.Position < position)
                        {
                            response.Error = ErrorCore.ERR_Union_NoLimits;
                            reply();
                            return;
                        }

                        unionPlayerInfo_2.Position = position;
                        break;
                    default:
                        break;
                }

                DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            }
            reply();
            await ETTask.CompletedTask;
        }

    }
}
