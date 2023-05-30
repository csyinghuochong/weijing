using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionOperatateHandler : AMActorRpcHandler<Scene, C2U_UnionOperatateRequest, U2C_UnionOperatateResponse>
    {

        protected override async ETTask Run(Scene scene, C2U_UnionOperatateRequest request, U2C_UnionOperatateResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCore.ERR_Union_Not_Exist;
                reply();
                return;
            }

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
                    if (request.UnitId!= dBUnionInfo.UnionInfo.LeaderId)
                    {
                        response.Error = ErrorCore.ERR_IsNotLeader;
                        reply();
                        return;
                    }
                    string[] operatevalue = request.Value.Split('_');
                    if (operatevalue.Length != 2)
                    {
                        response.Error = ErrorCore.ERR_IsNotLeader;
                        reply();
                        return;
                    }

                    long operateid = long.Parse(operatevalue[0]);


                    break;
                default:
                    break;
            }

            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }

    }
}
