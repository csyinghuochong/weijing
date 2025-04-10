using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public class Recharge_RechargeScene : AEvent<EventType.RechargeScene>
    {

        protected override void Run(EventType.RechargeScene args)
        {
            Scene scene = args.DomainScene;

            scene.AddComponent<ReChargeWXComponent>();
            scene.AddComponent<ReChargeQDComponent>();
            scene.AddComponent<ReChargeAliComponent>();
            scene.AddComponent<ReChargeIOSComponent>();
            scene.AddComponent<ReChargeTikTokComponent>();
        }
    }
}
