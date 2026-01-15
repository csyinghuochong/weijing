using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Player_OnPlayerReLink : AEvent<EventType.PlayerReLink>
    {
        protected override void Run(EventType.PlayerReLink args)
        {
            Session session = args.Session;
            Player player = args.Player;    
            session.AddComponent<SessionPlayerComponent>().PlayerId = player.Id;
            session.GetComponent<SessionPlayerComponent>().PlayerInstanceId = player.InstanceId;
            session.GetComponent<SessionPlayerComponent>().AccountId = args.AccountId;
            player.ClientSession = session;
        }
    }
}
