using System;
using System.Collections.Generic;
using UnityEngine;
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

        public Action SetHandler = null;
        public int SceneTypeEnum;
        public int TeamId;
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

        public static void OnInitUI(this UIPetMiningFormationComponent self, int sceneType, int teamid, Action action)
        {
            self.TeamId = teamid;
            self.SetHandler = action;
            self.SceneTypeEnum = sceneType;

            UI uipetmingTeam = UIHelper.GetUI( self.ZoneScene(), UIType.UIPetMiningTeam );
            List<long> petposition = uipetmingTeam.GetComponent<UIPetMiningTeamComponent>().PetMingPosition.GetRange(teamid * 9, 9);

            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationSet");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            self.UIPetFormationSet = self.AddChild<UIPetFormationSetComponent, GameObject>(go);

            self.UIPetFormationSet.OnUpdateFormation(self.SceneTypeEnum, petposition, true);
            self.UIPetFormationSet.DragEndHandler = self.RequestFormationSet;
            UICommonHelper.SetParent(go, self.FormationNode);
        }

        public static void RequestFormationSet(this UIPetMiningFormationComponent self, long rolePetInfoId, int toindex, int operateType)
        {
            Log.Debug($"RequestFormationSet: {rolePetInfoId} {toindex} {operateType}");

            toindex = self.TeamId * 9 + toindex;

            UI uipetmingTeam = UIHelper.GetUI(self.ZoneScene(), UIType.UIPetMiningTeam);
            List<long> petposition = uipetmingTeam.GetComponent<UIPetMiningTeamComponent>().PetMingPosition;

            //避免有多个。
            if (operateType != 2)   //互换位置
            {
                return;
            }

            int oldIndex = -1;
            long oldPetid = 0;

            if (petposition[toindex] != 0)
            {
                oldPetid = petposition[toindex];    
            }
            for (int i = 0; i < petposition.Count; i++ )
            {
                if (petposition[i] == rolePetInfoId)
                {
                    oldIndex = i;
                }
            }

            petposition[toindex] = rolePetInfoId;
            petposition[oldIndex] = oldPetid;

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.UIPetFormationSet.OnUpdateFormation(self.SceneTypeEnum, petposition.GetRange(self.TeamId * 9, 9), true);
        }
    }

}