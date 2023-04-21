using UnityEngine;

namespace ET
{
    [Event]
    public class Login_OnRelinkSucess : AEventClass<EventType.RelinkSucess>
    {
        protected override void Run(object cls)
        {
            EventType.RelinkSucess asa = (cls as EventType.RelinkSucess);
            asa.ZoneScene.GetComponent<RelinkComponent>().OnRelinkSucess().Coroutine();
        }
    }
}
