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
            UI uiBattleMain = UIHelper.GetUI(args.ZoneScene, UIType.UIPetChouKaGet);
            if (uiBattleMain == null)
            {
                return;
            }
            UI uI = await UIHelper.Create(args.ZoneScene, UIType.UIPetChouKaGet);
            uI.GetComponent<UIPetChouKaGetComponent>().OnInitUI(args.RolePetInfo, args.OldPetSkin, false);
        }
    }
}
