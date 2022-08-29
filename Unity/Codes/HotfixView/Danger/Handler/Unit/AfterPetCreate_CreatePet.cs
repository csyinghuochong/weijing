using UnityEngine;


namespace ET
{

    [Event]
    public class AfterPetCreate_CreatePet : AEventClass<EventType.AfterPetCreate>
    {

        protected override void  Run(object cls)
        {
            RunAsync(cls as EventType.AfterPetCreate);
        }

        private  void  RunAsync(EventType.AfterPetCreate args)
        {
            UICommonHelper.AfterPetCreate(args.Unit).Coroutine();
        }
    }
}
