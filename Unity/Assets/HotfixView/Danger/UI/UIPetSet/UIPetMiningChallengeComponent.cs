using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningChallengeComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
        public GameObject ButtonConfirm;

        public PetMingPlayerInfo PetMingPlayerInfo;
    }

    public class UIPetMiningChallengeComponentAwake : AwakeSystem<UIPetMiningChallengeComponent>
    {
        public override void Awake(UIPetMiningChallengeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetMiningChallenge); });

            self.ButtonConfirm = rc.Get<GameObject>("ButtonConfirm");
            ButtonHelp.AddListenerEx(self.ButtonConfirm , () => { self.OnButtonConfirm();  } );
        }
    }

    public static class UIPetMiningChallengeComponentSystem
    {
        public static void OnInitUI(this UIPetMiningChallengeComponent self, PetMingPlayerInfo petMingPlayerInfo)
        { 
            self.PetMingPlayerInfo = petMingPlayerInfo;  
        }

        public static   void OnButtonConfirm(this UIPetMiningChallengeComponent self)
        {
            Scene zoneScene = self.ZoneScene();
            int sceneid = BattleHelper.GetSceneIdByType( SceneTypeEnum.PetMing );
            int mineType = 1;
            int minePos = 0;
            int teamId = 0; 
            EnterFubenHelp.RequestTransfer(zoneScene, SceneTypeEnum.PetMing, sceneid, mineType, $"{minePos}_{teamId}").Coroutine();
            UIHelper.Remove( zoneScene, UIType.UIPetMiningChallenge );
        }

    }
}