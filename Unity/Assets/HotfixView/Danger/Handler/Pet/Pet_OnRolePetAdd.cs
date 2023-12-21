using UnityEngine;

namespace ET
{
    [Event]
    public class Pet_OnRolePetAdd : AEventClass<EventType.RolePetAdd>
    {
        protected override void Run(object cls)
        {
            EventType.RolePetAdd args = cls as EventType.RolePetAdd;
            RunAnsyc(args).Coroutine();
        }

        private async ETTask RunAnsyc(EventType.RolePetAdd args)
        {
            if (args.ZoneScene.GetComponent<BattleMessageComponent>().ShowPetChouKaGet)
            {
                args.ZoneScene.GetComponent<BattleMessageComponent>().RolePetAdds.Add(args);
            }
            else
            {
                args.ZoneScene.GetComponent<BattleMessageComponent>().ShowPetChouKaGet = true;
                UI uI = await UIHelper.Create(args.ZoneScene, UIType.UIPetChouKaGet);
                uI.GetComponent<UIPetChouKaGetComponent>().OnInitUI(args.RolePetInfo, args.OldPetSkin);
            }
        }
    }
}
