using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace ET
{

    public class UIPetMiningFormationComponent : Entity, IAwake
    {
        public GameObject CloseButton;
        public GameObject ButtonChallenge;
        public GameObject TextNumber;
        public GameObject FormationNode;
        public GameObject ButtonConfirm;

        public GameObject IconItemDrag;
        public UIPetFormationSetComponent UIPetFormationSet;
        public List<UIPetFormationItemComponent> uIPetFormations = new List<UIPetFormationItemComponent>();
        public List<long> PetTeamList = new List<long>() { };

        public Action SetHandler = null;
        public int SceneTypeEnum;
    }

    public class UIPetMiningFormationComponentAwake : AwakeSystem<UIPetMiningFormationComponent>
    {
        public override void Awake(UIPetMiningFormationComponent self)
        {
            self.SetHandler = null;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.uIPetFormations.Clear();
            self.ButtonChallenge = rc.Get<GameObject>("ButtonChallenge");
            self.TextNumber = rc.Get<GameObject>("TextNumber");
            self.FormationNode = rc.Get<GameObject>("FormationNode");
            self.ButtonConfirm = rc.Get<GameObject>("ButtonConfirm");
            self.IconItemDrag = rc.Get<GameObject>("IconItemDrag");
            self.CloseButton = rc.Get<GameObject>("CloseButton");
            self.IconItemDrag.SetActive(false);
            self.PetTeamList.Clear();

            ButtonHelp.AddListenerEx(self.ButtonConfirm, () => { self.OnButtonConfirm().Coroutine(); });
            ButtonHelp.AddListenerEx(self.ButtonChallenge, () => { self.OnButtonChallenge(); });
            self.CloseButton.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UIPetMiningFormation);
            });
        }
    }

    public static class UIPetMiningFormationComponentSystem
    {

        public static async ETTask OnButtonConfirm(this UIPetMiningFormationComponent self)
        {
            await ETTask.CompletedTask;
        }

        public static void OnButtonChallenge(this UIPetMiningFormationComponent self)
        { 
            
        }

    }

}