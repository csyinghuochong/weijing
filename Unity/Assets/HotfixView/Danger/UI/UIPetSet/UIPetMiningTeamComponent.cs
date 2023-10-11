using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningTeamComponent : Entity, IAwake
    {
        public GameObject ButtonClose;

    }

    public class UIPetMiningTeamComponentAwake : AwakeSystem<UIPetMiningTeamComponent>
    {
        public override void Awake(UIPetMiningTeamComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetMiningTeam ); });
        }
    }
}