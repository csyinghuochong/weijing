using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_StopResultHandler : AMActorLocationHandler<Unit, C2M_StopResult>
    {
        protected override async ETTask Run(Unit unit, C2M_StopResult message)
        {
            Vector3 curpos = new Vector3(message.X, message.Y, message.Z);
            float dis = Vector3.Distance(curpos, unit.Position);
            //Console.WriteLine($"dis： {dis}   x1_x2:{unit.Position.x} {message.X}  z1_z2:{unit.Position.z}  {message.Z}");
            if (dis > 1f)
            {
                //unit.GetComponent<MoveComponent>().MoveToAsync
                unit.Position = curpos;     
            }
            unit.StopResult(curpos, 0);
            await ETTask.CompletedTask;
        }
    }
}